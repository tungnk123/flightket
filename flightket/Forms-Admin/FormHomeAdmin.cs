using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_Admin
{
    public partial class FormHomeAdmin : Form
    {
        public FormHomeAdmin()
        {
            InitializeComponent();
        }

        private void btn_taoNhomNguoiDung_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTaoNhomNguoiDung formTaoNhomNguoiDung = new FormTaoNhomNguoiDung();
            formTaoNhomNguoiDung.Show();
        }

        private void btn_quanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Close();
            FormQuanLyTaiKhoan formQuanLyTaiKhoan = new FormQuanLyTaiKhoan();
            formQuanLyTaiKhoan.Show();
        }

        private void btn_phanQuyen_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPhanQuyen formPhanQuyen = new FormPhanQuyen();
            formPhanQuyen.Show();
        }

        private void btn_caiDat_Click(object sender, EventArgs e)
        {

        }
    }
}
