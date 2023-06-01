
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_hangGhe = new System.Windows.Forms.ComboBox();
            this.lb_chonHangGhe = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dp_ngayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.lb_ngayKhoiHanh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_sanBayDen = new System.Windows.Forms.ComboBox();
            this.lb_sanBayDen = new System.Windows.Forms.Label();
            this.lv_chuyenBayPhuHop = new System.Windows.Forms.ListView();
            this.column_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_maChuyenbay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_gioKhoiHanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_soGheTrong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_giaVe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_buttonChon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_danhSachChuyenBayPhuHop = new System.Windows.Forms.Label();
            this.btn_timChuyenBay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_sanBayDi = new System.Windows.Forms.ComboBox();
            this.lb_sanBayDi = new System.Windows.Forms.Label();
            this.lb_title2 = new System.Windows.Forms.Label();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_main.Controls.Add(this.panel4);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.lv_chuyenBayPhuHop);
            this.panel_main.Controls.Add(this.lb_danhSachChuyenBayPhuHop);
            this.panel_main.Controls.Add(this.btn_timChuyenBay);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.lb_title2);
            this.panel_main.Controls.Add(this.lb_title1);
            this.panel_main.Controls.Add(this.btn_back);
            this.panel_main.Controls.Add(this.btn_home);
            this.panel_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.Location = new System.Drawing.Point(70, 138);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1760, 900);
            this.panel_main.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.cb_hangGhe);
            this.panel4.Controls.Add(this.lb_chonHangGhe);
            this.panel4.Location = new System.Drawing.Point(1315, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 100);
            this.panel4.TabIndex = 5;
            // 
            // cb_hangGhe
            // 
            this.cb_hangGhe.BackColor = System.Drawing.Color.Silver;
            this.cb_hangGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hangGhe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_hangGhe.FormattingEnabled = true;
            this.cb_hangGhe.Location = new System.Drawing.Point(31, 58);
            this.cb_hangGhe.Name = "cb_hangGhe";
            this.cb_hangGhe.Size = new System.Drawing.Size(176, 37);
            this.cb_hangGhe.TabIndex = 1;
            // 
            // lb_chonHangGhe
            // 
            this.lb_chonHangGhe.AutoSize = true;
            this.lb_chonHangGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chonHangGhe.Location = new System.Drawing.Point(26, 11);
            this.lb_chonHangGhe.Name = "lb_chonHangGhe";
            this.lb_chonHangGhe.Size = new System.Drawing.Size(176, 29);
            this.lb_chonHangGhe.TabIndex = 0;
            this.lb_chonHangGhe.Text = "Chọn hạng ghế";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dp_ngayKhoiHanh);
            this.panel3.Controls.Add(this.lb_ngayKhoiHanh);
            this.panel3.Location = new System.Drawing.Point(926, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 100);
            this.panel3.TabIndex = 5;
            // 
            // dp_ngayKhoiHanh
            // 
            this.dp_ngayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_ngayKhoiHanh.Location = new System.Drawing.Point(5, 66);
            this.dp_ngayKhoiHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_ngayKhoiHanh.Name = "dp_ngayKhoiHanh";
            this.dp_ngayKhoiHanh.Size = new System.Drawing.Size(310, 26);
            this.dp_ngayKhoiHanh.TabIndex = 1;
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
            this.panel2.Location = new System.Drawing.Point(584, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 100);
            this.panel2.TabIndex = 5;
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
            // lv_chuyenBayPhuHop
            // 
            this.lv_chuyenBayPhuHop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_stt,
            this.column_maChuyenbay,
            this.column_gioKhoiHanh,
            this.column_soGheTrong,
            this.column_giaVe,
            this.column_buttonChon});
            this.lv_chuyenBayPhuHop.HideSelection = false;
            this.lv_chuyenBayPhuHop.Location = new System.Drawing.Point(282, 584);
            this.lv_chuyenBayPhuHop.Name = "lv_chuyenBayPhuHop";
            this.lv_chuyenBayPhuHop.Size = new System.Drawing.Size(1334, 130);
            this.lv_chuyenBayPhuHop.TabIndex = 10;
            this.lv_chuyenBayPhuHop.UseCompatibleStateImageBehavior = false;
            this.lv_chuyenBayPhuHop.View = System.Windows.Forms.View.Details;
            // 
            // column_stt
            // 
            this.column_stt.Text = "STT";
            this.column_stt.Width = 78;
            // 
            // column_maChuyenbay
            // 
            this.column_maChuyenbay.Text = "Mã chuyến bay";
            this.column_maChuyenbay.Width = 209;
            // 
            // column_gioKhoiHanh
            // 
            this.column_gioKhoiHanh.Text = "Giờ khởi hành";
            this.column_gioKhoiHanh.Width = 204;
            // 
            // column_soGheTrong
            // 
            this.column_soGheTrong.Text = "Số ghế trống";
            this.column_soGheTrong.Width = 212;
            // 
            // column_giaVe
            // 
            this.column_giaVe.Text = "Giá vé";
            this.column_giaVe.Width = 172;
            // 
            // column_buttonChon
            // 
            this.column_buttonChon.Text = "      ";
            this.column_buttonChon.Width = 172;
            // 
            // lb_danhSachChuyenBayPhuHop
            // 
            this.lb_danhSachChuyenBayPhuHop.AutoSize = true;
            this.lb_danhSachChuyenBayPhuHop.BackColor = System.Drawing.Color.Transparent;
            this.lb_danhSachChuyenBayPhuHop.Location = new System.Drawing.Point(766, 541);
            this.lb_danhSachChuyenBayPhuHop.Name = "lb_danhSachChuyenBayPhuHop";
            this.lb_danhSachChuyenBayPhuHop.Size = new System.Drawing.Size(345, 26);
            this.lb_danhSachChuyenBayPhuHop.TabIndex = 9;
            this.lb_danhSachChuyenBayPhuHop.Text = "Danh sách chuyến bay phù hợp";
            // 
            // btn_timChuyenBay
            // 
            this.btn_timChuyenBay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_timChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timChuyenBay.Location = new System.Drawing.Point(802, 427);
            this.btn_timChuyenBay.Name = "btn_timChuyenBay";
            this.btn_timChuyenBay.Size = new System.Drawing.Size(267, 62);
            this.btn_timChuyenBay.TabIndex = 8;
            this.btn_timChuyenBay.Text = "Tìm chuyến bay";
            this.btn_timChuyenBay.UseVisualStyleBackColor = false;
            this.btn_timChuyenBay.Click += new System.EventHandler(this.btn_timChuyenBay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cb_sanBayDi);
            this.panel1.Controls.Add(this.lb_sanBayDi);
            this.panel1.Location = new System.Drawing.Point(266, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 100);
            this.panel1.TabIndex = 4;
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDatChoChuyenBay_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
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

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label lb_title2;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.ListView lv_chuyenBayPhuHop;
        private System.Windows.Forms.Label lb_danhSachChuyenBayPhuHop;
        private System.Windows.Forms.Button btn_timChuyenBay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_sanBayDi;
        private System.Windows.Forms.Label lb_sanBayDi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_hangGhe;
        private System.Windows.Forms.Label lb_chonHangGhe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_ngayKhoiHanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_sanBayDen;
        private System.Windows.Forms.Label lb_sanBayDen;
        private System.Windows.Forms.DateTimePicker dp_ngayKhoiHanh;
        private System.Windows.Forms.ColumnHeader column_stt;
        private System.Windows.Forms.ColumnHeader column_maChuyenbay;
        private System.Windows.Forms.ColumnHeader column_gioKhoiHanh;
        private System.Windows.Forms.ColumnHeader column_soGheTrong;
        private System.Windows.Forms.ColumnHeader column_giaVe;
        private System.Windows.Forms.ColumnHeader column_buttonChon;
    }
}