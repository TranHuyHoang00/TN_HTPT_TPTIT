using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTPT
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //// CHECK EXITS
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        //// ĐĂNG NHẬP
        private void btnDangNhap_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FrmDangNhap f = new FrmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        //// SHOW MENU
        public void HienThiMenu()
        {
            MASVGV.Text = "MÃ GV SV : " + Program.username;
            HOTEN.Text = "HỌ TÊN : " + Program.mHoten;
            NHOM.Text = "NHÓM : " + Program.mGroup;
            if (Program.mGroup == "PGV")
            {
                btnTaoTK.Enabled = btnDangXuat.Enabled = true;
                rbDanhMuc.Visible = rbBaoCao.Visible = true;
                btnThiThu.Enabled = btnMonHoc.Enabled = btnKhoa.Enabled = btnSinhVien.Enabled = btnGiaoVien.Enabled = btnDeThi.Enabled = btnGVDK.Enabled = true;
                btnThiThu.Enabled = false;
            }
            if (Program.mGroup == "KHOA")
            {
                btnTaoTK.Enabled = btnDangXuat.Enabled = true;
                rbDanhMuc.Visible = true;
                btnMonHoc.Enabled = btnDeThi.Enabled = btnKhoa.Enabled = btnSinhVien.Enabled = btnGiaoVien.Enabled = btnGVDK.Enabled = btnTaoTK.Enabled = true;
                btnThiThu.Enabled = false;
            }
            if (Program.mGroup == "GIANGVIEN")
            {
                btnDangXuat.Enabled = true;
                rbDanhMuc.Visible = true;
                btnMonHoc.Enabled = btnKhoa.Enabled = btnSinhVien.Enabled = btnGiaoVien.Enabled = btnGVDK.Enabled = btnTaoTK.Enabled = false;
                btnThiThu.Enabled = btnDeThi.Enabled = true;
            }
            if (Program.mGroup == "SINHVIEN")
            {
                btnDangXuat.Enabled = true;
                rbSinhVien.Visible = true;
            }
            if (Program.mGroup != "")
            {
                btnDangNhap.Enabled = false;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            rbDanhMuc.Visible = rbSinhVien.Visible = rbBaoCao.Visible = false;
            btnDangXuat.Enabled = btnTaoTK.Enabled = false;
        }
        ////// MÔN HỌC
        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FrmMonHoc f = new FrmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// KHOA VÀ LỚP
        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmKhoa));
            if (frm != null) frm.Activate();
            else
            {
                FrmKhoa f = new FrmKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// SINH VIÊN
        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                FrmSinhVien f = new FrmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }  
        ////// GIÁO VIÊN
        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                FrmGiaoVien f = new FrmGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// ĐĂNG XUÁT
        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<Form> formsToClose = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != "FrmMain") 
                {
                    formsToClose.Add(form);
                }
            }
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
            Program.username = "";
            Program.mHoten = "";
            Program.mGroup = "";
            this.HienThiMenu();
            rbDanhMuc.Visible = rbSinhVien.Visible = rbBaoCao.Visible = false;
            btnDangXuat.Enabled = btnTaoTK.Enabled = false;
            Form frm = this.CheckExists(typeof(FrmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FrmDangNhap f = new FrmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }
        ////// ĐỀ THI
        private void btnDeThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmBoDe));
            if (frm != null) frm.Activate();
            else
            {
                FrmBoDe f = new FrmBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// TẠO LOGIN
        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FrmTaoTaiKhoan f = new FrmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// ĐĂNG KÝ THI
        private void btnGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangKyThi));
            if (frm != null) frm.Activate();
            else
            {
                FrmDangKyThi f = new FrmDangKyThi();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// THI THỬ
        private void btnThiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmChuanBiThiThu));
            if (frm != null) frm.Activate();
            else
            {
                FrmChuanBiThiThu f = new FrmChuanBiThiThu();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// THI SV
        private void btnThiSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmChuanBiThiSV));
            if (frm != null) frm.Activate();
            else
            {
                FrmChuanBiThiSV f = new FrmChuanBiThiSV();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// KẾT QUẢ THI SV
        private void btnXemKQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmFilterXemKQThi));
            if (frm != null) frm.Activate();
            else
            {
                FrmFilterXemKQThi f = new FrmFilterXemKQThi();
                f.MdiParent = this;
                f.Show();
            }
        }
        ////// BẢNG ĐIỂM
        private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                FrmBangDiem f = new FrmBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
