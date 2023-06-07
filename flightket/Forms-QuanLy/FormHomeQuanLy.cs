using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_QuanLy
{
    public partial class FormHomeQuanLy : Form
    {
        public FormHomeQuanLy()
        {
            InitializeComponent();
        }

        private void btn_nhapLichChuyenBay_Click(object sender, EventArgs e)
        {
            
            NhapLichChuyenBay nhapLichChuyenBay_I = new NhapLichChuyenBay();
            nhapLichChuyenBay_I.PreviousForm = this;
            nhapLichChuyenBay_I.ShowDialog();
            this.Hide();
        }

        private void btn_lapBaoCao_Click(object sender, EventArgs e)
        {
            
            LapBaoCao_Main lapBaoCao_Main = new LapBaoCao_Main();
            lapBaoCao_Main.PreviousForm = this;
            lapBaoCao_Main.ShowDialog();
            this.Hide();
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
    }
}
