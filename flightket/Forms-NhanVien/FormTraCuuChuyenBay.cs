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
    public partial class FormTraCuuChuyenBay : Form
    {
        public static FormTraCuuChuyenBay instance;
        public string maChuyenBay;
        public string sanBayDi;
        public string sanBayDen;
        public string ngayKhoiHanh;
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
                
            
        }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            maChuyenBay = tb_maChuyenBay.Text;
            sanBayDi = cb_sanBayDi.Text;
            sanBayDen = cb_sanBayDen.Text;
            ngayKhoiHanh = dp_ngayKhoiHanh.Text;
            using (var db = new FlightKetDBEntities())
            {
                var result = from chuyenbay in db.CHUYENBAYs
                             from sanbaydi in db.SANBAYs
                             from sanbayden in db.SANBAYs
                             where chuyenbay.MaChuyenBay.Equals(maChuyenBay) && sanbaydi.MaSanBay.Equals(chuyenbay.MaSanBayDi) 
                             && sanbayden.MaSanBay.Equals(chuyenbay.MaSanBayDen) 
                             select new { TenSanBayDi = sanbaydi.TenSanBay, TenSanBayDen = sanbayden.TenSanBay, NgayGioKhoiHanh = chuyenbay.NgayGioKhoiHanh
                             , ThoiGianBay = chuyenbay.ThoiGianBay };


                var resultList = result.ToList();

                if (resultList.Count > 0)
                {
                    lb_danhSachChuyenBayPhuHop.Visible = true;
                    dgv_chuyenBayPhuHop.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy danh sách phiếu đặt chỗ phù hợp");
                    lb_danhSachChuyenBayPhuHop.Visible = false;
                    dgv_chuyenBayPhuHop.Visible = false;
                    return;
                }

                dgv_chuyenBayPhuHop.RowCount = resultList.Count;
                for (int i = 0; i < resultList.Count; i++)
                {
                    dgv_chuyenBayPhuHop.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dgv_chuyenBayPhuHop.Rows[i].Cells[1].Value = resultList[i].TenSanBayDi;
                    dgv_chuyenBayPhuHop.Rows[i].Cells[2].Value = resultList[i].TenSanBayDen;
                    dgv_chuyenBayPhuHop.Rows[i].Cells[3].Value = resultList[i].NgayGioKhoiHanh.Value.Date.ToShortDateString();
                    dgv_chuyenBayPhuHop.Rows[i].Cells[4].Value = resultList[i].ThoiGianBay.ToString();
                }

            }
            
        }
    }
}
