using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_QuanLy
{
    public partial class FormHomeQuanLy : Form
    {
        public FormHomeQuanLy()
        {
            InitializeComponent();
        }

        private void btn_nhapLichChuyenBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapLichChuyenBay nhapLichChuyenBay_I = new NhapLichChuyenBay();
            nhapLichChuyenBay_I.ShowDialog();
        }
    }
}
