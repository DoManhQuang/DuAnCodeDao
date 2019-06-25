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
    public partial class BaoCaoNhapXuatTon : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        public BaoCaoNhapXuatTon()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            XtraReportBaoCaoTonKho reportTonKho = new XtraReportBaoCaoTonKho();
            if (cboKho.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhà kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboKho.Focus();
            }
            else
            {
                // Bỏ submit paramater review report
                reportTonKho.Parameters["pThangBaoCao"].Visible = false;
                reportTonKho.Parameters["pNamBaoCao"].Visible = false;
                reportTonKho.Parameters["pMaKho"].Visible = false;
                reportTonKho.Parameters["PTenKho"].Visible = false;

                int nam = int.Parse(dtpThangNam.Value.Year.ToString());
                int thang = int.Parse(dtpThangNam.Value.Month.ToString());


                // dữ liệu
                List<BaoCaoNhapXuatTonDAO> dataBaoCao = layer02.LayDuLieuBaoCaoTonKho(cboKho.SelectedValue.ToString(), nam, thang);

                // lấy tên tên nhà kho
                string tenkho = layer02.GetTenKhoTheoMaKho(cboKho.SelectedValue.ToString());


                // Tạo và hiển thị dữ liệu
                reportTonKho.InitData(dataBaoCao, nam, thang, cboKho.SelectedValue.ToString(), tenkho);

                documentViewer1.DocumentSource = reportTonKho;
                reportTonKho.CreateDocument();
            }
        }

        private void BaoCaoNhapXuatTon_Load(object sender, EventArgs e)
        {
            cboKho.DataSource = layer02.LayDanhSachNhaKhoALL();
            cboKho.DisplayMember = "TenNK";
            cboKho.ValueMember = "MaNK";
            cboKho.SelectedItem = null;
            cboKho.SelectedText = "--Chọn nhà kho--";

        }
    }
}
