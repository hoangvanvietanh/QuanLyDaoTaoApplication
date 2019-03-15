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
using System.Data.SqlClient;
using System.IO;

namespace DangNhap
{
    public partial class frmThongTinSV : DevExpress.XtraEditors.XtraForm
    {
        String strFilePath = "";
        Byte[] ImageByArray;
        String thaoTac;
        SqlConnection con = new SqlConnection(@"Data Source=HoangVanVietAnh;Initial Catalog=QuanLyDaoTao;Integrated Security=True");
        public frmThongTinSV()
        {
            InitializeComponent();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("selectAllNganhHoc", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                cbNganh.Items.Add(DR[1] + " " + DR[0]);

            }
            DR.Close();

            sqlCmd = new SqlCommand("selectAllLopHoc", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                cbLop.Items.Add(DR[1] + " " + DR[0]);

            }
            DR.Close();
        }
        public void TTSinhVien(String maSV, String hoTen, String diaChi, String soDT, String gioiTinh, String lopHoc, String nganhHoc, String khoa, String email, String noiSinh, String ngaySinh, byte[] ImageArray)
        {
            txtMaSV.Text = maSV;
            txtHoTen.Text = hoTen;
            txtMSoDT.Text = soDT;
            cbLop.Text = lopHoc;
            cbNganh.Text = nganhHoc;
            txtMKhoaHoc.Text = khoa;
            txtNoiSinh.Text = noiSinh;
            txtEmail.Text = email;
            txtNgaySinh.Text = ngaySinh;

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
                picSinhVien.Image = null;
            }
            else
            {
                ImageByArray = ImageArray;
                picSinhVien.Image = Image.FromStream(new MemoryStream(ImageArray));
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
                        picSinhVien.Image = new Bitmap(strFilePath);
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
                SqlCommand sqlCmd = new SqlCommand("SV_Insert", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maSV", txtMaSV.Text);
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
                sqlCmd.Parameters.AddWithValue("@maLop", cbLop.Text.Substring(cbLop.Text.LastIndexOf(' ') + 1));
                sqlCmd.Parameters.AddWithValue("@maNganh", cbNganh.Text.Substring(cbNganh.Text.LastIndexOf(' ') + 1));
                sqlCmd.Parameters.AddWithValue("@quyen", 3);
                sqlCmd.Parameters.AddWithValue("@khoa", txtMKhoaHoc.Text);
                sqlCmd.Parameters.AddWithValue("@hinh", ImageByArray);
                sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                sqlCmd.ExecuteNonQuery();
                sqlCmd = new SqlCommand("themTaiKhoan", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@tenTK", txtMaSV.Text);
                sqlCmd.Parameters.AddWithValue("@matKhau", "1");
                sqlCmd.Parameters.AddWithValue("@quyen", 3);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Lưu thành công ^^");
                this.Close();
                frmDTSinhVien frmDTGiangVien = new frmDTSinhVien();
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
                        picSinhVien.Image = new Bitmap(strFilePath);
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
                SqlCommand sqlCmd = new SqlCommand("SV_Update", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maSV", txtMaSV.Text);
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
                sqlCmd.Parameters.AddWithValue("@maLop", cbLop.Text.Substring(cbLop.Text.LastIndexOf(' ') + 1));
                sqlCmd.Parameters.AddWithValue("@maNganh", cbNganh.Text.Substring(cbNganh.Text.LastIndexOf(' ') + 1));
                sqlCmd.Parameters.AddWithValue("@quyen", 3);
                sqlCmd.Parameters.AddWithValue("@khoa", txtMKhoaHoc.Text);
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

        private void picSinhVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strFilePath = ofd.FileName;
                picSinhVien.Image = new Bitmap(strFilePath);
            }
        }
    }
}