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
        public FormLapBaoCao formParent;
        public FormLapBaoCaoThang(FormLapBaoCao formLapBaoCao)
        {
            InitializeComponent();
            formParent = formLapBaoCao;
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
                // Kiểm tra báo cáo có sẵn hay không
                var baoCaoThang = db.BAOCAOTHANGs.Where(a => a.Thang == thang && a.Nam == nam).ToList();
                // nếu báo cáo không có sẵn thì truy vấn rồi add vào database
                if(baoCaoThang.Count == 0)
                {
                    // Lấy ra danh sách chuyến bay theo tháng và năm được chọn
                    var listChuyenBay = db.CHUYENBAYs.Where(a => a.NgayGioKhoiHanh.Value.Month == thang && a.NgayGioKhoiHanh.Value.Year == nam).ToList();

                    if (listChuyenBay.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin các chuyến bay trong tháng");
                        return;
                    }

                    double tongDoanhThu = 0;
                    int tongChuyenbay = listChuyenBay.Count;
                    double[] doanhThuTungChuyenBay = new double[listChuyenBay.Count];
                    int[] soVeTungChuyenBay = new int[listChuyenBay.Count];
                    double[] tileTungChuyenBay = new double[listChuyenBay.Count];

                    // tính doanh thu của từng chuyến bay và cộng vào tổng doanh thu
                    for (int i = 0; i < listChuyenBay.Count; i++)
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
                    for (int i = 0; i < listChuyenBay.Count; i++)
                    {
                        tileTungChuyenBay[i] = (doanhThuTungChuyenBay[i] / tongDoanhThu) * 100;
                        tileTungChuyenBay[i] = Math.Round(tileTungChuyenBay[i], 2);
                    }
                    // hiển thị thông tin lên datagridView
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

                    // thêm dữ liệu mới truy vấn được vào csdl
                    // thêm báo cáo tháng
                    BAOCAOTHANG bAOCAOTHANG1 = new BAOCAOTHANG()
                    {
                        MaBCThang = "T" + thang.ToString() + (nam % 100).ToString(),
                        MaBCNam = "N" + nam.ToString(),
                        Thang = (short)thang,
                        Nam = (short)nam,
                        TongDoanhThuThang = tongDoanhThu,
                        TongChuyenBay = (short)tongChuyenbay,
                        TiLe = 1
                    };
                    db.BAOCAOTHANGs.Add(bAOCAOTHANG1);
                    db.SaveChanges();
                    // thêm chi tiết báo cáo tháng
                    for(int i = 0; i < listChuyenBay.Count; i++)
                    {
                        if (tileTungChuyenBay[i] > 0)
                        {
                            CT_BCTHANG cT_BCTHANG = new CT_BCTHANG()
                            {
                                MaBCThang = "T" + thang.ToString() + (nam % 100).ToString(),
                                MaChuyenBay = listChuyenBay[i].MaChuyenBay,
                                SoVe = (short)soVeTungChuyenBay[i],
                                DoanhThu = doanhThuTungChuyenBay[i],
                                TiLe = tileTungChuyenBay[i]
                            };
                            db.CT_BCTHANG.Add(cT_BCTHANG);
                        }
                        else
                        {
                            CT_BCTHANG cT_BCTHANG = new CT_BCTHANG()
                            {
                                MaBCThang = "T" + thang.ToString() + (nam % 100).ToString(),
                                MaChuyenBay = listChuyenBay[i].MaChuyenBay,
                                SoVe = (short)soVeTungChuyenBay[i],
                                DoanhThu = doanhThuTungChuyenBay[i],
                            };
                            db.CT_BCTHANG.Add(cT_BCTHANG);
                        }
                        
                    }
                    db.SaveChanges();

                    MessageBox.Show("Đã cập nhật danh sách doanh thu chuyến bay theo tháng");
                    lb_doanhThuBanVe.Text = "Doanh thu bán vé tháng " + thang.ToString() + " năm " + nam.ToString();
                }
                else if(baoCaoThang.Count > 0)
                {
                    string maBaoCaoThang = baoCaoThang.ToList().First().MaBCThang;
                    var listCTBCThang = db.CT_BCTHANG.Where(a => a.MaBCThang == maBaoCaoThang).ToList();
                    // Kiểm tra lại nếu tháng đang xét là tháng hiện tại thì phải load lại dữ liệu
                    if (thang == DateTime.Now.Month)
                    {
                        // xóa hết chi tiết báo cáo tháng của những chuyến bay trên tháng được chọn
                        foreach (var cT_BCTHANG in listCTBCThang)
                        {
                            CT_BCTHANG cT_BCTHANG1 = db.CT_BCTHANG.Find(cT_BCTHANG.MaBCThang, cT_BCTHANG.MaChuyenBay);
                            db.CT_BCTHANG.Remove(cT_BCTHANG1);
                            db.SaveChanges();
                        }

                        // thao tác truy vấn lại và add lại vào csdl
                        var listChuyenBay = db.CHUYENBAYs.Where(a => a.NgayGioKhoiHanh.Value.Month == thang && a.NgayGioKhoiHanh.Value.Year == nam).ToList();

                        if (listChuyenBay.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy thông tin các chuyến bay trong tháng");
                            return;
                        }

                        double tongDoanhThu = 0;
                        int tongChuyenbay = listChuyenBay.Count;
                        double[] doanhThuTungChuyenBay = new double[listChuyenBay.Count];
                        int[] soVeTungChuyenBay = new int[listChuyenBay.Count];
                        double[] tileTungChuyenBay = new double[listChuyenBay.Count];

                        // tính doanh thu của từng chuyến bay và cộng vào tổng doanh thu
                        for (int i = 0; i < listChuyenBay.Count; i++)
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
                        for (int i = 0; i < listChuyenBay.Count; i++)
                        {
                            tileTungChuyenBay[i] = (doanhThuTungChuyenBay[i] / tongDoanhThu) * 100;
                            tileTungChuyenBay[i] = Math.Round(tileTungChuyenBay[i], 2);
                        }
                        // hiển thị thông tin lên datagridView
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

                        // thêm dữ liệu mới truy vấn được vào csdl
                        // sửa lại báo cáo tháng
                        string maBaoCaoThang1 = "T" + thang.ToString() + (nam % 100).ToString();
                        BAOCAOTHANG bAOCAOTHANG1 = db.BAOCAOTHANGs.Find(maBaoCaoThang1);
                        bAOCAOTHANG1.TongDoanhThuThang = tongDoanhThu;
                        bAOCAOTHANG1.TongChuyenBay = (short)tongChuyenbay;
                        db.SaveChanges();
                        // thêm lại các chi tiết báo cáo tháng
                        for (int i = 0; i < listChuyenBay.Count; i++)
                        {
                            if (tileTungChuyenBay[i] > 0)
                            {
                                CT_BCTHANG cT_BCTHANG = new CT_BCTHANG()
                                {
                                    MaBCThang = "T" + thang.ToString() + (nam % 100).ToString(),
                                    MaChuyenBay = listChuyenBay[i].MaChuyenBay,
                                    SoVe = (short)soVeTungChuyenBay[i],
                                    DoanhThu = doanhThuTungChuyenBay[i],
                                    TiLe = tileTungChuyenBay[i]
                                };
                                db.CT_BCTHANG.Add(cT_BCTHANG);
                            }
                            else
                            {
                                CT_BCTHANG cT_BCTHANG = new CT_BCTHANG()
                                {
                                    MaBCThang = "T" + thang.ToString() + (nam % 100).ToString(),
                                    MaChuyenBay = listChuyenBay[i].MaChuyenBay,
                                    SoVe = (short)soVeTungChuyenBay[i],
                                    DoanhThu = doanhThuTungChuyenBay[i],
                                };
                                db.CT_BCTHANG.Add(cT_BCTHANG);
                            }

                        }
                        db.SaveChanges();

                        MessageBox.Show("Đã cập nhật danh sách doanh thu chuyến bay theo tháng");
                        lb_doanhThuBanVe.Text = "Doanh thu bán vé tháng " + thang.ToString() + " năm " + nam.ToString();

                    }
                    else
                    {
                        // nếu tháng cũ hơn thì chỉ cần load lên
                        dgv_doanhThuChuyenBay.RowCount = listCTBCThang.Count;
                        for (int i = 0; i < listCTBCThang.Count; i++)
                        {
                            dgv_doanhThuChuyenBay.Rows[i].Cells[0].Value = (i + 1).ToString();
                            dgv_doanhThuChuyenBay.Rows[i].Cells[1].Value = listCTBCThang[i].MaChuyenBay;
                            dgv_doanhThuChuyenBay.Rows[i].Cells[2].Value = listCTBCThang[i].SoVe;
                            dgv_doanhThuChuyenBay.Rows[i].Cells[3].Value = listCTBCThang[i].DoanhThu;
                            dgv_doanhThuChuyenBay.Rows[i].Cells[4].Value = listCTBCThang[i].TiLe;
                            dgv_doanhThuChuyenBay.Rows[i].Height = 30;
                        }
                        MessageBox.Show("Đã cập nhật danh sách doanh thu chuyến bay theo tháng");
                        lb_doanhThuBanVe.Text = "Doanh thu bán vé tháng " + thang.ToString() + " năm " + nam.ToString();
                    }
                    
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
            formParent.Close();
        }
    }
}
