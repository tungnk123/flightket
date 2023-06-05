
namespace flightket.Forms_NhanVien
{
    partial class FormNhapThongTinKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapThongTinKhachHang));
            this.SuspendLayout();
            // 
            // FormNhapThongTinKhachHang
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_baoCaoNam = new System.Windows.Forms.Button();
            this.btn_baoCaoThang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_baoCaoNam);
            this.panel1.Controls.Add(this.btn_baoCaoThang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(117, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1701, 515);
            this.panel1.TabIndex = 0;
            // 
            // btn_baoCaoNam
            // 
            this.btn_baoCaoNam.AutoEllipsis = true;
            this.btn_baoCaoNam.BackColor = System.Drawing.Color.Cyan;
            this.btn_baoCaoNam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_baoCaoNam.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baoCaoNam.Location = new System.Drawing.Point(871, 179);
            this.btn_baoCaoNam.Name = "btn_baoCaoNam";
            this.btn_baoCaoNam.Size = new System.Drawing.Size(216, 141);
            this.btn_baoCaoNam.TabIndex = 20;
            this.btn_baoCaoNam.Text = "Báo cáo doanh thu theo năm";
            this.btn_baoCaoNam.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_baoCaoNam.UseVisualStyleBackColor = false;
            this.btn_baoCaoNam.Click += new System.EventHandler(this.btn_baoCaoNam_Click);
            // 
            // btn_baoCaoThang
            // 
            this.btn_baoCaoThang.AutoEllipsis = true;
            this.btn_baoCaoThang.BackColor = System.Drawing.Color.Lime;
            this.btn_baoCaoThang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_baoCaoThang.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baoCaoThang.Location = new System.Drawing.Point(573, 179);
            this.btn_baoCaoThang.Name = "btn_baoCaoThang";
            this.btn_baoCaoThang.Size = new System.Drawing.Size(216, 141);
            this.btn_baoCaoThang.TabIndex = 20;
            this.btn_baoCaoThang.Text = "Báo cáo doanh thu theo tháng";
            this.btn_baoCaoThang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_baoCaoThang.UseVisualStyleBackColor = false;
            this.btn_baoCaoThang.Click += new System.EventHandler(this.btn_baoCaoThang_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(1406, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 126);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LapBaoCao_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350248398_786598096329880_2111811280162483567_n__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "LapBaoCao_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapBaoCao_Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_baoCaoNam;
        private System.Windows.Forms.Button btn_baoCaoThang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}