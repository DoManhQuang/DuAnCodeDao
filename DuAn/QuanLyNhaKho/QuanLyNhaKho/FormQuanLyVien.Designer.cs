namespace QuanLyNhaKho
{
    partial class FormQuanLyVien
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
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLNCC = new System.Windows.Forms.Button();
            this.btnQLNH = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Danh Mục";
            // 
            // btnQLKH
            // 
            this.btnQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.Image = global::QuanLyNhaKho.Properties.Resources.nhanvien;
            this.btnQLKH.Location = new System.Drawing.Point(432, 512);
            this.btnQLKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(288, 154);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Text = "Quản Lý Khách Hàng";
            this.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLNCC
            // 
            this.btnQLNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNCC.Image = global::QuanLyNhaKho.Properties.Resources.icons8_supplier_53;
            this.btnQLNCC.Location = new System.Drawing.Point(1095, 326);
            this.btnQLNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLNCC.Name = "btnQLNCC";
            this.btnQLNCC.Size = new System.Drawing.Size(303, 151);
            this.btnQLNCC.TabIndex = 1;
            this.btnQLNCC.Text = "Quản Lý Nhà Cung Cấp";
            this.btnQLNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLNCC.UseVisualStyleBackColor = true;
            this.btnQLNCC.Click += new System.EventHandler(this.btnQLNCC_Click);
            // 
            // btnQLNH
            // 
            this.btnQLNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNH.Image = global::QuanLyNhaKho.Properties.Resources.sanpham;
            this.btnQLNH.Location = new System.Drawing.Point(756, 512);
            this.btnQLNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLNH.Name = "btnQLNH";
            this.btnQLNH.Size = new System.Drawing.Size(301, 154);
            this.btnQLNH.TabIndex = 1;
            this.btnQLNH.Text = "Quản Lý Nhóm Hàng";
            this.btnQLNH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLNH.UseVisualStyleBackColor = true;
            this.btnQLNH.Click += new System.EventHandler(this.btnQLNH_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoHang.Image = global::QuanLyNhaKho.Properties.Resources.nhakho;
            this.btnKhoHang.Location = new System.Drawing.Point(756, 326);
            this.btnKhoHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(301, 151);
            this.btnKhoHang.TabIndex = 1;
            this.btnKhoHang.Text = "Quản Lý Kho Hàng";
            this.btnKhoHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKhoHang.UseVisualStyleBackColor = true;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.Image = global::QuanLyNhaKho.Properties.Resources.kh;
            this.btnQLNV.Location = new System.Drawing.Point(432, 326);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(288, 151);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::QuanLyNhaKho.Properties.Resources.icons8_export_48;
            this.btnDangXuat.Location = new System.Drawing.Point(1095, 512);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(303, 154);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Quay Lại";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // FormQuanLyVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQLNCC);
            this.Controls.Add(this.btnQLNH);
            this.Controls.Add(this.btnKhoHang);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuanLyVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho hàng Thịnh Hưng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button btnQLNH;
        private System.Windows.Forms.Button btnQLNCC;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnDangXuat;
    }
}