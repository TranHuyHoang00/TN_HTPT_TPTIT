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

namespace HTPT
{
    public partial class FrmDangKyThi : Form
    {
        private Boolean isThem = false;
        private Boolean isSua = false;
        private String maCS = "";
        public FrmDangKyThi()
        {
            InitializeComponent();
        }

        private void FrmDangKyThi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.tbThi.Connection.ConnectionString = Program.connstr;
            this.tbThi.Fill(this.DS.THI);
            this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
            this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
            this.tbLop.Connection.ConnectionString = Program.connstr;
            this.tbLop.Fill(this.DS.LOP);
            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.DS.MONHOC);
            this.tbGetPGV.Connection.ConnectionString = Program.connstr;
            this.tbGetPGV.Fill(this.DS.SP_GET_PGV);
            this.tbGetGV.Connection.ConnectionString = Program.connstr;
            this.tbGetGV.Fill(this.DS.SP_GET_GV);
            if (bdsDangKyThi.Count > 0)
            {
                cbbLanThi.Text = ((DataRowView)this.bdsDangKyThi.Current).Row["LAN"].ToString();
                cbbTrinhDo.Text = ((DataRowView)this.bdsDangKyThi.Current).Row["TRINHDO"].ToString();
            }
            if (Program.mGroup == "KHOA")
            {
                btnThem.Visibility = btnSua.Visibility = btnXoa.Visibility = btnHuy.Visibility = btnGhi.Visibility
                        = btnUndo.Visibility = btnRedo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else if (Program.mGroup == "PGV")
            {
                btnThem.Visibility = btnSua.Visibility = btnXoa.Visibility = btnHuy.Visibility = btnGhi.Visibility
                        = btnUndo.Visibility = btnRedo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            btnHuy.Enabled = btnGhi.Enabled = false;

            cbbTrinhDo.Items.Add("ĐHCQ");
            cbbTrinhDo.Items.Add("CĐCQ");
            cbbTrinhDo.Items.Add("VB2");
            cbbLanThi.Items.Add(1);
            cbbLanThi.Items.Add(2);
            cbbCoSo.DataSource = Program.bds_dspm.DataSource;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoSo;
            cbbCoSo.Enabled = true;
            String tenCS = cbbCoSo.Text;
            String strLenh = "EXEC SP_Lay_MaCS_Tu_TenCS N'" + tenCS + "'";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                maCS = Program.myReader.GetString(0);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("lỗi " + ex.Message);
            }
            finally
            {
                Program.myReader.Close();
            }
        }
        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbbCoSo.SelectedValue.ToString();
            if (cbbCoSo.SelectedIndex != Program.mCoSo) 
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
                Program.mCoSo = cbbCoSo.SelectedIndex;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                DS.EnforceConstraints = false;
                this.tbThi.Connection.ConnectionString = Program.connstr;
                this.tbThi.Fill(this.DS.THI);
                this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
                this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
                this.tbLop.Connection.ConnectionString = Program.connstr;
                this.tbLop.Fill(this.DS.LOP);
                this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                this.tbMonHoc.Fill(this.DS.MONHOC);
                this.tbGetPGV.Connection.ConnectionString = Program.connstr;
                this.tbGetPGV.Fill(this.DS.SP_GET_PGV);
                this.tbGetGV.Connection.ConnectionString = Program.connstr;
                this.tbGetGV.Fill(this.DS.SP_GET_GV);
                String tenCS = cbbCoSo.Text;
                String strLenh = "EXEC SP_Lay_MaCS_Tu_TenCS N'" + tenCS + "'";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    maCS = Program.myReader.GetString(0);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("lỗi " + ex.Message);
                }
                finally
                {
                    Program.myReader.Close();
                }
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cbbCoSo.Enabled = false;
                gcDangKyThi.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                numTietBD.Enabled = cbbTrinhDo.Enabled = dateNgayThi.Enabled = numSoCau.Enabled = numThoiGian.Enabled
                    = cbbLanThi.Enabled = cbbTenMon.Enabled = cbbTenLop.Enabled = cbbTenGV.Enabled = cbbTenPGV.Enabled = true;
                bdsDangKyThi.AddNew();
                dateNgayThi.Properties.MinValue = DateTime.Today;
                isThem = true;
                cbbTrinhDo.SelectedIndex = cbbLanThi.SelectedIndex = -1;
                btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnXoa.Enabled= btnUndo.Enabled = btnRedo.Enabled = false;
                numThoiGian.Value = 15;
                numSoCau.Value = 10;
                numTietBD.Value = 1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi thêm  giáo viên đăng ký thi " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDangKyThi.Count == 0)
            {
                XtraMessageBox.Show("Không có giáo viên đăng ký để sửa!", "", MessageBoxButtons.OK);
            }
            else
            {
                cbbCoSo.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                gcDangKyThi.Enabled = true;
                numTietBD.Enabled =  dateNgayThi.Enabled = numSoCau.Enabled = numThoiGian.Enabled = true;
                cbbTrinhDo.Enabled = cbbLanThi.Enabled = cbbTenMon.Enabled = cbbTenLop.Enabled = cbbTenGV.Enabled = cbbTenPGV.Enabled = false;
                cbbTenGV.Focus();
                isSua = true;
                btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled
                    = btnUndo.Enabled = btnRedo.Enabled = btnXoa.Enabled = false; 
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDangKyThi.Count == 0)
            {
                MessageBox.Show("Không có đăng ký thi để xóa!", "", MessageBoxButtons.OK);
            }
            else
            {
                if (bdsThi.Count > 0)
                {
                    XtraMessageBox.Show("Đăng ký thi đã thi , không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa đăng ký thi: " + ((DataRowView)this.bdsDangKyThi.Current).Row["ID_DANGKYTHI"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsDangKyThi.RemoveCurrent();
                        this.tbDangKyThi.Update(this.DS.DANGKYTHI);
                        this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
                        this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
                        XtraMessageBox.Show("Xóa đăng ký thi thành công!", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
                        this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
                        MessageBox.Show("Lỗi xóa đăng ký thi " + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
                else return;
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbbCoSo.Enabled = true;
            bdsDangKyThi.CancelEdit();
            btnHuy.Enabled = btnGhi.Enabled = false;
            isSua = isThem = false;
            numTietBD.Enabled = cbbTrinhDo.Enabled = dateNgayThi.Enabled = numSoCau.Enabled = numThoiGian.Enabled
                   = cbbLanThi.Enabled = cbbTenMon.Enabled = cbbTenLop.Enabled = cbbTenGV.Enabled = cbbTenPGV.Enabled = false;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
            this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
            gcDangKyThi.Enabled = true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbbCoSo.Enabled = true;
            bool isValid = ValidateInput();
            if (!isValid) return;
            btnHuy.Enabled = btnGhi.Enabled = false;
            if (isThem)
            {
                String sql = "EXEC SP_KT_DANGKYTHI N'" + txtMaMon.Text.Trim() + "', N'" + txtMaLop.Text.Trim() + "', " + cbbLanThi.Text.Trim() + "";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    String kq = Program.myReader.GetString(0);
                    Program.myReader.Close();
                    if (kq.Equals("1"))
                    {
                        XtraMessageBox.Show("Đã tồn tại đăng ký thi cho môn học, lớp học và lần thi này!", "", MessageBoxButtons.OK);
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        return;
                    }
                    else
                    {
                        WriteToDB();
                        isThem = false;
                        XtraMessageBox.Show("Đăng ký thi thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            else if (isSua)
            {
                WriteToDB();
                isSua = false;
                XtraMessageBox.Show("Sửa đăng ký thành công!", "", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
                this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isThem == true)
            {
                if (XtraMessageBox.Show("Bạn đang tạo mới đăng ký thi, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            else if (isSua == true)
            {
                if (XtraMessageBox.Show("Bạn đang sửa đăng ký thi, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            this.Close();
        }
        private void WriteToDB()
        {
            cbbCoSo.Enabled = false;
            gcDangKyThi.Enabled = true;
            numTietBD.Enabled = cbbTrinhDo.Enabled = dateNgayThi.Enabled = numSoCau.Enabled = numThoiGian.Enabled
                    = cbbLanThi.Enabled = cbbTenMon.Enabled = cbbTenLop.Enabled = cbbTenGV.Enabled = cbbTenPGV.Enabled = false;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                bdsDangKyThi.EndEdit();
                bdsDangKyThi.ResetCurrentItem();
                this.tbDangKyThi.Update(this.DS.DANGKYTHI);
                this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
                this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi đăng ký thi" + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        public bool ValidateInput()
        {
            if (numTietBD.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Tiết bắt đầu không được để trống ", "", MessageBoxButtons.OK);
                numTietBD.Focus();
                return false;
            }
            if (cbbTrinhDo.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Trình độ thi không được để trống ", "", MessageBoxButtons.OK);
                cbbTrinhDo.Focus();
                return false;
            }
            if (dateNgayThi.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Ngày thi không được để trống ", "", MessageBoxButtons.OK);
                dateNgayThi.Focus();
                return false;
            }
            if (DateTime.Compare(DateTime.Today, dateNgayThi.DateTime) > 0)
            {
                XtraMessageBox.Show("Ngày thi không được bé hơn ngày hiện tại ", "", MessageBoxButtons.OK);
                dateNgayThi.Focus();
                return false;
            }
            if (numSoCau.Value.ToString().Equals(""))
            {
                XtraMessageBox.Show("Số câu thi không được để trống ", "", MessageBoxButtons.OK);
                numSoCau.Focus();
                return false;
            }
            if (numSoCau.Value < 10 || numSoCau.Value > 100)
            {
                MessageBox.Show("Số câu thi phải >=10 và <=100 câu, vui lòng nhập lại", "", MessageBoxButtons.OK);
                numSoCau.Focus();
                return false;
            }
            if (numThoiGian.Value.ToString().Equals(""))
            {
                XtraMessageBox.Show("Thời gian thi không được để trống ", "", MessageBoxButtons.OK);
                numThoiGian.Focus();
                return false;
            }
            if (numThoiGian.Value < 10 || numThoiGian.Value > 60)
            {
                MessageBox.Show("Thời gian thi phải >=10 và <=60 phút, vui lòng nhập lại", "", MessageBoxButtons.OK);
                numThoiGian.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbbLanThi.Text.Trim()))
            {
                XtraMessageBox.Show("Lần thi không được để trống ", "", MessageBoxButtons.OK);
                cbbLanThi.Focus();
                return false;
            }
            if (cbbTenMon.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Môn học không được để trống ", "", MessageBoxButtons.OK);
                cbbTenMon.Focus();
                return false;
            }
            if (cbbTenLop.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Lớp học không được để trống ", "", MessageBoxButtons.OK);
                cbbTenLop.Focus();
                return false;
            }
            if (cbbTenGV.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Giáo viên không được để trống ", "", MessageBoxButtons.OK);
                cbbTenGV.Focus();
                return false;
            }
            if (cbbTenPGV.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Phòng giáo vụ không được để trống ", "", MessageBoxButtons.OK);
                cbbTenPGV.Focus();
                return false;
            }
            // Khi chọn lần thi =2 thì : kiểm tra đã thi lần 1 chưa, ngày thi lần 1 > ngày thi lần 2
            if (int.Parse(cbbLanThi.Text.Trim()) == 2)
            {
                String sqlKtLan = "EXEC SP_KT_DANGKYTHI N'" + txtMaMon.Text.Trim() + "', N'" + txtMaLop.Text.Trim() + "', " + 1 + "";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(sqlKtLan);
                    if (Program.myReader == null) return false;
                    Program.myReader.Read();
                    String kq = Program.myReader.GetString(0);
                    Program.myReader.Close();
                    if (kq.Equals("0"))
                    {
                        XtraMessageBox.Show("Hiện tại chưa đăng ký tổ chức thi lần 1 nên không thể tổ chức đăng ký thi lần 2", "", MessageBoxButtons.OK);
                        cbbLanThi.Focus();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Program.myReader.Close();
                    MessageBox.Show(ex.Message);
                    return false;
                }
                string ngaythi = "SELECT NGAYTHI from DANGKYTHI Where MALOP='" + txtMaLop.Text.Trim() + "'AND MAMH='" + txtMaMon.Text.Trim() + "'AND LAN=" + 1 + "";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(ngaythi);
                    if (Program.myReader == null) return false;
                    Program.myReader.Read();
                    DateTime kq = Program.myReader.GetDateTime(0);
                    Program.myReader.Close();
                    if (DateTime.Compare(kq, dateNgayThi.DateTime) > 0)
                    {
                        XtraMessageBox.Show("Ngày thi đăng ký thi lần 1 không được lớn hơn ngày thi đăng ký thi lần 2 ", "", MessageBoxButtons.OK);
                        dateNgayThi.Focus();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Program.myReader.Close();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            String sql = "exec SP_Dang_Ky_Thi N'"
                           + txtMaMon.Text.Trim() + "',N'"
                           + cbbTrinhDo.Text.Trim() + "', " + numSoCau.Value.ToString();
            try
            {
                DataTable dt = Program.ExecSqlDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    object firstValue = dt.Rows[0][0];
                    if (firstValue != null)
                    {
                        string firstValueString = firstValue.ToString().Trim();
                        if (firstValueString.Equals("CS1"))
                        {
                             txtCauThiCS1.Text = dt.Rows[0][1].ToString();
                             txtCauThiCS2.Text = dt.Rows[1][1].ToString();
                        }
                        if (firstValueString.Equals("CS2"))
                        {
                             txtCauThiCS1.Text = dt.Rows[1][1].ToString();
                             txtCauThiCS2.Text = dt.Rows[0][1].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại"+ firstValue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

    }
}
