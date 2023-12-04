using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTPT
{
    public partial class FrmGiaoVien : Form
    {
        private Boolean isThem = false;
        private Boolean isSua = false;
        public FrmGiaoVien()
        {
            InitializeComponent();
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.tbDangKyThi_GV.Connection.ConnectionString = Program.connstr;
            this.tbDangKyThi_GV.Fill(this.DS.DANGKYTHI);
            this.tbCauHoi.Connection.ConnectionString = Program.connstr;
            this.tbCauHoi.Fill(this.DS.CAUHOI);
            this.tbKhoa.Connection.ConnectionString = Program.connstr;
            this.tbKhoa.Fill(this.DS.KHOA);
            this.tbGiaoVien.Connection.ConnectionString = Program.connstr;
            this.tbGiaoVien.Fill(this.DS.GIAOVIEN);
            this.tbKhoa.Connection.ConnectionString = Program.connstr;
            this.tbKhoa.Fill(this.DS.KHOA);
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
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gcGiaoVien.Enabled=gcKhoa.Enabled = false;
                bdsGiaoVien.AddNew();
                btnGhi.Enabled = btnHuy.Enabled = true;
                isThem = true;
                txtMaGV.Enabled = txtHoGV.Enabled = txtTenGV.Enabled 
                    = txtDiaChi.Enabled=txtGioiTinh.Enabled=dateNgaySinh.Enabled=cbbTenKhoa.Enabled = true;
                txtMaGV.Focus();
                btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled
                    = btnUndo.Enabled = btnRedo.Enabled = btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi thêm môn học " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGiaoVien.Count == 0)
            {
                XtraMessageBox.Show("Không có giáo viên để sửa!", "", MessageBoxButtons.OK);
            }
            else
            {
                btnGhi.Enabled = btnHuy.Enabled = true;
                gcGiaoVien.Enabled =  true;
                gcKhoa.Enabled = false;
                txtMaGV.Enabled = false;
                txtHoGV.Enabled = txtTenGV.Enabled = txtDiaChi.Enabled = txtGioiTinh.Enabled = dateNgaySinh.Enabled = true;
                cbbTenKhoa.Enabled = false;
                isSua = true;
                btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled
                    = btnUndo.Enabled = btnRedo.Enabled = btnXoa.Enabled = false;
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGiaoVien.Count == 0)
            {
                XtraMessageBox.Show("Không có giáo viên để xóa!", "", MessageBoxButtons.OK);
            }
            else
            {
                if (bdsCauHoi.Count > 0)
                {
                    XtraMessageBox.Show("Giáo viên này đã ra đề thi, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsDangKyThi_GV.Count > 0)
                {
                    XtraMessageBox.Show("Giáo viên này đã tồn tại trong bảng  đăng ký thi, không thể xóa", "", MessageBoxButtons.OK);
                }
                if (bdsDangKyThi_NV.Count > 0)
                {
                    XtraMessageBox.Show("Nhân viên này đã tồn tại trong bảng đăng ký thi, không thể xóa", "", MessageBoxButtons.OK);
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên: " + ((DataRowView)this.bdsGiaoVien.Current).Row["TEN"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string maGV = "";
                    try
                    {
                        maGV = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position])["MAGV"].ToString();
                        bdsGiaoVien.RemoveCurrent();
                        this.tbGiaoVien.Update(this.DS.GIAOVIEN);
                        this.tbGiaoVien.Connection.ConnectionString = Program.connstr;
                        this.tbGiaoVien.Fill(this.DS.GIAOVIEN);
                        XtraMessageBox.Show("Xóa giáo viên thành công!", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa giáo viên " + ex.Message, "", MessageBoxButtons.OK);
                        this.tbGiaoVien.Fill(this.DS.GIAOVIEN);
                        bdsGiaoVien.Position = bdsGiaoVien.Find("MAGV", maGV);
                        return;
                    }
                }
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKhoa.Count > 0)
            {
                cbbTenKhoa.SelectedValue = ((DataRowView)this.bdsKhoa.Current).Row["MAKH"].ToString();
            }
            bdsGiaoVien.CancelEdit();
            btnHuy.Enabled = btnGhi.Enabled = false;
            isSua = isThem = false;
            txtMaGV.Enabled = txtHoGV.Enabled = txtTenGV.Enabled = txtDiaChi.Enabled = txtGioiTinh.Enabled = dateNgaySinh.Enabled = false;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            this.tbGiaoVien.Connection.ConnectionString = Program.connstr;
            this.tbGiaoVien.Fill(this.DS.GIAOVIEN);
            gcKhoa.Enabled = gcGiaoVien.Enabled = true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isValid = ValidateEmpty();
            if (!isValid) return;
            btnHuy.Enabled = btnGhi.Enabled = false;
            if (isThem)
            {
                String sql = "EXEC SP_KT_Giao_Vien_Ton_Tai N'" + txtMaGV.Text.Trim() + "'";
                try
                {
                    int kq = Program.ExecSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        txtMaGV.Focus();
                        return;
                    }
                    else
                    {
                        string maGV = txtMaGV.Text.Trim();
                        WriteToDB();
                        bdsGiaoVien.Position = bdsGiaoVien.Find("MAGV", maGV);
                        isThem = false;
                        XtraMessageBox.Show("Thêm giáo viên thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi thêm giáo viên " + ex.Message, "", MessageBoxButtons.OK);
                }
                finally
                {
                    Program.conn.Close();
                }
            }
            else if (isSua)
            {
                string maGV = txtMaGV.Text.Trim();
                WriteToDB();
                isSua = false;
                bdsGiaoVien.Position = bdsGiaoVien.Find("MAGV", maGV);
                XtraMessageBox.Show("Sửa giáo viên thành công!", "", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tbGiaoVien.Connection.ConnectionString = Program.connstr;
                this.tbGiaoVien.Fill(this.DS.GIAOVIEN);
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
                if (XtraMessageBox.Show("Bạn đang tạo mới giáo viên, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            else if (isSua == true)
            {
                if (XtraMessageBox.Show("Bạn đang sửa giáo viên, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            this.Close();
        }
        public bool ValidateEmpty()
        {
            if (txtMaGV.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Mã giáo viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return false;
            }
            if (txtHoGV.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Họ giao viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtHoGV.Focus();
                return false;
            }
            if (txtTenGV.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Tên giáo viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtTenGV.Focus();
                return false;
            }
          
            if (Regex.IsMatch(txtHoGV.Text, Program.FULLNAME_PATTERN) == false)
            {
                XtraMessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "", MessageBoxButtons.OK);
                txtHoGV.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTenGV.Text, Program.FULLNAME_PATTERN) == false)
            {
                XtraMessageBox.Show("Tên của người chỉ có chữ cái và khoảng trắng", "", MessageBoxButtons.OK);
                txtTenGV.Focus();
                return false;
            }
            if (txtMaGV.Text.Trim().Length > 8)
            {
                XtraMessageBox.Show("Mã giáo viên không được lớn hơn 8 kí tự ", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return false;
            }
            if (txtHoGV.Text.Trim().Length > 40)
            {
                XtraMessageBox.Show("Họ giáo viên không được lớn hơn 40 kí tự ", "", MessageBoxButtons.OK);
                txtHoGV.Focus();
                return false;
            }
            if (txtTenGV.Text.Trim().Length > 10)
            {
                XtraMessageBox.Show("Tên giáo viên không được lớn hơn 10 kí tự ", "", MessageBoxButtons.OK);
                txtTenGV.Focus();
                return false;
            }
            if (CalculateAge(dateNgaySinh.DateTime) < 18)
            {
                MessageBox.Show("Sinh viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dateNgaySinh.Focus();
                return false;
            }
            if (dateNgaySinh.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Ngày sinh không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                dateNgaySinh.Focus();
                return false;
            }
            if (txtGioiTinh.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Giới tính không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtGioiTinh.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Địa chỉ giáo viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim().Length > 100)
            {
                XtraMessageBox.Show("Địa chỉ giáo viên không được lớn hơn 100 kí tự ", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            if (cbbTenKhoa.Text.Trim().Equals("") && txtMaKH.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Khoa không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
        private void WriteToDB()
        {
            gcGiaoVien.Enabled = gcKhoa.Enabled = true;
            txtMaGV.Enabled = txtHoGV.Enabled = txtTenGV.Enabled = txtDiaChi.Enabled=txtGioiTinh.Enabled=dateNgaySinh.Enabled = false;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                bdsGiaoVien.EndEdit();
                bdsGiaoVien.ResetCurrentItem();
                this.tbGiaoVien.Update(this.DS.GIAOVIEN);
                this.tbGiaoVien.Connection.ConnectionString = Program.connstr;
                this.tbGiaoVien.Fill(this.DS.GIAOVIEN);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi giáo viên" + ex.Message, "", MessageBoxButtons.OK);
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
