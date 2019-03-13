﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.IO;
using System.Data.SqlClient;

namespace DangNhap
{
    public partial class frmDTGiangVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Byte[] ImageByArray;
        SqlConnection con = new SqlConnection(@"Data Source=HoangVanVietAnh;Initial Catalog=QuanLyDaoTao;Integrated Security=True");
        public frmDTGiangVien()
        {
            InitializeComponent();
           
            // This line of code is generated by Data Source Configuration Wizard
            giangVien_SelectAllTableAdapter.Fill(qlDaoTaoDataSet.GiangVien_SelectAll);
        }

      

        private void btnThemGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            frmTTGiangVien frmTTGiangVien = new frmTTGiangVien();
            frmTTGiangVien.menu("Them");
            frmTTGiangVien.Show();
        }

        private void btnSuaGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            String maGV = gridVGiangVien.Columns.View.GetFocusedRowCellValue("maGV").ToString();
            String diaChi = gridVGiangVien.Columns.View.GetFocusedRowCellValue("diaChi").ToString();
            String soDT = gridVGiangVien.Columns.View.GetFocusedRowCellValue("SDT").ToString();
            String gioiTinh = gridVGiangVien.Columns.View.GetFocusedRowCellValue("gioiTinh").ToString();
            String hoTen = gridVGiangVien.Columns.View.GetFocusedRowCellValue("hoTen").ToString();
            String trinhDo = gridVGiangVien.Columns.View.GetFocusedRowCellValue("trinhDo").ToString();
            String thamNien = gridVGiangVien.Columns.View.GetFocusedRowCellValue("thamNien").ToString();
            String khoa = gridVGiangVien.Columns.View.GetFocusedRowCellValue("tenKhoa").ToString();
            String noiSinh = gridVGiangVien.Columns.View.GetFocusedRowCellValue("noiSinh").ToString();
            String email = gridVGiangVien.Columns.View.GetFocusedRowCellValue("email").ToString();
            String ngaySinh = gridVGiangVien.Columns.View.GetFocusedRowCellValue("ngaySinh").ToString();
            byte[] ImageArray = (byte[])gridVGiangVien.Columns.View.GetFocusedRowCellValue("hinh");
            //this.Close();

            frmTTGiangVien frmTTGiangVien = new frmTTGiangVien();
            frmTTGiangVien.TTGiangVien(maGV,hoTen,diaChi,soDT,gioiTinh,trinhDo,thamNien,khoa,email,noiSinh,ngaySinh, ImageArray);
            frmTTGiangVien.menu("Sua");
            frmTTGiangVien.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strFilePath = ofd.FileName;
                picGiangVien.Image = new Bitmap(strFilePath);
            }*/
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*if (strFilePath == "")
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
            sqlCmd.Parameters.Add("@maGV","GV004");
            sqlCmd.Parameters.Add("@hoTen","Viet Anh");
            sqlCmd.Parameters.Add("@gioiTinh","Nam");
            sqlCmd.Parameters.Add("@diaChi","GoVap HCM");
            sqlCmd.Parameters.Add("@SDT","090909222");
            sqlCmd.Parameters.Add("@ngaySinh","1998/10/7");
            sqlCmd.Parameters.Add("@noiSinh","Hai Duong");
            sqlCmd.Parameters.Add("@trinhDo","Thạc Sỹ");
            sqlCmd.Parameters.Add("@thamNien",3);
            sqlCmd.Parameters.Add("@quyen",2);
            sqlCmd.Parameters.Add("@maKhoa","CNTT");
            sqlCmd.Parameters.Add("@hinh",ImageByArray);
            sqlCmd.Parameters.Add("@email","veitem@gmail.com");
            sqlCmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("OK");
            this.Close();
            frmDTGiangVien frmDTGiangVien = new frmDTGiangVien();
            frmDTGiangVien.WindowState = FormWindowState.Maximized;
            frmDTGiangVien.Show();*/
        }

        private void gridVGiangVien_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            laHoTen.Text = gridVGiangVien.Columns.View.GetFocusedRowCellValue("hoTen").ToString();
            byte[] ImageArray = (byte[])gridVGiangVien.Columns.View.GetFocusedRowCellValue("hinh");
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

        private void frmDTGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDaoTao frmDaoTao = new frmDaoTao();
            frmDaoTao.Show();
        }

        private void btnXoaGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String maGV = gridVGiangVien.Columns.View.GetFocusedRowCellValue("maGV").ToString();
            SqlCommand sqlCmd = new SqlCommand("xoaGiangVien", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maGV", maGV);
            sqlCmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Xóa thành công ^^");
            this.Close();
            frmDTGiangVien frmDTGiangVien = new frmDTGiangVien();
            frmDTGiangVien.WindowState = FormWindowState.Maximized;
            frmDTGiangVien.Show();
        }
        public void loadGrid()
        {
            giangVien_SelectAllTableAdapter.Fill(qlDaoTaoDataSet.GiangVien_SelectAll);
        }
        private void Load_Click(object sender, EventArgs e)
        {

            giangVien_SelectAllTableAdapter.Fill(qlDaoTaoDataSet.GiangVien_SelectAll);
            //gridVGiangVien.UpdateCurrentRow();
            //gridVGiangVien.EndDataUpdate();
        }
    }
}