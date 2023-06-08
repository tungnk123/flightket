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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyHoSoNhanVien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_danhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.columnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCapNhat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1815, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lv_danhSachNhanVien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(215, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2111, 1035);
            this.panel1.TabIndex = 10;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lv_danhSachNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.lv_danhSachNhanVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lv_danhSachNhanVien.Location = new System.Drawing.Point(172, 302);
            this.lv_danhSachNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lv_danhSachNhanVien.Name = "lv_danhSachNhanVien";
            this.lv_danhSachNhanVien.ReadOnly = true;
            this.lv_danhSachNhanVien.RowHeadersVisible = false;
            this.lv_danhSachNhanVien.RowHeadersWidth = 51;
            this.lv_danhSachNhanVien.Size = new System.Drawing.Size(1799, 389);
            this.lv_danhSachNhanVien.TabIndex = 31;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(881, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 42);
            this.label8.TabIndex = 8;
            this.label8.Text = "Danh sách nhân viên";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2107, 95);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý hồ sơ nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_home.Location = new System.Drawing.Point(92, 4);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(84, 46);
            this.btn_home.TabIndex = 1;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Location = new System.Drawing.Point(15, 4);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 46);
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FormQuanLyHoSoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350248398_786598096329880_2111811280162483567_n__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQuanLyHoSoNhanVien";
            this.Text = "FormQuanLyHoSoNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuanLyHoSoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lv_danhSachNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSdt;
        private System.Windows.Forms.DataGridViewButtonColumn columnCapNhat;
    }
}