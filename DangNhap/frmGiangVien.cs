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
using System.Data.SqlClient;
using System.IO;

namespace DangNhap
{
    public partial class frmGiangVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Byte[] ImageByArray;
        SqlConnection con = new SqlConnection(@"Data Source=HoangVanVietAnh;Initial Catalog=QuanLyDaoTao;Integrated Security=True");
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void laThongTin_Click(object sender, EventArgs e)
        {
            laThongTin.BackColor = Color.SkyBlue;
            paShowThongTin.Dock = DockStyle.Fill;
        }

        private void laThoat_Click(object sender, EventArgs e)
        {
            laThoat.BackColor = Color.SkyBlue;
            this.Close();
        }

        public void TTGiangVien(String maGV, String hoTen, String diaChi, String soDT, String gioiTinh, String trinhDo, String thamNien, String khoa, String email, String noiSinh, String ngaySinh, byte[] ImageArray)
        {
            laMaGV.Text = maGV;
            laHoTen.Text = hoTen;
            laSoDT.Text = soDT;
            laTrinhDo.Text = trinhDo;
            laKhoa.Text = khoa;
            laNoiSinh.Text = noiSinh;
            laEmail.Text = email;
            laNgaySinh.Text = ngaySinh;
            laThamNien.Text = thamNien;
            laGioiTinh.Text = gioiTinh;
            laDiaChi.Text = diaChi;
            if (ImageArray.Length == 0)
            {
                picGiangVien.Image = null;
            }
            else
            {
                ImageByArray = ImageArray;
                picGiangVien.Image = Image.FromStream(new MemoryStream(ImageArray));
            }
        }
    }
}