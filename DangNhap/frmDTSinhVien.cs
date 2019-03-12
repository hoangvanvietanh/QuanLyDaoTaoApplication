using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DangNhap
{
    public partial class frmDTSinhVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDTSinhVien()
        {
            InitializeComponent();
        }

        private void frmDTSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDaoTao frmDaoTao = new frmDaoTao();
            frmDaoTao.Show();
        }
    }
}