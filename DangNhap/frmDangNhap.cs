using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        string chon = "";
        SqlConnection con = new SqlConnection(@"Data Source=HoangVanVietAnh;Initial Catalog=QuanLyDaoTao;Integrated Security=True");
        public frmDangNhap()
        {
            InitializeComponent();
            con.Open();
            laDNGiangVien.BackColor = Color.LightSkyBlue;
            chon = "GiangVien";
        }

        private void laDNGiangVien_Click(object sender, EventArgs e)
        {
            if (!txtMaSo.Text.Equals("Mã số"))
            {
                if (txtMaSo.TextLength == 0)
                {
                    laCheckTK.Text = "Bạn chưa nhập mã số giảng viên";
                }
                else
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
                }
                else
                {
                    laCheckTK.Text = "Mã số giảng viên không tồn tại !!!";
                    laCheckTK.ForeColor = Color.Red;
                }
                }
            }
            laDNGiangVien.BackColor = Color.LightSkyBlue;
            laDNSinhVien.BackColor = Color.LightGray;
            laDNDaoTao.BackColor = Color.LightGray;
            chon = "GiangVien";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void laDNSinhVien_Click(object sender, EventArgs e)
        {
            if (!txtMaSo.Text.Equals("Mã số"))
            {
                if (txtMaSo.TextLength == 0)
                {
                    laCheckTK.Text = "Bạn chưa nhập mã số sinh viên";
                }
                else
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
                }
                else
                {
                    laCheckTK.Text = "Mã số sinh viên không tồn tại !!!";
                    laCheckTK.ForeColor = Color.Red;
                }
                }
            }
            
            laDNGiangVien.BackColor = Color.LightGray;
            laDNSinhVien.BackColor = Color.LightSkyBlue;
            laDNDaoTao.BackColor = Color.LightGray;
            chon = "SinhVien";
        }

        private void laDNDaoTao_Click(object sender, EventArgs e)
        {
            if (!txtMaSo.Text.Equals("Mã số"))
            {
                if (txtMaSo.TextLength == 0)
                {
                    laCheckTK.Text = "Bạn chưa nhập mã số đào tạo";
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
                        laCheckTK.Text = "Mã số đào tạo không tồn tại !!!";
                        laCheckTK.ForeColor = Color.Red;
                    }
                }
                
            }
            laDNDaoTao.BackColor = Color.LightSkyBlue;
            laDNSinhVien.BackColor = Color.LightGray;
            laDNGiangVien.BackColor = Color.LightGray;
            chon = "Daotao";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (chon.Equals("SinhVien"))
            {
                int flat = 1;
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
            else if (chon.Equals("GiangVien"))
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
            if (chon.Equals("SinhVien"))
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
                }
                else
                {
                    laCheckTK.Text = "Mã số sinh viên không tồn tại !!!";
                    laCheckTK.ForeColor = Color.Red;
                }
            }
            else if (chon.Equals("GiangVien"))
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
                }
                else
                {
                    laCheckTK.Text = "Mã số giảng viên không tồn tại !!!";
                    laCheckTK.ForeColor = Color.Red;
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
