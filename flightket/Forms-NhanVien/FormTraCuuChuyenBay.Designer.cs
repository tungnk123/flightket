
namespace flightket.Forms_NhanVien
{
    partial class FormTraCuuChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraCuuChuyenBay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_xuatThongTin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_sanBayDen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dp_ngayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.lb_ngayKhoiHanh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_sanBayDi = new System.Windows.Forms.ComboBox();
            this.lb_sanBayDen = new System.Windows.Forms.Label();
            this.lv_chuyenBayPhuHop = new System.Windows.Forms.ListView();
            this.column_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_sanBayDi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_sanBayDen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_gioKhoiHanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_thoiGianBay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_soGheTrong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_soGheDaDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_danhSachChuyenBayPhuHop = new System.Windows.Forms.Label();
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_maChuyenBay = new System.Windows.Forms.TextBox();
            this.lb_sanBayDi = new System.Windows.Forms.Label();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_xuatThongTin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lv_chuyenBayPhuHop);
            this.panel1.Controls.Add(this.lb_danhSachChuyenBayPhuHop);
            this.panel1.Controls.Add(this.btn_traCuu);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lb_title1);
            this.panel1.Location = new System.Drawing.Point(74, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 900);
            this.panel1.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Image = global::flightket.Properties.Resources.icons8_back_64;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 70);
            this.btn_back.TabIndex = 23;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.Image = global::flightket.Properties.Resources.icons8_home_50;
            this.btn_home.Location = new System.Drawing.Point(79, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(70, 70);
            this.btn_home.TabIndex = 24;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_xuatThongTin
            // 
            this.btn_xuatThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btn_xuatThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatThongTin.ForeColor = System.Drawing.Color.White;
            this.btn_xuatThongTin.Image = global::flightket.Properties.Resources.icons8_export_64;
            this.btn_xuatThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xuatThongTin.Location = new System.Drawing.Point(1323, 767);
            this.btn_xuatThongTin.Name = "btn_xuatThongTin";
            this.btn_xuatThongTin.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_xuatThongTin.Size = new System.Drawing.Size(317, 65);
            this.btn_xuatThongTin.TabIndex = 22;
            this.btn_xuatThongTin.Text = "Xuất thông tin";
            this.btn_xuatThongTin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1350, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "(*) Cung cấp ít nhất 1 thông tin";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.cb_sanBayDen);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(978, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 100);
            this.panel4.TabIndex = 17;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sân bay đến";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dp_ngayKhoiHanh);
            this.panel3.Controls.Add(this.lb_ngayKhoiHanh);
            this.panel3.Location = new System.Drawing.Point(1341, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 100);
            this.panel3.TabIndex = 15;
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
            this.panel2.Controls.Add(this.cb_sanBayDi);
            this.panel2.Controls.Add(this.lb_sanBayDen);
            this.panel2.Location = new System.Drawing.Point(598, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 100);
            this.panel2.TabIndex = 16;
            // 
            // cb_sanBayDi
            // 
            this.cb_sanBayDi.BackColor = System.Drawing.Color.Silver;
            this.cb_sanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sanBayDi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_sanBayDi.FormattingEnabled = true;
            this.cb_sanBayDi.Location = new System.Drawing.Point(31, 58);
            this.cb_sanBayDi.Name = "cb_sanBayDi";
            this.cb_sanBayDi.Size = new System.Drawing.Size(224, 37);
            this.cb_sanBayDi.TabIndex = 1;
            // 
            // lb_sanBayDen
            // 
            this.lb_sanBayDen.AutoSize = true;
            this.lb_sanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sanBayDen.Location = new System.Drawing.Point(26, 16);
            this.lb_sanBayDen.Name = "lb_sanBayDen";
            this.lb_sanBayDen.Size = new System.Drawing.Size(125, 29);
            this.lb_sanBayDen.TabIndex = 0;
            this.lb_sanBayDen.Text = "Sân bay đi";
            // 
            // lv_chuyenBayPhuHop
            // 
            this.lv_chuyenBayPhuHop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_stt,
            this.column_sanBayDi,
            this.column_sanBayDen,
            this.column_gioKhoiHanh,
            this.column_thoiGianBay,
            this.column_soGheTrong,
            this.column_soGheDaDat});
            this.lv_chuyenBayPhuHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_chuyenBayPhuHop.HideSelection = false;
            this.lv_chuyenBayPhuHop.Location = new System.Drawing.Point(221, 581);
            this.lv_chuyenBayPhuHop.Name = "lv_chuyenBayPhuHop";
            this.lv_chuyenBayPhuHop.Size = new System.Drawing.Size(1401, 130);
            this.lv_chuyenBayPhuHop.TabIndex = 20;
            this.lv_chuyenBayPhuHop.UseCompatibleStateImageBehavior = false;
            this.lv_chuyenBayPhuHop.View = System.Windows.Forms.View.Details;
            // 
            // column_stt
            // 
            this.column_stt.Text = "STT";
            this.column_stt.Width = 78;
            // 
            // column_sanBayDi
            // 
            this.column_sanBayDi.Text = "Sân bay đi";
            this.column_sanBayDi.Width = 142;
            // 
            // column_sanBayDen
            // 
            this.column_sanBayDen.Text = "Sân bay đến";
            this.column_sanBayDen.Width = 152;
            // 
            // column_gioKhoiHanh
            // 
            this.column_gioKhoiHanh.Text = "Giờ khởi hành";
            this.column_gioKhoiHanh.Width = 169;
            // 
            // column_thoiGianBay
            // 
            this.column_thoiGianBay.Text = "Thời gian bay";
            this.column_thoiGianBay.Width = 194;
            // 
            // column_soGheTrong
            // 
            this.column_soGheTrong.Text = "Số ghế trống";
            this.column_soGheTrong.Width = 172;
            // 
            // column_soGheDaDat
            // 
            this.column_soGheDaDat.Text = "Số ghế đã đặt";
            this.column_soGheDaDat.Width = 162;
            // 
            // lb_danhSachChuyenBayPhuHop
            // 
            this.lb_danhSachChuyenBayPhuHop.AutoSize = true;
            this.lb_danhSachChuyenBayPhuHop.BackColor = System.Drawing.Color.Transparent;
            this.lb_danhSachChuyenBayPhuHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_danhSachChuyenBayPhuHop.Location = new System.Drawing.Point(799, 523);
            this.lb_danhSachChuyenBayPhuHop.Name = "lb_danhSachChuyenBayPhuHop";
            this.lb_danhSachChuyenBayPhuHop.Size = new System.Drawing.Size(345, 26);
            this.lb_danhSachChuyenBayPhuHop.TabIndex = 19;
            this.lb_danhSachChuyenBayPhuHop.Text = "Danh sách chuyến bay phù hợp";
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_traCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traCuu.Image = global::flightket.Properties.Resources.icons8_search_50;
            this.btn_traCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuu.Location = new System.Drawing.Point(850, 412);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_traCuu.Size = new System.Drawing.Size(230, 65);
            this.btn_traCuu.TabIndex = 18;
            this.btn_traCuu.Text = "Tra cứu";
            this.btn_traCuu.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.tb_maChuyenBay);
            this.panel5.Controls.Add(this.lb_sanBayDi);
            this.panel5.Location = new System.Drawing.Point(280, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 100);
            this.panel5.TabIndex = 14;
            // 
            // tb_maChuyenBay
            // 
            this.tb_maChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maChuyenBay.Location = new System.Drawing.Point(31, 58);
            this.tb_maChuyenBay.Multiline = true;
            this.tb_maChuyenBay.Name = "tb_maChuyenBay";
            this.tb_maChuyenBay.Size = new System.Drawing.Size(180, 32);
            this.tb_maChuyenBay.TabIndex = 1;
            // 
            // lb_sanBayDi
            // 
            this.lb_sanBayDi.AutoSize = true;
            this.lb_sanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sanBayDi.Location = new System.Drawing.Point(26, 16);
            this.lb_sanBayDi.Name = "lb_sanBayDi";
            this.lb_sanBayDi.Size = new System.Drawing.Size(172, 29);
            this.lb_sanBayDi.TabIndex = 0;
            this.lb_sanBayDi.Text = "Mã chuyến bay";
            // 
            // lb_title1
            // 
            this.lb_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title1.AutoSize = true;
            this.lb_title1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Location = new System.Drawing.Point(654, 29);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(570, 69);
            this.lb_title1.TabIndex = 13;
            this.lb_title1.Text = "Tra cứu chuyến bay";
            // 
            // FormTraCuuChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350361348_206044632301251_2266599988871672436_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTraCuuChuyenBay";
            this.Text = "FormTraCuuChuyenBay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_xuatThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_sanBayDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dp_ngayKhoiHanh;
        private System.Windows.Forms.Label lb_ngayKhoiHanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_sanBayDi;
        private System.Windows.Forms.Label lb_sanBayDen;
        private System.Windows.Forms.ListView lv_chuyenBayPhuHop;
        private System.Windows.Forms.ColumnHeader column_stt;
        private System.Windows.Forms.ColumnHeader column_sanBayDi;
        private System.Windows.Forms.ColumnHeader column_sanBayDen;
        private System.Windows.Forms.ColumnHeader column_gioKhoiHanh;
        private System.Windows.Forms.ColumnHeader column_thoiGianBay;
        private System.Windows.Forms.ColumnHeader column_soGheTrong;
        private System.Windows.Forms.ColumnHeader column_soGheDaDat;
        private System.Windows.Forms.Label lb_danhSachChuyenBayPhuHop;
        private System.Windows.Forms.Button btn_traCuu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_maChuyenBay;
        private System.Windows.Forms.Label lb_sanBayDi;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
    }
}