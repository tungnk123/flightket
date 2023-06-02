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
    public partial class FormThayDoiChiTietSoHangVe : Form
    {
        public FormThayDoiChiTietSoHangVe()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.White);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormThayDoiQuiDinh formThayDoiQuiDinh = new FormThayDoiQuiDinh();
            this.Hide();
            formThayDoiQuiDinh.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
            this.Hide();
            formHomeQuanLy.ShowDialog();
        }
    }
}
