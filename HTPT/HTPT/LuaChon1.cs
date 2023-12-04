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
    public partial class LuaChon1 : UserControl
    {
        public LuaChon1(CauHoi ch)
        {
            InitializeComponent();
            this.cauhoi = ch;

        }
        private string dapan;
        private string daChon = "";
        private CauHoi cauhoi;
        public string DapAn { get => dapan; set { dapan = value; } }

        public void radioBoxChangedListView(String daChon)
        {
            String[] arr = new string[2];
            arr[0] = "Câu " + cauhoi.CauSo;
            arr[1] = cauhoi.DaChon;
            ListViewItem baiThi = new ListViewItem(arr);
            Program.frmThi.listViewDAChon.Items[cauhoi.CauSo - 1] = baiThi;
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            cauhoi.DaChon = "Yes";
            radioBoxChangedListView(daChon);
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            cauhoi.DaChon = "No";
            radioBoxChangedListView(daChon);
        }
    }
}
