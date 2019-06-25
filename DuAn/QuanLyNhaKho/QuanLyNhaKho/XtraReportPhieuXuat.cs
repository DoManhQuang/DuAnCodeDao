using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyNhaKho.DAO;
using System.Collections.Generic;

namespace QuanLyNhaKho
{
    public partial class XtraReportPhieuXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportPhieuXuat()
        {
            InitializeComponent();
        }

        public void InitData(PhieuXuatDAO thongTinPhieuNhap, List<ChiTietHangHoaDAO> dataHangXuat)
        {
            pSoPhieuXuat.Value = thongTinPhieuNhap.SoPhieuXuat;

            pNgayXuat.Value = thongTinPhieuNhap.NgayXuat;

            pNguoiNhan.Value = thongTinPhieuNhap.NguoiNhanHang;

            pXuatTaiKho.Value = thongTinPhieuNhap.XuatTaiKho;

            pGhiChu.Value = thongTinPhieuNhap.GhiChu;

            pNguoiLapPhieu.Value = thongTinPhieuNhap.TenNhanVienXuat;

            objectDataSource2.DataSource = dataHangXuat;
        }

    }
}
