using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyNhaKho.DAO;
using System.Collections.Generic;

namespace QuanLyNhaKho
{
    public partial class XtraReportHetHanSuDung : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportHetHanSuDung()
        {
            InitializeComponent();
        }

        public void InitDataHetHanSuDung(List<KiemKeDAO> dataHetHan)
        {
            objectDataSource1.DataSource = dataHetHan;
        }

    }
}
