using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flightket.Forms_QuanLy
{
    public partial class FormCapNhatThongTinNhanVien : Form
    {
        NHANVIEN nhanVien;

        public FormCapNhatThongTinNhanVien(NHANVIEN nhanVien)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.White);
            this.nhanVien = nhanVien;
            _init();
        }

        private String DobAfterHandle()
        {
            String[] dob = nhanVien.NgaySinh.ToString().Split(' ');
            String[] namSinh = dob[0].Split('/');
            String temp = namSinh[0];
            namSinh[0] = namSinh[1];
            namSinh[1] = temp;
            return String.Join("/", namSinh);
        }
        private void _init()
        {
            tb_maNhanVien.Text = nhanVien.MaNhanVien;
            tb_hoTen.Text = nhanVien.HoTen;
            tb_diaChi.Text = nhanVien.DiaChi;
            tb_soDienThoai.Text = nhanVien.SoDienThoai;
            dp_ngaySinh.Value = nhanVien.NgaySinh.Value.Date;
        }

        // Kiểm tra chuỗi toàn số
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // Kiểm tra chuỗi chứa kí tự đặc biệt
        public bool ContainsSpecialCharacters(string input)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9 ]");
            return regex.IsMatch(input);
        }

        public bool ContainsNumberCharacters(string input)
        {
            Regex regex = new Regex(@"[0-9]");
            return regex.IsMatch(input);
        }

        private void tb_hoTen_Leave(object sender, EventArgs e)
        {
            String hoTen = tb_hoTen.Text;
            if (hoTen.Trim() == String.Empty)
            {
                MessageBox.Show("Không được để trống họ tên");
                tb_hoTen.Text = nhanVien.HoTen;
            } else if (ContainsNumberCharacters(hoTen))
            {
                MessageBox.Show("Họ tên không được chứa chữ số");
                tb_hoTen.Text = nhanVien.HoTen;
            } else if (ContainsSpecialCharacters(hoTen))
            {
                MessageBox.Show("Họ tên không được chứa kí tự đặc biệt");
                tb_hoTen.Text = nhanVien.HoTen;
            }
        }


        // Add điều kiện để kiểm tra khi người dùng rời khỏi tb_diaChi
        private void tb_diaChi_Leave(object sender, EventArgs e)
        {
            String diaChi = tb_diaChi.Text;
            if (String.IsNullOrEmpty(diaChi.Trim()))
            {
                MessageBox.Show("Không được để trống địa chỉ");
                tb_diaChi.Text = nhanVien.DiaChi;
            }
            else if (ContainsSpecialCharacters(diaChi))
            {
                MessageBox.Show("Địa chỉ không được chứa kí tự đặc biệt");
                tb_diaChi.Text = nhanVien.DiaChi;
            }
        }

        // Add điều kiện để kiểm tra khi người dùng rời khỏi tb_soDienThoai
        private void tb_soDienThoai_Leave(object sender, EventArgs e)
        {
            String sdt = tb_soDienThoai.Text;
            if (String.IsNullOrEmpty(sdt.Trim()))
            {
                MessageBox.Show("Không được để trống số điện thoại");
                tb_soDienThoai.Text = nhanVien.SoDienThoai;
            }
            else if (!IsNumeric(sdt.Trim()))
            {
                MessageBox.Show("Số điện thoại phải toàn số");
                tb_soDienThoai.Text = nhanVien.SoDienThoai;
            } else
            {
                if (sdt.Trim().Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số");
                    tb_soDienThoai.Text = nhanVien.SoDienThoai;
                }
            }
        }

        // Tạo delegate khi có sự kiện back trở về FormQuanLyHoSoNhanVien
        public delegate void UpdateNhanVien(NHANVIEN nhanvien);
        public event UpdateNhanVien UpdateEvent;

        private void btn_luuThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (!ContainTextBoxNullOrEmpty())
                {
                    string inputText = tb_soDienThoai.Text;
                    bool isNumeric = Regex.IsMatch(inputText, @"^\d+$");
                    if(isNumeric == false)
                    {
                        MessageBox.Show("Vui lòng điền số điện thoại ở định dạng số");
                        return;
                    }
                    string inputText1 = tb_hoTen.Text;
                    bool isAlphabetic1 = Regex.IsMatch(inputText1, @"^[a-zA-Z\s]+$");
                    if(isAlphabetic1 == false )
                    {
                        MessageBox.Show("Vui lòng điền họ tên đúng định dạng");
                        return;
                    }
                    UpdateInfoNhanVien();
                    UpdateEvent(this.nhanVien);
                    this.Close();
                } else
                {
                    MessageBox.Show("Không được để trống thông tin!!!");
                }
            }
        }

        // Kiểm tra có tb nào người dùng bỏ trống ?
        private bool ContainTextBoxNullOrEmpty()
        {
            String hoTen = tb_hoTen.Text;
            String diaChi = tb_diaChi.Text;
            String soDienThoai = tb_soDienThoai.Text;

            if (String.IsNullOrEmpty(hoTen) || String.IsNullOrEmpty(diaChi) 
                 || String.IsNullOrEmpty(soDienThoai))
            {
                return true;
            }
            return false;
        }

        // Định dạng ngày
        private String FormatDob(String ngaySinh)
        {
            String[] ngayFormat = ngaySinh.Split(' ');
            String[] namSinh = ngayFormat[0].Split('/');
            String temp = namSinh[0];
            namSinh[0] = namSinh[1];
            namSinh[1] = temp;
            namSinh[2] = namSinh[2].Substring(0, 4);
            return String.Join("/", namSinh);
        }
        // Cập nhật lại thông tin của nhân viên đó
        private void UpdateInfoNhanVien()
        {
            try
            {
                String hoTen = tb_hoTen.Text;
                String diaChi = tb_diaChi.Text;
                String soDienThoai = tb_soDienThoai.Text;

                this.nhanVien.HoTen = hoTen;
                this.nhanVien.DiaChi = diaChi;
                this.nhanVien.NgaySinh = dp_ngaySinh.Value.Date;
                this.nhanVien.SoDienThoai = soDienThoai; 
            } catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
            formHomeQuanLy.ShowDialog();    
        }

        
    }
}
