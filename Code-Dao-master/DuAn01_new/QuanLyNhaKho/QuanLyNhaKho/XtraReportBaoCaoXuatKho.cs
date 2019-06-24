using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyNhaKho.DAO;
using System.Collections.Generic;

namespace QuanLyNhaKho
{
    public partial class XtraReportBaoCaoXuatKho : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBaoCaoXuatKho()
        {
            InitializeComponent();
        }
        public void InitData(List<BaoCaoXuatKhoDAO> dataBaoCao, DateTime tungay, DateTime denngay, string makho, string tenkho, string mancc, string tenncc)
        {
            pTuNgay.Value = tungay;
            pDenNgay.Value = denngay;
            pMaKho.Value = makho;
            pTenKho.Value = tenkho;
            pMaNCC.Value = mancc;
            pTenNhaCungCap.Value = tenncc;

            objectDataSource1.DataSource = dataBaoCao;

        }
    }
}
