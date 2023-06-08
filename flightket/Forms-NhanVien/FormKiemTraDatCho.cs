using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace flightket.Forms_NhanVien
{
    public partial class FormKiemTraDatCho : Form
    {
        private int maDatChoID;
        private string maHanhKhach, maChuyenBay, maHangVe;
        public FormKiemTraDatCho()
        {
            InitializeComponent();
        }

        private void btn_kiemTra_Click(object sender, EventArgs e)
        {
            string hoten = tb_hoVaTen.Text;
            string cmnd = tb_CMND.Text;
            string soDienThoai = tb_soDienThoai.Text;

            if (!IsLegalName(hoten) || !IsJustNumber(soDienThoai) || !IsJustNumber(cmnd))
            {
                MessageBox.Show("Thông tin không hợp lệ! Vui lòng nhập lại!");
                return;
            }
            using (var db = new FlightKetDBEntities())
            {
                var result = from hanhkhach in db.HANHKHACHes
                             from phieudatcho in db.PHIEUDATCHOes
                             from hangve in db.HANGVEs
                             where hanhkhach.MaHanhKhach.Equals(phieudatcho.MaHanhKhach) && hangve.MaHangVe.Equals(phieudatcho.MaHangVe)
                             select new { phieudatcho.MaChuyenBay, phieudatcho.MaPhieuDatCho, hangve.TenHangVe, hanhkhach.TenHanhKhach, hanhkhach.CMND, hanhkhach.SDT, phieudatcho.CHUYENBAY.NgayGioKhoiHanh };
                result = result.Where(a => a.NgayGioKhoiHanh.Value > DateTime.Now);
                if (tb_hoVaTen.Text.Length > 0)
                {
                    result = result.Where(c => c.TenHanhKhach.Equals(hoten));
                }
                if (tb_CMND.Text.Length > 0)
                {
                    result = result.Where(c => c.CMND.Equals(cmnd));
                }
                if (tb_soDienThoai.Text.Length > 0)
                {
                    result = result.Where(c => c.SDT.Equals(soDienThoai));
                }

                var resultList = result.ToList();

                if (resultList.Count > 0)
                {
                    panelDanhSachPhieuDatCho.Visible = true;
                    panelChiTietPhieuDatCho.Visible = false;
                    dataGridView1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy danh sách phiếu đặt chỗ phù hợp");
                    panelDanhSachPhieuDatCho.Visible = false;
                    panelChiTietPhieuDatCho.Visible = false;
                    return;
                }

                dataGridView1.RowCount = resultList.Count;
                for (int i = 0; i < resultList.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dataGridView1.Rows[i].Cells[1].Value = resultList[i].MaChuyenBay;
                    dataGridView1.Rows[i].Cells[2].Value = resultList[i].MaPhieuDatCho.ToString();
                    dataGridView1.Rows[i].Cells[3].Value = resultList[i].TenHangVe;
                    dataGridView1.Rows[i].Cells[4].Value = "Chọn";
                    dataGridView1.Rows[i].Height = 30;

                    //
                    DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                    dataGridViewCellStyle.ForeColor = Color.White;
                    dataGridViewCellStyle.BackColor = Color.SkyBlue;
                    dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Rows[i].Cells[4].Style = dataGridViewCellStyle;
                }

            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                maDatChoID = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[2].Value);
                using (var db = new FlightKetDBEntities())
                {
                    var result = from hanhkhach in db.HANHKHACHes
                                 from phieudatcho in db.PHIEUDATCHOes
                                 from hangve in db.HANGVEs
                                 from chuyenbay in db.CHUYENBAYs
                                 from sanbay in db.SANBAYs
                                 where hanhkhach.MaHanhKhach.Equals(phieudatcho.MaHanhKhach) && hangve.MaHangVe.Equals(phieudatcho.MaHangVe) && phieudatcho.MaChuyenBay.Equals(chuyenbay.MaChuyenBay) && phieudatcho.MaPhieuDatCho.Equals(maDatChoID)//&&
                                 //hanhkhach.TenHanhKhach.Equals(tb_hoVaTen.Text) && hanhkhach.CMND.Equals(tb_CMND.Text) && hanhkhach.SDT.Equals(tb_soDienThoai.Text) && phieudatcho.MaPhieuDatCho.Equals(maDatChoID)
                                 select new { phieudatcho.MaPhieuDatCho, chuyenbay.MaChuyenBay, hanhkhach.TenHanhKhach, hanhkhach.CMND, hanhkhach.NgaySinh, hanhkhach.SDT, chuyenbay.NgayGioKhoiHanh, hangve.TenHangVe, phieudatcho.GiaTien, hanhkhach.MaHanhKhach, hangve.MaHangVe };
                    if (tb_hoVaTen.Text.Length > 0)
                    {
                        result = result.Where(c => c.TenHanhKhach.Equals(tb_hoVaTen.Text));
                    }
                    if (tb_CMND.Text.Length > 0)
                    {
                        result = result.Where(c => c.CMND.Equals(tb_CMND.Text));
                    }
                    if (tb_soDienThoai.Text.Length > 0)
                    {
                        result = result.Where(c => c.SDT.Equals(tb_soDienThoai.Text));
                    }

                    var resultList = result.ToList();
                    var item = resultList.FirstOrDefault();

                    var result2 = from cb in db.CHUYENBAYs
                                  from sb1 in db.SANBAYs
                                  from sb2 in db.SANBAYs
                                  where cb.MaChuyenBay.Equals(item.MaChuyenBay) && cb.MaSanBayDi.Equals(sb1.MaSanBay) && cb.MaSanBayDen.Equals(sb2.MaSanBay)
                                  select new { TenSanBayDi = sb1.TenSanBay, TenSanBayDen = sb2.TenSanBay };
                    var resultList2 = result2.ToList();
                    var item2 = resultList2.FirstOrDefault();

                    if (item != null)
                    {
                        maHanhKhach = item.MaHanhKhach;
                        maChuyenBay = item.MaChuyenBay;
                        maHangVe = item.MaHangVe;

                        lb_maDatCho.Text = item.MaPhieuDatCho.ToString();
                        lb_maChuyenBay.Text = item.MaChuyenBay;
                        lb_hoVaTen.Text = item.TenHanhKhach;
                        lb_CMND.Text = item.CMND;
                        lb_ngaySinh.Text = item.NgaySinh.Value.Date.ToShortDateString();
                        lb_soDienThoai.Text = item.SDT.ToString();
                        lb_ngayDi.Text = item.NgayGioKhoiHanh.Value.Date.ToShortDateString();
                        lb_gioKhoiHanh.Text = item.NgayGioKhoiHanh.Value.TimeOfDay.ToString();
                        lb_hangVe.Text = item.TenHangVe.ToString();
                        lb_giaVe.Text = item.GiaTien.ToString();
                        lb_sanBayDi.Text = item2.TenSanBayDi.ToString();
                        lb_sanBayDen.Text = item2.TenSanBayDen.ToString();
                        dataGridView1.Visible = false;
                        panelChiTietPhieuDatCho.Visible = true;
                        panelChiTietPhieuDatCho.BringToFront();
                    }
                }
            }
        }

        private void btn_banVe_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận bán vé", "FlightKet - Bán vé", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                using (var db = new FlightKetDBEntities())
                {
                    PHIEUDATCHO pHIEUDATCHO = db.PHIEUDATCHOes.Find(maDatChoID);
                    if (pHIEUDATCHO == null) return;
                    VECHUYENBAY vECHUYENBAY = new VECHUYENBAY() { MaChuyenBay = pHIEUDATCHO.MaChuyenBay, MaHangVe = pHIEUDATCHO.MaHangVe, MaHanhKhach = pHIEUDATCHO.MaHanhKhach, GiaTien = pHIEUDATCHO.GiaTien };
                    db.PHIEUDATCHOes.Remove(pHIEUDATCHO);
                    db.VECHUYENBAYs.Add(vECHUYENBAY);
                    db.SaveChanges();
                    panelChiTietPhieuDatCho.Visible = false;
                    panelDanhSachPhieuDatCho.Visible = false;
                    MessageBox.Show("Bán vé thành công");
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
        }

        private void btn_huyDatCho_Click(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                PHIEUDATCHO pHIEUDATCHO = db.PHIEUDATCHOes.Find(maDatChoID);
                CHUYENBAY cHUYENBAY = db.CHUYENBAYs.Find(maChuyenBay);
                if (pHIEUDATCHO == null) return;
                THAMSO tHAMSO = db.THAMSOes.FirstOrDefault();
                DateTime now = DateTime.Now;
                TimeSpan timeDifference = cHUYENBAY.NgayGioKhoiHanh.Value - now;
                TimeSpan soGioHuyVeTruocKhoiHanh = new TimeSpan(tHAMSO.SoGioHuyPhieuTruocKhoiHanh.Value, 0, 0);
                if (timeDifference < soGioHuyVeTruocKhoiHanh)
                {
                    MessageBox.Show("Không thể hủy đặt chỗ vì chuyến bay sắp khởi hành");
                    return;
                }
                db.PHIEUDATCHOes.Remove(pHIEUDATCHO);
                db.SaveChanges();
                panelChiTietPhieuDatCho.Visible = false;
                panelDanhSachPhieuDatCho.Visible = false;
                MessageBox.Show("Hủy đặt chỗ thành công");
            }
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            FormCapNhatThongTinPhieuDatCho formCapNhatThongTinPhieuDatCho = new FormCapNhatThongTinPhieuDatCho(maDatChoID, maChuyenBay, maHanhKhach, maHangVe, this);
            this.Hide();
            formCapNhatThongTinPhieuDatCho.ShowDialog();
            if (formCapNhatThongTinPhieuDatCho.IsAccessible == false)
            {
                using (var db = new FlightKetDBEntities())
                {
                    HANHKHACH hANHKHACH = db.HANHKHACHes.Find(this.maHanhKhach);
                    PHIEUDATCHO pHIEUDATCHO = db.PHIEUDATCHOes.Find(this.maDatChoID);

                    lb_hoVaTen.Text = hANHKHACH.TenHanhKhach;
                    lb_CMND.Text = hANHKHACH.CMND;
                    lb_ngaySinh.Text = hANHKHACH.NgaySinh.Value.ToShortDateString();
                    lb_soDienThoai.Text = hANHKHACH.SDT;
                    lb_giaVe.Text = pHIEUDATCHO.GiaTien.ToString();

                    tb_hoVaTen.Text = hANHKHACH.TenHanhKhach;
                    tb_CMND.Text = hANHKHACH.CMND;
                    tb_soDienThoai.Text = hANHKHACH.SDT;

                    //var querry = from pdc in db.PHIEUDATCHOes
                    //             from hv in db.HANGVEs
                    //             where pdc.MaHangVe.Equals(hv.MaHangVe)
                    //             select new { hv.TenHangVe };
                    var querry = db.HANGVEs.Where(c => c.MaHangVe == pHIEUDATCHO.MaHangVe);
                    var result = querry.ToList().FirstOrDefault();
                    this.maHangVe = pHIEUDATCHO.MaHangVe;
                    lb_hangVe.Text = result.TenHangVe;



                }
                this.Show();
            }
        }
        public static bool IsLegalName(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsJustNumber(string number)
        {
            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
