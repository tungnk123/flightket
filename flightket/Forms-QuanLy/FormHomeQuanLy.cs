using System;
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

            FormNhapLichChuyenBay nhapLichChuyenBay_I = new FormNhapLichChuyenBay();
            nhapLichChuyenBay_I.Show();
            this.Hide();
        }

        private void btn_lapBaoCao_Click(object sender, EventArgs e)
        {


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
