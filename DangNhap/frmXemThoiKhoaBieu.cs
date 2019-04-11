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
     public partial class frmXemThoiKhoaBieu : DevExpress.XtraEditors.XtraForm
    {
        public String maGV = "";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);
        public frmXemThoiKhoaBieu()
        {
            InitializeComponent();
            
        }

        private void frmXemThoiKhoaBieu_Load(object sender, EventArgs e)
        {

        }


        public void xemTKB(String maGV)
        {
            this.maGV = maGV;
            con.Open();
            int flag = 0;
            int[] check = new int[28];
            SqlCommand sqlCmd = new SqlCommand("XemThoiKhoaBieuTheoGV", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@maGV", maGV);
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
        }

        private void btnInTKB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmPreviewReport frm = new frmPreviewReport())
            {
                frm.WindowState = FormWindowState.Maximized;
                frm.inGiangVienTKB(maGV);
                frm.ShowDialog();
            }
        }
    }
}