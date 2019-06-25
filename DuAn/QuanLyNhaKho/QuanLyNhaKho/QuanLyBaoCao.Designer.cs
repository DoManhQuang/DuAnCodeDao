namespace QuanLyNhaKho
{
    partial class QuanLyBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyBaoCao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnBaoCaoXuat = new System.Windows.Forms.Button();
            this.btnBaoCaoTon = new System.Windows.Forms.Button();
            this.btnBaoCaoNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 715);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.btnBaoCaoXuat);
            this.panel2.Controls.Add(this.btnBaoCaoTon);
            this.panel2.Controls.Add(this.btnBaoCaoNhap);
            this.panel2.Location = new System.Drawing.Point(173, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 382);
            this.panel2.TabIndex = 7;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::QuanLyNhaKho.Properties.Resources.icons8_export_48;
            this.btnDangXuat.Location = new System.Drawing.Point(4, 218);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(281, 140);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Text = "Quay lại";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnBaoCaoXuat
            // 
            this.btnBaoCaoXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoXuat.Image = global::QuanLyNhaKho.Properties.Resources.baocaoxuat;
            this.btnBaoCaoXuat.Location = new System.Drawing.Point(309, 52);
            this.btnBaoCaoXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaoCaoXuat.Name = "btnBaoCaoXuat";
            this.btnBaoCaoXuat.Size = new System.Drawing.Size(287, 143);
            this.btnBaoCaoXuat.TabIndex = 10;
            this.btnBaoCaoXuat.Text = "Báo cáo xuất kho";
            this.btnBaoCaoXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCaoXuat.UseVisualStyleBackColor = true;
            this.btnBaoCaoXuat.Click += new System.EventHandler(this.btnBaoCaoXuat_Click);
            // 
            // btnBaoCaoTon
            // 
            this.btnBaoCaoTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoTon.Image = global::QuanLyNhaKho.Properties.Resources.baocaotonkho;
            this.btnBaoCaoTon.Location = new System.Drawing.Point(3, 52);
            this.btnBaoCaoTon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaoCaoTon.Name = "btnBaoCaoTon";
            this.btnBaoCaoTon.Size = new System.Drawing.Size(279, 143);
            this.btnBaoCaoTon.TabIndex = 11;
            this.btnBaoCaoTon.Text = "Báo cáo nhập xuất tồn";
            this.btnBaoCaoTon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCaoTon.UseVisualStyleBackColor = true;
            this.btnBaoCaoTon.Click += new System.EventHandler(this.btnBaoCaoTon_Click);
            // 
            // btnBaoCaoNhap
            // 
            this.btnBaoCaoNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoNhap.Image")));
            this.btnBaoCaoNhap.Location = new System.Drawing.Point(621, 52);
            this.btnBaoCaoNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaoCaoNhap.Name = "btnBaoCaoNhap";
            this.btnBaoCaoNhap.Size = new System.Drawing.Size(280, 143);
            this.btnBaoCaoNhap.TabIndex = 12;
            this.btnBaoCaoNhap.Text = "Báo cáo nhập kho";
            this.btnBaoCaoNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCaoNhap.UseVisualStyleBackColor = true;
            this.btnBaoCaoNhap.Click += new System.EventHandler(this.btnBaoCaoNhap_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Báo cáo thông kê";
            // 
            // QuanLyBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 649);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo - Kho hàng Thịnh Hưng";
            this.Load += new System.EventHandler(this.QuanLyBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnBaoCaoXuat;
        private System.Windows.Forms.Button btnBaoCaoTon;
        private System.Windows.Forms.Button btnBaoCaoNhap;
        private System.Windows.Forms.Label label1;
    }
}