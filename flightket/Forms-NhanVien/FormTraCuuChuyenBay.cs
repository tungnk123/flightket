using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace flightket.Forms_NhanVien
{
    public partial class FormTraCuuChuyenBay : Form
    {
        public static FormTraCuuChuyenBay instance;
        public string maChuyenBay;
        public string sanBayDi;
        public string sanBayDen;
        public DateTime ngayKhoiHanh;
        public FormTraCuuChuyenBay()
        {
            instance = this;
            InitializeComponent();
            using (var db = new FlightKetDBEntities())
            {
                var sanBayQuery = from sanbaydi in db.SANBAYs
                                  select new { TenSanBay = sanbaydi.TenSanBay };
                var sanBayList = sanBayQuery.ToList();
                var sanBayDenList = sanBayQuery.ToList();
                cb_sanBayDi.DisplayMember = "TenSanBay";
                cb_sanBayDi.DataSource = sanBayList;
                cb_sanBayDen.DisplayMember = "TenSanBay";
                cb_sanBayDen.DataSource = sanBayDenList;



            }
            cb_sanBayDen.SelectedIndex = -1;
            cb_sanBayDi.SelectedIndex = -1;

            if (chb_ngayKhoiHanh.Checked)
            {
                ngayKhoiHanh = dp_ngayKhoiHanh.Value.Date;
            }



        }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            maChuyenBay = tb_maChuyenBay.Text;
            sanBayDi = cb_sanBayDi.Text;
            sanBayDen = cb_sanBayDen.Text;
            using (var db = new FlightKetDBEntities())
            {
                var result = from chuyenbay in db.CHUYENBAYs
                             from sanbaydi in db.SANBAYs
                             from sanbayden in db.SANBAYs
                             where chuyenbay.MaSanBayDi == sanbaydi.MaSanBay && chuyenbay.MaSanBayDen == sanbayden.MaSanBay
                             select new
                             {
                                 MaChuyenBay = chuyenbay.MaChuyenBay,
                                 TenSanBayDi = sanbaydi.TenSanBay,
                                 TenSanBayDen = sanbayden.TenSanBay,
                                 NgayGioKhoiHanh = chuyenbay.NgayGioKhoiHanh,
                                 ThoiGianBay = chuyenbay.ThoiGianBay
                             };
                if (chb_ngayKhoiHanh.Checked)
                {
                    result = result.Where(c => DbFunctions.TruncateTime(c.NgayGioKhoiHanh) == ngayKhoiHanh.Date);
                }

                if (maChuyenBay.Length > 0)
                {
                    result = result.Where(c => c.MaChuyenBay.Equals(maChuyenBay));
                }
                if (sanBayDi.Length > 0)
                {
                    result = result.Where(c => c.TenSanBayDi.Equals(sanBayDi));
                }
                if (sanBayDen.Length > 0)
                {
                    result = result.Where(c => c.TenSanBayDen.Equals(sanBayDen));
                }

                var resultList = result.ToList();

                List<int> listSoGheTrong = new List<int>();
                List<int> listSoGheDaDat = new List<int>();
                List<int> listTongSoGhe = new List<int>();
                if (resultList.Count > 0)
                {
                    MessageBox.Show("Tìm kiếm thành công! Loading ...");
                    for (int i = 0; i < resultList.Count; i++)
                    {
                        listSoGheTrong.Add(0);
                        listSoGheDaDat.Add(0);
                        listTongSoGhe.Add(0);
                    }
                    lb_danhSachChuyenBayPhuHop.Visible = true;
                    dgv_chuyenBayPhuHop.Visible = true;
                    for (int i = 0; i < resultList.Count; i++)
                    {
                        string maChuyenBay = resultList[i].MaChuyenBay;
                        var query_tongSoGhe = from chuyenbay in db.CHUYENBAYs
                                              from ct_hangve in db.CT_HANGVE
                                              where chuyenbay.MaChuyenBay.Equals(ct_hangve.MaChuyenBay) && chuyenbay.MaChuyenBay.Equals(maChuyenBay)
                                              select ct_hangve.SoLuongGhe;

                        var query_tongSoGhe_List = query_tongSoGhe.ToList();
                        for (int j = 0; j < query_tongSoGhe_List.Count; j++)
                        {
                            listTongSoGhe[i] += (int)query_tongSoGhe_List[j];

                        }
                        //MessageBox.Show(tongSoGhe.ToString());
                        //var querry_tongSoGhe = from cb in db.CHUYENBAYs
                        //                       from hv in db.HANGVEs
                        //                       from cthv in db.CT_HANGVE
                        //                       where cb.MaChuyenBay.Equals(cthv.MaChuyenBay) && hv.MaHangVe.Equals(cthv.MaHangVe) && hv.TenHangVe.Equals(cb_hangVe.Text) && cb.MaChuyenBay.Equals(maChuyenBay)
                        //                       select new { cthv.SoLuongGhe };
                        //int tongSoGhe = (int)querry_tongSoGhe.ToList().FirstOrDefault().SoLuongGhe;


                        var querry_soGheDaDatPDC = from cb in db.CHUYENBAYs
                                                   where cb.MaChuyenBay.Equals(maChuyenBay)
                                                   select cb.PHIEUDATCHOes.Count;
                        var query_soGheDaDatVe = from chuyenbay in db.CHUYENBAYs
                                                 where chuyenbay.MaChuyenBay.Equals(maChuyenBay)
                                                 select chuyenbay.VECHUYENBAYs.Count;
                        int soGheDaDatPDC = querry_soGheDaDatPDC.ToList().First();
                        int soGheDaDatVe = query_soGheDaDatVe.ToList().First();
                        listSoGheDaDat[i] = soGheDaDatPDC + soGheDaDatVe;

                        listSoGheTrong[i] = listTongSoGhe[i] - listSoGheDaDat[i];

                        //listSoGheTrong.Add(tongSoGhe - soGheDaBan - soGheDaDat);
                    }


                    //
                    dgv_chuyenBayPhuHop.RowCount = resultList.Count;
                    for (int i = 0; i < resultList.Count; i++)
                    {
                        dgv_chuyenBayPhuHop.Rows[i].Cells[0].Value = (i + 1).ToString();
                        dgv_chuyenBayPhuHop.Rows[i].Cells[1].Value = resultList[i].MaChuyenBay;
                        dgv_chuyenBayPhuHop.Rows[i].Cells[2].Value = resultList[i].TenSanBayDi;
                        dgv_chuyenBayPhuHop.Rows[i].Cells[3].Value = resultList[i].TenSanBayDen;
                        dgv_chuyenBayPhuHop.Rows[i].Cells[4].Value = resultList[i].NgayGioKhoiHanh.Value.Date.ToShortDateString();
                        dgv_chuyenBayPhuHop.Rows[i].Cells[5].Value = resultList[i].ThoiGianBay.ToString();
                        dgv_chuyenBayPhuHop.Rows[i].Cells[6].Value = listSoGheTrong[i].ToString();
                        dgv_chuyenBayPhuHop.Rows[i].Cells[7].Value = listSoGheDaDat[i].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy danh sách phiếu đặt chỗ phù hợp");
                    lb_danhSachChuyenBayPhuHop.Visible = false;
                    dgv_chuyenBayPhuHop.Visible = false;
                    return;
                }


            }


        }

        private void cb_ngayKhoiHanh_CheckStateChanged(object sender, EventArgs e)
        {
            if (chb_ngayKhoiHanh.Checked)
            {
                dp_ngayKhoiHanh.Visible = true;
                ngayKhoiHanh = dp_ngayKhoiHanh.Value;
            }
            else
            {
                dp_ngayKhoiHanh.Visible = false;
            }
        }

        private void dp_ngayKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
            ngayKhoiHanh = dp_ngayKhoiHanh.Value;
        }

        private void btn_xuatThongTin_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_chuyenBayPhuHop);

        }
        private void ExportToExcel(DataGridView dgv)
        {
            // Create a SaveFileDialog instance
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";

            // Display the file dialog and check if the user clicked the "OK" button
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Creating Excel Application
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Creating Excel Workbook
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Missing.Value);

                // Creating Excel Worksheet
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.ActiveSheet;

                // Set column headers from DataGridView
                for (int j = 1; j <= dgv.Columns.Count; j++)
                {
                    excelWorksheet.Cells[1, j] = dgv.Columns[j - 1].HeaderText;
                }

                // Writing DataGridView data to Excel Worksheet
                for (int i = 2; i <= dgv.Rows.Count + 1; i++)
                {
                    for (int j = 1; j <= dgv.Columns.Count; j++)
                    {
                        excelWorksheet.Cells[i, j] = dgv.Rows[i - 2].Cells[j - 1].Value.ToString();
                    }
                }

                // Save the Excel file at the chosen location
                excelWorkbook.SaveAs(filePath);

                // Close the workbook and the Excel application
                excelWorkbook.Close();
                excelApp.Quit();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeNhanVien.instance.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeNhanVien.instance.Show();
        }

        private void FormTraCuuChuyenBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHomeNhanVien.instance.Show();
        }

        
    }
}
