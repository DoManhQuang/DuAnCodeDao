﻿namespace QuanLyNhaKho
{
    partial class QuenMatKhau
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatkhau1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatkhau2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapnhap = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(235, 76);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(143, 20);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(235, 116);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(143, 20);
            this.txtTaikhoan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMatkhau1
            // 
            this.txtMatkhau1.Location = new System.Drawing.Point(235, 156);
            this.txtMatkhau1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatkhau1.Name = "txtMatkhau1";
            this.txtMatkhau1.PasswordChar = '*';
            this.txtMatkhau1.Size = new System.Drawing.Size(143, 20);
            this.txtMatkhau1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // txtMatkhau2
            // 
            this.txtMatkhau2.Location = new System.Drawing.Point(235, 195);
            this.txtMatkhau2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatkhau2.Name = "txtMatkhau2";
            this.txtMatkhau2.PasswordChar = '*';
            this.txtMatkhau2.Size = new System.Drawing.Size(143, 20);
            this.txtMatkhau2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đổi mật khẩu";
            // 
            // btnCapnhap
            // 
            this.btnCapnhap.Image = global::QuanLyNhaKho.Properties.Resources.icons8_save_close_24;
            this.btnCapnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhap.Location = new System.Drawing.Point(95, 272);
            this.btnCapnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.btnCapnhap.Size = new System.Drawing.Size(100, 32);
            this.btnCapnhap.TabIndex = 2;
            this.btnCapnhap.Text = "Cập Nhập";
            this.btnCapnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapnhap.UseVisualStyleBackColor = true;
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapnhap_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Image = global::QuanLyNhaKho.Properties.Resources.icons8_left_26;
            this.btnQuaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuaylai.Location = new System.Drawing.Point(285, 272);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Padding = new System.Windows.Forms.Padding(11, 0, 8, 0);
            this.btnQuaylai.Size = new System.Drawing.Size(98, 32);
            this.btnQuaylai.TabIndex = 2;
            this.btnQuaylai.Text = "Quay Lại";
            this.btnQuaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // QuenMatKhau
            // 
            this.AcceptButton = this.btnCapnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnCapnhap);
            this.Controls.Add(this.txtMatkhau2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.txtMatkhau1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCapnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatkhau1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatkhau2;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Label label5;
    }
}