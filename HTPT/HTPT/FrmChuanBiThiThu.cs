using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTPT
{
    public partial class FrmChuanBiThiThu : Form
    {
        public FrmChuanBiThiThu()
        {
            InitializeComponent();
        }

        private void FrmChuanBiThiThu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.tbDangKyThi.Connection.ConnectionString = Program.connstr;
            this.tbDangKyThi.Fill(this.DS.DANGKYTHI);
            bdsDangKyThi.Filter = string.Format("NGAYTHI >= #{0}#", DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));
            bdsDangKyThi.Sort = "NGAYTHI ASC";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            if (bdsDangKyThi.Count > 0)
            {
                FrmThi.id_dangkythi = Int32.Parse(((DataRowView)this.bdsDangKyThi.Current).Row["ID_DANGKYTHI"].ToString().Trim());
                FrmThi.maMH = ((DataRowView)this.bdsDangKyThi.Current).Row["MAMH"].ToString().Trim();
                FrmThi.trinhDo = ((DataRowView)this.bdsDangKyThi.Current).Row["TRINHDO"].ToString().Trim();
                FrmThi.lan = Int32.Parse(((DataRowView)this.bdsDangKyThi.Current).Row["LAN"].ToString().Trim());
                FrmThi.maLop = ((DataRowView)this.bdsDangKyThi.Current).Row["MALOP"].ToString().Trim();
                FrmThi.ngaythi = Convert.ToDateTime(((DataRowView)this.bdsDangKyThi.Current).Row["NGAYTHI"]);
                FrmThi.thoiGian = Int32.Parse(((DataRowView)this.bdsDangKyThi.Current).Row["THOIGIAN"].ToString().Trim());
                FrmThi.soCau = Int32.Parse(((DataRowView)this.bdsDangKyThi.Current).Row["SOCAUTHI"].ToString().Trim());
                FrmThi.soCauCS1 = Int32.Parse(((DataRowView)this.bdsDangKyThi.Current).Row["CAUHOI_CS1"].ToString().Trim());
                FrmThi.soCauCS2 = Int32.Parse(((DataRowView)this.bdsDangKyThi.Current).Row["CAUHOI_CS2"].ToString().Trim());
                this.Close();
                Program.frmThi = new FrmThi();
                Program.frmThi.Activate();
                Program.frmThi.Show();
                this.Visible = false;
            }
            else
            {
                XtraMessageBox.Show("Chưa có lịch giáo viên đăng ký nào để thi thử!", "", MessageBoxButtons.OK);
            }
        }
    }
}
