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
    public partial class NhomHang : Form
    {
        public NhomHang()
        {
            InitializeComponent();
        }
        BLLayer02 layer02 = new BLLayer02();
        private string MaDM = null;
        public void setMaDM(string madm)
        {
            this.MaDM = madm;
        }
        public string getMaDM()
        {
            return MaDM;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            layer02.ThemBangDanhMuc(getMaDM(), txtTenNH.Text.Trim());
            NhomHang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            layer02.SuaBangDanhmuc(getMaDM(), txtTenNH.Text.Trim());
            NhomHang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            layer02.XoaBangDanhmuc(getMaDM());
            NhomHang_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            layer02.TimkiemthongTinDanhMuc(txtTenNH.Text.Trim());
        }

        private void NhomHang_Load(object sender, EventArgs e)
        {
            txtTenNH.Clear();
            dgvNhomHang.DataSource = layer02.LayThongTinDanhmuc();
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
