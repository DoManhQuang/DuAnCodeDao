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
    public partial class NhomHang : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public NhomHang()
        {
            InitializeComponent();
        }
        public NhomHang(NhanVienDAO nv)
        {
            InitializeComponent();
            NVDangNhap = nv;
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
        private void NhomHang_Load(object sender, EventArgs e)
        {
            txtTenNH.Clear();
            dgvNhomHang.DataSource = layer02.LayThongTinDanhmuc();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string numberID = "DM000" + layer02.GetMaDM().ToString();
            layer02.ThemBangDanhMuc(numberID, txtTenNH.Text.Trim());
            NhomHang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            layer02.SuaBangDanhmuc(getMaDM(), txtTenNH.Text.Trim());
            NhomHang_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvNhomHang.DataSource = layer02.TimkiemthongTinDanhMuc(txtTenNH.Text.Trim());
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormQuanLyVien formQuanLyVien = new FormQuanLyVien();
            this.Hide();
            formQuanLyVien.ShowDialog();
            this.Close();
        }

        private void dgvNhomHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = dgvNhomHang.Rows[e.RowIndex];
                if (viewRow != null)
                {
                    setMaDM(viewRow.Cells[0].Value.ToString());
                    txtMa.Text = viewRow.Cells[0].Value.ToString();
                    txtTenNH.Text = viewRow.Cells[1].Value.ToString();
                }
            }
        }
    }
}
