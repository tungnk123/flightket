using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_QuanLy
{
    public partial class FormQuanLyHoSoNhanVien : Form
    {
        public string DataFromForm2 { get; set; }
        List<NHANVIEN> nhanViens;
        public FormQuanLyHoSoNhanVien()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.White);
            Load_Data();    
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
            this.Hide();
            formHomeQuanLy.ShowDialog();  
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
            this.Hide();
            formHomeQuanLy.ShowDialog();
        }

        private void FormQuanLyHoSoNhanVien_Load(object sender, EventArgs e)
        {

        }
        private void Load_Data()
        {
            using(var dbContext = new FlightKetDBEntities())
            {
                nhanViens = dbContext.NHANVIENs.ToList();
                if (nhanViens.Count == 0)
                {
                    MessageBox.Show("Không có nhân viên nào trong danh sách");
                    return;
                } 
                lv_danhSachNhanVien.RowCount = nhanViens.Count;
                for (int i = 0; i < nhanViens.Count; i++) 
                {
                    lv_danhSachNhanVien.Rows[i].Cells[0].Value = (i + 1).ToString();
                    lv_danhSachNhanVien.Rows[i].Cells[1].Value = nhanViens[i].MaNhanVien.ToString();
                    lv_danhSachNhanVien.Rows[i].Cells[2].Value = nhanViens[i].HoTen.ToString();
                    String dob = nhanViens[i].NamSinh.ToString().Substring(0, 10);
                    String[] namSinh = dob.Split('/');
                    String temp = namSinh[0];
                    namSinh[0] = namSinh[1];
                    namSinh[1] = temp;
                    String ngayThangNamSinh = String.Join("/",  namSinh);
                    lv_danhSachNhanVien.Rows[i].Cells[3].Value = ngayThangNamSinh;
                    lv_danhSachNhanVien.Rows[i].Cells[4].Value = nhanViens[i].DiaChi.ToString();
                    lv_danhSachNhanVien.Rows[i].Cells[5].Value = nhanViens[i].SDT.ToString();
                    lv_danhSachNhanVien.Rows[i].Cells[6].Value = "Cập nhật";

                    DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                    dataGridViewCellStyle.ForeColor = Color.Black;
                    dataGridViewCellStyle.BackColor = Color.Blue;
                    dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    lv_danhSachNhanVien.Rows[i].Cells[6].Style = dataGridViewCellStyle;
                }
            }
        }

        private void lv_danhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == lv_danhSachNhanVien.Columns[6].Index && e.RowIndex >= 0)
            {
                int viTri = e.RowIndex;
                FormCapNhatThongTinNhanVien form = new FormCapNhatThongTinNhanVien(nhanViens[viTri]);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

    }
}
