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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        BLLayer02 layer02 = new BLLayer02();
        private string MaKH = null;
        public void setMaKH(string makh)
        {
            this.MaKH = makh;
        }
        public string getMaKH()
        {
            return MaKH;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvDanhSachKH.DataSource = layer02.LayThongTinKhachHang();
            txtDiachi.Clear();
            txtEmail.Clear();
            txtSdt.Clear();
            txtTenKH.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            layer02.SuaBangKhachHang(getMaKH(), txtTenKH.Text.Trim(), txtDiachi.Text.Trim(), txtSdt.Text.Trim(), txtEmail.Text.Trim());
            KhachHang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            layer02.XoaBangKhachHang(getMaKH());
            KhachHang_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvDanhSachKH.DataSource = layer02.TimKiemTinKhachHang(txtTenKH.Text.Trim());
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormQuanLyVien formQuanLyVien = new FormQuanLyVien();
            this.Hide();
            formQuanLyVien.ShowDialog();
            this.Close();
        }
    }
}
