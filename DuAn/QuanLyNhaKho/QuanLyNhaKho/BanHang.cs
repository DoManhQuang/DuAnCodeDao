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
    public partial class BanHang : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        private List<ChiTietHangHoaDAO> DanhSachHangBan = new List<ChiTietHangHoaDAO>();
        private double TongTien = 0;
        private NhanVienDAO NhanVienDangNhap = new NhanVienDAO();
        public BanHang(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NhanVienDangNhap = nhanviendangnhap;
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = SinhMaSoHoaDonTuDong();

            txtNhanVien.Text = NhanVienDangNhap.TenNV;


            // Khởi tạo danh sách hàng xuất
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa("");
            List<ChiTietHangHoaDAO> danhsachnull = new List<ChiTietHangHoaDAO>();
            danhsachnull.Add(chiTietMotSanPham);

            dgvDanhSachHangMua.DataSource = danhsachnull;

            dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";


            cboTenHangHoa.DataSource = layer02.LayDanhSachHangHoa();
            cboTenHangHoa.DisplayMember = "TenHH";
            cboTenHangHoa.ValueMember = "MaHH";
            cboTenHangHoa.SelectedItem = null;
            cboTenHangHoa.SelectedText = "--Chọn mặt hàng--";
        }



        private string SinhMaSoHoaDonTuDong()
        {
            string maHangHoaGoc = layer02.LayMaHoaDonCuoiCung().Rows[0][0].ToString();// lấy ô đầu tiên của bảng kết quả trả về
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
                bool isNumericSL = int.TryParse(txtSoLuongMua.Text, out sl);
                if (txtSoLuongMua.Text.Equals(""))
                {
                    MessageBox.Show("Số lượng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuongMua.Focus();
                }
                else if (!isNumericSL)
                {
                    MessageBox.Show("Số lượng nhập phải là chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuongMua.Focus();
                }
                else if (sl <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuongMua.Focus();
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
                            if (isCheckHHinDanhSachHangBan(DanhSachHangBan, cboTenHangHoa.SelectedValue.ToString()))// trường hợp có
                            {
                                MessageBox.Show("Mã hàng hóa đã có trong danh sách nhập. Nếu muốn sửa thông tin mặt hàng này thì hãy xóa mặt hàng này và thêm lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDanhSachHangMua.DataSource = DanhSachHangBan;

                                dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                                dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                                dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
                                dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
                                dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Đơn giá";
                                dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";
                            }
                            else
                            {
                                // Lấy dữ liệu số lượng nhập, giá nhập, thành tiền vào danh sách
                                double giaBanCuaSPThem = Math.Round((double.Parse(chiTietMotSanPham.DonGia) * 2) / 10000, 1) * 10000;
                                    //Math.Round((((double.Parse(chiTietMotSanPham.DonGia) * 2) / int.Parse(chiTietMotSanPham.SoLuong)) * int.Parse(chiTietMotSanPham.DonGia)) / 10000, 1) * 10000;

                                chiTietMotSanPham.DonGia = giaBanCuaSPThem.ToString();
                                chiTietMotSanPham.SoLuong = txtSoLuongMua.Text;
                                chiTietMotSanPham.ThanhTien = (giaBanCuaSPThem * int.Parse(txtSoLuongMua.Text)).ToString();

                                DanhSachHangBan.Add(chiTietMotSanPham);

                                dgvDanhSachHangMua.DataSource = DanhSachHangBan;

                                dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                                dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                                dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
                                dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
                                dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Đơn giá";
                                dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";

                                // Tính tổng tiền mỗi khi thêm sản phẩm
                                TongTien += int.Parse(txtSoLuongMua.Text) * giaBanCuaSPThem;
                                txtTongTien.Text = TongTien.ToString();

                                // xóa bỏ số lượng
                                txtSoLuongMua.Text = ""; ;
                            }

                        }
                    
                }


        }


        private void dgvDanhSachHangMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvDanhSachHangMua.CurrentCell.RowIndex;

            string tenHangClickHientai = dgvDanhSachHangMua.Rows[rowindex].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa có tên là: " + tenHangClickHientai + " không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                string maHangXoa = dgvDanhSachHangMua.Rows[rowindex].Cells[0].Value.ToString();
                // cập nhật lại tổng tiền của hóa đơn
                TongTien -= double.Parse(dgvDanhSachHangMua.Rows[rowindex].Cells[5].Value.ToString());
                txtTongTien.Text = TongTien.ToString();


                // Xóa bỏ hàng hóa đó trong danh sách mua
                int viTriXoa = -1;
                for (int i = 0; i < DanhSachHangBan.Count; i++)
                {
                    if (DanhSachHangBan[i].MaHH.Equals(maHangXoa))
                    {
                        viTriXoa = i;
                    }
                }
                DanhSachHangBan.RemoveAt(viTriXoa);

                // Cập nhật danh sách hàng nhập sau khi xóa

                dgvDanhSachHangMua.DataSource = null;
                dgvDanhSachHangMua.DataSource = DanhSachHangBan;

                dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
                dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            Hide();
            Giaodiennguoidung dn = new Giaodiennguoidung(NhanVienDangNhap);
            dn.ShowDialog();
            this.Close();
        }
        private void ClearDataHoaDonBanHang()
        {
            txtMaHD.Text = SinhMaSoHoaDonTuDong();


            // reset thông tin khách hàng
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";


            TongTien = 0;
            txtTongTien.Text = TongTien.ToString();


            // xóa bỏ danh sách hàng bán
            DanhSachHangBan.Clear();
            dgvDanhSachHangMua.DataSource = null;

            txtSoLuongMua.Text = "0";
            cboTenHangHoa.DataSource = layer02.LayDanhSachHangHoa();
            cboTenHangHoa.DisplayMember = "TenHH";
            cboTenHangHoa.ValueMember = "MaHH";
            cboTenHangHoa.SelectedItem = null;
            cboTenHangHoa.SelectedText = "--Chọn mặt hàng--";

            txtGhiChu.Text = "";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtGhiChu.Text.Equals(""))
            {
                MessageBox.Show("Ghi chú không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGhiChu.Focus();
            }
            else
            {
                if (txtTenKH.Text.Equals(""))
                {
                    MessageBox.Show("Tên Khách hàng không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenKH.Focus();
                }
                else
                {

                    if (txtDiaChi.Text.Equals(""))
                    {
                        MessageBox.Show("Địac chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDiaChi.Focus();
                    }
                    else
                    {

                        if (txtSDT.Text.Equals(""))
                        {
                            MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSDT.Focus();
                        }
                        else
                        {
                            if (txtEmail.Text.Equals(""))
                            {
                                MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtEmail.Focus();
                            }
                            else
                            {
                                try
                                {
                                    layer02.ThanhToanVaThemHoaDonBanHang(txtMaHD.Text, NhanVienDangNhap.MaNV, dtpNgayMua.Value, txtGhiChu.Text, double.Parse(txtTongTien.Text), txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, DanhSachHangBan);

                                    MessageBox.Show("Thanh toán và tạo hóa đơn bán hàng thàng công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    ClearDataHoaDonBanHang();
                                }
                                catch (SqlException)
                                {
                                    MessageBox.Show("Lỗi trong quá trình tạo hóa đơn. Vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }


        private bool isCheckHHinDanhSachHangBan(List<ChiTietHangHoaDAO> danhSachHH, string maHangKiemTra)
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
