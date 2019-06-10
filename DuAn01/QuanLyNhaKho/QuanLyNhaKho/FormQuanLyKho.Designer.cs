namespace QuanLyNhaKho
{
    partial class FormQuanLyKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKiemKe = new System.Windows.Forms.Button();
            this.btnPhieunhap = new System.Windows.Forms.Button();
            this.btnPhieuxuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Kho Hàng Hóa";
            // 
            // btnKiemKe
            // 
            this.btnKiemKe.Location = new System.Drawing.Point(554, 256);
            this.btnKiemKe.Name = "btnKiemKe";
            this.btnKiemKe.Size = new System.Drawing.Size(175, 58);
            this.btnKiemKe.TabIndex = 1;
            this.btnKiemKe.Text = "Kiểm Kê Hàng Hóa";
            this.btnKiemKe.UseVisualStyleBackColor = true;
            this.btnKiemKe.Click += new System.EventHandler(this.btnKiemKe_Click);
            // 
            // btnPhieunhap
            // 
            this.btnPhieunhap.Location = new System.Drawing.Point(59, 256);
            this.btnPhieunhap.Name = "btnPhieunhap";
            this.btnPhieunhap.Size = new System.Drawing.Size(175, 58);
            this.btnPhieunhap.TabIndex = 1;
            this.btnPhieunhap.Text = "Quản Lý Phiếu Nhập";
            this.btnPhieunhap.UseVisualStyleBackColor = true;
            // 
            // btnPhieuxuat
            // 
            this.btnPhieuxuat.Location = new System.Drawing.Point(307, 256);
            this.btnPhieuxuat.Name = "btnPhieuxuat";
            this.btnPhieuxuat.Size = new System.Drawing.Size(175, 58);
            this.btnPhieuxuat.TabIndex = 1;
            this.btnPhieuxuat.Text = "Quản Lý Phiếu Xuất";
            this.btnPhieuxuat.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 430);
            this.Controls.Add(this.btnPhieuxuat);
            this.Controls.Add(this.btnPhieunhap);
            this.Controls.Add(this.btnKiemKe);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyKho";
            this.Text = "FormQuanLyKho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKiemKe;
        private System.Windows.Forms.Button btnPhieunhap;
        private System.Windows.Forms.Button btnPhieuxuat;
    }
}