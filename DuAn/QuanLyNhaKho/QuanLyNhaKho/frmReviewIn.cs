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
using DevExpress.XtraEditors;

namespace QuanLyNhaKho
{
    public partial class frmReviewIn : Form
    {
        public frmReviewIn()
        {
            InitializeComponent();
        }

        public void InPhieuNhap(PhieuNhapDAO thongTinPhieuNhap, List<ChiTietHangHoaDAO> dataHangHoaNhap){
        
            XtraReportNhapHang reportNhapHang = new XtraReportNhapHang();

            // Bỏ submit paramater review report
            reportNhapHang.Parameters["SoPhieuNhap"].Visible = false;
            reportNhapHang.Parameters["NgayNhap"].Visible = false;
            reportNhapHang.Parameters["NguoiGiaoHang"].Visible = false;
            reportNhapHang.Parameters["NhapTaiKho"].Visible = false;
            reportNhapHang.Parameters["GhiChu"].Visible = false;
            reportNhapHang.Parameters["NguoiLapPhieu"].Visible = false;

            reportNhapHang.InitData(thongTinPhieuNhap, dataHangHoaNhap);

            documentViewer1.DocumentSource = reportNhapHang;
            reportNhapHang.CreateDocument();
        }
        public void InPhieuXuat(PhieuXuatDAO thongTinPhieuXuat, List<ChiTietHangHoaDAO> dataHangHoaXuat)
        {

            XtraReportPhieuXuat reportPhieuXuat = new XtraReportPhieuXuat();

            // Bỏ submit paramater review report
            reportPhieuXuat.Parameters["pSoPhieuXuat"].Visible = false;
            reportPhieuXuat.Parameters["pNgayXuat"].Visible = false;
            reportPhieuXuat.Parameters["pNguoiNhan"].Visible = false;
            reportPhieuXuat.Parameters["pXuatTaiKho"].Visible = false;
            reportPhieuXuat.Parameters["pGhiChu"].Visible = false;
            reportPhieuXuat.Parameters["pNguoiLapPhieu"].Visible = false;

            reportPhieuXuat.InitData(thongTinPhieuXuat, dataHangHoaXuat);

            documentViewer1.DocumentSource = reportPhieuXuat;
            reportPhieuXuat.CreateDocument();
        }

        public void InPhieuTonKho(List<KiemKeDAO> dataTonKho)
        {
            XtraReportTonKho reportTonKho = new XtraReportTonKho();

            reportTonKho.InitDataTonKho(dataTonKho);

            documentViewer1.DocumentSource = reportTonKho;
            reportTonKho.CreateDocument();
        }
        public void InPhieuHetHan(List<KiemKeDAO> dataHetHan)
        {
            XtraReportHetHanSuDung reportHetHan = new XtraReportHetHanSuDung();

            reportHetHan.InitDataHetHanSuDung(dataHetHan);

            documentViewer1.DocumentSource = reportHetHan;
            reportHetHan.CreateDocument();
        }
        public void InPhieuSapHetHan(List<KiemKeDAO> dataSapHetHan)
        {
            XtraReportSapHetHan reportSapHetHan = new XtraReportSapHetHan();

            reportSapHetHan.InitDataSapHetHan(dataSapHetHan);

            documentViewer1.DocumentSource = reportSapHetHan;
            reportSapHetHan.CreateDocument();
        }

        private void frmReviewIn_Load(object sender, EventArgs e)
        {

        }
    }
}
