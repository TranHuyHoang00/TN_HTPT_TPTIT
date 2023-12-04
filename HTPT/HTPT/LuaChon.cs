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
    public partial class LuaChon : UserControl
    {
        public LuaChon(CauHoi ch)
        {
            InitializeComponent();
            this.cauhoi = ch;

        }
        private string noiDung;
        private string thuTu;
        private string dapan;

        private string daChon = "";
        private CauHoi cauhoi;
        public string NoiDung { get => noiDung; set { noiDung = value; rbNoiDung.Text = noiDung; } }
        public string ThuTu { get => thuTu; set { thuTu = value; lbThuTu.Text = thuTu; } }
        public string DapAn { get => dapan; set { dapan = value; } }


        private void rbNoiDung_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                foreach (LuaChon lc in cauhoi.flowLC.Controls.OfType<LuaChon>())
                {
                    if (lc.rbNoiDung == rb)
                    {
                        continue;
                    }
                    lc.rbNoiDung.Checked = false;
                }
                
            }
            cauhoi.DaChon = dapan;
            radioBoxChangedListView(daChon);
        }
        public void radioBoxChangedListView(String daChon)
        {
            String[] arr = new string[2];
            arr[0] = "Câu " + cauhoi.CauSo;
            arr[1] = cauhoi.DaChon;
            ListViewItem baiThi = new ListViewItem(arr);
            Program.frmThi.listViewDAChon.Items[cauhoi.CauSo - 1] = baiThi;
        }
    }
}
