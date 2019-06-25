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
    public partial class BaoCaoXuatKho : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        public BaoCaoXuatKho()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {

            XtraReportBaoCaoXuatKho reprortbaocaoxuatkho = new XtraReportBaoCaoXuatKho();
            if (cboKho.SelectedItem==null)
            {
                MessageBox.Show("Vui lòng chọn nhà kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboKho.Focus();
            }
            else if (cboNCC.SelectedItem==null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNCC.Focus();
            }
            else
            {
                // Bỏ submit paramater review report
                reprortbaocaoxuatkho.Parameters["pTuNgay"].Visible = false;
                reprortbaocaoxuatkho.Parameters["pDenNgay"].Visible = false;
                reprortbaocaoxuatkho.Parameters["pMaKho"].Visible = false;
                reprortbaocaoxuatkho.Parameters["pTenKho"].Visible = false;
                reprortbaocaoxuatkho.Parameters["pMaNCC"].Visible = false;
                reprortbaocaoxuatkho.Parameters["pTenNhaCungCap"].Visible = false;

                // dữ liệu
                List<BaoCaoXuatKhoDAO> dataBaoCao = layer02.LayDuLieuBaoCaoXuatKho(cboKho.SelectedValue.ToString(), cboNCC.SelectedValue.ToString(), dtpTuNgay.Value, dtpDenNgay.Value);

                // lấy tên ncc và tên nhà kho
                string tenkho = layer02.GetTenKhoTheoMaKho(cboKho.SelectedValue.ToString());
                string tenNCC = layer02.GetTenNhaCungCapTheoMaNhaCungCap(cboNCC.SelectedValue.ToString());


                reprortbaocaoxuatkho.InitData(dataBaoCao, dtpTuNgay.Value, dtpDenNgay.Value, cboKho.SelectedValue.ToString(), tenkho, cboNCC.SelectedValue.ToString(), tenNCC);

                documentViewer1.DocumentSource = reprortbaocaoxuatkho;
                reprortbaocaoxuatkho.CreateDocument();
            }
        }

        private void BaoCaoXuatKho_Load(object sender, EventArgs e)
        {
            cboKho.DataSource = layer02.LayDanhSachNhaKhoALL();
            cboKho.DisplayMember = "TenNK";
            cboKho.ValueMember = "MaNK";
            cboKho.SelectedItem = null;
            cboKho.SelectedText = "--Chọn nhà kho--";

            cboNCC.DataSource = layer02.LayDanhSachNhaCungCapALL();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
            cboNCC.SelectedItem = null;
            cboNCC.SelectedText = "--Chọn nhà cung cấp--";
        }
    }
}
