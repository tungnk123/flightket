using System;
using System.Windows.Forms;

namespace flightket.Forms_NhanVien
{
    public partial class FormHomeNhanVien : Form
    {
        public static FormHomeNhanVien instance;
        private bool isDatChoChuyenBayShown;

        public FormHomeNhanVien()
        {
            this.KeyPreview = true;
            this.KeyDown += FormHomeNhanVien_KeyDown;
            instance = this;
            InitializeComponent();

        }

        private void btn_datChoChuyenBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDatChoChuyenBay formDatChoChuyenBay = new FormDatChoChuyenBay();
            formDatChoChuyenBay.ShowDialog();
            if (formDatChoChuyenBay.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btn_kiemTraDatCho_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKiemTraDatCho formKiemTraDatCho = new FormKiemTraDatCho(); ;
            formKiemTraDatCho.ShowDialog();
            if (formKiemTraDatCho.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btn_banVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBanVeChuyenBay formBanVeChuyenBay = new FormBanVeChuyenBay();
            formBanVeChuyenBay.ShowDialog();
            if (formBanVeChuyenBay.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btn_traCuuChuyenBay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTraCuuChuyenBay formTraCuuChuyenBay = new FormTraCuuChuyenBay();
            formTraCuuChuyenBay.ShowDialog();
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
            if (Properties.Settings.Default.SoundEnabled)
            {
                FormDangNhap.mediaPlayer.Stop();
            }
        }

        private void FormHomeNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDangNhap.instance.Show();
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
                            //case 1:
                            //    this.Hide();
                            //    FormNhapLichChuyenBay formNhapLichChuyenBay = new FormNhapLichChuyenBay();
                            //    formNhapLichChuyenBay.FormClosed += (s, args) =>
                            //    {
                            //        this.Show();
                            //        isDatChoChuyenBayShown = false;
                            //    };
                            //    formNhapLichChuyenBay.Show();
                            //    isDatChoChuyenBayShown = true;
                            //    e.Handled = true;
                            //    break;
                            case 2:
                                this.Hide();
                                FormBanVe formBanVe = new FormBanVe();
                                formBanVe.FormClosed += (s, args) =>
                                {
                                    this.Show();
                                    isDatChoChuyenBayShown = false;
                                };
                                formBanVe.Show();
                                isDatChoChuyenBayShown = true;
                                e.Handled = true;
                                break;
                            case 3:
                                this.Hide();
                                FormDatChoChuyenBay formDatChoChuyenBay = new FormDatChoChuyenBay();
                                formDatChoChuyenBay.FormClosed += (s, args) =>
                                {
                                    this.Show();
                                    isDatChoChuyenBayShown = false;
                                };
                                formDatChoChuyenBay.Show();
                                isDatChoChuyenBayShown = true;
                                e.Handled = true;
                                break;
                            case 4:
                                this.Hide();
                                FormKiemTraDatCho formKiemTraDatCho = new FormKiemTraDatCho();
                                formKiemTraDatCho.FormClosed += (s, args) =>
                                {
                                    this.Show();
                                    isDatChoChuyenBayShown = false;
                                };
                                formKiemTraDatCho.Show();
                                isDatChoChuyenBayShown = true;
                                e.Handled = true;
                                break;
                            case 5:
                                this.Hide();
                                FormTraCuuChuyenBay formTraCuuChuyenBay = new FormTraCuuChuyenBay();
                                formTraCuuChuyenBay.FormClosed += (s, args) =>
                                {
                                    this.Show();
                                    isDatChoChuyenBayShown = false;
                                };
                                formTraCuuChuyenBay.Show();
                                isDatChoChuyenBayShown = true;
                                e.Handled = true;
                                break;
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
