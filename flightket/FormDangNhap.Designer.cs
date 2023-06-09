
namespace flightket
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_hienMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_quenMatKhau = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.cb_hienMatKhau);
            this.panel1.Controls.Add(this.btn_dangNhap);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.lb_quenMatKhau);
            this.panel1.Controls.Add(this.lb_password);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Location = new System.Drawing.Point(742, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 458);
            this.panel1.TabIndex = 1;
            // 
            // cb_hienMatKhau
            // 
            this.cb_hienMatKhau.AutoSize = true;
            this.cb_hienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.cb_hienMatKhau.Location = new System.Drawing.Point(45, 278);
            this.cb_hienMatKhau.Name = "cb_hienMatKhau";
            this.cb_hienMatKhau.Size = new System.Drawing.Size(121, 21);
            this.cb_hienMatKhau.TabIndex = 7;
            this.cb_hienMatKhau.Text = "Hiện mật khẩu";
            this.cb_hienMatKhau.UseVisualStyleBackColor = false;
            this.cb_hienMatKhau.CheckedChanged += new System.EventHandler(this.cb_hienMatKhau_CheckedChanged);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.Location = new System.Drawing.Point(127, 330);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(219, 55);
            this.btn_dangNhap.TabIndex = 6;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.LightGray;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(45, 218);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(378, 38);
            this.tb_password.TabIndex = 4;
            // 
            // lb_quenMatKhau
            // 
            this.lb_quenMatKhau.AutoSize = true;
            this.lb_quenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_quenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quenMatKhau.ForeColor = System.Drawing.Color.Black;
            this.lb_quenMatKhau.Location = new System.Drawing.Point(168, 415);
            this.lb_quenMatKhau.Name = "lb_quenMatKhau";
            this.lb_quenMatKhau.Size = new System.Drawing.Size(131, 20);
            this.lb_quenMatKhau.TabIndex = 5;
            this.lb_quenMatKhau.Text = "Quên mật khẩu?";
            this.lb_quenMatKhau.Click += new System.EventHandler(this.lb_quenMatKhau_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(40, 179);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(104, 27);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Mật khẩu";
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(151, 29);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(167, 34);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Đăng nhập";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.LightGray;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(45, 107);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(378, 38);
            this.tb_username.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(40, 77);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(154, 27);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tên đăng nhập";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::flightket.Properties.Resources._350248398_786598096329880_2111811280162483567_n__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flightket - Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormDangNhap_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Label lb_quenMatKhau;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.CheckBox cb_hienMatKhau;
    }
}

