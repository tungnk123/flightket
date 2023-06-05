using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Entity.Migrations;

namespace flightket.Forms_QuanLy
{
    public partial class FormThayDoiChiTietSoHangVe : Form
    {
        List<HANGVE> hangVeBanDauList; // Hạng vé ban đầu (dữ liệu ban đầu)
        List<HANGVE> hangVeThayDoiList; // Hạng vé dùng để lưu thay đổi các giá trị thêm xóa Hangve
        public FormThayDoiChiTietSoHangVe(List<HANGVE> hangVes)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.White);
            this.hangVeBanDauList = new List<HANGVE>();
            this.hangVeThayDoiList= new List<HANGVE>();
            this.hangVeThayDoiList = hangVes;
            this.hangVeBanDauList = hangVes;
            Load_Data();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            FormThayDoiQuiDinh formThayDoiQuiDinh = new FormThayDoiQuiDinh();
            this.Hide();
            formThayDoiQuiDinh.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
            this.Hide();
            formHomeQuanLy.ShowDialog();
        }

        private void FormThayDoiChiTietSoHangVe_Load(object sender, EventArgs e)
        {

        }

        // Load data vào trong datagridview
        private void Load_Data()
        {
            lv_danhSachHangVe.RowCount = hangVeBanDauList.Count + 10;
            tb_giaTriCu.Text = hangVeBanDauList.Count.ToString();
            if (hangVeBanDauList.Count == 0)
            {
                MessageBox.Show("Không tồn tại hạng vé nào trong danh sách hạng vé");
                return;
            }
            for (int i = 0; i < hangVeBanDauList.Count; i ++)
            {
                lv_danhSachHangVe.Rows[i].Cells[0].Value = (i + 1).ToString();
                lv_danhSachHangVe.Rows[i].Cells[1].Value = hangVeBanDauList[i].TenHangVe.ToString();
                lv_danhSachHangVe.Rows[i].Cells[2].Value = hangVeBanDauList[i].TiLeDonGia.ToString();
                lv_danhSachHangVe.Rows[i].Cells[3].Value = "Xóa";

                DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                dataGridViewCellStyle.ForeColor = Color.White;
                dataGridViewCellStyle.BackColor = Color.Red;
                dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                lv_danhSachHangVe.Rows[i].Cells[3].Style = dataGridViewCellStyle;
            }
        }

        // Click xóa hàng
        private void lv_danhSachHangVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == lv_danhSachHangVe.Columns[3].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa hạng vé này không?", "Xóa", MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.Yes)) 
                {
                    lv_danhSachHangVe.Rows.RemoveAt(e.RowIndex);
                    hangVeThayDoiList.RemoveAt(e.RowIndex);
                    tb_giaTriMoi.Text = hangVeThayDoiList.Count().ToString();
                    Update_DataGridView();
                }
            }
        }

        private void Update_DataGridView()
        {
            lv_danhSachHangVe.Rows.Clear();
            lv_danhSachHangVe.RowCount = hangVeThayDoiList.Count() + 10;
            for (int i = 0; i < hangVeThayDoiList.Count; i++)
            {
                lv_danhSachHangVe.Rows[i].Cells[0].Value = (i + 1).ToString();
                lv_danhSachHangVe.Rows[i].Cells[1].Value = hangVeThayDoiList[i].TenHangVe.ToString();
                lv_danhSachHangVe.Rows[i].Cells[2].Value = hangVeThayDoiList[i].TiLeDonGia.ToString();
                lv_danhSachHangVe.Rows[i].Cells[3].Value = "Xóa";

                DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                dataGridViewCellStyle.ForeColor = Color.White;
                dataGridViewCellStyle.BackColor = Color.Red;
                dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                lv_danhSachHangVe.Rows[i].Cells[3].Style = dataGridViewCellStyle;
            }
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
            Regex regex = new Regex(@"[^a-zA-Z0-9. ]");
            return regex.IsMatch(input);
        }

        // Event click ra khỏi tb_tenHangVe
        private void tb_tenHangVe_Leave(object sender, EventArgs e)
        {
            if (tb_tenHangVe.Text.Trim() == "")
            {
                tb_tenHangVe.Clear();
                return;
            } else if (IsNumeric(tb_tenHangVe.Text)) 
            {
                tb_tenHangVe.Clear();
                MessageBox.Show("Tên hạng vé không được chỉ toàn số");
            } else if (ContainsSpecialCharacters(tb_tenHangVe.Text))
            {
                tb_tenHangVe.Clear();
                MessageBox.Show("Tên hạng vé không được chứa kí tự đặc biệt");
            }
        }

        // Kiểm tra chuỗi có là số thực
        public bool IsParseDouble(string input)
        {
            return Double.TryParse(input, out _);
        }

        // Event click ra khỏi tb_tiLe
        private void tb_tiLe_Leave(object sender, EventArgs e)
        {
            if (tb_tiLe.Text.Trim() == "")
            {
                tb_tiLe.Clear();
                return;
            } else if (ContainsSpecialCharacters(tb_tiLe.Text))
            {
                tb_tiLe.Clear();
                MessageBox.Show("Tỉ lệ không được chứa kí tự đặc biệt");
            } else if (!IsParseDouble(tb_tiLe.Text))
            {
                tb_tiLe.Clear();
                MessageBox.Show("Tỉ lệ phải là một số hợp lệ");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_tenHangVe.Text.Trim() == null)
            {
                MessageBox.Show("Không được để trống tên hạng vé");
            } else if (tb_tiLe.Text.Trim() == null)
            {
                MessageBox.Show("Không được để trống tỉ lệ");
            } else
            {
                try
                {
                    Add_Rows();
                    MessageBox.Show("Thêm hàng thành công!");
                } catch(Exception ex) 
                {
                    MessageBox.Show("Thêm hàng thất bại");
                }
            }
        }
        
        // Thêm hàng mới vào trong datagridview và thêm một đối tượng HANGVE vào trong hangVeThayDoiList
        private void Add_Rows()
        {
            // Tạo đối tượng hangVeNew
            String soHangVe = (hangVeThayDoiList.Count() + 1 < 10) ? ("0" + (hangVeThayDoiList.Count() + 1).ToString()) : (hangVeThayDoiList.Count().ToString());
            String maHangVe = "HV" + soHangVe;
            String tenHangVe = tb_tenHangVe.Text;
            byte tiLe = Byte.Parse(tb_tiLe.Text);
            
            // Add đối tượng vào List các hạng vé thay đổi
            HANGVE hangVeNew = new HANGVE { MaHangVe = maHangVe , TenHangVe =  tenHangVe, TiLeDonGia = tiLe};
            hangVeThayDoiList.Add(hangVeNew);
            int soLuongHangVe = hangVeThayDoiList.Count();
            tb_giaTriMoi.Text = soLuongHangVe.ToString();

            // Thêm dòng mới vào datagridview
            lv_danhSachHangVe.Rows[soLuongHangVe - 1].Cells[0].Value = (soLuongHangVe).ToString();
            lv_danhSachHangVe.Rows[soLuongHangVe - 1].Cells[1].Value = hangVeBanDauList[soLuongHangVe - 1].TenHangVe.ToString();
            lv_danhSachHangVe.Rows[soLuongHangVe - 1].Cells[2].Value = hangVeBanDauList[soLuongHangVe - 1].TiLeDonGia.ToString();
            lv_danhSachHangVe.Rows[soLuongHangVe - 1].Cells[3].Value = "Xóa";

            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            dataGridViewCellStyle.ForeColor = Color.White;
            dataGridViewCellStyle.BackColor = Color.Red;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lv_danhSachHangVe.Rows[soLuongHangVe - 1].Cells[3].Style = dataGridViewCellStyle;

            // Clear các textbox
            tb_tenHangVe.Clear();
            tb_tiLe.Clear();
        }

        private void btn_luuThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật những thay đổi ở trên không?", "Confirm", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes)) 
            {
                try
                {
                    Update_Database();
                    MessageBox.Show("Cập nhật hạng vé thành công!");
                    tb_giaTriMoi.Clear();
                } catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }   
            }
        }

        private void Update_Database()
        {
            using (var dbContext = new FlightKetDBEntities())
            {
                foreach (var hangVe in hangVeThayDoiList)
                {
                    dbContext.HANGVEs.AddOrUpdate(hangVe);
                }
                dbContext.SaveChanges();
            }
        }
    }
}
