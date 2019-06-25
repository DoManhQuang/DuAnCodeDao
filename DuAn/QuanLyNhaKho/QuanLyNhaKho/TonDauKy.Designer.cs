namespace QuanLyNhaKho
{
    partial class TonDauKy
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
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.cmbNhakho = new System.Windows.Forms.ComboBox();
            this.btnTonkho = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpThoigian = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTondauky = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTondauky)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Image = global::QuanLyNhaKho.Properties.Resources.icons8_left_26;
            this.btnQuaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuaylai.Location = new System.Drawing.Point(12, 10);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Padding = new System.Windows.Forms.Padding(22, 0, 18, 0);
            this.btnQuaylai.Size = new System.Drawing.Size(138, 37);
            this.btnQuaylai.TabIndex = 7;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // cmbNhakho
            // 
            this.cmbNhakho.FormattingEnabled = true;
            this.cmbNhakho.Location = new System.Drawing.Point(334, 15);
            this.cmbNhakho.Name = "cmbNhakho";
            this.cmbNhakho.Size = new System.Drawing.Size(247, 24);
            this.cmbNhakho.TabIndex = 5;
            // 
            // btnTonkho
            // 
            this.btnTonkho.Image = global::QuanLyNhaKho.Properties.Resources.icons8_open_box_24;
            this.btnTonkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTonkho.Location = new System.Drawing.Point(630, 107);
            this.btnTonkho.Name = "btnTonkho";
            this.btnTonkho.Padding = new System.Windows.Forms.Padding(25, 0, 14, 0);
            this.btnTonkho.Size = new System.Drawing.Size(171, 37);
            this.btnTonkho.TabIndex = 2;
            this.btnTonkho.Text = "Tồn Đầu Kỳ";
            this.btnTonkho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTonkho.UseVisualStyleBackColor = true;
            this.btnTonkho.Click += new System.EventHandler(this.btnTonkho_Click);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Mota";
            this.Column8.HeaderText = "Mô tả";
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenDM";
            this.Column6.HeaderText = "Danh Mục";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Hansudung";
            this.Column9.HeaderText = "Hạn Sử Dụng";
            this.Column9.Name = "Column9";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Dvt";
            this.Column5.HeaderText = "Đơn vị tính";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Soluong";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Giavon";
            this.Column3.HeaderText = "Giá Vốn";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHH";
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHH";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtpThoigian);
            this.panel1.Controls.Add(this.btnQuaylai);
            this.panel1.Controls.Add(this.cmbNhakho);
            this.panel1.Controls.Add(this.btnTonkho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 199);
            this.panel1.TabIndex = 11;
            // 
            // dtpThoigian
            // 
            this.dtpThoigian.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoigian.Location = new System.Drawing.Point(768, 16);
            this.dtpThoigian.Name = "dtpThoigian";
            this.dtpThoigian.Size = new System.Drawing.Size(225, 27);
            this.dtpThoigian.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời Gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhà kho";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenNK";
            this.Column7.HeaderText = "Nhà kho";
            this.Column7.Name = "Column7";
            // 
            // dgvTondauky
            // 
            this.dgvTondauky.AllowUserToAddRows = false;
            this.dgvTondauky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTondauky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTondauky.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvTondauky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTondauky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvTondauky.Location = new System.Drawing.Point(0, 214);
            this.dgvTondauky.Name = "dgvTondauky";
            this.dgvTondauky.RowTemplate.Height = 24;
            this.dgvTondauky.Size = new System.Drawing.Size(1054, 312);
            this.dgvTondauky.TabIndex = 10;
            // 
            // TonDauKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTondauky);
            this.Name = "TonDauKy";
            this.Text = "Tồn Đầu Kỳ";
            this.Load += new System.EventHandler(this.TonDauKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTondauky)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.ComboBox cmbNhakho;
        private System.Windows.Forms.Button btnTonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpThoigian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dgvTondauky;
    }
}