using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace flightket.Forms_QuanLy
{
    public partial class FormThayDoiQuiDinh : Form
    {
        List<SANBAY> sanBaysList;
        List<HANGVE> hangVesList;
        FlightKetDBEntities dbContext;
        public FormThayDoiQuiDinh()
        {
            InitializeComponent();
            Load_Data_ThamSo();
        }

        private void btn_thayDoiSoLuongSanBayMoi_Click(object sender, EventArgs e)
        {
            FormChiTietThayDoiSoSanBay formChiTietThayDoiSoSanBay = new FormChiTietThayDoiSoSanBay(sanBaysList);
            this.Hide();
            formChiTietThayDoiSoSanBay.ShowDialog();
        }

        private void btn_thayDoiSoLuongHangVeMoi_Click(object sender, EventArgs e)
        {
            FormThayDoiChiTietSoHangVe formThayDoiChiTietSoHangVe = new FormThayDoiChiTietSoHangVe(hangVesList);
            this.Hide();
            formThayDoiChiTietSoHangVe.ShowDialog();
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

        private void FormThayDoiQuiDinh_Load(object sender, EventArgs e)
        {
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

        // Kiểm tra chuỗi có là số thực
        public bool IsParseDouble(string input)
        {
            return Double.TryParse(input, out _);
        }

        private void Load_Data_ThamSo()
        {
            hangVesList = new List<HANGVE>();
            sanBaysList = new List<SANBAY>();
            using (dbContext = new FlightKetDBEntities())
            {
                var thamSoList = dbContext.THAMSOes.ToList();
                foreach (var thamSo in thamSoList)
                {
                    tb_thoiGianBayMinCu.Text = thamSo.ThoiGianBayToiThieu.ToString();
                    tb_sanBayTrungChuyenMaxCu.Text = thamSo.SoSanBayTrungGianToiDa.ToString();
                    tb_thoiGianDungMinCu.Text = thamSo.ThoiGianDungToiThieu.ToString();
                    tb_thoiGianDungMaxCu.Text = thamSo.ThoiGianDungToiDa.ToString();
                    tb_thoiGianTruocDatVeSlowestCu.Text = thamSo.SoGioDatVeTruocKhoiHanh.ToString();
                    tb_thoiGianTruocHuyVeSlowestCu.Text = thamSo.SoGioHuyPhieuTruocKhoiHanh.ToString();
                }

                var sanBays = dbContext.SANBAYs.ToList();
                foreach (var sanBay in sanBays)
                {
                    sanBaysList.Add((SANBAY)sanBay);
                }
                tb_thayDoiSoLuongSanBayCu.Text = sanBaysList.Count.ToString();

                var hangVes = dbContext.HANGVEs.ToList();
                foreach (var hangVe in hangVes)
                {
                    hangVesList.Add((HANGVE)hangVe);
                }
                tb_thayDoiSoLuongHangVeCu.Text = hangVesList.Count.ToString();
            }
        }

        // Kiểm tra chuỗi hợp lệ trong tb_thoiGianBayMinMoi
        private void tb_thoiGianBayMinMoi_Leave(object sender, EventArgs e)
        {
            String thoiGianBayMinMoi = tb_thoiGianBayMinMoi.Text;
            if (thoiGianBayMinMoi.Trim() == "")
            {
                tb_thoiGianBayMinMoi.Clear();
                return;
            }
            if (!IsNumeric(thoiGianBayMinMoi) || Int32.Parse(thoiGianBayMinMoi) <= 0)
            {
                MessageBox.Show("Thời gian bay tối thiểu phải là một số nguyên dương");
                tb_thoiGianBayMinMoi.Clear();
                return;
            }
            try
            {
                short thoiGianBayToiThieu = short.Parse(thoiGianBayMinMoi);
                if (thoiGianBayToiThieu < 30)
                {
                    MessageBox.Show("Thời gian bay tối thiểu phải lớn hơn 30");
                    tb_thoiGianBayMinMoi.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thời gian bay tối thiểu phải là một số nguyên dương!" + ex.Message);
                tb_thoiGianBayMinMoi.Clear();
            }
        }

        private void tb_sanBayTrungChuyenMaxMoi_Leave(object sender, EventArgs e)
        {
            String soSanBayToiDa = tb_sanBayTrungChuyenMaxMoi.Text;
            if (soSanBayToiDa.Trim() == "")
            {
                tb_sanBayTrungChuyenMaxMoi.Clear();
                return;
            }
            if (!IsNumeric(soSanBayToiDa) || Int32.Parse(soSanBayToiDa) < 0)
            {
                MessageBox.Show("Số sân bay trung chuyển tối đa phải là một số nguyên dương");
                tb_sanBayTrungChuyenMaxMoi.Clear();
                return;
            }
            try
            {
                short thoiGianBayToiThieu = short.Parse(soSanBayToiDa);
                if (thoiGianBayToiThieu <= 0)
                {
                    MessageBox.Show("Số sân bay trung chuyển tối đa phải là số nguyên dương lớn hơn hoặc bằng 1");
                    tb_sanBayTrungChuyenMaxMoi.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số sân bay trung chuyển tối đa phải là một số nguyên dương!" + ex.Message);
                tb_sanBayTrungChuyenMaxMoi.Clear();
            }
        }

        private void tb_thoiGianDungMinMoi_Leave(object sender, EventArgs e)
        {
            String thoiGianDungMinMoi = tb_thoiGianDungMinMoi.Text;
            if (thoiGianDungMinMoi.Trim() == "")
            {
                tb_thoiGianDungMinMoi.Clear();
                return;
            }
            if (!IsNumeric(thoiGianDungMinMoi) || Int32.Parse(thoiGianDungMinMoi) < 0)
            {
                MessageBox.Show("Thời gian dừng tối thiểu phải là một số nguyên dương");
                tb_thoiGianDungMinMoi.Clear();
                return;
            }
            try
            {
                short thoiGianDungToiThieu = short.Parse(thoiGianDungMinMoi);
                if (thoiGianDungToiThieu < 10)
                {
                    MessageBox.Show("Thời gian dừng tối thiểu phải là một số nguyên dương >= 10");
                    tb_thoiGianDungMinMoi.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thời gian dừng tối thiểu phải là một số nguyên dương!" + ex.Message);
                tb_thoiGianDungMinMoi.Clear();
            }
        }

        private void tb_thoiGianDungMaxMoi_Leave(object sender, EventArgs e)
        {
            String thoiGianDungMaxMoi = tb_thoiGianDungMaxMoi.Text;
            if (thoiGianDungMaxMoi.Trim() == "")
            {
                tb_thoiGianDungMaxMoi.Clear();
                return;
            }
            if (!IsNumeric(thoiGianDungMaxMoi) || Int32.Parse(thoiGianDungMaxMoi) < 0)
            {
                MessageBox.Show("Thời gian dừng tối đa phải là một số nguyên dương");
                tb_thoiGianDungMaxMoi.Clear();
                return;
            }
            try
            {
                short thoiGianDungToiDa = short.Parse(thoiGianDungMaxMoi);
                if (thoiGianDungToiDa < 30)
                {
                    MessageBox.Show("Thời gian dừng tối đa phải là một số nguyên dương >= 30");
                    tb_thoiGianDungMaxMoi.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thời gian dừng tối đa phải là một số nguyên dương!" + ex.Message);
                tb_thoiGianDungMaxMoi.Clear();
            }
        }

        private void tb_thoiGianTruocDatVeSlowestMoi_Leave(object sender, EventArgs e)
        {
            String thoiGianChamNhatTruocKhiDatVeString = tb_thoiGianTruocDatVeSlowestMoi.Text;
            if (thoiGianChamNhatTruocKhiDatVeString.Trim() == "")
            {
                tb_thoiGianTruocDatVeSlowestMoi.Clear();
                return;
            }
            if (!IsNumeric(thoiGianChamNhatTruocKhiDatVeString) || Int32.Parse(thoiGianChamNhatTruocKhiDatVeString) < 0)
            {
                MessageBox.Show("Thời gian chậm nhất trước khi đặt vé phải là một số nguyên dương");
                tb_thoiGianTruocDatVeSlowestMoi.Clear();
                return;
            }
            try
            {
                short thoiGianChamNhatTruocKhiDatVeShort = short.Parse(thoiGianChamNhatTruocKhiDatVeString);
                if (thoiGianChamNhatTruocKhiDatVeShort < 2)
                {
                    MessageBox.Show("Thời gian chậm nhất trước khi đặt vé phải là một số nguyên dương >= 2");
                    tb_thoiGianTruocDatVeSlowestMoi.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thời gian chậm nhất trước khi đặt vé phải là một số nguyên dương !" + ex.Message);
                tb_thoiGianTruocDatVeSlowestMoi.Clear();
            }
        }

        private void tb_thoiGianTruocHuyVeSlowestMoi_Leave(object sender, EventArgs e)
        {
            String thoiGianChamNhatTruocKhiHuyVeString = tb_thoiGianTruocHuyVeSlowestMoi.Text;
            if (thoiGianChamNhatTruocKhiHuyVeString.Trim() == "")
            {
                tb_thoiGianTruocHuyVeSlowestMoi.Clear();
                return;
            }
            if (!IsNumeric(thoiGianChamNhatTruocKhiHuyVeString) || Int32.Parse(thoiGianChamNhatTruocKhiHuyVeString) < 0)
            {
                MessageBox.Show("Thời gian chậm nhất trước khi hủy vé phải là một số nguyên dương");
                tb_thoiGianTruocHuyVeSlowestMoi.Clear();
                return;
            }
            try
            {
                short thoiGianChamNhatTruocKhiHuyVeShort = short.Parse(thoiGianChamNhatTruocKhiHuyVeString);
                if (thoiGianChamNhatTruocKhiHuyVeShort < 8)
                {
                    MessageBox.Show("Thời gian chậm nhất trước khi hủy vé phải là một số nguyên dương >= 8");
                    tb_thoiGianTruocHuyVeSlowestMoi.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thời gian chậm nhất trước khi hủy vé phải là một số nguyên dương" + ex.Message);
                tb_thoiGianTruocHuyVeSlowestMoi.Clear();
            }
        }

        private void btn_luuThayDoi_Click(object sender, EventArgs e)
        {
            int thoiGianBayMinMoi = -1;
            int thoiGianDungMinMoi = -1;
            int thoiGianDungMaxMoi = -1;
            int thoiGianTruocDatVeSlowestMoi = -1;
            int thoiGianTruocHuyVeSlowestMoi = -1;
            int sanBayTrungChuyenMaxMoi = -1;

            bool validInput = true;

            if (!string.IsNullOrEmpty(tb_thoiGianBayMinMoi.Text))
            {
                if (!Int32.TryParse(tb_thoiGianBayMinMoi.Text, out thoiGianBayMinMoi) || thoiGianBayMinMoi <= 0)
                {
                    validInput = false;
                }
            }

            if (!string.IsNullOrEmpty(tb_thoiGianDungMinMoi.Text))
            {
                if (!Int32.TryParse(tb_thoiGianDungMinMoi.Text, out thoiGianDungMinMoi) || thoiGianDungMinMoi <= 0)
                {
                    validInput = false;
                }
            }

            if (!string.IsNullOrEmpty(tb_thoiGianDungMaxMoi.Text))
            {
                if (!Int32.TryParse(tb_thoiGianDungMaxMoi.Text, out thoiGianDungMaxMoi) || thoiGianDungMaxMoi <= 0)
                {
                    validInput = false;
                }
            }

            if (!string.IsNullOrEmpty(tb_thoiGianTruocDatVeSlowestMoi.Text))
            {
                if (!Int32.TryParse(tb_thoiGianTruocDatVeSlowestMoi.Text, out thoiGianTruocDatVeSlowestMoi) || thoiGianTruocDatVeSlowestMoi <= 0)
                {
                    validInput = false;
                }
            }

            if (!string.IsNullOrEmpty(tb_thoiGianTruocHuyVeSlowestMoi.Text))
            {
                if (!Int32.TryParse(tb_thoiGianTruocHuyVeSlowestMoi.Text, out thoiGianTruocHuyVeSlowestMoi) || thoiGianTruocHuyVeSlowestMoi <= 0)
                {
                    validInput = false;
                }
            }

            if (!string.IsNullOrEmpty(tb_sanBayTrungChuyenMaxMoi.Text))
            {
                if (!Int32.TryParse(tb_sanBayTrungChuyenMaxMoi.Text, out sanBayTrungChuyenMaxMoi) || sanBayTrungChuyenMaxMoi <= 0)
                {
                    validInput = false;
                }
            }

            if (!validInput)
            {
                MessageBox.Show("Giá trị thay đổi không hợp lệ! Vui lòng thử lại");
                return;
            }





            DialogResult result = MessageBox.Show("Bạn có chắc muốn lưu thay đổi?", "Confirm", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                try
                {
                    Update_Data_From_New_To_Old();
                    Update_Data_From_Database();
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại!" + ex.Message);
                }

            }
        }

        // Cập nhật dữ liệu lên database
        private void Update_Data_From_Database()
        {
            short thoiGianBayToiThieuUpdate = short.Parse(tb_thoiGianBayMinCu.Text);
            short sanBayTrungChuyenMaxUpdate = short.Parse(tb_sanBayTrungChuyenMaxCu.Text);
            short thoiGianDungToiThieuUpdate = short.Parse(tb_thoiGianDungMinCu.Text);
            short thoiGianDungToiDaUpdate = short.Parse(tb_thoiGianDungMaxCu.Text);
            short thoiGianChamNhatTruocDatVeUpdate = short.Parse(tb_thoiGianTruocDatVeSlowestCu.Text);
            short thoiGianChamNhatTruocHuyVeUpdate = short.Parse(tb_thoiGianTruocHuyVeSlowestCu.Text);
            using (dbContext = new FlightKetDBEntities())
            {
                var thamSoTable = dbContext.THAMSOes.FirstOrDefault();
                thamSoTable.ThoiGianBayToiThieu = thoiGianBayToiThieuUpdate;
                thamSoTable.SoSanBayTrungGianToiDa = sanBayTrungChuyenMaxUpdate;
                thamSoTable.ThoiGianDungToiThieu = thoiGianDungToiThieuUpdate;
                thamSoTable.ThoiGianDungToiDa = thoiGianDungToiDaUpdate;
                thamSoTable.SoGioDatVeTruocKhoiHanh = thoiGianChamNhatTruocDatVeUpdate;
                thamSoTable.SoGioHuyPhieuTruocKhoiHanh = thoiGianChamNhatTruocHuyVeUpdate;

                dbContext.SaveChanges();
            }
        }

        // Lưu dữ liệu từ mới sang cũ
        private void Update_Data_From_New_To_Old()
        {
            tb_thoiGianBayMinCu.Text = (tb_thoiGianBayMinMoi.Text != String.Empty) ? tb_thoiGianBayMinMoi.Text : tb_thoiGianBayMinCu.Text;
            tb_sanBayTrungChuyenMaxCu.Text = (tb_sanBayTrungChuyenMaxMoi.Text != String.Empty) ? tb_sanBayTrungChuyenMaxMoi.Text : tb_sanBayTrungChuyenMaxCu.Text;
            tb_thoiGianDungMinCu.Text = (tb_thoiGianDungMinMoi.Text != String.Empty) ? tb_thoiGianDungMinMoi.Text : tb_thoiGianDungMinCu.Text;
            tb_thoiGianDungMaxCu.Text = (tb_thoiGianDungMaxMoi.Text != String.Empty) ? tb_thoiGianDungMaxMoi.Text : tb_thoiGianDungMaxCu.Text;
            tb_thoiGianTruocDatVeSlowestCu.Text = (tb_thoiGianTruocDatVeSlowestMoi.Text != String.Empty) ? tb_thoiGianTruocDatVeSlowestMoi.Text : tb_thoiGianTruocDatVeSlowestCu.Text;
            tb_thoiGianTruocHuyVeSlowestCu.Text = (tb_thoiGianTruocHuyVeSlowestMoi.Text != String.Empty) ? tb_thoiGianTruocHuyVeSlowestMoi.Text : tb_thoiGianTruocHuyVeSlowestCu.Text;

            tb_thoiGianBayMinMoi.Clear();
            tb_sanBayTrungChuyenMaxMoi.Clear();
            tb_thoiGianDungMinMoi.Clear();
            tb_thoiGianDungMaxMoi.Clear();
            tb_thoiGianTruocDatVeSlowestMoi.Clear();
            tb_thoiGianTruocHuyVeSlowestMoi.Clear();
        }


    }
}
