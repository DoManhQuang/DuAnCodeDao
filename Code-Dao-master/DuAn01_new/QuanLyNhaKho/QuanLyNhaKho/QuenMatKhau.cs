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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        BLLayer02 layer02 = new BLLayer02();
        private void btnCapnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "" || txtTaikhoan.Text.Trim() == "" || txtMatkhau2.Text.Trim() == "" || txtMatkhau1.Text.Trim() == "")
                {
                    throw new IDandPassisNull();
                }
                else if (!String.Equals(txtMatkhau2.Text.Trim(), txtMatkhau1.Text.Trim()))
                {
                    throw new PasswordAgain();
                }
                else
                {
                    layer02.CapNhapTaiKhoan(txtID.Text.Trim(), txtTaikhoan.Text.Trim(), txtMatkhau2.Text.Trim());
                    MessageBox.Show("Cập Nhập Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IDandPassisNull)
            {
                MessageBox.Show("Không được để trống thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PasswordAgain)
            {
                MessageBox.Show("Mật khẩu phải trùng nhau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhập thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
