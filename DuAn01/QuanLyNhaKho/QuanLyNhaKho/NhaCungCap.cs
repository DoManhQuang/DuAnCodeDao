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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        BLLayer02 layer02 = new BLLayer02();
        private string MaNCC = null;
        public void setMaNCC(string mancc)
        {
            this.MaNCC = mancc;
        }
        public string getMaNCC()
        {
            return MaNCC;
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = layer02.LayThongTinNhaCungCap();
            txtDiachi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtTenNCC.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            layer02.ThemBangNhaCungCap(getMaNCC(), txtTenNCC.Text.Trim(), txtDiachi.Text.Trim(), txtSDT.Text.Trim(), txtEmail.Text.Trim());
            NhaCungCap_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            layer02.SuaBangNhaCungCap(getMaNCC(), txtTenNCC.Text.Trim(), txtDiachi.Text.Trim(), txtSDT.Text.Trim(), txtEmail.Text.Trim());
            NhaCungCap_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            layer02.XoaBangNhaCungCap(getMaNCC());
            NhaCungCap_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = layer02.TimkiemthongTinNhaCungCap(txtTenNCC.Text.Trim());
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
