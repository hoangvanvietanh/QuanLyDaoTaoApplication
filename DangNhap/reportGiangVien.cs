using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DangNhap
{
    public partial class reportGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        public reportGiangVien()
        {
            InitializeComponent();
        }
        public String setMaGV_Report(String maGV)
        {
            paraMaGV.Value = maGV;
            return maGV;
        }
    }
}
