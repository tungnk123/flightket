using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_NhanVien
{
    public partial class FormDatChoChuyenBay : Form
    {
        public bool isFormNhapThongTinKhOn = false;
        public static FormDatChoChuyenBay instance;
        public FormDatChoChuyenBay()
        {
            instance = this;
            InitializeComponent();
        }

        private void FormDatChoChuyenBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                isFormNhapThongTinKhOn = FormNhapThongTinKhachHang.instance.IsDisposed;
                if (!isFormNhapThongTinKhOn)
                {
                    FormHomeNhanVien.instance.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormDatChoChuyenBay.instance.Close();
            FormHomeNhanVien.instance.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormDatChoChuyenBay.instance.Close();
            FormHomeNhanVien.instance.Show();
        }

        // event test để chuyển qua FormNhapThongTinKhachHang
        private void btn_timChuyenBay_Click(object sender, EventArgs e)
        {
            isFormNhapThongTinKhOn = true;
            FormDatChoChuyenBay.instance.Close();
            FormNhapThongTinKhachHang formNhapThongTinKhachHang = new FormNhapThongTinKhachHang();
            formNhapThongTinKhachHang.Show();
        }



    }
}
