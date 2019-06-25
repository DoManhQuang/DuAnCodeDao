namespace QuanLyNhaKho
{
    partial class KhoHang
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
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.AllowUserToAddRows = false;
            this.dgvKhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvKhoHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhoHang.Location = new System.Drawing.Point(0, 179);
            this.dgvKhoHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.RowTemplate.Height = 24;
            this.dgvKhoHang.Size = new System.Drawing.Size(600, 187);
            this.dgvKhoHang.TabIndex = 12;
            this.dgvKhoHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNK";
            this.Column1.HeaderText = "Mã Nhà Kho";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNK";
            this.Column2.HeaderText = "Tên Nhà Kho";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Diachi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(440, 25);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(136, 20);
            this.txtDiachi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtTenNK
            // 
            this.txtTenNK.Location = new System.Drawing.Point(146, 24);
            this.txtTenNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNK.Name = "txtTenNK";
            this.txtTenNK.Size = new System.Drawing.Size(130, 20);
            this.txtTenNK.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Nhà Kho";
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyNhaKho.Properties.Resources.icons8_left_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(472, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Quay Lại";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyNhaKho.Properties.Resources.icons8_view_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(366, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Tìm Kiếm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyNhaKho.Properties.Resources.icons8_close_window_24;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(262, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(19, 0, 14, 0);
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Xóa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button4
            // 
            this.button4.Image = global::QuanLyNhaKho.Properties.Resources.icons8_edit_24;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(157, 102);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(15, 0, 14, 0);
            this.button4.Size = new System.Drawing.Size(88, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "Sửa";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button5
            // 
            this.button5.Image = global::QuanLyNhaKho.Properties.Resources.icons8_plus_24;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(54, 102);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(15, 0, 11, 0);
            this.button5.Size = new System.Drawing.Size(89, 34);
            this.button5.TabIndex = 22;
            this.button5.Text = "Thêm";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvKhoHang);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNK);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhoHang";
            this.Load += new System.EventHandler(this.KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}