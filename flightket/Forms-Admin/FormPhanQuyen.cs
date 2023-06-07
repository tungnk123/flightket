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
        public FormPhanQuyen()
        {
            InitializeComponent();
        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            using (var db = new FlightKetDBEntities())
            {
                //var result = from nhanvien in db.NHANVIENs;
            }
        }
    }
}
