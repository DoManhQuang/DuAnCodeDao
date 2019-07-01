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
    public partial class ThemMoiPhieuNhap : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        List<ChiTietHangHoaDAO> DanhSachHangHoaNhap = new List<ChiTietHangHoaDAO>();
        private double TongTien = 0;
        private NhanVienDAO NVDangNhap = new NhanVienDAO();

        public ThemMoiPhieuNhap(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NVDangNhap = nhanviendangnhap;
        }

        private void ThemMoiPhieuNhap_Load(object sender, EventArgs e)
        {
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

            // Khởi tạo danh sách hàng nhập
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa("");
            List<ChiTietHangHoaDAO> danhsachnull = new List<ChiTietHangHoaDAO>();
            danhsachnull.Add(chiTietMotSanPham);

            dgvDanhSachHangMua.DataSource = danhsachnull;

            dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Giá nhập";
            dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";

            txtMaNV.Text = NVDangNhap.TenNV;


            // Sinh ngẫu nhiên số phiếu nhập
            txtSoPhieuNhap.Text = SinhMaSoPhieuNhapTuDong();

            cboTenHangHoa.DataSource = layer02.LayDanhSachHangHoa();
            cboTenHangHoa.DisplayMember = "TenHH";
            cboTenHangHoa.ValueMember = "MaHH";
            cboTenHangHoa.SelectedItem = null;
            cboTenHangHoa.SelectedText = "--Chọn mặt hàng--";
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            
            if (cboTenHangHoa.SelectedItem!=null)
            {
                int sl;
                bool isNumericSL = int.TryParse(txtSoLuong.Text, out sl);
                if (txtSoLuong.Text.Equals(""))
                {
                    MessageBox.Show("Số lượng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                }
                else if (!isNumericSL)
                {
                    MessageBox.Show("Số lượng nhập phải là chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                }
                else if (sl <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                }
                else if (sl >= 999000)
                {
                    MessageBox.Show("Số lượng nhập quá nhiều kho không đủ chứa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                }
                else
                {
                    int giaNhap;
                    bool isNumericGiaNhap = int.TryParse(txtGiaNhap.Text, out giaNhap);
                    if (txtGiaNhap.Text.Equals(""))
                    {
                        MessageBox.Show("Giá nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGiaNhap.Focus();
                    }
                    else if (!isNumericGiaNhap)
                    {
                        MessageBox.Show("Giá nhập phải là chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGiaNhap.Focus();
                    }
                    else if (giaNhap <= 0)
                    {
                        MessageBox.Show("Giá nhập phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGiaNhap.Focus();
                    }
                    else
                    {
                        // Xóa bỏ danh sách hàng hóa cũ
                        dgvDanhSachHangMua.DataSource = null;

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
                            if (isCheckHHinDanhSachHangNhap(DanhSachHangHoaNhap, cboTenHangHoa.SelectedValue.ToString()))// trường hợp có
                            {
                                MessageBox.Show("Mã hàng hóa đã có trong danh sách nhập. Nếu muốn sửa thông tin mặt hàng này thì hãy xóa mặt hàng này và thêm lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDanhSachHangMua.DataSource = DanhSachHangHoaNhap;

                                dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                                dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                                dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
                                dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
                                dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Giá nhập";
                                dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";
                            }
                            else
                            {
                                // Lấy dữ liệu số lượng nhập, giá nhập, thành tiền vào danh sách
                                chiTietMotSanPham.DonGia = txtGiaNhap.Text;
                                chiTietMotSanPham.SoLuong = txtSoLuong.Text;
                                chiTietMotSanPham.ThanhTien = (int.Parse(txtGiaNhap.Text) * int.Parse(txtSoLuong.Text)).ToString();

                                DanhSachHangHoaNhap.Add(chiTietMotSanPham);

                                dgvDanhSachHangMua.DataSource = DanhSachHangHoaNhap;

                                dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                                dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                                dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
                                dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
                                dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Giá nhập";
                                dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";

                                // Tính tổng tiền mỗi khi thêm sản phẩm
                                TongTien += int.Parse(txtSoLuong.Text) * int.Parse(txtGiaNhap.Text);
                                txtTongTien.Text = TongTien.ToString();
                            }


                        }
                    }
                }
            }else {
                MessageBox.Show("Vui lòng chọn hàng hóa trước khi thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTenHangHoa.Focus();
            }

        }


        private string SinhMaSoPhieuNhapTuDong()
        {
            string maHangHoaGoc = layer02.LayMaSoPhieuNhapCuoiCung().Rows[0][0].ToString();// lấy ô đầu tiên của bảng kết quả trả về
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


        private void ResetThemMoiPhieuNhap()
        {
            txtSoPhieuNhap.Text = SinhMaSoPhieuNhapTuDong();
            txtNguoiGiaoHang.Text = "";

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

            cboTenHangHoa.DataSource = layer02.LayDanhSachHangHoa();
            cboTenHangHoa.DisplayMember = "TenHH";
            cboTenHangHoa.ValueMember = "MaHH";
            cboTenHangHoa.SelectedItem = null;
            cboTenHangHoa.SelectedText = "--Chọn mặt hàng--";

            txtSoLuong.Text = "0";
            txtGiaNhap.Text = "0";

            dgvDanhSachHangMua.DataSource = null;
            DanhSachHangHoaNhap.Clear();

            // Khởi tạo danh sách hàng nhập
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa("");
            List<ChiTietHangHoaDAO> danhsachnull = new List<ChiTietHangHoaDAO>();
            danhsachnull.Add(chiTietMotSanPham);

            dgvDanhSachHangMua.DataSource = danhsachnull;

            dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Giá nhập";
            dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetThemMoiPhieuNhap();
            Hide();
            QuanLyPhieuNhap qlpn = new QuanLyPhieuNhap(NVDangNhap);
            qlpn.ShowDialog();
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtNguoiGiaoHang.Text.Equals(""))
            {
                MessageBox.Show("Tên người giao hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNguoiGiaoHang.Focus();
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
                                //txtMaNV.Text
                                layer02.ThemPhieuNhapHangVaoBangPhieuNhap(txtSoPhieuNhap.Text, NVDangNhap.MaNV, cboKho.SelectedValue.ToString(), dtpNgayNhap.Value, txtNguoiGiaoHang.Text, txtGhiChu.Text, double.Parse(txtTongTien.Text.Trim()), DanhSachHangHoaNhap);

                                ResetThemMoiPhieuNhap();

                                MessageBox.Show("Thêm phiếu nhập hàng thàng công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lbTaoMoiHangHoa_Click(object sender, EventArgs e)
        {
            TaoHangHoa taoMoiHH = new TaoHangHoa(cboTenHangHoa);
            taoMoiHH.ShowDialog();
        }

        private void dgvDanhSachHangMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvDanhSachHangMua.CurrentCell.RowIndex;

            string tenHangClickHientai = dgvDanhSachHangMua.Rows[rowindex].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa có tên là: " + tenHangClickHientai + " không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string maHangXoa = dgvDanhSachHangMua.Rows[rowindex].Cells[0].Value.ToString();
                // Xóa bỏ hàng hóa đó trong danh sách mua
                int viTriXoa = -1;
                for (int i = 0; i < DanhSachHangHoaNhap.Count; i++)
                {
                    if (DanhSachHangHoaNhap[i].MaHH.Equals(maHangXoa))
                    {
                        viTriXoa = i;
                    }
                }
                DanhSachHangHoaNhap.RemoveAt(viTriXoa);

                // Cập nhật danh sách hàng nhập sau khi xóa

                dgvDanhSachHangMua.DataSource = null;
                dgvDanhSachHangMua.DataSource = DanhSachHangHoaNhap;

                dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
                dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Giá nhập";
                dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";
            }

        }

        private bool isCheckHHinDanhSachHangNhap(List<ChiTietHangHoaDAO> danhSachHH, string maHangKiemTra)
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
