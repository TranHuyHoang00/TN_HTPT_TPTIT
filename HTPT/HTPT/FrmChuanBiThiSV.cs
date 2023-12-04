using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace HTPT
{
    public partial class FrmChuanBiThiSV : Form
    {
        public FrmChuanBiThiSV()
        {
            InitializeComponent();
        }
        private SqlConnection conn_publisher = new SqlConnection();
        private void FrmChuanBiThiSV_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            txtMaSV.Text = Program.username.Trim();
            txtHoTen.Text = Program.mHoten.Trim();
            String sql1 = "EXEC SP_GET_LICH_THI_HT N'" + Program.username.Trim() + "'";
            String sql = "SELECT LOP.MALOP, TENLOP FROM dbo.LOP JOIN dbo.SINHVIEN " +
                   "ON SINHVIEN.MALOP = LOP.MALOP WHERE MASV = N'" + Program.username + "'";
            try
            {
                DataTable dt = Program.ExecSqlDataTable(sql1);
                if (dt.Rows.Count > 0)
                {
                    gcGVDK.DataSource = dt;
                }
                Program.myReader = Program.ExecSqlDataReader(sql);
                if (Program.myReader != null)
                {
                    Program.myReader.Read();
                    txtMaLop.Text = Program.myReader.GetString(0).Trim();
                    txtTenLop.Text = Program.myReader.GetString(1).Trim();

                }
               

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.myReader.Close();
                Program.conn.Close();
            }
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            if (gcGVDK.MainView is GridView gridView)
            {
                int rowCount = gridView.RowCount;
                if (rowCount == 0)
                {
                    MessageBox.Show("Không có kỳ thi nào.");
                }else
                {

                    String maMH = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MAMH").ToString().Trim();
                    int lan = Int32.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "LAN").ToString().Trim());
                    if (lan == 2)
                    {
                        String ktlan1 = "exec SP_KT_Lan_Thi N'"
                                           + Program.username + "', N'"
                                           + maMH + "', "
                                           + 1;
                        try
                        {
                            Program.myReader = Program.ExecSqlDataReader(ktlan1);
                            if (Program.myReader == null) return;
                            Program.myReader.Read();
                            String kq = Program.myReader.GetString(0);
                            Program.myReader.Close();
                            if (kq.Equals("0"))
                            {
                                XtraMessageBox.Show("Sinh viên chưa thi lần một, không thể thi lần hai", "", MessageBoxButtons.OK);
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi " + ex.Message, "", MessageBoxButtons.OK);
                            Program.myReader.Close();
                        }
                    }
                    String ktlan = "exec SP_KT_Lan_Thi N'"
                   + Program.username + "', N'"
                   + maMH + "', "
                   + lan;
                    try
                    {

                        Program.myReader = Program.ExecSqlDataReader(ktlan);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();

                        String kq = Program.myReader.GetString(0);
                        Program.myReader.Close();

                        if (kq.Equals("1"))
                        {
                            XtraMessageBox.Show("Sinh viên đã thi lần này, không được thi lại", "", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            FrmThi.id_dangkythi = Int32.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_DANGKYTHI").ToString().Trim());
                            FrmThi.maMH = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MAMH").ToString().Trim();
                            FrmThi.trinhDo = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TRINHDO").ToString().Trim();
                            FrmThi.lan = Int32.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "LAN").ToString().Trim());
                            FrmThi.maLop = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MALOP").ToString().Trim();
                            FrmThi.ngaythi = Convert.ToDateTime(gridView.GetRowCellValue(gridView.FocusedRowHandle, "NGAYTHI"));
                            FrmThi.thoiGian = Int32.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "THOIGIAN").ToString().Trim());
                            FrmThi.soCau = Int32.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "SOCAUTHI").ToString().Trim());
                            FrmThi.soCauCS1 = Int32.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "CAUHOI_CS1").ToString().Trim());
                            FrmThi.soCauCS2 = Int32.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "CAUHOI_CS2").ToString().Trim());
                            FrmThi.tenLop = txtTenLop.Text.Trim();
                            this.Close();
                            Program.frmThi = new FrmThi();
                            Program.frmThi.Activate();
                            Program.frmThi.Show();
                            this.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi " + ex.Message, "", MessageBoxButtons.OK);
                        Program.myReader.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có kỳ thi nào");
            }
      
                
               
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
