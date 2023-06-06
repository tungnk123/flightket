using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_Admin
{
    public partial class FormThemTaiKhoan : Form
    {
        List<String> loaiTaiKhoanList = new List<string> { "Nhân viên sân bay", "Quản lý" };
        Random random = new Random();
        String maNhanvien;
        int number;
        public FormThemTaiKhoan()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.Now;
            
            cb_loaiTaiKhoan.DataSource = loaiTaiKhoanList;
            number = random.Next(100, 999);
            maNhanvien = "NV" + number.ToString();
            tb_maNhanVien.Text = maNhanvien;

        }
        private bool IsLettersOnly(string value)
        {
            return value.All(c => char.IsLetter(c) || c == ' ');
        }


        private bool IsNumbersOnly(string value)
        {
            return value.All(char.IsDigit);
        }


        private void btn_xacNhanThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string hoTen = tb_hoTen.Text;
            string maNhanVien = tb_maNhanVien.Text;
            string tenDangNhap = tb_tenDangNhap.Text;
            string matKhau = tb_matKhau.Text;
            DateTime ngaySinh = dp_ngaySinh.Value;
            string diaChi = tb_diaChi.Text;
            string soDienThoai = tb_soDienThoai.Text;
            string loaiTaiKhoan = cb_loaiTaiKhoan.Text.Equals("Nhân viên sân bay") ? "nhanviensanbay" : "quanly";

            if (!IsLettersOnly(hoTen))
            {
                MessageBox.Show("Họ và tên chỉ được chứa chữ cái!");
                return;
            }
            if (!IsNumbersOnly(soDienThoai))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số!");
                return;
            }

            using (var db = new FlightKetDBEntities())
            {
                var result = db.NHANVIENs.Where(c => c.MaNhanVien.Equals(maNhanVien) || c.UserName.Equals(tenDangNhap));

                var resultList = result.ToList();
                if (resultList.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên hoặc tên đăng nhập đã bị trùng! Vui lòng nhập lại!");
                    return;
                }
                var newNhanVien = new NHANVIEN
                {
                    MaNhanVien = maNhanVien,
                    HoTen = hoTen,
                    UserName = tenDangNhap,
                    PassWord = matKhau,
                    NamSinh = ngaySinh,
                    DiaChi = diaChi,
                    SDT = soDienThoai,
                    Role = loaiTaiKhoan
                };

                db.NHANVIENs.Add(newNhanVien);
                db.SaveChanges();
                MessageBox.Show("Thêm tài khoản nhân viên thành công!");


            }

            tb_diaChi.Text = "";
            tb_hoTen.Text = "";
            tb_matKhau.Text = "";
            tb_tenDangNhap.Text = "";
            tb_soDienThoai.Text = "";
            tb_maNhanVien.Text = "NV" + random.Next(100, 999).ToString();
        }
    }
}
