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
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "" && txtPassword.Text.Trim() == "")
                {
                    throw new IDandPassisNull();
                }
                else if (layer02.DangNhap(txtID.Text.Trim(), txtPassword.Text.Trim()))
                {
                    int chucnang = layer02.ChucNangNguoiDung(txtID.Text.Trim(), txtPassword.Text.Trim());
                    if (chucnang == 1)
                    {
                        QuanLyNhanVien formQuanLy = new QuanLyNhanVien();
                        this.Hide();
                        formQuanLy.ShowDialog();
                        this.Close();
                    }
                    else if (chucnang == 2)
                    {

                    }
                    else if (chucnang == 3)
                    {

                    }
                    else
                    {
                        throw new IDDoesnotExist();
                    }
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
    }
}
