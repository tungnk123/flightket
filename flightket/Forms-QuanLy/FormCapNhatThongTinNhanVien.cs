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

        private void _init()
        {
            tb_maNhanVien.Text = nhanVien.MaNhanVien;
            tb_hoTen.Text = nhanVien.HoTen;
            tb_diaChi.Text = nhanVien.DiaChi;
            String dob = nhanVien.NamSinh.ToString().Substring(0, 10);
            String[] namSinh = dob.Split('/');
            String temp = namSinh[0];
            namSinh[0] = namSinh[1];
            namSinh[1] = temp;
            String ngayThangNamSinh = String.Join("/", namSinh);
            tb_namSinh.Text = ngayThangNamSinh;
            tb_soDienThoai.Text = nhanVien.SDT;
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

        private void tb_namSinh_Leave(object sender, EventArgs e)
        {
            String ngaySinh = tb_namSinh.Text;
            DateTime date;
            if (!DateTime.TryParse(ngaySinh, out date))
            {
                MessageBox.Show("Ngày không hợp lệ");
            }
        }

        private void tb_diaChi_Leave(object sender, EventArgs e)
        {
            String diaChi = tb_diaChi.Text;
            if (diaChi.Trim() == String.Empty)
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

        private void tb_soDienThoai_Leave(object sender, EventArgs e)
        {
            String sdt = tb_soDienThoai.Text;
            if (sdt.Trim() == String.Empty)
            {
                MessageBox.Show("Không được để trống số điện thoại");
                tb_soDienThoai.Text = nhanVien.SDT;
            }
            else if (!IsNumeric(sdt))
            {
                MessageBox.Show("Số điện thoại phải toàn số");
                tb_soDienThoai.Text = nhanVien.SDT;
            } else
            {
                if (sdt.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số");
                    tb_soDienThoai.Text = nhanVien.SDT;
                }
            }
        }

        private void btn_xacNhanCapNhat_Click(object sender, EventArgs e)
        {
            string data = "Dữ liệu từ Form2";
            this.Close();
        }

    }
}
