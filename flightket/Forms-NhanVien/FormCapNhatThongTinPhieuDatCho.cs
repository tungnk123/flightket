using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace flightket.Forms_NhanVien
{
    public partial class FormCapNhatThongTinPhieuDatCho : Form
    {
        private PHIEUDATCHO pHIEUDATCHO;
        private HANHKHACH hANHKHACH;
        private CHUYENBAY cHUYENBAY;
        private HANGVE hANGVE;
        private FormKiemTraDatCho formparent;

        private string maHanhKhach;
        private int maPhieuDatCho;
        private string maChuyenBay;
        public FormCapNhatThongTinPhieuDatCho()
        {
            InitializeComponent();
        }
        public FormCapNhatThongTinPhieuDatCho(int maPhieuDatCho, string maChuyenBay, string maHanhKhach, string maHangVe, FormKiemTraDatCho formCapNhatThongTinPhieuDatCho)
        {
            InitializeComponent();
            formparent = formCapNhatThongTinPhieuDatCho;

            using (FlightKetDBEntities db = new FlightKetDBEntities())
            {
                pHIEUDATCHO = db.PHIEUDATCHOes.Find(maPhieuDatCho);
                hANHKHACH = db.HANHKHACHes.Find(maHanhKhach);
                cHUYENBAY = db.CHUYENBAYs.Find(maChuyenBay);
                hANGVE = db.HANGVEs.Find(maHangVe);

                this.maHanhKhach = maHanhKhach;
                this.maPhieuDatCho = maPhieuDatCho;
                this.maChuyenBay = maChuyenBay;

                tb_hoVaTen.Text = hANHKHACH.TenHanhKhach;
                tb_soDienThoai.Text = hANHKHACH.SDT;
                tb_CMND.Text = hANHKHACH.CMND;
                cb_gioiTinh.Text = hANHKHACH.GioiTinh;
                dateTimePicker1.Value = hANHKHACH.NgaySinh.Value;

                var querry = from cb in db.CHUYENBAYs
                             from hv in db.HANGVEs
                             from cthv in db.CT_HANGVE
                             where cb.MaChuyenBay.Equals(cthv.MaChuyenBay) && cthv.MaHangVe.Equals(hv.MaHangVe) && cb.MaChuyenBay.Equals(maChuyenBay)
                             select new { hv.TenHangVe };
                var list = querry.ToList();
                cb_hangVe.Items.Clear();
                foreach (var item in list)
                {
                    cb_hangVe.Items.Add(item.TenHangVe);
                }
                cb_hangVe.Text = hANGVE.TenHangVe;

            }

        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận cập nhật", "FlightKet - Cập nhật thông tin khách hàng", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                using (var db = new FlightKetDBEntities())
                {
                    HANHKHACH hANHKHACH1 = db.HANHKHACHes.Find(this.maHanhKhach);
                    PHIEUDATCHO pHIEUDATCHO1 = db.PHIEUDATCHOes.Find(this.maPhieuDatCho);
                    CHUYENBAY cHUYENBAY = db.CHUYENBAYs.Find(this.maChuyenBay);

                    hANHKHACH1.TenHanhKhach = tb_hoVaTen.Text;
                    hANHKHACH1.CMND = tb_CMND.Text;
                    hANHKHACH1.NgaySinh = dateTimePicker1.Value;
                    hANHKHACH1.SDT = tb_soDienThoai.Text;

                    //var querry = from pdc in db.PHIEUDATCHOes
                    //             from hv in db.HANGVEs
                    //             where pdc.MaHangVe.Equals(hv.MaHangVe) && hv.TenHangVe.Equals(cb_hangVe.Text)
                    //             select new { hv.MaHangVe, hv.TiLeDonGia };
                    var result1 = db.HANGVEs.Where(c => c.TenHangVe == cb_hangVe.Text).ToList();
                    var result = result1.ToList().FirstOrDefault();
                    pHIEUDATCHO1.MaHangVe = result.MaHangVe;
                    pHIEUDATCHO1.GiaTien = (cHUYENBAY.GiaVe * result.TiLeDonGia) / 100;
                    db.SaveChanges();
                }
                MessageBox.Show("Cập nhật thông tin thành công");
                this.Close();
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            formparent.Close();
        }
    }
}
