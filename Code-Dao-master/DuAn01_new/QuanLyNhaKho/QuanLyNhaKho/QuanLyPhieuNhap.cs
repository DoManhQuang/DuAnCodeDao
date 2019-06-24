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
    public partial class QuanLyPhieuNhap : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public QuanLyPhieuNhap(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NVDangNhap = nhanviendangnhap;
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            Hide();
            ThemMoiPhieuNhap pnMoi = new ThemMoiPhieuNhap(NVDangNhap);
            pnMoi.ShowDialog();
            this.Close();
        }

        private void QuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvDanhSachPhieuNhap.DataSource = layer02.LayThongTinDanhSachPhieuNhap();
            dgvDanhSachPhieuNhap.Columns["STT"].Width = 60;
        }

        private void dgvDanhSachPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvDanhSachPhieuNhap.CurrentCell.RowIndex;
            string MaPN = dgvDanhSachPhieuNhap.Rows[rowindex].Cells[1].Value.ToString();
            dgvChiTietPhieuNhap.DataSource = layer02.LayThongTinChiTietCuaPhieuNhap(MaPN);

            dgvChiTietPhieuNhap.Columns["STT"].HeaderText = "STT";
            dgvChiTietPhieuNhap.Columns["STT"].Width = 60;
            dgvChiTietPhieuNhap.Columns["MaHH"].HeaderText = "Mã hàng";
            dgvChiTietPhieuNhap.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvChiTietPhieuNhap.Columns["Soluong"].HeaderText = "Số lượng";
            dgvChiTietPhieuNhap.Columns["Soluong"].Width = 100;
            dgvChiTietPhieuNhap.Columns["Dvt"].HeaderText = "Đơn vị tính";
            dgvChiTietPhieuNhap.Columns["Dvt"].Width = 100;
            dgvChiTietPhieuNhap.Columns["Giavon"].HeaderText = "Giá nhập";
            dgvChiTietPhieuNhap.Columns["Giavon"].Width = 110;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDanhSachPhieuNhap.DataSource = null;
            dgvDanhSachPhieuNhap.DataSource = layer02.LayThongTinDanhSachPhieuNhap();
            dgvDanhSachPhieuNhap.Columns["STT"].Width = 60;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string MaPX = txtTimKiem.Text;
            dgvDanhSachPhieuNhap.DataSource = layer02.TimKiemPhieuNhap(MaPX);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (frmReviewIn XemTruocKhiIn = new frmReviewIn())
            {
                int rowindex = dgvDanhSachPhieuNhap.CurrentCell.RowIndex;

                // Lấy thông tin phiếu nhập từ dòng click
                PhieuNhapDAO thongTinPhieuNhap = new PhieuNhapDAO(dgvDanhSachPhieuNhap.Rows[rowindex].Cells[1].Value.ToString(), dgvDanhSachPhieuNhap.Rows[rowindex].Cells[2].Value.ToString(), dgvDanhSachPhieuNhap.Rows[rowindex].Cells[3].Value.ToString(), dgvDanhSachPhieuNhap.Rows[rowindex].Cells[4].Value.ToString(), dgvDanhSachPhieuNhap.Rows[rowindex].Cells[5].Value.ToString(), dgvDanhSachPhieuNhap.Rows[rowindex].Cells[6].Value.ToString());


                // Lấy chi tiết phiếu nhập (danh sách mặt hàng nhập) từ bảng
                string MaPN = dgvDanhSachPhieuNhap.Rows[rowindex].Cells[1].Value.ToString();
                List<ChiTietHangHoaDAO> dataHangNhap = layer02.LayThongTinChiTietCuaPhieuNhapTheoSoPhieu(MaPN);

                // Đổ dữ liệu vào phiếu in
                XemTruocKhiIn.InPhieuNhap(thongTinPhieuNhap, dataHangNhap);
                
                //XemTruocKhiIn.InPhieuNhap();
                XemTruocKhiIn.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyKhoHang qlKhoHang = new QuanLyKhoHang(NVDangNhap);
            qlKhoHang.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
