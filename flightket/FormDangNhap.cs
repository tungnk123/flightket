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
            }
            else if (username == "nhanvien" && password == "nhanvien")
            {
                this.Hide();
                FormHomeNhanVien formHomeNhanVien = new FormHomeNhanVien();
                formHomeNhanVien.ShowDialog();
            }
            else if (username == "" && password == "")
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
