using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace flightket.Forms_NhanVien
{

    public partial class FormDatCho : Form
    {
        private string maChuyenBay;
        private double giaVe;
        private string tenHangVe;
        private FormDatChoChuyenBay formParent;
        public FormDatCho()
        {
            InitializeComponent();
        }
        public FormDatCho(string maChuyenBay, double giaVe, string tenHangVe, FormDatChoChuyenBay formDatChoChuyenBay)
        {
            InitializeComponent();
            this.maChuyenBay = maChuyenBay;
            this.giaVe = giaVe;
            this.tenHangVe = tenHangVe;
            formParent = formDatChoChuyenBay;

            tb_maChuyenBay.Text = maChuyenBay;
            tb_giaTien.Text = giaVe.ToString();
            tb_hangVe.Text = tenHangVe;
        }
        private bool KiemTraSo(string so)
        {
            foreach (char c in so)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private bool KiemTraHoTen(string hoTen)
        {
            foreach (char c in hoTen)
            {
                if (!Char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_xacNhanDatCho_Click(object sender, EventArgs e)
        {
            string hoTen = tb_hoVaTen.Text;
            string cmnd = tb_CMND.Text;
            string soDienThoai = tb_soDienThoai.Text;

            if (tb_hoVaTen.Text.Length == 0 || tb_CMND.Text.Length == 0 || tb_soDienThoai.Text.Length == 0 || cb_gioiTinh.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return;
            }
            if (dp_ngaySinh.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh hợp lệ");
                return;
            }
            if (!KiemTraHoTen(hoTen) || !KiemTraSo(cmnd) || !KiemTraSo(soDienThoai))
            {
                MessageBox.Show("Thông tin không hợp lệ! Vui lòng nhập lại");
                return;
            }
            using (var db = new FlightKetDBEntities())
            {
                var querry = db.HANHKHACHes.Where(a => a.TenHanhKhach.Equals(tb_hoVaTen.Text) && a.CMND.Equals(tb_CMND.Text) && a.SDT.Equals(tb_soDienThoai.Text));
                var result = querry.ToList();
                if (result.Count > 0)
                {
                    var querry_maHangVe = db.HANGVEs.Where(a => a.TenHangVe.Equals(tb_hangVe.Text));
                    var maHangVe = querry_maHangVe.ToList().FirstOrDefault().MaHangVe;

                    db.PHIEUDATCHOes.Add(new PHIEUDATCHO() { MaHanhKhach = result.FirstOrDefault().MaHanhKhach, MaChuyenBay = this.maChuyenBay, MaHangVe = maHangVe, GiaTien = this.giaVe });
                    db.SaveChanges();
                    MessageBox.Show("Đặt chỗ thành công");
                    tb_hoVaTen.Text = "";
                    tb_CMND.Text = "";
                    tb_soDienThoai.Text = "";
                }
                else if (result.Count == 0)
                {
                    string gioiTinh = cb_gioiTinh.Text;
                    string maHanhkhach = "HK" + (db.HANHKHACHes.ToList().Count + 1).ToString();
                    if (cb_gioiTinh.Text == "Nữ")
                    {
                        gioiTinh = "Nu";
                    }

                    HANHKHACH hANHKHACH = new HANHKHACH() { MaHanhKhach = maHanhkhach, TenHanhKhach = tb_hoVaTen.Text, CMND = tb_CMND.Text, SDT = tb_soDienThoai.Text, NgaySinh = dp_ngaySinh.Value, GioiTinh = gioiTinh };
                    db.HANHKHACHes.Add(hANHKHACH);
                    db.SaveChanges();
                    string maHangVe = db.HANGVEs.Where(a => a.TenHangVe.Equals(tb_hangVe.Text)).ToList().FirstOrDefault().MaHangVe;
                    PHIEUDATCHO pHIEUDATCHO = new PHIEUDATCHO() { MaChuyenBay = maChuyenBay, MaHanhKhach = maHanhkhach, MaHangVe = maHangVe, GiaTien = Convert.ToDouble(tb_giaTien.Text) };
                    db.PHIEUDATCHOes.Add(pHIEUDATCHO);
                    db.SaveChanges();
                    MessageBox.Show("Đặt chỗ thành công");
                    tb_hoVaTen.Text = "";
                    tb_CMND.Text = "";
                    tb_soDienThoai.Text = "";
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            formParent.Close();
        }
    }
}
