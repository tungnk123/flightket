using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace flightket.Forms_QuanLy
{
    public partial class CustomDialogForm : Form
    {
        private String ErrorString;
        public CustomDialogForm(String ErrorString)
        {
            InitializeComponent();
            this.ErrorString = ErrorString;
            lb_codeError.Text = ErrorString;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabelTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Template Excel";
            saveFileDialog.FileName = "TemplateChuyeBayFullDetail.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create the Excel file with the template data
                string templateFilePath = saveFileDialog.FileName;
                CreateTemplateExcelFile(templateFilePath);
            }
        }
        private void CreateTemplateExcelFile(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage package = new ExcelPackage();
            // Create a new Excel workbook and add a worksheet
            var worksheet = package.Workbook.Worksheets.Add("Template");

            // Add the template column headers
            worksheet.Cells[1, 1].Value = "MaChuyenBay";
            worksheet.Cells[1, 2].Value = "MaHangVe";
            worksheet.Cells[1, 3].Value = "SoLuongGhe";
            worksheet.Cells[1, 4].Value = "MaSanBayDi";
            worksheet.Cells[1, 5].Value = "MaSanBayDen";
            worksheet.Cells[1, 6].Value = "NgayGioKhoiHanh";
            worksheet.Cells[1, 7].Value = "ThoiGianBay";
            worksheet.Cells[1, 8].Value = "GiaVe";
            worksheet.Cells[1, 9].Value = "MaCTCB";
            worksheet.Cells[1, 10].Value = "MaSanBayTrungGian";
            worksheet.Cells[1, 11].Value = "ThoiGianDung";
            worksheet.Cells[1, 12].Value = "GhiChu";
            

            // Save the Excel file
            FileInfo excelFile = new FileInfo(filePath);
            package.SaveAs(excelFile);

            DialogResult result = MessageBox.Show("Template Excel file saved successfully!", "Save Template", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Close();
            }

        }
    }
}
