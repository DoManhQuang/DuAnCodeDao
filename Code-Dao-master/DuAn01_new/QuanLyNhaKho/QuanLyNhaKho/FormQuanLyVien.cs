using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho
{
    public partial class FormQuanLyVien : Form
    {
        public FormQuanLyVien()
        {
            InitializeComponent();
        }
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien formQuanLyVien = new QuanLyNhanVien();
            this.Hide();
            formQuanLyVien.ShowDialog();
            this.Close();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            KhoHang khoHang = new KhoHang();
            this.Hide();
            khoHang.ShowDialog();
            this.Close();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            this.Hide();
            nhaCungCap.ShowDialog();
            this.Close();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            this.Hide();
            khachHang.ShowDialog();
            this.Close();
        }

        private void btnQLNH_Click(object sender, EventArgs e)
        {
            NhomHang nhomHang = new NhomHang();
            this.Hide();
            nhomHang.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            Giaodiennguoidung dn = new Giaodiennguoidung();
            dn.ShowDialog();
            this.Close();
        }
    }
}
