using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        string chon = "";
        public frmDangNhap()
        {
            InitializeComponent();
            laDNGiangVien.BackColor = Color.LightSkyBlue;
            chon = "GiangVien";
        }

        private void laDNGiangVien_Click(object sender, EventArgs e)
        {
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
            laDNGiangVien.BackColor = Color.LightGray;
            laDNSinhVien.BackColor = Color.LightSkyBlue;
            laDNDaoTao.BackColor = Color.LightGray;
            chon = "SinhVien";
        }

        private void laDNDaoTao_Click(object sender, EventArgs e)
        {
            laDNDaoTao.BackColor = Color.LightSkyBlue;
            laDNSinhVien.BackColor = Color.LightGray;
            laDNGiangVien.BackColor = Color.LightGray;
            chon = "Daotao";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (chon.Equals("SinhVien"))
            {
               
                frmSinhVien sinhVien = new frmSinhVien();
                sinhVien.Show();
                this.Hide();
            }
            else if (chon.Equals("GiangVien"))
            {
                frmGiangVien giangVien = new frmGiangVien();
                giangVien.Show();
                this.Hide();
            }
            else
            {
                frmDaoTao daoTao = new frmDaoTao();
                daoTao.Show();
                this.Hide();
            }

        }
    }
}
