using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace flightket.Forms_QuanLy
{
    public partial class NhapLichChuyenBay : Form
    {
        private String[] listSanBayDi;
        private String[] listSanBayDen;
        private String[] listGioKhoiHanh_Gio;
        private String[] listGioKhoiHanh_Phut;
        private String[] listThoiGianBay_Gio;
        private String[] listThoiGianBay_Phut;
        private String[] listHangGhe;
        private String[] listTenSanBay;

        public NhapLichChuyenBay()
        {
            InitializeComponent();

            updateUI();
        }

        private void updateUI()
        {
            float opacityLevel = 0.1f;
            Color panelColor = Color.FromArgb((int)(opacityLevel * 255), Color.Red);
            panel_main.BackColor = panelColor;
            panel_sanbaytrunggian.Visible = false;

            cb_sanBayDi.DropDownStyle = ComboBoxStyle.DropDownList;
            listSanBayDi = new string[] { "Chọn" };
            cb_sanBayDi.Items.AddRange(listSanBayDi);

            listSanBayDen = new string[] { "Chọn" };
            cb_sanBayDen.Items.AddRange(listSanBayDen);

            listGioKhoiHanh_Gio = new string[24];
            listThoiGianBay_Gio = new string[24];
            for (int i = 0; i < 24; i++)
            {
                listGioKhoiHanh_Gio[i] = i.ToString("D2");
                listThoiGianBay_Gio[i] = i.ToString("D2");
            }
            cb_gioKhoiHanh.Items.AddRange(listGioKhoiHanh_Gio);
            cb_gioThoiGianBay.Items.AddRange(listThoiGianBay_Gio);

            listGioKhoiHanh_Phut = new string[60];
            listThoiGianBay_Phut = new string[60];
            for (int i = 0; i < 60; i++)
            {
                listGioKhoiHanh_Phut[i] = i.ToString("D2");
                listThoiGianBay_Phut[i] = i.ToString("D2");
            }
            cb_phutKhoiHanh.Items.AddRange(listGioKhoiHanh_Phut);
            cb_phutThoiGianBay.Items.AddRange(listThoiGianBay_Phut);

            listTenSanBay = new string[] { "Something" };
            cb_tenSanBay.Items.AddRange(listTenSanBay);




        }

        private void btnCB_dungOSanBay_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                panel_sanbaytrunggian.Visible = true;
            }
            else
            {
                panel_sanbaytrunggian.Visible = false;
            }
        }
    }
}
