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
    public partial class FormHomeNhanVien : Form
    {
        public static FormHomeNhanVien instance;
        public FormHomeNhanVien()
        {
            instance = this;
            InitializeComponent();
        }

        private void btn_datChoChuyenBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDatChoChuyenBay formDatChoChuyenBay = new FormDatChoChuyenBay();
            formDatChoChuyenBay.ShowDialog();
        }

        private void btn_kiemTraDatCho_Click(object sender, EventArgs e)
        {

        }

        private void btn_banVe_Click(object sender, EventArgs e)
        {

        }

        private void btn_traCuuChuyenBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTraCuuChuyenBay formTraCuuChuyenBay = new FormTraCuuChuyenBay();
            formTraCuuChuyenBay.ShowDialog();
        }

        private void btn_lapBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btn_caiDat_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
                FormDangNhap.instance.Show();
            }
        }

        private void FormHomeNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDangNhap.instance.Show();
        }
    }
}
