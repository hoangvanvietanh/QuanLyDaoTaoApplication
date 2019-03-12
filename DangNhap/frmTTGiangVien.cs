using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.SqlClient;

namespace DangNhap
{
    public partial class frmTTGiangVien : DevExpress.XtraEditors.XtraForm
    {
        String strFilePath = "";
        Byte[] ImageByArray;
        SqlConnection con = new SqlConnection(@"Data Source=HoangVanVietAnh;Initial Catalog=QuanLyDaoTao;Integrated Security=True");
        public frmTTGiangVien()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {
            if (strFilePath == "")
            {
                if (ImageByArray.Length != 0)
                    ImageByArray = new byte[] { };
            }
            else
            {
                Image temp = new Bitmap(strFilePath);
                MemoryStream strm = new MemoryStream();
                temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                ImageByArray = strm.ToArray();
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand sqlCmd = new SqlCommand("GV_Insert", con) { CommandType = CommandType.StoredProcedure };
            sqlCmd.Parameters.AddWithValue("@maGV", txtMaGV.Text);
            sqlCmd.Parameters.AddWithValue("@hoTen", txtHoTen.Text);
            sqlCmd.Parameters.AddWithValue("@gioiTinh", txtGioiTinh.Text);
            sqlCmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
            sqlCmd.Parameters.AddWithValue("@SDT", txtSoDT.Text);
            sqlCmd.Parameters.AddWithValue("@ngaySinh", txtNgaySinh.Text);
            sqlCmd.Parameters.AddWithValue("@noiSinh", txtNoiSinh.Text);
            sqlCmd.Parameters.AddWithValue("@trinhDo", txtTrinhDo.Text);
            sqlCmd.Parameters.AddWithValue("@thamNien", txtThamNien.Text);
            sqlCmd.Parameters.AddWithValue("@quyen", 2);
            if (txtKhoa.Text.Equals("Công Nghệ Thông Tin"))
            {
                sqlCmd.Parameters.AddWithValue("@maKhoa", "CNTT");
            }
            else
            {
                sqlCmd.Parameters.AddWithValue("@maKhoa", "MMT");
            }
            
            sqlCmd.Parameters.AddWithValue("@hinh", ImageByArray);
            sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlCmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("OK");
            this.Close();
            frmDTGiangVien frmDTGiangVien = new frmDTGiangVien();
            frmDTGiangVien.WindowState = FormWindowState.Maximized;
            frmDTGiangVien.Show();
        }

        private void windowsUIButtonPanelCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picGiangVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strFilePath = ofd.FileName;
                picGiangVien.Image = new Bitmap(strFilePath);
            }
        }
    }
}