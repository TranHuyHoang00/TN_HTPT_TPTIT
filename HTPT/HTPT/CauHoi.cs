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
    public partial class CauHoi : UserControl
    {
        public CauHoi()
        {
            InitializeComponent();
        }
        private int idCauHoi;
        private int cauSo;
        private string noiDung;
        private string daChon = "";
        private string dapAn = "";
        public int IdCauHoi { get => idCauHoi; set => idCauHoi = value; }
        public int CauSo { get => cauSo; set { cauSo = value; labelCauSo.Text = "Câu " + cauSo + ":"; } }
        public string NoiDung { get => noiDung; set { noiDung = value; labelNoiDung.Text = noiDung; } }
        public string DaChon { get => daChon; set => daChon = value; }
        public string DapAn { get => dapAn; set => dapAn = value; }
    }
}
