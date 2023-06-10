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
using System.Windows.Media;

namespace flightket
{
    public partial class FormDangNhap : Form
    {
        public static FormDangNhap instance;
        public static MediaPlayer mediaPlayer;
        public FormDangNhap()
        {
            instance = this;
            InitializeComponent();
            //cmt
            ////cmt
            try
            {
                if (Properties.Settings.Default.SoundEnabled)
                {
                    mediaPlayer = new MediaPlayer();
                    mediaPlayer.Open(new Uri("chillin39-20915.mp3", UriKind.Relative));
                    mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
                    mediaPlayer.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when playing background music: " + ex.Message);
            }
        }
        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            mediaPlayer.Position = TimeSpan.Zero;
            mediaPlayer.Play();
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
                FormDangNhap.mediaPlayer.Play();
            }
            else if (username == "nhanvien" && password == "nhanvien")
            {
                this.Hide();
                FormHomeNhanVien formHomeNhanVien = new FormHomeNhanVien();
                formHomeNhanVien.ShowDialog();
                FormDangNhap.mediaPlayer.Play();
            }
            else if (username == "" && password == "")
            {
                this.Hide();
                FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
                formHomeQuanLy.ShowDialog();
                FormDangNhap.mediaPlayer.Play();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void lb_quenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ Admin để được cấp lại thông tin đăng nhập!");
        }

        private void cb_hienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienMatKhau.Checked)
            {
                tb_password.UseSystemPasswordChar = true;
            }
            else
            {
                tb_password.UseSystemPasswordChar = false;
            }
        }
    }
}
