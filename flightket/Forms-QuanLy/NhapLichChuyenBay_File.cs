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
using System.Reflection;

namespace flightket.Forms_QuanLy
{
    public partial class NhapLichChuyenBay_File : Form
    {
        public Form PreviousForm { get; set; }
        FlightKetDBEntities db = new FlightKetDBEntities();
        private string filePath;
        public NhapLichChuyenBay_File()
        {
            InitializeComponent();
            updateUI();
        }

        private void updateUI()
        {
            lb_progress.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormHomeQuanLy loginForm = Application.OpenForms.OfType<FormHomeQuanLy>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
                this.Close();
            }
        }
        private void llb_chonFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Select an Excel file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                if (filePath != null)
                {
                    lb_fileDaChon.Text = filePath;
                }
            }
        }
        private void btn_xacNhan_Click_1(object sender, EventArgs e)
        {
            ImportFromExcel(filePath);
        }
        private void ImportFromExcel(string filePath)
        {
            /* Excel.Application excelApp = new Excel.Application();
             Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
             Excel.Worksheet worksheet = workbook.ActiveSheet;*/
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            List<CHUYENBAY> listCHUYENBAY = new List<CHUYENBAY>();
            List<CT_CHUYENBAY> listCTCHUYENBAY = new List<CT_CHUYENBAY>();
            List<CT_HANGVE> listCTHANGVE = new List<CT_HANGVE>();

            try
            {
                lb_progress.Visible = true;
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.ActiveSheet;
                // Get the range of used cells in the worksheet
                Excel.Range usedRange = worksheet.UsedRange;

                int tongRowData = usedRange.Rows.Count - 1;
                MessageBox.Show("Tong so dong" + tongRowData.ToString());
                int thanhCong = 0;

                // Iterate through the rows in the range, skipping the header row
                for (int row = 2; row <= usedRange.Rows.Count; row++)
                {
                    lb_progress.Text = $"Đang đọc dữ liệu {row} / {tongRowData}";
                    //if (String.IsNullOrEmpty(usedRange.Cells[row].Cells[1].Value)) {
                    //    break;
                    //}

                    // Read the values from the Excel file
                    string maChuyenBay = Convert.ToString(usedRange.Cells[row, 1].Value);
                    string maHangVe = Convert.ToString(usedRange.Cells[row, 2].Value);

                    int soLuongGhe = Convert.ToInt32(usedRange.Cells[row, 3].Value);

                    string maSanBayDi = Convert.ToString(usedRange.Cells[row, 4].Value);
                    string maSanBayDen = Convert.ToString(usedRange.Cells[row, 5].Value);
                    DateTime ngayGioKhoiHanh = Convert.ToDateTime(usedRange.Cells[row, 6].Value);

                    int thoiGianBay = Convert.ToInt32(usedRange.Cells[row, 7].Value);

                    double giaVe = Convert.ToDouble(usedRange.Cells[row, 8].Value);
                    string maCTCB = Convert.ToString(usedRange.Cells[row, 9].Value);
                    string maSanBayTrungGian = Convert.ToString(usedRange.Cells[row, 10].Value);

                    int thoiGianDung = Convert.ToInt32(usedRange.Cells[row, 11].Value);

                    string ghiChu = Convert.ToString(usedRange.Cells[row, 12].Value);
                    string tenSanBay = Convert.ToString(usedRange.Cells[row, 13].Value);
                    string quocGia = Convert.ToString(usedRange.Cells[row, 14].Value);
                    string diaChi = Convert.ToString(usedRange.Cells[row, 15].Value);

                    // Create a new object and populate its properties
                    var newData = new
                    {
                        MaChuyenBay = maChuyenBay,
                        MaHangVe = maHangVe,
                        SoLuongGhe = soLuongGhe,
                        MaSanBayDi = maSanBayDi,
                        MaSanBayDen = maSanBayDen,
                        NgayGioKhoiHanh = ngayGioKhoiHanh,
                        ThoiGianBay = thoiGianBay,
                        GiaVe = giaVe,
                        MaCTCB = maCTCB,
                        MaSanBayTrungGian = maSanBayTrungGian,
                        ThoiGianDung = thoiGianDung,
                        GhiChu = ghiChu,
                        TenSanBay = tenSanBay,
                        QuocGia = quocGia,
                        DiaChi = diaChi
                    };

                    if (newData.GetType().GetProperties().Any(prop => prop.GetValue(newData) == null))
                    {
                        continue;
                    }
                    else
                    {
                        if (db.CHUYENBAYs.Any(ct => ct.MaChuyenBay == maChuyenBay))
                        {
                            continue;
                        }
                        else
                        {
                            CHUYENBAY itemCHUYENBAY = new CHUYENBAY()
                            {
                                MaChuyenBay = maChuyenBay,
                                MaSanBayDi = maSanBayDi,
                                MaSanBayDen = maSanBayDen,
                                NgayGioKhoiHanh = ngayGioKhoiHanh,
                                ThoiGianBay = (short)thoiGianBay,
                                GiaVe = (float)usedRange.Cells[row, 8].Value,
                            };

                            if (!db.CHUYENBAYs.Any(ct => ct.MaChuyenBay == itemCHUYENBAY.MaChuyenBay))
                            {
                                if (db.SANBAYs.Any(ct => ct.MaSanBay == itemCHUYENBAY.MaSanBayDi))
                                {
                                    if (db.SANBAYs.Any(ct => ct.MaSanBay == itemCHUYENBAY.MaSanBayDen))
                                    {
                                        listCHUYENBAY.Add(itemCHUYENBAY);
                                        CT_CHUYENBAY itemCTCHUYENBAY = new CT_CHUYENBAY()
                                        {
                                            MaChuyenBay = maChuyenBay,
                                            MaSanBayTrungGian = maSanBayTrungGian,
                                            ThoiGianDung = Convert.ToInt16(thoiGianDung),
                                            GhiChu = ghiChu
                                        };
                                        if (db.SANBAYs.Any(ct => ct.MaSanBay == itemCTCHUYENBAY.MaSanBayTrungGian))
                                        {

                                            listCTCHUYENBAY.Add(itemCTCHUYENBAY);
                                            CT_HANGVE itemCTHANGVE = new CT_HANGVE()
                                            {
                                                MaChuyenBay = maChuyenBay.ToString(),
                                                MaHangVe = maHangVe.ToString(),
                                                SoLuongGhe = Convert.ToInt16(soLuongGhe)
                                            };
                                            if (db.CT_HANGVE.Any(ct => ct.MaHangVe == itemCTHANGVE.MaHangVe))
                                            {
                                                // Add the new object to the database using Entity Framework
                                                if (!db.CT_HANGVE.Any(ct => ct.MaChuyenBay == itemCTHANGVE.MaChuyenBay))
                                                {
                                                    listCTHANGVE.Add(itemCTHANGVE);
                                                }
                                                thanhCong++;
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
                db.CHUYENBAYs.AddRange(listCHUYENBAY);
                db.CT_CHUYENBAY.AddRange(listCTCHUYENBAY);
                db.CT_HANGVE.AddRange(listCTHANGVE);
                // Save changes to the database
                db.SaveChanges();

                MessageBox.Show("Data imported from Excel successfully! \n" + $"Tổng Dòng Dữ Liệu: {tongRowData}\n" + $"Thành Công: {thanhCong}\n" + $"Thất Bại: {tongRowData - thanhCong}");
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Không tìm thấy File do có thể bị xóa, hoặc di chuyển");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing data from Excel: " + ex.Message);
            }
            finally
            {
                if (workbook != null)
                {
                    workbook.Close();
                    excelApp.Quit();
                    ReleaseObject(worksheet);
                    ReleaseObject(workbook);
                    ReleaseObject(excelApp);
                }
            }
            lb_progress.Visible = false;
        }


        // Helper method to release COM objects }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ctDSHangVe = from c in db.CT_HANGVE
                             select new
                             {
                                 MaChuyenBay = c.MaChuyenBay,
                                 MaHangVe = c.MaHangVe,
                                 SoLuongGhe = c.SoLuongGhe
                             };
            var duLieuChuyenBay = from c in db.CHUYENBAYs
                                  select new
                                  {
                                      MaChuyenBay = c.MaChuyenBay,
                                      MaSanBayDi = c.MaSanBayDi,
                                      MaSanBayDen = c.MaSanBayDen,
                                      NgayGioKhoiHanh = c.NgayGioKhoiHanh,
                                      ThoiGianBay = c.ThoiGianBay,
                                      GiaVe = c.GiaVe
                                  };

            var duLieuCTChuyenBay = from c in db.CT_CHUYENBAY
                                    select new
                                    {
                                        MaCTCB = c.MaCTCB,
                                        MaChuyenBay = c.MaChuyenBay,
                                        MaSanBayTrungGian = c.MaSanBayTrungGian,
                                        ThoiGianDung = c.ThoiGianDung,
                                        GhiChu = c.GhiChu,
                                        TenSanBay = c.SANBAY.TenSanBay,
                                        QuocGia = c.SANBAY.QuocGia,
                                        DiaChi = c.SANBAY.DiaChi
                                    };

            var combinedData = from ct in ctDSHangVe
                               join cb in duLieuChuyenBay on ct.MaChuyenBay equals cb.MaChuyenBay
                               join ctc in duLieuCTChuyenBay on cb.MaChuyenBay equals ctc.MaChuyenBay
                               select new
                               {
                                   MaChuyenBay = ct.MaChuyenBay,
                                   MaHangVe = ct.MaHangVe,
                                   SoLuongGhe = ct.SoLuongGhe,
                                   MaSanBayDi = cb.MaSanBayDi,
                                   MaSanBayDen = cb.MaSanBayDen,
                                   NgayGioKhoiHanh = cb.NgayGioKhoiHanh,
                                   ThoiGianBay = cb.ThoiGianBay,
                                   GiaVe = cb.GiaVe,
                                   MaCTCB = ctc.MaCTCB,
                                   MaSanBayTrungGian = ctc.MaSanBayTrungGian,
                                   ThoiGianDung = ctc.ThoiGianDung,
                                   GhiChu = ctc.GhiChu,
                                   TenSanBay = ctc.TenSanBay,
                                   QuocGia = ctc.QuocGia,
                                   DiaChi = ctc.DiaChi
                               };



            ExportToExcel(combinedData);


        }

        // in thu ra du lieu chuyen bay

        private void ExportToExcel(IEnumerable<dynamic> data)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Set the headers in the Excel file
            int columnCount = data.First().GetType().GetProperties().Length;
            for (int i = 1; i <= columnCount; i++)
            {
                string header = data.First().GetType().GetProperties()[i - 1].Name;
                worksheet.Cells[1, i] = header;
            }

            // Populate the data in the Excel file
            int row = 2;
            foreach (var item in data)
            {
                for (int column = 1; column <= columnCount; column++)
                {
                    string columnName = item.GetType().GetProperties()[column - 1].Name;
                    object value = item.GetType().GetProperty(columnName).GetValue(item, null);
                    worksheet.Cells[row, column] = value;
                }
                row++;
            }

            // Save the Excel file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                workbook.SaveAs(filePath);
                workbook.Close();

                excelApp.Quit();
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excelApp);

                MessageBox.Show("Data exported to Excel successfully!");
            }
        }


    }
}
