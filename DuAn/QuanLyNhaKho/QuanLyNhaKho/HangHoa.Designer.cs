namespace QuanLyNhaKho
{
    partial class HangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHanghoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDanhmuc = new System.Windows.Forms.ComboBox();
            this.cmbNhakho = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLuaChonIn = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnHetHan = new System.Windows.Forms.Button();
            this.btnSapHetHan = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTonkho = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenhang
            // 
            this.txtTenhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhang.Location = new System.Drawing.Point(591, 33);
            this.txtTenhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(247, 30);
            this.txtTenhang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Hàng";
            // 
            // dgvHanghoa
            // 
            this.dgvHanghoa.AllowUserToAddRows = false;
            this.dgvHanghoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHanghoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanghoa.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHanghoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHanghoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHanghoa.Location = new System.Drawing.Point(0, 207);
            this.dgvHanghoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHanghoa.Name = "dgvHanghoa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHanghoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHanghoa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHanghoa.RowTemplate.Height = 24;
            this.dgvHanghoa.Size = new System.Drawing.Size(1800, 690);
            this.dgvHanghoa.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHH";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHH";
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Giavon";
            this.Column3.HeaderText = "Giá Vốn";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Soluong";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Dvt";
            this.Column5.HeaderText = "Đơn vị tính";
            this.Column5.Name = "Column5";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Hansudung";
            this.Column9.HeaderText = "Hạn Sử Dụng";
            this.Column9.Name = "Column9";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenDM";
            this.Column6.HeaderText = "Danh Mục";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenNK";
            this.Column7.HeaderText = "Nhà kho";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Mota";
            this.Column8.HeaderText = "Mô tả";
            this.Column8.Name = "Column8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(872, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhà kho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(872, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhóm hàng";
            // 
            // cmbDanhmuc
            // 
            this.cmbDanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDanhmuc.FormattingEnabled = true;
            this.cmbDanhmuc.Location = new System.Drawing.Point(1009, 73);
            this.cmbDanhmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDanhmuc.Name = "cmbDanhmuc";
            this.cmbDanhmuc.Size = new System.Drawing.Size(247, 33);
            this.cmbDanhmuc.TabIndex = 6;
            // 
            // cmbNhakho
            // 
            this.cmbNhakho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhakho.FormattingEnabled = true;
            this.cmbNhakho.Location = new System.Drawing.Point(1009, 31);
            this.cmbNhakho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNhakho.Name = "cmbNhakho";
            this.cmbNhakho.Size = new System.Drawing.Size(247, 33);
            this.cmbNhakho.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lựa chọn in:";
            // 
            // cboLuaChonIn
            // 
            this.cboLuaChonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLuaChonIn.FormattingEnabled = true;
            this.cboLuaChonIn.Location = new System.Drawing.Point(591, 73);
            this.cboLuaChonIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLuaChonIn.Name = "cboLuaChonIn";
            this.cboLuaChonIn.Size = new System.Drawing.Size(247, 33);
            this.cboLuaChonIn.TabIndex = 8;
            this.cboLuaChonIn.SelectedIndexChanged += new System.EventHandler(this.cboLuaChonIn_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnQuaylai);
            this.panel1.Controls.Add(this.cboLuaChonIn);
            this.panel1.Controls.Add(this.btnHetHan);
            this.panel1.Controls.Add(this.cmbNhakho);
            this.panel1.Controls.Add(this.btnSapHetHan);
            this.panel1.Controls.Add(this.cmbDanhmuc);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.btnTonkho);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTenhang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1800, 199);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.Image = global::QuanLyNhaKho.Properties.Resources.icons8_left_26;
            this.btnQuaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuaylai.Location = new System.Drawing.Point(12, 10);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Padding = new System.Windows.Forms.Padding(21, 0, 19, 0);
            this.btnQuaylai.Size = new System.Drawing.Size(164, 50);
            this.btnQuaylai.TabIndex = 7;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnHetHan
            // 
            this.btnHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHetHan.Image = global::QuanLyNhaKho.Properties.Resources.icons8_warning_24;
            this.btnHetHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHetHan.Location = new System.Drawing.Point(429, 133);
            this.btnHetHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHetHan.Name = "btnHetHan";
            this.btnHetHan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHetHan.Size = new System.Drawing.Size(197, 49);
            this.btnHetHan.TabIndex = 0;
            this.btnHetHan.Text = "Hàng Hết Hạn";
            this.btnHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHetHan.UseVisualStyleBackColor = true;
            this.btnHetHan.Click += new System.EventHandler(this.btnHetHan_Click);
            // 
            // btnSapHetHan
            // 
            this.btnSapHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapHetHan.Image = global::QuanLyNhaKho.Properties.Resources.icons8_expired_24;
            this.btnSapHetHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapHetHan.Location = new System.Drawing.Point(635, 133);
            this.btnSapHetHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSapHetHan.Name = "btnSapHetHan";
            this.btnSapHetHan.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSapHetHan.Size = new System.Drawing.Size(236, 49);
            this.btnSapHetHan.TabIndex = 1;
            this.btnSapHetHan.Text = "Hàng Sắp Hết Hạn";
            this.btnSapHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapHetHan.UseVisualStyleBackColor = true;
            this.btnSapHetHan.Click += new System.EventHandler(this.btnSapHetHan_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = global::QuanLyNhaKho.Properties.Resources.icons8_view_24;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(1247, 133);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(28, 0, 20, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(180, 49);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnTonkho
            // 
            this.btnTonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTonkho.Image = global::QuanLyNhaKho.Properties.Resources.icons8_open_box_24;
            this.btnTonkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTonkho.Location = new System.Drawing.Point(879, 133);
            this.btnTonkho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTonkho.Name = "btnTonkho";
            this.btnTonkho.Padding = new System.Windows.Forms.Padding(25, 0, 13, 0);
            this.btnTonkho.Size = new System.Drawing.Size(169, 49);
            this.btnTonkho.TabIndex = 2;
            this.btnTonkho.Text = "Tồn Kho";
            this.btnTonkho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTonkho.UseVisualStyleBackColor = true;
            this.btnTonkho.Click += new System.EventHandler(this.btnTonkho_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::QuanLyNhaKho.Properties.Resources.icons8_print_26;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(1056, 133);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Padding = new System.Windows.Forms.Padding(16, 0, 5, 0);
            this.btnIn.Size = new System.Drawing.Size(183, 49);
            this.btnIn.TabIndex = 0;
            this.btnIn.TabStop = false;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHanghoa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kiểm Kê";
            this.Load += new System.EventHandler(this.HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHanghoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDanhmuc;
        private System.Windows.Forms.ComboBox cmbNhakho;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnSapHetHan;
        private System.Windows.Forms.Button btnHetHan;
        private System.Windows.Forms.Button btnTonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLuaChonIn;
        private System.Windows.Forms.Panel panel1;
    }
}