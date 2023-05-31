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
    public partial class NhapLichChuyenBay_I : Form
    {
        public NhapLichChuyenBay_I()
        {
            InitializeComponent();

            updateUI();
        }

        private void updateUI()
        {
            panel1.BackColor = Color.FromArgb(128, 255, 0, 0);

        }

        
    }
}
