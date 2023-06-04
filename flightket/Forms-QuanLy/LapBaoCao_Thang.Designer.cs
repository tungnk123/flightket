namespace flightket.Forms_QuanLy
{
    partial class LapBaoCao_Thang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_xuatBaoCao = new System.Windows.Forms.LinkLabel();
            this.lb_tongDoanhThu = new System.Windows.Forms.Label();
            this.lv_doanhThu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xemTatCa = new System.Windows.Forms.Button();
            this.btn_xemBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_doanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_xuatBaoCao);
            this.panel1.Controls.Add(this.lb_tongDoanhThu);
            this.panel1.Controls.Add(this.lv_doanhThu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_nam);
            this.panel1.Controls.Add(this.cb_thang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_xemTatCa);
            this.panel1.Controls.Add(this.btn_xemBaoCao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(92, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1701, 849);
            this.panel1.TabIndex = 1;
            // 
            // btn_xuatBaoCao
            // 
            this.btn_xuatBaoCao.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xuatBaoCao.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_xuatBaoCao.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatBaoCao.Image = global::flightket.Properties.Resources.ic_upload;
            this.btn_xuatBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xuatBaoCao.LinkColor = System.Drawing.Color.Black;
            this.btn_xuatBaoCao.Location = new System.Drawing.Point(1173, 758);
            this.btn_xuatBaoCao.Name = "btn_xuatBaoCao";
            this.btn_xuatBaoCao.Padding = new System.Windows.Forms.Padding(10);
            this.btn_xuatBaoCao.Size = new System.Drawing.Size(307, 77);
            this.btn_xuatBaoCao.TabIndex = 29;
            this.btn_xuatBaoCao.TabStop = true;
            this.btn_xuatBaoCao.Text = "Xuất báo cáo";
            this.btn_xuatBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuatBaoCao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_xuatBaoCao_LinkClicked);
            // 
            // lb_tongDoanhThu
            // 
            this.lb_tongDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.lb_tongDoanhThu.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongDoanhThu.Location = new System.Drawing.Point(1224, 705);
            this.lb_tongDoanhThu.Name = "lb_tongDoanhThu";
            this.lb_tongDoanhThu.Size = new System.Drawing.Size(256, 39);
            this.lb_tongDoanhThu.TabIndex = 28;
            this.lb_tongDoanhThu.Text = "100.0000";
            this.lb_tongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lv_doanhThu
            // 
            this.lv_doanhThu.AllowUserToAddRows = false;
            this.lv_doanhThu.AllowUserToDeleteRows = false;
            this.lv_doanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lv_doanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lv_doanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lv_doanhThu.DefaultCellStyle = dataGridViewCellStyle2;
            this.lv_doanhThu.Location = new System.Drawing.Point(187, 396);
            this.lv_doanhThu.Name = "lv_doanhThu";
            this.lv_doanhThu.ReadOnly = true;
            this.lv_doanhThu.RowHeadersVisible = false;
            this.lv_doanhThu.Size = new System.Drawing.Size(1293, 291);
            this.lv_doanhThu.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(953, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 39);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tổng doanh thu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 39);
            this.label5.TabIndex = 26;
            this.label5.Text = "Báo cáo doanh thu theo tháng";
            // 
            // cb_nam
            // 
            this.cb_nam.Font = new System.Drawing.Font("Inter", 20.25F);
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Location = new System.Drawing.Point(803, 207);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(133, 41);
            this.cb_nam.TabIndex = 25;
            this.cb_nam.SelectedIndexChanged += new System.EventHandler(this.cb_nam_SelectedIndexChanged);
            // 
            // cb_thang
            // 
            this.cb_thang.Font = new System.Drawing.Font("Inter", 20.25F);
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(413, 207);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(128, 41);
            this.cb_thang.TabIndex = 24;
            this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(819, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 39);
            this.label4.TabIndex = 23;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "Báo cáo doanh thu theo tháng";
            // 
            // btn_xemTatCa
            // 
            this.btn_xemTatCa.AutoEllipsis = true;
            this.btn_xemTatCa.BackColor = System.Drawing.Color.Lime;
            this.btn_xemTatCa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xemTatCa.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemTatCa.Location = new System.Drawing.Point(1179, 223);
            this.btn_xemTatCa.Name = "btn_xemTatCa";
            this.btn_xemTatCa.Size = new System.Drawing.Size(216, 52);
            this.btn_xemTatCa.TabIndex = 20;
            this.btn_xemTatCa.Text = "Xem Tất Cả";
            this.btn_xemTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_xemTatCa.UseVisualStyleBackColor = false;
            this.btn_xemTatCa.Click += new System.EventHandler(this.btn_xemTatCa_Click);
            // 
            // btn_xemBaoCao
            // 
            this.btn_xemBaoCao.AutoEllipsis = true;
            this.btn_xemBaoCao.BackColor = System.Drawing.Color.Lime;
            this.btn_xemBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xemBaoCao.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemBaoCao.Location = new System.Drawing.Point(1179, 165);
            this.btn_xemBaoCao.Name = "btn_xemBaoCao";
            this.btn_xemBaoCao.Size = new System.Drawing.Size(216, 52);
            this.btn_xemBaoCao.TabIndex = 20;
            this.btn_xemBaoCao.Text = "Xem báo cáo";
            this.btn_xemBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_xemBaoCao.UseVisualStyleBackColor = false;
            this.btn_xemBaoCao.Click += new System.EventHandler(this.btn_xemBaoCao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 64);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lập báo cáo";
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = global::flightket.Properties.Resources.ic_home;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(68, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(59, 51);
            this.btn_home.TabIndex = 9;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::flightket.Properties.Resources.ic_back;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(59, 51);
            this.btn_back.TabIndex = 10;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::flightket.Properties.Resources._2_removebg_preview__1__1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1406, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 126);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LapBaoCao_Thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350248398_786598096329880_2111811280162483567_n__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LapBaoCao_Thang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapBaoCao_Thang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lv_doanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_xemBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.DataGridView lv_doanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_tongDoanhThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel btn_xuatBaoCao;
        private System.Windows.Forms.Button btn_xemTatCa;
    }
}