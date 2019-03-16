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
            tbThamNien.Value = Convert.ToInt16(thamNien);
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

        private void tbThamNien_Scroll(object sender, EventArgs e)
        {
            txtMThamNien.Text = tbThamNien.Value.ToString();
        }

        private void txtMaGV_Leave(object sender, EventArgs e)
        {
            int flat = 0;
            SqlCommand sqlCmd = new SqlCommand("findGiangVien", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maGV", txtMaGV.Text);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                flat = 1;
            }
            DR.Close();
            if (flat == 1)
            {
                laCheckMaGV.Text = "Mã giảng viên đã tồn tại !!!";
            }
            else if (txtMaGV.TextLength == 0)
            {
                laCheckMaGV.Text = "Bạn chưa điền mã giảng viên nhé";
            }
            else
            {
                laCheckMaGV.Text = "";
            }
            
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.TextLength == 0)
            {
                laCheckHoTen.Text = "Bạn bỏ trống họ tên kìa lêu lêu";
            }
            else
            {
                laCheckHoTen.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.TextLength == 0)
            {
                laEmail.Text = "Email kêu bạn điền kìa ";
            }
            else
            {
                laEmail.Text = "";
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.TextLength == 0)
            {
                laDiaChi.Text = "Bạn là người ngoài hành tinh hả";
            }
            else
            {
                laDiaChi.Text = "";
            }
        }

        private void cbTrinhDo_Leave(object sender, EventArgs e)
        {
            if (cbTrinhDo.Text.Equals("                 -- Chọn Trình Độ --"))
            {
                laTrinhDo.Text = "Đồ lười biếng";
            }
            else
            {
                laTrinhDo.Text = "";
            }
        }

        private void cbKhoa_Leave(object sender, EventArgs e)
        {
            if (cbKhoa.Text.Equals("                     --Chọn Khoa--"))
            {
                laKhoa.Text = "Bạn ơi tíck đi";
            }
            else
            {
                laKhoa.Text = "";
            }
        }

        private void txtMSoDT_Leave(object sender, EventArgs e)
        {
            if (txtMSoDT.Text.Equals("(    )    -"))
            {
                laSoDT.Text = "Liên lạc với bạn bằng niềm tin à";
            }
            else
            {
                laSoDT.Text = "";
            }
        }

        private void laNoiSinh_Leave(object sender, EventArgs e)
        {
            if (txtNoiSinh.TextLength == 0)
            {
                laNoiSinh.Text = "Bạn ơi nơi bạn sinh ra ở đâu";
            }
            else
            {
                laNoiSinh.Text = "";
            }
        }
    }
}