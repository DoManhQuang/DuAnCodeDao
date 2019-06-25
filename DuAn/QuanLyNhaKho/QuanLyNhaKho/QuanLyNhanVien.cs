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
    public partial class QuanLyNhanVien : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        public QuanLyNhanVien(NhanVienDAO NV)
        {
            InitializeComponent();
            NVDangNhap = NV;
        }
        BLLayer02 layer02 = new BLLayer02();
        private string MaNV = null;
        public void setMaNV(string manv)
        {
            this.MaNV = manv;
        }
        public string getMaNV()
        {
            return MaNV;
        }
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
            string numberID = "NV000" + layer02.GetMaNV().ToString();
            int gioitinh = 1;
            if(rdNu.Checked)
            {
                gioitinh = 0;
            }
            layer02.ThemBangNhanvien(numberID, txtTenNV.Text.Trim(), txtChucvu.Text.Trim(), gioitinh, dtpNgaysinh.Value.ToString("yyyy/MM/dd"), 
                txtSdt.Text.Trim(), txtDiachi.Text.Trim(), txtEmail.Text.Trim(), txtPhanquyen.Text.Trim(), "123456");
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int gioitinh = 1;
            if (rdNu.Checked)
            {
                gioitinh = 0;
            }
            layer02.SuaBangNhanvien(getMaNV(), txtTenNV.Text.Trim(), txtChucvu.Text.Trim(), gioitinh, dtpNgaysinh.Value.ToString("yyyy/MM/dd"),
                txtSdt.Text.Trim(), txtDiachi.Text.Trim(), txtEmail.Text.Trim(), txtPhanquyen.Text.Trim());
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            layer02.XoaBangNhanvien(getMaNV());
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvNhavien.DataSource = layer02.TimKiemBangNhanvien(txtTenNV.Text.Trim());
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_Load(sender, e);
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormQuanLyVien formQuanLyVien = new FormQuanLyVien();
            this.Hide();
            formQuanLyVien.ShowDialog();
            this.Close();
        }

        private void dgvNhavien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = dgvNhavien.Rows[e.RowIndex];
                if (viewRow != null)
                {
                    setMaNV(viewRow.Cells[0].Value.ToString());
                    txtTenNV.Text = viewRow.Cells[1].Value.ToString();
                    txtChucvu.Text = viewRow.Cells[2].Value.ToString();
                    if (Convert.ToBoolean(viewRow.Cells[3].Value) == true) // kiểm tra giới tính
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    dtpNgaysinh.Text = viewRow.Cells[4].Value.ToString();
                    txtSdt.Text = viewRow.Cells[5].Value.ToString();
                    txtDiachi.Text = viewRow.Cells[6].Value.ToString();
                    txtEmail.Text = viewRow.Cells[7].Value.ToString();
                    txtPhanquyen.Text = viewRow.Cells[8].Value.ToString();
                }
            }
        }
    }
}
