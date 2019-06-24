using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyNhaKho.DAO;
using System.Collections.Generic;

namespace QuanLyNhaKho
{
    public partial class XtraReportNhapHang : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportNhapHang()
        {
            InitializeComponent();
        }


        public void InitData(PhieuNhapDAO thongTinPhieuNhap,List<ChiTietHangHoaDAO> dataHangNhap)
        {
            SoPhieuNhap.Value = thongTinPhieuNhap.SoPhieuNhap;

            NgayNhap.Value = thongTinPhieuNhap.NgayNhap;

            NguoiGiaoHang.Value = thongTinPhieuNhap.NguoiGiaoHang;

            NhapTaiKho.Value = thongTinPhieuNhap.NhapTaiKho;

            GhiChu.Value = thongTinPhieuNhap.GhiChu;

            NguoiLapPhieu.Value = thongTinPhieuNhap.TenNhanVienNhap;

            objectDataSource1.DataSource = dataHangNhap;
        }
    }
}
