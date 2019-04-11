using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DangNhap
{
    public partial class thoiKhoaBieuGVReport : DevExpress.XtraReports.UI.XtraReport
    {
        public thoiKhoaBieuGVReport()
        {
            InitializeComponent();
        }

        public void paramTKBGiangVien(String maGV)
        {
            parameter1.Value = maGV;
        }
    }
}
