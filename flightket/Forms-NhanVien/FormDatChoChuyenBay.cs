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

namespace flightket.Forms_NhanVien
{
    public partial class FormDatChoChuyenBay : Form
    {
        public FormDatChoChuyenBay()
        {
            InitializeComponent();

            using (var db = new FlightKetDBEntities())
            {
                var querry = db.HANGVEs.ToList();
                foreach (var entity in querry)
                {
                    cb_hangVe.Items.Add(entity.TenHangVe);
                }
                var querry1 = db.SANBAYs.ToList();
                foreach (var entity in querry1)
                {
                    cb_sanBayDi.Items.Add(entity.TenSanBay);
                    cb_sanBayDen.Items.Add(entity.TenSanBay);
                }
            }

        }

        private void btn_timChuyenBay_Click_1(object sender, EventArgs e)
        {
            if (cb_hangVe.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn hạng vé trước khi tìm kiếm");
                return;
            }
            using (var db = new FlightKetDBEntities())
            {
                var querry = from cb in db.CHUYENBAYs
                             from sb1 in db.SANBAYs
                             from sb2 in db.SANBAYs
                             from cthv in db.CT_HANGVE
                             from hv in db.HANGVEs
                             where cb.MaSanBayDi.Equals(sb1.MaSanBay) && cb.MaSanBayDen.Equals(sb2.MaSanBay) && hv.MaHangVe.Equals(cthv.MaHangVe) && hv.TenHangVe.Equals(cb_hangVe.Text) && cthv.MaChuyenBay.Equals(cb.MaChuyenBay)
                             select new { cb.MaChuyenBay, TenSanBayDi = sb1.TenSanBay, TenSanBayDen = sb2.TenSanBay, hv.TenHangVe, cb.NgayGioKhoiHanh };

                dp_ngayKhoiHanh.Value = new DateTime(dp_ngayKhoiHanh.Value.Year, dp_ngayKhoiHanh.Value.Month, dp_ngayKhoiHanh.Value.Day, 0, 0, 0);
                querry = querry.Where(cb => DbFunctions.TruncateTime(cb.NgayGioKhoiHanh) == dp_ngayKhoiHanh.Value).Select(cb => cb);
                if (cb_sanBayDi.Text.Length > 0)
                {
                    querry = querry.Where(a => a.TenSanBayDi == cb_sanBayDi.Text);
                }
                if (cb_sanBayDen.Text.Length > 0)
                {
                    querry = querry.Where(a => a.TenSanBayDen == cb_sanBayDen.Text);
                }
                var resultList = querry.ToList();


                if (resultList.Count > 0)
                {
                    List<int> listSoGheTrong = new List<int>();
                    List<double> listgiaVe = new List<double>();

                    for (int i = 0; i < resultList.Count; i++)
                    {
                        string maChuyenBay = resultList[i].MaChuyenBay;
                        var querry_tongSoGhe = from cb in db.CHUYENBAYs
                                               from hv in db.HANGVEs
                                               from cthv in db.CT_HANGVE
                                               where cb.MaChuyenBay.Equals(cthv.MaChuyenBay) && hv.MaHangVe.Equals(cthv.MaHangVe) && hv.TenHangVe.Equals(cb_hangVe.Text) && cb.MaChuyenBay.Equals(maChuyenBay)
                                               select new { cthv.SoLuongGhe };
                        int tongSoGhe = (int)querry_tongSoGhe.ToList().FirstOrDefault().SoLuongGhe;

                        var querry_soGheDaBan = from cb in db.CHUYENBAYs
                                                from vcb in db.VECHUYENBAYs
                                                where cb.MaChuyenBay.Equals(vcb.MaChuyenBay) && vcb.HANGVE.TenHangVe.Equals(cb_hangVe.Text) && cb.MaChuyenBay.Equals(maChuyenBay)
                                                select vcb;
                        int soGheDaBan = querry_soGheDaBan.ToList().Count();
                        var querry_soGheDaDat = from cb in db.CHUYENBAYs
                                                from pdc in db.PHIEUDATCHOes
                                                where cb.MaChuyenBay.Equals(pdc.MaChuyenBay) && pdc.HANGVE.TenHangVe.Equals(cb_hangVe.Text) && cb.MaChuyenBay.Equals(maChuyenBay)
                                                select pdc;
                        int soGheDaDat = querry_soGheDaDat.ToList().Count();

                        listSoGheTrong.Add(tongSoGhe - soGheDaBan - soGheDaDat);
                    }

                    //MessageBox.Show(resultList[0].MaChuyenBay);

                    for (int i = 0; i < resultList.Count; i++)
                    {
                        string maChuyenBay = resultList[i].MaChuyenBay;
                        var querry_giaVe = from cb in db.CHUYENBAYs
                                           from hv in db.HANGVEs
                                           from cthv in db.CT_HANGVE
                                           where cb.MaChuyenBay.Equals(cthv.MaChuyenBay) && cthv.MaHangVe.Equals(hv.MaHangVe) && cb.MaChuyenBay.Equals(maChuyenBay) && hv.TenHangVe.Equals(cb_hangVe.Text)
                                           select new { cb.GiaVe, hv.TiLeDonGia };
                        var result = querry_giaVe.ToList().FirstOrDefault();

                        double giave = (double)(result.GiaVe * result.TiLeDonGia) / 100;
                        listgiaVe.Add(giave);
                    }

                    dgv_chuyenBayPhuHop.RowCount = resultList.Count;
                    for (int i = 0; i < resultList.Count; i++)
                    {
                        dgv_chuyenBayPhuHop.Rows[i].Cells[0].Value = (i + 1).ToString();
                        dgv_chuyenBayPhuHop.Rows[i].Cells[1].Value = resultList[i].MaChuyenBay;
                        dgv_chuyenBayPhuHop.Rows[i].Cells[2].Value = resultList[i].NgayGioKhoiHanh.Value.TimeOfDay.ToString();
                        dgv_chuyenBayPhuHop.Rows[i].Cells[3].Value = listSoGheTrong[i].ToString();
                        dgv_chuyenBayPhuHop.Rows[i].Cells[4].Value = listgiaVe[i].ToString();
                        dgv_chuyenBayPhuHop.Rows[i].Cells[5].Value = "Chọn";
                        dgv_chuyenBayPhuHop.Rows[i].Height = 30;

                        DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                        dataGridViewCellStyle.ForeColor = Color.White;
                        dataGridViewCellStyle.BackColor = Color.SkyBlue;
                        dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_chuyenBayPhuHop.Rows[i].Cells[5].Style = dataGridViewCellStyle;
                    }

                    MessageBox.Show("Đã cập nhật thông tin chuyến bay phù hợp");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin chuyến bay phù hợp");
                }
            }
        }

