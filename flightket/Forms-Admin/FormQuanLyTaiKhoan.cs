﻿using System;
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
    public partial class FormQuanLyTaiKhoan : Form
    {
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            cb_loaiTaiKhoan.Text = "Nhân viên sân bay";
            loadNhanVien();
        }

        private void loadNhanVien()
        {
            using (var db = new FlightKetDBEntities())
            {
                lb_danhSachTaiKhoan.Text = "Danh sách tài khoản " + cb_loaiTaiKhoan.Text;
                var querry = db.NHANVIENs.Where(a => a.Role.Equals("nhanviensanbay"));
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
                var querry = db.NHANVIENs.Where(a => a.Role.Equals("quanly"));
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_loaiTaiKhoan.Text == "Nhân viên sân bay")
            {
                loadNhanVien();
            }
            else
            {
                loadQuanLy();
            }
        }

        private void dgv_danhSachTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNhanVien = dgv_danhSachTaiKhoan.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            FormCapNhatTaiKhoanNhanVien formCapNhatTaiKhoanNhanVien = new FormCapNhatTaiKhoanNhanVien(maNhanVien);
            this.Hide();
            formCapNhatTaiKhoanNhanVien.ShowDialog();
            if(formCapNhatTaiKhoanNhanVien.IsAccessible == false)
            {
                this.Show();
                this.loadNhanVien();
            }
        }
    }
}