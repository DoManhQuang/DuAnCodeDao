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

    public partial class TaoHangHoa : Form
    {

        BLLayer02 layer02 = new BLLayer02();
        ComboBox hanghoa = new ComboBox();

        public TaoHangHoa(ComboBox hanghoa)
        {
            InitializeComponent();
            this.hanghoa = hanghoa;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maDM = cboDanhMuc.SelectedValue.ToString();
                string NCC = cboNCC.SelectedValue.ToString();
                layer02.ThemMoiHangHoa(txtMaHH.Text, txtTenHH.Text, txtDVT.Text, dtpHanSuDung.Value.ToString("yyyy-MM-dd"), "0", "0", maDM, txtMoTa.Text, NCC);
                MessageBox.Show("Thêm mới thành công 1 hàng hóa.");
                ResetTaoHangHoaKhiLuuThanhCong();
                hanghoa.DataSource = layer02.LayDanhSachHangHoa();
                hanghoa.DisplayMember = "TenHH";
                hanghoa.ValueMember = "MaHH";
                hanghoa.SelectedItem = null;
                hanghoa.SelectedText = "--Chọn mặt hàng--";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi lỗi về cho nhà phát triển." + ex.ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                TaoHangHoa_Load(sender, e);
            }
        }

        private void TaoHangHoa_Load(object sender, EventArgs e)
        {
            cboNCC.DataSource = layer02.LayDanhSachNhaCungCap();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
            cboNCC.SelectedItem = null;
            cboNCC.SelectedText = "--Chọn nhà cung cấp--";


            cboDanhMuc.DataSource = layer02.LayDanhSachDanhMuc();
            cboDanhMuc.DisplayMember = "TenDM";
            cboDanhMuc.ValueMember = "MaDM";
            cboDanhMuc.SelectedItem = null;
            cboDanhMuc.SelectedText = "--Chọn nhóm hàng--";

            txtMaHH.Text = SinhMaSoHangHoaTuDong();



        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private string SinhMaSoHangHoaTuDong()
        {
            string maHangHoaGoc = layer02.LayMaSoHangHoaCuoiCung().Rows[0][0].ToString();// lấy ô đầu tiên của bảng kết quả trả về
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

        private void ResetTaoHangHoaKhiLuuThanhCong(){

            cboNCC.DataSource = layer02.LayDanhSachNhaCungCap();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
            cboNCC.SelectedItem = null;
            cboNCC.SelectedText = "--Chọn nhà cung cấp--";


            cboDanhMuc.DataSource = layer02.LayDanhSachDanhMuc();
            cboDanhMuc.DisplayMember = "TenDM";
            cboDanhMuc.ValueMember = "MaDM";
            cboDanhMuc.SelectedItem = null;
            cboDanhMuc.SelectedText = "--Chọn nhóm hàng--";

            txtMaHH.Text = SinhMaSoHangHoaTuDong();

            txtTenHH.Text = "";

            txtDVT.Text = "";

            txtMoTa.Text = "";

        
        }
    }
}
