using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace flightket.Forms_Admin
{
    public partial class FormPhanQuyen : Form
    {
        public static FormPhanQuyen instance;
        public FormPhanQuyen()
        {
            instance = this;
            InitializeComponent();

        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                var result = from role in db.ROLEs
                             select role.RoleName;
                var resultList = result.ToList();
                List<string> roleNameList = new List<string>();
                foreach (string item in resultList)
                {
                    if (item.Equals("Qu?n lý"))
                    {
                        roleNameList.Add("Quản lý");
                    }
                    else
                    {
                        roleNameList.Add(item);
                    }
                }
                cmb_loaiTaiKhoan.DataSource = roleNameList;
            }
        }

        private void cmb_loaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                var result = from role in db.ROLEs
                             select role;


                if (cmb_loaiTaiKhoan.SelectedIndex == 0)
                {
                    result = result.Where(c => c.RoleID.Equals("NVSB1"));
                }
                else if (cmb_loaiTaiKhoan.SelectedIndex == 1)
                {
                    result = result.Where(c => c.RoleID.Equals("QULY1"));
                }

                var resultList = result.ToList();
                var itemResult = resultList.First();

                cb_nhapLichChuyenBay.Checked = (bool)itemResult.CanNhapLichChuyenBay;
                cb_banVe.Checked = (bool)itemResult.CanBanVe;
                cb_ghiNhanDatVe.Checked = (bool)itemResult.CanGhiNhanDatVe;
                cb_traCuuChuyenBay.Checked = (bool)itemResult.CanTraCuuChuyenBay;
                cb_lapBaoCao.Checked = (bool)itemResult.CanLapBaoCao;
                cb_thayDoiQuiDinh.Checked = (bool)itemResult.CanThayDoiQuyDinh;

            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                ROLE role = new ROLE();
                if (cmb_loaiTaiKhoan.SelectedIndex == 0)
                {
                    role = db.ROLEs.Find("NVSB1");
                }
                else if (cmb_loaiTaiKhoan.SelectedIndex == 1)
                {
                    role = db.ROLEs.Find("QULY1");
                }

                role.CanNhapLichChuyenBay = cb_nhapLichChuyenBay.Checked;
                role.CanBanVe = cb_banVe.Checked;
                role.CanGhiNhanDatVe = cb_ghiNhanDatVe.Checked;
                role.CanLapBaoCao = cb_lapBaoCao.Checked;
                role.CanTraCuuChuyenBay = cb_traCuuChuyenBay.Checked;
                role.CanThayDoiQuyDinh = cb_thayDoiQuiDinh.Checked;

                db.SaveChanges();
                MessageBox.Show("Cập nhập quyền thành công!");

            }
        }

        private void FormPhanQuyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
            formHomeAdmin.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
            formHomeAdmin.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
            formHomeAdmin.Show();
        }

        
    }
}
