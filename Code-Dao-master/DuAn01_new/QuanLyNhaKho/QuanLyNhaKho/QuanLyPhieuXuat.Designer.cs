namespace QuanLyNhaKho
{
    partial class QuanLyPhieuXuat
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLapPhieuXuat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieuXuat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPhieuXuat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLapPhieuXuat);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 47);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::QuanLyNhaKho.Properties.Resources.icons8_left_26;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(7, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(452, 12);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(184, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // btnTim
            // 
            this.btnTim.Image = global::QuanLyNhaKho.Properties.Resources.icons8_search_16;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(640, 9);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(22, 0, 18, 0);
            this.btnTim.Size = new System.Drawing.Size(89, 24);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::QuanLyNhaKho.Properties.Resources.icons8_print_26;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnIn.Location = new System.Drawing.Point(282, 7);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Padding = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.btnIn.Size = new System.Drawing.Size(89, 28);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyNhaKho.Properties.Resources.icons8_synchronize_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(190, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 2, 0);
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Làm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLapPhieuXuat
            // 
            this.btnLapPhieuXuat.Image = global::QuanLyNhaKho.Properties.Resources.icons8_plus_24;
            this.btnLapPhieuXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapPhieuXuat.Location = new System.Drawing.Point(89, 7);
            this.btnLapPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnLapPhieuXuat.Name = "btnLapPhieuXuat";
            this.btnLapPhieuXuat.Padding = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.btnLapPhieuXuat.Size = new System.Drawing.Size(94, 28);
            this.btnLapPhieuXuat.TabIndex = 0;
            this.btnLapPhieuXuat.Text = "Tạo phiếu";
            this.btnLapPhieuXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapPhieuXuat.UseVisualStyleBackColor = true;
            this.btnLapPhieuXuat.Click += new System.EventHandler(this.btnLapPhieuXuat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvChiTietPhieuXuat);
            this.groupBox2.Location = new System.Drawing.Point(2, 276);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(932, 241);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hàng xuất";
            // 
            // dgvChiTietPhieuXuat
            // 
            this.dgvChiTietPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuXuat.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuXuat.Location = new System.Drawing.Point(5, 18);
            this.dgvChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat";
            this.dgvChiTietPhieuXuat.RowTemplate.Height = 24;
            this.dgvChiTietPhieuXuat.Size = new System.Drawing.Size(927, 219);
            this.dgvChiTietPhieuXuat.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDanhSachPhieuXuat);
            this.groupBox1.Location = new System.Drawing.Point(2, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(932, 269);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu xuất";
            // 
            // dgvDanhSachPhieuXuat
            // 
            this.dgvDanhSachPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuXuat.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuXuat.Location = new System.Drawing.Point(4, 17);
            this.dgvDanhSachPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachPhieuXuat.Name = "dgvDanhSachPhieuXuat";
            this.dgvDanhSachPhieuXuat.RowTemplate.Height = 24;
            this.dgvDanhSachPhieuXuat.Size = new System.Drawing.Size(927, 201);
            this.dgvDanhSachPhieuXuat.TabIndex = 0;
            this.dgvDanhSachPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhieuXuat_CellClick);
            // 
            // QuanLyPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu xuất";
            this.Load += new System.EventHandler(this.QuanLyPhieuXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLapPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuXuat;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}