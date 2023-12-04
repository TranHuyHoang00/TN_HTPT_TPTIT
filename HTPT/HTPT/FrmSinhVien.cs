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
using System.Text.RegularExpressions;

namespace HTPT
{
    public partial class FrmSinhVien : Form
    {
        private Boolean isThem = false;
        private Boolean isSua = false;
        private String maCS = "";
        private String beforePassword;
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.tbLop.Connection.ConnectionString = Program.connstr;
            this.tbLop.Fill(this.DS.LOP);
            this.tbThi.Connection.ConnectionString = Program.connstr;
            this.tbThi.Fill(this.DS.THI);
            this.tbSinhVien.Connection.ConnectionString = Program.connstr;
            this.tbSinhVien.Fill(this.DS.SINHVIEN);
            if (Program.mGroup == "KHOA")
            {
                btnThem.Visibility = btnSua.Visibility = btnXoa.Visibility = btnHuy.Visibility = btnGhi.Visibility
                        = btnUndo.Visibility = btnRedo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else if (Program.mGroup == "PGV")
            {
                btnThem.Visibility = btnSua.Visibility = btnXoa.Visibility = btnHuy.Visibility = btnGhi.Visibility
                        = btnUndo.Visibility = btnRedo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            btnHuy.Enabled = btnGhi.Enabled = false;
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
            //Kiem tra cbbCoSo co du lieu chua
            if (cbbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbbCoSo.SelectedValue.ToString();
            if (cbbCoSo.SelectedIndex != Program.mCoSo) // khi cbb chọn cơ sở khác, đăng nhập=HTKN
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
                this.tbLop.Connection.ConnectionString = Program.connstr;
                this.tbLop.Fill(this.DS.LOP);
                this.tbThi.Connection.ConnectionString = Program.connstr;
                this.tbThi.Fill(this.DS.THI);
                this.tbSinhVien.Connection.ConnectionString = Program.connstr;
                this.tbSinhVien.Fill(this.DS.SINHVIEN);
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
                cbbTenLop.Enabled = true;
                gcSinhVien.Enabled = gcLop.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                bdsSinhVien.AddNew();
                isThem = true;
                txtMaSV.Enabled = txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChi.Enabled = dateNgaySinh.Enabled = txtPassword.Enabled = true;
                txtMaSV.Focus();
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled= btnUndo.Enabled = btnRedo.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi thêm sinh viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSinhVien.Count == 0)
            {
                XtraMessageBox.Show("Không có sinh viên để sửa!", "", MessageBoxButtons.OK);
            }
            else
            {
                cbbCoSo.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                gcSinhVien.Enabled = true;
                gcLop.Enabled = false;
                txtMaSV.Enabled = false;
                txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChi.Enabled = dateNgaySinh.Enabled = txtPassword.Enabled = true;
                txtMaLop.Enabled = false;
                isSua = true;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnUndo.Enabled = btnRedo.Enabled =  false;
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSinhVien.Count == 0)
            {
                XtraMessageBox.Show("Không có sinh viên để xóa!", "", MessageBoxButtons.OK);
            }
            else
            {
                if (bdsThi.Count > 0)
                {
                    XtraMessageBox.Show("Sinh viên này đã có bảng điểm, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên: " + ((DataRowView)this.bdsSinhVien.Current).Row["TEN"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string maSV = "";
                    try
                    {
                        maSV = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
                        bdsSinhVien.RemoveCurrent();
                        this.tbSinhVien.Update(this.DS.SINHVIEN);
                        this.tbSinhVien.Connection.ConnectionString = Program.connstr;
                        this.tbSinhVien.Fill(this.DS.SINHVIEN);
                        XtraMessageBox.Show("Xóa sinh viên thành công!", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa sinh viên " + ex.Message, "", MessageBoxButtons.OK);
                        this.tbSinhVien.Fill(this.DS.SINHVIEN);
                        bdsSinhVien.Position = bdsSinhVien.Find("MASV", maSV);
                        return;
                    }
                }
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbbTenLop.Enabled = false;
            cbbCoSo.Enabled = true;
            bdsSinhVien.CancelEdit();
            btnHuy.Enabled = btnGhi.Enabled = false;
            isSua = isThem = false;
            txtMaSV.Enabled = txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChi.Enabled = dateNgaySinh.Enabled = txtPassword.Enabled = false;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            this.tbSinhVien.Connection.ConnectionString = Program.connstr;
            this.tbSinhVien.Fill(this.DS.SINHVIEN);
            gcLop.Enabled = gcSinhVien.Enabled = true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbbCoSo.Enabled = true;
            bool isValid = ValidateEmpty();
            if (!isValid) return;
            btnHuy.Enabled = btnGhi.Enabled = false;
            if (isThem)
            {
                String sql = "EXEC SP_KT_Sinh_Vien_Ton_Tai N'" + txtMaSV.Text.Trim() + "'";
                try
                {
                    int kq = Program.ExecSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        txtMaSV.Focus();
                        return;
                    }
                    else
                    {
                        string maSV = txtMaSV.Text.Trim();
                        //txtPassword.Text = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim());
                        WriteToDB();
                        bdsSinhVien.Position = bdsSinhVien.Find("MASV", maSV);
                        isThem = false;
                        XtraMessageBox.Show("Thêm sinh viên thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Thêm sinh viên thất bại " + ex.Message, "", MessageBoxButtons.OK);
                }
                finally
                {
                    Program.conn.Close();
                }
            }
            else if (isSua)
            {
                string maSV = txtMaSV.Text.Trim();
                //if (!txtPassword.Text.Trim().Equals(beforePassword))
                //{
                //    txtPassword.Text = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim());
                //}
                WriteToDB();
                isSua = false;
                bdsSinhVien.Position = bdsSinhVien.Find("MASV", maSV);
                XtraMessageBox.Show("Sửa sinh viên thành công!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DS.EnforceConstraints = false;
                this.tbLop.Connection.ConnectionString = Program.connstr;
                this.tbLop.Fill(this.DS.LOP);
                this.tbThi.Connection.ConnectionString = Program.connstr;
                this.tbThi.Fill(this.DS.THI);
                this.tbSinhVien.Connection.ConnectionString = Program.connstr;
                this.tbSinhVien.Fill(this.DS.SINHVIEN);
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
                if (XtraMessageBox.Show("Bạn đang tạo mới sinh viên, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            else if (isSua == true)
            {
                if (XtraMessageBox.Show("Bạn đang sửa sinh viên, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            this.Close();
        }
        public bool ValidateEmpty()
        {
            if (txtMaSV.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Mã sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            if (txtHoSV.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Họ sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtHoSV.Focus();
                return false;
            }
            if (Regex.IsMatch(txtHoSV.Text, Program.FULLNAME_PATTERN) == false)
            {
                XtraMessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "", MessageBoxButtons.OK);
                txtHoSV.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTenSV.Text, Program.FULLNAME_PATTERN) == false)
            {
                XtraMessageBox.Show("Tên của người chỉ có chữ cái và khoảng trắng", "", MessageBoxButtons.OK);
                txtHoSV.Focus();
                return false;
            }
            if (txtTenSV.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Tên sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtTenSV.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Địa chỉ sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            if (dateNgaySinh.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Ngày sinh không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                dateNgaySinh.Focus();
                return false;
            }
            if (CalculateAge(dateNgaySinh.DateTime) < 18)
            {
                MessageBox.Show("Sinh viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dateNgaySinh.Focus();
                return false;
            }
            if (txtMaSV.Text.Trim().Length > 8)
            {
                XtraMessageBox.Show("Mã sinh viên không được lớn hơn 8 kí tự ", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            if (txtHoSV.Text.Trim().Length > 50)
            {
                XtraMessageBox.Show("Họ sinh viên không được lớn hơn 50 kí tự ", "", MessageBoxButtons.OK);
                txtHoSV.Focus();
                return false;
            }
            if (txtTenSV.Text.Trim().Length > 10)
            {
                XtraMessageBox.Show("Tên sinh viên không được lớn hơn 10 kí tự ", "", MessageBoxButtons.OK);
                txtTenSV.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim().Length > 100)
            {
                XtraMessageBox.Show("Địa chỉ sinh viên không được lớn hơn 100 kí tự ", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            if (cbbTenLop.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Lớp không được để trống, vui lòng chọn lại", "", MessageBoxButtons.OK);
                cbbTenLop.Focus();
                return false;
            }
            if (txtPassword.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Mật khẩu không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtPassword.Focus();
                return false;
            }
            return true;
        }
        private void WriteToDB()
        {
            gcSinhVien.Enabled = gcLop.Enabled = true;
            txtMaSV.Enabled = txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChi.Enabled = dateNgaySinh.Enabled = txtPassword.Enabled=cbbTenLop.Enabled = false;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                bdsSinhVien.EndEdit();
                bdsSinhVien.ResetCurrentItem();
                this.tbSinhVien.Update(this.DS.SINHVIEN);
                this.tbSinhVien.Connection.ConnectionString = Program.connstr;
                this.tbSinhVien.Fill(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi sinh viên" + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
