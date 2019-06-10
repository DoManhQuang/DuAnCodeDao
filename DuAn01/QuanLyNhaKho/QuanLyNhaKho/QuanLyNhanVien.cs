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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        BLLayer02 layer02 = new BLLayer02();
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            txtTenNV.Clear();
            txtChucvu.Clear();
            txtSdt.Clear();
            txtDiachi.Clear();
            txtEmail.Clear();
            txtPhanquyen.Clear();
            dgvNhavien.DataSource = layer02.LayThongTinNhanvien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNV = "";
            int gioitinh = 1;
            if(rdNu.Checked)
            {
                gioitinh = 0;
            }
            layer02.ThemBangNhanvien(MaNV, txtTenNV.Text.Trim(), txtChucvu.Text.Trim(), gioitinh, dtpNgaysinh.Value.ToString("yyyy/MM/dd"), 
                txtSdt.Text.Trim(), txtDiachi.Text.Trim(), txtEmail.Text.Trim(), txtPhanquyen.Text.Trim(), "123456");
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaNV = "";
            int gioitinh = 1;
            if (rdNu.Checked)
            {
                gioitinh = 0;
            }
            layer02.SuaBangNhanvien(MaNV, txtTenNV.Text.Trim(), txtChucvu.Text.Trim(), gioitinh, dtpNgaysinh.Value.ToString("yyyy/MM/dd"),
                txtSdt.Text.Trim(), txtDiachi.Text.Trim(), txtEmail.Text.Trim(), txtPhanquyen.Text.Trim());
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNV = "";
            layer02.XoaBangNhanvien(MaNV);
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            layer02.TimKiemBangNhanvien(txtTenNV.Text.Trim());
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_Load(sender, e);
        }
    }
}
