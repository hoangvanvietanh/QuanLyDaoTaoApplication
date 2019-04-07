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
using System.Configuration;

namespace DangNhap
{
    public partial class frmGiangVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Byte[] ImageByArray;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);
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
            this.Close();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
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

        private void laLichDay_Click(object sender, EventArgs e)
        {
            
        }

        private void laIn_Click(object sender, EventArgs e)
        {
            laIn.BackColor = Color.SkyBlue;
            laThongTin.BackColor = Color.Silver;
            using (frmPreviewReport frm = new frmPreviewReport())
            {
                frm.WindowState = FormWindowState.Maximized;
                frm.inGiangVien(laMaGV.Text, laHoTen.Text, laDiaChi.Text, laSoDT.Text, laGioiTinh.Text, laTrinhDo.Text, laThamNien.Text, laKhoa.Text, laEmail.Text, laNoiSinh.Text, laNgaySinh.Text, ImageByArray);
                frm.ShowDialog();
            }
        }
    }
}