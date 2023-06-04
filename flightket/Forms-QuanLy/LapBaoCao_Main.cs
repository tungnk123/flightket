using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightket.Forms_QuanLy
{
    public partial class LapBaoCao_Main : Form
    {
        public Form PreviousForm { get; set; }
        public LapBaoCao_Main()
        {
            InitializeComponent();
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
