using System;
using System.Windows.Forms;

namespace flightket.Forms_Admin
{
    public partial class FormTaoNhomNguoiDung : Form
    {
        Random random = new Random();
        public FormTaoNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void btn_timChuyenBay_Click(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                ROLE rOLE = new ROLE();
                int number = random.Next(100, 999);
                rOLE.RoleID = "NV" + number.ToString();
                rOLE.RoleName = tb_nameGroupUser.Text;
                rOLE.Description = tb_description.Text;
                rOLE.CanNhapLichChuyenBay = cb_nhapLichChuyenBay.Checked;
                rOLE.CanBanVe = cb_banVe.Checked;
                rOLE.CanGhiNhanDatVe = cb_ghiNhanDatVe.Checked;
                rOLE.CanLapBaoCao = cb_lapBaoCao.Checked;
                rOLE.CanTraCuuChuyenBay = cb_traCuuChuyenBay.Checked;
                rOLE.CanThayDoiQuyDinh = cb_thayDoiQuiDinh.Checked;

                db.ROLEs.Add(rOLE);
                db.SaveChanges();
                MessageBox.Show("Thêm mới Role thành công!");
            }
        }
    }
}