        private void dgv_chuyenBayPhuHop_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dgv_chuyenBayPhuHop.SelectedCells[0].OwningRow.Cells[3].Value) != 0)
            {
                if (e.ColumnIndex == 5 && e.RowIndex >= 0)
                {
                    string maChuyenBay = (string)dgv_chuyenBayPhuHop.SelectedCells[0].OwningRow.Cells[1].Value;
                    double giaVe = Convert.ToDouble(dgv_chuyenBayPhuHop.SelectedCells[0].OwningRow.Cells[4].Value);
                    string tenHangVe = cb_hangVe.Text;

                    using (var db = new FlightKetDBEntities())
                    {
                        CHUYENBAY cHUYENBAY = db.CHUYENBAYs.Find(maChuyenBay);
                        if (cHUYENBAY.NgayGioKhoiHanh.Value < DateTime.Now)
                        {
                            MessageBox.Show("Chuyến bay được chọn đã khởi hành");
                            return;
                        }
                        THAMSO tHAMSO = db.THAMSOes.FirstOrDefault();
                        DateTime now = DateTime.Now;
                        TimeSpan timeDifference = cHUYENBAY.NgayGioKhoiHanh.Value - now;
                        TimeSpan soGioDatVeTrcKhoiHanh = new TimeSpan(tHAMSO.SoGioDatVeTruocKhoiHanh.Value, 0, 0);
                        if (timeDifference < soGioDatVeTrcKhoiHanh)
                        {
                            MessageBox.Show("Đã quá hạn để đặt vé chuyến bay này");
                            return;
                        }
                    }
                    FormDatCho formBanVe = new FormDatCho(maChuyenBay, giaVe, tenHangVe);
                    this.Hide();
                    formBanVe.ShowDialog();
                    if (formBanVe.IsAccessible == false)
                    {
                        this.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chuyến bay đươc chọn đã hết ghế trống");
                return;
            }
        }
    }
}
