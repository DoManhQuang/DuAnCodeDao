using QuanLyNhaKho.DAO;
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
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public HangHoa(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NVDangNhap = nhanviendangnhap;
           
        }
        BLLayer02 layer02 = new BLLayer02();
        private void HangHoa_Load(object sender, EventArgs e)
        {
            txtTenhang.Clear();
            dgvHanghoa.DataSource = layer02.LayThongTinHangHoa().Tables[0];
            cmbNhakho.DataSource = layer02.LayDanhSachNhaKho();
            cmbNhakho.DisplayMember = "TenNK";
            cmbNhakho.ValueMember = "MaNK";

            cmbDanhmuc.DataSource = layer02.LayThongTinHangHoa().Tables[2];
            cmbDanhmuc.DisplayMember = "TenDM";
         

            cboLuaChonIn.Items.Clear();

            cboLuaChonIn.Items.Add("--Lựa chọn phiếu in--");
            cboLuaChonIn.SelectedIndex = 0;
            cboLuaChonIn.Items.Add("Phiếu tồn kho");
            cboLuaChonIn.Items.Add("Phiếu hàng hết hạn");
            cboLuaChonIn.Items.Add("Phiếu hàng sắp hết hạn");

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

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            QuanLyKhoHang quanLyKho = new QuanLyKhoHang(NVDangNhap);
            this.Hide();
            quanLyKho.ShowDialog();
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            List<KiemKeDAO> datas = new List<KiemKeDAO>();
            for (int rows = 0; rows < dgvHanghoa.Rows.Count; rows++)
            {
                //string mahh, string tenhh, string kho,string dvt, string sl, string dongia, string thanhtien
                KiemKeDAO datarow = new KiemKeDAO(dgvHanghoa.Rows[rows].Cells[0].Value.ToString(), dgvHanghoa.Rows[rows].Cells[1].Value.ToString(), dgvHanghoa.Rows[rows].Cells[4].Value.ToString(), dgvHanghoa.Rows[rows].Cells[5].Value.ToString(), dgvHanghoa.Rows[rows].Cells[2].Value.ToString(), dgvHanghoa.Rows[rows].Cells[7].Value.ToString(), (int.Parse(dgvHanghoa.Rows[rows].Cells[4].Value.ToString()) * (int.Parse(dgvHanghoa.Rows[rows].Cells[5].Value.ToString()))).ToString(), dgvHanghoa.Rows[rows].Cells[3].Value.ToString());
                //MessageBox.Show(dgvHanghoa.Rows[rows].Cells[3].Value.ToString());
                    datas.Add(datarow);
            }
            if (cboLuaChonIn.SelectedIndex == 0)// không lựa chọn gì
            {
                MessageBox.Show("Vui lòng chọn loại phiếu in trước khi in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLuaChonIn.Focus();
            }
             else if (cboLuaChonIn.SelectedIndex==1)// tồn kho
            {
                using (frmReviewIn XemTruocKhiIn = new frmReviewIn())
                {

                    // Đổ dữ liệu vào phiếu in
                    XemTruocKhiIn.InPhieuTonKho(datas);

                    //XemTruocKhiIn.InPhieuNhap();
                    XemTruocKhiIn.ShowDialog();
                }
            }
            else if (cboLuaChonIn.SelectedIndex == 2)// hàng đã hết hạn
            {
                using (frmReviewIn XemTruocKhiIn = new frmReviewIn())
                {

                    // Đổ dữ liệu vào phiếu in
                    XemTruocKhiIn.InPhieuHetHan(datas);

                    //XemTruocKhiIn.InPhieuNhap();
                    XemTruocKhiIn.ShowDialog();
                }
            }
            else if (cboLuaChonIn.SelectedIndex == 3)// hàng sắp hết hạn
            {
                using (frmReviewIn XemTruocKhiIn = new frmReviewIn())
                {

                    // Đổ dữ liệu vào phiếu in
                    XemTruocKhiIn.InPhieuSapHetHan(datas);

                    //XemTruocKhiIn.InPhieuNhap();
                    XemTruocKhiIn.ShowDialog();
                }
            }

        }

        private void cboLuaChonIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuaChonIn.SelectedIndex==1)
            {
                dgvHanghoa.DataSource = layer02.LayThongTinHangHoa().Tables[0];
            }
            else if (cboLuaChonIn.SelectedIndex==2)
            {
                dgvHanghoa.DataSource = layer02.HangHoaDaHetHan();
            }
            else if (cboLuaChonIn.SelectedIndex==3)
            {
                dgvHanghoa.DataSource = layer02.HangHoaSapHetHan();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
