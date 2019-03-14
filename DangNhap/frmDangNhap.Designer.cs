namespace DangNhap
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.laDangNhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.laDNSinhVien = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.laDNDaoTao = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.laDNGiangVien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.laDangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 219);
            this.panel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(443, 186);
            this.panel11.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyDaoTao.Properties.Resources._19d8a051527db023e96c;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // laDangNhap
            // 
            this.laDangNhap.BackColor = System.Drawing.Color.White;
            this.laDangNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.laDangNhap.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.laDangNhap.Location = new System.Drawing.Point(0, 186);
            this.laDangNhap.Name = "laDangNhap";
            this.laDangNhap.Size = new System.Drawing.Size(443, 33);
            this.laDangNhap.TabIndex = 0;
            this.laDangNhap.Text = "ĐĂNG NHẬP";
            this.laDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 37);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.laDNSinhVien);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(147, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(149, 37);
            this.panel7.TabIndex = 2;
            // 
            // laDNSinhVien
            // 
            this.laDNSinhVien.BackColor = System.Drawing.Color.LightGray;
            this.laDNSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laDNSinhVien.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.laDNSinhVien.Location = new System.Drawing.Point(0, 0);
            this.laDNSinhVien.Name = "laDNSinhVien";
            this.laDNSinhVien.Size = new System.Drawing.Size(149, 37);
            this.laDNSinhVien.TabIndex = 0;
            this.laDNSinhVien.Text = "Sinh Viên";
            this.laDNSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laDNSinhVien.Click += new System.EventHandler(this.laDNSinhVien_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.laDNDaoTao);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(296, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(147, 37);
            this.panel6.TabIndex = 1;
            // 
            // laDNDaoTao
            // 
            this.laDNDaoTao.BackColor = System.Drawing.Color.LightGray;
            this.laDNDaoTao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laDNDaoTao.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.laDNDaoTao.Location = new System.Drawing.Point(0, 0);
            this.laDNDaoTao.Name = "laDNDaoTao";
            this.laDNDaoTao.Size = new System.Drawing.Size(147, 37);
            this.laDNDaoTao.TabIndex = 0;
            this.laDNDaoTao.Text = "Đào Tạo";
            this.laDNDaoTao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laDNDaoTao.Click += new System.EventHandler(this.laDNDaoTao_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.laDNGiangVien);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(147, 37);
            this.panel5.TabIndex = 0;
            // 
            // laDNGiangVien
            // 
            this.laDNGiangVien.BackColor = System.Drawing.Color.LightGray;
            this.laDNGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laDNGiangVien.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.laDNGiangVien.Location = new System.Drawing.Point(0, 0);
            this.laDNGiangVien.Name = "laDNGiangVien";
            this.laDNGiangVien.Size = new System.Drawing.Size(147, 37);
            this.laDNGiangVien.TabIndex = 0;
            this.laDNGiangVien.Text = "Giảng Viên";
            this.laDNGiangVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laDNGiangVien.Click += new System.EventHandler(this.laDNGiangVien_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 155);
            this.panel3.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.btnThoat);
            this.panel10.Controls.Add(this.btnDangNhap);
            this.panel10.Controls.Add(this.txtMatKhau);
            this.panel10.Controls.Add(this.txtMaSo);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(70, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(303, 155);
            this.panel10.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(189)))), ((int)(((byte)(240)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial Narrow", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(154, 120);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 29);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(189)))), ((int)(((byte)(240)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(44, 120);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(104, 29);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 15.25F);
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtMatKhau.Location = new System.Drawing.Point(6, 69);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(286, 31);
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.TabStop = false;
            this.txtMatKhau.Text = "Mật Khẩu";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Font = new System.Drawing.Font("Arial", 15.25F);
            this.txtMaSo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtMaSo.Location = new System.Drawing.Point(6, 20);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(286, 31);
            this.txtMaSo.TabIndex = 0;
            this.txtMaSo.TabStop = false;
            this.txtMaSo.Text = "Mã số";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(373, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(70, 155);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(70, 155);
            this.panel8.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(75)))), ((int)(((byte)(91)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 411);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 72);
            this.panel4.TabIndex = 3;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 483);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label laDangNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label laDNGiangVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label laDNSinhVien;
        private System.Windows.Forms.Label laDNDaoTao;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel11;
    }
}

