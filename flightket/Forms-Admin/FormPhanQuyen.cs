using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var roleResult = from role in db.ROLEs
                                 select role.RoleName;
                cmb_chonLoaiNguoiDung.DataSource = roleResult.ToList();

                            
            }
        }
    }
}
