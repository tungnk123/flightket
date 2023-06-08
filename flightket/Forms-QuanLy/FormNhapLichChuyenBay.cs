using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data.Entity;
using System.Net;
using OfficeOpenXml.LoadFunctions.Params;

namespace flightket.Forms_QuanLy
{
    public partial class FormNhapLichChuyenBay : Form
    {
        public Form PreviousForm { get; set; }
        private int[] soLuongTungHangVe;
        public FormNhapLichChuyenBay()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            tb_maChuyenBay.Text = RandomStringGenerator.GenerateRandomString().ToString().ToUpper();
            using (var db = new FlightKetDBEntities())
            {
                var listSanBay = db.SANBAYs.ToList();
                foreach (var sanbay in listSanBay)
                {
                    cb_sanBayDi.Items.Add(sanbay.TenSanBay);
                    cb_sanBayDen.Items.Add(sanbay.TenSanBay);
                    cb_tenSanBayTrungGian.Items.Add(sanbay.TenSanBay);
                }
                var listHangVe = db.HANGVEs.ToList();
                foreach (var hangVe in listHangVe)
                {
                    cb_hangVe.Items.Add(hangVe.TenHangVe);
                }
                soLuongTungHangVe = new int[listHangVe.Count];
                for (int i = 0; i < listHangVe.Count; i++)
                {
                    soLuongTungHangVe[i] = 0;
                }

            }
        }

        private void chb_dungOSanBayTrungGian_CheckedChanged(object sender, EventArgs e)
        {
            panel_sanbaytrunggian.Visible = !panel_sanbaytrunggian.Visible;
        }

