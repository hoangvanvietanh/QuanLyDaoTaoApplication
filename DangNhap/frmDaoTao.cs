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
            this.Close();
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
        }

        private void laGiangVien_Click(object sender, EventArgs e)
        {
            frmDTGiangVien frmDTGiangVien = new frmDTGiangVien();
            frmDTGiangVien.WindowState = FormWindowState.Maximized;
            frmDTGiangVien.Show();
            //this.Close();
        }

        private void laSinhVien_Click(object sender, EventArgs e)
        {
            frmDTSinhVien frmDTSinhVien = new frmDTSinhVien();
            frmDTSinhVien.WindowState = FormWindowState.Maximized;
            frmDTSinhVien.Show();
            //this.Close();
        }

        private void laGiangVien_MouseHover(object sender, EventArgs e)
        {
            laGiangVien.BackColor = Color.Silver;
            laGiangVien.Image = null;
            laGiangVien.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laGiangVien_MouseLeave(object sender, EventArgs e)
        {
            
            laGiangVien.BackColor = Color.SkyBlue;
            laGiangVien.Image = DangNhap.Properties.Resources.iconfinder_Professor_131512__1_;
            laGiangVien.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laSinhVien_MouseHover(object sender, EventArgs e)
        {
            laSinhVien.BackColor = Color.Silver;
            laSinhVien.Image = null;
            laSinhVien.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laSinhVien_MouseLeave(object sender, EventArgs e)
        {

            laSinhVien.BackColor = Color.SkyBlue;
            laSinhVien.Image = DangNhap.Properties.Resources.iconfinder_130_man_student_2_3099383;
            laSinhVien.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laMonHoc_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Chức năng đang trong quá trình làm,\n bạn chờ nhé ^^", "Thông báo");
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Hide();
            notifyDashboard.Visible = true;
        }

        private void notifyDashboard_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyDashboard.Visible = false;
        }

        private void laThoat_MouseHover(object sender, EventArgs e)
        {
            laThoat.BackColor = Color.Silver;
            laThoat.Image = null;
            laThoat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laThoat_MouseLeave(object sender, EventArgs e)
        {
            laThoat.BackColor = Color.SkyBlue;
            laThoat.Image = DangNhap.Properties.Resources.iconfinder_Exit_132037;
            laThoat.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laKhoa_MouseHover(object sender, EventArgs e)
        {
            laKhoa.BackColor = Color.Silver;
            laKhoa.Image = null;
            laKhoa.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laKhoa_MouseLeave(object sender, EventArgs e)
        {
            laKhoa.BackColor = Color.SkyBlue;
            laKhoa.Image = DangNhap.Properties.Resources.iconfinder_20_Graduation_2064495;
            laKhoa.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laLop_MouseHover(object sender, EventArgs e)
        {
            laLop.BackColor = Color.Silver;
            laLop.Image = null;
            laLop.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laLop_MouseLeave(object sender, EventArgs e)
        {
            laLop.BackColor = Color.SkyBlue;
            laLop.Image = DangNhap.Properties.Resources.iconfinder_classeducationschoolstudystudentsteacherleacture_4332319;
            laLop.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laThoiKhoaBieu_MouseHover(object sender, EventArgs e)
        {
            laThoiKhoaBieu.BackColor = Color.Silver;
            laThoiKhoaBieu.Image = null;
            laThoiKhoaBieu.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laThoiKhoaBieu_MouseLeave(object sender, EventArgs e)
        {
            laThoiKhoaBieu.BackColor = Color.SkyBlue;
            laThoiKhoaBieu.Image = DangNhap.Properties.Resources.iconfinder_resolutions_04_897245;
            laThoiKhoaBieu.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laMonHoc_MouseHover(object sender, EventArgs e)
        {
            laMonHoc.BackColor = Color.Silver;
            laMonHoc.Image = null;
            laMonHoc.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laMonHoc_MouseLeave(object sender, EventArgs e)
        {
            laMonHoc.BackColor = Color.SkyBlue;
            laMonHoc.Image = DangNhap.Properties.Resources.iconfinder_Closed_Book_Icon_1741323;
            laMonHoc.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laChuyenNganh_MouseHover(object sender, EventArgs e)
        {
            laChuyenNganh.BackColor = Color.Silver;
            laChuyenNganh.Image = null;
            laChuyenNganh.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laChuyenNganh_MouseLeave(object sender, EventArgs e)
        {
            laChuyenNganh.BackColor = Color.SkyBlue;
            laChuyenNganh.Image = DangNhap.Properties.Resources.iconfinder_system_job_seeker_employee_unemployee_work_2620499;
            laChuyenNganh.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laCoSoVatChat_MouseHover(object sender, EventArgs e)
        {
            laCoSoVatChat.BackColor = Color.Silver;
            laCoSoVatChat.Image = null;
            laCoSoVatChat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laCoSoVatChat_MouseLeave(object sender, EventArgs e)
        {
            laCoSoVatChat.BackColor = Color.SkyBlue;
            laCoSoVatChat.Image = DangNhap.Properties.Resources.iconfinder_school_01_1989001;
            laCoSoVatChat.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            laTaiKhoan.BackColor = Color.Silver;
            laTaiKhoan.Image = null;
            laTaiKhoan.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void laTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            laTaiKhoan.BackColor = Color.SkyBlue;
            laTaiKhoan.Image = DangNhap.Properties.Resources.iconfinder_146_man_mechanic_2_3099399;
            laTaiKhoan.TextAlign = ContentAlignment.BottomLeft;
        }

        private void laKhoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình làm,\n bạn chờ nhé ^^", "Thông báo");
        }

        private void laLop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình làm,\n bạn chờ nhé ^^", "Thông báo");
        }

        private void laThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            frmPhanCong frmPhanCong = new frmPhanCong();
            frmPhanCong.Show();
            //MessageBox.Show("Chức năng đang trong quá trình làm,\n bạn chờ nhé ^^", "Thông báo");
        }

        private void laChuyenNganh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình làm,\n bạn chờ nhé ^^", "Thông báo");
        }

        private void laCoSoVatChat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình làm,\n bạn chờ nhé ^^", "Thông báo");
        }

        private void laTaiKhoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình làm,\n bạn chờ nhé ^^", "Thông báo");
        }
    }
}