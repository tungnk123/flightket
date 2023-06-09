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
            nhapLichChuyenBay_I.ShowDialog();
            this.Hide();
            if(nhapLichChuyenBay_I.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btn_lapBaoCao_Click(object sender, EventArgs e)
        {


        }

        private void btn_thayDoiQuiDinh_Click(object sender, EventArgs e)
        {
            FormThayDoiQuiDinh formThayDoiQuiDinh = new FormThayDoiQuiDinh();
            this.Hide();
            formThayDoiQuiDinh.ShowDialog();
            this.Show();
        }

        private void btn_quanLyHoSo_Click(object sender, EventArgs e)
        {
            FormQuanLyHoSoNhanVien formQuanLyHoSoNhanVien = new FormQuanLyHoSoNhanVien();
            this.Hide();
            formQuanLyHoSoNhanVien.ShowDialog();
            this.Show();
        }

        private void FormHomeQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this == Application.OpenForms["FormHomeQuanLy"])
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả từ hộp thoại
                if (result == DialogResult.Yes)
                {
                    // Đóng ứng dụng nếu người dùng chọn Yes
                    Application.Exit();
                }
                else
                {
                    // Ngăn chặn đóng form nếu người dùng chọn No
                    e.Cancel = true;
                }
            }
        }
    }
}
