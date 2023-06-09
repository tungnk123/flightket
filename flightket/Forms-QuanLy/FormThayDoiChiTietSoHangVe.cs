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
using System.Data.Entity;
using System.Data.SqlClient;

namespace flightket.Forms_QuanLy
{
    public partial class FormThayDoiChiTietSoHangVe : Form
    {
        List<HANGVE> hangVeBanDauList; // Hạng vé ban đầu (dữ liệu ban đầu)
        List<HANGVE> hangVeThayDoiList; // Hạng vé dùng để lưu thay đổi các giá trị thêm xóa Hangve
        List<int> viTriHangVeConTrong;
        List<HANGVE> hangVeThem;
        List<HANGVE> hangVeXoa;
        public FormThayDoiChiTietSoHangVe(List<HANGVE> hangVes)
        {
            InitializeComponent();
            this.hangVeBanDauList = new List<HANGVE>();
            this.hangVeThayDoiList = new List<HANGVE>();
            this.hangVeThem = new List<HANGVE>();
            this.hangVeXoa = new List<HANGVE>();

            this.viTriHangVeConTrong = new List<int>();
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
                    String maHangVe = hangVeThayDoiList[e.RowIndex].MaHangVe.ToString();
                    if (HasRecordForeignKeyInPhieuDatCho(maHangVe))
                    {
                        MessageBox.Show("Hạng vé đã được sử dụng trong PHIEUDATCHO nên không thể xóa");
                    } else if (HasRecordForeignKeyInVeChuyenBay(maHangVe))
                    {
                        MessageBox.Show("Hạng vé đã được sử dụng trong VECHUYENBAY nên không thể xóa");
                    } else if (HasRecordForeignKeyInCT_HANGVE(maHangVe))
                    {
                        MessageBox.Show("Hạng vé đã được sử dụng trong CT_CHUYENBAY nên không thể xóa");
                    }
                    else {
                        lv_danhSachHangVe.Rows.RemoveAt(e.RowIndex);
                        hangVeXoa.Add(hangVeThayDoiList[e.RowIndex]);
                        hangVeThayDoiList.RemoveAt(e.RowIndex);
                        viTriHangVeConTrong.Add(e.RowIndex + 1);
                        tb_giaTriMoi.Text = hangVeThayDoiList.Count().ToString();
                        Update_DataGridView();
                        MessageBox.Show("Xóa hạng vé thành công");
                    }                
                }
            }
        }

        // Kiểm tra xem mã hạng vé đó đã được sử dụng trong CT_HANGVE chưa 
        private bool HasRecordForeignKeyInCT_HANGVE(String maHangVe)
        {
            using (var dbContext = new FlightKetDBEntities())
            {
                var hangVeInCT_HANGVE = dbContext.CT_HANGVE.Where(ct_hangVe => ct_hangVe.MaHangVe == maHangVe).ToList();
                if (hangVeInCT_HANGVE.Any())
                {
                    return true;
                }
                return false;
            }
        }
        // Kiểm tra xem mã hạng vé đó đã được sử dụng trong PHIEUDATCHO chưa
        private bool HasRecordForeignKeyInPhieuDatCho(String maHangVe)
        {
            using (var dbContext = new FlightKetDBEntities())
            {
                var hangVeInPhieuDatCho = dbContext.PHIEUDATCHOes.Where(phieuDatCho => phieuDatCho.MaHangVe== maHangVe).ToList();   
                if (hangVeInPhieuDatCho.Any())
                {
                    return true;
                }
                return false;
            }
        }

        // Kiểm tra xem mã hạng vé đó đã được sử dụng trong VECHUYENBAY chưa
        private bool HasRecordForeignKeyInVeChuyenBay(String maHangVe)
        {
            using (var dbContext = new FlightKetDBEntities())
            {
                var hangVeInPhieuDatCho = dbContext.VECHUYENBAYs.Where(veChuyenBay => veChuyenBay.MaHangVe == maHangVe).ToList();
                if (hangVeInPhieuDatCho.Any())
                {
                    return true;
                }
                return false;
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
                } catch(Exception ex) 
                {
                    MessageBox.Show("Thêm hàng thất bại" + ex.Message);
                }
            }
        }
        
        // Kiểm tra hạng vé đã tồn tại trong hangVeThayDoiList
        private bool ContainMaHangVe(String maHangVeNew)
        {
            foreach(var hangVe in hangVeThayDoiList)
            {
                if (hangVe.MaHangVe.Trim() == maHangVeNew)
                {
                    return true;
                }
            }
            return false;
        }

        // Thêm hàng mới vào trong datagridview và thêm một đối tượng HANGVE vào trong hangVeThayDoiList
        private void Add_Rows()
        {
            // Tạo đối tượng hangVeNew
            int soHangVe = 0;
            String maHangVe;
            do
            {
                soHangVe++;
                maHangVe = (soHangVe < 10) ? ("HV0" + soHangVe.ToString()) : ("HV" + soHangVe);

            } while (ContainMaHangVe(maHangVe));
            
            String tenHangVe = tb_tenHangVe.Text;
            byte tiLe = Byte.Parse(tb_tiLe.Text);
            
            // Add đối tượng vào List các hạng vé thay đổi
            HANGVE hangVeNew = new HANGVE { MaHangVe = maHangVe , TenHangVe =  tenHangVe, TiLeDonGia = tiLe};
            hangVeThayDoiList.Add(hangVeNew);
            hangVeThem.Add(hangVeNew);
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
                    tb_giaTriCu.Text = hangVeThayDoiList.Count().ToString();
                    tb_giaTriMoi.Clear();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }
        }

        private void Update_Database()
        {
            using (var dbContext = new FlightKetDBEntities())
            {
                var hangVes = dbContext.HANGVEs;

                // -- Xóa hạng vé --//
                // Xác định điều kiện xóa
                var maHangVeXoa = hangVeXoa.Select(h => h.MaHangVe).ToList(); // Lấy danh sách mã hạng vé cần xóa

                foreach(var maHangVe in maHangVeXoa)
                {
                    var sql = "DELETE FROM HANGVE WHERE MaHangVe = @MaHangVe";
                    object[] parameters =
                    {
                        new SqlParameter("@MaHangVe", maHangVe)
                    };
                    dbContext.Database.ExecuteSqlCommand(sql, parameters);
                }

                // -- Thêm hạng vé --//
                foreach(var hangVe in hangVeThem)
                {
                    hangVes.AddOrUpdate(hangVe);
                }

                dbContext.SaveChanges();
            }
        }

        
    }
}
