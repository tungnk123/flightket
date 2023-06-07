namespace flightket.Forms_NhanVien
{
    partial class FormLapBaoCaoNam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapBaoCaoNam));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panelDanhSachPhieuDatCho = new System.Windows.Forms.Panel();
            this.lb_doanhThuBanVe = new System.Windows.Forms.Label();
            this.dgv_doanhThuChuyenBay = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.lb_sanBayDen = new System.Windows.Forms.Label();
            this.btn_xemBaoCao = new System.Windows.Forms.Button();
            this.lb_title2 = new System.Windows.Forms.Label();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.ColumnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_main.SuspendLayout();
            this.panelDanhSachPhieuDatCho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhThuChuyenBay)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_main.Controls.Add(this.panelDanhSachPhieuDatCho);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.btn_xemBaoCao);
            this.panel_main.Controls.Add(this.lb_title2);
            this.panel_main.Controls.Add(this.lb_title1);
            this.panel_main.Controls.Add(this.btn_back);
            this.panel_main.Controls.Add(this.btn_home);
            this.panel_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.Location = new System.Drawing.Point(101, 90);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1701, 852);
            this.panel_main.TabIndex = 7;
            // 
            // panelDanhSachPhieuDatCho
            // 
            this.panelDanhSachPhieuDatCho.BackColor = System.Drawing.Color.Transparent;
            this.panelDanhSachPhieuDatCho.Controls.Add(this.lb_doanhThuBanVe);
            this.panelDanhSachPhieuDatCho.Controls.Add(this.dgv_doanhThuChuyenBay);
            this.panelDanhSachPhieuDatCho.Location = new System.Drawing.Point(240, 376);
            this.panelDanhSachPhieuDatCho.Name = "panelDanhSachPhieuDatCho";
            this.panelDanhSachPhieuDatCho.Size = new System.Drawing.Size(1373, 383);
            this.panelDanhSachPhieuDatCho.TabIndex = 14;
            // 
            // lb_doanhThuBanVe
            // 
            this.lb_doanhThuBanVe.AutoSize = true;
            this.lb_doanhThuBanVe.BackColor = System.Drawing.Color.Transparent;
            this.lb_doanhThuBanVe.Location = new System.Drawing.Point(489, 14);
            this.lb_doanhThuBanVe.Name = "lb_doanhThuBanVe";
            this.lb_doanhThuBanVe.Size = new System.Drawing.Size(280, 26);
            this.lb_doanhThuBanVe.TabIndex = 9;
            this.lb_doanhThuBanVe.Text = "Doanh thu bán vé năm ...";
            // 
            // dgv_doanhThuChuyenBay
            // 
            this.dgv_doanhThuChuyenBay.AllowUserToOrderColumns = true;
            this.dgv_doanhThuChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhThuChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSTT,
            this.ColumnMaChuyenBay,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_doanhThuChuyenBay.Location = new System.Drawing.Point(121, 61);
            this.dgv_doanhThuChuyenBay.Name = "dgv_doanhThuChuyenBay";
            this.dgv_doanhThuChuyenBay.ReadOnly = true;
            this.dgv_doanhThuChuyenBay.RowHeadersWidth = 51;
            this.dgv_doanhThuChuyenBay.RowTemplate.Height = 24;
            this.dgv_doanhThuChuyenBay.Size = new System.Drawing.Size(1177, 228);
            this.dgv_doanhThuChuyenBay.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cb_nam);
            this.panel2.Controls.Add(this.lb_sanBayDen);
            this.panel2.Location = new System.Drawing.Point(607, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 100);
            this.panel2.TabIndex = 14;
            // 
            // cb_nam
            // 
            this.cb_nam.BackColor = System.Drawing.Color.Silver;
            this.cb_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.cb_nam.Location = new System.Drawing.Point(31, 58);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(132, 37);
            this.cb_nam.TabIndex = 1;
            // 
            // lb_sanBayDen
            // 
            this.lb_sanBayDen.AutoSize = true;
            this.lb_sanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sanBayDen.Location = new System.Drawing.Point(26, 16);
            this.lb_sanBayDen.Name = "lb_sanBayDen";
            this.lb_sanBayDen.Size = new System.Drawing.Size(64, 29);
            this.lb_sanBayDen.TabIndex = 0;
            this.lb_sanBayDen.Text = "Năm";
            // 
            // btn_xemBaoCao
            // 
            this.btn_xemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_xemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemBaoCao.Location = new System.Drawing.Point(967, 214);
            this.btn_xemBaoCao.Name = "btn_xemBaoCao";
            this.btn_xemBaoCao.Size = new System.Drawing.Size(267, 62);
            this.btn_xemBaoCao.TabIndex = 15;
            this.btn_xemBaoCao.Text = "Xem báo cáo";
            this.btn_xemBaoCao.UseVisualStyleBackColor = false;
            // 
            // lb_title2
            // 
            this.lb_title2.AutoSize = true;
            this.lb_title2.BackColor = System.Drawing.Color.Transparent;
            this.lb_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title2.Location = new System.Drawing.Point(654, 102);
            this.lb_title2.Name = "lb_title2";
            this.lb_title2.Size = new System.Drawing.Size(460, 38);
            this.lb_title2.TabIndex = 3;
            this.lb_title2.Text = "Báo cáo doanh thu theo năm";
            // 
            // lb_title1
            // 
            this.lb_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title1.AutoSize = true;
            this.lb_title1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Location = new System.Drawing.Point(709, 4);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(367, 69);
            this.lb_title1.TabIndex = 2;
            this.lb_title1.Text = "Lập báo cáo";
            // 
            // btn_back
            // 
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 70);
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(79, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(70, 70);
            this.btn_home.TabIndex = 1;
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // ColumnSTT
            // 
            this.ColumnSTT.HeaderText = "STT";
            this.ColumnSTT.MinimumWidth = 6;
            this.ColumnSTT.Name = "ColumnSTT";
            this.ColumnSTT.ReadOnly = true;
            this.ColumnSTT.Width = 70;
            // 
            // ColumnMaChuyenBay
            // 
            this.ColumnMaChuyenBay.HeaderText = "Tháng";
            this.ColumnMaChuyenBay.MinimumWidth = 6;
            this.ColumnMaChuyenBay.Name = "ColumnMaChuyenBay";
            this.ColumnMaChuyenBay.ReadOnly = true;
            this.ColumnMaChuyenBay.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số chuyến bay";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Doanh thu ( Đồng )";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 210;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tỉ lệ ( % )";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // FormLapBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350361348_206044632301251_2266599988871672436_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel_main);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLapBaoCaoNam";
            this.Text = "FlightKet - Lập báo cáo năm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panelDanhSachPhieuDatCho.ResumeLayout(false);
            this.panelDanhSachPhieuDatCho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhThuChuyenBay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panelDanhSachPhieuDatCho;
        private System.Windows.Forms.Label lb_doanhThuBanVe;
        private System.Windows.Forms.DataGridView dgv_doanhThuChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.Label lb_sanBayDen;
        private System.Windows.Forms.Button btn_xemBaoCao;
        private System.Windows.Forms.Label lb_title2;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
    }
}