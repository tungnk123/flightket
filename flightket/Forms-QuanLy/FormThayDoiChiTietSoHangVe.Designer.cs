namespace flightket.Forms_QuanLy
{
    partial class FormThayDoiChiTietSoHangVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThayDoiChiTietSoHangVe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.btn_themHangGhe = new System.Windows.Forms.Button();
            this.lv_danhSachHangVe = new System.Windows.Forms.DataGridView();
            this.columnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_luuThayDoi = new System.Windows.Forms.Button();
            this.tb_tiLe = new System.Windows.Forms.TextBox();
            this.tb_tenHangVe = new System.Windows.Forms.TextBox();
            this.tb_giaTriMoi = new System.Windows.Forms.TextBox();
            this.tb_giaTriCu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachHangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lb_title1);
            this.panel1.Controls.Add(this.btn_themHangGhe);
            this.panel1.Controls.Add(this.lv_danhSachHangVe);
            this.panel1.Controls.Add(this.btn_luuThayDoi);
            this.panel1.Controls.Add(this.tb_tiLe);
            this.panel1.Controls.Add(this.tb_tenHangVe);
            this.panel1.Controls.Add(this.tb_giaTriMoi);
            this.panel1.Controls.Add(this.tb_giaTriCu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(46, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 731);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Danh sách các hạng vé";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(604, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 53);
            this.button1.TabIndex = 52;
            this.button1.Text = "Lưu thay đổi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lb_title1
            // 
            this.lb_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title1.AutoSize = true;
            this.lb_title1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Location = new System.Drawing.Point(335, 36);
            this.lb_title1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(772, 55);
            this.lb_title1.TabIndex = 51;
            this.lb_title1.Text = "Thay đổi chi tiết số lượng hạng vé";
            // 
            // btn_themHangGhe
            // 
            this.btn_themHangGhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_themHangGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themHangGhe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themHangGhe.Location = new System.Drawing.Point(968, 271);
            this.btn_themHangGhe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themHangGhe.Name = "btn_themHangGhe";
            this.btn_themHangGhe.Size = new System.Drawing.Size(71, 30);
            this.btn_themHangGhe.TabIndex = 50;
            this.btn_themHangGhe.Text = "Thêm";
            this.btn_themHangGhe.UseVisualStyleBackColor = false;
            this.btn_themHangGhe.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lv_danhSachHangVe
            // 
            this.lv_danhSachHangVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lv_danhSachHangVe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.lv_danhSachHangVe.BackgroundColor = System.Drawing.Color.White;
            this.lv_danhSachHangVe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lv_danhSachHangVe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lv_danhSachHangVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lv_danhSachHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lv_danhSachHangVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSTT,
            this.columnTenSanBay,
            this.columnQuocGia,
            this.columnXoa});
            this.lv_danhSachHangVe.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lv_danhSachHangVe.Location = new System.Drawing.Point(200, 354);
            this.lv_danhSachHangVe.Name = "lv_danhSachHangVe";
            this.lv_danhSachHangVe.ReadOnly = true;
            this.lv_danhSachHangVe.RowHeadersVisible = false;
            this.lv_danhSachHangVe.RowHeadersWidth = 51;
            this.lv_danhSachHangVe.Size = new System.Drawing.Size(1026, 240);
            this.lv_danhSachHangVe.TabIndex = 45;
            this.lv_danhSachHangVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lv_danhSachHangVe_CellContentClick);
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
            this.columnTenSanBay.HeaderText = "Tên hạng vé";
            this.columnTenSanBay.MinimumWidth = 6;
            this.columnTenSanBay.Name = "columnTenSanBay";
            this.columnTenSanBay.ReadOnly = true;
            // 
            // columnQuocGia
            // 
            this.columnQuocGia.FillWeight = 8F;
            this.columnQuocGia.HeaderText = "Tỉ lệ so với đơn giá";
            this.columnQuocGia.MinimumWidth = 6;
            this.columnQuocGia.Name = "columnQuocGia";
            this.columnQuocGia.ReadOnly = true;
            // 
            // columnXoa
            // 
            this.columnXoa.FillWeight = 2F;
            this.columnXoa.HeaderText = "Xóa";
            this.columnXoa.MinimumWidth = 6;
            this.columnXoa.Name = "columnXoa";
            this.columnXoa.ReadOnly = true;
            // 
            // btn_luuThayDoi
            // 
            this.btn_luuThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btn_luuThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luuThayDoi.ForeColor = System.Drawing.Color.White;
            this.btn_luuThayDoi.Location = new System.Drawing.Point(553, 737);
            this.btn_luuThayDoi.Name = "btn_luuThayDoi";
            this.btn_luuThayDoi.Size = new System.Drawing.Size(225, 52);
            this.btn_luuThayDoi.TabIndex = 44;
            this.btn_luuThayDoi.Text = "Lưu thay đổi";
            this.btn_luuThayDoi.UseVisualStyleBackColor = false;
            this.btn_luuThayDoi.Click += new System.EventHandler(this.btn_luuThayDoi_Click);
            // 
            // tb_tiLe
            // 
            this.tb_tiLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_tiLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tiLe.ForeColor = System.Drawing.Color.Black;
            this.tb_tiLe.Location = new System.Drawing.Point(674, 275);
            this.tb_tiLe.Multiline = true;
            this.tb_tiLe.Name = "tb_tiLe";
            this.tb_tiLe.Size = new System.Drawing.Size(207, 27);
            this.tb_tiLe.TabIndex = 41;
            this.tb_tiLe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_tiLe.Leave += new System.EventHandler(this.tb_tiLe_Leave);
            // 
            // tb_tenHangVe
            // 
            this.tb_tenHangVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_tenHangVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenHangVe.ForeColor = System.Drawing.Color.Black;
            this.tb_tenHangVe.Location = new System.Drawing.Point(379, 275);
            this.tb_tenHangVe.Multiline = true;
            this.tb_tenHangVe.Name = "tb_tenHangVe";
            this.tb_tenHangVe.Size = new System.Drawing.Size(188, 27);
            this.tb_tenHangVe.TabIndex = 40;
            this.tb_tenHangVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_tenHangVe.Leave += new System.EventHandler(this.tb_tenHangVe_Leave);
            // 
            // tb_giaTriMoi
            // 
            this.tb_giaTriMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_giaTriMoi.Enabled = false;
            this.tb_giaTriMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giaTriMoi.ForeColor = System.Drawing.Color.Black;
            this.tb_giaTriMoi.Location = new System.Drawing.Point(920, 154);
            this.tb_giaTriMoi.Multiline = true;
            this.tb_giaTriMoi.Name = "tb_giaTriMoi";
            this.tb_giaTriMoi.ReadOnly = true;
            this.tb_giaTriMoi.Size = new System.Drawing.Size(180, 36);
            this.tb_giaTriMoi.TabIndex = 39;
            this.tb_giaTriMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_giaTriCu
            // 
            this.tb_giaTriCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_giaTriCu.Enabled = false;
            this.tb_giaTriCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giaTriCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.tb_giaTriCu.Location = new System.Drawing.Point(676, 154);
            this.tb_giaTriCu.Multiline = true;
            this.tb_giaTriCu.Name = "tb_giaTriCu";
            this.tb_giaTriCu.ReadOnly = true;
            this.tb_giaTriCu.Size = new System.Drawing.Size(180, 36);
            this.tb_giaTriCu.TabIndex = 38;
            this.tb_giaTriCu.Text = "10";
            this.tb_giaTriCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 22);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tỉ lệ so với đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tên hạng vé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Số lượng hạng vé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(936, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Giá trị mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(698, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Giá trị cũ";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Location = new System.Drawing.Point(2, 2);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(52, 57);
            this.btn_back.TabIndex = 23;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(55, 2);
            this.btn_home.Margin = new System.Windows.Forms.Padding(2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(52, 57);
            this.btn_home.TabIndex = 24;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // FormThayDoiChiTietSoHangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350361348_206044632301251_2266599988871672436_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThayDoiChiTietSoHangVe";
            this.Text = "FormThayDoiChiTietSoHangVe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThayDoiChiTietSoHangVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachHangVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lv_danhSachHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTenSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuocGia;
        private System.Windows.Forms.DataGridViewButtonColumn columnXoa;
        private System.Windows.Forms.Button btn_luuThayDoi;
        private System.Windows.Forms.TextBox tb_tiLe;
        private System.Windows.Forms.TextBox tb_tenHangVe;
        private System.Windows.Forms.TextBox tb_giaTriMoi;
        private System.Windows.Forms.TextBox tb_giaTriCu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_themHangGhe;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}