namespace flightket.Forms_QuanLy
{
    partial class NhapLichChuyenBay_File
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_xacNhan = new System.Windows.Forms.Panel();
            this.lb_fileDaChon = new System.Windows.Forms.LinkLabel();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.llb_chonFile = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_progress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_xacNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel_xacNhan);
            this.panel1.Controls.Add(this.llb_chonFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1823, 482);
            this.panel1.TabIndex = 0;
            // 
            // panel_xacNhan
            // 
            this.panel_xacNhan.Controls.Add(this.lb_fileDaChon);
            this.panel_xacNhan.Controls.Add(this.btn_xacNhan);
            this.panel_xacNhan.Controls.Add(this.label3);
            this.panel_xacNhan.Location = new System.Drawing.Point(259, 251);
            this.panel_xacNhan.Name = "panel_xacNhan";
            this.panel_xacNhan.Size = new System.Drawing.Size(1343, 217);
            this.panel_xacNhan.TabIndex = 21;
            // 
            // lb_fileDaChon
            // 
            this.lb_fileDaChon.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_fileDaChon.BackColor = System.Drawing.Color.Transparent;
            this.lb_fileDaChon.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fileDaChon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_fileDaChon.LinkColor = System.Drawing.Color.Black;
            this.lb_fileDaChon.Location = new System.Drawing.Point(499, 13);
            this.lb_fileDaChon.Name = "lb_fileDaChon";
            this.lb_fileDaChon.Padding = new System.Windows.Forms.Padding(10);
            this.lb_fileDaChon.Size = new System.Drawing.Size(695, 77);
            this.lb_fileDaChon.TabIndex = 23;
            this.lb_fileDaChon.TabStop = true;
            this.lb_fileDaChon.Text = "C://document?fighter/import.csv";
            this.lb_fileDaChon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_xacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xacNhan.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacNhan.Location = new System.Drawing.Point(608, 148);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(132, 43);
            this.btn_xacNhan.TabIndex = 22;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xacNhan.UseVisualStyleBackColor = false;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "File đã chọn :";
            // 
            // llb_chonFile
            // 
            this.llb_chonFile.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.llb_chonFile.BackColor = System.Drawing.Color.Chartreuse;
            this.llb_chonFile.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_chonFile.Image = global::flightket.Properties.Resources.ic_upload;
            this.llb_chonFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llb_chonFile.LinkColor = System.Drawing.Color.Black;
            this.llb_chonFile.Location = new System.Drawing.Point(704, 162);
            this.llb_chonFile.Name = "llb_chonFile";
            this.llb_chonFile.Padding = new System.Windows.Forms.Padding(10);
            this.llb_chonFile.Size = new System.Drawing.Size(455, 77);
            this.llb_chonFile.TabIndex = 20;
            this.llb_chonFile.TabStop = true;
            this.llb_chonFile.Text = "Chọn từ máy tính của bạn";
            this.llb_chonFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llb_chonFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_chonFile_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(834, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chọn file cần nhập";
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = global::flightket.Properties.Resources.ic_home;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(342, 28);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(59, 51);
            this.btn_home.TabIndex = 15;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::flightket.Properties.Resources.ic_back;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(277, 28);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(59, 51);
            this.btn_back.TabIndex = 16;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 64);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhập Lịch Chuyến Bay";
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
            // lb_progress
            // 
            this.lb_progress.BackColor = System.Drawing.Color.Transparent;
            this.lb_progress.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_progress.ForeColor = System.Drawing.Color.Red;
            this.lb_progress.Location = new System.Drawing.Point(1592, 1012);
            this.lb_progress.Name = "lb_progress";
            this.lb_progress.Size = new System.Drawing.Size(269, 35);
            this.lb_progress.TabIndex = 18;
            this.lb_progress.Text = "Tiến Trình";
            this.lb_progress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NhapLichChuyenBay_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350248398_786598096329880_2111811280162483567_n__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lb_progress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapLichChuyenBay_File";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapLichChuyenBay_File";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_xacNhan.ResumeLayout(false);
            this.panel_xacNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel_xacNhan;
        private System.Windows.Forms.LinkLabel lb_fileDaChon;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llb_chonFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_progress;
    }
}