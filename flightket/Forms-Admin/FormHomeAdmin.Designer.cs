
namespace flightket.Forms_Admin
{
    partial class FormHomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeAdmin));
            this.btn_taoNhomNguoiDung = new System.Windows.Forms.Button();
            this.btn_quanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btn_phanQuyen = new System.Windows.Forms.Button();
            this.btn_caiDat = new System.Windows.Forms.Button();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_taoNhomNguoiDung
            // 
            this.btn_taoNhomNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taoNhomNguoiDung.Image = global::flightket.Properties.Resources.icons8_add_male_user_group_50;
            this.btn_taoNhomNguoiDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taoNhomNguoiDung.Location = new System.Drawing.Point(597, 323);
            this.btn_taoNhomNguoiDung.Name = "btn_taoNhomNguoiDung";
            this.btn_taoNhomNguoiDung.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_taoNhomNguoiDung.Size = new System.Drawing.Size(446, 100);
            this.btn_taoNhomNguoiDung.TabIndex = 0;
            this.btn_taoNhomNguoiDung.Text = "Tạo nhóm người dùng";
            this.btn_taoNhomNguoiDung.UseVisualStyleBackColor = true;
            this.btn_taoNhomNguoiDung.Click += new System.EventHandler(this.btn_taoNhomNguoiDung_Click);
            // 
            // btn_quanLyTaiKhoan
            // 
            this.btn_quanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLyTaiKhoan.Image = global::flightket.Properties.Resources.icons8_account_66;
            this.btn_quanLyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quanLyTaiKhoan.Location = new System.Drawing.Point(1113, 323);
            this.btn_quanLyTaiKhoan.Name = "btn_quanLyTaiKhoan";
            this.btn_quanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_quanLyTaiKhoan.Size = new System.Drawing.Size(446, 100);
            this.btn_quanLyTaiKhoan.TabIndex = 1;
            this.btn_quanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btn_quanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_quanLyTaiKhoan.Click += new System.EventHandler(this.btn_quanLyTaiKhoan_Click);
            // 
            // btn_phanQuyen
            // 
            this.btn_phanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phanQuyen.Image = global::flightket.Properties.Resources.permission;
            this.btn_phanQuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_phanQuyen.Location = new System.Drawing.Point(651, 499);
            this.btn_phanQuyen.Name = "btn_phanQuyen";
            this.btn_phanQuyen.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_phanQuyen.Size = new System.Drawing.Size(392, 100);
            this.btn_phanQuyen.TabIndex = 2;
            this.btn_phanQuyen.Text = "Phân quyền";
            this.btn_phanQuyen.UseVisualStyleBackColor = true;
            this.btn_phanQuyen.Click += new System.EventHandler(this.btn_phanQuyen_Click);
            // 
            // btn_caiDat
            // 
            this.btn_caiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caiDat.Image = global::flightket.Properties.Resources.icons8_settings_50;
            this.btn_caiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caiDat.Location = new System.Drawing.Point(1113, 499);
            this.btn_caiDat.Name = "btn_caiDat";
            this.btn_caiDat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_caiDat.Size = new System.Drawing.Size(392, 100);
            this.btn_caiDat.TabIndex = 3;
            this.btn_caiDat.Text = "Cài đặt";
            this.btn_caiDat.UseVisualStyleBackColor = true;
            this.btn_caiDat.Click += new System.EventHandler(this.btn_caiDat_Click);
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btn_dangXuat.Image = global::flightket.Properties.Resources.icons8_log_out_50;
            this.btn_dangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangXuat.Location = new System.Drawing.Point(1487, 834);
            this.btn_dangXuat.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_dangXuat.Size = new System.Drawing.Size(261, 103);
            this.btn_dangXuat.TabIndex = 7;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_dangXuat.UseVisualStyleBackColor = true;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // FormHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350248398_786598096329880_2111811280162483567_n__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_dangXuat);
            this.Controls.Add(this.btn_caiDat);
            this.Controls.Add(this.btn_phanQuyen);
            this.Controls.Add(this.btn_quanLyTaiKhoan);
            this.Controls.Add(this.btn_taoNhomNguoiDung);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHomeAdmin";
            this.Text = "Flightket - Home Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHomeAdmin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_taoNhomNguoiDung;
        private System.Windows.Forms.Button btn_quanLyTaiKhoan;
        private System.Windows.Forms.Button btn_phanQuyen;
        private System.Windows.Forms.Button btn_caiDat;
        private System.Windows.Forms.Button btn_dangXuat;
    }
}