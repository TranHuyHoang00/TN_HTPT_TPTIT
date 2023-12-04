using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTPT
{
    public partial class FrmThi : Form
    {
        public static int id_dangkythi;
        public static string maMH = "";
        public static string trinhDo = "";
        public static int lan;
        public static string maLop = "";
        public static string tenLop = "";
        public static int thoiGian;
        public static int soCau;
        public static int soCauCS1;
        public static int soCauCS2;
        private static int soCauDung = 0;
        private static double diem = 0.0;
        public static CauHoi[] listCauHoi;
        public static DateTime ngaythi;
        private int s = 1;
        public FrmThi()
        {
            InitializeComponent();
        }
        private void FrmThi_Load(object sender, EventArgs e)
        {
            txtMaMon.Text = maMH;
            txtTrinhDo.Text = trinhDo;
            txtLan.Text = lan.ToString();
            dateNgayThi.Text = ngaythi.ToString();
            txtThoiGian.Text = thoiGian.ToString();
            txtSoCau.Text = soCau.ToString();
            gbInfoSV.Visible = false;

            MaGVSV.Text = "Mã số: " + Program.username; ;
            HoTen.Text = "Họ tên: " + Program.mHoten;
            Nhom.Text = "Nhóm: " + Program.mGroup;

            if (Program.mGroup == "SINHVIEN")
            {
                gbInfoSV.Visible = true;
                txtHoTen.Text = Program.mHoten;
                txtMaSV.Text = Program.username;
                txtMaLop.Text = maLop;
                txtTenLop.Text = tenLop;
            }
            labelTime.Visible = false;
            btnNop.Visible = false;
           loadCauHoi();
        }
        private void loadCauHoi()
        {
            String sql = "exec SP_LAY_CAU_HOI N'"
                    + maMH + "',N'"
                    + trinhDo + "', " + soCauCS1 + ", " + soCauCS2;
            try
            {
                DataTable thi = Program.ExecSqlDataTable(sql);
                if (thi.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không thể lấy được đề thi, thiếu đề", "", MessageBoxButtons.OK);
                    return;
                }
                labelTime.Visible = true;
                labelTime.Text = thoiGian.ToString() + " : 00";
                timer1.Start();
                btnNop.Visible = true;
                bdsDeThi.DataSource = thi;

                listCauHoi = new CauHoi[soCau];
                for (int i = 0; i < listCauHoi.Length; i++)
                {
                    listCauHoi[i] = new CauHoi();
                    if (((DataRowView)bdsDeThi[i])["MALCH"].ToString().Trim().Equals("LCH2"))
                    {
                        try
                        {
                            String sql1 = "exec SP_LAY_LUA_CHON " + (int)((DataRowView)bdsDeThi[i])["MACH"];
                            DataTable tb = Program.ExecSqlDataTable(sql1);
                            bdsLuaChon.DataSource = tb;
                            for (int j = 0; j < tb.Rows.Count; j++)
                            {
                                LuaChon lc = new LuaChon(listCauHoi[i]);
                                lc.NoiDung = ((DataRowView)bdsLuaChon[j])["NOIDUNG"].ToString();
                                lc.DapAn = ((DataRowView)bdsLuaChon[j])["THUTU"].ToString();
                                lc.ThuTu = ((DataRowView)bdsLuaChon[j])["THUTU"].ToString();
                                listCauHoi[i].flowLC.Controls.Add(lc);
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Lỗi " + e.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    if (((DataRowView)bdsDeThi[i])["MALCH"].ToString().Trim().Equals("LCH1"))
                    {
                        LuaChon1 lc1 = new LuaChon1(listCauHoi[i]);
                        listCauHoi[i].flowLC.Controls.Add(lc1);
                    }

                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].IdCauHoi = (int)((DataRowView)bdsDeThi[i])["MACH"];
                    listCauHoi[i].NoiDung = ((DataRowView)bdsDeThi[i])["NOIDUNG"].ToString();
                    listCauHoi[i].DapAn = ((DataRowView)bdsDeThi[i])["DAPAN"].ToString();
                    listCauHoi[i].DaChon = "";
                    flowDeThi.Controls.Add(listCauHoi[i]);
                    String[] arr = new string[2];
                    arr[0] = "Câu " + (i + 1);
                    arr[1] = listCauHoi[i].DaChon;
                    ListViewItem item = new ListViewItem(arr);
                    listViewDAChon.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void ghiDiemBaiThi()
        {
            DataTable dt = new DataTable();
            //Tạo column cho dt
            dt.Columns.Add(new DataColumn("MACH", typeof(int)));
            dt.Columns.Add(new DataColumn("DAP_AN_CHON", typeof(string)));
            // add dữ liệu bài thi trên lưới vào dt
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                dt.Rows.Add( listCauHoi[i].IdCauHoi, listCauHoi[i].DaChon);
            }
            // Thiết lập tên, kiểu
            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_CT_BAITHI"; // 
            para.ParameterName = "@BAITHI";
            para.Value = dt; // Truyền dữ liệu từ dt vào para
            // GHi dữ liệu từ para vào table CT_BAITHI trên SQL thông qua SP
            Program.conn.Open();
            SqlCommand sqlcom = new SqlCommand("SP_INSERT_THI", Program.conn);
            sqlcom.Parameters.Clear();
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add(para);
            sqlcom.Parameters.Add("@ID_DANGKYTHI", SqlDbType.SmallInt);
            sqlcom.Parameters.Add("@MASV", SqlDbType.Char, 8);
            sqlcom.Parameters.Add("@DIEM", SqlDbType.Float);
            sqlcom.Parameters["@ID_DANGKYTHI"].Value = id_dangkythi;
            sqlcom.Parameters["@MASV"].Value = Program.username;
            sqlcom.Parameters["@DIEM"].Value = diem;
            try
            {
                sqlcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi điểm bài thi " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == 0)
            {
                if (thoiGian != 0)
                {
                    thoiGian--;
                    s = 59; 
                }
            }
            labelTime.Text = thoiGian.ToString() + " : " + s.ToString();
            if (thoiGian == 0 && s == 0)
            {
                timer1.Stop();
                XtraMessageBox.Show("Đã hết thời gian thi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNop.Enabled = false;
                tinhdiem();
                // Nếu là sinhvien thì ghi điểm
                if (Program.mGroup == "SINHVIEN")
                {
                    //ghiDiemBaiThi();
                }
                btnNop.Visible = false;
                flowDeThi.Controls.Clear();
                // gán dữ liệu sang FrmKQThi
                FrmKQThi.socau = soCau;
                FrmKQThi.diem = diem;
                FrmKQThi.soCauDung = soCauDung;
                FrmKQThi.maMH = maMH;
                FrmKQThi.thoiGian = thoiGian;
                FrmKQThi.trinhDo = trinhDo;
                FrmKQThi.lan = lan;
                FrmKQThi.ngayThi = dateNgayThi.DateTime.ToString();
                FrmKQThi.maLop = maLop;
                FrmKQThi.tenLop = tenLop;
                this.Close();

                Program.frmKQThi = new FrmKQThi();
                Program.frmKQThi.Activate();
                Program.frmKQThi.Show();
            }
        }
        private void tinhdiem()
        {
            soCauDung = 0;
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (listCauHoi[i].DaChon.Trim().CompareTo(listCauHoi[i].DapAn.Trim()) == 0)
                    soCauDung++;
            }
            if (soCauDung == 0) diem = 0;
            else diem = Math.Round((double)(10 * soCauDung) / soCau, 2);
        }
        private void btnNop_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn nộp bài", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                timer1.Stop();
                tinhdiem();
                if (Program.mGroup == "SINHVIEN") 
                {
                    ghiDiemBaiThi();
                }
                btnNop.Visible = false;
                flowDeThi.Controls.Clear();
                FrmKQThi.socau = soCau;
                FrmKQThi.diem = diem;
                FrmKQThi.soCauDung = soCauDung;
                FrmKQThi.maMH = maMH;
                FrmKQThi.thoiGian = thoiGian;
                FrmKQThi.trinhDo = trinhDo;
                FrmKQThi.lan = lan;
                FrmKQThi.ngayThi = dateNgayThi.DateTime.ToString();
                FrmKQThi.maLop = maLop;
                FrmKQThi.tenLop = tenLop;
                this.Close();

                Program.frmKQThi = new FrmKQThi();
                Program.frmKQThi.Activate();
                Program.frmKQThi.Show();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn chưa nộp bài thi, nhấn OK để nộp bài", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
            {
                timer1.Stop();
                tinhdiem();
                if (Program.mGroup == "SINHVIEN")
                {
                    ghiDiemBaiThi();
                }
                btnNop.Visible = false;
                flowDeThi.Controls.Clear();
                FrmKQThi.socau = soCau;
                FrmKQThi.diem = diem;
                FrmKQThi.soCauDung = soCauDung;
                FrmKQThi.maMH = maMH;
                FrmKQThi.thoiGian = thoiGian;
                FrmKQThi.trinhDo = trinhDo;
                FrmKQThi.lan = lan;
                FrmKQThi.ngayThi = dateNgayThi.DateTime.ToString();
                FrmKQThi.maLop = maLop;
                FrmKQThi.tenLop = tenLop;
                this.Close();

                Program.frmKQThi = new FrmKQThi();
                Program.frmKQThi.Activate();
                Program.frmKQThi.Show();
            }
            else this.Close();
        }
    }
}
