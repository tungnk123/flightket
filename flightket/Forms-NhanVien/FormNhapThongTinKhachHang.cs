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
    public partial class FormNhapThongTinKhachHang : Form
    {
        public static FormNhapThongTinKhachHang instance;
        public FormNhapThongTinKhachHang()
        {
            instance = this;
            InitializeComponent();
        }

        private void FormNhapThongTinKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDatChoChuyenBay.instance.Show();
            
        }
    }
}
