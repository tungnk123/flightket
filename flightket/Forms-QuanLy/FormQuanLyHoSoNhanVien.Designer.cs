namespace flightket.Forms_QuanLy
{
    partial class FormQuanLyHoSoNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyHoSoNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_danhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.columnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCapNhat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lv_danhSachNhanVien);
            this.panel1.Controls.Add(this.btn_xacNhan);
            this.panel1.Controls.Add(this.lb_title1);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(72, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 900);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Danh sách nhân viên ";
            // 
            // lv_danhSachNhanVien
            // 
            this.lv_danhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lv_danhSachNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.lv_danhSachNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.lv_danhSachNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lv_danhSachNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lv_danhSachNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lv_danhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lv_danhSachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSTT,
            this.columnMaNhanVien,
            this.columnHoTen,
            this.columnNamSinh,
            this.columnDiaChi,
            this.columnSdt,
            this.columnCapNhat});
            this.lv_danhSachNhanVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lv_danhSachNhanVien.Location = new System.Drawing.Point(122, 209);
            this.lv_danhSachNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.lv_danhSachNhanVien.Name = "lv_danhSachNhanVien";
            this.lv_danhSachNhanVien.ReadOnly = true;
            this.lv_danhSachNhanVien.RowHeadersVisible = false;
            this.lv_danhSachNhanVien.RowHeadersWidth = 51;
            this.lv_danhSachNhanVien.Size = new System.Drawing.Size(1677, 400);
            this.lv_danhSachNhanVien.TabIndex = 32;
            this.lv_danhSachNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lv_danhSachNhanVien_CellContentClick);
            // 
            // columnSTT
            // 
            this.columnSTT.FillWeight = 2F;
            this.columnSTT.HeaderText = "STT";
            this.columnSTT.MinimumWidth = 6;
            this.columnSTT.Name = "columnSTT";
            this.columnSTT.ReadOnly = true;
            // 
            // columnMaNhanVien
            // 
            this.columnMaNhanVien.FillWeight = 6F;
            this.columnMaNhanVien.HeaderText = "Mã nhân viên";
            this.columnMaNhanVien.MinimumWidth = 6;
            this.columnMaNhanVien.Name = "columnMaNhanVien";
            this.columnMaNhanVien.ReadOnly = true;
            // 
            // columnHoTen
            // 
            this.columnHoTen.FillWeight = 8F;
            this.columnHoTen.HeaderText = "Họ tên";
            this.columnHoTen.MinimumWidth = 6;
            this.columnHoTen.Name = "columnHoTen";
            this.columnHoTen.ReadOnly = true;
            // 
            // columnNamSinh
            // 
            this.columnNamSinh.FillWeight = 4F;
            this.columnNamSinh.HeaderText = "Năm sinh";
            this.columnNamSinh.MinimumWidth = 6;
            this.columnNamSinh.Name = "columnNamSinh";
            this.columnNamSinh.ReadOnly = true;
            this.columnNamSinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnNamSinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnDiaChi
            // 
            this.columnDiaChi.FillWeight = 10F;
            this.columnDiaChi.HeaderText = "Địa chỉ";
            this.columnDiaChi.MinimumWidth = 6;
            this.columnDiaChi.Name = "columnDiaChi";
            this.columnDiaChi.ReadOnly = true;
            // 
            // columnSdt
            // 
            this.columnSdt.FillWeight = 4F;
            this.columnSdt.HeaderText = "SĐT";
            this.columnSdt.MinimumWidth = 6;
            this.columnSdt.Name = "columnSdt";
            this.columnSdt.ReadOnly = true;
            // 
            // columnCapNhat
            // 
            this.columnCapNhat.FillWeight = 4F;
            this.columnCapNhat.HeaderText = "";
            this.columnCapNhat.MinimumWidth = 6;
            this.columnCapNhat.Name = "columnCapNhat";
            this.columnCapNhat.ReadOnly = true;
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btn_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacNhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xacNhan.Location = new System.Drawing.Point(859, 716);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(253, 65);
            this.btn_xacNhan.TabIndex = 30;
            this.btn_xacNhan.Text = "Lưu thay đổi";
            this.btn_xacNhan.UseVisualStyleBackColor = false;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // lb_title1
            // 
            this.lb_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title1.AutoSize = true;
            this.lb_title1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Location = new System.Drawing.Point(618, 28);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(692, 69);
            this.lb_title1.TabIndex = 27;
            this.lb_title1.Text = "Quản lý hồ sơ nhân viên";
            // 
            // btn_back
            // 
            this.btn_back.Image = global::flightket.Properties.Resources.icon_back_final;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 70);
            this.btn_back.TabIndex = 23;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.Image = global::flightket.Properties.Resources.icon_home_final;
            this.btn_home.Location = new System.Drawing.Point(79, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(70, 70);
            this.btn_home.TabIndex = 24;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // FormQuanLyHoSoNhanVien
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
            this.Name = "FormQuanLyHoSoNhanVien";
            this.Text = "FormQuanLyHoSoNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLyHoSoNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lv_danhSachNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSdt;
        private System.Windows.Forms.DataGridViewButtonColumn columnCapNhat;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
    }
}