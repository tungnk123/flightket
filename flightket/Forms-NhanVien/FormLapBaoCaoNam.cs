using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace flightket.Forms_NhanVien
{
    public partial class FormLapBaoCaoNam : Form
    {
        int nam;
        private FormLapBaoCao formParent;
        public FormLapBaoCaoNam(FormLapBaoCao formLapBaoCao)
        {
            InitializeComponent();
            formParent = formLapBaoCao;
        }

        private void btn_xemBaoCao_Click(object sender, EventArgs e)
        {
            if(cb_nam.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn năm trước khi lập báo cáo");
                return;
            }
            using (var db = new FlightKetDBEntities())
            {
                nam = Convert.ToInt32(cb_nam.Text);
                capNhatLaiTatCaBaoCaoThangTrongNam();
                string maBaoCaoNam = "N" + cb_nam.Text;
                var BaoCaoThangs = from bct in db.BAOCAOTHANGs
                                      from bcn in db.BAOCAONAMs
                                      where bct.MaBCNam == bcn.MaBCNam && bcn.MaBCNam == maBaoCaoNam
                                      orderby bct.Thang ascending
                                      select bct;
                var listBaoCaoThang = BaoCaoThangs.ToList();
                double[] tiLeTungThang = new double[listBaoCaoThang.Count];
                double tongDoanhThuNam = 0;
                for(int i = 0; i <  listBaoCaoThang.Count; i++)
                {
                    tongDoanhThuNam += (double)listBaoCaoThang[i].TongDoanhThuThang;
                }
                for(int i =0; i < listBaoCaoThang.Count; i++)
                {
                    tiLeTungThang[i] = (double)(listBaoCaoThang[i].TongDoanhThuThang / tongDoanhThuNam) * 100;
                }
                dgv_doanhThuNam.RowCount = listBaoCaoThang.Count;
                for(int i = 0; i < listBaoCaoThang.Count; i++)
                {
                    dgv_doanhThuNam.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_doanhThuNam.Rows[i].Cells[1].Value = listBaoCaoThang[i].Thang;
                    dgv_doanhThuNam.Rows[i].Cells[2].Value = listBaoCaoThang[i].TongChuyenBay;
                    dgv_doanhThuNam.Rows[i].Cells[3].Value = listBaoCaoThang[i].TongDoanhThuThang;
                    dgv_doanhThuNam.Rows[i].Cells[4].Value = Math.Round(tiLeTungThang[i], 2);
                    dgv_doanhThuNam.Rows[i].Height = 30;
                }
                MessageBox.Show("Đã cập nhật danh sách doanh thu chuyến bay theo năm");
                lb_doanhThuBanVe.Text = "Doanh thu bán vé năm " + nam.ToString() ;
                lb_tongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThuNam.ToString() + " đồng";
            }
        }

        private void capNhatLaiTatCaBaoCaoThangTrongNam()
        {
            for(int j = 1; j <= 12; j++)
            {
                int thang = j;
                using (var db = new FlightKetDBEntities())
                {
                    // Kiểm tra báo cáo có sẵn hay không
                    var baoCaoThang = db.BAOCAOTHANGs.Where(a => a.Thang == thang && a.Nam == nam).ToList();
                    // nếu báo cáo không có sẵn thì truy vấn rồi add vào database
                    if (baoCaoThang.Count == 0)
                    {
                        // Lấy ra danh sách chuyến bay theo tháng và năm được chọn
                        var listChuyenBay = db.CHUYENBAYs.Where(a => a.NgayGioKhoiHanh.Value.Month == thang && a.NgayGioKhoiHanh.Value.Year == nam).ToList();

                        if (listChuyenBay.Count == 0)
                        {
                            string maBaoCaoNam = "N" + nam.ToString();
                            BAOCAONAM timBaoCaoNam1 = db.BAOCAONAMs.Find(maBaoCaoNam);
                            if (timBaoCaoNam1 == null)
                            {
                                BAOCAONAM bAOCAONAM1 = new BAOCAONAM()
                                {
                                    MaBCNam = "N" + nam.ToString(),
                                    Nam = (short)nam,
                                    TongDoanhThu = 0
                                };
                                db.BAOCAONAMs.Add(bAOCAONAM1);
                                db.SaveChanges();
                            }


                            // thêm báo cáo tháng
                            BAOCAOTHANG bAOCAOTHANG = new BAOCAOTHANG()
                            {
                                MaBCThang = "T" + thang.ToString() + (nam % 100).ToString(),
                                MaBCNam = "N" + nam.ToString(),
                                Thang = (short)thang,
                                Nam = (short)nam,
                                TongDoanhThuThang = 0,
                                TongChuyenBay = 0,
                            };
                            db.BAOCAOTHANGs.Add(bAOCAOTHANG);
                            db.SaveChanges();
                            continue;
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

                        // thêm dữ liệu mới truy vấn được vào csdl

                        // thêm báo cáo năm
                        BAOCAONAM timBaoCaoNam = db.BAOCAONAMs.Find("N" + nam.ToString());
                        if (timBaoCaoNam == null)
                        {
                            BAOCAONAM bAOCAONAM = new BAOCAONAM()
                            {
                                MaBCNam = "N" + nam.ToString(),
                                Nam = (short)nam,
                                TongDoanhThu = 0
                            };
                            db.BAOCAONAMs.Add(bAOCAONAM);
                            db.SaveChanges();
                        }


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
                                if(db.CT_BCTHANG.Find(cT_BCTHANG.MaBCThang, cT_BCTHANG.MaChuyenBay) == null)
                                {
                                    db.CT_BCTHANG.Add(cT_BCTHANG);
                                }
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
                                if (db.CT_BCTHANG.Find(cT_BCTHANG.MaBCThang, cT_BCTHANG.MaChuyenBay) == null)
                                {
                                    db.CT_BCTHANG.Add(cT_BCTHANG);
                                }
                            }
                        }
                        db.SaveChanges();
                    }
                    

                }
            }
            
        }

        private void btn_xuatBaoCao_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            // Tạo một workbook mới
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Số hàng và số cột trong DataGridView
            int rowCount = dgv_doanhThuNam.Rows.Count;
            int colCount = dgv_doanhThuNam.Columns.Count;

            // Ghi tiêu đề cột vào worksheet
            for (int j = 1; j <= colCount; j++)
            {
                worksheet.Cells[1, j] = dgv_doanhThuNam.Columns[j - 1].HeaderText;
            }

            // Ghi dữ liệu từ DataGridView vào worksheet
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    worksheet.Cells[i + 1, j] = dgv_doanhThuNam.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            worksheet.Cells[rowCount + 2, colCount] = lb_tongDoanhThu.Text;

            // Hiển thị SaveFileDialog để chọn vị trí và tên tệp Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu workbook vào tệp Excel
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Close();

                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Đóng workbook nếu người dùng không chọn tệp Excel
                workbook.Close();
            }

            // Đóng ứng dụng Excel
            excelApp.Quit();
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
