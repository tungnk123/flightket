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
    public partial class NhapLichChuyenBay : Form
    {
        public NhapLichChuyenBay()
        {
            InitializeComponent();

            updateUI();
        }

        private void updateUI()
        {
            panel_main.BackColor = Color.FromArgb(128, 255, 0, 0);
            panel_sanbaytrunggian.Visible = false;


        }

        private void btnCB_dungOSanBay_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if(checkBox.Checked)
            {
               panel_sanbaytrunggian.Visible = true;
            } else
            {
                panel_sanbaytrunggian.Visible = false;
            }
        }
    }
}
