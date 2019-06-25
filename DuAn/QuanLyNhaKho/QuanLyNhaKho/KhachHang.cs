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
    public partial class KhachHang : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public KhachHang()
        {
            InitializeComponent();
        }
        public KhachHang(NhanVienDAO nv)
        {
            InitializeComponent();
            NVDangNhap = nv;
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

        private void dgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = dgvDanhSachKH.Rows[e.RowIndex];
                if (viewRow != null)
                { 
                    setMaKH(viewRow.Cells[0].Value.ToString());
                    txtTenKH.Text = viewRow.Cells[1].Value.ToString();
                    txtSdt.Text = viewRow.Cells[2].Value.ToString();
                    txtDiachi.Text = viewRow.Cells[3].Value.ToString();
                    txtEmail.Text = viewRow.Cells[4].Value.ToString();
                }
            }
        }
    }
}
