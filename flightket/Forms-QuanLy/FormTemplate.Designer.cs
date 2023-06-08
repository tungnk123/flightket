
namespace flightket.Forms_QuanLy
{
    partial class FormTemplate
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llb_chonFile = new System.Windows.Forms.LinkLabel();
            this.panel_xacNhan = new System.Windows.Forms.Panel();
            this.lb_fileDaChon = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_xacNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_xacNhan);
            this.panel1.Controls.Add(this.panel_xacNhan);
            this.panel1.Controls.Add(this.llb_chonFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_title1);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(71, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 900);
            this.panel1.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 70);
            this.btn_back.TabIndex = 23;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(79, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(70, 70);
            this.btn_home.TabIndex = 24;
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // lb_title1
            // 
            this.lb_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title1.AutoSize = true;
            this.lb_title1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Location = new System.Drawing.Point(593, 28);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(617, 69);
            this.lb_title1.TabIndex = 27;
            this.lb_title1.Text = "Nhập lịch chuyến bay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(803, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chọn file cần nhập";
            // 
            // llb_chonFile
            // 
            this.llb_chonFile.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.llb_chonFile.BackColor = System.Drawing.Color.Chartreuse;
            this.llb_chonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_chonFile.Image = global::flightket.Properties.Resources.ic_upload;
            this.llb_chonFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llb_chonFile.LinkColor = System.Drawing.Color.Black;
            this.llb_chonFile.Location = new System.Drawing.Point(613, 230);
            this.llb_chonFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_chonFile.Name = "llb_chonFile";
            this.llb_chonFile.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.llb_chonFile.Size = new System.Drawing.Size(606, 94);
            this.llb_chonFile.TabIndex = 34;
            this.llb_chonFile.TabStop = true;
            this.llb_chonFile.Text = "Chọn từ máy tính của bạn";
            this.llb_chonFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_xacNhan
            // 
            this.panel_xacNhan.Controls.Add(this.lb_fileDaChon);
            this.panel_xacNhan.Controls.Add(this.label3);
            this.panel_xacNhan.Location = new System.Drawing.Point(131, 376);
            this.panel_xacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.panel_xacNhan.Name = "panel_xacNhan";
            this.panel_xacNhan.Size = new System.Drawing.Size(1512, 145);
            this.panel_xacNhan.TabIndex = 22;
            // 
            // lb_fileDaChon
            // 
            this.lb_fileDaChon.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_fileDaChon.BackColor = System.Drawing.Color.Transparent;
            this.lb_fileDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fileDaChon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_fileDaChon.LinkColor = System.Drawing.Color.Black;
            this.lb_fileDaChon.Location = new System.Drawing.Point(665, 16);
            this.lb_fileDaChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fileDaChon.Name = "lb_fileDaChon";
            this.lb_fileDaChon.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lb_fileDaChon.Size = new System.Drawing.Size(926, 94);
            this.lb_fileDaChon.TabIndex = 23;
            this.lb_fileDaChon.TabStop = true;
            this.lb_fileDaChon.Text = "C://document?fighter/import.csv";
            this.lb_fileDaChon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 42);
            this.label3.TabIndex = 21;
            this.label3.Text = "File đã chọn :";
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btn_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacNhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xacNhan.Location = new System.Drawing.Point(774, 572);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(230, 65);
            this.btn_xacNhan.TabIndex = 24;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = false;
            // 
            // FormTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Name = "FormTemplate";
            this.Text = "FormTemplate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_xacNhan.ResumeLayout(false);
            this.panel_xacNhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llb_chonFile;
        private System.Windows.Forms.Panel panel_xacNhan;
        private System.Windows.Forms.LinkLabel lb_fileDaChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_xacNhan;
    }
}