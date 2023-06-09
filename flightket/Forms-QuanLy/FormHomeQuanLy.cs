using flightket.Forms_NhanVien;
using System;
using System.Windows.Forms;

namespace flightket.Forms_QuanLy
{
    public partial class FormHomeQuanLy : Form
    {
        private bool isDatChoChuyenBayShown;

        public FormHomeQuanLy()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += FormHomeNhanVien_KeyDown;
        }

        private void btn_nhapLichChuyenBay_Click(object sender, EventArgs e)
        {

            FormNhapLichChuyenBay nhapLichChuyenBay_I = new FormNhapLichChuyenBay();
            nhapLichChuyenBay_I.ShowDialog();
            this.Hide();
            if (nhapLichChuyenBay_I.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btn_lapBaoCao_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLapBaoCao formLapBaoCao = new FormLapBaoCao();
            formLapBaoCao.ShowDialog();
            if (formLapBaoCao.IsAccessible == false)
            {
                this.Show();
            }
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



        private void btn_caiDat_Click(object sender, EventArgs e)
        {
            FormCaiDat formCaiDat = new FormCaiDat();
            formCaiDat.Show();
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
        private void FormHomeNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                string pressedKey = e.KeyCode.ToString();

                for (int i = 1; i <= 6; i++)
                {
                    string shortcut = Properties.Settings.Default[$"Shortcut{i}"] as string;
                    string secondStroke = Properties.Settings.Default[$"Shortcut{i}Right"] as string;

                    if ((shortcut == pressedKey.ToUpper() || secondStroke == pressedKey.ToUpper()) && !isDatChoChuyenBayShown)
                    {
                        switch (i)
                        {
                            case 1:
                                this.Hide();
                                FormNhapLichChuyenBay formNhapLichChuyenBay = new FormNhapLichChuyenBay();
                                formNhapLichChuyenBay.FormClosed += (s, args) =>
                                {
                                    this.Show();
                                    isDatChoChuyenBayShown = false;
                                };
                                formNhapLichChuyenBay.Show();
                                isDatChoChuyenBayShown = true;
                                e.Handled = true;
                                break;
                            //case 2:
                            //    this.Hide();
                            //    FormBanVe formBanVe = new FormBanVe();
                            //    formBanVe.FormClosed += (s, args) =>
                            //    {
                            //        this.Show();
                            //        isDatChoChuyenBayShown = false;
                            //    };
                            //    formBanVe.Show();
                            //    isDatChoChuyenBayShown = true;
                            //    e.Handled = true;
                            //    break;
                            //case 3:
                            //    this.Hide();
                            //    FormDatChoChuyenBay formDatChoChuyenBay = new FormDatChoChuyenBay();
                            //    formDatChoChuyenBay.FormClosed += (s, args) =>
                            //    {
                            //        this.Show();
                            //        isDatChoChuyenBayShown = false;
                            //    };
                            //    formDatChoChuyenBay.Show();
                            //    isDatChoChuyenBayShown = true;
                            //    e.Handled = true;
                            //    break;
                            //case 4:
                            //    this.Hide();
                            //    FormKiemTraDatCho formKiemTraDatCho = new FormKiemTraDatCho();
                            //    formKiemTraDatCho.FormClosed += (s, args) =>
                            //    {
                            //        this.Show();
                            //        isDatChoChuyenBayShown = false;
                            //    };
                            //    formKiemTraDatCho.Show();
                            //    isDatChoChuyenBayShown = true;
                            //    e.Handled = true;
                            //    break;
                            //case 5:
                            //    this.Hide();
                            //    FormTraCuuChuyenBay formTraCuuChuyenBay = new FormTraCuuChuyenBay();
                            //    formTraCuuChuyenBay.FormClosed += (s, args) =>
                            //    {
                            //        this.Show();
                            //        isDatChoChuyenBayShown = false;
                            //    };
                            //    formTraCuuChuyenBay.Show();
                            //    isDatChoChuyenBayShown = true;
                            //    e.Handled = true;
                            //    break;
                            case 6:
                                this.Hide();
                                FormLapBaoCao formLapBaoCao = new FormLapBaoCao();
                                formLapBaoCao.FormClosed += (s, args) =>
                                {
                                    this.Show();
                                    isDatChoChuyenBayShown = false;
                                };
                                formLapBaoCao.Show();
                                isDatChoChuyenBayShown = true;
                                e.Handled = true;
                                break;
                        }
                    }
                }
            }


        }

        
    }
}
