using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyNhaKho.DAO;
using System.Collections.Generic;

namespace QuanLyNhaKho
{
    public partial class XtraReportTonKho : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportTonKho()
        {
            InitializeComponent();
        }

        public void InitDataTonKho(List<KiemKeDAO> dataTonKho)
        {
            objectDataSource1.DataSource = dataTonKho;
        }

    }
}