        private void cb_hangGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_soLuong.Text = soLuongTungHangVe[cb_hangVe.SelectedIndex].ToString();
        }

        private void btn_themHangGhe_Click(object sender, EventArgs e)
        {
            int soLuongGhe;
            try
            {
                soLuongGhe = Convert.ToInt32(tb_soLuong.Text);
                if (soLuongGhe <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng vé là số nguyên lơn hơn 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số lượng vé là số nguyên");
                return;
            }
            soLuongTungHangVe[cb_hangVe.SelectedIndex] = soLuongGhe;
            MessageBox.Show("Thêm hạng vé thành công");
        }

        private void pic_rndMaChuyenBay_Click(object sender, EventArgs e)
        {
            tb_maChuyenBay.Text = RandomStringGenerator.GenerateRandomString().ToString().ToUpper();
        }

        private void tb_maChuyenBay_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 5)
            {
                MessageBox.Show("Vui lòng chỉ nhập 5 kí tự");
                textBox.Text = String.Empty;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                THAMSO thamso = db.THAMSOes.FirstOrDefault();
                int soSanBayTrungGianToiDa = (int)thamso.SoSanBayTrungGianToiDa;
                int thoiGianDungToiThieu = (int)thamso.ThoiGianDungToiThieu;
                if (cb_tenSanBayTrungGian.Text.Length == 0 || tb_thoiGianDung.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin về sân bay trung gian và thời gian dừng");
                    return;
                }
                if (cb_tenSanBayTrungGian.Text == cb_sanBayDen.Text || cb_tenSanBayTrungGian.Text == cb_sanBayDi.Text)
                {
                    MessageBox.Show("Sân bay trung gian không được trùng với sân bay đi và sân bay đến");
                    return;
                }
                if (cb_sanBayDen.Text.Length == 0 || cb_sanBayDi.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền thông tin sân bay đi sân bay đến trước khi điền sân bay trung gian");
                    return;
                }
                try
                {
                    int thoiGianDung = Convert.ToInt32(tb_thoiGianDung.Text);
                    if (thoiGianDung < thoiGianDungToiThieu)
                    {
                        MessageBox.Show("Thời gian dừng phải lớn hơn " + thoiGianDungToiThieu + " phút");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Thời gian dừng phải là số nguyên lớn hơn 0");
                    return;
                }
                if ((lv_sanBayTrungGian.Items.Count + 1) > soSanBayTrungGianToiDa)
                {
                    MessageBox.Show("Chỉ được phép có " + soSanBayTrungGianToiDa + " sân bay trung gian");
                    return;
                }
                for (int i = 0; i < lv_sanBayTrungGian.Items.Count; i++)
                {
                    if (lv_sanBayTrungGian.Items[i].SubItems[1].Text == cb_tenSanBayTrungGian.Text)
                    {
                        MessageBox.Show("Đã tồn tại sân bay này trong sân bay trung gian");
                        return;
                    }
                }
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (lv_sanBayTrungGian.Items.Count + 1).ToString();
                lvi.SubItems.Add(cb_tenSanBayTrungGian.Text);
                lvi.SubItems.Add(tb_thoiGianDung.Text);
                lvi.SubItems.Add(tb_ghiChu.Text);
                lv_sanBayTrungGian.Items.Add(lvi);

            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                CHUYENBAY cHUYENBAY = db.CHUYENBAYs.Find(tb_maChuyenBay.Text);
                if (cHUYENBAY != null) return;
                if (cb_sanBayDi.Text.Length == 0 || cb_sanBayDen.Text.Length == 0 || cb_gioKhoiHanh.Text.Length == 0 || cb_phutKhoiHanh.Text.Length == 0 || tb_giaVe.Text.Length == 0 || cb_ThoiGianBay.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đẩy đủ tất cả thông tin về chuyến bay");
                    return;
                }
                int soLuongVeToiThieu = 0;
                for (int i = 0; i < soLuongTungHangVe.Length; i++)
                {
                    if (soLuongTungHangVe[i] > 0)
                    {
                        soLuongVeToiThieu++;
                    }
                }
                if (soLuongVeToiThieu == 0)
                {
                    MessageBox.Show("Vui lòng thêm ít nhất 1 hạng vé cho chuyến bay");
                    return;
                }
                DateTime dateTime = DateTime.Now;
                if (dp_ngayKhoiHanh.Value.Date <= dateTime.Date)
                {
                    MessageBox.Show("Vui lòng chọn giá trị ngày khởi hành cho hợp lệ");
                    return;
                }
                THAMSO tHAMSO = db.THAMSOes.FirstOrDefault();
                try
                {
                    int thoiGianBay = Convert.ToInt32(cb_ThoiGianBay.Text);
                    if (thoiGianBay < tHAMSO.ThoiGianBayToiThieu)
                    {
                        MessageBox.Show("Thời gian bay phải lớn hơn " + tHAMSO.ThoiGianBayToiThieu + " phút");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập thời gian bay là số nguyên");
                    return;
                }
                try
                {
                    int gio1, phut1;
                    gio1 = Convert.ToInt32(cb_gioKhoiHanh.Text);
                    phut1 = Convert.ToInt32(cb_gioKhoiHanh.Text);
                    if (gio1 < 0 || gio1 > 24 || phut1 < 0 || phut1 > 59)
                    {
                        MessageBox.Show("Vui lòng chọn giờ và phút hợp lý");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn giờ và phút hợp lý");
                    return;
                }
                try
                {
                    int giaVe = Convert.ToInt32(tb_giaVe.Text);
                    if (giaVe <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập giá vé là một số nguyên dương");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập giá vé là một số nguyên dương");
                    return;
                }
                // Đủ hết điều kiện rồi thì add vào database
                int gio, phut;
                gio = Convert.ToInt32(cb_gioKhoiHanh.Text);
                phut = Convert.ToInt32(cb_gioKhoiHanh.Text);
                string maChuyenBay = tb_maChuyenBay.Text;
                string maSanBayDi = db.SANBAYs.Where(a => a.TenSanBay == cb_sanBayDi.Text).ToList().FirstOrDefault().MaSanBay;
                string maSanBayDen = db.SANBAYs.Where(a => a.TenSanBay == cb_sanBayDen.Text).ToList().FirstOrDefault().MaSanBay;
                DateTime ngayGioKhoiHanh = new DateTime(dp_ngayKhoiHanh.Value.Year, dp_ngayKhoiHanh.Value.Month, dp_ngayKhoiHanh.Value.Day, gio, phut, 0);
                int ThoiGianBay = Convert.ToInt32(cb_ThoiGianBay.Text);
                int GiaVe = Convert.ToInt32(tb_giaVe.Text);
                CHUYENBAY ChuyenBay = new CHUYENBAY()
                {
                    MaChuyenBay = tb_maChuyenBay.Text,
                    MaSanBayDi = maSanBayDi,
                    MaSanBayDen = maSanBayDen,
                    NgayGioKhoiHanh = ngayGioKhoiHanh,
                    ThoiGianBay = (short)ThoiGianBay,
                    GiaVe = GiaVe
                };
                db.CHUYENBAYs.Add(ChuyenBay);
                db.SaveChanges();
                for (int i = 0; i < soLuongTungHangVe.Length; i++)
                {
                    if (soLuongTungHangVe[i] > 0)
                    {
                        string tenHangVe = cb_hangVe.Items[i].ToString();
                        string maHangVe = db.HANGVEs.Where(a => a.TenHangVe == tenHangVe).ToList().FirstOrDefault().MaHangVe;
                        CT_HANGVE cT_HANGVE = new CT_HANGVE()
                        {
                            MaHangVe = maHangVe,
                            MaChuyenBay = maChuyenBay,
                            SoLuongGhe = (short)soLuongTungHangVe[i]
                        };
                        db.CT_HANGVE.Add(cT_HANGVE);
                        db.SaveChanges();
                    }
                }
                if (panel_sanbaytrunggian.Visible == true)
                {
                    for (int i = 0; i < lv_sanBayTrungGian.Items.Count; i++)
                    {
                        string tenSanBayTrungGian = lv_sanBayTrungGian.Items[i].SubItems[1].Text;
                        string maSanbayTrungGian = db.SANBAYs.Where(a => a.TenSanBay == tenSanBayTrungGian).ToList().FirstOrDefault().MaSanBay;
                        int thoiGianDung = Convert.ToInt32(lv_sanBayTrungGian.Items[i].SubItems[2].Text);
                        string ghiChu = lv_sanBayTrungGian.Items[i].SubItems[3].Text;
                        CT_CHUYENBAY cT_CHUYENBAY = new CT_CHUYENBAY()
                        {
                            MaChuyenBay = maChuyenBay,
                            MaSanBayTrungGian = maSanbayTrungGian,
                            ThoiGianDung = (short)thoiGianDung,
                            GhiChu = ghiChu,
                        };
                        db.CT_CHUYENBAY.Add(cT_CHUYENBAY);
                        db.SaveChanges();
                    }

                }
                MessageBox.Show("Lên lịch chuyến bay thành công");

            }
        }

        private void btn_xuatThongTin_Click(object sender, EventArgs e)
        {
            NhapLichChuyenBay_File nhapLichChuyenBay_File = new NhapLichChuyenBay_File();
            nhapLichChuyenBay_File.Show();
        }
    }
}
