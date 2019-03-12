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

namespace DangNhap
{
    public partial class frmDaoTao : DevExpress.XtraEditors.XtraForm
    {
        public frmDaoTao()
        {
            InitializeComponent();
        }
        private void laThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void laGiangVien_Click(object sender, EventArgs e)
        {
            frmDTGiangVien frmDTGiangVien = new frmDTGiangVien();
            frmDTGiangVien.WindowState = FormWindowState.Maximized;
            frmDTGiangVien.Show();
            this.Close();
        }

        private void laSinhVien_Click(object sender, EventArgs e)
        {
            frmDTSinhVien frmDTSinhVien = new frmDTSinhVien();
            frmDTSinhVien.Show();
            this.Close();
        }

        private void laGiangVien_MouseHover(object sender, EventArgs e)
        {
            laGiangVien.BackColor = Color.Silver;
            paGiangVien.Size = new Size(114, 103);
        }

        private void laGiangVien_MouseLeave(object sender, EventArgs e)
        {
            
            laGiangVien.BackColor = Color.SkyBlue;
            paGiangVien.Size = new Size(110, 99);
        }

        private void laSinhVien_MouseHover(object sender, EventArgs e)
        {
            laSinhVien.BackColor = Color.Silver;
            paSinhVien.Size = new Size(114, 103);
        }

        private void laSinhVien_MouseLeave(object sender, EventArgs e)
        {

            laSinhVien.BackColor = Color.SkyBlue;
            paSinhVien.Size = new Size(110, 99);
        }
    }
}