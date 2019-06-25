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
    public partial class TonDauKy : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public TonDauKy()
        {
            InitializeComponent();
        }
        public TonDauKy(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NVDangNhap = nhanviendangnhap;
        }

        BLLayer02 layer02 = new BLLayer02();
        private void btnTonkho_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTondauky.DataSource = layer02.LayHangTonDauKy(cmbNhakho.Text, dtpThoigian.Value.ToString("yyyy/MM/dd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi lỗi về nhà phát triển. " + ex.ToString(), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void TonDauKy_Load(object sender, EventArgs e)
        {
            try
            {
                cmbNhakho.DataSource = layer02.LayTenNhaKho();
                cmbNhakho.DisplayMember = "MaNK";
                cmbNhakho.ValueMember = "MaNK";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi lỗi về nhà phát triển. " + ex.ToString(), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyKhoHang baocao = new QuanLyKhoHang(NVDangNhap);
            baocao.ShowDialog();
            this.Close();
        }
    }
}
