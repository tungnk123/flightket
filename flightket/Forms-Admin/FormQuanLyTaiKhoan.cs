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
    public partial class FormQuanLyTaiKhoan : Form
    {
        public static FormQuanLyTaiKhoan instance;
        public FormQuanLyTaiKhoan()
        {
            instance = this;
            InitializeComponent();
        }
    }
}
