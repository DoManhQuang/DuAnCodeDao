namespace QuanLyNhaKho
{
    partial class QuanLyKhoHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnPhieuxuat = new System.Windows.Forms.Button();
            this.btnPhieunhap = new System.Windows.Forms.Button();
            this.btnTondauky = new System.Windows.Forms.Button();
            this.btnKiemKe = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 638);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnBaoCao);
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.btnPhieuxuat);
            this.panel2.Controls.Add(this.btnPhieunhap);
            this.panel2.Controls.Add(this.btnTondauky);
            this.panel2.Controls.Add(this.btnKiemKe);
            this.panel2.Location = new System.Drawing.Point(145, 200);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 382);
            this.panel2.TabIndex = 7;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Image = global::QuanLyNhaKho.Properties.Resources.baocao3;
            this.btnBaoCao.Location = new System.Drawing.Point(4, 218);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(281, 140);
            this.btnBaoCao.TabIndex = 14;
            this.btnBaoCao.Text = "Báo cáo Thông Kê";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::QuanLyNhaKho.Properties.Resources.icons8_export_48;
            this.btnDangXuat.Location = new System.Drawing.Point(621, 218);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(280, 140);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Text = "Quay Lại";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnPhieuxuat
            // 
            this.btnPhieuxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuxuat.Image = global::QuanLyNhaKho.Properties.Resources.xuatkho;
            this.btnPhieuxuat.Location = new System.Drawing.Point(309, 52);
            this.btnPhieuxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhieuxuat.Name = "btnPhieuxuat";
            this.btnPhieuxuat.Size = new System.Drawing.Size(287, 143);
            this.btnPhieuxuat.TabIndex = 10;
            this.btnPhieuxuat.Text = "Quản Lý Xuất Kho";
            this.btnPhieuxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhieuxuat.UseVisualStyleBackColor = true;
            this.btnPhieuxuat.Click += new System.EventHandler(this.btnPhieuxuat_Click);
            // 
            // btnPhieunhap
            // 
            this.btnPhieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieunhap.Image = global::QuanLyNhaKho.Properties.Resources.nhapkho;
            this.btnPhieunhap.Location = new System.Drawing.Point(6, 52);
            this.btnPhieunhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhieunhap.Name = "btnPhieunhap";
            this.btnPhieunhap.Size = new System.Drawing.Size(279, 143);
            this.btnPhieunhap.TabIndex = 11;
            this.btnPhieunhap.Text = "Quản Lý Nhập Kho";
            this.btnPhieunhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhieunhap.UseVisualStyleBackColor = true;
            this.btnPhieunhap.Click += new System.EventHandler(this.btnPhieunhap_Click);
            // 
            // btnTondauky
            // 
            this.btnTondauky.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTondauky.Image = global::QuanLyNhaKho.Properties.Resources.kiemke;
            this.btnTondauky.Location = new System.Drawing.Point(309, 215);
            this.btnTondauky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTondauky.Name = "btnTondauky";
            this.btnTondauky.Size = new System.Drawing.Size(287, 143);
            this.btnTondauky.TabIndex = 12;
            this.btnTondauky.Text = "Tồn Đầu Kỳ";
            this.btnTondauky.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTondauky.UseVisualStyleBackColor = true;
            this.btnTondauky.Click += new System.EventHandler(this.btnTondauky_Click);
            // 
            // btnKiemKe
            // 
            this.btnKiemKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemKe.Image = global::QuanLyNhaKho.Properties.Resources.kiemke;
            this.btnKiemKe.Location = new System.Drawing.Point(621, 52);
            this.btnKiemKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiemKe.Name = "btnKiemKe";
            this.btnKiemKe.Size = new System.Drawing.Size(280, 143);
            this.btnKiemKe.TabIndex = 12;
            this.btnKiemKe.Text = "Quản Lý Kiểm Kê";
            this.btnKiemKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKiemKe.UseVisualStyleBackColor = true;
            this.btnKiemKe.Click += new System.EventHandler(this.btnKiemKe_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Kho Hàng";
            // 
            // QuanLyKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 662);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho hàng";
            this.Load += new System.EventHandler(this.QuanLyKhoHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPhieuxuat;
        private System.Windows.Forms.Button btnPhieunhap;
        private System.Windows.Forms.Button btnKiemKe;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTondauky;

    }
}