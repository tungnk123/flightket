using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_NhanVien
{
    public partial class FormDatChoChuyenBay : Form
    {
        public FormDatChoChuyenBay()
        {
            InitializeComponent();
        }

        private void FormDatChoChuyenBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            FormHomeNhanVien.instance.Show();
        }

    }
}
