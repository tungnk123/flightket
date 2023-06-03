using System;
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

namespace flightket.Forms_QuanLy
{
    public partial class NhapLichChuyenBay : Form
    {
        FlightKetDBEntities db = new FlightKetDBEntities();
        private String[] listSanBayDi;
        private String[] listSanBayDen;
        private String[] listGioKhoiHanh_Gio;
        private String[] listGioKhoiHanh_Phut;
        private String[] listThoiGianBay_Gio;
        private String[] listThoiGianBay_Phut;
        private String[] listHangGhe;
        private String[] listTenSanBay;
        int soLuongHangVe1 = 0;
        int soLuongHangVe2 = 0;
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
            var SANBAY = from c in db.SANBAYs
                         select new
                         {

                         };


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
                                TenSanBay = c.TenSanBay,
                            };
            cb_tenSanBay.DataSource = tenSanBay.Select(x => x.TenSanBay).ToList();




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
                                    if(cb_hangGhe.Items.Count == listHangVe.Count)
                                    {
                                        // them vao database

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
                                                    MessageBox.Show("Error: Duplicate key 'MaChuyenBay'.");
                                                    // Handle the duplicate key situation (e.g., display an error message)
                                                }
                                                else
                                                {
                                                    // The record with 'MaChuyenBay' doesn't exist, proceed with insertion
                                                    db.CHUYENBAYs.Add(data);
                                                    db.SaveChanges();
                                                    MessageBox.Show("Thêm dữ liệu thành công");
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }


                                            try
                                            {
                                                foreach (var hangVe in listHangVe)
                                                {
                                                    // Check if a record with the same combination of primary key values already exists
                                                    if (db.CT_HANGVE.Any(ct => ct.MaHangVe == hangVe.MaHangVe && ct.MaHangVe == hangVe.MaHangVe))
                                                    {
                                                        MessageBox.Show("Error: Duplicate key values (MaVe, MaHangVe).");
                                                        // Handle the duplicate key situation (e.g., display an error message)
                                                    }
                                                    else
                                                    {
                                                        // The record with the combination of primary key values doesn't exist, proceed with insertion
                                                        db.CT_HANGVE.Add(hangVe);
                                                    }
                                                }

                                                db.SaveChanges();
                                                MessageBox.Show("Thêm dữ liệu thành công");
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }



                                            MessageBox.Show("Click");
                                            /*CT_HANGVE cT_HANGVE = new CT_HANGVE()
                                            {
                                                MaChuyenBay = tb_maChuyenBay.Text.ToString(),
                                                MaHangVe = cb_hangGhe.SelectedValue.ToString(),
                                                SoLuongGhe = Convert.ToInt16(soLuongHangVe1)
                                            };

                                            db.CT_HANGVE.Add(cT_HANGVE);
                                            db.SaveChanges();*/

                                        }
                                        else
                                        {
                                            MessageBox.Show("Lỗi định dạng nhập giá vé!");
                                        }
                                    } else
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
            if(cb_hangGhe.SelectedValue != null)
            {
                if (String.IsNullOrEmpty(tb_soLuong.Text))
                {
                    listHangVe.Add(new CT_HANGVE()
                    {
                        MaChuyenBay = tb_maChuyenBay.Text,
                        MaHangVe = cb_hangGhe.SelectedValue?.ToString(),
                        SoLuongGhe = 0
                    });
                    // QUA HẠNG VÉ MỚI
                    tb_soLuong.Text = String.Empty;
                    tb_soLuong.Focus();
                }
                else
                {
                    listHangVe.Add(new CT_HANGVE()
                    {
                        MaChuyenBay = tb_maChuyenBay.Text,
                        MaHangVe = cb_hangGhe.SelectedValue?.ToString(),
                        SoLuongGhe = Convert.ToInt16(soLuongHangVe1)
                    });

                    tb_soLuong.Text = String.Empty;
                    tb_soLuong.Focus();
                }
            }
            

        }
    }
}
