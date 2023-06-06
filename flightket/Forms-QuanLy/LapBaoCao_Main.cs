using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_QuanLy
{
    public partial class LapBaoCao_Main : Form
    {
        FlightKetDBEntities db = new FlightKetDBEntities();
        public Form PreviousForm { get; set; }
        public LapBaoCao_Main()
        {
            InitializeComponent();
            capNhatDB();
        }

        private void capNhatDB()
        {
            List<CT_BCTHANG> listCTBCThang = new List<CT_BCTHANG>();
            List<BAOCAOTHANG> listBAOCAOTHANG = new List<BAOCAOTHANG>();
            List<BAOCAONAM> listBAOCAONAM = new List<BAOCAONAM>();

            var tongDoanhThuBaoCaoNam = (from cb in db.CHUYENBAYs
                        join cthv in db.CT_HANGVE on cb.MaChuyenBay equals cthv.MaChuyenBay
                        join hv in db.HANGVEs on cthv.MaHangVe equals hv.MaHangVe
                        group new { cb, cthv, hv } by new { Year = DbFunctions.DiffYears(DateTime.MinValue, cb.NgayGioKhoiHanh), cb.NgayGioKhoiHanh } into g
                        orderby g.Key.Year
                        select new
                        {
                            Year = g.Key.Year,
                            g.Key.NgayGioKhoiHanh,
                            TotalTongDoangThuChuyenBay = g.Sum(rt => (rt.hv.TiLeDonGia * rt.cthv.SoLuongGhe))
                        }).ToList();

            var query = from cb in db.CHUYENBAYs
                        join cthv in db.CT_HANGVE on cb.MaChuyenBay equals cthv.MaChuyenBay
                        join hv in db.HANGVEs on cthv.MaHangVe equals hv.MaHangVe
                        group new { cb, cthv, hv } by new { Year = DbFunctions.DiffYears(DateTime.MinValue, cb.NgayGioKhoiHanh) } into g
                        orderby g.Key.Year
                        select new
                        {
                            Year = g.Key.Year,
                            TotalTongDoangThuChuyenBay = g.Sum(rt => (rt.hv.TiLeDonGia * rt.cthv.SoLuongGhe))
                        };

            var result = from r in query
                         group r by new { r.Year } into g
                         select new
                         {
                             Year = g.Key.Year,
                             ToanBoDoanhThu = g.Sum(r => r.TotalTongDoangThuChuyenBay)
                         };

            foreach (var item in result)
            {
                //MessageBox.Show($"{item.Year} - {item.ToanBoDoanhThu}");
     
                string mabcNam = $"N{item.Year + 1}";
                BAOCAONAM itemBCNAM = new BAOCAONAM()
                {
                    MaBCNam = mabcNam,
                    Nam = Convert.ToInt16(item.Year + 1),
                    TongDoanhThu = item.ToanBoDoanhThu
                };
                //MessageBox.Show(itemBCNAM.MaBCNam + " - " + itemBCNAM.Nam + " - " + itemBCNAM.TongDoanhThu + " - " + item.Year);

                if (!db.BAOCAONAMs.Any(x => x.MaBCNam == mabcNam))
                {
                    listBAOCAONAM.Add(itemBCNAM);
                    try
                    {
                        db.BAOCAONAMs.AddRange(listBAOCAONAM);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            
            

            var varTONGDOANHTHUTOANBOCHUYENBAY = (from cb in db.CHUYENBAYs
                                                  join cthv in db.CT_HANGVE on cb.MaChuyenBay equals cthv.MaChuyenBay
                                                  join hv in db.HANGVEs on cthv.MaHangVe equals hv.MaHangVe
                                                  group new { cb, hv, cthv } by new { cb.MaChuyenBay, cb.NgayGioKhoiHanh } into g
                                                  select new
                                                  {
                                                      g.Key.MaChuyenBay,
                                                      g.Key.NgayGioKhoiHanh,
                                                      TONGDOANGTHUCHUYENABY = (from rt in g
                                                                               group rt.cthv.SoLuongGhe * rt.hv.TiLeDonGia by rt.cb.MaChuyenBay into rtg
                                                                               select rtg.Sum()).Sum()
                                                  }).Sum(r => r.TONGDOANGTHUCHUYENABY);


            var DSBaoCaoThang = (from cb in db.CHUYENBAYs
                                 join ct in db.CT_HANGVE on cb.MaChuyenBay equals ct.MaChuyenBay
                                 join hv in db.HANGVEs on ct.MaHangVe equals hv.MaHangVe
                                 group new { cb, ct, hv } by new { Year = DbFunctions.DiffYears(DateTime.MinValue, cb.NgayGioKhoiHanh), Month = DbFunctions.DiffMonths(DateTime.MinValue, cb.NgayGioKhoiHanh), cb.NgayGioKhoiHanh } into g
                                 select new
                                 {
                                     g.Key.Year,
                                     g.Key.Month,
                                     g.Key.NgayGioKhoiHanh,
                                     TongSoLuongGhe = g.Sum(x => x.ct.SoLuongGhe),
                                     TotalTONGDOANGTHUCHUYENABY = g.Sum(x => x.hv.TiLeDonGia * x.ct.SoLuongGhe)
                                 }).ToList();



            //DSBaoCaoThang = DSBaoCaoThang.OrderBy(x => x.Year).ThenBy(x => x.Month);
            int rowCountBCThang = DSBaoCaoThang.Count();
            for (int i = 0; i < rowCountBCThang; i++)
            {
                int year = Convert.ToInt16(DSBaoCaoThang[i].Year);
                int month = Convert.ToInt16(DSBaoCaoThang[i].Month);
                
                DateTime date = (DateTime)DSBaoCaoThang[i].NgayGioKhoiHanh;
                //MessageBox.Show(date.ToString());
                string mabcThang = $"T{date.Month}2{Convert.ToString(date.Year).Substring(date.Year.ToString().Length - 2)}";
                // Perform further operations with the variables
                string mabcNam = $"N{date.Year}";
                //MessageBox.Show(mabcNam);

                BAOCAOTHANG itemBCThang = new BAOCAOTHANG()
                {
                    MaBCThang = mabcThang,
                    MaBCNam = mabcNam,
                    Thang = Convert.ToInt16(date.Month),
                    Nam = Convert.ToInt16(date.Year),
                    TongDoanhThuThang = DSBaoCaoThang[i].TotalTONGDOANGTHUCHUYENABY,
                    TongChuyenBay = Convert.ToInt16(DSBaoCaoThang[i].TongSoLuongGhe),
                    TiLe = (double)Math.Round((double)((double)DSBaoCaoThang[i].TotalTONGDOANGTHUCHUYENABY / varTONGDOANHTHUTOANBOCHUYENBAY * 100), 1)
                };

                if(!db.BAOCAOTHANGs.Any(x => x.MaBCThang == itemBCThang.MaBCThang))
                {
                    listBAOCAOTHANG.Add(itemBCThang);
                    try
                    {
                        db.BAOCAOTHANGs.Add(itemBCThang);
                        db.SaveChanges();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            db.BAOCAOTHANGs.AddRange(listBAOCAOTHANG);
            //db.SaveChanges();



            var DSCTBCThang = (from cb in db.CHUYENBAYs
                        join cthv in db.CT_HANGVE on cb.MaChuyenBay equals cthv.MaChuyenBay
                        join hv in db.HANGVEs on cthv.MaHangVe equals hv.MaHangVe
                        group new { cb, cthv, hv } by new { cb.MaChuyenBay, cb.NgayGioKhoiHanh } into g
                        select new
                        {
                            MaChuyenBay = g.Key.MaChuyenBay,
                            NgayGioKhoiHanh = g.Key.NgayGioKhoiHanh,
                            TONGDOANGTHUCHUYENABY = g.Sum(rt => rt.hv.TiLeDonGia * rt.cthv.SoLuongGhe / 100),
                            TONGSOLUONGGHE = g.Sum(rt => rt.cthv.SoLuongGhe)
                        }).ToList();




            int rowCountCTBCThang = DSCTBCThang.Count();
            

            for (int i = 0; i < rowCountCTBCThang; i++)
            {
                DateTime date = (DateTime)DSCTBCThang[i].NgayGioKhoiHanh;
                string mabcThang = $"T{date.Month}2{Convert.ToString(date.Year).Substring(date.Year.ToString().Length - 2)}";
                // MessageBox.Show(mabcThang + "-" + result[i].MaChuyenBay);               

                CT_BCTHANG itemCTBCTHang = new CT_BCTHANG()
                {
                    MaBCThang = mabcThang,
                    MaChuyenBay = DSCTBCThang[i].MaChuyenBay,
                    SoVe = (short)DSCTBCThang[i].TONGSOLUONGGHE,
                    DoanhThu = (double)DSCTBCThang[i].TONGDOANGTHUCHUYENABY,
                    TiLe = null
                };
                /*MessageBox.Show(varTONGDOANHTHUTOANBOCHUYENBAY.ToString());
                MessageBox.Show(
                    itemCTBCTHang.MaBCThang + " - " +
                    itemCTBCTHang.MaChuyenBay + " - " +
                    itemCTBCTHang.SoVe + " - " +
                    itemCTBCTHang.DoanhThu + " - " +
                    itemCTBCTHang.TiLe);*/


                if(!db.CT_BCTHANG.Any(c => c.MaChuyenBay == itemCTBCTHang.MaChuyenBay))
                {
                    listCTBCThang.Add(itemCTBCTHang);
                    try
                    {
                        db.CT_BCTHANG.Add(itemCTBCTHang);
                        db.SaveChanges();
                        MessageBox.Show("Lam moi du lieu thanh cong");
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                                    
                }
            }
            db.CT_BCTHANG.AddRange(listCTBCThang);
            //db.SaveChanges();

            
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

        private void btn_baoCaoThang_Click(object sender, EventArgs e)
        {
            this.Hide();
            LapBaoCao_Thang lapBaoCao_Thang = new LapBaoCao_Thang();
            lapBaoCao_Thang.PreviousForm = this;
            lapBaoCao_Thang.Show();
        }

        private void btn_baoCaoNam_Click(object sender, EventArgs e)
        {
            this.Hide();
            LapBaoCao_Nam lapBaoCao_Nam = new LapBaoCao_Nam();
            lapBaoCao_Nam.PreviousForm = this;
            lapBaoCao_Nam.Show();
        }
    }
}
