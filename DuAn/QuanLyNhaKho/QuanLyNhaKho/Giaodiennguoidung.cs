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
    public partial class Giaodiennguoidung : Form
    {
        public Giaodiennguoidung()
        {
            InitializeComponent();
        }
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public Giaodiennguoidung(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NVDangNhap = nhanviendangnhap;
        }
        private void btnQLDM_Click(object sender, EventArgs e)
        {
            // Quản lý
            FormQuanLyVien formQuanLy = new FormQuanLyVien(NVDangNhap);
            this.Hide();
            formQuanLy.ShowDialog();
            this.Close();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            // Kho hàng
            QuanLyKhoHang quanLyKho = new QuanLyKhoHang(NVDangNhap);
            this.Hide();
            quanLyKho.ShowDialog();
            this.Close();
        }

        private void btnBH_Click(object sender, EventArgs e)
        {
            // Bán hàng
            Hide();
            BanHang bh = new BanHang(NVDangNhap);
            bh.ShowDialog();
            this.Close();
        }
    }
}
