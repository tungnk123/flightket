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
    public partial class FormBanVe : Form
    {
        private string maChuyenBay;
        private double giaVe;
        private string tenHangVe;
        private FormBanVeChuyenBay formParent;
        public FormBanVe()
        {
            InitializeComponent();
        }
        public FormBanVe(string maChuyenBay, double giaVe, string tenHangVe, FormBanVeChuyenBay formParent)
        {
            InitializeComponent();
            this.maChuyenBay = maChuyenBay;
            this.giaVe = giaVe;
            this.tenHangVe = tenHangVe;

            tb_maChuyenBay.Text = maChuyenBay;
            tb_giaTien.Text = giaVe.ToString();
            tb_hangVe.Text = tenHangVe;
            this.formParent = formParent;
        }

        private void btn_xacNhanBanVe_Click(object sender, EventArgs e)
        {
            if(tb_hoVaTen.Text.Length == 0 || tb_CMND.Text.Length == 0 || tb_soDienThoai.Text.Length == 0 || cb_gioiTinh.Text.Length == 0) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return;
            }
            if(dp_ngaySinh.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh hợp lệ");
                return;
            }
            using(var db = new FlightKetDBEntities())
            {
                var querry = db.HANHKHACHes.Where(a => a.TenHanhKhach.Equals(tb_hoVaTen.Text) && a.CMND.Equals(tb_CMND.Text) && a.SDT.Equals(tb_soDienThoai.Text));
                var result = querry.ToList();
                if(result.Count > 0)
                {
                    var querry_maHangVe = db.HANGVEs.Where(a => a.TenHangVe.Equals(tb_hangVe.Text));
                    var maHangVe = querry_maHangVe.ToList().FirstOrDefault().MaHangVe;

                    db.VECHUYENBAYs.Add(new VECHUYENBAY() { MaHanhKhach = result.FirstOrDefault().MaHanhKhach, MaChuyenBay = this.maChuyenBay, MaHangVe = maHangVe, GiaTien = this.giaVe });
                    db.SaveChanges();
                    MessageBox.Show("Đặt chỗ thành công");
                    this.Close();
                }
                else if(result.Count == 0)
                {
                    string maHanhkhach = "HK" + (db.HANHKHACHes.ToList().Count + 1).ToString();
                    HANHKHACH hANHKHACH = new HANHKHACH() { MaHanhKhach = maHanhkhach, TenHanhKhach = tb_hoVaTen.Text, CMND = tb_CMND.Text, SDT = tb_soDienThoai.Text, NgaySinh = dp_ngaySinh.Value, GioiTinh = cb_gioiTinh.Text };
                    db.HANHKHACHes.Add(hANHKHACH);
                    db.SaveChanges();
                    string maHangVe = db.HANGVEs.Where(a => a.TenHangVe.Equals(tb_hangVe.Text)).ToList().FirstOrDefault().MaHangVe;
                    VECHUYENBAY vECHUYENBAY = new VECHUYENBAY() { MaChuyenBay = maChuyenBay, MaHanhKhach = maHanhkhach, MaHangVe = maHangVe, GiaTien = Convert.ToDouble(tb_giaTien.Text) };
                    db.VECHUYENBAYs.Add(vECHUYENBAY);
                    db.SaveChanges();
                    MessageBox.Show("Đặt chỗ thành công");
                    this.Close();
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
