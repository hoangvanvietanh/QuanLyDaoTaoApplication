using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DangNhap
{
    public partial class dsSinhVienTheoLopReport : DevExpress.XtraReports.UI.XtraReport
    {
        public dsSinhVienTheoLopReport()
        {
            InitializeComponent();
        }

        public void paramLop(String maLop)
        {
            parameter1.Value = maLop;
        }
    }
}
