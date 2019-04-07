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
using System.Configuration;

namespace DangNhap
{
    public partial class frmPhanCong : DevExpress.XtraEditors.XtraForm
    {
        String[] buoiHoc = new string[2];
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);
        public frmPhanCong()
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
                cbKhoaGV.Properties.Items.Add(DR[1]);
                cbKhoaLop.Properties.Items.Add(DR[1]);
            }
            DR.Close();
            con.Close();
        }

        private void cbKhoaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            timKhoaGVTableAdapter.Fill(qlDaoTaoDataSet.timKhoaGV,cbKhoaGV.SelectedItem.ToString());
            //timKhoaLopHocTableAdapter.Fill(qlDaoTaoDataSet.timKhoaLopHoc, cbKhoaGV.SelectedItem.ToString());
            //GetData("Công Nghệ Thông Tin")
        }

        private void cbKhoaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            timKhoaLopHocTableAdapter.Fill(qlDaoTaoDataSet1.timKhoaLopHoc, cbKhoaLop.SelectedItem.ToString());
        }

        private void gridVLop_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            laLop.Text = gridVLop.Columns.View.GetFocusedRowCellValue("maLop").ToString();
            int[] check = new int[28];
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("XemThoiKhoaBieuTheoLop", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("maLop", gridVLop.Columns.View.GetFocusedRowCellValue("maLop").ToString());
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    check[1] = 1; 
                    cb2T2Ca1.Text = DR[1].ToString();
                    cb2T2Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T2Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T2Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T2Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T2Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
               else
                {
                    if (check[1] == 0)
                    {
                        cb2T2Ca1.Text = "";
                        cb2T2Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    check[2] = 1;
                    cb2T2Ca2.Text = DR[1].ToString();
                    cb2T2Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T2Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T2Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T2Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T2Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[2] == 0)
                    {
                        cb2T2Ca2.Text = "";
                        cb2T2Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    check[3] = 1;
                    cb2T2Ca3.Text = DR[1].ToString();
                    cb2T2Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T2Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T2Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T2Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T2Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[3] == 0)
                    {
                        cb2T2Ca3.Text = "";
                        cb2T2Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    check[4] = 1;
                    cb2T2Ca4.Text = DR[1].ToString();
                    cb2T2Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T2Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T2Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T2Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T2Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[4] == 0)
                    {
                        cb2T2Ca4.Text = "";
                        cb2T2Ca4.Properties.Items.Clear();
                    }
                }

            }
            con.Close();
        }

        private void gridVKhoaGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            laGV.Text = gridVKhoaGV.Columns.View.GetFocusedRowCellValue("hoTen").ToString();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("XemThoiKhoaBieuTheoGV", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("maGV", gridVKhoaGV.Columns.View.GetFocusedRowCellValue("maGV").ToString());
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbT2Ca1.Text = DR[1].ToString();
                    cbT2Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cbT2Ca2.Text = DR[1].ToString();
                    cbT2Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cbT2Ca3.Text = DR[1].ToString();
                    cbT2Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cbT2Ca4.Text = DR[1].ToString();
                    cbT2Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
            }
            con.Close();
        }

        private void listThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String a = listThu.SelectedIndex.ToString();
            //MessageBox.Show(a);
        }

        private void cT2Ca1_CheckedChanged(object sender, EventArgs e)
        {
            if (cT2Ca1.Checked == true)
            {
                buoiHoc[1] = "1T2";
                MessageBox.Show(buoiHoc[1]);
            }
            else
            {
                buoiHoc[1] = "";
                MessageBox.Show(buoiHoc[1]);
            }
        }
    }
}