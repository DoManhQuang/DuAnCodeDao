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
    public partial class NhaCungCap : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public NhaCungCap()
        {
            InitializeComponent();
        }
        public NhaCungCap(NhanVienDAO nv)
        {
            InitializeComponent();
            NVDangNhap = nv;
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
            string numberID = "NCC000" + layer02.GetMaNCC().ToString();
            layer02.ThemBangNhaCungCap(numberID, txtTenNCC.Text.Trim(), txtDiachi.Text.Trim(), txtSDT.Text.Trim(), txtEmail.Text.Trim());
            NhaCungCap_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            layer02.SuaBangNhaCungCap(getMaNCC(), txtTenNCC.Text.Trim(), txtDiachi.Text.Trim(), txtSDT.Text.Trim(), txtEmail.Text.Trim());
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

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = dgvNhaCC.Rows[e.RowIndex];
                if (viewRow != null)
                {
                    setMaNCC(viewRow.Cells[0].Value.ToString());
                    txtTenNCC.Text = viewRow.Cells[1].Value.ToString();
                    txtSDT.Text = viewRow.Cells[3].Value.ToString();
                    txtDiachi.Text = viewRow.Cells[2].Value.ToString();
                    txtEmail.Text = viewRow.Cells[4].Value.ToString();
                }
            }
        }
    }
}
