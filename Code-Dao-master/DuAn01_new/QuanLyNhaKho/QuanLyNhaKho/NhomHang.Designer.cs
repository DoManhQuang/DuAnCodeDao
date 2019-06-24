namespace QuanLyNhaKho
{
    partial class NhomHang
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
            this.dgvNhomHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhomHang
            // 
            this.dgvNhomHang.AllowUserToAddRows = false;
            this.dgvNhomHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvNhomHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhomHang.Location = new System.Drawing.Point(0, 179);
            this.dgvNhomHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhomHang.Name = "dgvNhomHang";
            this.dgvNhomHang.RowTemplate.Height = 24;
            this.dgvNhomHang.Size = new System.Drawing.Size(600, 187);
            this.dgvNhomHang.TabIndex = 22;
            this.dgvNhomHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDM";
            this.Column1.HeaderText = "Mã Nhóm Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDM";
            this.Column2.HeaderText = "Tên Nhóm Hàng";
            this.Column2.Name = "Column2";
            // 
            // txtTenNH
            // 
            this.txtTenNH.Location = new System.Drawing.Point(272, 41);
            this.txtTenNH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.Size = new System.Drawing.Size(156, 20);
            this.txtTenNH.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Nhóm Hàng";
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Image = global::QuanLyNhaKho.Properties.Resources.icons8_left_26;
            this.btnQuaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuaylai.Location = new System.Drawing.Point(473, 95);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQuaylai.Size = new System.Drawing.Size(88, 34);
            this.btnQuaylai.TabIndex = 23;
            this.btnQuaylai.Text = "Quay Lại";
            this.btnQuaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::QuanLyNhaKho.Properties.Resources.icons8_view_24;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(368, 95);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(90, 34);
            this.btnTimkiem.TabIndex = 24;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyNhaKho.Properties.Resources.icons8_close_window_24;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(263, 95);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(19, 0, 14, 0);
            this.btnXoa.Size = new System.Drawing.Size(87, 34);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyNhaKho.Properties.Resources.icons8_edit_24;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(162, 95);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(15, 0, 11, 0);
            this.btnSua.Size = new System.Drawing.Size(82, 34);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyNhaKho.Properties.Resources.icons8_plus_24;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(49, 95);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(15, 0, 8, 0);
            this.btnThem.Size = new System.Drawing.Size(89, 34);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // NhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNhomHang);
            this.Controls.Add(this.txtTenNH);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhóm Hàng";
            this.Load += new System.EventHandler(this.NhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhomHang;
        private System.Windows.Forms.TextBox txtTenNH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}