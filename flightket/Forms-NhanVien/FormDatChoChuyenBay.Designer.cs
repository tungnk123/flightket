
namespace flightket.Forms_NhanVien
{
    partial class FormDatChoChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatChoChuyenBay));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panelDanhSachPhieuDatCho = new System.Windows.Forms.Panel();
            this.lb_danhSachChuyenBayPhuHop = new System.Windows.Forms.Label();
            this.dgv_chuyenBayPhuHop = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_hangVe = new System.Windows.Forms.ComboBox();
            this.lb_chonHangVe = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dp_ngayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.lb_ngayKhoiHanh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_sanBayDen = new System.Windows.Forms.ComboBox();
            this.lb_sanBayDen = new System.Windows.Forms.Label();
            this.btn_timChuyenBay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_sanBayDi = new System.Windows.Forms.ComboBox();
            this.lb_sanBayDi = new System.Windows.Forms.Label();
            this.lb_title2 = new System.Windows.Forms.Label();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.ColumnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGioKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_main.SuspendLayout();
            this.panelDanhSachPhieuDatCho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenBayPhuHop)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_main.Controls.Add(this.panelDanhSachPhieuDatCho);
            this.panel_main.Controls.Add(this.panel4);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.btn_timChuyenBay);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.lb_title2);
            this.panel_main.Controls.Add(this.lb_title1);
            this.panel_main.Controls.Add(this.btn_back);
            this.panel_main.Controls.Add(this.btn_home);
            this.panel_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.Location = new System.Drawing.Point(98, 133);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1701, 852);
            this.panel_main.TabIndex = 6;
            // 
            // panelDanhSachPhieuDatCho
            // 
            this.panelDanhSachPhieuDatCho.BackColor = System.Drawing.Color.Transparent;
            this.panelDanhSachPhieuDatCho.Controls.Add(this.lb_danhSachChuyenBayPhuHop);
            this.panelDanhSachPhieuDatCho.Controls.Add(this.dgv_chuyenBayPhuHop);
            this.panelDanhSachPhieuDatCho.Location = new System.Drawing.Point(234, 485);
            this.panelDanhSachPhieuDatCho.Name = "panelDanhSachPhieuDatCho";
            this.panelDanhSachPhieuDatCho.Size = new System.Drawing.Size(1389, 224);
            this.panelDanhSachPhieuDatCho.TabIndex = 14;
            // 
            // lb_danhSachChuyenBayPhuHop
            // 
            this.lb_danhSachChuyenBayPhuHop.AutoSize = true;
            this.lb_danhSachChuyenBayPhuHop.BackColor = System.Drawing.Color.Transparent;
            this.lb_danhSachChuyenBayPhuHop.Location = new System.Drawing.Point(535, 15);
            this.lb_danhSachChuyenBayPhuHop.Name = "lb_danhSachChuyenBayPhuHop";
            this.lb_danhSachChuyenBayPhuHop.Size = new System.Drawing.Size(345, 26);
            this.lb_danhSachChuyenBayPhuHop.TabIndex = 9;
            this.lb_danhSachChuyenBayPhuHop.Text = "Danh sách chuyến bay phù hợp";
            // 
            // dgv_chuyenBayPhuHop
            // 
            this.dgv_chuyenBayPhuHop.AllowUserToOrderColumns = true;
            this.dgv_chuyenBayPhuHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chuyenBayPhuHop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSTT,
            this.ColumnMaChuyenBay,
            this.columnGioKhoiHanh,
            this.ColumnSoGheTrong,
            this.ColumnGiaVe,
            this.ColumnChon});
            this.dgv_chuyenBayPhuHop.Location = new System.Drawing.Point(80, 44);
            this.dgv_chuyenBayPhuHop.Name = "dgv_chuyenBayPhuHop";
            this.dgv_chuyenBayPhuHop.ReadOnly = true;
            this.dgv_chuyenBayPhuHop.RowHeadersWidth = 51;
            this.dgv_chuyenBayPhuHop.RowTemplate.Height = 24;
            this.dgv_chuyenBayPhuHop.Size = new System.Drawing.Size(1183, 165);
            this.dgv_chuyenBayPhuHop.TabIndex = 6;
            this.dgv_chuyenBayPhuHop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chuyenBayPhuHop_CellDoubleClick_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.cb_hangVe);
            this.panel4.Controls.Add(this.lb_chonHangVe);
            this.panel4.Location = new System.Drawing.Point(1311, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 100);
            this.panel4.TabIndex = 12;
            // 
            // cb_hangVe
            // 
            this.cb_hangVe.BackColor = System.Drawing.Color.Silver;
            this.cb_hangVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hangVe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_hangVe.FormattingEnabled = true;
            this.cb_hangVe.Location = new System.Drawing.Point(31, 58);
            this.cb_hangVe.Name = "cb_hangVe";
            this.cb_hangVe.Size = new System.Drawing.Size(210, 37);
            this.cb_hangVe.TabIndex = 1;
            // 
            // lb_chonHangVe
            // 
            this.lb_chonHangVe.AutoSize = true;
            this.lb_chonHangVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chonHangVe.Location = new System.Drawing.Point(26, 11);
            this.lb_chonHangVe.Name = "lb_chonHangVe";
            this.lb_chonHangVe.Size = new System.Drawing.Size(160, 29);
            this.lb_chonHangVe.TabIndex = 0;
            this.lb_chonHangVe.Text = "Chọn hạng vé";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dp_ngayKhoiHanh);
            this.panel3.Controls.Add(this.lb_ngayKhoiHanh);
            this.panel3.Location = new System.Drawing.Point(934, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 100);
            this.panel3.TabIndex = 13;
            // 
            // dp_ngayKhoiHanh
            // 
            this.dp_ngayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_ngayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_ngayKhoiHanh.Location = new System.Drawing.Point(31, 58);
            this.dp_ngayKhoiHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_ngayKhoiHanh.Name = "dp_ngayKhoiHanh";
            this.dp_ngayKhoiHanh.Size = new System.Drawing.Size(210, 34);
            this.dp_ngayKhoiHanh.TabIndex = 1;
            this.dp_ngayKhoiHanh.Value = new System.DateTime(2023, 6, 7, 15, 54, 52, 0);
            // 
            // lb_ngayKhoiHanh
            // 
            this.lb_ngayKhoiHanh.AutoSize = true;
            this.lb_ngayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayKhoiHanh.Location = new System.Drawing.Point(26, 16);
            this.lb_ngayKhoiHanh.Name = "lb_ngayKhoiHanh";
            this.lb_ngayKhoiHanh.Size = new System.Drawing.Size(178, 29);
            this.lb_ngayKhoiHanh.TabIndex = 0;
            this.lb_ngayKhoiHanh.Text = "Ngày khởi hành";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cb_sanBayDen);
            this.panel2.Controls.Add(this.lb_sanBayDen);
            this.panel2.Location = new System.Drawing.Point(587, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 100);
            this.panel2.TabIndex = 14;
            // 
            // cb_sanBayDen
            // 
            this.cb_sanBayDen.BackColor = System.Drawing.Color.Silver;
            this.cb_sanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sanBayDen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_sanBayDen.FormattingEnabled = true;
            this.cb_sanBayDen.Location = new System.Drawing.Point(31, 58);
            this.cb_sanBayDen.Name = "cb_sanBayDen";
            this.cb_sanBayDen.Size = new System.Drawing.Size(224, 37);
            this.cb_sanBayDen.TabIndex = 1;
            // 
            // lb_sanBayDen
            // 
            this.lb_sanBayDen.AutoSize = true;
            this.lb_sanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sanBayDen.Location = new System.Drawing.Point(26, 16);
            this.lb_sanBayDen.Name = "lb_sanBayDen";
            this.lb_sanBayDen.Size = new System.Drawing.Size(146, 29);
            this.lb_sanBayDen.TabIndex = 0;
            this.lb_sanBayDen.Text = "Sân bay đến";
            // 
            // btn_timChuyenBay
            // 
            this.btn_timChuyenBay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_timChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timChuyenBay.Location = new System.Drawing.Point(809, 392);
            this.btn_timChuyenBay.Name = "btn_timChuyenBay";
            this.btn_timChuyenBay.Size = new System.Drawing.Size(267, 62);
            this.btn_timChuyenBay.TabIndex = 15;
            this.btn_timChuyenBay.Text = "Tìm chuyến bay";
            this.btn_timChuyenBay.UseVisualStyleBackColor = false;
            this.btn_timChuyenBay.Click += new System.EventHandler(this.btn_timChuyenBay_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cb_sanBayDi);
            this.panel1.Controls.Add(this.lb_sanBayDi);
            this.panel1.Location = new System.Drawing.Point(262, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 100);
            this.panel1.TabIndex = 11;
            // 
            // cb_sanBayDi
            // 
            this.cb_sanBayDi.BackColor = System.Drawing.Color.Silver;
            this.cb_sanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sanBayDi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_sanBayDi.FormattingEnabled = true;
            this.cb_sanBayDi.Location = new System.Drawing.Point(31, 58);
            this.cb_sanBayDi.Name = "cb_sanBayDi";
            this.cb_sanBayDi.Size = new System.Drawing.Size(217, 37);
            this.cb_sanBayDi.TabIndex = 1;
            // 
            // lb_sanBayDi
            // 
            this.lb_sanBayDi.AutoSize = true;
            this.lb_sanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sanBayDi.Location = new System.Drawing.Point(26, 16);
            this.lb_sanBayDi.Name = "lb_sanBayDi";
            this.lb_sanBayDi.Size = new System.Drawing.Size(125, 29);
            this.lb_sanBayDi.TabIndex = 0;
            this.lb_sanBayDi.Text = "Sân bay đi";
            // 
            // lb_title2
            // 
            this.lb_title2.AutoSize = true;
            this.lb_title2.BackColor = System.Drawing.Color.Transparent;
            this.lb_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title2.Location = new System.Drawing.Point(623, 102);
            this.lb_title2.Name = "lb_title2";
            this.lb_title2.Size = new System.Drawing.Size(585, 38);
            this.lb_title2.TabIndex = 3;
            this.lb_title2.Text = "Nhập thông tin chuyến bay mong muốn";
            // 
            // lb_title1
            // 
            this.lb_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title1.AutoSize = true;
            this.lb_title1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Location = new System.Drawing.Point(640, 4);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(573, 69);
            this.lb_title1.TabIndex = 2;
            this.lb_title1.Text = "Đặt chỗ chuyến bay";
            // 
            // btn_back
            // 
            this.btn_back.Image = global::flightket.Properties.Resources.icon_back_final;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 70);
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.Image = global::flightket.Properties.Resources.icon_home_final;
            this.btn_home.Location = new System.Drawing.Point(79, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(70, 70);
            this.btn_home.TabIndex = 1;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
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
            this.ColumnMaChuyenBay.HeaderText = "Mã Chuyến Bay";
            this.ColumnMaChuyenBay.MinimumWidth = 6;
            this.ColumnMaChuyenBay.Name = "ColumnMaChuyenBay";
            this.ColumnMaChuyenBay.ReadOnly = true;
            this.ColumnMaChuyenBay.Width = 300;
            // 
            // columnGioKhoiHanh
            // 
            this.columnGioKhoiHanh.HeaderText = "Giờ khởi hành";
            this.columnGioKhoiHanh.MinimumWidth = 6;
            this.columnGioKhoiHanh.Name = "columnGioKhoiHanh";
            this.columnGioKhoiHanh.ReadOnly = true;
            this.columnGioKhoiHanh.Width = 250;
            // 
            // ColumnSoGheTrong
            // 
            this.ColumnSoGheTrong.HeaderText = "Số ghế trống";
            this.ColumnSoGheTrong.MinimumWidth = 6;
            this.ColumnSoGheTrong.Name = "ColumnSoGheTrong";
            this.ColumnSoGheTrong.ReadOnly = true;
            this.ColumnSoGheTrong.Width = 200;
            // 
            // ColumnGiaVe
            // 
            this.ColumnGiaVe.HeaderText = "Giá vé";
            this.ColumnGiaVe.MinimumWidth = 6;
            this.ColumnGiaVe.Name = "ColumnGiaVe";
            this.ColumnGiaVe.ReadOnly = true;
            this.ColumnGiaVe.Width = 200;
            // 
            // ColumnChon
            // 
            this.ColumnChon.HeaderText = "";
            this.ColumnChon.MinimumWidth = 6;
            this.ColumnChon.Name = "ColumnChon";
            this.ColumnChon.ReadOnly = true;
            this.ColumnChon.Width = 110;
            // 
            // FormDatChoChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350361348_206044632301251_2266599988871672436_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel_main);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatChoChuyenBay";
            this.Text = "Flightket - Đặt chỗ chuyến bay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panelDanhSachPhieuDatCho.ResumeLayout(false);
            this.panelDanhSachPhieuDatCho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenBayPhuHop)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panelDanhSachPhieuDatCho;
        private System.Windows.Forms.Label lb_danhSachChuyenBayPhuHop;
        private System.Windows.Forms.DataGridView dgv_chuyenBayPhuHop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_hangVe;
        private System.Windows.Forms.Label lb_chonHangVe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dp_ngayKhoiHanh;
        private System.Windows.Forms.Label lb_ngayKhoiHanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_sanBayDen;
        private System.Windows.Forms.Label lb_sanBayDen;
        private System.Windows.Forms.Button btn_timChuyenBay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_sanBayDi;
        private System.Windows.Forms.Label lb_sanBayDi;
        private System.Windows.Forms.Label lb_title2;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGioKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoGheTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChon;
    }
}