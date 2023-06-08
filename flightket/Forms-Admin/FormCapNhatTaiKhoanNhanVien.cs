using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace flightket.Forms_Admin
{
    public partial class FormCapNhatTaiKhoanNhanVien : Form
    {
        string maNhanVien;
        public FormCapNhatTaiKhoanNhanVien()
        {
            InitializeComponent();
        }
        public FormCapNhatTaiKhoanNhanVien(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
            cb_loaiTaiKhoan.Text = "";

            using (var db = new FlightKetDBEntities())
            {
                NHANVIEN nHANVIEN = db.NHANVIENs.Find(maNhanVien);
                tb_maNhanVien.Text = nHANVIEN.MaNhanVien;
                tb_hoTen.Text = nHANVIEN.HoTen;
                tb_tenDangNhap.Text = nHANVIEN.UserName;
                tb_matKhau.Text = nHANVIEN.PassWord;
                
                var result = from role in db.ROLEs
                             select role.RoleName;
                var resultList = result.ToList();
                List<string> roleNameList = new List<string>();
                foreach (string item in resultList)
                {
                    if (item.Equals("Qu?n lý"))
                    {
                        roleNameList.Add("Quản lý");
                    }
                    else
                    {
                        roleNameList.Add(item);
                    }
                }
                cb_loaiTaiKhoan.DataSource = roleNameList;
                cb_loaiTaiKhoan.Text = nHANVIEN.RoleID.Equals("NVSB1") ? "Nhân viên sân bay" : "Quản lý";
            }
        }

        private void btn_timChuyenBay_Click(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                string maNhanvien = this.maNhanVien;
                string hoTen = tb_hoTen.Text;
                string tenDangNhap = tb_tenDangNhap.Text;
                string matKhau = tb_matKhau.Text;
                string vaiTro;
                NHANVIEN nHANVIEN = db.NHANVIENs.Find(maNhanvien);
                if (cb_loaiTaiKhoan.Text == "Nhân viên sân bay")
                {
                    vaiTro = "NVSB1";
                }
                else
                {
                    vaiTro = "QULY1";
                }
                if (tb_hoTen.Text.Length == 0 || tb_tenDangNhap.Text.Length == 0 || tb_matKhau.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập lại đầy đủ thông tin trước khi cập nhật");
                    return;
                }
                var querry = db.NHANVIENs.Where(a => a.UserName.Equals(tb_tenDangNhap.Text));
                if (querry.ToList().Count() > 0)
                {
                    if (nHANVIEN.UserName != tb_tenDangNhap.Text)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại vui lòng nhập tên khác");
                        return;
                    }
                }

                nHANVIEN.HoTen = hoTen;
                nHANVIEN.RoleID = vaiTro;
                nHANVIEN.UserName = tenDangNhap;
                nHANVIEN.PassWord = matKhau;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thông tin thành công");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn xóa tài khoản " + tb_maNhanVien.Text + " hay không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                using (var db = new FlightKetDBEntities())
                {
                    var result = db.NHANVIENs.Find(tb_maNhanVien.Text);

                    db.NHANVIENs.Remove(result);
                    db.SaveChanges();
                    MessageBox.Show("Đã xóa nhân viên thành công! ");
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
            FormQuanLyTaiKhoan.instance.Close();
            FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
            formHomeAdmin.Show();
        }
    }
}
