using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyNhaKho.DAO;
using System.Collections.Generic;

namespace QuanLyNhaKho
{
    public partial class XtraReportSapHetHan : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportSapHetHan()
        {
            InitializeComponent();
        }

        public void InitDataSapHetHan(List<KiemKeDAO> dataSapHetHan)
        {
            objectDataSource2.DataSource = dataSapHetHan;
        }

    }
}
