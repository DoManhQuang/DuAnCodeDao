using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaKho.DAO;
namespace QuanLyNhaKho
{
    public partial class FormQuanLyVien : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public FormQuanLyVien()
        {
            InitializeComponent();
        }
        public FormQuanLyVien(NhanVienDAO NV)
        {
            InitializeComponent();
            NVDangNhap = NV;
        }
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien formQuanLyVien = new QuanLyNhanVien(NVDangNhap);
            this.Hide();
            formQuanLyVien.ShowDialog();
            this.Close();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            KhoHang khoHang = new KhoHang(NVDangNhap);
            this.Hide();
            khoHang.ShowDialog();
            this.Close();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap(NVDangNhap);
            this.Hide();
            nhaCungCap.ShowDialog();
            this.Close();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang(NVDangNhap);
            this.Hide();
            khachHang.ShowDialog();
            this.Close();
        }

        private void btnQLNH_Click(object sender, EventArgs e)
        {
            NhomHang nhomHang = new NhomHang(NVDangNhap);
            this.Hide();
            nhomHang.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            Giaodiennguoidung dn = new Giaodiennguoidung(NVDangNhap);
            dn.ShowDialog();
            this.Close();
        }
    }
}
