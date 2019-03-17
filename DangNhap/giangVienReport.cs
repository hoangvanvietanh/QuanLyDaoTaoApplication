using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DangNhap
{
    public partial class giangVienReport : DevExpress.XtraReports.UI.XtraReport
    {
        public giangVienReport()
        {
            InitializeComponent();
        }
        public void paramGiangVien(String maGV, String hoTen, String diaChi, String soDT, String gioiTinh, String trinhDo, String thamNien, String khoa, String email, String noiSinh, String ngaySinh, byte[] ImageArray)
        {
            pMaGV.Value = maGV;
            pHoTen.Value = hoTen;
            pSoDT.Value = soDT;
            pTrinhDo.Value = trinhDo;
            pKhoa.Value = khoa;
            pNoiSinh.Value = noiSinh;
            pEmail.Value = email;
            pNgaySinh.Value = ngaySinh;
            String a = thamNien;
            pGioiTinh.Value = gioiTinh;
            pDiaChi.Value = diaChi;
            pHinh.Value = ImageArray;
            /*if (ImageArray.Length == 0)
            {
                picGiangVien.Image = null;
            }
            else
            {
                ImageByArray = ImageArray;
                picGiangVien.Image = Image.FromStream(new MemoryStream(ImageArray));
            }*/
        }
    }
}
