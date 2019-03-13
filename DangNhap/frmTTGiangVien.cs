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
        String thaoTac;
        SqlConnection con = new SqlConnection(@"Data Source=HoangVanVietAnh;Initial Catalog=QuanLyDaoTao;Integrated Security=True");
        public frmTTGiangVien()
        {
            InitializeComponent();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("selectAllKhoa", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                cbKhoa.Items.Add(DR[1]);

            }
            DR.Close();
        }

        public void TTGiangVien(String maGV, String hoTen, String diaChi, String soDT, String gioiTinh, String trinhDo, String thamNien, String khoa, String email, String noiSinh, String ngaySinh, byte[] ImageArray)
        {
            txtMaGV.Text = maGV;
            txtHoTen.Text = hoTen;
            txtMSoDT.Text = soDT;
            cbTrinhDo.Text = trinhDo;
            cbKhoa.Text = khoa;
            txtNoiSinh.Text = noiSinh;
            txtEmail.Text = email;
            txtNgaySinh.Text = ngaySinh;
            if (thamNien.Length == 1)
            {
                txtMThamNien.Text = "0" + thamNien;
            }
            else
            {
                txtMThamNien.Text = thamNien;
            }
            if (gioiTinh.Equals("Nam"))
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtDiaChi.Text = diaChi;
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
        public void menu(String chon)
        {
            thaoTac = chon;
        }
        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {
            if (thaoTac.Equals("Them"))
            {
                if (strFilePath == "")
                {
                    /*if (ImageByArray.Length != 0)
                        ImageByArray = new byte[] { };*/
                    MessageBox.Show("Vui lòng chọn hình đại diện ^^");
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        strFilePath = ofd.FileName;
                        picGiangVien.Image = new Bitmap(strFilePath);
                    }
                    Image temp = new Bitmap(strFilePath);
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageByArray = strm.ToArray();
                }
                else
                {
                    Image temp = new Bitmap(strFilePath);
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageByArray = strm.ToArray();
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("GV_Insert", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maGV", txtMaGV.Text);
                sqlCmd.Parameters.AddWithValue("@hoTen", txtHoTen.Text);
                if (radNam.Checked == true)
                {
                    sqlCmd.Parameters.AddWithValue("@gioiTinh", "Nam");
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@gioiTinh", "Nữ");
                }
                sqlCmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
                sqlCmd.Parameters.AddWithValue("@SDT", txtMSoDT.Text);
                sqlCmd.Parameters.AddWithValue("@ngaySinh", txtNgaySinh.Text);
                sqlCmd.Parameters.AddWithValue("@noiSinh", txtNoiSinh.Text);
                sqlCmd.Parameters.AddWithValue("@trinhDo", cbTrinhDo.Text);
                sqlCmd.Parameters.AddWithValue("@thamNien", txtMThamNien.Text);
                sqlCmd.Parameters.AddWithValue("@quyen", 2);
                if (cbKhoa.Text.Equals("Công Nghệ Thông Tin"))
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
                sqlCmd = new SqlCommand("themTaiKhoan", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@tenTK", txtMaGV.Text);
                sqlCmd.Parameters.AddWithValue("@matKhau", "1");
                sqlCmd.Parameters.AddWithValue("@quyen", 2);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Lưu thành công ^^");
                this.Close();
                frmDTGiangVien frmDTGiangVien = new frmDTGiangVien();
                frmDTGiangVien.WindowState = FormWindowState.Maximized;
                frmDTGiangVien.Show();
            }
            else
            {
                if (strFilePath != "")
                {
                    /*if (ImageByArray.Length != 0)
                        ImageByArray = new byte[] { };*/
                    MessageBox.Show("Vui lòng chọn hình đại diện ^^");
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        strFilePath = ofd.FileName;
                        picGiangVien.Image = new Bitmap(strFilePath);
                    }
                    Image temp = new Bitmap(strFilePath);
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageByArray = strm.ToArray();
                }
                else
                {
                    if (ImageByArray == null)
                    {
                        Image temp = new Bitmap(strFilePath);
                        MemoryStream strm = new MemoryStream();
                        temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                        ImageByArray = strm.ToArray();
                    }
                    
                    //picGiangVien.Image = Image.FromStream(new MemoryStream(ImageByArray));
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("GV_Update", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maGV", txtMaGV.Text);
                sqlCmd.Parameters.AddWithValue("@hoTen", txtHoTen.Text);
                if (radNam.Checked == true)
                {
                    sqlCmd.Parameters.AddWithValue("@gioiTinh", "Nam");
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@gioiTinh", "Nữ");
                }
                sqlCmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
                sqlCmd.Parameters.AddWithValue("@SDT", txtMSoDT.Text);
                sqlCmd.Parameters.AddWithValue("@ngaySinh", txtNgaySinh.Text);
                sqlCmd.Parameters.AddWithValue("@noiSinh", txtNoiSinh.Text);
                sqlCmd.Parameters.AddWithValue("@trinhDo", cbTrinhDo.Text);
                sqlCmd.Parameters.AddWithValue("@thamNien", txtMThamNien.Text);
                sqlCmd.Parameters.AddWithValue("@quyen", 2);
                if (cbKhoa.Text.Equals("Công Nghệ Thông Tin"))
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
                MessageBox.Show("Lưu thành công ^^");
                this.Close();
                // frmDTGiangVien frmDTGiangVien = new frmDTGiangVien();
                //frmDTGiangVien.WindowState = FormWindowState.Maximized;
                //frmDTGiangVien.Show();
            }
            
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