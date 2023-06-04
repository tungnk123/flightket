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

namespace flightket.Forms_QuanLy
{
    public partial class NhapLichChuyenBay : Form
    {
        public Form PreviousForm { get; set; }
        FlightKetDBEntities db = new FlightKetDBEntities();
        private String[] listSanBayDi;
        private String[] listSanBayDen;
        private String[] listGioKhoiHanh_Gio;
        private String[] listGioKhoiHanh_Phut;
        private String[] listThoiGianBay_Gio;
        private String[] listThoiGianBay_Phut;
        private String[] listTenSanBay;
        List<CT_HANGVE> listHangVe;
        public NhapLichChuyenBay()
        {
            listHangVe = new List<CT_HANGVE>();
            InitializeComponent();

            updateUI();

            mirrorData();
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
            cb_sanBayDi.SelectedIndex = 0;

            cb_sanBayDen.DropDownStyle = ComboBoxStyle.DropDownList;
            listSanBayDen = new string[] { "Chọn" };
            cb_sanBayDen.Items.AddRange(listSanBayDen);
            cb_sanBayDen.SelectedIndex = 0;


            cb_hangGhe.Items.Add("1");
            cb_hangGhe.Items.Add("2");
            cb_hangGhe.SelectedIndex = 0;

            listGioKhoiHanh_Gio = new string[24];
            listThoiGianBay_Gio = new string[24];
            for (int i = 0; i < 24; i++)
            {
                listGioKhoiHanh_Gio[i] = i.ToString("D2");
                listThoiGianBay_Gio[i] = i.ToString("D2");
            }
            cb_gioKhoiHanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_gioKhoiHanh.Items.AddRange(listGioKhoiHanh_Gio);
            cb_gioKhoiHanh.SelectedIndex = 0;
            cb_ThoiGianBay.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ThoiGianBay.Items.AddRange(listThoiGianBay_Gio);
            cb_ThoiGianBay.SelectedIndex = 0;

            listGioKhoiHanh_Phut = new string[60];
            listThoiGianBay_Phut = new string[60];
            for (int i = 0; i < 60; i++)
            {
                listGioKhoiHanh_Phut[i] = i.ToString("D2");
                listThoiGianBay_Phut[i] = i.ToString("D2");
            }
            cb_phutKhoiHanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_phutKhoiHanh.Items.AddRange(listGioKhoiHanh_Phut);
            cb_phutKhoiHanh.SelectedIndex = 0;
            cb_ThoiGianBay.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ThoiGianBay.Items.AddRange(listThoiGianBay_Phut);
            cb_ThoiGianBay.SelectedIndex = 0;

            listTenSanBay = new string[] { "Something" };
            cb_tenSanBay.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tenSanBay.Items.AddRange(listTenSanBay);
            cb_tenSanBay.SelectedIndex = 0;


            tb_maChuyenBay.Text = RandomStringGenerator.GenerateRandomString().ToString().ToUpper();

            cb_hangGhe.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hangGhe.SelectedIndex = 0;
        }

