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
    public partial class FrmKhoa : Form
    {
        private Boolean isThem = false;
        private Boolean isSua = false;
        private Boolean isThemLop = false;
        private Boolean isSuaLop = false;
        private String maCS = "";
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
            this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
            this.tbSinhVien.Connection.ConnectionString = Program.connstr;
            this.tbSinhVien.Fill(this.DS.SINHVIEN);
            this.tbGiaoVien.Connection.ConnectionString = Program.connstr;
            this.tbGiaoVien.Fill(this.DS.GIAOVIEN);
            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.DS.MONHOC);
            this.tbLop.Connection.ConnectionString = Program.connstr;
            this.tbLop.Fill(this.DS.LOP);
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
                this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
                this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
                this.tbSinhVien.Connection.ConnectionString = Program.connstr;
                this.tbSinhVien.Fill(this.DS.SINHVIEN);
                this.tbGiaoVien.Connection.ConnectionString = Program.connstr;
                this.tbGiaoVien.Fill(this.DS.GIAOVIEN);
                this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                this.tbMonHoc.Fill(this.DS.MONHOC);
                this.tbLop.Connection.ConnectionString = Program.connstr;
                this.tbLop.Fill(this.DS.LOP);
                this.tbKhoa.Connection.ConnectionString = Program.connstr;
                this.tbKhoa.Fill(this.DS.KHOA);
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
                gcKhoa.Enabled = gcLop.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                bdsKhoa.AddNew();
                isThem = true;
                txtCoSo.Text = maCS;
                ctxMenuLop.Enabled = false;
                txtMaKhoa.Enabled = txtTenKhoa.Enabled=txtActivate.Enabled = true;
                txtMaKhoa.Focus();
                btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnUndo.Enabled = btnRedo.Enabled = btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi thêm khoa " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKhoa.Count == 0)
            {
                XtraMessageBox.Show("Không có khoa để sửa!", "", MessageBoxButtons.OK);
            }
            else
            {
                cbbCoSo.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                gcKhoa.Enabled = true;
                gcLop.Enabled = false;
               ctxMenuLop.Enabled = false;
                txtTenKhoa.Enabled = true;
                txtMaKhoa.Enabled=txtActivate.Enabled = false;
                txtTenKhoa.Focus();
                isSua = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKhoa.Count == 0)
            {
                XtraMessageBox.Show("Không có khoa để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (bdsLop.Count > 0)
                {
                    XtraMessageBox.Show("Khoa đã có lớp, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsGiaoVien.Count > 0)
                {
                    XtraMessageBox.Show("Khoa đã có giáo viên, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsMonHoc.Count > 0)
                {
                    XtraMessageBox.Show("Khoa đã có môn học, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa " + ((DataRowView)this.bdsKhoa.Current).Row["TENKH"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string maKhoa = "";
                    try
                    {
                        maKhoa = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString().Trim();
                        bdsKhoa.RemoveCurrent();
                        this.tbKhoa.Update(this.DS.KHOA);
                        this.tbKhoa.Connection.ConnectionString = Program.connstr;
                        this.tbKhoa.Fill(this.DS.KHOA);
                        XtraMessageBox.Show("Xóa khoa thành công!", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa khoa " + ex.Message, "", MessageBoxButtons.OK);
                        this.tbKhoa.Fill(this.DS.KHOA);
                        bdsKhoa.Position = bdsKhoa.Find("MAKH", maKhoa);
                        return;
                    }
                }
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbbCoSo.Enabled = true;
            bdsKhoa.CancelEdit();
            btnHuy.Enabled = btnGhi.Enabled = false;
            isSua = isThem = false;
            txtMaKhoa.Enabled= txtTenKhoa.Enabled = false;
            btnThem.Enabled =btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled  = true;
            this.tbKhoa.Connection.ConnectionString = Program.connstr;
            this.tbKhoa.Fill(this.DS.KHOA);
            gcKhoa.Enabled = gcLop.Enabled = true;
            ctxMenuLop.Enabled = true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbbCoSo.Enabled = true;
            bool isValid = ValidateEmpty();
            if (!isValid) return;
            btnHuy.Enabled = btnGhi.Enabled = false;
            if (isThem)
            {
                String sql = "EXEC SP_KT_Khoa_Ton_Tai N'" + txtMaKhoa.Text.Trim() + "', N'" + txtTenKhoa.Text.Trim() + "'";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();

                    String kq = Program.myReader.GetString(0);
                    if (kq.Equals("1"))
                    {
                        txtMaKhoa.Focus();
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        XtraMessageBox.Show("Mã khoa đã tồn tại, vui lòng nhập mã khác", "", MessageBoxButtons.OK);
                        return;
                    }
                    else if (kq.Equals("2"))
                    {
                        txtTenKhoa.Focus();
                        btnHuy.Enabled = btnGhi.Enabled = true;
                        XtraMessageBox.Show("Tên khoa đã tồn tại, vui lòng nhập tên khác", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        string maKhoa = txtMaKhoa.Text.Trim();
                        WriteToDB();
                        bdsKhoa.Position = bdsKhoa.Find("MaKH", maKhoa);
                        isThem = false;
                        XtraMessageBox.Show("Thêm khoa thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Thêm khoa thất bại " + ex.Message, "", MessageBoxButtons.OK);
                }
                finally
                {
                    Program.myReader.Close();
                }
            }
            else if (isSua)
            {
                String sql = "EXEC SP_KT_Sua_Khoa_Ton_Tai '" + txtMaKhoa.Text.Trim() + "', N'" + txtTenKhoa.Text.Trim() + "'";
                try
                {
                    int kq = Program.ExecSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        txtTenKhoa.Focus();
                        return;
                    }
                    else
                    {
                        string maKhoa = txtMaKhoa.Text.Trim();
                        WriteToDB();
                        isSua = false;
                        bdsKhoa.Position = bdsKhoa.Find("MAKH", maKhoa);
                        XtraMessageBox.Show("Sửa khoa thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Sửa khoa thất bại " + ex.Message, "", MessageBoxButtons.OK);
                }
                finally
                {
                    Program.conn.Close();
                }
            }
            else return;
        }
        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tbKhoa.Connection.ConnectionString = Program.connstr;
                this.tbKhoa.Fill(this.DS.KHOA);
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
                if (XtraMessageBox.Show("Bạn đang tạo mới khoa, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }
            else if (isSua == true)
            {
                if (XtraMessageBox.Show("Bạn đang sửa khoa, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }
            }

            if (isThemLop == true)
            {
                if (XtraMessageBox.Show("Bạn đang tạo mới lớp học, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiLop_Click(sender, e);
                }
            }
            else if (isSuaLop == true)
            {
                if (XtraMessageBox.Show("Bạn đang sửa lớp học, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiLop_Click(sender, e);
                }
            }
            this.Close();
        }
        public bool ValidateEmpty()
        {
            if (txtMaKhoa.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Mã khoa không được để trống ", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }

            if (txtTenKhoa.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Tên khoa không được để trống ", "", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return false;
            }

            if (txtMaKhoa.Text.Trim().Length > 8)
            {
                XtraMessageBox.Show("Mã khoa không được lớn hơn 8 kí tự ", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }
            if (txtMaKhoa.Text.Trim().Length <3)
            {
                XtraMessageBox.Show("Mã khoa không được bé hơn 3 kí tự ", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }
            if (txtTenKhoa.Text.Trim().Length > 50)
            {
                XtraMessageBox.Show("Tên khoa không được lớn hơn 50 kí tự ", "", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return false;
            }
            if (txtTenKhoa.Text.Trim().Length < 4)
            {
                XtraMessageBox.Show("Tên khoa không được bé hơn 5 kí tự ", "", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return false;
            }
            if (txtActivate.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Loại không được để trống ", "", MessageBoxButtons.OK);
                txtActivate.Focus();
                return false;
            }
            if (txtActivate.Text.Trim() != "1" && txtActivate.Text.Trim() != "2")
            {
                XtraMessageBox.Show("Loại phải là 1(Khoa) hoặc 2(PGV) ", "", MessageBoxButtons.OK);
                txtActivate.Focus();
                return false;
            }
            return true;
        }
        private void WriteToDB()
        {
            gcKhoa.Enabled = gcLop.Enabled = true;
            txtMaKhoa.Enabled = txtTenKhoa.Enabled=txtActivate.Enabled = false;
            ctxMenuLop.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled  = btnTaiLai.Enabled=true;
            try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.tbKhoa.Update(this.DS.KHOA);
                this.tbKhoa.Connection.ConnectionString = Program.connstr;
                this.tbKhoa.Fill(this.DS.KHOA);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi khoa" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        // LOP
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                cbbCoSo.Enabled = false;
                gcKhoa.Enabled = false;
                gcLop.Enabled = true;
                btnGhiLop.Enabled = btnHuyLop.Enabled=cbbTenKhoa.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled
                    = btnHuy.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;
                bdsLop.AddNew();
                isThemLop = true;
                txtMaLop.Enabled = txtTenLop.Enabled = true;
                txtMaLop.Focus();
                btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnTaiLaiLop.Enabled =
                    btnUndoLop.Enabled = btnRedoLop.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi thêm lớp học " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                XtraMessageBox.Show("Không có lớp học để sửa!", "", MessageBoxButtons.OK);
            }
            else
            {
                cbbCoSo.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled
                   = btnHuy.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;
                btnGhiLop.Enabled = btnHuyLop.Enabled = true;
                gcLop.Enabled  = true;
                gcKhoa.Enabled = false;
                txtTenLop.Enabled = true;
                txtMaLop.Enabled = false;
                txtTenLop.Focus();
                isSuaLop = true;
                btnThemLop.Enabled = btnTaiLaiLop.Enabled = btnSuaLop.Enabled
                    = btnXoaLop.Enabled = btnUndoLop.Enabled = btnRedoLop.Enabled = false;
            }
        }
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                XtraMessageBox.Show("Không có lớp để xóa!", "", MessageBoxButtons.OK);
            }
            else
            {
                if (bdsSinhVien.Count > 0)
                {
                    XtraMessageBox.Show("Lớp học đã có sinh viên, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsDangKyThi.Count > 0)
                {
                    XtraMessageBox.Show("Lớp học đã có đăng ký thi, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }

                if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa lớp học: " + ((DataRowView)this.bdsLop.Current).Row["TENLOP"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string maLop = "";
                    try
                    {
                        maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString().Trim();
                        bdsLop.RemoveCurrent();
                        this.tbLop.Update(this.DS.LOP);
                        this.tbLop.Connection.ConnectionString = Program.connstr;
                        this.tbLop.Fill(this.DS.LOP);
                        XtraMessageBox.Show("Xóa lớp thành công!", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa lớp học " + ex.Message, "", MessageBoxButtons.OK);
                        this.tbLop.Fill(this.DS.LOP);
                        bdsLop.Position = bdsLop.Find("MALOP", maLop);
                        return;
                    }
                }
                else return;
            }
        }
        private void btnHuyLop_Click(object sender, EventArgs e)
        {
            cbbCoSo.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = true;
            bdsLop.CancelEdit();
            btnHuyLop.Enabled = btnGhiLop.Enabled = false;
            isSuaLop = isThemLop = false;
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            cbbTenKhoa.Enabled = false;
            btnThemLop.Enabled = btnTaiLaiLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = true;
            this.tbLop.Connection.ConnectionString = Program.connstr;
            this.tbLop.Fill(this.DS.LOP);
            gcLop.Enabled = gcKhoa.Enabled = true;
        }
        private void btnGhiLop_Click(object sender, EventArgs e)
        {
            cbbCoSo.Enabled = true;
            bool isValid = ValidateEmptyLop();
            if (!isValid) return;
            btnHuyLop.Enabled = btnGhiLop.Enabled = false;
            if (isThemLop)
            {
                String sql = "EXEC SP_KT_Lop_Ton_Tai '" + txtMaLop.Text.Trim() + "', N'" + txtTenLop.Text.Trim() + "', N'" + cbbTenKhoa.Text.Trim() + "'";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    String kq = Program.myReader.GetString(0);
                    if (kq.Equals("1"))
                    {
                        txtMaLop.Focus();
                        btnHuyLop.Enabled = btnGhiLop.Enabled = true;
                        XtraMessageBox.Show("Mã lớp học đã tồn tại, vui lòng nhập mã khác", "", MessageBoxButtons.OK);
                        return;
                    }
                    else if (kq.Equals("2"))
                    {
                        txtTenLop.Focus();
                        btnHuyLop.Enabled = btnGhiLop.Enabled = true;
                        XtraMessageBox.Show("Tên lớp học đã tồn tại, vui lòng nhập tên khác", "", MessageBoxButtons.OK);
                        return;
                    }
                    else if (kq.Equals("3"))
                    {
                        cbbTenKhoa.Focus();
                        btnHuyLop.Enabled = btnGhiLop.Enabled = true;
                        XtraMessageBox.Show("Không thể tạo lớp cho Phòng giáo vụ, vui lòng chọn khoa khác", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        string maLop = txtMaLop.Text.Trim();
                        WriteToDBLop();
                        bdsLop.Position = bdsLop.Find("MALOP", maLop);
                        isThemLop = false;
                        XtraMessageBox.Show("Thêm lớp thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi ghi lớp học " + ex.Message, "", MessageBoxButtons.OK);
                }
                finally
                {
                    Program.myReader.Close();
                }
            }
            else if (isSuaLop)
            {
                String sql = "EXEC SP_KT_Sua_Lop_Ton_Tai '" + txtMaLop.Text.Trim() + "', N'" + txtTenLop.Text.Trim() + "'";
                try
                {
                    int kq = Program.ExecSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        txtTenLop.Focus();
                        return;
                    }
                    else
                    {
                        string maLop = txtMaLop.Text.Trim();
                        WriteToDBLop();
                        isSuaLop = false;
                        bdsLop.Position = bdsLop.Find("MALOP", maLop);
                        XtraMessageBox.Show("Sửa lớp thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi sửa lớp " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                finally
                {
                    Program.conn.Close();
                }
            }
            else return;
        }
        private void btnTaiLaiLop_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbLop.Connection.ConnectionString = Program.connstr;
                this.tbLop.Fill(this.DS.LOP);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void WriteToDBLop()
        {
            btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = true;
            gcLop.Enabled = gcKhoa.Enabled = true;
            txtTenLop.Enabled = cbbTenKhoa.Enabled = txtMaLop.Enabled = false;
            btnThemLop.Enabled = btnTaiLaiLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = true;
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.tbLop.Update(this.DS.LOP);
                this.tbLop.Connection.ConnectionString = Program.connstr;
                this.tbLop.Fill(this.DS.LOP);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi lớp học" + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        public bool ValidateEmptyLop()
        {
            if (txtMaLop.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Mã lớp học không được để trống ", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            if (txtTenLop.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Tên lớp học không được để trống ", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            if (cbbTenKhoa.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Khoa không được để trống ", "", MessageBoxButtons.OK);
                return false;
            }
            if (txtMaLop.Text.Trim().Length > 15)
            {
                XtraMessageBox.Show("Mã lớp không được lớn hơn 15 kí tự ", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            if (txtMaLop.Text.Trim().Length < 3)
            {
                XtraMessageBox.Show("Mã lớp không được bé hơn 3 kí tự ", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }
            if (txtTenLop.Text.Trim().Length > 40)
            {
                XtraMessageBox.Show("Tên lớp không được lớn hơn 40 kí tự ", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            if (txtTenLop.Text.Trim().Length <3)
            {
                XtraMessageBox.Show("Tên lớp không được bé hơn 3 kí tự ", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            return true;
        }
    }
}
