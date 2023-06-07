using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_NhanVien
{
    public partial class FormLapBaoCaoThang : Form
    {
        public FormLapBaoCaoThang()
        {
            InitializeComponent();
        }

        private void btn_xemBaoCao_Click(object sender, EventArgs e)
        {
            int thang, nam;
            try
            {
                thang = Convert.ToInt32(cb_thang.Text);
                nam = Convert.ToInt32(cb_nam.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin tháng và năm hợp lệ");
                return;
            }

            using (var db = new FlightKetDBEntities())
            {
                // Lấy ra danh sách chuyến bay theo tháng và năm được chọn
                var listChuyenBay = db.CHUYENBAYs.Where(a => a.NgayGioKhoiHanh.Value.Month == thang && a.NgayGioKhoiHanh.Value.Year == nam).ToList();

                if(listChuyenBay.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin các chuyến bay trong tháng");
                    return;
                }

                double tongDoanhThu = 0;
                double[] doanhThuTungChuyenBay = new double[listChuyenBay.Count];
                int[] soVeTungChuyenBay = new int[listChuyenBay.Count];
                double[] tileTungChuyenBay = new double[listChuyenBay.Count];

                // tính doanh thu của từng chuyến bay và cộng vào tổng doanh thu
                for(int i = 0; i < listChuyenBay.Count; i++)
                {
                    string maChuyenBay = listChuyenBay[i].MaChuyenBay;
                    var VeChuyenBay = from cb in db.CHUYENBAYs
                                      from vcb in db.VECHUYENBAYs
                                      where cb.MaChuyenBay == vcb.MaChuyenBay && cb.MaChuyenBay == maChuyenBay
                                      select new { vcb.GiaTien };
                    var listVeChuyenBay = VeChuyenBay.ToList();
                    soVeTungChuyenBay[i] = listVeChuyenBay.Count;
                    foreach (var veChuyenBay in listVeChuyenBay)
                    {
                        tongDoanhThu += (double)veChuyenBay.GiaTien;
                        doanhThuTungChuyenBay[i] += (double)veChuyenBay.GiaTien;
                    }
                }
                // tính tỉ lệ doanh thu của từng chuyến bay
                for(int i = 0;i < listChuyenBay.Count; i++)
                {
                    tileTungChuyenBay[i] = (doanhThuTungChuyenBay[i] / tongDoanhThu) * 100;
                    tileTungChuyenBay[i] = Math.Round(tileTungChuyenBay[i], 2);
                }

                dgv_doanhThuChuyenBay.RowCount = listChuyenBay.Count;
                for (int i = 0; i < listChuyenBay.Count; i++)
                {
                    dgv_doanhThuChuyenBay.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_doanhThuChuyenBay.Rows[i].Cells[1].Value = listChuyenBay[i].MaChuyenBay;
                    dgv_doanhThuChuyenBay.Rows[i].Cells[2].Value = soVeTungChuyenBay[i];
                    dgv_doanhThuChuyenBay.Rows[i].Cells[3].Value = doanhThuTungChuyenBay[i];
                    dgv_doanhThuChuyenBay.Rows[i].Cells[4].Value = tileTungChuyenBay[i]; 
                    dgv_doanhThuChuyenBay.Rows[i].Height = 30;

                }
                MessageBox.Show("Đã cập nhật danh sách doanh thu chuyến bay theo tháng");
                lb_doanhThuBanVe.Text = "Doanh thu bán vé tháng " + thang.ToString() + " năm " + nam.ToString();
            }

        }
    }
}
