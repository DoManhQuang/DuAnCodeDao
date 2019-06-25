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
    public partial class KhoHang : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public KhoHang()
        {
            InitializeComponent();
        }
        public KhoHang(NhanVienDAO NV)
        {
            InitializeComponent();
            NVDangNhap = NV;
        }
        BLLayer02 layer02 = new BLLayer02();
        private string MaNK = null;
        public void setMaNK(string mank)
        {
            this.MaNK = mank;
        }
        public string getMaNK()
        {
            return MaNK;
        }
        private void KhoHang_Load(object sender, EventArgs e)
        {
            txtDiachi.Clear();
            txtTenNK.Clear();
            dgvKhoHang.DataSource = layer02.LayThongTinNhaKho();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string numberID = "NK000" + layer02.GetMaNK().ToString();
            layer02.ThemBangNhaKho(numberID, txtTenNK.Text.Trim(), txtDiachi.Text.Trim());
            KhoHang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            layer02.SuaBangNhaKho(getMaNK(), txtTenNK.Text.Trim(), txtDiachi.Text.Trim());
            KhoHang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            layer02.XoaBangNhaKho(getMaNK());
            KhoHang_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvKhoHang.DataSource = layer02.TimkiemthongTinNhaKho(txtTenNK.Text.Trim());
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormQuanLyVien formQuanLyVien = new FormQuanLyVien();
            this.Hide();
            formQuanLyVien.ShowDialog();
            this.Close();
        }

        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = dgvKhoHang.Rows[e.RowIndex];
                if (viewRow != null)
                {
                    setMaNK(viewRow.Cells[0].Value.ToString());
                    txtTenNK.Text = viewRow.Cells[1].Value.ToString();
                    txtDiachi.Text = viewRow.Cells[2].Value.ToString();
                }
            }
        }
    }
}
