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
    public partial class QuanLyBaoCao : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public QuanLyBaoCao()
        {
            InitializeComponent();
        }
        public QuanLyBaoCao(NhanVienDAO nv)
        {
            InitializeComponent();
            NVDangNhap = nv;
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyKhoHang dn = new QuanLyKhoHang(NVDangNhap);
            dn.ShowDialog();
            this.Close();
        }

        private void QuanLyBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnBaoCaoTon_Click(object sender, EventArgs e)
        {
            BaoCaoNhapXuatTon baocaoton = new BaoCaoNhapXuatTon(NVDangNhap);
            baocaoton.ShowDialog();
        }

        private void btnBaoCaoXuat_Click(object sender, EventArgs e)
        {
            BaoCaoXuatKho xuatkho = new BaoCaoXuatKho(NVDangNhap);
            xuatkho.ShowDialog();
        }

        private void btnBaoCaoNhap_Click(object sender, EventArgs e)
        {
            BaoCaoNhapKho bcnhapkho = new BaoCaoNhapKho(NVDangNhap);
            bcnhapkho.ShowDialog();
        }
    }
}
