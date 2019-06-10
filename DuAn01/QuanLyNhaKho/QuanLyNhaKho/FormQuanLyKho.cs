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
    public partial class FormQuanLyKho : Form
    {
        public FormQuanLyKho()
        {
            InitializeComponent();
        }

        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            HangHoa hangHoa = new HangHoa();
            this.Hide();
            hangHoa.ShowDialog();
            this.Close();
        }
    }
}
