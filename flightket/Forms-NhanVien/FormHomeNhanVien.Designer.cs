
namespace flightket.Forms_NhanVien
{
    partial class FormHomeNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeNhanVien));
            this.btn_datChoChuyenBay = new System.Windows.Forms.Button();
            this.btn_kiemTraDatCho = new System.Windows.Forms.Button();
            this.btn_traCuuChuyenBay = new System.Windows.Forms.Button();
            this.btn_lapBaoCao = new System.Windows.Forms.Button();
            this.btn_banVe = new System.Windows.Forms.Button();
            this.btn_caiDat = new System.Windows.Forms.Button();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_datChoChuyenBay
            // 
            this.btn_datChoChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datChoChuyenBay.Image = global::flightket.Properties.Resources.icons8_flight_seat_50;
            this.btn_datChoChuyenBay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datChoChuyenBay.Location = new System.Drawing.Point(390, 333);
            this.btn_datChoChuyenBay.Name = "btn_datChoChuyenBay";
            this.btn_datChoChuyenBay.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_datChoChuyenBay.Size = new System.Drawing.Size(446, 103);
            this.btn_datChoChuyenBay.TabIndex = 0;
            this.btn_datChoChuyenBay.Text = "Đặt chỗ chuyến bay";
            this.btn_datChoChuyenBay.UseVisualStyleBackColor = true;
            this.btn_datChoChuyenBay.Click += new System.EventHandler(this.btn_datChoChuyenBay_Click);
            // 
            // btn_kiemTraDatCho
            // 
            this.btn_kiemTraDatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kiemTraDatCho.Image = global::flightket.Properties.Resources.icons8_confirm_50;
            this.btn_kiemTraDatCho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kiemTraDatCho.Location = new System.Drawing.Point(882, 333);
            this.btn_kiemTraDatCho.Name = "btn_kiemTraDatCho";
            this.btn_kiemTraDatCho.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_kiemTraDatCho.Size = new System.Drawing.Size(446, 103);
            this.btn_kiemTraDatCho.TabIndex = 1;
            this.btn_kiemTraDatCho.Text = "Kiểm tra đặt chỗ";
            this.btn_kiemTraDatCho.UseVisualStyleBackColor = true;
            this.btn_kiemTraDatCho.Click += new System.EventHandler(this.btn_kiemTraDatCho_Click);
            // 
            // btn_traCuuChuyenBay
            // 
            this.btn_traCuuChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traCuuChuyenBay.Image = global::flightket.Properties.Resources.icons8_search_50;
            this.btn_traCuuChuyenBay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuuChuyenBay.Location = new System.Drawing.Point(390, 504);
            this.btn_traCuuChuyenBay.Name = "btn_traCuuChuyenBay";
            this.btn_traCuuChuyenBay.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_traCuuChuyenBay.Size = new System.Drawing.Size(446, 103);
            this.btn_traCuuChuyenBay.TabIndex = 2;
            this.btn_traCuuChuyenBay.Text = "Tra cứu chuyến bay";
            this.btn_traCuuChuyenBay.UseVisualStyleBackColor = true;
            this.btn_traCuuChuyenBay.Click += new System.EventHandler(this.btn_traCuuChuyenBay_Click);
            // 
            // btn_lapBaoCao
            // 
            this.btn_lapBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lapBaoCao.Image = global::flightket.Properties.Resources.icons8_report_50;
            this.btn_lapBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lapBaoCao.Location = new System.Drawing.Point(882, 504);
            this.btn_lapBaoCao.Name = "btn_lapBaoCao";
            this.btn_lapBaoCao.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_lapBaoCao.Size = new System.Drawing.Size(446, 103);
            this.btn_lapBaoCao.TabIndex = 3;
            this.btn_lapBaoCao.Text = "Lập báo cáo";
            this.btn_lapBaoCao.UseVisualStyleBackColor = true;
            this.btn_lapBaoCao.Click += new System.EventHandler(this.btn_lapBaoCao_Click);
            // 
            // btn_banVe
            // 
            this.btn_banVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banVe.Image = global::flightket.Properties.Resources.icons8_ticket_50;
            this.btn_banVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banVe.Location = new System.Drawing.Point(1371, 333);
            this.btn_banVe.Name = "btn_banVe";
            this.btn_banVe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_banVe.Size = new System.Drawing.Size(261, 103);
            this.btn_banVe.TabIndex = 4;
            this.btn_banVe.Text = "Bán vé";
            this.btn_banVe.UseVisualStyleBackColor = true;
            this.btn_banVe.Click += new System.EventHandler(this.btn_banVe_Click);
            // 
            // btn_caiDat
            // 
            this.btn_caiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caiDat.Image = global::flightket.Properties.Resources.icons8_settings_50;
            this.btn_caiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caiDat.Location = new System.Drawing.Point(1371, 504);
            this.btn_caiDat.Name = "btn_caiDat";
            this.btn_caiDat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_caiDat.Size = new System.Drawing.Size(261, 103);
            this.btn_caiDat.TabIndex = 5;
            this.btn_caiDat.Text = "Cài đặt";
            this.btn_caiDat.UseVisualStyleBackColor = true;
            this.btn_caiDat.Click += new System.EventHandler(this.btn_caiDat_Click);
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangXuat.Image = global::flightket.Properties.Resources.icons8_log_out_50;
            this.btn_dangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangXuat.Location = new System.Drawing.Point(1578, 831);
            this.btn_dangXuat.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_dangXuat.Size = new System.Drawing.Size(261, 103);
            this.btn_dangXuat.TabIndex = 6;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_dangXuat.UseVisualStyleBackColor = true;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // FormHomeNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flightket.Properties.Resources._350361348_206044632301251_2266599988871672436_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_dangXuat);
            this.Controls.Add(this.btn_caiDat);
            this.Controls.Add(this.btn_banVe);
            this.Controls.Add(this.btn_lapBaoCao);
            this.Controls.Add(this.btn_traCuuChuyenBay);
            this.Controls.Add(this.btn_kiemTraDatCho);
            this.Controls.Add(this.btn_datChoChuyenBay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHomeNhanVien";
            this.Text = " Flightket - Home Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHomeNhanVien_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_datChoChuyenBay;
        private System.Windows.Forms.Button btn_kiemTraDatCho;
        private System.Windows.Forms.Button btn_traCuuChuyenBay;
        private System.Windows.Forms.Button btn_lapBaoCao;
        private System.Windows.Forms.Button btn_banVe;
        private System.Windows.Forms.Button btn_caiDat;
        private System.Windows.Forms.Button btn_dangXuat;
    }
}