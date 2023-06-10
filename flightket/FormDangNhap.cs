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
            cb_hienMatKhau.Checked = false;
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
           
            if (Properties.Settings.Default.SoundEnabled)
            {
                mediaPlayer.Position = TimeSpan.Zero;
                mediaPlayer.Play();
            }
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin xác thực!");
                return;
            }
            if (username == "admin" && password == "admin")
            {
                this.Hide();
                FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
                formHomeAdmin.ShowDialog();
                return;
            }
            else if (username == "nhanvien" && password == "nhanvien")
            {
                this.Hide();
                cb_hienMatKhau.Checked = false;
                tb_username.Text = "";
                tb_password.Text = "";
                FormHomeNhanVien formHomeNhanVien = new FormHomeNhanVien();
                formHomeNhanVien.ShowDialog();
                return;
            }
            else if (username == "quanly" && password == "quanly")
            {
                this.Hide();
                cb_hienMatKhau.Checked = false;
                tb_username.Text = "";
                tb_password.Text = "";
                FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
                formHomeQuanLy.ShowDialog();
                return;
            }
            using (var db = new FlightKetDBEntities())
            {
                var result = db.NHANVIENs.ToList();
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].UserName.Equals(username))
                    {
                        if (result[i].PassWord.Equals(password))
                        {
                            if (result[i].RoleID.Equals("NVSB1"))
                            {
                                this.Hide();
                                cb_hienMatKhau.Checked = false;
                                tb_username.Text = "";
                                tb_password.Text = "";
                                FormHomeNhanVien formHomeNhanVien = new FormHomeNhanVien();
                                formHomeNhanVien.ShowDialog();
                                return;
                            }
                            else if (result[i].RoleID.Equals("QULY1"))
                            {
                                this.Hide();
                                cb_hienMatKhau.Checked = false;
                                tb_username.Text = "";
                                tb_password.Text = "";
                                FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
                                formHomeQuanLy.ShowDialog();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu! Vui lòng thử lại");
                            return;
                        }
                    }

                }

                MessageBox.Show("Không tồn tại tài khoản! Vui lòng thử lại");
                return;

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
