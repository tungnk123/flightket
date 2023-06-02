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
    public partial class FormCapNhatThongTinPhieuDatCho : Form
    {
        public FormCapNhatThongTinPhieuDatCho()
        {
            InitializeComponent();
        }
        public FormCapNhatThongTinPhieuDatCho(int maPhieuDatCho, string maChuyenBay, string maHanhKhach, string maHangVe)
        {
            InitializeComponent();
            
            using(FlightKetDBEntities db = new FlightKetDBEntities())
            {
                PHIEUDATCHO pHIEUDATCHO = db.PHIEUDATCHOes.Find(maPhieuDatCho);
                HANHKHACH hANHKHACH = db.HANHKHACHes.Find(maHanhKhach);
                CHUYENBAY cHUYENBAY = db.CHUYENBAYs.Find(maChuyenBay);
                HANGVE hANGVE = db.HANGVEs.Find(maHangVe);

                tb_hoVaTen.Text = hANHKHACH.TenHanhKhach;
                tb_soDienThoai.Text = hANHKHACH.SDT;
                tb_CMND.Text = hANHKHACH.CMND;
                cb_gioiTinh.Text = hANHKHACH.GioiTinh;
                dateTimePicker1.Value = hANHKHACH.NgaySinh.Value;

                var querry = from cb in db.CHUYENBAYs
                             from hv in db.HANGVEs
                             from cthv in db.CT_HANGVE
                             where cb.MaChuyenBay.Equals(cthv.MaChuyenBay) && cthv.MaHangVe.Equals(hv.MaHangVe) && cb.MaChuyenBay.Equals(maChuyenBay)
                             select new { hv.TenHangVe };
                var list = querry.ToList();
                cb_hangVe.Items.Clear();
                foreach ( var item in list)
                {
                    cb_hangVe.Items.Add(item.TenHangVe);
                }
                cb_hangVe.Text = hANGVE.TenHangVe;
            }

        }
    }
}
