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

        private void btn_thayDoiQuiDinh_Click(object sender, EventArgs e)
        {
            FormThayDoiQuiDinh formThayDoiQuiDinh = new FormThayDoiQuiDinh();
            this.Hide();
            formThayDoiQuiDinh.ShowDialog();
        }

        private void btn_quanLyHoSo_Click(object sender, EventArgs e)
        {
            FormQuanLyHoSoNhanVien formQuanLyHoSoNhanVien = new FormQuanLyHoSoNhanVien();
            this.Hide();
            formQuanLyHoSoNhanVien.ShowDialog();
        }
    }
}
