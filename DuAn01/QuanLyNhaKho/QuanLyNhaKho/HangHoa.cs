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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }
        BLLayer02 layer02 = new BLLayer02();
        private void HangHoa_Load(object sender, EventArgs e)
        {
            txtTenhang.Clear();
            dgvHanghoa.DataSource = layer02.LayThongTinHangHoa().Tables[0];
            cmbNhakho.DataSource = layer02.LayThongTinHangHoa().Tables[1];
            cmbNhakho.DisplayMember = "TenNK";
            cmbDanhmuc.DataSource = layer02.LayThongTinHangHoa().Tables[2];
            cmbDanhmuc.DisplayMember = "TenDM";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvHanghoa.DataSource = layer02.TimKiemBangHangHoa(txtTenhang.Text.Trim(), cmbNhakho.Text, cmbDanhmuc.Text);
        }

        private void btnTonkho_Click(object sender, EventArgs e)
        {
            HangHoa_Load(sender, e);
        }

        private void btnHetHan_Click(object sender, EventArgs e)
        {
            dgvHanghoa.DataSource = layer02.HangHoaDaHetHan();
        }

        private void btnSapHetHan_Click(object sender, EventArgs e)
        {
            dgvHanghoa.DataSource = layer02.HangHoaSapHetHan();
        }
    }
}
