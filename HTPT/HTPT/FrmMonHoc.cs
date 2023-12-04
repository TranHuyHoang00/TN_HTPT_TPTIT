using DevExpress.Utils;
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
    public partial class FrmMonHoc : Form
    {
        private Boolean isThem = false;
        private Boolean isSua = false;
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.tbCauHoi.Connection.ConnectionString = Program.connstr;
            this.tbCauHoi.Fill(this.DS.CAUHOI);
            this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
            this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
            this.tbKhoa.Connection.ConnectionString = Program.connstr;
            this.tbKhoa.Fill(this.DS.KHOA);
            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.DS.MONHOC);
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
            gcMonHoc.Enabled=gcKhoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            bdsMonHoc.AddNew();
            isThem = true;
            txtTenMH.Enabled = txtMaMH.Enabled=cbbTenKhoa.Enabled = true;
            txtMaMH.Focus();
            btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = false;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMonHoc.Count == 0)
            { XtraMessageBox.Show("Không có môn học để sửa!", "", MessageBoxButtons.OK); }
            else
            {
                btnGhi.Enabled = btnHuy.Enabled = true;
                gcMonHoc.Enabled = true;
                gcKhoa.Enabled = false;
                txtTenMH.Enabled = true;
                txtMaMH.Enabled = cbbTenKhoa.Enabled = false;
                isSua = true;
                btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnUndo.Enabled = btnRedo.Enabled = btnXoa.Enabled = false;
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMonHoc.Count == 0)
            {
                XtraMessageBox.Show("Không có môn học để xóa!", "", MessageBoxButtons.OK);
            }
            else
            {
                if (bdsCauHoi.Count > 0)
                {
                    XtraMessageBox.Show("Môn học này đã có bộ đề, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsDangKyThi.Count > 0)
                {
                    XtraMessageBox.Show("Môn học này đã được đăng ký thi, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa môn học: " + ((DataRowView)this.bdsMonHoc.Current).Row["TENMH"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string maMH = "";
                    try
                    {
                        maMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                        bdsMonHoc.RemoveCurrent();
                        this.tbMonHoc.Update(this.DS.MONHOC);
                        this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                        this.tbMonHoc.Fill(this.DS.MONHOC);
                        XtraMessageBox.Show("Xóa môn học thành công!", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa môn học " + ex.Message, "", MessageBoxButtons.OK);
                        this.tbMonHoc.Fill(this.DS.MONHOC);
                        bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                        return;
                    }
                }
                else return;
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            btnHuy.Enabled = btnGhi.Enabled = false;
            isSua = isThem = false;
            txtTenMH.Enabled = txtMaMH.Enabled = cbbTenKhoa.Enabled = false;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.DS.MONHOC);
            gcMonHoc.Enabled=gcKhoa.Enabled = true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isValid = ValidateEmpty();
            if (!isValid) return;
            btnHuy.Enabled = btnGhi.Enabled = false;
            if (isThem)
            {
                String sql = "EXEC SP_KT_MonHoc_Ton_Tai N'" + txtMaMH.Text.Trim() + "', N'" + txtTenMH.Text.Trim() + "', N'" + cbbTenKhoa.Text.Trim() + "'";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    String kq = Program.myReader.GetString(0);
                    if (kq.Equals("1"))
                    {
                        txtMaMH.Focus();
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        XtraMessageBox.Show("Mã môn học đã tồn tại, vui lòng nhập mã khác", "", MessageBoxButtons.OK);
                        return;
                    }
                    else if (kq.Equals("2"))
                    {
                        txtTenMH.Focus();
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        XtraMessageBox.Show("Tên môn học đã tồn tại, vui lòng nhập tên khác", "", MessageBoxButtons.OK);
                        return;
                    }
                    else if (kq.Equals("3"))
                    {
                        txtTenMH.Focus();
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        XtraMessageBox.Show("Không thể tạo môn học cho Phòng Giáo Vụ", "", MessageBoxButtons.OK);
                        return;
                    }
                    else if (kq.Equals("4"))
                    {
                        txtTenMH.Focus();
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        XtraMessageBox.Show("Không tồn tại Khoa", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        string maMH = txtMaMH.Text.Trim();
                        WriteToDB();
                        bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                        isThem = false;
                        XtraMessageBox.Show("Thêm môn học thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                { XtraMessageBox.Show("Lỗi ghi môn học" + ex.Message, "", MessageBoxButtons.OK); }
                finally
                { Program.myReader.Close(); }
            }
            else if (isSua)
            {
                String sql = "EXEC SP_KT_Sua_MonHoc_Ton_Tai '" + txtMaMH.Text.Trim() + "', N'" + txtTenMH.Text.Trim() + "'";
                try
                {
                    int kq = Program.ExecSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        txtTenMH.Focus();
                        return;
                    }
                    else
                    {
                        string maMH = txtMaMH.Text.Trim();
                        WriteToDB();
                        isSua = false;
                        bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                        XtraMessageBox.Show("Sửa môn học thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                { XtraMessageBox.Show("Sửa môn học thất bại " + ex.Message, "", MessageBoxButtons.OK); }
                finally
                { Program.conn.Close(); }
            }
            else return;
        }
        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                this.tbMonHoc.Fill(this.DS.MONHOC);
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
                if (XtraMessageBox.Show("Bạn đang tạo mới môn học, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            else if (isSua == true)
            {
                if (XtraMessageBox.Show("Bạn đang sửa môn học, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            this.Close();
        }
        private void WriteToDB()
        {
            gcMonHoc.Enabled=gcKhoa.Enabled = true;
            txtTenMH.Enabled = txtMaMH.Enabled=cbbTenKhoa.Enabled = false;
            btnThem.Enabled = btnTaiLai.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.tbMonHoc.Update(this.DS.MONHOC);
                this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                this.tbMonHoc.Fill(this.DS.MONHOC);
            }
            catch (Exception ex)
            { XtraMessageBox.Show("Lỗi ghi môn học DB" + ex.Message, "", MessageBoxButtons.OK); }
        }
        public bool ValidateEmpty()
        {
            if (txtMaMH.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Mã môn học không được để trống ", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return false;
            }
            if (txtTenMH.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Tên môn học không được để trống ", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return false;
            }
            if (txtMaMH.Text.Trim().Length < 2)
            {
                XtraMessageBox.Show("Mã môn học không được bé hơn 3 kí tự ", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return false;
            }
            if (txtTenMH.Text.Trim().Length > 50)
            {
                XtraMessageBox.Show("Tên môn học không được lớn hơn 50 kí tự ", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return false;
            }
            if (cbbTenKhoa.Text.Trim().Equals("") && txtMaKH.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Khoa không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                cbbTenKhoa.Focus();
                return false;
            }
            return true;
        }

      

      

      

       

        private void cbbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }

}
