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
    public partial class frmReviewInTKB : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);
        public frmReviewInTKB()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from XemThoiKhoaBieuGV where maGV = GV001", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            inThoiKhoaBieu inThoiKhoa = new inThoiKhoaBieu();
            inThoiKhoa.SetDataSource(dt);
            crystalReportTKBGV.ReportSource = inThoiKhoa;
            con.Close();*/
        }
    }
}