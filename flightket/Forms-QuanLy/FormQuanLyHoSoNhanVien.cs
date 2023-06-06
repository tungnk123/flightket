using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        private static int POSITION_UPDATE;
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

        // Format năm sinh
        private String FormatDob(String dob)
        {
            String[] ngayFormat = dob.Split(' ');
            String[] namSinh = ngayFormat[0].Split('/');
            String temp = namSinh[0];
            namSinh[0] = namSinh[1];
            namSinh[1] = temp;
            namSinh[2] = namSinh[2].Substring(0, 4);
            return String.Join("/", namSinh);
        }

        // Load data từ database vào trong lv_danhSachNhanVien
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
                    lv_danhSachNhanVien.Rows[i].Cells[3].Value = FormatDob(nhanViens[i].NamSinh.ToString());
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
                form.UpdateEvent += form_UpdateNhanVien;
                POSITION_UPDATE = viTri;
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        // Cập nhật lại danh sách nhân viên
        private void form_UpdateNhanVien(NHANVIEN nhanVien)
        {
            try
            {
                Update_DataGridView(nhanVien);
                Update_List_NhanVien(nhanVien);
                Update_Database(nhanVien);
                MessageBox.Show("Cập nhật thành công!");
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        // Cập nhật database
        private void Update_Database(NHANVIEN nhanVien)
        {
            using (var dbContext = new FlightKetDBEntities())
            {
                var nhanVienTable = dbContext.NHANVIENs;
                var nhanVienNeedUpdate = nhanVienTable.FirstOrDefault(c => c.MaNhanVien == nhanVien.MaNhanVien);
                nhanVienNeedUpdate.SDT = nhanVien.SDT;
                nhanVienNeedUpdate.DiaChi = nhanVien.DiaChi;
                nhanVienNeedUpdate.HoTen = nhanVien.HoTen;
                nhanVienNeedUpdate.NamSinh = nhanVien.NamSinh;
                dbContext.SaveChanges();
            }
        }

        // Cập nhật lại list nhanvien
        private void Update_List_NhanVien(NHANVIEN nhanVien)
        {
            nhanViens[POSITION_UPDATE] = nhanVien;
        }

        // Cập nhật lại datagridview
        private void Update_DataGridView(NHANVIEN nhanVien)
        {
            lv_danhSachNhanVien.Rows[POSITION_UPDATE].Cells[2].Value = nhanVien.HoTen;
            lv_danhSachNhanVien.Rows[POSITION_UPDATE].Cells[3].Value = FormatDob(nhanVien.NamSinh.ToString().Substring(0, 10));
            lv_danhSachNhanVien.Rows[POSITION_UPDATE].Cells[4].Value = nhanVien.DiaChi;
            lv_danhSachNhanVien.Rows[POSITION_UPDATE].Cells[5].Value = nhanVien.SDT;
        }
    }
}
