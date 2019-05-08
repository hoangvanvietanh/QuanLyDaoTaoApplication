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
        public String phongHoc = "";
        public String suaPhongHoc = "";
        public String action = "";
        public String maBuoiHoc = "";
        public String maPhong = "";
        public String[] buoiHoc = new string[24];
        public String suaBuoiHoc = "";
        public int kiemTraSua = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);
        public frmPhanCong()
        {
            InitializeComponent();
            con.Open();
            action = "them";
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
            int flag = 0;
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
                flag++;
                //////////////////T2
                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cb2T2Ca1.Properties.Items.Clear();
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
                    cb2T2Ca2.Properties.Items.Clear();
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
                    cb2T2Ca3.Properties.Items.Clear();
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
                    cb2T2Ca4.Properties.Items.Clear();
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

                //////////////////T3
                if (Convert.ToInt16(DR[4].ToString()) == 3 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cb2T3Ca1.Properties.Items.Clear();
                    check[5] = 1;
                    cb2T3Ca1.Text = DR[1].ToString();
                    cb2T3Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T3Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T3Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T3Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T3Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[5] == 0)
                    {
                        cb2T3Ca1.Text = "";
                        cb2T3Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 3 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cb2T3Ca2.Properties.Items.Clear();
                    check[6] = 1;
                    cb2T3Ca2.Text = DR[1].ToString();
                    cb2T3Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T3Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T3Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T3Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T3Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[6] == 0)
                    {
                        cb2T3Ca2.Text = "";
                        cb2T3Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 3 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cb2T3Ca3.Properties.Items.Clear();
                    check[7] = 1;
                    cb2T3Ca3.Text = DR[1].ToString();
                    cb2T3Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T3Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T3Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T3Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T3Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[7] == 0)
                    {
                        cb2T3Ca3.Text = "";
                        cb2T3Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 3 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cb2T3Ca4.Properties.Items.Clear();
                    check[8] = 1;
                    cb2T3Ca4.Text = DR[1].ToString();
                    cb2T3Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T3Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T3Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T3Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T3Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[8] == 0)
                    {
                        cb2T3Ca4.Text = "";
                        cb2T3Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T4
                if (Convert.ToInt16(DR[4].ToString()) == 4 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cb2T4Ca1.Properties.Items.Clear();
                    check[9] = 1;
                    cb2T4Ca1.Text = DR[1].ToString();
                    cb2T4Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T4Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T4Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T4Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T4Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[9] == 0)
                    {
                        cb2T4Ca1.Text = "";
                        cb2T4Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 4 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cb2T4Ca2.Properties.Items.Clear();
                    check[10] = 1;
                    cb2T4Ca2.Text = DR[1].ToString();
                    cb2T4Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T4Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T4Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T4Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T4Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[10] == 0)
                    {
                        cb2T4Ca2.Text = "";
                        cb2T4Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 4 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cb2T4Ca3.Properties.Items.Clear();
                    check[11] = 1;
                    cb2T4Ca3.Text = DR[1].ToString();
                    cb2T4Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T4Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T4Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T4Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T4Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[11] == 0)
                    {
                        cb2T4Ca3.Text = "";
                        cb2T4Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 4 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cb2T4Ca4.Properties.Items.Clear();
                    check[12] = 1;
                    cb2T4Ca4.Text = DR[1].ToString();
                    cb2T4Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T4Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T4Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T4Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T4Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[12] == 0)
                    {
                        cb2T4Ca4.Text = "";
                        cb2T4Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T5
                if (Convert.ToInt16(DR[4].ToString()) == 5 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cb2T5Ca1.Properties.Items.Clear();
                    check[13] = 1;
                    cb2T5Ca1.Text = DR[1].ToString();
                    cb2T5Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T5Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T5Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T5Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T5Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[13] == 0)
                    {
                        cb2T5Ca1.Text = "";
                        cb2T5Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 5 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cb2T5Ca2.Properties.Items.Clear();
                    check[14] = 1;
                    cb2T5Ca2.Text = DR[1].ToString();
                    cb2T5Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T5Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T5Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T5Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T5Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[14] == 0)
                    {
                        cb2T5Ca2.Text = "";
                        cb2T5Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 5 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cb2T5Ca3.Properties.Items.Clear();
                    check[15] = 1;
                    cb2T5Ca3.Text = DR[1].ToString();
                    cb2T5Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T5Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T5Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T5Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T5Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[15] == 0)
                    {
                        cb2T5Ca3.Text = "";
                        cb2T5Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 5 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cb2T5Ca4.Properties.Items.Clear();
                    check[16] = 1;
                    cb2T5Ca4.Text = DR[1].ToString();
                    cb2T5Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T5Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T5Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T5Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T5Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[16] == 0)
                    {
                        cb2T5Ca4.Text = "";
                        cb2T5Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T6
                if (Convert.ToInt16(DR[4].ToString()) == 6 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cb2T6Ca1.Properties.Items.Clear();
                    check[17] = 1;
                    cb2T6Ca1.Text = DR[1].ToString();
                    cb2T6Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T6Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T6Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T6Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T6Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[17] == 0)
                    {
                        cb2T6Ca1.Text = "";
                        cb2T6Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 6 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cb2T6Ca2.Properties.Items.Clear();
                    check[18] = 1;
                    cb2T6Ca2.Text = DR[1].ToString();
                    cb2T6Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T6Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T6Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T6Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T6Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[18] == 0)
                    {
                        cb2T6Ca2.Text = "";
                        cb2T6Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 6 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cb2T6Ca3.Properties.Items.Clear();
                    check[19] = 1;
                    cb2T6Ca3.Text = DR[1].ToString();
                    cb2T6Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T6Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T6Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T6Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T6Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[19] == 0)
                    {
                        cb2T6Ca3.Text = "";
                        cb2T6Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 6 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cb2T6Ca4.Properties.Items.Clear();
                    check[20] = 1;
                    cb2T6Ca4.Text = DR[1].ToString();
                    cb2T6Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T6Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T6Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T6Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T6Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[20] == 0)
                    {
                        cb2T6Ca4.Text = "";
                        cb2T6Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T7
                if (Convert.ToInt16(DR[4].ToString()) == 7 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cb2T7Ca1.Properties.Items.Clear();
                    check[21] = 1;
                    cb2T7Ca1.Text = DR[1].ToString();
                    cb2T7Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T7Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T7Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T7Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T7Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[21] == 0)
                    {
                        cb2T7Ca1.Text = "";
                        cb2T7Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 7 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cb2T7Ca2.Properties.Items.Clear();
                    check[22] = 1;
                    cb2T7Ca2.Text = DR[1].ToString();
                    cb2T7Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T7Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T7Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T7Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T7Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[22] == 0)
                    {
                        cb2T7Ca2.Text = "";
                        cb2T7Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 7 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cb2T7Ca3.Properties.Items.Clear();
                    check[23] = 1;
                    cb2T7Ca3.Text = DR[1].ToString();
                    cb2T7Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T7Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T7Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T7Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T7Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[23] == 0)
                    {
                        cb2T7Ca3.Text = "";
                        cb2T7Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 7 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cb2T7Ca4.Properties.Items.Clear();
                    check[24] = 1;
                    cb2T7Ca4.Text = DR[1].ToString();
                    cb2T7Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cb2T7Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cb2T7Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cb2T7Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cb2T7Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[24] == 0)
                    {
                        cb2T7Ca4.Text = "";
                        cb2T7Ca4.Properties.Items.Clear();
                    }
                }

            }
            if (flag == 0)
            {
                cb2T2Ca1.Text = "";
                cb2T2Ca1.Properties.Items.Clear();
                cb2T2Ca2.Text = "";
                cb2T2Ca2.Properties.Items.Clear();
                cb2T2Ca3.Text = "";
                cb2T2Ca3.Properties.Items.Clear();
                cb2T2Ca4.Text = "";
                cb2T2Ca4.Properties.Items.Clear();

                cb2T3Ca1.Text = "";
                cb2T3Ca1.Properties.Items.Clear();
                cb2T3Ca2.Text = "";
                cb2T3Ca2.Properties.Items.Clear();
                cb2T3Ca3.Text = "";
                cb2T3Ca3.Properties.Items.Clear();
                cb2T3Ca4.Text = "";
                cb2T3Ca4.Properties.Items.Clear();

                cb2T4Ca1.Text = "";
                cb2T4Ca1.Properties.Items.Clear();
                cb2T4Ca2.Text = "";
                cb2T4Ca2.Properties.Items.Clear();
                cb2T4Ca3.Text = "";
                cb2T4Ca3.Properties.Items.Clear();
                cb2T4Ca4.Text = "";
                cb2T4Ca4.Properties.Items.Clear();

                cb2T5Ca1.Text = "";
                cb2T5Ca1.Properties.Items.Clear();
                cb2T5Ca2.Text = "";
                cb2T5Ca2.Properties.Items.Clear();
                cb2T5Ca3.Text = "";
                cb2T5Ca3.Properties.Items.Clear();
                cb2T5Ca4.Text = "";
                cb2T5Ca4.Properties.Items.Clear();

                cb2T6Ca1.Text = "";
                cb2T6Ca1.Properties.Items.Clear();
                cb2T6Ca2.Text = "";
                cb2T6Ca2.Properties.Items.Clear();
                cb2T6Ca3.Text = "";
                cb2T6Ca3.Properties.Items.Clear();
                cb2T6Ca4.Text = "";
                cb2T6Ca4.Properties.Items.Clear();

                cb2T7Ca1.Text = "";
                cb2T7Ca1.Properties.Items.Clear();
                cb2T7Ca2.Text = "";
                cb2T7Ca2.Properties.Items.Clear();
                cb2T7Ca3.Text = "";
                cb2T7Ca3.Properties.Items.Clear();
                cb2T7Ca4.Text = "";
                cb2T7Ca4.Properties.Items.Clear();

            }
            DR.Close();
            con.Close();
            loadPhong();
        }

        private void gridVKhoaGV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (action.Equals("sua"))
            {
                taoMoi();
            }
            
            int flag = 0;
            int[] check = new int[28];
            laGV.Text = gridVKhoaGV.Columns.View.GetFocusedRowCellValue("hoTen").ToString();
            laMaGV.Text = gridVKhoaGV.Columns.View.GetFocusedRowCellValue("maGV").ToString();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("XemThoiKhoaBieuTheoGV", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("maGV", gridVKhoaGV.Columns.View.GetFocusedRowCellValue("maGV").ToString());
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                flag++;
                //////////////////T2
                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbT2Ca1.Properties.Items.Clear();
                    check[1] = 1;
                    cbT2Ca1.Text = DR[1].ToString();
                    cbT2Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[1] == 0)
                    {
                        cbT2Ca1.Text = "";
                        cbT2Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cbT2Ca2.Properties.Items.Clear();
                    check[2] = 1;
                    cbT2Ca2.Text = DR[1].ToString();
                    cbT2Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[2] == 0)
                    {
                        cbT2Ca2.Text = "";
                        cbT2Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cbT2Ca3.Properties.Items.Clear();
                    check[3] = 1;
                    cbT2Ca3.Text = DR[1].ToString();
                    cbT2Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[3] == 0)
                    {
                        cbT2Ca3.Text = "";
                        cbT2Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cbT2Ca4.Properties.Items.Clear();
                    check[4] = 1;
                    cbT2Ca4.Text = DR[1].ToString();
                    cbT2Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[4] == 0)
                    {
                        cbT2Ca4.Text = "";
                        cbT2Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T3
                if (Convert.ToInt16(DR[4].ToString()) == 3 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbT3Ca1.Properties.Items.Clear();
                    check[5] = 1;
                    cbT3Ca1.Text = DR[1].ToString();
                    cbT3Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT3Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT3Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT3Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT3Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[5] == 0)
                    {
                        cbT3Ca1.Text = "";
                        cbT3Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 3 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cbT3Ca2.Properties.Items.Clear();
                    check[6] = 1;
                    cbT3Ca2.Text = DR[1].ToString();
                    cbT3Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT3Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT3Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT3Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT3Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[6] == 0)
                    {
                        cbT3Ca2.Text = "";
                        cbT3Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 3 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cbT3Ca3.Properties.Items.Clear();
                    check[7] = 1;
                    cbT3Ca3.Text = DR[1].ToString();
                    cbT3Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT3Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT3Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT3Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT3Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[7] == 0)
                    {
                        cbT3Ca3.Text = "";
                        cbT3Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 3 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cbT3Ca4.Properties.Items.Clear();
                    check[8] = 1;
                    cbT3Ca4.Text = DR[1].ToString();
                    cbT3Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT3Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT3Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT3Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT3Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[8] == 0)
                    {
                        cbT3Ca4.Text = "";
                        cbT3Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T4
                if (Convert.ToInt16(DR[4].ToString()) == 4 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbT4Ca1.Properties.Items.Clear();
                    check[9] = 1;
                    cbT4Ca1.Text = DR[1].ToString();
                    cbT4Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT4Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT4Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT4Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT4Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[9] == 0)
                    {
                        cbT4Ca1.Text = "";
                        cbT4Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 4 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cbT4Ca2.Properties.Items.Clear();
                    check[10] = 1;
                    cbT4Ca2.Text = DR[1].ToString();
                    cbT4Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT4Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT4Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT4Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT4Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[10] == 0)
                    {
                        cbT4Ca2.Text = "";
                        cbT4Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 4 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cbT4Ca3.Properties.Items.Clear();
                    check[11] = 1;
                    cbT4Ca3.Text = DR[1].ToString();
                    cbT4Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT4Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT4Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT4Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT4Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[11] == 0)
                    {
                        cbT4Ca3.Text = "";
                        cbT4Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 4 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cbT4Ca4.Properties.Items.Clear();
                    check[12] = 1;
                    cbT4Ca4.Text = DR[1].ToString();
                    cbT4Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT4Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT4Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT4Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT4Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[12] == 0)
                    {
                        cbT4Ca4.Text = "";
                        cbT4Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T5
                if (Convert.ToInt16(DR[4].ToString()) == 5 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbT5Ca1.Properties.Items.Clear();
                    check[13] = 1;
                    cbT5Ca1.Text = DR[1].ToString();
                    cbT5Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT5Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT5Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT5Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT5Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[13] == 0)
                    {
                        cbT5Ca1.Text = "";
                        cbT5Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 5 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cbT5Ca2.Properties.Items.Clear();
                    check[14] = 1;
                    cbT5Ca2.Text = DR[1].ToString();
                    cbT5Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT5Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT5Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT5Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT5Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[14] == 0)
                    {
                        cbT5Ca2.Text = "";
                        cbT5Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 5 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cbT5Ca3.Properties.Items.Clear();
                    check[15] = 1;
                    cbT5Ca3.Text = DR[1].ToString();
                    cbT5Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT5Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT5Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT5Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT5Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[15] == 0)
                    {
                        cbT5Ca3.Text = "";
                        cbT5Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 5 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cbT5Ca4.Properties.Items.Clear();
                    check[16] = 1;
                    cbT5Ca4.Text = DR[1].ToString();
                    cbT5Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT5Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT5Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT5Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT5Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[16] == 0)
                    {
                        cbT5Ca4.Text = "";
                        cbT5Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T6
                if (Convert.ToInt16(DR[4].ToString()) == 6 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbT6Ca1.Properties.Items.Clear();
                    check[17] = 1;
                    cbT6Ca1.Text = DR[1].ToString();
                    cbT6Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT6Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT6Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT6Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT6Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[17] == 0)
                    {
                        cbT6Ca1.Text = "";
                        cbT6Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 6 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cbT6Ca2.Properties.Items.Clear();
                    check[18] = 1;
                    cbT6Ca2.Text = DR[1].ToString();
                    cbT6Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT6Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT6Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT6Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT6Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[18] == 0)
                    {
                        cbT6Ca2.Text = "";
                        cbT6Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 6 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cbT6Ca3.Properties.Items.Clear();
                    check[19] = 1;
                    cbT6Ca3.Text = DR[1].ToString();
                    cbT6Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT6Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT6Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT6Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT6Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[19] == 0)
                    {
                        cbT6Ca3.Text = "";
                        cbT6Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 6 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cbT6Ca4.Properties.Items.Clear();
                    check[20] = 1;
                    cbT6Ca4.Text = DR[1].ToString();
                    cbT6Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT6Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT6Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT6Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT6Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[20] == 0)
                    {
                        cbT6Ca4.Text = "";
                        cbT6Ca4.Properties.Items.Clear();
                    }
                }

                //////////////////T7
                if (Convert.ToInt16(DR[4].ToString()) == 7 && Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbT7Ca1.Properties.Items.Clear();
                    check[21] = 1;
                    cbT7Ca1.Text = DR[1].ToString();
                    cbT7Ca1.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT7Ca1.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT7Ca1.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT7Ca1.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT7Ca1.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[21] == 0)
                    {
                        cbT7Ca1.Text = "";
                        cbT7Ca1.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 7 && Convert.ToInt16(DR[5].ToString()) == 2)
                {
                    cbT7Ca2.Properties.Items.Clear();
                    check[22] = 1;
                    cbT7Ca2.Text = DR[1].ToString();
                    cbT7Ca2.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT7Ca2.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT7Ca2.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT7Ca2.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT7Ca2.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[22] == 0)
                    {
                        cbT7Ca2.Text = "";
                        cbT7Ca2.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 7 && Convert.ToInt16(DR[5].ToString()) == 3)
                {
                    cbT7Ca3.Properties.Items.Clear();
                    check[23] = 1;
                    cbT7Ca3.Text = DR[1].ToString();
                    cbT7Ca3.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT7Ca3.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT7Ca3.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT7Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT7Ca3.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[23] == 0)
                    {
                        cbT7Ca3.Text = "";
                        cbT7Ca3.Properties.Items.Clear();
                    }
                }

                if (Convert.ToInt16(DR[4].ToString()) == 7 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cbT7Ca4.Properties.Items.Clear();
                    check[24] = 1;
                    cbT7Ca4.Text = DR[1].ToString();
                    cbT7Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT7Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT7Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT7Ca4.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT7Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
                else
                {
                    if (check[24] == 0)
                    {
                        cbT7Ca4.Text = "";
                        cbT7Ca4.Properties.Items.Clear();
                    }
                }
            }
            if (flag == 0)
            {
                cbT2Ca1.Text = "";
                cbT2Ca1.Properties.Items.Clear();
                cbT2Ca2.Text = "";
                cbT2Ca2.Properties.Items.Clear();
                cbT2Ca3.Text = "";
                cbT2Ca3.Properties.Items.Clear();
                cbT2Ca4.Text = "";
                cbT2Ca4.Properties.Items.Clear();

                cbT3Ca1.Text = "";
                cbT3Ca1.Properties.Items.Clear();
                cbT3Ca2.Text = "";
                cbT3Ca2.Properties.Items.Clear();
                cbT3Ca3.Text = "";
                cbT3Ca3.Properties.Items.Clear();
                cbT3Ca4.Text = "";
                cbT3Ca4.Properties.Items.Clear();

                cbT4Ca1.Text = "";
                cbT4Ca1.Properties.Items.Clear();
                cbT4Ca2.Text = "";
                cbT4Ca2.Properties.Items.Clear();
                cbT4Ca3.Text = "";
                cbT4Ca3.Properties.Items.Clear();
                cbT4Ca4.Text = "";
                cbT4Ca4.Properties.Items.Clear();

                cbT5Ca1.Text = "";
                cbT5Ca1.Properties.Items.Clear();
                cbT5Ca2.Text = "";
                cbT5Ca2.Properties.Items.Clear();
                cbT5Ca3.Text = "";
                cbT5Ca3.Properties.Items.Clear();
                cbT5Ca4.Text = "";
                cbT5Ca4.Properties.Items.Clear();

                cbT6Ca1.Text = "";
                cbT6Ca1.Properties.Items.Clear();
                cbT6Ca2.Text = "";
                cbT6Ca2.Properties.Items.Clear();
                cbT6Ca3.Text = "";
                cbT6Ca3.Properties.Items.Clear();
                cbT6Ca4.Text = "";
                cbT6Ca4.Properties.Items.Clear();

                cbT7Ca1.Text = "";
                cbT7Ca1.Properties.Items.Clear();
                cbT7Ca2.Text = "";
                cbT7Ca2.Properties.Items.Clear();
                cbT7Ca3.Text = "";
                cbT7Ca3.Properties.Items.Clear();
                cbT7Ca4.Text = "";
                cbT7Ca4.Properties.Items.Clear();


            }
            DR.Close();
            con.Close();
            loadPhong();
        }

        private void listThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String a = listThu.SelectedIndex.ToString();
            //MessageBox.Show(a);
        }

        

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlDaoTaoDataSet1.XemTatCaPhongHoc' table. You can move, or remove it, as needed.
            this.xemTatCaPhongHocTableAdapter.Fill(this.qlDaoTaoDataSet1.XemTatCaPhongHoc);
            // TODO: This line of code loads data into the 'qlDaoTaoDataSet1.XemTatCaMonHoc' table. You can move, or remove it, as needed.
            this.xemTatCaMonHocTableAdapter.Fill(this.qlDaoTaoDataSet1.XemTatCaMonHoc);

        }

        private void btnLuuTKB_Click(object sender, EventArgs e)
        {
            con.Open();
            if (action.Equals("sua"))
            {
                SqlCommand sqlCmd = new SqlCommand("suaPhanCong", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maPC", maPC.Text);
                sqlCmd.Parameters.AddWithValue("@maGV", laMaGV.Text);
                sqlCmd.Parameters.AddWithValue("@maMH", cbMonHoc.EditValue.ToString());
                sqlCmd.Parameters.AddWithValue("@maLop", laLop.Text);
                sqlCmd.Parameters.AddWithValue("@ngayBD", dateBD.Value.ToShortDateString());
                sqlCmd.Parameters.AddWithValue("@ngayKT", dateKT.Value.ToShortDateString());
                if (cbHocKy.SelectedText.Equals("Học kỳ 1"))
                {
                    sqlCmd.Parameters.AddWithValue("@hocKy", 1);
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@hocKy", 2);
                }

                sqlCmd.Parameters.AddWithValue("@namHoc", dateBD.Value.Year);
                if (cbTrangThai.SelectedText.Equals("Đã xong"))
                {
                    sqlCmd.Parameters.AddWithValue("@trangThai", 0);
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@trangThai", 1);
                }
                sqlCmd.ExecuteNonQuery();
                if (!maBuoiHoc.Equals(suaBuoiHoc))
                {
                    sqlCmd = new SqlCommand("xoaThoiKhoaBieu", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
                    sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
                    sqlCmd.ExecuteNonQuery();

                    sqlCmd = new SqlCommand("themThoiKhoaBieu", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue("@maPC", maPC.Text);
                    sqlCmd.Parameters.AddWithValue("@maBH", suaBuoiHoc);
                    sqlCmd.Parameters.AddWithValue("@maPhong", cbPhongHoc.EditValue.ToString());
                    sqlCmd.ExecuteNonQuery();
                }
            }
            else
            {
                SqlCommand sqlCmd = new SqlCommand("themPhanCong", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maGV", laMaGV.Text);
                sqlCmd.Parameters.AddWithValue("@maMH", cbMonHoc.EditValue.ToString());
                sqlCmd.Parameters.AddWithValue("@maLop", laLop.Text);
                sqlCmd.Parameters.AddWithValue("@ngayBD", dateBD.Value.ToShortDateString());
                sqlCmd.Parameters.AddWithValue("@ngayKT", dateKT.Value.ToShortDateString());
                if (cbHocKy.SelectedText.Equals("Học kỳ 1"))
                {
                    sqlCmd.Parameters.AddWithValue("@hocKy", 1);
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@hocKy", 2);
                }

                sqlCmd.Parameters.AddWithValue("@namHoc", dateBD.Value.Year);
                if (cbTrangThai.SelectedText.Equals("Đã xong"))
                {
                    sqlCmd.Parameters.AddWithValue("@trangThai", 0);
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue("@trangThai", 1);
                }
                int modified = Convert.ToInt32(sqlCmd.ExecuteScalar());

                for (int i = 1; i < buoiHoc.Length; i++)
                {
                    if (buoiHoc[i] != null)
                    {
                        sqlCmd = new SqlCommand("themThoiKhoaBieu", con)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        sqlCmd.Parameters.AddWithValue("@maPC", modified);
                        sqlCmd.Parameters.AddWithValue("@maBH", buoiHoc[i].ToString());
                        sqlCmd.Parameters.AddWithValue("@maPhong", cbPhongHoc.EditValue.ToString());
                        sqlCmd.ExecuteNonQuery();
                    }
                }
            }
            buoiHoc = new string[24];
            con.Close();
            MessageBox.Show("Lưu thành công ^^");
        }

        private void cbPhongHoc_EditValueChanged(object sender, EventArgs e)
        {
            int flag = 0;
            int[] check = new int[28];
            con.Open();

            String phong = cbPhongHoc.EditValue.ToString();
            SqlCommand sqlCmd = new SqlCommand("kiemTraTheoPhong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            if (action.Equals("them"))
            {
                sqlCmd = new SqlCommand("kiemTraTheoPhongLop", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maLop", laLop.Text);
            }
            sqlCmd.Parameters.AddWithValue("@maPhong", phong);
            sqlCmd.Parameters.AddWithValue("@maGV", laMaGV.Text);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            //con.Close();
            while (DR.Read())
            {
                flag++;
                if (DR[0].ToString().Equals("1T2"))
                {
                    check[1] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T2") && phong.Equals(maPhong))
                    {
                        cT2Ca1.Visible = true;
                        cT2Ca1.Checked = true;
                    }
                    else
                    {
                        cT2Ca1.Visible = false;
                        cT2Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[1] == 0)
                    {
                        cT2Ca1.Visible = true;
                        cT2Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T2"))
                {
                    check[2] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T2") && phong.Equals(maPhong))
                    {
                        cT2Ca2.Visible = true;
                        cT2Ca2.Checked = true;
                    }
                    else
                    {
                        cT2Ca2.Visible = false;
                        cT2Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[2] == 0)
                    {
                        cT2Ca2.Visible = true;
                        cT2Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T2"))
                {
                    check[3] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T2") && phong.Equals(maPhong))
                    {
                        cT2Ca3.Visible = true;
                        cT2Ca3.Checked = true;
                    }
                    else
                    {
                        cT2Ca3.Visible = false;
                        cT2Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[3] == 0)
                    {
                        cT2Ca3.Visible = true;
                        cT2Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T2"))
                {
                    check[4] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T2") && phong.Equals(maPhong))
                    {
                        cT2Ca4.Visible = true;
                        cT2Ca4.Checked = true;
                    }
                    else
                    {
                        cT2Ca4.Visible = false;
                        cT2Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[4] == 0)
                    {
                        cT2Ca4.Visible = true;
                        cT2Ca4.Checked = false;
                    }
                }

                ////////////////////////T3
                if (DR[0].ToString().Equals("1T3"))
                {
                    check[5] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T3") && phong.Equals(maPhong))
                    {
                        cT3Ca1.Visible = true;
                        cT3Ca1.Checked = true;
                    }
                    else
                    {
                        cT3Ca1.Visible = false;
                        cT3Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[5] == 0)
                    {
                        cT3Ca1.Visible = true;
                        cT3Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T3"))
                {
                    check[6] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T3") && phong.Equals(maPhong))
                    {
                        cT3Ca2.Visible = true;
                        cT3Ca2.Checked = true;
                    }
                    else
                    {
                        cT3Ca2.Visible = false;
                        cT3Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[6] == 0)
                    {
                        cT3Ca2.Visible = true;
                        cT3Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T3"))
                {
                    check[7] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T3") && phong.Equals(maPhong))
                    {
                        cT3Ca3.Visible = true;
                        cT3Ca3.Checked = true;
                    }
                    else
                    {
                        cT3Ca3.Visible = false;
                        cT3Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[7] == 0)
                    {
                        cT3Ca3.Visible = true;
                        cT3Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T3"))
                {
                    check[8] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T3") && phong.Equals(maPhong))
                    {
                        cT3Ca4.Visible = true;
                        cT3Ca4.Checked = true;
                    }
                    else
                    {
                        cT3Ca4.Visible = false;
                        cT3Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[8] == 0)
                    {
                        cT3Ca4.Visible = true;
                        cT3Ca4.Checked = false;
                    }
                }

                ////////////////////////T4
                if (DR[0].ToString().Equals("1T4"))
                {
                    check[9] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T4") && phong.Equals(maPhong))
                    {
                        cT4Ca1.Visible = true;
                        cT4Ca1.Checked = true;
                    }
                    else
                    {
                        cT4Ca1.Visible = false;
                        cT4Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[9] == 0)
                    {
                        cT4Ca1.Visible = true;
                        cT4Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T4"))
                {
                    check[10] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T4") && phong.Equals(maPhong))
                    {
                        cT4Ca2.Visible = true;
                        cT4Ca2.Checked = true;
                    }
                    else
                    {
                        cT4Ca2.Visible = false;
                        cT4Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[10] == 0)
                    {
                        cT4Ca2.Visible = true;
                        cT4Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T4"))
                {
                    check[11] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T4") && phong.Equals(maPhong))
                    {
                        cT4Ca3.Visible = true;
                        cT4Ca3.Checked = true;
                    }
                    else
                    {
                        cT4Ca3.Visible = false;
                        cT4Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[11] == 0)
                    {
                        cT4Ca3.Visible = true;
                        cT4Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T4"))
                {
                    check[12] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T4") && phong.Equals(maPhong))
                    {
                        cT4Ca4.Visible = true;
                        cT4Ca4.Checked = true;
                    }
                    else
                    {
                        cT4Ca4.Visible = false;
                        cT4Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[12] == 0)
                    {
                        cT4Ca4.Visible = true;
                        cT4Ca4.Checked = false;
                    }
                }

                ////////////////////////T5
                if (DR[0].ToString().Equals("1T5"))
                {
                    check[13] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T5") && phong.Equals(maPhong))
                    {
                        cT5Ca1.Visible = true;
                        cT5Ca1.Checked = true;
                    }
                    else
                    {
                        cT5Ca1.Visible = false;
                        cT5Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[13] == 0)
                    {
                        cT5Ca1.Visible = true;
                        cT5Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T5"))
                {
                    check[14] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T5") && phong.Equals(maPhong))
                    {
                        cT5Ca2.Visible = true;
                        cT5Ca2.Checked = true;
                    }
                    else
                    {
                        cT5Ca2.Visible = false;
                        cT5Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[14] == 0)
                    {
                        cT5Ca2.Visible = true;
                        cT5Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T5"))
                {
                    check[15] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T5") && phong.Equals(maPhong))
                    {
                        cT5Ca3.Visible = true;
                        cT5Ca3.Checked = true;
                    }
                    else
                    {
                        cT5Ca3.Visible = false;
                        cT5Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[15] == 0)
                    {
                        cT5Ca3.Visible = true;
                        cT5Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T5"))
                {
                    check[16] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T5") && phong.Equals(maPhong))
                    {
                        cT5Ca4.Visible = true;
                        cT5Ca4.Checked = true;
                    }
                    else
                    {
                        cT5Ca4.Visible = false;
                        cT5Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[16] == 0)
                    {
                        cT5Ca4.Visible = true;
                        cT5Ca4.Checked = false;
                    }
                }


                ////////////////////////T6
                if (DR[0].ToString().Equals("1T6"))
                {
                    check[17] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T6") && phong.Equals(maPhong))
                    {
                        cT6Ca1.Visible = true;
                        cT6Ca1.Checked = true;
                    }
                    else
                    {
                        cT6Ca1.Visible = false;
                        cT6Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[17] == 0)
                    {
                        cT6Ca1.Visible = true;
                        cT6Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T6"))
                {
                    check[18] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T6") && phong.Equals(maPhong))
                    {
                        cT6Ca2.Visible = true;
                        cT6Ca2.Checked = true;
                    }
                    else
                    {
                        cT6Ca2.Visible = false;
                        cT6Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[18] == 0)
                    {
                        cT6Ca2.Visible = true;
                        cT6Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T6"))
                {
                    check[19] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T6") && phong.Equals(maPhong))
                    {
                        cT6Ca3.Visible = true;
                        cT6Ca3.Checked = true;
                    }
                    else
                    {
                        cT6Ca3.Visible = false;
                        cT6Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[19] == 0)
                    {
                        cT6Ca3.Visible = true;
                        cT6Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T6"))
                {
                    check[20] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T6") && phong.Equals(maPhong))
                    {
                        cT6Ca4.Visible = true;
                        cT6Ca4.Checked = true;
                    }
                    else
                    {
                        cT6Ca4.Visible = false;
                        cT6Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[20] == 0)
                    {
                        cT6Ca4.Visible = true;
                        cT6Ca4.Checked = false;
                    }
                }

                ////////////////////////T7
                if (DR[0].ToString().Equals("1T7"))
                {
                    check[21] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T7") && phong.Equals(maPhong))
                    {
                        cT7Ca1.Visible = true;
                        cT7Ca1.Checked = true;
                    }
                    else
                    {
                        cT7Ca1.Visible = false;
                        cT7Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[21] == 0)
                    {
                        cT7Ca1.Visible = true;
                        cT7Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T7"))
                {
                    check[22] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T7") && phong.Equals(maPhong))
                    {
                        cT7Ca2.Visible = true;
                        cT7Ca2.Checked = true;
                    }
                    else
                    {
                        cT7Ca2.Visible = false;
                        cT7Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[22] == 0)
                    {
                        cT7Ca2.Visible = true;
                        cT7Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T7"))
                {
                    check[23] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T7") && phong.Equals(maPhong))
                    {
                        cT7Ca3.Visible = true;
                        cT7Ca3.Checked = true;
                    }
                    else
                    {
                        cT7Ca3.Visible = false;
                        cT7Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[23] == 0)
                    {
                        cT7Ca3.Visible = true;
                        cT7Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T7"))
                {
                    check[24] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T7") && phong.Equals(maPhong))
                    {
                        cT7Ca4.Visible = true;
                        cT7Ca4.Checked = true;
                    }
                    else
                    {
                        cT7Ca4.Visible = false;
                        cT7Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[24] == 0)
                    {
                        cT7Ca4.Visible = true;
                        cT7Ca4.Checked = false;
                    }
                }
            }
            DR.Close();
            con.Close();
            if (flag == 0)
            {
                cT2Ca1.Visible = true;
                cT2Ca2.Visible = true;
                cT2Ca3.Visible = true;
                cT2Ca4.Visible = true;

                cT3Ca1.Visible = true;
                cT3Ca2.Visible = true;
                cT3Ca3.Visible = true;
                cT3Ca4.Visible = true;

                cT4Ca1.Visible = true;
                cT4Ca2.Visible = true;
                cT4Ca3.Visible = true;
                cT4Ca4.Visible = true;

                cT5Ca1.Visible = true;
                cT5Ca2.Visible = true;
                cT5Ca3.Visible = true;
                cT5Ca4.Visible = true;

                cT6Ca1.Visible = true;
                cT6Ca2.Visible = true;
                cT6Ca3.Visible = true;
                cT6Ca4.Visible = true;

                cT7Ca1.Visible = true;
                cT7Ca2.Visible = true;
                cT7Ca3.Visible = true;
                cT7Ca4.Visible = true;

                cT2Ca1.Checked = false;
                cT2Ca2.Checked = false;
                cT2Ca3.Checked = false;
                cT2Ca4.Checked = false;

                cT2Ca1.Checked = false;
                cT2Ca2.Checked = false;
                cT2Ca3.Checked = false;
                cT2Ca4.Checked = false;

                cT3Ca1.Checked = false;
                cT3Ca2.Checked = false;
                cT3Ca3.Checked = false;
                cT3Ca4.Checked = false;

                cT4Ca1.Checked = false;
                cT4Ca2.Checked = false;
                cT4Ca3.Checked = false;
                cT4Ca4.Checked = false;

                cT5Ca1.Checked = false;
                cT5Ca2.Checked = false;
                cT5Ca3.Checked = false;
                cT5Ca4.Checked = false;

                cT6Ca1.Checked = false;
                cT6Ca2.Checked = false;
                cT6Ca3.Checked = false;
                cT6Ca4.Checked = false;

                cT7Ca1.Checked = false;
                cT7Ca2.Checked = false;
                cT7Ca3.Checked = false;
                cT7Ca4.Checked = false;
            }
            
        }

        

        private void cT2Ca1_CheckedChanged(object sender, EventArgs e)
        {
            if (cT2Ca1.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "1T2";
                }
                buoiHoc[1] = "1T2";
                
            }
            else
            {
                buoiHoc[1] = null;
            }
            checkChonNgay();
        }

        private void cT2Ca2_CheckedChanged(object sender, EventArgs e)
        {
            if (cT2Ca2.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "2T2";
                }
                    buoiHoc[2] = "2T2";
            }
            else
            {
                buoiHoc[2] = null;
            }
            checkChonNgay();
        }

        private void cT2Ca3_CheckedChanged(object sender, EventArgs e)
        {
            if (cT2Ca3.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "3T2";
                }
            
                    buoiHoc[3] = "3T2";
                
            }
            else
            {
                buoiHoc[3] = null;
            }
        }

        private void cT2Ca4_CheckedChanged(object sender, EventArgs e)
        {
            if (cT2Ca4.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "4T2";
                }
             
                    buoiHoc[4] = "4T2";
                
            }
            else
            {
                buoiHoc[4] = null;
            }
            checkChonNgay();
        }

        private void cT3Ca1_CheckedChanged(object sender, EventArgs e)
        {
            if (cT3Ca1.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "1T3";
                }
                buoiHoc[5] = "1T3";
            }
            else
            {
                buoiHoc[5] = null;
            }
            checkChonNgay();
        }

        private void cT3Ca2_CheckedChanged(object sender, EventArgs e)
        {
            if (cT3Ca2.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "2T3";
                }
                buoiHoc[6] = "2T3";
            }
            else
            {
                buoiHoc[6] = null;
            }
            checkChonNgay();
        }

        private void cT3Ca3_CheckedChanged(object sender, EventArgs e)
        {
            if (cT3Ca3.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "3T3";
                }
                buoiHoc[7] = "3T3";
            }
            else
            {
                buoiHoc[7] = null;
            }
            checkChonNgay();
        }

        private void cT3Ca4_CheckedChanged(object sender, EventArgs e)
        {
            if (cT3Ca4.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "4T3";
                }
                buoiHoc[8] = "4T3";
            }
            else
            {
                buoiHoc[8] = null;
            }
            checkChonNgay();
        }

        private void cT4Ca1_CheckedChanged(object sender, EventArgs e)
        {
            if (cT4Ca1.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "1T4";
                }
                buoiHoc[9] = "1T4";
            }
            else
            {
                buoiHoc[9] = null;
            }
            checkChonNgay();
        }

        private void cT4Ca2_CheckedChanged(object sender, EventArgs e)
        {
            if (cT4Ca2.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "2T4";
                }
                buoiHoc[10] = "2T4";
            }
            else
            {
                buoiHoc[10] = null;
            }
            checkChonNgay();
        }

        private void cT4Ca3_CheckedChanged(object sender, EventArgs e)
        {
            if (cT4Ca3.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "3T4";
                }
                buoiHoc[11] = "3T4";
            }
            else
            {
                buoiHoc[11] = null;
            }
            checkChonNgay();
        }

        private void cT4Ca4_CheckedChanged(object sender, EventArgs e)
        {
            if (cT4Ca4.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "4T4";
                }
                buoiHoc[12] = "4T4";
            }
            else
            {
                buoiHoc[12] = null;
            }
            checkChonNgay();
        }

        private void cT5Ca1_CheckedChanged(object sender, EventArgs e)
        {
            if (cT5Ca1.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "1T5";
                }
                buoiHoc[13] = "1T5";
            }
            else
            {
                buoiHoc[13] = null;
            }
            checkChonNgay();
        }

        private void cT5Ca2_CheckedChanged(object sender, EventArgs e)
        {
            if (cT5Ca2.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "2T5";
                }
                buoiHoc[14] = "2T5";
            }
            else
            {
                buoiHoc[14] = null;
            }
            checkChonNgay();
        }

        private void cT5Ca3_CheckedChanged(object sender, EventArgs e)
        {
            if (cT5Ca3.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "3T5";
                }
                buoiHoc[15] = "3T5";
            }
            else
            {
                buoiHoc[15] = null;
            }
            checkChonNgay();
        }

        private void cT5Ca4_CheckedChanged(object sender, EventArgs e)
        {
            if (cT5Ca4.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "4T5";
                }
                buoiHoc[16] = "4T5";
            }
            else
            {
                buoiHoc[16] = null;
            }
            checkChonNgay();
        }

        private void cT6Ca1_CheckedChanged(object sender, EventArgs e)
        {
            if (cT6Ca1.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "1T6";
                }
                buoiHoc[17] = "1T6";
            }
            else
            {
                buoiHoc[17] = null;
            }
            checkChonNgay();
        }

        private void cT6Ca2_CheckedChanged(object sender, EventArgs e)
        {
            if (cT6Ca2.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "2T6";
                }
                buoiHoc[18] = "2T6";
            }
            else
            {
                buoiHoc[18] = null;
            }
            checkChonNgay();
        }

        private void cT6Ca3_CheckedChanged(object sender, EventArgs e)
        {
            if (cT6Ca3.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "3T6";
                }
                buoiHoc[19] = "3T6";
            }
            else
            {
                buoiHoc[19] = null;
            }
            checkChonNgay();
        }

        private void cT6Ca4_CheckedChanged(object sender, EventArgs e)
        {
            if (cT6Ca4.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "4T6";
                }
                buoiHoc[20] = "4T6";
            }
            else
            {
                buoiHoc[20] = null;
            }
            checkChonNgay();
        }

        private void cT7Ca1_CheckedChanged(object sender, EventArgs e)
        {
            if (cT7Ca1.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "1T7";
                }
                buoiHoc[21] = "1T7";
            }
            else
            {
                buoiHoc[21] = null;
            }
            checkChonNgay();
        }

        private void cT7Ca2_CheckedChanged(object sender, EventArgs e)
        {
            if (cT7Ca2.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "2T7";
                }
                buoiHoc[22] = "2T7";
            }
            else
            {
                buoiHoc[22] = null;
            }
            checkChonNgay();
        }

        private void cT7Ca3_CheckedChanged(object sender, EventArgs e)
        {
            if (cT7Ca3.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "3T7";
                }
                buoiHoc[23] = "3T7";
            }
            else
            {
                buoiHoc[23] = null;
            }
            checkChonNgay();
        }

        private void cT7Ca4_CheckedChanged(object sender, EventArgs e)
        {
            if (cT7Ca4.Checked == true)
            {
                if (action.Equals("sua"))
                {
                    suaBuoiHoc = "4T7";
                }
                buoiHoc[24] = "4T7";
            }
            else
            {
                buoiHoc[24] = null;
            }
            checkChonNgay();
        }

        public void loadBuoiHoc()
        {
            cT2Ca1.Visible = true;
            cT2Ca2.Visible = true;
            cT2Ca3.Visible = true;
            cT2Ca4.Visible = true;

            cT3Ca1.Visible = true;
            cT3Ca2.Visible = true;
            cT3Ca3.Visible = true;
            cT3Ca4.Visible = true;

            cT4Ca1.Visible = true;
            cT4Ca2.Visible = true;
            cT4Ca3.Visible = true;
            cT4Ca4.Visible = true;

            cT5Ca1.Visible = true;
            cT5Ca2.Visible = true;
            cT5Ca3.Visible = true;
            cT5Ca4.Visible = true;

            cT6Ca1.Visible = true;
            cT6Ca2.Visible = true;
            cT6Ca3.Visible = true;
            cT6Ca4.Visible = true;

            cT7Ca1.Visible = true;
            cT7Ca2.Visible = true;
            cT7Ca3.Visible = true;
            cT7Ca4.Visible = true;

            cT2Ca1.Checked = false;
            cT2Ca2.Checked = false;
            cT2Ca3.Checked = false;
            cT2Ca4.Checked = false;

            cT2Ca1.Checked = false;
            cT2Ca2.Checked = false;
            cT2Ca3.Checked = false;
            cT2Ca4.Checked = false;

            cT3Ca1.Checked = false;
            cT3Ca2.Checked = false;
            cT3Ca3.Checked = false;
            cT3Ca4.Checked = false;

            cT4Ca1.Checked = false;
            cT4Ca2.Checked = false;
            cT4Ca3.Checked = false;
            cT4Ca4.Checked = false;

            cT5Ca1.Checked = false;
            cT5Ca2.Checked = false;
            cT5Ca3.Checked = false;
            cT5Ca4.Checked = false;

            cT6Ca1.Checked = false;
            cT6Ca2.Checked = false;
            cT6Ca3.Checked = false;
            cT6Ca4.Checked = false;

            cT7Ca1.Checked = false;
            cT7Ca2.Checked = false;
            cT7Ca3.Checked = false;
            cT7Ca4.Checked = false;
        }

        public void taoMoi()
        {
            gridCLop.Visible = true;
            paTKBLop.Visible = true;
            cbKhoaLop.Visible = true;
            action = "them";
            maBuoiHoc = "";
            maPhong = "";
            laGV.Text = "Họ tên";
            laLop.Text = "Lớp";
            laMaGV.Text = "";
            maPC.Text = "0";
            cbMonHoc.Text = "Chọn môn học";
            dateBD.Text = "";
            dateKT.Text = "";
            cbTrangThai.Text = "Chọn trạng thái";
            cbPhongHoc.Text = "Chọn phòng học";
            cbHocKy.Text = "Chọn học kỳ";
            loadBuoiHoc();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            taoMoi();
        }

        private void cbT2Ca1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;
            paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT2Ca1.SelectedIndex = 1;
            String phong = cbT2Ca1.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "1T2";
            
            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT2Ca1.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT2Ca2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;
            paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT2Ca2.SelectedIndex = 1;
            String phong = cbT2Ca2.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "2T2";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT2Ca2.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT2Ca3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;
            paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT2Ca3.SelectedIndex = 1;
            String phong = cbT2Ca3.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "3T2";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT2Ca3.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT2Ca4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT2Ca4.SelectedIndex = 1;
            String phong = cbT2Ca4.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "4T2";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT2Ca4.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT3Ca1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT3Ca1.SelectedIndex = 1;
            String phong = cbT3Ca1.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "1T3";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT3Ca1.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT3Ca2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT3Ca2.SelectedIndex = 1;
            String phong = cbT3Ca2.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "2T3";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT3Ca2.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT3Ca3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT3Ca3.SelectedIndex = 1;
            String phong = cbT3Ca3.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "3T3";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT3Ca3.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT3Ca4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT3Ca4.SelectedIndex = 1;
            String phong = cbT3Ca4.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "4T3";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT3Ca4.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT4Ca1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT4Ca1.SelectedIndex = 1;
            String phong = cbT4Ca1.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "1T4";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT4Ca1.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT4Ca2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT4Ca2.SelectedIndex = 1;
            String phong = cbT4Ca2.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "2T4";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT4Ca2.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT4Ca3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT4Ca3.SelectedIndex = 1;
            String phong = cbT4Ca3.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "3T4";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT4Ca3.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT4Ca4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT4Ca4.SelectedIndex = 1;
            String phong = cbT4Ca4.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "4T4";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT4Ca4.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT5Ca1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT5Ca1.SelectedIndex = 1;
            String phong = cbT5Ca1.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "1T5";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT5Ca1.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT5Ca2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT5Ca2.SelectedIndex = 1;
            String phong = cbT5Ca2.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "2T5";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT5Ca2.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT5Ca3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT5Ca3.SelectedIndex = 1;
            String phong = cbT5Ca3.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "3T5";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT5Ca3.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT5Ca4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT5Ca4.SelectedIndex = 1;
            String phong = cbT5Ca4.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "4T5";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT5Ca4.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT6Ca1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT6Ca1.SelectedIndex = 1;
            String phong = cbT6Ca1.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "1T6";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT6Ca1.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT6Ca2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT6Ca2.SelectedIndex = 1;
            String phong = cbT6Ca2.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "2T6";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT6Ca2.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT6Ca3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT6Ca3.SelectedIndex = 1;
            String phong = cbT6Ca3.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "3T6";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT6Ca3.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT6Ca4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT6Ca4.SelectedIndex = 1;
            String phong = cbT6Ca4.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "4T6";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT6Ca4.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT7Ca1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT7Ca1.SelectedIndex = 1;
            String phong = cbT7Ca1.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "1T7";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT7Ca1.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT7Ca2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT7Ca2.SelectedIndex = 1;
            String phong = cbT7Ca2.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "2T7";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT7Ca2.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT7Ca3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT7Ca3.SelectedIndex = 1;
            String phong = cbT7Ca3.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "3T7";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT7Ca3.SelectedIndex = 0;
            loadPhong();
        }

        private void cbT7Ca4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            gridCLop.Visible = false;paTKBLop.Visible = false;cbKhoaLop.Visible = false;
            cbT7Ca4.SelectedIndex = 1;
            String phong = cbT7Ca4.SelectedItem.ToString();
            int vtLay = phong.Length - 7;
            maPhong = phong.Substring(7, vtLay);
            action = "sua";
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("xemChiTietPhanCong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maPhong", maPhong);
            maBuoiHoc = "4T7";

            sqlCmd.Parameters.AddWithValue("@maBH", maBuoiHoc);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                laMaGV.Text = DR[1].ToString();
                laGV.Text = DR[2].ToString();
                laLop.Text = DR[3].ToString();
                cbMonHoc.EditValue = DR[4].ToString();
                if (Convert.ToInt16(DR[5].ToString()) == 1)
                {
                    cbHocKy.SelectedIndex = 0;
                }
                else
                {
                    cbHocKy.SelectedIndex = 1;
                }
                maPC.Text = DR[0].ToString();
                dateBD.Text = DR[6].ToString();
                dateKT.Text = DR[7].ToString();
                if (Convert.ToInt16(DR[8].ToString()) == 1)
                {
                    cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    cbTrangThai.SelectedIndex = 0;
                }

            }
            DR.Close();
            con.Close();
            cbPhongHoc.EditValue = maPhong;
            cbT7Ca4.SelectedIndex = 0;
            loadPhong();
        }

        public void loadPhong()
        {
            int flag = 0;
            int[] check = new int[28];
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("kiemTraTheoPhong", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            String phong = cbPhongHoc.EditValue.ToString();
            if (action.Equals("them"))
            {
                sqlCmd = new SqlCommand("kiemTraTheoPhongLop", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maLop", laLop.Text);
            }
            sqlCmd.Parameters.AddWithValue("@maPhong", phong);
            sqlCmd.Parameters.AddWithValue("@maGV", laMaGV.Text);
            SqlDataReader DR = sqlCmd.ExecuteReader();
            //con.Close();
            while (DR.Read())
            {
                flag++;
                if (DR[0].ToString().Equals("1T2"))
                {
                    check[1] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T2") && phong.Equals(maPhong))
                    {
                        cT2Ca1.Visible = true;
                        cT2Ca1.Checked = true;
                    }
                    else
                    {
                        cT2Ca1.Visible = false;
                        cT2Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[1] == 0)
                    {
                        cT2Ca1.Visible = true;
                        cT2Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T2"))
                {
                    check[2] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T2") && phong.Equals(maPhong))
                    {
                        cT2Ca2.Visible = true;
                        cT2Ca2.Checked = true;
                    }
                    else
                    {
                        cT2Ca2.Visible = false;
                        cT2Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[2] == 0)
                    {
                        cT2Ca2.Visible = true;
                        cT2Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T2"))
                {
                    check[3] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T2") && phong.Equals(maPhong))
                    {
                        cT2Ca3.Visible = true;
                        cT2Ca3.Checked = true;
                    }
                    else
                    {
                        cT2Ca3.Visible = false;
                        cT2Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[3] == 0)
                    {
                        cT2Ca3.Visible = true;
                        cT2Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T2"))
                {
                    check[4] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T2") && phong.Equals(maPhong))
                    {
                        cT2Ca4.Visible = true;
                        cT2Ca4.Checked = true;
                    }
                    else
                    {
                        cT2Ca4.Visible = false;
                        cT2Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[4] == 0)
                    {
                        cT2Ca4.Visible = true;
                        cT2Ca4.Checked = false;
                    }
                }

                ////////////////////////T3
                if (DR[0].ToString().Equals("1T3"))
                {
                    check[5] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T3") && phong.Equals(maPhong))
                    {
                        cT3Ca1.Visible = true;
                        cT3Ca1.Checked = true;
                    }
                    else
                    {
                        cT3Ca1.Visible = false;
                        cT3Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[5] == 0)
                    {
                        cT3Ca1.Visible = true;
                        cT3Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T3"))
                {
                    check[6] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T3") && phong.Equals(maPhong))
                    {
                        cT3Ca2.Visible = true;
                        cT3Ca2.Checked = true;
                    }
                    else
                    {
                        cT3Ca2.Visible = false;
                        cT3Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[6] == 0)
                    {
                        cT3Ca2.Visible = true;
                        cT3Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T3"))
                {
                    check[7] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T3") && phong.Equals(maPhong))
                    {
                        cT3Ca3.Visible = true;
                        cT3Ca3.Checked = true;
                    }
                    else
                    {
                        cT3Ca3.Visible = false;
                        cT3Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[7] == 0)
                    {
                        cT3Ca3.Visible = true;
                        cT3Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T3"))
                {
                    check[8] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T3") && phong.Equals(maPhong))
                    {
                        cT3Ca4.Visible = true;
                        cT3Ca4.Checked = true;
                    }
                    else
                    {
                        cT3Ca4.Visible = false;
                        cT3Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[8] == 0)
                    {
                        cT3Ca4.Visible = true;
                        cT3Ca4.Checked = false;
                    }
                }

                ////////////////////////T4
                if (DR[0].ToString().Equals("1T4"))
                {
                    check[9] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T4") && phong.Equals(maPhong))
                    {
                        cT4Ca1.Visible = true;
                        cT4Ca1.Checked = true;
                    }
                    else
                    {
                        cT4Ca1.Visible = false;
                        cT4Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[9] == 0)
                    {
                        cT4Ca1.Visible = true;
                        cT4Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T4"))
                {
                    check[10] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T4") && phong.Equals(maPhong))
                    {
                        cT4Ca2.Visible = true;
                        cT4Ca2.Checked = true;
                    }
                    else
                    {
                        cT4Ca2.Visible = false;
                        cT4Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[10] == 0)
                    {
                        cT4Ca2.Visible = true;
                        cT4Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T4"))
                {
                    check[11] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T4") && phong.Equals(maPhong))
                    {
                        cT4Ca3.Visible = true;
                        cT4Ca3.Checked = true;
                    }
                    else
                    {
                        cT4Ca3.Visible = false;
                        cT4Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[11] == 0)
                    {
                        cT4Ca3.Visible = true;
                        cT4Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T4"))
                {
                    check[12] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T4") && phong.Equals(maPhong))
                    {
                        cT4Ca4.Visible = true;
                        cT4Ca4.Checked = true;
                    }
                    else
                    {
                        cT4Ca4.Visible = false;
                        cT4Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[12] == 0)
                    {
                        cT4Ca4.Visible = true;
                        cT4Ca4.Checked = false;
                    }
                }

                ////////////////////////T5
                if (DR[0].ToString().Equals("1T5"))
                {
                    check[13] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T5") && phong.Equals(maPhong))
                    {
                        cT5Ca1.Visible = true;
                        cT5Ca1.Checked = true;
                    }
                    else
                    {
                        cT5Ca1.Visible = false;
                        cT5Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[13] == 0)
                    {
                        cT5Ca1.Visible = true;
                        cT5Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T5"))
                {
                    check[14] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T5") && phong.Equals(maPhong))
                    {
                        cT5Ca2.Visible = true;
                        cT5Ca2.Checked = true;
                    }
                    else
                    {
                        cT5Ca2.Visible = false;
                        cT5Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[14] == 0)
                    {
                        cT5Ca2.Visible = true;
                        cT5Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T5"))
                {
                    check[15] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T5") && phong.Equals(maPhong))
                    {
                        cT5Ca3.Visible = true;
                        cT5Ca3.Checked = true;
                    }
                    else
                    {
                        cT5Ca3.Visible = false;
                        cT5Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[15] == 0)
                    {
                        cT5Ca3.Visible = true;
                        cT5Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T5"))
                {
                    check[16] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T5") && phong.Equals(maPhong))
                    {
                        cT5Ca4.Visible = true;
                        cT5Ca4.Checked = true;
                    }
                    else
                    {
                        cT5Ca4.Visible = false;
                        cT5Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[16] == 0)
                    {
                        cT5Ca4.Visible = true;
                        cT5Ca4.Checked = false;
                    }
                }


                ////////////////////////T6
                if (DR[0].ToString().Equals("1T6"))
                {
                    check[17] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T6") && phong.Equals(maPhong))
                    {
                        cT6Ca1.Visible = true;
                        cT6Ca1.Checked = true;
                    }
                    else
                    {
                        cT6Ca1.Visible = false;
                        cT6Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[17] == 0)
                    {
                        cT6Ca1.Visible = true;
                        cT6Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T6"))
                {
                    check[18] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T6") && phong.Equals(maPhong))
                    {
                        cT6Ca2.Visible = true;
                        cT6Ca2.Checked = true;
                    }
                    else
                    {
                        cT6Ca2.Visible = false;
                        cT6Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[18] == 0)
                    {
                        cT6Ca2.Visible = true;
                        cT6Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T6"))
                {
                    check[19] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T6") && phong.Equals(maPhong))
                    {
                        cT6Ca3.Visible = true;
                        cT6Ca3.Checked = true;
                    }
                    else
                    {
                        cT6Ca3.Visible = false;
                        cT6Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[19] == 0)
                    {
                        cT6Ca3.Visible = true;
                        cT6Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T6"))
                {
                    check[20] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T6") && phong.Equals(maPhong))
                    {
                        cT6Ca4.Visible = true;
                        cT6Ca4.Checked = true;
                    }
                    else
                    {
                        cT6Ca4.Visible = false;
                        cT6Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[20] == 0)
                    {
                        cT6Ca4.Visible = true;
                        cT6Ca4.Checked = false;
                    }
                }

                ////////////////////////T7
                if (DR[0].ToString().Equals("1T7"))
                {
                    check[21] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("1T7") && phong.Equals(maPhong))
                    {
                        cT7Ca1.Visible = true;
                        cT7Ca1.Checked = true;
                    }
                    else
                    {
                        cT7Ca1.Visible = false;
                        cT7Ca1.Checked = false;
                    }
                }
                else
                {
                    if (check[21] == 0)
                    {
                        cT7Ca1.Visible = true;
                        cT7Ca1.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("2T7"))
                {
                    check[22] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("2T7") && phong.Equals(maPhong))
                    {
                        cT7Ca2.Visible = true;
                        cT7Ca2.Checked = true;
                    }
                    else
                    {
                        cT7Ca2.Visible = false;
                        cT7Ca2.Checked = false;
                    }
                }
                else
                {
                    if (check[22] == 0)
                    {
                        cT7Ca2.Visible = true;
                        cT7Ca2.Checked = false;
                    }
                }


                if (DR[0].ToString().Equals("3T7"))
                {
                    check[23] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("3T7") && phong.Equals(maPhong))
                    {
                        cT7Ca3.Visible = true;
                        cT7Ca3.Checked = true;
                    }
                    else
                    {
                        cT7Ca3.Visible = false;
                        cT7Ca3.Checked = false;
                    }
                }
                else
                {
                    if (check[23] == 0)
                    {
                        cT7Ca3.Visible = true;
                        cT7Ca3.Checked = false;
                    }
                }

                if (DR[0].ToString().Equals("4T7"))
                {
                    check[24] = 1;
                    if (action.Equals("sua") && maBuoiHoc.Equals("4T7") && phong.Equals(maPhong))
                    {
                        cT7Ca4.Visible = true;
                        cT7Ca4.Checked = true;
                    }
                    else
                    {
                        cT7Ca4.Visible = false;
                        cT7Ca4.Checked = false;
                    }
                }
                else
                {
                    if (check[24] == 0)
                    {
                        cT7Ca4.Visible = true;
                        cT7Ca4.Checked = false;
                    }
                }
            }
            DR.Close();
            con.Close();
            if (flag == 0)
            {
                cT2Ca1.Visible = true;
                cT2Ca2.Visible = true;
                cT2Ca3.Visible = true;
                cT2Ca4.Visible = true;

                cT3Ca1.Visible = true;
                cT3Ca2.Visible = true;
                cT3Ca3.Visible = true;
                cT3Ca4.Visible = true;

                cT4Ca1.Visible = true;
                cT4Ca2.Visible = true;
                cT4Ca3.Visible = true;
                cT4Ca4.Visible = true;

                cT5Ca1.Visible = true;
                cT5Ca2.Visible = true;
                cT5Ca3.Visible = true;
                cT5Ca4.Visible = true;

                cT6Ca1.Visible = true;
                cT6Ca2.Visible = true;
                cT6Ca3.Visible = true;
                cT6Ca4.Visible = true;

                cT7Ca1.Visible = true;
                cT7Ca2.Visible = true;
                cT7Ca3.Visible = true;
                cT7Ca4.Visible = true;

                cT2Ca1.Checked = false;
                cT2Ca2.Checked = false;
                cT2Ca3.Checked = false;
                cT2Ca4.Checked = false;

                cT2Ca1.Checked = false;
                cT2Ca2.Checked = false;
                cT2Ca3.Checked = false;
                cT2Ca4.Checked = false;

                cT3Ca1.Checked = false;
                cT3Ca2.Checked = false;
                cT3Ca3.Checked = false;
                cT3Ca4.Checked = false;

                cT4Ca1.Checked = false;
                cT4Ca2.Checked = false;
                cT4Ca3.Checked = false;
                cT4Ca4.Checked = false;

                cT5Ca1.Checked = false;
                cT5Ca2.Checked = false;
                cT5Ca3.Checked = false;
                cT5Ca4.Checked = false;

                cT6Ca1.Checked = false;
                cT6Ca2.Checked = false;
                cT6Ca3.Checked = false;
                cT6Ca4.Checked = false;

                cT7Ca1.Checked = false;
                cT7Ca2.Checked = false;
                cT7Ca3.Checked = false;
                cT7Ca4.Checked = false;
            }
        }

        public void checkChonNgay()
        {
            int flag = 0;
            for (int i = 0; i < 24; i++)
            {
                if (buoiHoc[i] != null)
                {
                    flag++;
                }
            }
            if (flag == 1)
            {
                btnLuuTKB.Enabled = true;
            }
            else if (flag == 2 && action.Equals("them"))
            {
                btnLuuTKB.Enabled = true;
            }
            else
            {
                btnLuuTKB.Enabled = false;
            }
        }

        private void cbMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            int flag = 0;
            
            if (action.Equals("them"))
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand("kiemTraMonHoc", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@maLop", laLop.Text);
                sqlCmd.Parameters.AddWithValue("@maMH", cbMonHoc.EditValue.ToString());
                SqlDataReader DR = sqlCmd.ExecuteReader();
                while (DR.Read())
                {
                    flag++;
                }
                con.Close();
            }
            
                
            if (flag != 0)
            {
                MessageBox.Show("Lớp đã học môn này rồi");
            }
            
        }
    }

}