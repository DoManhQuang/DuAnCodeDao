using QuanLyNhaKho.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho
{
    public partial class ThemMoiPhieuXuat : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        List<ChiTietHangHoaDAO> DanhSachHangHoaXuat = new List<ChiTietHangHoaDAO>();

        private double TongTien = 0;
        private NhanVienDAO NVDangNhap = new NhanVienDAO();

        public ThemMoiPhieuXuat(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NVDangNhap = nhanviendangnhap;
        }

        private void ThemMoiPhieuXuat_Load(object sender, EventArgs e)
        {
            txtSoPhieuXuat.Text = SinhMaSoPhieuXuatTuDong();

            cboKho.DataSource = layer02.LayDanhSachNhaKho();
            cboKho.DisplayMember = "TenNK";
            cboKho.ValueMember = "MaNK";
            cboKho.SelectedItem = null;
            cboKho.SelectedText = "--Chọn nhà kho--";

            cboNhaCungCap.DataSource = layer02.LayDanhSachNhaCungCap();
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
            cboNhaCungCap.SelectedItem = null;
            cboNhaCungCap.SelectedText = "--Chọn nhà cung cấp--";

            // Khởi tạo danh sách hàng xuất
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa("");
            List<ChiTietHangHoaDAO> danhsachnull = new List<ChiTietHangHoaDAO>();
            danhsachnull.Add(chiTietMotSanPham);

            dgvDanhSachHangXuat.DataSource = danhsachnull;

            dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá xuất";
            dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";


            txtNhanVien.Text = NVDangNhap.TenNV;

            cboTenHangHoa.DataSource = layer02.LayDanhSachHangHoa();
            cboTenHangHoa.DisplayMember = "TenHH";
            cboTenHangHoa.ValueMember = "MaHH";
            cboTenHangHoa.SelectedItem = null;
            cboTenHangHoa.SelectedText = "--Chọn mặt hàng--";

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private string SinhMaSoPhieuXuatTuDong()
        {
            string maHangHoaGoc = layer02.LayMaSoPhieuXuatCuoiCung().Rows[0][0].ToString();// lấy ô đầu tiên của bảng kết quả trả về
            string kyTuDau = maHangHoaGoc.Substring(0, 2);
            int soCanTang = Convert.ToInt32(maHangHoaGoc.Substring(2)) + 1;

            string maHangHoa = "";
            if (soCanTang >= 0 && soCanTang < 10)
                maHangHoa = kyTuDau + "0000" + soCanTang;
            if (soCanTang >= 10 && soCanTang < 100)
                maHangHoa = kyTuDau + "000" + soCanTang;
            if (soCanTang >= 100 && soCanTang < 1000)
                maHangHoa = kyTuDau + "00" + soCanTang;
            if (soCanTang >= 1000 && soCanTang < 10000)
                maHangHoa = kyTuDau + "0" + soCanTang;
            if (soCanTang >= 10000 && soCanTang < 100000)
                maHangHoa = kyTuDau + soCanTang;
            if (soCanTang >= 100000)
                maHangHoa = "Không thể tăng hơn nữa!";


            return maHangHoa;

        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            

                int sl;
                bool isNumericSL = int.TryParse(txtSoLuongXuat.Text, out sl);
                if (txtSoLuongXuat.Text.Equals(""))
                {
                    MessageBox.Show("Số lượng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuongXuat.Focus();
                }
                else if (!isNumericSL)
                {
                    MessageBox.Show("Số lượng nhập phải là chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuongXuat.Focus();
                }
                else if (sl <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuongXuat.Focus();
                }
                else
                {
                        // Xóa bỏ danh sách hàng hóa cũ
                        dgvDanhSachHangXuat.DataSource = null;

                        //MessageBox.Show(txtMaHangHoa.Text);

                        // Cập nhật danh sách mới
                        ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa(cboTenHangHoa.SelectedValue.ToString());
                        //MessageBox.Show(chiTietMotSanPham.MaHH);

                        if (chiTietMotSanPham.MaHH == null)
                        {
                            MessageBox.Show("Mã hàng hóa không đúng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboTenHangHoa.Focus();
                        }
                        else
                        {
                            // Kiểm tra xem mã hàng hóa đó đã có trong danh sách hàng nhập chưa
                            if (isCheckHHinDanhSachHangXuat(DanhSachHangHoaXuat, cboTenHangHoa.SelectedValue.ToString()))// trường hợp có
                            {
                                MessageBox.Show("Mã hàng hóa đã có trong danh sách nhập. Nếu muốn sửa thông tin mặt hàng này thì hãy xóa mặt hàng này và thêm lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDanhSachHangXuat.DataSource = DanhSachHangHoaXuat;

                                dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                                dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                                dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
                                dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
                                dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá xuất";
                                dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";
                            }
                            else
                            {

                                // Lấy dữ liệu số lượng nhập, giá nhập, thành tiền vào danh sách
                                double giaXuatCuaSPThem = Math.Round((double.Parse(chiTietMotSanPham.DonGia) * 2)/10000, 1)*10000;


                                chiTietMotSanPham.DonGia = giaXuatCuaSPThem.ToString();
                                chiTietMotSanPham.SoLuong = txtSoLuongXuat.Text;
                                chiTietMotSanPham.ThanhTien = (giaXuatCuaSPThem * int.Parse(txtSoLuongXuat.Text)).ToString();

                                DanhSachHangHoaXuat.Add(chiTietMotSanPham);

                                dgvDanhSachHangXuat.DataSource = DanhSachHangHoaXuat;

                                dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                                dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                                dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
                                dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
                                dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá xuất";
                                dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";

                                // Tính tổng tiền mỗi khi thêm sản phẩm
                                TongTien += int.Parse(txtSoLuongXuat.Text) * giaXuatCuaSPThem;
                                txtTongTien.Text = TongTien.ToString();
                            }

                       
                    }
                }
         
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyPhieuXuat qlpx = new QuanLyPhieuXuat(NVDangNhap);
            qlpx.ShowDialog();
            this.Close();
        }

        private void ClearDataThemMoiPhieuXuat()
        {
            txtSoPhieuXuat.Text = SinhMaSoPhieuXuatTuDong();

            txtNguoiNhanHang.Text = "";

            if (cboKho.SelectedItem != null)
            {
                cboKho.SelectedItem = null;
                cboKho.SelectedText = "--Chọn nhà kho--";
            }

            if (cboNhaCungCap.SelectedItem != null)
            {
                cboNhaCungCap.SelectedItem = null;
                cboNhaCungCap.SelectedText = "--Chọn nhà cung cấp";
            }

            txtGhiChu.Text = "";
            txtTongTien.Text = "0";

            TongTien = 0;

            cboTenHangHoa.SelectedItem = null;
            cboTenHangHoa.SelectedText = "--Chọn hàng hóa--";

            txtSoLuongXuat.Text = "0";

            dgvDanhSachHangXuat.DataSource = null;
            DanhSachHangHoaXuat.Clear();

            // Khởi tạo danh sách hàng xuất
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa("");
            List<ChiTietHangHoaDAO> danhsachnull = new List<ChiTietHangHoaDAO>();
            danhsachnull.Add(chiTietMotSanPham);

            dgvDanhSachHangXuat.DataSource = danhsachnull;

            dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá xuất";
            dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtNguoiNhanHang.Text.Equals(""))
            {
                MessageBox.Show("Tên người nhận hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNguoiNhanHang.Focus();
            }
            else
            {
                if (cboKho.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboKho.Focus();
                }
                else
                {
                    if (cboNhaCungCap.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboNhaCungCap.Focus();
                    }
                    else
                    {
                        if (txtGhiChu.Text.Equals(""))
                        {
                            MessageBox.Show("Ghi chú không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtGhiChu.Focus();
                        }
                        else
                        {
                            try
                            {
                                 //txtNhanVien.Text
                                layer02.ThemPhieuNhapHangVaoBangPhieuXuat(txtSoPhieuXuat.Text, cboKho.SelectedValue.ToString(), NVDangNhap.MaNV, dtpNgayXuat.Value, txtNguoiNhanHang.Text, txtGhiChu.Text, double.Parse(txtTongTien.Text), DanhSachHangHoaXuat);

                                ClearDataThemMoiPhieuXuat();

                                MessageBox.Show("Thêm phiếu xuất hàng thàng công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException)
                            {
                                MessageBox.Show("Lỗi trong quá trình thêm phiếu. Vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Hide();
                                DangNhap dn = new DangNhap();
                                dn.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                }
            }
           
        }


        private void dgvDanhSachHangXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvDanhSachHangXuat.CurrentCell.RowIndex;

            string tenHangClickHientai = dgvDanhSachHangXuat.Rows[rowindex].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa có tên là: " + tenHangClickHientai + " không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                string maHangXoa = dgvDanhSachHangXuat.Rows[rowindex].Cells[0].Value.ToString();

                // cập nhật lại tổng tiền của hóa đơn
                TongTien -= double.Parse(dgvDanhSachHangXuat.Rows[rowindex].Cells[5].Value.ToString());
                txtTongTien.Text = TongTien.ToString();

                // Xóa bỏ hàng hóa đó trong danh sách mua
                int viTriXoa = -1;
                for (int i = 0; i < DanhSachHangHoaXuat.Count; i++)
                {
                    if (DanhSachHangHoaXuat[i].MaHH.Equals(maHangXoa))
                    {
                        viTriXoa = i;
                    }
                }
                DanhSachHangHoaXuat.RemoveAt(viTriXoa);

                // Cập nhật danh sách hàng nhập sau khi xóa

                dgvDanhSachHangXuat.DataSource = null;
                dgvDanhSachHangXuat.DataSource = DanhSachHangHoaXuat;

                dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
                dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá xuất";
                dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";
            }
        }

        private bool isCheckHHinDanhSachHangXuat(List<ChiTietHangHoaDAO> danhSachHH, string maHangKiemTra)
        {

            foreach (ChiTietHangHoaDAO item in danhSachHH)
            {
                if (item.MaHH.Equals(maHangKiemTra))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
