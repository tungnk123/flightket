using flightket.Forms_NhanVien;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace flightket
{
    public partial class FormCaiDat : Form
    {
        List<String> scList1 = new List<string> { "Ctrl", "Alt" };
        List<String> scList2 = new List<string> { "Ctrl", "Alt" };
        List<String> scList3 = new List<string> { "Ctrl", "Alt" };
        List<String> scList4 = new List<string> { "Ctrl", "Alt" };
        List<String> scList5 = new List<string> { "Ctrl", "Alt" };
        List<String> scList6 = new List<string> { "Ctrl", "Alt" };

        public static MyShortCut[] shortCutList = new MyShortCut[6]
        {
            new MyShortCut(),
            new MyShortCut(),
            new MyShortCut(),
            new MyShortCut(),
            new MyShortCut(),
            new MyShortCut(),
        };

        public FormCaiDat()
        {
            InitializeComponent();

            cb_scBanVe.DataSource = scList1;
            cb_scKiemTra.DataSource = scList2;
            cb_scLapBaoCao.DataSource = scList3;
            cb_scNhapLieu.DataSource = scList4;
            cb_scXacNhan.DataSource = scList5;
            cb_scTraCuu.DataSource = scList6;

            // Load shortcut settings
            LoadShortcutSettings();
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            // Update shortcut settings
            UpdateShortcutSettings();

            // Save the changes
            SaveShortcutSettings();

            MessageBox.Show("Thay đổi cài đặt thành công!");
        }

        private void LoadShortcutSettings()
        {
            // Set data from user settings
            shortCutList[0].firctStroke = Properties.Settings.Default.Shortcut1;
            shortCutList[0].secondStroke = Properties.Settings.Default.Shortcut1Right;

            shortCutList[1].firctStroke = Properties.Settings.Default.Shortcut2;
            shortCutList[1].secondStroke = Properties.Settings.Default.Shortcut2Right;

            shortCutList[2].firctStroke = Properties.Settings.Default.Shortcut3;
            shortCutList[2].secondStroke = Properties.Settings.Default.Shortcut3Right;

            shortCutList[3].firctStroke = Properties.Settings.Default.Shortcut4;
            shortCutList[3].secondStroke = Properties.Settings.Default.Shortcut4Right;

            shortCutList[4].firctStroke = Properties.Settings.Default.Shortcut5;
            shortCutList[4].secondStroke = Properties.Settings.Default.Shortcut5Right;

            shortCutList[5].firctStroke = Properties.Settings.Default.Shortcut6;
            shortCutList[5].secondStroke = Properties.Settings.Default.Shortcut6Right;

            // Set data to the controls
            cb_scNhapLieu.Text = shortCutList[0].firctStroke;
            tb_scNhapLieu_right.Text = shortCutList[0].secondStroke;

            cb_scBanVe.Text = shortCutList[1].firctStroke;
            tb_scBanVe_right.Text = shortCutList[1].secondStroke;

            cb_scXacNhan.Text = shortCutList[2].firctStroke;
            tb_scXacNhan_right.Text = shortCutList[2].secondStroke;

            cb_scKiemTra.Text = shortCutList[3].firctStroke;
            tb_scKiemTraDatCho_right.Text = shortCutList[3].secondStroke;

            cb_scTraCuu.Text = shortCutList[4].firctStroke;
            tb_scTraCuu_right.Text = shortCutList[4].secondStroke;

            cb_scLapBaoCao.Text = shortCutList[5].firctStroke;
            tb_scLapBaoCao_right.Text = shortCutList[5].secondStroke;
        }

        private void UpdateShortcutSettings()
        {
            // Update shortcut settings from the controls
            shortCutList[0].firctStroke = cb_scNhapLieu.Text;
            shortCutList[0].secondStroke = tb_scNhapLieu_right.Text;

            shortCutList[1].firctStroke = cb_scBanVe.Text;
            shortCutList[1].secondStroke = tb_scBanVe_right.Text;

            shortCutList[2].firctStroke = cb_scXacNhan.Text;
            shortCutList[2].secondStroke = tb_scXacNhan_right.Text;

            shortCutList[3].firctStroke = cb_scKiemTra.Text;
            shortCutList[3].secondStroke = tb_scKiemTraDatCho_right.Text;

            shortCutList[4].firctStroke = cb_scTraCuu.Text;
            shortCutList[4].secondStroke = tb_scTraCuu_right.Text;

            shortCutList[5].firctStroke = cb_scLapBaoCao.Text;
            shortCutList[5].secondStroke = tb_scLapBaoCao_right.Text;
        }

        private void SaveShortcutSettings()
        {
            // Save the shortcut settings to user settings
            Properties.Settings.Default.Shortcut1 = shortCutList[0].firctStroke;
            Properties.Settings.Default.Shortcut1Right = shortCutList[0].secondStroke;

            Properties.Settings.Default.Shortcut2 = shortCutList[1].firctStroke;
            Properties.Settings.Default.Shortcut2Right = shortCutList[1].secondStroke;

            Properties.Settings.Default.Shortcut3 = shortCutList[2].firctStroke;
            Properties.Settings.Default.Shortcut3Right = shortCutList[2].secondStroke;

            Properties.Settings.Default.Shortcut4 = shortCutList[3].firctStroke;
            Properties.Settings.Default.Shortcut4Right = shortCutList[3].secondStroke;

            Properties.Settings.Default.Shortcut5 = shortCutList[4].firctStroke;
            Properties.Settings.Default.Shortcut5Right = shortCutList[4].secondStroke;

            Properties.Settings.Default.Shortcut6 = shortCutList[5].firctStroke;
            Properties.Settings.Default.Shortcut6Right = shortCutList[5].secondStroke;

            // Save the changes
            Properties.Settings.Default.Save();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeNhanVien.instance.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeNhanVien.instance.Show();
        }
    }
}
