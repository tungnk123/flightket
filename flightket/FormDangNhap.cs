using flightket.Forms_Admin;
using flightket.Forms_NhanVien;
using flightket.Forms_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket
{
    public partial class FormDangNhap : Form
    {
        public static FormDangNhap instance;
        public FormDangNhap()
        {
            instance = this;
            InitializeComponent();
            //cmt
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            if (username == "admin" && password == "admin")
            {
                this.Hide();
                FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
                formHomeAdmin.ShowDialog();
            }
            else if (username == "nhanvien" && password == "nhanvien")
            {
                this.Hide();
                FormHomeNhanVien formHomeNhanVien = new FormHomeNhanVien();
                formHomeNhanVien.ShowDialog();
            }
            else if (username == "quanly" && password == "quanly")
            {
                this.Hide();
                FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
                formHomeQuanLy.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }
    }
}
