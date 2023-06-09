namespace flightket.Forms_QuanLy
{
    partial class FormChiTietThayDoiSoSanBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietThayDoiSoSanBay));
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_soLuongSanBayCu = new System.Windows.Forms.TextBox();
            this.tb_soLuongSanBayMoi = new System.Windows.Forms.TextBox();
            this.btn_luuThayDoi = new System.Windows.Forms.Button();
            this.lv_danhSachSanBay = new System.Windows.Forms.DataGridView();
            this.columnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_tenSanBay = new System.Windows.Forms.TextBox();
            this.tb_tenQuocGia = new System.Windows.Forms.TextBox();
            this.tb_diaChi = new System.Windows.Forms.TextBox();
            this.btn_themHangGhe = new System.Windows.Forms.Button();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachSanBay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(79, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(70, 70);
            this.btn_home.TabIndex = 24;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 70);
            this.btn_back.TabIndex = 23;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1032, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Giá trị cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1349, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Giá trị mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Số lượng sân bay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tên sân bay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(654, 298);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Quốc gia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1013, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Địa chỉ";
            // 
            // tb_soLuongSanBayCu
            // 
            this.tb_soLuongSanBayCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_soLuongSanBayCu.Enabled = false;
            this.tb_soLuongSanBayCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soLuongSanBayCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.tb_soLuongSanBayCu.Location = new System.Drawing.Point(1002, 194);
            this.tb_soLuongSanBayCu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soLuongSanBayCu.Multiline = true;
            this.tb_soLuongSanBayCu.Name = "tb_soLuongSanBayCu";
            this.tb_soLuongSanBayCu.ReadOnly = true;
            this.tb_soLuongSanBayCu.Size = new System.Drawing.Size(239, 32);
            this.tb_soLuongSanBayCu.TabIndex = 38;
            this.tb_soLuongSanBayCu.Text = "10";
            this.tb_soLuongSanBayCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_soLuongSanBayMoi
            // 
            this.tb_soLuongSanBayMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_soLuongSanBayMoi.Enabled = false;
            this.tb_soLuongSanBayMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soLuongSanBayMoi.ForeColor = System.Drawing.Color.Black;
            this.tb_soLuongSanBayMoi.Location = new System.Drawing.Point(1328, 194);
            this.tb_soLuongSanBayMoi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soLuongSanBayMoi.Multiline = true;
            this.tb_soLuongSanBayMoi.Name = "tb_soLuongSanBayMoi";
            this.tb_soLuongSanBayMoi.ReadOnly = true;
            this.tb_soLuongSanBayMoi.Size = new System.Drawing.Size(239, 32);
            this.tb_soLuongSanBayMoi.TabIndex = 39;
            this.tb_soLuongSanBayMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_luuThayDoi
            // 
            this.btn_luuThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btn_luuThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luuThayDoi.ForeColor = System.Drawing.Color.White;
            this.btn_luuThayDoi.Location = new System.Drawing.Point(797, 759);
            this.btn_luuThayDoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luuThayDoi.Name = "btn_luuThayDoi";
            this.btn_luuThayDoi.Size = new System.Drawing.Size(300, 65);
            this.btn_luuThayDoi.TabIndex = 44;
            this.btn_luuThayDoi.Text = "Lưu thay đổi";
            this.btn_luuThayDoi.UseVisualStyleBackColor = false;
            this.btn_luuThayDoi.Click += new System.EventHandler(this.btn_luuThayDoi_Click);
            // 
            // lv_danhSachSanBay
            // 
            this.lv_danhSachSanBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lv_danhSachSanBay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.lv_danhSachSanBay.BackgroundColor = System.Drawing.Color.White;
            this.lv_danhSachSanBay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lv_danhSachSanBay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lv_danhSachSanBay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lv_danhSachSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lv_danhSachSanBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSTT,
            this.columnTenSanBay,
            this.columnQuocGia,
            this.columDiaChi,
            this.columnXoa});
            this.lv_danhSachSanBay.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lv_danhSachSanBay.Location = new System.Drawing.Point(257, 442);
            this.lv_danhSachSanBay.Margin = new System.Windows.Forms.Padding(4);
            this.lv_danhSachSanBay.Name = "lv_danhSachSanBay";
            this.lv_danhSachSanBay.ReadOnly = true;
            this.lv_danhSachSanBay.RowHeadersVisible = false;
            this.lv_danhSachSanBay.RowHeadersWidth = 51;
            this.lv_danhSachSanBay.Size = new System.Drawing.Size(1368, 249);
            this.lv_danhSachSanBay.TabIndex = 45;
            this.lv_danhSachSanBay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lv_danhSachSanBay_CellContentClick);
            // 
            // columnSTT
            // 
            this.columnSTT.FillWeight = 2F;
            this.columnSTT.HeaderText = "STT";
            this.columnSTT.MinimumWidth = 6;
            this.columnSTT.Name = "columnSTT";
            this.columnSTT.ReadOnly = true;
            // 
            // columnTenSanBay
            // 
            this.columnTenSanBay.FillWeight = 8F;
            this.columnTenSanBay.HeaderText = "Tên sân bay";
            this.columnTenSanBay.MinimumWidth = 6;
            this.columnTenSanBay.Name = "columnTenSanBay";
            this.columnTenSanBay.ReadOnly = true;
            // 
            // columnQuocGia
            // 
            this.columnQuocGia.FillWeight = 8F;
            this.columnQuocGia.HeaderText = "Quốc gia";
            this.columnQuocGia.MinimumWidth = 6;
            this.columnQuocGia.Name = "columnQuocGia";
            this.columnQuocGia.ReadOnly = true;
            // 
            // columDiaChi
            // 
            this.columDiaChi.FillWeight = 8F;
            this.columDiaChi.HeaderText = "Địa chỉ";
            this.columDiaChi.MinimumWidth = 6;
            this.columDiaChi.Name = "columDiaChi";
            this.columDiaChi.ReadOnly = true;
            // 
            // columnXoa
            // 
            this.columnXoa.FillWeight = 2F;
            this.columnXoa.HeaderText = "Xóa";
            this.columnXoa.MinimumWidth = 6;
            this.columnXoa.Name = "columnXoa";
            this.columnXoa.ReadOnly = true;
            // 
            // tb_tenSanBay
            // 
            this.tb_tenSanBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenSanBay.Location = new System.Drawing.Point(266, 339);
            this.tb_tenSanBay.Multiline = true;
            this.tb_tenSanBay.Name = "tb_tenSanBay";
            this.tb_tenSanBay.Size = new System.Drawing.Size(196, 32);
            this.tb_tenSanBay.TabIndex = 46;
            // 
            // tb_tenQuocGia
            // 
            this.tb_tenQuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenQuocGia.Location = new System.Drawing.Point(659, 339);
            this.tb_tenQuocGia.Multiline = true;
            this.tb_tenQuocGia.Name = "tb_tenQuocGia";
            this.tb_tenQuocGia.Size = new System.Drawing.Size(196, 32);
            this.tb_tenQuocGia.TabIndex = 47;
            // 
            // tb_diaChi
            // 
            this.tb_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diaChi.Location = new System.Drawing.Point(1018, 330);
            this.tb_diaChi.Multiline = true;
            this.tb_diaChi.Name = "tb_diaChi";
            this.tb_diaChi.Size = new System.Drawing.Size(345, 32);
            this.tb_diaChi.TabIndex = 48;
            // 
            // btn_themHangGhe
            // 
            this.btn_themHangGhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_themHangGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themHangGhe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themHangGhe.Location = new System.Drawing.Point(1517, 325);
            this.btn_themHangGhe.Name = "btn_themHangGhe";
            this.btn_themHangGhe.Size = new System.Drawing.Size(95, 37);
            this.btn_themHangGhe.TabIndex = 49;
            this.btn_themHangGhe.Text = "Thêm";
            this.btn_themHangGhe.UseVisualStyleBackColor = false;
            this.btn_themHangGhe.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lb_title1
            // 
            this.lb_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title1.AutoSize = true;
            this.lb_title1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Location = new System.Drawing.Point(459, 31);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(944, 69);
            this.lb_title1.TabIndex = 50;
            this.lb_title1.Text = "Thay đổi chi tiết số lượng sân bay";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_title1);
            this.panel1.Controls.Add(this.btn_themHangGhe);
            this.panel1.Controls.Add(this.tb_diaChi);
            this.panel1.Controls.Add(this.tb_tenQuocGia);
            this.panel1.Controls.Add(this.tb_tenSanBay);
            this.panel1.Controls.Add(this.lv_danhSachSanBay);
            this.panel1.Controls.Add(this.btn_luuThayDoi);
            this.panel1.Controls.Add(this.tb_soLuongSanBayMoi);
            this.panel1.Controls.Add(this.tb_soLuongSanBayCu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(66, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 900);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(820, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Danh sách các sân bay";
            // 
            // FormChiTietThayDoiSoSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350361348_206044632301251_2266599988871672436_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChiTietThayDoiSoSanBay";
            this.Text = "FormChiTietThayDoiSoSanBay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChiTietThayDoiSoSanBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachSanBay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_soLuongSanBayCu;
        private System.Windows.Forms.TextBox tb_soLuongSanBayMoi;
        private System.Windows.Forms.Button btn_luuThayDoi;
        private System.Windows.Forms.DataGridView lv_danhSachSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTenSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDiaChi;
        private System.Windows.Forms.DataGridViewButtonColumn columnXoa;
        private System.Windows.Forms.TextBox tb_tenSanBay;
        private System.Windows.Forms.TextBox tb_tenQuocGia;
        private System.Windows.Forms.TextBox tb_diaChi;
        private System.Windows.Forms.Button btn_themHangGhe;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}