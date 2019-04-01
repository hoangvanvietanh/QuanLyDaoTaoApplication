using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        string maSo = "";
        SqlConnection con = new SqlConnection(@"Data Source=HoangVanVietAnh;Initial Catalog=QuanLyDaoTao;Integrated Security=True");
        public frmDangNhap()
        {
            InitializeComponent();
            con.Open();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (maSo.Equals("SV"))
            {
                int flat = 0;
                SqlCommand sqlCmd = new SqlCommand("dangNhap", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@tenTK", txtMaSo.Text);
                sqlCmd.Parameters.AddWithValue("@matKhau", txtMatKhau.Text);
                sqlCmd.Parameters.AddWithValue("@quyen", 3);
                SqlDataReader DR = sqlCmd.ExecuteReader();
                while (DR.Read())
                {
                    
                    flat = 1;
                }
                if (flat==1)
                {
                    frmSinhVien sinhVien = new frmSinhVien();
                    sinhVien.Show();
                    this.Hide();
                }
                else
                {
                    txtCheckMK.Text = "Sai mật khẩu !!!";
                }
                DR.Close();
                
            }
            else if (maSo.Equals("GV"))
            {
                int flat = 0;
                SqlCommand sqlCmd = new SqlCommand("dangNhap", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@tenTK", txtMaSo.Text);
                sqlCmd.Parameters.AddWithValue("@matKhau", txtMatKhau.Text);
                sqlCmd.Parameters.AddWithValue("@quyen", 2);
                SqlDataReader DR = sqlCmd.ExecuteReader();
                while (DR.Read())
                {
                    flat = 1;
                    
                }
                DR.Close();
                if (flat == 1)
                {
                    sqlCmd = new SqlCommand("findGiangVien", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue("@maGV", txtMaSo.Text);
                    DR = sqlCmd.ExecuteReader();
                    while (DR.Read())
                    {
                        frmGiangVien giangVien = new frmGiangVien();
                        giangVien.TTGiangVien(DR[0].ToString(), DR[1].ToString(), DR[3].ToString(), DR[4].ToString(), DR[2].ToString(), DR[7].ToString(), DR[8].ToString(), DR[14].ToString(), DR[12].ToString(), DR[6].ToString(), DR[5].ToString(), (byte[])DR[11]);
                        giangVien.Show();

                    }
                    DR.Close();
                    this.Hide();
                }
                else
                {
                    txtCheckMK.Text = "Sai mật khẩu !!!";
                }
                DR.Close();
            }
            else
            {
                int flat = 0;
                SqlCommand sqlCmd = new SqlCommand("dangNhap", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@tenTK", txtMaSo.Text);
                sqlCmd.Parameters.AddWithValue("@matKhau", txtMatKhau.Text);
                sqlCmd.Parameters.AddWithValue("@quyen", 1);
                SqlDataReader DR = sqlCmd.ExecuteReader();
                while (DR.Read())
                {
                    flat = 1;
                    
                }
                if (flat == 1)
                {
                    frmDaoTao daoTao = new frmDaoTao();
                    daoTao.Show();
                    this.Hide();
                }
                else
                {
                    txtCheckMK.Text = "Sai mật khẩu !!!";
                }
                DR.Close();
            }

        }

        private void txtMaSo_Leave(object sender, EventArgs e)
        {
            if (txtMaSo.Text.Length == 0)
            {
                laCheckTK.Text = "Đừng bỏ trống nhé bạn ơi lỗi đó !!!";
            }
            else
            {
                maSo = txtMaSo.Text.Substring(0, 2);
            }
            if (maSo.Equals("SV"))
            {
                int flat = 0;
                SqlCommand sqlCmd = new SqlCommand("findTaiKhoan", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@tenTK", txtMaSo.Text);
                sqlCmd.Parameters.AddWithValue("@quyen", 3);
                SqlDataReader DR = sqlCmd.ExecuteReader();
                while (DR.Read())
                {
                    flat = 1;
                }
                DR.Close();
                if (flat == 1)
                {
                    laCheckTK.Text = "Mã số hợp lệ ^^";
                    laCheckTK.ForeColor = Color.Green;

                    sqlCmd = new SqlCommand("findDNSinhVien", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue("@maSV", txtMaSo.Text);
                    DR = sqlCmd.ExecuteReader();
                    while (DR.Read())
                    {
                        laHoTen.Text = "Xin chào " + DR[0].ToString();
                        rPicAvatar.Image = Image.FromStream(new MemoryStream((byte[])DR[1]));
                    }
                    DR.Close();
                }
                else
                {
                    laCheckTK.Text = "Mã số sinh viên không tồn tại !!!";
                    laCheckTK.ForeColor = Color.Red;

                    rPicAvatar.Image = DangNhap.Properties.Resources._19d8a051527db023e96c;
                    laHoTen.Text = "Welcome to Gia Định";
                }
            }
            else if (maSo.Equals("GV"))
            {
                int flat = 0;
                SqlCommand sqlCmd = new SqlCommand("findTaiKhoan", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@tenTK", txtMaSo.Text);
                sqlCmd.Parameters.AddWithValue("@quyen", 2);
                SqlDataReader DR = sqlCmd.ExecuteReader();
                while (DR.Read())
                {
                    flat = 1;
                }
                DR.Close();
                if (flat == 1)
                {
                    laCheckTK.Text = "Mã số hợp lệ ^^";
                    laCheckTK.ForeColor = Color.Green;

                    sqlCmd = new SqlCommand("findDNGiangVien", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue("@maGV", txtMaSo.Text);
                    DR = sqlCmd.ExecuteReader();
                    while (DR.Read())
                    {
                        laHoTen.Text = "Xin chào " + DR[0].ToString();
                        rPicAvatar.Image = Image.FromStream(new MemoryStream((byte[])DR[1]));
                    }
                    DR.Close();
                }
                else
                {
                    laCheckTK.Text = "Mã số giảng viên không tồn tại !!!";
                    laCheckTK.ForeColor = Color.Red;
                    rPicAvatar.Image = DangNhap.Properties.Resources._19d8a051527db023e96c;
                    laHoTen.Text = "Welcome to Gia Định";
                }
            }
            else
            {
                int flat = 0;
                SqlCommand sqlCmd = new SqlCommand("findTaiKhoan", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@tenTK", txtMaSo.Text);
                sqlCmd.Parameters.AddWithValue("@quyen", 1);
                SqlDataReader DR = sqlCmd.ExecuteReader();
                while (DR.Read())
                {
                    flat = 1;
                }
                DR.Close();
                if (flat == 1)
                {
                    laCheckTK.Text = "Mã số hợp lệ ^^";
                    laCheckTK.ForeColor = Color.Green;
                }
                else
                {
                    laCheckTK.Text = "Mã số không tồn tại !!!";
                    laCheckTK.ForeColor = Color.Red;
                }
            }
           
        }

        private void txtMaSo_Click(object sender, EventArgs e)
        {
            if (txtMaSo.Text.Equals("Mã số"))
            {
                txtMaSo.Clear();
            }
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Equals("Mật khẩu"))
            {
                txtMatKhau.Clear();
            }
        }
    }
}
