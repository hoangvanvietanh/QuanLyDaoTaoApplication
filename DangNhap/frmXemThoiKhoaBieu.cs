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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);
        public frmXemThoiKhoaBieu()
        {
            InitializeComponent();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("XemThoiKhoaBieuTheoGV", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("maGV","GV001");
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                if (Convert.ToInt16(DR[4].ToString())==2 && Convert.ToInt16(DR[5].ToString()) == 1)
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
                    cbT2Ca3.Properties.Items.Add("Môn: "+DR[1].ToString());
                    cbT2Ca3.Properties.Items.Add("Phòng: "+DR[6].ToString());
                    cbT2Ca3.Properties.Items.Add("GV: "+DR[0].ToString());
                    cbT2Ca3.Properties.Items.Add("Ngày BĐ: " + DR[8].ToString().Substring(0, 9));
                    cbT2Ca3.Properties.Items.Add("Ngày KT: "+DR[9].ToString().Substring(0, 9));
                }
                if (Convert.ToInt16(DR[4].ToString()) == 2 && Convert.ToInt16(DR[5].ToString()) == 4)
                {
                    cbT2Ca4.Text = DR[1].ToString();
                    cbT2Ca4.Properties.Items.Add("Môn: " + DR[1].ToString());
                    cbT2Ca4.Properties.Items.Add("Phòng: " + DR[6].ToString());
                    cbT2Ca4.Properties.Items.Add("GV: " + DR[0].ToString());
                    cbT2Ca4.Properties.Items.Add("Ngày BĐ: " +  DR[8].ToString().Substring(0,9));
                    cbT2Ca4.Properties.Items.Add("Ngày KT: " + DR[9].ToString().Substring(0, 9));
                }
            }
        }

        private void frmXemThoiKhoaBieu_Load(object sender, EventArgs e)
        {

        }
    }
}