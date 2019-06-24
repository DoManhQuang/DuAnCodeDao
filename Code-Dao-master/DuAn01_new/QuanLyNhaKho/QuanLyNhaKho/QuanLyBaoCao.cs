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
    public partial class QuanLyBaoCao : Form
    {
        public QuanLyBaoCao()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyKhoHang dn = new QuanLyKhoHang();
            dn.ShowDialog();
            this.Close();
        }

        private void QuanLyBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnBaoCaoTon_Click(object sender, EventArgs e)
        {
            BaoCaoNhapXuatTon baocaoton = new BaoCaoNhapXuatTon();
            baocaoton.ShowDialog();
        }

        private void btnBaoCaoXuat_Click(object sender, EventArgs e)
        {
            BaoCaoXuatKho xuatkho = new BaoCaoXuatKho();
            xuatkho.ShowDialog();
        }

        private void btnBaoCaoNhap_Click(object sender, EventArgs e)
        {
            BaoCaoNhapKho bcnhapkho = new BaoCaoNhapKho();
            bcnhapkho.ShowDialog();
        }
    }
}
