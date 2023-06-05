using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_QuanLy
{
    public partial class FormChiTietThayDoiSoSanBay : Form
    {
        List<SANBAY> sanBaysBanDauList;
        List<SANBAY> sanBaysCapNhatList;
        public FormChiTietThayDoiSoSanBay(List<SANBAY> sanBaysList)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.White);
            this.sanBaysBanDauList = new List<SANBAY>();
            this.sanBaysCapNhatList= new List<SANBAY>();    
            this.sanBaysBanDauList = sanBaysList;
            this.sanBaysCapNhatList = sanBaysList;
            Load_Data();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormThayDoiQuiDinh formThayDoiQuiDinh = new FormThayDoiQuiDinh();   
            formThayDoiQuiDinh.ShowDialog();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
            this.Hide();
            formHomeQuanLy.ShowDialog();    
        }

        private void FormChiTietThayDoiSoSanBay_Load(object sender, EventArgs e)
        {
            

        }

        // Load data to datagridview
        private void Load_Data()
        {
            lv_danhSachSanBay.RowCount = sanBaysBanDauList.Count + 10;
            if (sanBaysBanDauList.Count == 0)
            {
                MessageBox.Show("Không có sân bay nào trong danh sách sân bay");
                return;
            }
            for (int i = 0; i < sanBaysBanDauList.Count; i++)
            {
                lv_danhSachSanBay.Rows[i].Cells[0].Value = (i + 1).ToString();
                lv_danhSachSanBay.Rows[i].Cells[1].Value = sanBaysBanDauList[i].TenSanBay.ToString();
                lv_danhSachSanBay.Rows[i].Cells[2].Value = sanBaysBanDauList[i].QuocGia.ToString();
                lv_danhSachSanBay.Rows[i].Cells[3].Value = sanBaysBanDauList[i].DiaChi.ToString();
                lv_danhSachSanBay.Rows[i].Cells[4].Value = "Xóa";

                DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                dataGridViewCellStyle.BackColor = Color.Red;
                dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                lv_danhSachSanBay.Rows[i].Cells[4].Style = dataGridViewCellStyle;
            }
            tb_soLuongSanBayCu.Text = sanBaysBanDauList.Count.ToString(); 
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

        private void tb_tenSanBay_Leave(object sender, EventArgs e)
        {
            String tenSanBay = tb_tenSanBay.Text;
            if (tenSanBay.Trim() == String.Empty)
            {
                tb_tenSanBay.Clear();
                return;
            } else if (IsNumeric(tenSanBay))
            {
                MessageBox.Show("Tên sân bay không được chứa toàn chữ cái");
                tb_tenSanBay.Clear();
            } else if (ContainsSpecialCharacters(tenSanBay))
            {
                MessageBox.Show("Tên sân bay không được chứa kí tự đặc biệt");
                tb_tenSanBay.Clear();
            }
        }

        private void tb_tenQuocGia_Leave(object sender, EventArgs e)
        {
            String tenQuocGia = tb_tenQuocGia.Text;
            if (tenQuocGia.Trim() == String.Empty)
            {
                tb_tenQuocGia.Clear();
                return;
            }
            else if (IsNumeric(tenQuocGia))
            {
                MessageBox.Show("Tên quốc gia không được chứa toàn chữ cái");
                tb_tenQuocGia.Clear();
            }
            else if (ContainsSpecialCharacters(tenQuocGia))
            {
                MessageBox.Show("Tên quốc gia không được chứa kí tự đặc biệt");
                tb_tenQuocGia.Clear();
            }
        }

        private void tb_diaChi_Leave(object sender, EventArgs e)
        {
            String diaChi = tb_diaChi.Text;
            if (diaChi.Trim() == String.Empty)
            {
                tb_diaChi.Clear();
                return;
            }
            else if (IsNumeric(diaChi))
            {
                MessageBox.Show("Địa chỉ sân bay không được chứa toàn chữ cái");
                tb_diaChi.Clear();
            }
            else if (ContainsSpecialCharacters(diaChi))
            {
                MessageBox.Show("Địa chỉ sân bay không được chứa kí tự đặc biệt");
                tb_diaChi.Clear();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_tenSanBay.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Không được để trống tên sân bay");
            } else if (tb_tenQuocGia.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Không được để trống tên quốc gia");
            } else if (tb_diaChi.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Không được để trống địa chỉ");
            } else
            {
                try
                {
                    Add_Rows();
                    MessageBox.Show("Thêm hàng thành công!");
                } catch (Exception ex)
                {
                    MessageBox.Show("Thêm hàng thất bại!");
                }
            }
        }

        private void Add_Rows()
        {
            // Tạo đối tượng SanBayNew
            String soSanBay = (sanBaysCapNhatList.Count() + 1 < 10) ? ("0" + (sanBaysCapNhatList.Count() + 1).ToString()) : (sanBaysCapNhatList.Count().ToString());
            String maSanBay = "SBN" + soSanBay;
            String tenSanBay = tb_tenSanBay.Text;
            String tenQuocGia = tb_tenQuocGia.Text;
            String diaChi = tb_diaChi.Text;

            // Add đối tượng vào List các sân bay thay đổi
            SANBAY sanBayNew = new SANBAY {MaSanBay = maSanBay, TenSanBay = tenSanBay, QuocGia = tenQuocGia, DiaChi = diaChi };
            sanBaysCapNhatList.Add(sanBayNew);
            int soLuongSanBay = sanBaysCapNhatList.Count();
            tb_soLuongSanBayMoi.Text = soLuongSanBay.ToString();

            // Thêm dòng mới vào datagridview
            lv_danhSachSanBay.Rows[soLuongSanBay - 1].Cells[0].Value = (soLuongSanBay).ToString();
            lv_danhSachSanBay.Rows[soLuongSanBay - 1].Cells[1].Value = tenSanBay;
            lv_danhSachSanBay.Rows[soLuongSanBay - 1].Cells[2].Value = tenQuocGia;
            lv_danhSachSanBay.Rows[soLuongSanBay - 1].Cells[3].Value = diaChi;
            lv_danhSachSanBay.Rows[soLuongSanBay - 1].Cells[4].Value = "Xóa";

            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            dataGridViewCellStyle.ForeColor = Color.White;
            dataGridViewCellStyle.BackColor = Color.Red;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lv_danhSachSanBay.Rows[soLuongSanBay - 1].Cells[4].Style = dataGridViewCellStyle;

            // Clear các textBox
            tb_tenQuocGia.Clear();
            tb_tenSanBay.Clear();
            tb_diaChi.Clear();
        }

        private void lv_danhSachSanBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == lv_danhSachSanBay.Columns[4].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa sân bay này không?", "Xóa", MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.Yes))
                {
                    lv_danhSachSanBay.Rows.RemoveAt(e.RowIndex);
                    sanBaysCapNhatList.RemoveAt(e.RowIndex);
                    tb_soLuongSanBayMoi.Text = sanBaysCapNhatList.Count().ToString();
                    Update_DataGridView();
                }
            }
        }

        private void Update_DataGridView()
        {
            lv_danhSachSanBay.Rows.Clear();
            lv_danhSachSanBay.RowCount = sanBaysCapNhatList.Count() + 10;
            for (int i = 0; i < sanBaysCapNhatList.Count; i++)
            {
                lv_danhSachSanBay.Rows[i].Cells[0].Value = (i + 1).ToString();
                lv_danhSachSanBay.Rows[i].Cells[1].Value = sanBaysCapNhatList[i].TenSanBay.ToString();
                lv_danhSachSanBay.Rows[i].Cells[2].Value = sanBaysCapNhatList[i].QuocGia.ToString();
                lv_danhSachSanBay.Rows[i].Cells[3].Value = sanBaysCapNhatList[i].DiaChi.ToString();
                lv_danhSachSanBay.Rows[i].Cells[4].Value = "Xóa";

                DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                dataGridViewCellStyle.BackColor = Color.Red;
                dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                lv_danhSachSanBay.Rows[i].Cells[4].Style = dataGridViewCellStyle;
            }
        }

        private void btn_luuThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật những thay đổi ở trên không?", "Confirm", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                try
                {
                    Update_Database();
                    MessageBox.Show("Cập nhật sân bay thành công!");
                    tb_soLuongSanBayMoi.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }

        // Cập nhật lên database
        private void Update_Database()
        {
            using (var dbContext = new FlightKetDBEntities())
            {
                foreach (var sanBay in sanBaysCapNhatList)
                {
                    dbContext.SANBAYs.AddOrUpdate(sanBay);
                }
                dbContext.SaveChanges();
            }
        }
    }
}
