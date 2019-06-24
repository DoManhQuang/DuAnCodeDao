namespace QuanLyNhaKho
{
    partial class Giaodiennguoidung
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
            this.btnQLDM = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnBH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQLDM
            // 
            this.btnQLDM.Location = new System.Drawing.Point(48, 208);
            this.btnQLDM.Name = "btnQLDM";
            this.btnQLDM.Size = new System.Drawing.Size(230, 98);
            this.btnQLDM.TabIndex = 0;
            this.btnQLDM.Text = "QUẢN LÝ DANH MỤC";
            this.btnQLDM.UseVisualStyleBackColor = true;
            this.btnQLDM.Click += new System.EventHandler(this.btnQLDM_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(392, 208);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(230, 98);
            this.btnQLKH.TabIndex = 0;
            this.btnQLKH.Text = "QUẢN LÝ KHO HÀNG";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnBH
            // 
            this.btnBH.Location = new System.Drawing.Point(724, 208);
            this.btnBH.Name = "btnBH";
            this.btnBH.Size = new System.Drawing.Size(230, 98);
            this.btnBH.TabIndex = 0;
            this.btnBH.Text = "BÁN HÀNG";
            this.btnBH.UseVisualStyleBackColor = true;
            this.btnBH.Click += new System.EventHandler(this.btnBH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ NHÀ KHO";
            // 
            // Giaodiennguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBH);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQLDM);
            this.Name = "Giaodiennguoidung";
            this.Text = "Giao Diện Người Dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLDM;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnBH;
        private System.Windows.Forms.Label label1;
    }
}