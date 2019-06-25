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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        BLLayer02 layer02 = new BLLayer02();
        private NhanVienDAO NhanVienDangNhap = new NhanVienDAO();
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    throw new IDandPassisNull();
                }
                else if (layer02.DangNhap(txtID.Text.Trim(), txtPassword.Text.Trim()))
                {
                    string MaNV = null;
                    int chucnang = layer02.ChucNangNguoiDung(txtID.Text.Trim(), txtPassword.Text.Trim());
                    
                    if(layer02.GetMaNV(txtID.Text.Trim(), txtPassword.Text.Trim()) != null)
                    {
                        MaNV = layer02.GetMaNV(txtID.Text.Trim(), txtPassword.Text.Trim());
                        NhanVienDangNhap.MaNV = MaNV;
                        NhanVienDangNhap.TenNV = layer02.GetTenNV(txtID.Text.Trim(), txtPassword.Text.Trim());
                        NhanVienDangNhap.PhanQuyen = chucnang.ToString();
                    }
                    /*
                    if (chucnang == 1)
                    {
                        // Quản lý
                        FormQuanLyVien formQuanLy = new FormQuanLyVien();
                        this.Hide();
                        formQuanLy.ShowDialog();
                        this.Close();
                    }
                    else if (chucnang == 2)
                    {
                        // Kho hàng
                        QuanLyKhoHang quanLyKho = new QuanLyKhoHang(NhanVienDangNhap);
                        this.Hide();
                        quanLyKho.ShowDialog();
                        this.Close();
                    }
                    else if (chucnang == 3)
                    {
                        // Bán hàng
                        Hide();
                        BanHang bh = new BanHang(NhanVienDangNhap);
                        bh.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        
                        throw new IDDoesnotExist();
                    }
                     */
                    Giaodiennguoidung GDND = new Giaodiennguoidung(NhanVienDangNhap);
                    this.Hide();
                    GDND.ShowDialog();
                    this.Close();
                }
            }
            catch(IDandPassisNull)
            {
                MessageBox.Show("Không được để trống thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DangNhap_Load(sender, e);
            }
            catch(IDDoesnotExist)
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DangNhap_Load(sender, e);
            }
            catch(Exception)
            {
                MessageBox.Show("Đăng nhập thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DangNhap_Load(sender, e);
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtID.Clear();
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            this.Hide();
            quenMatKhau.ShowDialog();
            this.Close();
        }
    }
}