        private void mirrorData()
        {
            var duLieuChuyenBay = from c in db.CHUYENBAYs
                                  select new
                                  {
                                      MaChuyenBay = c.MaChuyenBay,
                                      MaSanBayDi = c.MaSanBayDi,
                                      MaSanBayDen = c.MaSanBayDen,
                                      NgayGioKhoiHanh = c.NgayGioKhoiHanh,
                                      ThoiGianBay = c.ThoiGianBay,
                                      GiaVe = c.GiaVe
                                  };

            var lvDanhSachSanBayTrungGian = from c in db.CT_CHUYENBAY
                                            select new
                                            {
                                                MaCTCB = c.MaCTCB,
                                                MaChuyenBay = c.MaChuyenBay,
                                                MaSanBayTrungGian = c.MaSanBayTrungGian,
                                                ThoiGianDung = c.ThoiGianDung,
                                                GhiChu = c.GhiChu,
                                                TenSanBay = c.SANBAY.TenSanBay,
                                                QuocGia = c.SANBAY.QuocGia,
                                                DiaChi = c.SANBAY.DiaChi
                                            };
            lv_danhSachSanBayTrungGian.DataSource = lvDanhSachSanBayTrungGian.ToList();

            var dsSanBayDi = from c in db.SANBAYs
                             select new
                             {
                                 MaSanBay = c.MaSanBay,
                                 TenSanBay = c.TenSanBay,
                             };
            var dsSanBayDen = from c in db.SANBAYs
                              select new
                              {
                                  MaSanBay = c.MaSanBay,
                                  TenSanBay = c.TenSanBay,
                              };

            cb_sanBayDi.DataSource = dsSanBayDi.ToList();
            cb_sanBayDi.DisplayMember = "TenSanBay";
            cb_sanBayDi.ValueMember = "MaSanBay";

            cb_sanBayDen.DataSource = dsSanBayDen.ToList();
            cb_sanBayDen.DisplayMember = "TenSanBay";
            cb_sanBayDen.ValueMember = "MaSanBay";

            var tenSanBay = from c in db.SANBAYs
                            select new
                            {
                                MaSanBay = c.MaSanBay,
                                TenSanBay = c.TenSanBay,
                            };
            cb_tenSanBay.DataSource = tenSanBay.ToList();
            cb_tenSanBay.DisplayMember = "TenSanBay";
            cb_tenSanBay.ValueMember = "MaSanBay";




            var dsHangVe = from c in db.HANGVEs
                           select new
                           {
                               MaHangVe = c.MaHangVe,
                               TenHangVe = c.TenHangVe,
                               TiLeDonGia = c.TiLeDonGia
                           };
            cb_hangGhe.DataSource = dsHangVe.ToList();
            cb_hangGhe.DisplayMember = "TenHangVe";
            cb_hangGhe.ValueMember = "MaHangVe";

            
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_thoiGianDung.Text))
            {
                double thoiGianDung;
                if (double.TryParse(tb_thoiGianDung.Text, out thoiGianDung))
                {
                    string maChuyenBay = tb_maChuyenBay.Text.ToString();

                    // KIỂM TRA ĐÃ TỒN TẠI CHUYẾN BAY CHÍNH THỨC TRONG DB HAY CHƯA, NẾU CHƯA CÓ KHÔNG CÓ PHÉP ĐIỀN SÂN BAY TRUNG GIAN

                    CHUYENBAY existingChuyenBay = db.CHUYENBAYs.FirstOrDefault(c => c.MaChuyenBay == maChuyenBay);

                    // TRẢ VỀ NULL ~ CHƯA CÓ CHUYẾN BAY CHÍNH

                    if (existingChuyenBay != null)
                    {


                        CT_CHUYENBAY cT_CHUYENBAY = new CT_CHUYENBAY()
                        {
                            MaChuyenBay = maChuyenBay,
                            MaSanBayTrungGian = cb_tenSanBay.SelectedValue.ToString(),
                            ThoiGianDung = Convert.ToInt16(tb_thoiGianDung.Text),
                            GhiChu = tb_ghiChu.Text?.ToString(),
                        };
                        MessageBox.Show(cT_CHUYENBAY.MaSanBayTrungGian);
                        // SÂN BAY TRUNG GIAN KHÔNG ĐƯỢC TRÙNG VỚI SÂN BAY ĐI VÀ SÂN BAY ĐẾN

                        if (db.CHUYENBAYs.Any(ct => ct.MaChuyenBay == cT_CHUYENBAY.MaChuyenBay && ct.MaSanBayDi == cT_CHUYENBAY.MaSanBayTrungGian && ct.MaChuyenBay == cT_CHUYENBAY.MaChuyenBay))
                        {
                            MessageBox.Show("Sân bay TRUNG GIAN không được trùng với SÂN BAY ĐI");
                        }
                        else
                        {
                            if (db.CHUYENBAYs.Any(ct => ct.MaChuyenBay == cT_CHUYENBAY.MaChuyenBay && ct.MaSanBayDen == cT_CHUYENBAY.MaSanBayTrungGian))
                            {
                                MessageBox.Show("Sân bay TRUNG GIAN không được trùng với SÂN BAY ĐẾN");
                            }
                            else
                            {
                                if (db.CT_CHUYENBAY.Any(ct => ct.MaChuyenBay == cT_CHUYENBAY.MaChuyenBay && ct.MaSanBayTrungGian == cT_CHUYENBAY.MaSanBayTrungGian))
                                {
                                    MessageBox.Show("Error: Duplicate key values (MaChuyenBay, MaSanBayTrungGian).");
                                    // Handle the duplicate key situation (e.g., display an error message)
                                }
                                else
                                {
                                    // The record with the combination of primary key values doesn't exist, proceed with insertion
                                    db.CT_CHUYENBAY.Add(cT_CHUYENBAY);
                                    db.SaveChanges();
                                    var lvDanhSachSanBayTrungGian = from c in db.CT_CHUYENBAY
                                                                    select new
                                                                    {
                                                                        MaCTCB = c.MaCTCB,
                                                                        MaChuyenBay = c.MaChuyenBay,
                                                                        MaSanBayTrungGian = c.MaSanBayTrungGian,
                                                                        ThoiGianDung = c.ThoiGianDung,
                                                                        GhiChu = c.GhiChu,
                                                                        CHUYENBAY = c.CHUYENBAY.MaChuyenBay,
                                                                        SANBAY = c.SANBAY.TenSanBay,

                                                                    };

                                    lv_danhSachSanBayTrungGian.DataSource = lvDanhSachSanBayTrungGian.ToList();
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu chuyến bay, vui lòng nhập dữ liệu chuyến bay trước khi nhập CHUYẾN BAY TRUNG GIAN");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi định dạng thời gian dừng chuyến bay");
                    tb_thoiGianDung.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thời gian dừng chuyến bay");
            }
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

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_maChuyenBay.Text))
            {
                MessageBox.Show("Vui Lòng Điền Mã Chuyến Bay!");
            }
            else
            {
                if (!tb_maChuyenBay.Text.All(char.IsLetterOrDigit) || tb_maChuyenBay.Text.Length > 5)
                {
                    MessageBox.Show("Mã chuyến bay chỉ được chứa chữ, số, và chỉ dưới 5 kí tự");
                }
                else
                {
                    if (cb_sanBayDi.Text.Equals(cb_sanBayDen.Text))
                    {
                        MessageBox.Show("Sân bay đến và sân bay đi không được trùng nhau");
                    }
                    else
                    {
                        DateTime selectedDate = dp_ngayKhoiHanh.Value;
                        DateTime currentDate = DateTime.Now;
                        string formattedDate = selectedDate.ToString("dd/MM/yyyy");
                        if (selectedDate.Date < currentDate.Date)
                        {
                            MessageBox.Show($"Chỉ cho phép ngày khởi hành kể từ {currentDate.Date.ToString("dd/MM/yyyy")}");
                        }
                        else
                        {
                            DateTime dateTime;
                            if (DateTime.TryParseExact(formattedDate + " " + $"{cb_gioKhoiHanh.Text}:{cb_phutKhoiHanh.Text}", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                            {
                                if (!String.IsNullOrEmpty(tb_giaVe.Text))
                                {
                                    if (cb_hangGhe.Items.Count == listHangVe.Count)
                                    {
                                        double giaVe;
                                        if (double.TryParse(tb_giaVe.Text, out giaVe))
                                        {
                                            CHUYENBAY data = new CHUYENBAY()
                                            {
                                                MaChuyenBay = tb_maChuyenBay.Text.ToString(),
                                                MaSanBayDi = cb_sanBayDi.SelectedValue.ToString(),
                                                MaSanBayDen = cb_sanBayDen.SelectedValue.ToString(),
                                                NgayGioKhoiHanh = dateTime,
                                                ThoiGianBay = Convert.ToInt16(cb_ThoiGianBay.Text),
                                                GiaVe = giaVe,
                                            };
                                            try
                                            {
                                                // Your code to parse the input and create the 'CHUYENBAY' object

                                                // Check if the record with the same 'MaChuyenBay' already exists
                                                if (db.CHUYENBAYs.Any(c => c.MaChuyenBay == data.MaChuyenBay))
                                                {
                                                    MessageBox.Show($"Đã tồn tại chuyến bay {data.MaChuyenBay} trong Database");
                                                    // Handle the duplicate key situation (e.g., display an error message)
                                                }
                                                else
                                                {
                                                    // The record with 'MaChuyenBay' doesn't exist, proceed with insertion
                                                    db.CHUYENBAYs.Add(data);
                                                    db.CT_HANGVE.AddRange(listHangVe);
                                                    //db.SaveChanges();
                                                    MessageBox.Show("Thêm dữ liệu CHUYENBAY thành công");
                                                }
                                                db.SaveChanges();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Lỗi định dạng nhập giá vé!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Hãy điền số lượng ghế cho tất cả các vé");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng điền giá vé!");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void tb_soLuong_TextChanged(object sender, EventArgs e)
        {
            if (cb_hangGhe.Text.ToString().Trim().Equals("1"))
            {
                bool isNumeric = int.TryParse(tb_soLuong.Text.ToString().Trim(), out int soLuongHangVe1);
                if (!isNumeric)
                {
                    MessageBox.Show("Sai định dạng số lượng ghế!");
                }
                else
                {
                    soLuongHangVe1 = Convert.ToInt16(tb_soLuong.Text);
                }
            }
            else if (cb_hangGhe.Text.ToString().Trim().Equals("2"))
            {
                bool isNumeric = int.TryParse(tb_soLuong.Text.ToString().Trim(), out int soLuongHangVe2);
                if (!isNumeric)
                {
                    MessageBox.Show("Sai định dạng số lượng ghế!");
                }
                else
                {
                    soLuongHangVe2 = Convert.ToInt16(tb_soLuong.Text);
                }
            }
        }

        private void cb_hangGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool keyExists = listHangVe.Any(pair => pair.MaHangVe == cb_hangGhe.SelectedValue.ToString());
            CT_HANGVE existingPair = listHangVe.FirstOrDefault(pair => pair.MaHangVe == cb_hangGhe.SelectedValue.ToString());

            if (existingPair != null)
            {
                if (!string.IsNullOrEmpty(existingPair.MaHangVe))
                {
                    tb_soLuong.Text = existingPair.SoLuongGhe.ToString();
                    btn_themHangGhe.Text = "Sửa";
                }
                else
                {
                    tb_soLuong.Text = string.Empty;
                    tb_soLuong.Focus();
                    btn_themHangGhe.Text = "Thêm";
                }
            }
            else
            {
                tb_soLuong.Text = string.Empty;
                tb_soLuong.Focus();
                btn_themHangGhe.Text = "Thêm";
            }
        }

        private void btn_themHangGhe_Click(object sender, EventArgs e)
        {
            string selectedValue = cb_hangGhe.SelectedValue?.ToString();
            CT_HANGVE existingPair = listHangVe.FirstOrDefault(pair => pair.MaHangVe == selectedValue);

            CT_HANGVE newPair = new CT_HANGVE()
            {
                MaChuyenBay = tb_maChuyenBay.Text,
                MaHangVe = selectedValue,
                SoLuongGhe = Convert.ToInt16(tb_soLuong.Text)
            };

            if (existingPair == null)
            {
                listHangVe.Add(newPair);

                if (cb_hangGhe.SelectedIndex == cb_hangGhe.Items.Count - 1)
                {
                    cb_hangGhe.SelectedIndex = 0;
                }
                else
                {
                    cb_hangGhe.SelectedIndex = cb_hangGhe.SelectedIndex + 1;
                }
            }
            else
            {
                listHangVe.Remove(existingPair);
                listHangVe.Add(newPair);
            }
        }

        private void cb_tenSanBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                tb_thoiGianDung.Text = String.Empty;
                tb_ghiChu.Text = String.Empty;
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormHomeQuanLy loginForm = Application.OpenForms.OfType<FormHomeQuanLy>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
                this.Close();
            }
        }

        private void btn_nhapFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapLichChuyenBay_File nhapLichChuyenBay_File = new NhapLichChuyenBay_File();
            nhapLichChuyenBay_File.PreviousForm = this;
            nhapLichChuyenBay_File.ShowDialog();
        }
    }
}
