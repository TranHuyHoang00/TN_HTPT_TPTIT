using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace HTPT
{
    public partial class FrmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoiCSDLGoc() == 0) return;
            LayDSPM();
            cbCoSo.SelectedIndex = 1; cbCoSo.SelectedIndex = 0;
        }
        private void LayDSPM()
        {
            String cmd = "SELECT * FROM Get_Subscribes";
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            Program.bds_dspm.DataSource = dt;
            conn_publisher.Close();
            cbCoSo.DataSource = Program.bds_dspm;
            cbCoSo.DisplayMember = "TENCS"; //co so 1-2
            cbCoSo.ValueMember = "TENSERVER"; //DESKTOP-ID9RBP3\MSSQLSERVER01 
            conn_publisher.Close();
        }
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private int KetNoiCSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publiser;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi kết nối về CSDL gốc.\nBạn xem lại tên server của publiser, và tên CSDL trong chuối kết nối.\n" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }
        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e) ///  ?
        {
            try
            {
                Program.servername = cbCoSo.SelectedValue.ToString(); ////
            }
            catch (Exception) { }
        }
        //// ĐĂNG NHẬP
        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            if (tbTaiKhoan.Text.Trim() == "")
            {
                if (checkBoxSV.Checked)
                    XtraMessageBox.Show("Mã sinh viên không được trống", "", MessageBoxButtons.OK);
                else
                    XtraMessageBox.Show("Tài khoản không được trống", "", MessageBoxButtons.OK);
                tbTaiKhoan.Focus();
                return;
            }

            if (tbMatKhau.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mật khẩu không được trống", "", MessageBoxButtons.OK);
                tbMatKhau.Focus();
                return;
            }

            if (checkBoxSV.Checked)
            {
                Program.mlogin = Program.svLogin;
                Program.password = Program.svPassword;
            }
            else
            {
                Program.mlogin = tbTaiKhoan.Text;
                Program.password = tbMatKhau.Text;
            }
            // Đăng nhập thất bại
            if (Program.KetNoi() == 0) return;

            Program.mCoSo = cbCoSo.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            if (checkBoxSV.Checked) Program.mSV = tbTaiKhoan.Text.Trim();

            string strLenh;
            if (checkBoxSV.Checked == false)
            {
                strLenh = "EXEC SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'"; //MAGV ,HOTEN,NHOM
            }
            else
            {
                String sql = "EXEC SP_GET_PASSWORD_FROM_MASV N'" + Program.mSV + "'"; //pass
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    if (Program.myReader == null) return;

                    Program.myReader.Read();
                    String hashPass = Program.myReader.GetString(0);
                    if (hashPass.Equals(""))
                    {
                        XtraMessageBox.Show("Mã sinh viên hoặc mật khẩu sai, vui lòng xem lại !", "", MessageBoxButtons.OK);
                        return;
                    }
                    //bool verified = BCrypt.Net.BCrypt.Verify(tbMatKhau.Text.Trim(), hashPass); // so sánh 2 cái

                    if (hashPass == tbMatKhau.Text.Trim())
                    {
                        strLenh = "EXEC SP_Lay_Thong_Tin_SV_Tu_Login  '" + Program.mSV + "'"; //MASV,HOTEN,NHOM
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã sinh viên hoặc mật khẩu sai, vui lòng xem lại !", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Mã sinh viên hoặc mật khẩu sai, vui lòng xem lại !", "", MessageBoxButtons.OK);
                    return;
                }
                finally
                {
                    Program.myReader.Close();
                }
            }
            if (strLenh.Equals("")) return;
            //Thực hiện sp
            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Convert.IsDBNull(Program.myReader.GetString(1))) // k trả về rỗng
            {
                XtraMessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Program.username = Program.myReader.GetString(0);
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);

                Program.myReader.Close();
                Program.conn.Close();

                if (checkBoxSV.Checked == true)
                {
                    Program.frmChinh.MASVGV.Text = "Mã số : " + Program.username;
                    Program.frmChinh.HOTEN.Text = "Họ tên : " + Program.mHoten;
                    Program.frmChinh.NHOM.Text = "Nhóm : " + Program.mGroup;
                    Program.frmChinh.HienThiMenu();
                }
                else
                {
                    Program.frmChinh.MASVGV.Text = "Mã số : " + Program.username;
                    Program.frmChinh.HOTEN.Text = "Họ tên : " + Program.mHoten;
                    Program.frmChinh.NHOM.Text = "Nhóm : " + Program.mGroup;
                    Program.frmChinh.HienThiMenu();
                }
                this.Close();
            }
        }
        //// CKECK BOX SINHVIEN
        private void checkBoxSV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSV.Checked == true)
            {
                labelTaiKhoan.Text = "Mã SV";
            }
            else
            {
                labelTaiKhoan.Text = "Tài khoản";
            }
        }
        //// Thoát
        private void bntThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
