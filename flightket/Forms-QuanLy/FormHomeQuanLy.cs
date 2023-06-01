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
        public static UserControlThayDoiQuiDinh userControlThayDoiQuiDinh;
        public static UserControlQuanLyHoSoNhanVien userControlQuanLyHoSoNhanVien;
        public FormHomeQuanLy()
        {
            InitializeComponent();
            _init();
        }

        private void btn_thayDoiQuiDinh_Click(object sender, EventArgs e)
        {
            this.panelControl.Visible = false;
            this.panelUserControl.Visible = true;
            userControlThayDoiQuiDinh.Visible = true;
            userControlQuanLyHoSoNhanVien.Visible = false;
        }

        private void FormHomeQuanLy_Load(object sender, EventArgs e)
        {
            this.panelUserControl.Visible = false;
            this.panelUserControl.BackColor = Color.FromArgb(150, Color.White);
        }

        private void _init()
        {
            userControlThayDoiQuiDinh = new UserControlThayDoiQuiDinh();
            userControlQuanLyHoSoNhanVien = new UserControlQuanLyHoSoNhanVien();
            this.panelUserControl.Controls.Add(userControlThayDoiQuiDinh);
            this.panelControl.Controls.Add(userControlQuanLyHoSoNhanVien);
        }

        private void btn_quanLyHoSo_Click(object sender, EventArgs e)
        {
            this.panelControl.Visible = false;
            this.panelUserControl.Visible = true;
            userControlThayDoiQuiDinh.Visible = false;
            userControlQuanLyHoSoNhanVien.Visible = true;
        }
    }
}
