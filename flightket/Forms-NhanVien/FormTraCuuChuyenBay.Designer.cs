
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraCuuChuyenBay));
            this.lb_title1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_maChuyenBay = new System.Windows.Forms.TextBox();
            this.lb_sanBayDi = new System.Windows.Forms.Label();
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.lb_danhSachChuyenBayPhuHop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_sanBayDi = new System.Windows.Forms.ComboBox();
            this.lb_sanBayDen = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chb_ngayKhoiHanh = new System.Windows.Forms.CheckBox();
            this.dp_ngayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_sanBayDen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xuatThongTin = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_title2 = new System.Windows.Forms.Label();
            this.dgv_chuyenBayPhuHop = new System.Windows.Forms.DataGridView();
            this.column_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_maChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_sanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_sanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ngayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_thoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_soGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_soGheDaDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenBayPhuHop)).BeginInit();
            this.SuspendLayout();
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
            this.btn_traCuu.Click += new System.EventHandler(this.btn_traCuu_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.chb_ngayKhoiHanh);
            this.panel3.Controls.Add(this.dp_ngayKhoiHanh);
            this.panel3.Location = new System.Drawing.Point(1341, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 100);
            this.panel3.TabIndex = 15;
            // 
            // chb_ngayKhoiHanh
            // 
            this.chb_ngayKhoiHanh.AutoSize = true;
            this.chb_ngayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ngayKhoiHanh.Location = new System.Drawing.Point(31, 16);
            this.chb_ngayKhoiHanh.Name = "chb_ngayKhoiHanh";
            this.chb_ngayKhoiHanh.Size = new System.Drawing.Size(200, 33);
            this.chb_ngayKhoiHanh.TabIndex = 2;
            this.chb_ngayKhoiHanh.Text = "Ngày khởi hành";
            this.chb_ngayKhoiHanh.UseVisualStyleBackColor = true;
            this.chb_ngayKhoiHanh.CheckStateChanged += new System.EventHandler(this.cb_ngayKhoiHanh_CheckStateChanged);
            // 
            // dp_ngayKhoiHanh
            // 
            this.dp_ngayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_ngayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_ngayKhoiHanh.Location = new System.Drawing.Point(31, 66);
            this.dp_ngayKhoiHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_ngayKhoiHanh.Name = "dp_ngayKhoiHanh";
            this.dp_ngayKhoiHanh.Size = new System.Drawing.Size(240, 34);
            this.dp_ngayKhoiHanh.TabIndex = 1;
            this.dp_ngayKhoiHanh.Value = new System.DateTime(2023, 6, 7, 15, 53, 6, 0);
            this.dp_ngayKhoiHanh.Visible = false;
            this.dp_ngayKhoiHanh.ValueChanged += new System.EventHandler(this.dp_ngayKhoiHanh_ValueChanged);
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
            this.btn_xuatThongTin.Text = "Export File";
            this.btn_xuatThongTin.UseVisualStyleBackColor = false;
            this.btn_xuatThongTin.Click += new System.EventHandler(this.btn_xuatThongTin_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lb_title2);
            this.panel1.Controls.Add(this.dgv_chuyenBayPhuHop);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_xuatThongTin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lb_danhSachChuyenBayPhuHop);
            this.panel1.Controls.Add(this.btn_traCuu);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lb_title1);
            this.panel1.Location = new System.Drawing.Point(77, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 900);
            this.panel1.TabIndex = 1;
            // 
            // lb_title2
            // 
            this.lb_title2.AutoSize = true;
            this.lb_title2.BackColor = System.Drawing.Color.Transparent;
            this.lb_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title2.Location = new System.Drawing.Point(717, 117);
            this.lb_title2.Name = "lb_title2";
            this.lb_title2.Size = new System.Drawing.Size(427, 38);
            this.lb_title2.TabIndex = 26;
            this.lb_title2.Text = "Nhập thông tin muốn tra cứu\r\n";
            // 
            // dgv_chuyenBayPhuHop
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chuyenBayPhuHop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_chuyenBayPhuHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chuyenBayPhuHop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_stt,
            this.column_maChuyenBay,
            this.column_sanBayDi,
            this.column_sanBayDen,
            this.column_ngayKhoiHanh,
            this.column_thoiGianBay,
            this.column_soGheTrong,
            this.column_soGheDaDat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chuyenBayPhuHop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_chuyenBayPhuHop.Location = new System.Drawing.Point(182, 570);
            this.dgv_chuyenBayPhuHop.Name = "dgv_chuyenBayPhuHop";
            this.dgv_chuyenBayPhuHop.RowHeadersWidth = 51;
            this.dgv_chuyenBayPhuHop.RowTemplate.Height = 24;
            this.dgv_chuyenBayPhuHop.Size = new System.Drawing.Size(1501, 182);
            this.dgv_chuyenBayPhuHop.TabIndex = 12;
            // 
            // column_stt
            // 
            this.column_stt.HeaderText = "STT";
            this.column_stt.MinimumWidth = 6;
            this.column_stt.Name = "column_stt";
            this.column_stt.Width = 60;
            // 
            // column_maChuyenBay
            // 
            this.column_maChuyenBay.HeaderText = "Mã chuyến bay";
            this.column_maChuyenBay.MinimumWidth = 6;
            this.column_maChuyenBay.Name = "column_maChuyenBay";
            this.column_maChuyenBay.Width = 150;
            // 
            // column_sanBayDi
            // 
            this.column_sanBayDi.HeaderText = "Sân bay đi";
            this.column_sanBayDi.MinimumWidth = 6;
            this.column_sanBayDi.Name = "column_sanBayDi";
            this.column_sanBayDi.Width = 180;
            // 
            // column_sanBayDen
            // 
            this.column_sanBayDen.HeaderText = "Sân bay đến";
            this.column_sanBayDen.MinimumWidth = 6;
            this.column_sanBayDen.Name = "column_sanBayDen";
            this.column_sanBayDen.Width = 180;
            // 
            // column_ngayKhoiHanh
            // 
            this.column_ngayKhoiHanh.HeaderText = "Ngày khởi hành";
            this.column_ngayKhoiHanh.MinimumWidth = 6;
            this.column_ngayKhoiHanh.Name = "column_ngayKhoiHanh";
            this.column_ngayKhoiHanh.Width = 125;
            // 
            // column_thoiGianBay
            // 
            this.column_thoiGianBay.HeaderText = "Thời gian bay (phút)";
            this.column_thoiGianBay.MinimumWidth = 6;
            this.column_thoiGianBay.Name = "column_thoiGianBay";
            this.column_thoiGianBay.Width = 125;
            // 
            // column_soGheTrong
            // 
            this.column_soGheTrong.HeaderText = "Số ghế trống";
            this.column_soGheTrong.MinimumWidth = 6;
            this.column_soGheTrong.Name = "column_soGheTrong";
            this.column_soGheTrong.Width = 125;
            // 
            // column_soGheDaDat
            // 
            this.column_soGheDaDat.HeaderText = "Số ghế đã đặt";
            this.column_soGheDaDat.MinimumWidth = 6;
            this.column_soGheDaDat.Name = "column_soGheDaDat";
            this.column_soGheDaDat.Width = 125;
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
            this.Text = "Flightket - Tra cứu chuyến bay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTraCuuChuyenBay_FormClosed);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenBayPhuHop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_maChuyenBay;
        private System.Windows.Forms.Label lb_sanBayDi;
        private System.Windows.Forms.Button btn_traCuu;
        private System.Windows.Forms.Label lb_danhSachChuyenBayPhuHop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_sanBayDi;
        private System.Windows.Forms.Label lb_sanBayDen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dp_ngayKhoiHanh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_sanBayDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_xuatThongTin;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_chuyenBayPhuHop;
        private System.Windows.Forms.CheckBox chb_ngayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_maChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_sanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_sanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ngayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_thoiGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_soGheTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_soGheDaDat;
        private System.Windows.Forms.Label lb_title2;
    }
}