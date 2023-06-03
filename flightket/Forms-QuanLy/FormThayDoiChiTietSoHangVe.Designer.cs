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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThayDoiChiTietSoHangVe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_danhSachHangVe = new System.Windows.Forms.DataGridView();
            this.columnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_luuThayDoi = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_tiLe = new System.Windows.Forms.TextBox();
            this.tb_tenHangVe = new System.Windows.Forms.TextBox();
            this.tb_giaTriMoi = new System.Windows.Forms.TextBox();
            this.tb_giaTriCu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachHangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1361, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lv_danhSachHangVe);
            this.panel1.Controls.Add(this.btn_luuThayDoi);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.tb_tiLe);
            this.panel1.Controls.Add(this.tb_tenHangVe);
            this.panel1.Controls.Add(this.tb_giaTriMoi);
            this.panel1.Controls.Add(this.tb_giaTriCu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(161, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1583, 841);
            this.panel1.TabIndex = 9;
            // 
            // lv_danhSachHangVe
            // 
            this.lv_danhSachHangVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lv_danhSachHangVe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.lv_danhSachHangVe.BackgroundColor = System.Drawing.Color.White;
            this.lv_danhSachHangVe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lv_danhSachHangVe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lv_danhSachHangVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.lv_danhSachHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lv_danhSachHangVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSTT,
            this.columnHangVe,
            this.columnTiLe,
            this.columnXoa});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lv_danhSachHangVe.DefaultCellStyle = dataGridViewCellStyle10;
            this.lv_danhSachHangVe.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lv_danhSachHangVe.Location = new System.Drawing.Point(261, 432);
            this.lv_danhSachHangVe.Name = "lv_danhSachHangVe";
            this.lv_danhSachHangVe.ReadOnly = true;
            this.lv_danhSachHangVe.RowHeadersVisible = false;
            this.lv_danhSachHangVe.Size = new System.Drawing.Size(1026, 316);
            this.lv_danhSachHangVe.TabIndex = 31;
            this.lv_danhSachHangVe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lv_danhSachHangVe_CellContentClick);
            // 
            // columnSTT
            // 
            this.columnSTT.FillWeight = 2F;
            this.columnSTT.HeaderText = "STT";
            this.columnSTT.Name = "columnSTT";
            this.columnSTT.ReadOnly = true;
            // 
            // columnHangVe
            // 
            this.columnHangVe.FillWeight = 8F;
            this.columnHangVe.HeaderText = "Hạng vé";
            this.columnHangVe.Name = "columnHangVe";
            this.columnHangVe.ReadOnly = true;
            // 
            // columnTiLe
            // 
            this.columnTiLe.FillWeight = 8F;
            this.columnTiLe.HeaderText = "Tỉ lệ so với đơn giá";
            this.columnTiLe.Name = "columnTiLe";
            this.columnTiLe.ReadOnly = true;
            // 
            // columnXoa
            // 
            this.columnXoa.FillWeight = 2F;
            this.columnXoa.HeaderText = "Xóa";
            this.columnXoa.Name = "columnXoa";
            this.columnXoa.ReadOnly = true;
            // 
            // btn_luuThayDoi
            // 
            this.btn_luuThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btn_luuThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luuThayDoi.ForeColor = System.Drawing.Color.White;
            this.btn_luuThayDoi.Location = new System.Drawing.Point(682, 764);
            this.btn_luuThayDoi.Name = "btn_luuThayDoi";
            this.btn_luuThayDoi.Size = new System.Drawing.Size(225, 52);
            this.btn_luuThayDoi.TabIndex = 30;
            this.btn_luuThayDoi.Text = "Lưu thay đổi";
            this.btn_luuThayDoi.UseVisualStyleBackColor = false;
            this.btn_luuThayDoi.Click += new System.EventHandler(this.btn_luuThayDoi_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(967, 346);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(180, 60);
            this.btn_them.TabIndex = 28;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_tiLe
            // 
            this.tb_tiLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_tiLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tiLe.ForeColor = System.Drawing.Color.Black;
            this.tb_tiLe.Location = new System.Drawing.Point(700, 346);
            this.tb_tiLe.Multiline = true;
            this.tb_tiLe.Name = "tb_tiLe";
            this.tb_tiLe.Size = new System.Drawing.Size(207, 60);
            this.tb_tiLe.TabIndex = 17;
            this.tb_tiLe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_tiLe.Leave += new System.EventHandler(this.tb_tiLe_Leave);
            // 
            // tb_tenHangVe
            // 
            this.tb_tenHangVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_tenHangVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenHangVe.ForeColor = System.Drawing.Color.Black;
            this.tb_tenHangVe.Location = new System.Drawing.Point(405, 346);
            this.tb_tenHangVe.Multiline = true;
            this.tb_tenHangVe.Name = "tb_tenHangVe";
            this.tb_tenHangVe.Size = new System.Drawing.Size(236, 60);
            this.tb_tenHangVe.TabIndex = 16;
            this.tb_tenHangVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_tenHangVe.Leave += new System.EventHandler(this.tb_tenHangVe_Leave);
            // 
            // tb_giaTriMoi
            // 
            this.tb_giaTriMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_giaTriMoi.Enabled = false;
            this.tb_giaTriMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giaTriMoi.ForeColor = System.Drawing.Color.Black;
            this.tb_giaTriMoi.Location = new System.Drawing.Point(1004, 179);
            this.tb_giaTriMoi.Multiline = true;
            this.tb_giaTriMoi.Name = "tb_giaTriMoi";
            this.tb_giaTriMoi.ReadOnly = true;
            this.tb_giaTriMoi.Size = new System.Drawing.Size(180, 60);
            this.tb_giaTriMoi.TabIndex = 15;
            this.tb_giaTriMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_giaTriCu
            // 
            this.tb_giaTriCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tb_giaTriCu.Enabled = false;
            this.tb_giaTriCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giaTriCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.tb_giaTriCu.Location = new System.Drawing.Point(754, 179);
            this.tb_giaTriCu.Multiline = true;
            this.tb_giaTriCu.Name = "tb_giaTriCu";
            this.tb_giaTriCu.ReadOnly = true;
            this.tb_giaTriCu.Size = new System.Drawing.Size(180, 60);
            this.tb_giaTriCu.TabIndex = 14;
            this.tb_giaTriCu.Text = "2";
            this.tb_giaTriCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(694, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 36);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tỉ lệ so với đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên hạng vé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng các hạng vé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1023, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá trị mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(783, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá trị cũ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1580, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thay đổi chi tiết số hạng vé";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_home.Location = new System.Drawing.Point(69, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(63, 37);
            this.btn_home.TabIndex = 1;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Location = new System.Drawing.Point(11, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(63, 37);
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FormThayDoiChiTietSoHangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350248398_786598096329880_2111811280162483567_n__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FormThayDoiChiTietSoHangVe";
            this.Text = "FormThayDoiChiTietSoHangVe";
            this.Load += new System.EventHandler(this.FormThayDoiChiTietSoHangVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_danhSachHangVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lv_danhSachHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTiLe;
        private System.Windows.Forms.DataGridViewButtonColumn columnXoa;
        private System.Windows.Forms.Button btn_luuThayDoi;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tb_tiLe;
        private System.Windows.Forms.TextBox tb_tenHangVe;
        private System.Windows.Forms.TextBox tb_giaTriMoi;
        private System.Windows.Forms.TextBox tb_giaTriCu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
    }
}