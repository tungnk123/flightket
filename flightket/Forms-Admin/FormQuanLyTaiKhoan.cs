using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace flightket.Forms_Admin
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        public static FormQuanLyTaiKhoan instance;
        public FormQuanLyTaiKhoan()
        {
            instance = this;
            InitializeComponent();
            
            using (var db = new FlightKetDBEntities())
            {
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
                

            }
            
            if (cb_loaiTaiKhoan.Text == "Nhân viên sân bay")
            {
                loadNhanVien();
            }
        }

        private void loadNhanVien()
        {
            using (var db = new FlightKetDBEntities())
            {
                lb_danhSachTaiKhoan.Text = "Danh sách tài khoản " + cb_loaiTaiKhoan.Text;
                var querry = db.NHANVIENs.Where(a => a.RoleID.Equals("NVSB1"));
                var result = querry.ToList();
                dgv_danhSachTaiKhoan.RowCount = result.Count;
                for (int i = 0; i < result.Count; i++)
                {
                    dgv_danhSachTaiKhoan.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_danhSachTaiKhoan.Rows[i].Cells[1].Value = result[i].MaNhanVien;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[2].Value = result[i].HoTen;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[3].Value = result[i].UserName;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[4].Value = result[i].PassWord;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[5].Value = "Cập nhật";
                    dgv_danhSachTaiKhoan.Rows[i].Height = 30;

                    DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                    dataGridViewCellStyle.ForeColor = Color.White;
                    dataGridViewCellStyle.BackColor = Color.SkyBlue;
                    dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[5].Style = dataGridViewCellStyle;
                }
            }
        }
        public void loadQuanLy()
        {
            using (var db = new FlightKetDBEntities())
            {
                lb_danhSachTaiKhoan.Text = "Danh sách tài khoản " + cb_loaiTaiKhoan.Text;
                var querry = db.NHANVIENs.Where(a => a.RoleID.Equals("QULY1"));
                var result = querry.ToList();
                dgv_danhSachTaiKhoan.RowCount = result.Count;
                for (int i = 0; i < result.Count; i++)
                {
                    dgv_danhSachTaiKhoan.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_danhSachTaiKhoan.Rows[i].Cells[1].Value = result[i].MaNhanVien;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[2].Value = result[i].HoTen;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[3].Value = result[i].UserName;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[4].Value = result[i].PassWord;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[5].Value = "Cập nhật";
                    dgv_danhSachTaiKhoan.Rows[i].Height = 30;

                    DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                    dataGridViewCellStyle.ForeColor = Color.White;
                    dataGridViewCellStyle.BackColor = Color.SkyBlue;
                    dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_danhSachTaiKhoan.Rows[i].Cells[5].Style = dataGridViewCellStyle;
                }
            }
        }

        private void cb_loaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_loaiTaiKhoan.Text == "Nhân viên sân bay")
            {
                loadNhanVien();
            }
            else if (cb_loaiTaiKhoan.Text == "Quản lý")
            {
                loadQuanLy();
            }
            else
            {
                MessageBox.Show("Không có thông tin tài khoản!");
                dgv_danhSachTaiKhoan.DataSource = null;
                return;
            }

        }

        private void dgv_danhSachTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNhanVien = dgv_danhSachTaiKhoan.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            FormCapNhatTaiKhoanNhanVien formCapNhatTaiKhoanNhanVien = new FormCapNhatTaiKhoanNhanVien(maNhanVien);
            this.Hide();
            formCapNhatTaiKhoanNhanVien.ShowDialog();


            if (!formCapNhatTaiKhoanNhanVien.IsAccessible)
            {
                try
                {
                    FormQuanLyTaiKhoan.instance.Show();
                }
                catch
                {
                    return;
                }

                if (cb_loaiTaiKhoan.Text == "Nhân viên sân bay")
                {
                    loadNhanVien();
                }
                else
                {
                    loadQuanLy();
                }
            }
        }


        private void btn_themNhanVien_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan formThemTaiKhoan = new FormThemTaiKhoan();
            formThemTaiKhoan.Show();
            if (!formThemTaiKhoan.IsAccessible)
            {
                this.Show();

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
            formHomeAdmin.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
            formHomeAdmin.Show();
        }

        private void FormQuanLyTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
            formHomeAdmin.Show();
        }

      
    }
}
