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
using System.Windows.Forms.VisualStyles;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace flightket.Forms_QuanLy
{
    public partial class LapBaoCao_Nam : Form
    {
        FlightKetDBEntities db = new FlightKetDBEntities();
        public Form PreviousForm { get; set; }
        private String[] listNam;
        public LapBaoCao_Nam()
        {
            InitializeComponent();
            updateUI();
            mirrorData();
        }

        private void updateUI()
        {
            cb_nam.DropDownStyle = ComboBoxStyle.DropDownList;
            listNam = new string[] { "Chọn" };
            cb_nam.Items.AddRange(listNam);
            cb_nam.SelectedIndex = 0;

            lb_tongDoanhThu.Text = "0.0000";
            label5.Text = $"Báo cáo doanh thu theo năm TẤT CẢ";
        }

        private void mirrorData()
        {
            var dsBaoCaoNam = from c in db.BAOCAONAMs
                              select new
                              {
                                  MaBCNam = c.MaBCNam,
                                  Nam = c.Nam,
                                  TongDoanhThu = c.TongDoanhThu,
                              };

            cb_nam.DataSource = dsBaoCaoNam.ToList();
            cb_nam.DisplayMember = "Nam";
            cb_nam.ValueMember = "MaBCNam";

            lv_doanhThu.DataSource = dsBaoCaoNam.ToList();
            double? sumTongDoanhThu = dsBaoCaoNam.Sum(item => (double?)item.TongDoanhThu);

            if (sumTongDoanhThu.HasValue)
            {
                lb_tongDoanhThu.Text = sumTongDoanhThu.Value.ToString("0.000");
            }
            else
            {
                lb_tongDoanhThu.Text = "0.000";
            }

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeQuanLy formHomeQuanLy = new FormHomeQuanLy();
            formHomeQuanLy.ShowDialog();
        }

        private void cb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_nam.SelectedValue != null)
            {
                UpdateDataGridView();
                label5.Text = $"Báo cáo doanh thu theo năm {cb_nam.Text}";
            }            
        }
        private void UpdateDataGridView()
        {
            if (cb_nam.SelectedValue != null)
            {
                string selectedNam = cb_nam.SelectedValue.ToString();

                var dsBaoCaoNam = from c in db.BAOCAONAMs
                                  where c.MaBCNam == selectedNam
                                  select new
                                  {
                                      MaBCNam = c.MaBCNam,
                                      Nam = c.Nam,
                                      TongDoanhThu = c.TongDoanhThu,
                                  };

                lv_doanhThu.DataSource = dsBaoCaoNam.ToList();
                double? sumTongDoanhThu = dsBaoCaoNam.Sum(item => (double?)item.TongDoanhThu);

                if (sumTongDoanhThu.HasValue)
                {
                    lb_tongDoanhThu.Text = sumTongDoanhThu.Value.ToString("0.000");
                }
                else
                {
                    lb_tongDoanhThu.Text = "0.000";
                }
            }
            else
            {
                // Show all data when "Chọn" is selected in either ComboBox
                // lv_doanhThu.DataSource = dsBaoCaoThang.ToList();
            }

        }

        private void btn_xemTatCa_Click(object sender, EventArgs e)
        {
            var dsBaoCaoNam = from c in db.BAOCAONAMs
                              select new
                              {
                                  MaBCNam = c.MaBCNam,
                                  Nam = c.Nam,
                                  TongDoanhThu = c.TongDoanhThu,
                              };

            lv_doanhThu.DataSource = dsBaoCaoNam.ToList();
            double? sumTongDoanhThu = dsBaoCaoNam.Sum(item => (double?)item.TongDoanhThu);

            if (sumTongDoanhThu.HasValue)
            {
                lb_tongDoanhThu.Text = sumTongDoanhThu.Value.ToString("0.000");
            }
            else
            {
                lb_tongDoanhThu.Text = "0.000";
            }
            label5.Text = $"Báo cáo doanh thu theo năm TẤT CẢ";
        }

        private void btn_xemBaoCao_Click(object sender, EventArgs e)
        {
            if (cb_nam.SelectedValue != null)
            {
                UpdateDataGridView();
                label5.Text = $"Báo cáo doanh thu theo năm {cb_nam.Text}";
            }
        }

        private void btn_xuatBaoCao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Choose export format:\nExport as Excel: YES \nExport as CSV: NO\nClose this dialog: Cancel ", "Export Options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Export to Excel
                ExportToExcel(lv_doanhThu);
            }
            else if (result == DialogResult.No)
            {
                // Export to CSV
                ExportToCSV(lv_doanhThu);
            }
            else if (result == DialogResult.Cancel)
            {
                // Cancel the export
                // Optional: Add any cleanup or additional logic
            }
        }
        private void ExportToCSV(DataGridView dataGridView)
        {
            // Prompt user to select file location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Export to CSV";
            saveFileDialog.FileName = $"{label5.Text}.csv"; // Set default file name
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a StringBuilder to store the CSV data
                StringBuilder sb = new StringBuilder();

                // Append the column headers
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    sb.Append(column.HeaderText);
                    sb.Append(",");
                }
                sb.AppendLine();

                // Append the rows
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Escape the cell value if necessary
                        string cellValue = cell.Value?.ToString() ?? string.Empty;
                        cellValue = cellValue.Replace("\"", "\"\"");
                        sb.Append("\"" + cellValue + "\"");
                        sb.Append(",");
                    }
                    sb.AppendLine();
                }

                // Write the StringBuilder content to the CSV file
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());

                MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            // Prompt user to select file location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.FileName = $"{label5.Text}.xlsx"; // Set default file name
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new Excel package
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                ExcelPackage package = new ExcelPackage();

                // Create a new worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Set column headers
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                }

                // Populate rows with data
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                // Auto-fit columns for better readability
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Save the Excel package to the selected file
                File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());

                MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
