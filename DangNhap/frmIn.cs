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
    public partial class frmIn : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);
        public frmIn()
        {
            InitializeComponent();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("selectAllLopHoc", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader DR = sqlCmd.ExecuteReader();
            while (DR.Read())
            {
                cbLop.Items.Add(DR[0]);

            }
            DR.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            using (frmPreviewReport frm = new frmPreviewReport())
            {
                frm.WindowState = FormWindowState.Maximized;
                frm.inDSLop(cbLop.Text);
                frm.ShowDialog();
            }
        }
    }
}