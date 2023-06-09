using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace flightket.Forms_QuanLy
{
    public partial class NhapLichChuyenBay_File : Form
    {
        private string filePath;
        private FlightKetDBEntities db = new FlightKetDBEntities();

        public NhapLichChuyenBay_File()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            lb_progress.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            ImportFromExcel(filePath);
        }

        private void ImportFromExcel(string filePath)
        {
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
                Excel.Range usedRange = worksheet.UsedRange;

                int tongRowData = usedRange.Rows.Count - 1;
                MessageBox.Show("Tong so dong: " + tongRowData.ToString());
                int thanhCong = 0;

                for (int row = 2; row <= usedRange.Rows.Count; row++)
                {
                    string maChuyenBay = Convert.ToString(usedRange.Cells[row, 1].Value);
                    string maHangVe = Convert.ToString(usedRange.Cells[row, 2].Value);
                    short? soLuongGhe = Convert.ToInt16(usedRange.Cells[row, 3].Value);
                    string maSanBayDi = Convert.ToString(usedRange.Cells[row, 4].Value);
                    string maSanBayDen = Convert.ToString(usedRange.Cells[row, 5].Value);
                    DateTime ngayGioKhoiHanh = Convert.ToDateTime(usedRange.Cells[row, 6].Value);
                    int thoiGianBay = Convert.ToInt32(usedRange.Cells[row, 7].Value);
                    decimal giaVe = Convert.ToDecimal(usedRange.Cells[row, 8].Value);
                    int maCTCB = Convert.ToInt32(usedRange.Cells[row, 9].Value);
                    string maSanBayTrungGian = Convert.ToString(usedRange.Cells[row, 10].Value);
                    short? thoiGianDung = Convert.ToInt16(usedRange.Cells[row, 11].Value);
                    string ghiChu = Convert.ToString(usedRange.Cells[row, 12].Value);

                    var chuyenBay = new CHUYENBAY
                    {
                        MaChuyenBay = maChuyenBay,
                        MaSanBayDi = maSanBayDi,
                        MaSanBayDen = maSanBayDen,
                        NgayGioKhoiHanh = ngayGioKhoiHanh,
                        ThoiGianBay = (short?)thoiGianBay,
                        GiaVe = (double?)giaVe
                    };
                    listCHUYENBAY.Add(chuyenBay);

                    var ctChuyenBay = new CT_CHUYENBAY
                    {
                        MaCTCB = maCTCB,
                        MaChuyenBay = maChuyenBay,
                        MaSanBayTrungGian = maSanBayTrungGian,
                        ThoiGianDung = thoiGianDung,
                        GhiChu = ghiChu
                    };
                    listCTCHUYENBAY.Add(ctChuyenBay);

                    var ctHangVe = new CT_HANGVE
                    {
                        MaChuyenBay = maChuyenBay,
                        MaHangVe = maHangVe,
                        SoLuongGhe = soLuongGhe
                    };
                    listCTHANGVE.Add(ctHangVe);
                    thanhCong++;
                }

                db.CHUYENBAYs.AddRange(listCHUYENBAY);
                db.CT_CHUYENBAY.AddRange(listCTCHUYENBAY);
                db.CT_HANGVE.AddRange(listCTHANGVE);
                
                db.SaveChanges();

                MessageBox.Show("Nhập lịch chuyến bay thành công!\n" +
                    $"Tổng số dòng: {tongRowData}\n" +
                    $"Thành công: {thanhCong}\n" +
                    $"Thất bại: {tongRowData - thanhCong}");
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                Console.WriteLine(ex.Message);
                //CustomDialogForm customDialogForm = new CustomDialogForm("Không tìm thấy tệp tin. Có thể nó đã bị xóa hoặc di chuyển.");
                //customDialogForm.ShowDialog();
            }
            catch (Exception ex)
            {
                //CustomDialogForm customDialogForm = new CustomDialogForm(ex.Message);
                //customDialogForm.ShowDialog();
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
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
