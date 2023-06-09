namespace flightket.Forms_Admin
{
    partial class FormQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyTaiKhoan));
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_themNhanVien = new System.Windows.Forms.Button();
            this.dgv_danhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_danhSachTaiKhoan = new System.Windows.Forms.Label();
            this.cb_loaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.lb_title2 = new System.Windows.Forms.Label();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_main.Controls.Add(this.btn_themNhanVien);
            this.panel_main.Controls.Add(this.dgv_danhSachTaiKhoan);
            this.panel_main.Controls.Add(this.lb_danhSachTaiKhoan);
            this.panel_main.Controls.Add(this.cb_loaiTaiKhoan);
            this.panel_main.Controls.Add(this.lb_title2);
            this.panel_main.Controls.Add(this.lb_title1);
            this.panel_main.Controls.Add(this.btn_back);
            this.panel_main.Controls.Add(this.btn_home);
            this.panel_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.Location = new System.Drawing.Point(60, 119);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1760, 840);
            this.panel_main.TabIndex = 4;
            // 
            // btn_themNhanVien
            // 
            this.btn_themNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_themNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themNhanVien.Location = new System.Drawing.Point(847, 723);
            this.btn_themNhanVien.Name = "btn_themNhanVien";
            this.btn_themNhanVien.Size = new System.Drawing.Size(267, 62);
            this.btn_themNhanVien.TabIndex = 14;
            this.btn_themNhanVien.Text = "Thêm nhân viên";
            this.btn_themNhanVien.UseVisualStyleBackColor = false;
            this.btn_themNhanVien.Click += new System.EventHandler(this.btn_themNhanVien_Click);
            // 
            // dgv_danhSachTaiKhoan
            // 
            this.dgv_danhSachTaiKhoan.AllowUserToOrderColumns = true;
            this.dgv_danhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhSachTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_danhSachTaiKhoan.Location = new System.Drawing.Point(175, 361);
            this.dgv_danhSachTaiKhoan.Name = "dgv_danhSachTaiKhoan";
            this.dgv_danhSachTaiKhoan.ReadOnly = true;
            this.dgv_danhSachTaiKhoan.RowHeadersWidth = 51;
            this.dgv_danhSachTaiKhoan.RowTemplate.Height = 24;
            this.dgv_danhSachTaiKhoan.Size = new System.Drawing.Size(1536, 335);
            this.dgv_danhSachTaiKhoan.TabIndex = 13;
            this.dgv_danhSachTaiKhoan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhSachTaiKhoan_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Họ tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên đăng nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mật khẩu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // lb_danhSachTaiKhoan
            // 
            this.lb_danhSachTaiKhoan.AutoSize = true;
            this.lb_danhSachTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lb_danhSachTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_danhSachTaiKhoan.Location = new System.Drawing.Point(662, 254);
            this.lb_danhSachTaiKhoan.Name = "lb_danhSachTaiKhoan";
            this.lb_danhSachTaiKhoan.Size = new System.Drawing.Size(589, 38);
            this.lb_danhSachTaiKhoan.TabIndex = 12;
            this.lb_danhSachTaiKhoan.Text = "Danh sách tài khoản nhân viên sân bay";
            // 
            // cb_loaiTaiKhoan
            // 
            this.cb_loaiTaiKhoan.BackColor = System.Drawing.Color.Silver;
            this.cb_loaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loaiTaiKhoan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_loaiTaiKhoan.FormattingEnabled = true;
            this.cb_loaiTaiKhoan.Items.AddRange(new object[] {
            "Nhân viên sân bay",
            "Quản lý"});
            this.cb_loaiTaiKhoan.Location = new System.Drawing.Point(945, 102);
            this.cb_loaiTaiKhoan.Name = "cb_loaiTaiKhoan";
            this.cb_loaiTaiKhoan.Size = new System.Drawing.Size(236, 37);
            this.cb_loaiTaiKhoan.TabIndex = 11;
            this.cb_loaiTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cb_loaiTaiKhoan_SelectedIndexChanged);
            // 
            // lb_title2
            // 
            this.lb_title2.AutoSize = true;
            this.lb_title2.BackColor = System.Drawing.Color.Transparent;
            this.lb_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title2.Location = new System.Drawing.Point(681, 102);
            this.lb_title2.Name = "lb_title2";
            this.lb_title2.Size = new System.Drawing.Size(219, 38);
            this.lb_title2.TabIndex = 3;
            this.lb_title2.Text = "Loại tài khoản";
            // 
            // lb_title1
            // 
            this.lb_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title1.AutoSize = true;
            this.lb_title1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Location = new System.Drawing.Point(672, 4);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(509, 69);
            this.lb_title1.TabIndex = 2;
            this.lb_title1.Text = "Quản lý tài khoản";
            // 
            // btn_back
            // 
            this.btn_back.Image = global::flightket.Properties.Resources.icons8_back_64;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 70);
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.Image = global::flightket.Properties.Resources.icons8_home_50;
            this.btn_home.Location = new System.Drawing.Point(79, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(70, 70);
            this.btn_home.TabIndex = 1;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // FormQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350361348_206044632301251_2266599988871672436_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel_main);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLyTaiKhoan";
            this.Text = "FormQuanLyTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_themNhanVien;
        private System.Windows.Forms.DataGridView dgv_danhSachTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lb_danhSachTaiKhoan;
        private System.Windows.Forms.ComboBox cb_loaiTaiKhoan;
        private System.Windows.Forms.Label lb_title2;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
    }
}