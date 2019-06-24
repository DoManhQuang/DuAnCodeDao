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
    public partial class QuanLyPhieuXuat : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public QuanLyPhieuXuat(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NVDangNhap = nhanviendangnhap;
        }

        private void btnLapPhieuXuat_Click(object sender, EventArgs e)
        {
            Hide();
            ThemMoiPhieuXuat pxMoi = new ThemMoiPhieuXuat(NVDangNhap);
            pxMoi.ShowDialog();
            this.Close();
        }

        private void QuanLyPhieuXuat_Load(object sender, EventArgs e)
        {
            dgvDanhSachPhieuXuat.DataSource = layer02.LayThongTinDanhSachPhieuXuat();
            dgvDanhSachPhieuXuat.Columns["STT"].Width = 60;
        }

        private void dgvDanhSachPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvChiTietPhieuXuat.DataSource = null;
            int rowindex = dgvDanhSachPhieuXuat.CurrentCell.RowIndex;
               string MaPX = dgvDanhSachPhieuXuat.Rows[rowindex].Cells[1].Value.ToString();
               //MessageBox.Show(MaPX);
            dgvChiTietPhieuXuat.DataSource = layer02.LayThongTinChiTietCuaPhieuXuat(MaPX);

            dgvChiTietPhieuXuat.Columns["STT"].HeaderText = "STT";
            dgvChiTietPhieuXuat.Columns["STT"].Width = 60;
            dgvChiTietPhieuXuat.Columns["MaHH"].HeaderText = "Mã hàng";
            dgvChiTietPhieuXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvChiTietPhieuXuat.Columns["Soluong"].HeaderText = "Số lượng";
            dgvChiTietPhieuXuat.Columns["Soluong"].Width = 100;
            dgvChiTietPhieuXuat.Columns["Dvt"].HeaderText = "Đơn vị tính";
            dgvChiTietPhieuXuat.Columns["Dvt"].Width = 100;
            dgvChiTietPhieuXuat.Columns["Giavon"].HeaderText = "Giá xuất";
            dgvChiTietPhieuXuat.Columns["Giavon"].Width = 110;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDanhSachPhieuXuat.DataSource = null;
            dgvDanhSachPhieuXuat.DataSource = layer02.LayThongTinDanhSachPhieuXuat();
            dgvDanhSachPhieuXuat.Columns["STT"].Width = 60;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string MaPX = txtTimKiem.Text;
            dgvDanhSachPhieuXuat.DataSource = layer02.TimKiemPhieuXuat(MaPX);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // in phiếu xuất

            using (frmReviewIn XemTruocKhiIn = new frmReviewIn())
            {
                int rowindex = dgvDanhSachPhieuXuat.CurrentCell.RowIndex;

                // Lấy thông tin phiếu nhập từ dòng click
                PhieuXuatDAO thongTinPhieuXuat = new PhieuXuatDAO(dgvDanhSachPhieuXuat.Rows[rowindex].Cells[1].Value.ToString(), dgvDanhSachPhieuXuat.Rows[rowindex].Cells[2].Value.ToString(), dgvDanhSachPhieuXuat.Rows[rowindex].Cells[3].Value.ToString(), dgvDanhSachPhieuXuat.Rows[rowindex].Cells[4].Value.ToString(), dgvDanhSachPhieuXuat.Rows[rowindex].Cells[5].Value.ToString(), dgvDanhSachPhieuXuat.Rows[rowindex].Cells[6].Value.ToString());


                // Lấy chi tiết phiếu nhập (danh sách mặt hàng nhập) từ bảng
                string MaPN = dgvDanhSachPhieuXuat.Rows[rowindex].Cells[1].Value.ToString();
                List<ChiTietHangHoaDAO> dataHangXuat = layer02.LayThongTinChiTietCuaPhieuXuatTheoSoPhieu(MaPN);

                // Đổ dữ liệu vào phiếu in
                XemTruocKhiIn.InPhieuXuat(thongTinPhieuXuat, dataHangXuat);

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
    }
}
