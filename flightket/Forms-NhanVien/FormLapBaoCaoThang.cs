using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

                    if(thang == DateTime.Now.Month)
                    {
                        MessageBox.Show("Đã cập nhật danh sách doanh thu chuyến bay theo tháng");
                        lb_doanhThuBanVe.Text = "Doanh thu bán vé tháng " + thang.ToString() + " năm " + nam.ToString();
                        lb_tongDoanhThu.Text = "Tổng doanh thu: " + Regex.Replace(tongDoanhThu.ToString(), @"\B(?=(\d{3})+(?!\d))", ".") + " đồng";
                        return;
                    }

                    // thêm dữ liệu mới truy vấn được vào csdl

                    // thêm báo cáo năm
                    BAOCAONAM timBaoCaoNam = db.BAOCAONAMs.Find("T" + nam.ToString());
                    if( timBaoCaoNam == null)
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
                    lb_tongDoanhThu.Text = "Tổng doanh thu: " + Regex.Replace(tongDoanhThu.ToString(), @"\B(?=(\d{3})+(?!\d))", ".") + " đồng";
                }
                else if(baoCaoThang.Count > 0 && thang == DateTime.Now.Month)
                {
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
                    MessageBox.Show("Đã cập nhật danh sách doanh thu chuyến bay theo tháng");
                    lb_doanhThuBanVe.Text = "Doanh thu bán vé tháng " + thang.ToString() + " năm " + nam.ToString();
                    lb_tongDoanhThu.Text = "Tổng doanh thu: " + Regex.Replace(tongDoanhThu.ToString() ,@"\B(?=(\d{3})+(?!\d))", ".") + " đồng";
                }
                else
                {
                    string maBaoCaoThang = baoCaoThang.ToList().First().MaBCThang;
                    var listCTBCThang = db.CT_BCTHANG.Where(a => a.MaBCThang == maBaoCaoThang).ToList();
                    double tongDoanhThu = 0;
                 
                    // nếu tháng cũ thì chỉ cần load lên
                    dgv_doanhThuChuyenBay.RowCount = listCTBCThang.Count;
                    for (int i = 0; i < listCTBCThang.Count; i++)
                    {
                        dgv_doanhThuChuyenBay.Rows[i].Cells[0].Value = (i + 1).ToString();
                        dgv_doanhThuChuyenBay.Rows[i].Cells[1].Value = listCTBCThang[i].MaChuyenBay;
                        dgv_doanhThuChuyenBay.Rows[i].Cells[2].Value = listCTBCThang[i].SoVe;
                        dgv_doanhThuChuyenBay.Rows[i].Cells[3].Value = listCTBCThang[i].DoanhThu;
                        tongDoanhThu += (double)listCTBCThang[i].DoanhThu;
                        dgv_doanhThuChuyenBay.Rows[i].Cells[4].Value = listCTBCThang[i].TiLe;
                        dgv_doanhThuChuyenBay.Rows[i].Height = 30;
                    }
                    MessageBox.Show("Đã cập nhật danh sách doanh thu chuyến bay theo tháng");
                    lb_doanhThuBanVe.Text = "Doanh thu bán vé tháng " + thang.ToString() + " năm " + nam.ToString();
                    lb_tongDoanhThu.Text = "Tổng doanh thu: " + Regex.Replace(tongDoanhThu.ToString(), @"\B(?=(\d{3})+(?!\d))", ".") + " đồng";

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

        private void btn_xuatBaoCao_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            // Tạo một workbook mới
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Số hàng và số cột trong DataGridView
            int rowCount = dgv_doanhThuChuyenBay.Rows.Count;
            int colCount = dgv_doanhThuChuyenBay.Columns.Count;

            // Ghi tiêu đề cột vào worksheet
            for (int j = 1; j <= colCount; j++)
            {
                worksheet.Cells[1, j] = dgv_doanhThuChuyenBay.Columns[j - 1].HeaderText;
            }

            // Ghi dữ liệu từ DataGridView vào worksheet
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    worksheet.Cells[i + 1, j] = dgv_doanhThuChuyenBay.Rows[i - 1].Cells[j - 1].Value;
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
    }
}
