namespace flightket.Forms_QuanLy
{
    partial class CustomDialogForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.linkLabelTemplate = new System.Windows.Forms.LinkLabel();
            this.lb_codeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(204, 148);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // linkLabelTemplate
            // 
            this.linkLabelTemplate.AutoSize = true;
            this.linkLabelTemplate.Location = new System.Drawing.Point(189, 110);
            this.linkLabelTemplate.Name = "linkLabelTemplate";
            this.linkLabelTemplate.Size = new System.Drawing.Size(106, 13);
            this.linkLabelTemplate.TabIndex = 1;
            this.linkLabelTemplate.TabStop = true;
            this.linkLabelTemplate.Text = "Lưu Mẫu Excel Ngay";
            this.linkLabelTemplate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTemplate_LinkClicked);
            // 
            // lb_codeError
            // 
            this.lb_codeError.Location = new System.Drawing.Point(25, 9);
            this.lb_codeError.Name = "lb_codeError";
            this.lb_codeError.Size = new System.Drawing.Size(435, 73);
            this.lb_codeError.TabIndex = 2;
            this.lb_codeError.Text = "label1";
            // 
            // CustomDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 183);
            this.Controls.Add(this.lb_codeError);
            this.Controls.Add(this.linkLabelTemplate);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.LinkLabel linkLabelTemplate;
        private System.Windows.Forms.Label lb_codeError;
    }
}