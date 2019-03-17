using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DangNhap
{
    public partial class frmPreviewReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPreviewReport()
        {
            InitializeComponent();
        }

        public void inGiangVien(String maGV, String hoTen, String diaChi, String soDT, String gioiTinh, String trinhDo, String thamNien, String khoa, String email, String noiSinh, String ngaySinh, byte[] ImageArray)
        {
            
            giangVienReport giangVienReport = new giangVienReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in giangVienReport.Parameters)
            {
                p.Visible = false;
            }
            giangVienReport.paramGiangVien(maGV, hoTen, diaChi, soDT, gioiTinh, trinhDo, thamNien, khoa, email, noiSinh, ngaySinh,ImageArray);
            giangVienReport.CreateDocument();
            documentViewer1.DocumentSource = giangVienReport;
            giangVienReport.CreateDocument();
        }

        public void inListGiangVien()
        {
            listGiangVienReport giangVienReport = new listGiangVienReport();
            giangVienReport.CreateDocument();
            documentViewer1.DocumentSource = giangVienReport;
            giangVienReport.CreateDocument();
        }
    }
}