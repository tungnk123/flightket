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
    public partial class FormLapBaoCao : Form
    {
        public FormLapBaoCao()
        {
            InitializeComponent();
        }

        private void btn_baoCaoThang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLapBaoCaoThang formLapBaoCaoThang = new FormLapBaoCaoThang(this);
            formLapBaoCaoThang.ShowDialog();
            if(formLapBaoCaoThang.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
