using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        MyShortCut[] shortCutList = new MyShortCut[6];
        


        public FormCaiDat()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                shortCutList[i] = new MyShortCut();
            }
            cb_scBanVe.DataSource = scList1;
            cb_scKiemTra.DataSource = scList2;
            cb_scLapBaoCao.DataSource = scList3;
            cb_scNhapLieu.DataSource = scList4;
            cb_scXacNhan.DataSource = scList5;
            cb_scTraCuu.DataSource = scList6;

            // set data 
            if (shortCutList[0].firctStroke != null)
            {
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
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    shortCutList[i] = new MyShortCut();
                }



            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
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

            MessageBox.Show("Thay đổi cài đặt thành công!");
        }
        //private void LoadShortcutSettings()
        //{
        //    cb_scNhapLieu.Text = Properties.Settings.Default.Shortcut1;
        //    tb_scNhapLieu_right.Text = Properties.Settings.Default.Shortcut1Right;

        //    cb_scBanVe.Text = Properties.Settings.Default.Shortcut2;
        //    tb_scBanVe_right.Text = Properties.Settings.Default.Shortcut2Right;

        //    cb_scXacNhan.Text = Properties.Settings.Default.Shortcut3;
        //    tb_scXacNhan_right.Text = Properties.Settings.Default.Shortcut3Right;

        //    cb_scKiemTra.Text = Properties.Settings.Default.Shortcut4;
        //    tb_scKiemTraDatCho_right.Text = Properties.Settings.Default.Shortcut4Right;

        //    cb_scTraCuu.Text = Properties.Settings.Default.Shortcut5;
        //    tb_scTraCuu_right.Text = Properties.Settings.Default.Shortcut5Right;

        //    cb_scLapBaoCao.Text = Properties.Settings.Default.Shortcut6;
        //    tb_scLapBaoCao_right.Text = Properties.Settings.Default.Shortcut6Right;
        //}

        //private void UpdateShortcutSettings()
        //{
        //    Properties.Settings.Default.Shortcut1 = cb_scNhapLieu.Text;
        //    Properties.Settings.Default.Shortcut1Right = tb_scNhapLieu_right.Text;

        //    Properties.Settings.Default.Shortcut2 = cb_scBanVe.Text;
        //    Properties.Settings.Default.Shortcut2Right = tb_scBanVe_right.Text;

        //    Properties.Settings.Default.Shortcut3 = cb_scXacNhan.Text;
        //    Properties.Settings.Default.Shortcut3Right = tb_scXacNhan_right.Text;

        //    Properties.Settings.Default.Shortcut4 = cb_scKiemTra.Text;
        //    Properties.Settings.Default.Shortcut4Right = tb_scKiemTraDatCho_right.Text;

        //    Properties.Settings.Default.Shortcut5 = cb_scTraCuu.Text;
        //    Properties.Settings.Default.Shortcut5Right = tb_scTraCuu_right.Text;

        //    Properties.Settings.Default.Shortcut6 = cb_scLapBaoCao.Text;
        //    Properties.Settings.Default.Shortcut6Right = tb_scLapBaoCao_right.Text;
        //}
    }
}
