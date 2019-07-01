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
    public partial class BaoCaoNhapKho : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        BLLayer02 layer02 = new BLLayer02();
        public BaoCaoNhapKho()
        {
            InitializeComponent();
        }
        public BaoCaoNhapKho(NhanVienDAO nv)
        {
            InitializeComponent();
            NVDangNhap = nv;
        }
        private void BaoCaoNhapKho_Load(object sender, EventArgs e)
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

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            XtraReportBaoCaoNhapKho reprortbaocaonhapkho = new XtraReportBaoCaoNhapKho();
            if (cboKho.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhà kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboKho.Focus();
            }
            else if (cboNCC.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNCC.Focus();
            }
            else
            {
                // Bỏ submit paramater review report
                reprortbaocaonhapkho.Parameters["pTuNgay"].Visible = false;
                reprortbaocaonhapkho.Parameters["pDenNgay"].Visible = false;
                reprortbaocaonhapkho.Parameters["pMaKho"].Visible = false;
                reprortbaocaonhapkho.Parameters["pTenKho"].Visible = false;
                reprortbaocaonhapkho.Parameters["pMaNCC"].Visible = false;
                reprortbaocaonhapkho.Parameters["pTenNhaCungCap"].Visible = false;

                // dữ liệu
                List<BaoCaoNhapKhoDAO> dataBaoCao = layer02.LayDuLieuBaoCaoNhapKho(cboKho.SelectedValue.ToString(), cboNCC.SelectedValue.ToString(), dtpTuNgay.Value, dtpDenNgay.Value);

                // lấy tên ncc và tên nhà kho
                string tenkho = layer02.GetTenKhoTheoMaKho(cboKho.SelectedValue.ToString());
                string tenNCC = layer02.GetTenNhaCungCapTheoMaNhaCungCap(cboNCC.SelectedValue.ToString());


                reprortbaocaonhapkho.InitData(dataBaoCao, dtpTuNgay.Value, dtpDenNgay.Value, cboKho.SelectedValue.ToString(), tenkho, cboNCC.SelectedValue.ToString(), tenNCC);

                documentViewer1.DocumentSource = reprortbaocaonhapkho;
                reprortbaocaonhapkho.CreateDocument();
            }
        }
    }
}
