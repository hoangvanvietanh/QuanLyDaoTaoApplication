namespace DangNhap
{
    partial class frmDTSinhVien
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rpTrangChu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceSapXep = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridCSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gridVSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.qlDaoTaoDataSetSV = new QuanLyDaoTao.QLDaoTaoDataSet();
            this.selectAllSVTableAdapter = new QuanLyDaoTao.QLDaoTaoDataSetTableAdapters.selectAllSVTableAdapter();
            this.colmaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoiSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemSV = new DevExpress.XtraBars.BarButtonItem();
            this.rpEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnXoaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaSV = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDaoTaoDataSetSV)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThemSV,
            this.btnXoaSV,
            this.btnSuaSV});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpTrangChu});
            this.ribbon.Size = new System.Drawing.Size(772, 154);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // rpTrangChu
            // 
            this.rpTrangChu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rpEdit});
            this.rpTrangChu.Name = "rpTrangChu";
            this.rpTrangChu.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThemSV);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "New";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 427);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(772, 22);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 10);
            this.panel1.TabIndex = 2;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceSapXep});
            this.accordionControl1.Location = new System.Drawing.Point(0, 164);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(114, 263);
            this.accordionControl1.TabIndex = 3;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceSapXep
            // 
            this.aceSapXep.Name = "aceSapXep";
            this.aceSapXep.Text = "Sắp xếp";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(607, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 263);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(597, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 263);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridCSinhVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(114, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 263);
            this.panel4.TabIndex = 6;
            // 
            // gridCSinhVien
            // 
            this.gridCSinhVien.DataMember = "selectAllSV";
            this.gridCSinhVien.DataSource = this.qlDaoTaoDataSetSV;
            this.gridCSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCSinhVien.Location = new System.Drawing.Point(0, 0);
            this.gridCSinhVien.MainView = this.gridVSinhVien;
            this.gridCSinhVien.MenuManager = this.ribbon;
            this.gridCSinhVien.Name = "gridCSinhVien";
            this.gridCSinhVien.Size = new System.Drawing.Size(483, 263);
            this.gridCSinhVien.TabIndex = 0;
            this.gridCSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVSinhVien});
            // 
            // gridVSinhVien
            // 
            this.gridVSinhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaSV,
            this.colhoTen,
            this.colgioiTinh,
            this.coldiaChi,
            this.colSDT,
            this.colngaySinh,
            this.colnoiSinh,
            this.colkhoa,
            this.colemail,
            this.coltenLop,
            this.coltenNganh,
            this.coltenKhoa,
            this.colquyen,
            this.colmaLop,
            this.colmaNganh,
            this.colhinh,
            this.colmaKhoa});
            this.gridVSinhVien.GridControl = this.gridCSinhVien;
            this.gridVSinhVien.Name = "gridVSinhVien";
            // 
            // qlDaoTaoDataSetSV
            // 
            this.qlDaoTaoDataSetSV.DataSetName = "QLDaoTaoDataSet";
            this.qlDaoTaoDataSetSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectAllSVTableAdapter
            // 
            this.selectAllSVTableAdapter.ClearBeforeFill = true;
            // 
            // colmaSV
            // 
            this.colmaSV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmaSV.AppearanceHeader.Options.UseFont = true;
            this.colmaSV.AppearanceHeader.Options.UseTextOptions = true;
            this.colmaSV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmaSV.Caption = "Mã GV";
            this.colmaSV.FieldName = "maSV";
            this.colmaSV.Name = "colmaSV";
            this.colmaSV.OptionsColumn.AllowEdit = false;
            this.colmaSV.OptionsColumn.AllowFocus = false;
            this.colmaSV.Visible = true;
            this.colmaSV.VisibleIndex = 0;
            this.colmaSV.Width = 94;
            // 
            // colhoTen
            // 
            this.colhoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colhoTen.AppearanceHeader.Options.UseFont = true;
            this.colhoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colhoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhoTen.Caption = "Họ tên";
            this.colhoTen.FieldName = "hoTen";
            this.colhoTen.Name = "colhoTen";
            this.colhoTen.OptionsColumn.AllowEdit = false;
            this.colhoTen.OptionsColumn.AllowFocus = false;
            this.colhoTen.Visible = true;
            this.colhoTen.VisibleIndex = 1;
            this.colhoTen.Width = 118;
            // 
            // colgioiTinh
            // 
            this.colgioiTinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colgioiTinh.AppearanceHeader.Options.UseFont = true;
            this.colgioiTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colgioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgioiTinh.Caption = "Giới tính";
            this.colgioiTinh.FieldName = "gioiTinh";
            this.colgioiTinh.Name = "colgioiTinh";
            this.colgioiTinh.OptionsColumn.AllowEdit = false;
            this.colgioiTinh.OptionsColumn.AllowFocus = false;
            this.colgioiTinh.Visible = true;
            this.colgioiTinh.VisibleIndex = 2;
            this.colgioiTinh.Width = 56;
            // 
            // coldiaChi
            // 
            this.coldiaChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coldiaChi.AppearanceHeader.Options.UseFont = true;
            this.coldiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.coldiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldiaChi.Caption = "Địa chỉ";
            this.coldiaChi.FieldName = "diaChi";
            this.coldiaChi.Name = "coldiaChi";
            this.coldiaChi.OptionsColumn.AllowEdit = false;
            this.coldiaChi.OptionsColumn.AllowFocus = false;
            this.coldiaChi.Visible = true;
            this.coldiaChi.VisibleIndex = 3;
            this.coldiaChi.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSDT.AppearanceHeader.Options.UseFont = true;
            this.colSDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSDT.Caption = "Số ĐT";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            this.colSDT.OptionsColumn.AllowFocus = false;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 94;
            // 
            // colngaySinh
            // 
            this.colngaySinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colngaySinh.AppearanceHeader.Options.UseFont = true;
            this.colngaySinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colngaySinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaySinh.Caption = "Ngày sinh";
            this.colngaySinh.FieldName = "ngaySinh";
            this.colngaySinh.Name = "colngaySinh";
            this.colngaySinh.OptionsColumn.AllowEdit = false;
            this.colngaySinh.OptionsColumn.AllowFocus = false;
            this.colngaySinh.Visible = true;
            this.colngaySinh.VisibleIndex = 5;
            this.colngaySinh.Width = 94;
            // 
            // colnoiSinh
            // 
            this.colnoiSinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colnoiSinh.AppearanceHeader.Options.UseFont = true;
            this.colnoiSinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colnoiSinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnoiSinh.Caption = "Nơi sinh";
            this.colnoiSinh.FieldName = "noiSinh";
            this.colnoiSinh.Name = "colnoiSinh";
            this.colnoiSinh.OptionsColumn.AllowEdit = false;
            this.colnoiSinh.OptionsColumn.AllowFocus = false;
            this.colnoiSinh.Visible = true;
            this.colnoiSinh.VisibleIndex = 6;
            this.colnoiSinh.Width = 94;
            // 
            // colkhoa
            // 
            this.colkhoa.AppearanceCell.Options.UseTextOptions = true;
            this.colkhoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkhoa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colkhoa.AppearanceHeader.Options.UseFont = true;
            this.colkhoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colkhoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkhoa.Caption = "Khóa";
            this.colkhoa.FieldName = "khoa";
            this.colkhoa.Name = "colkhoa";
            this.colkhoa.OptionsColumn.AllowEdit = false;
            this.colkhoa.OptionsColumn.AllowFocus = false;
            this.colkhoa.Visible = true;
            this.colkhoa.VisibleIndex = 7;
            this.colkhoa.Width = 42;
            // 
            // colquyen
            // 
            this.colquyen.FieldName = "quyen";
            this.colquyen.Name = "colquyen";
            // 
            // colmaLop
            // 
            this.colmaLop.FieldName = "maLop";
            this.colmaLop.Name = "colmaLop";
            // 
            // colmaNganh
            // 
            this.colmaNganh.FieldName = "maNganh";
            this.colmaNganh.Name = "colmaNganh";
            // 
            // colemail
            // 
            this.colemail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colemail.AppearanceHeader.Options.UseFont = true;
            this.colemail.AppearanceHeader.Options.UseTextOptions = true;
            this.colemail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.OptionsColumn.AllowFocus = false;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 8;
            this.colemail.Width = 102;
            // 
            // colhinh
            // 
            this.colhinh.FieldName = "hinh";
            this.colhinh.Name = "colhinh";
            // 
            // coltenLop
            // 
            this.coltenLop.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coltenLop.AppearanceHeader.Options.UseFont = true;
            this.coltenLop.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenLop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenLop.Caption = "Lớp";
            this.coltenLop.FieldName = "tenLop";
            this.coltenLop.Name = "coltenLop";
            this.coltenLop.OptionsColumn.AllowEdit = false;
            this.coltenLop.OptionsColumn.AllowFocus = false;
            this.coltenLop.Visible = true;
            this.coltenLop.VisibleIndex = 9;
            this.coltenLop.Width = 107;
            // 
            // coltenNganh
            // 
            this.coltenNganh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coltenNganh.AppearanceHeader.Options.UseFont = true;
            this.coltenNganh.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenNganh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenNganh.Caption = "Ngành";
            this.coltenNganh.FieldName = "tenNganh";
            this.coltenNganh.Name = "coltenNganh";
            this.coltenNganh.OptionsColumn.AllowEdit = false;
            this.coltenNganh.OptionsColumn.AllowFocus = false;
            this.coltenNganh.Visible = true;
            this.coltenNganh.VisibleIndex = 10;
            this.coltenNganh.Width = 107;
            // 
            // colmaKhoa
            // 
            this.colmaKhoa.FieldName = "maKhoa";
            this.colmaKhoa.Name = "colmaKhoa";
            // 
            // coltenKhoa
            // 
            this.coltenKhoa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coltenKhoa.AppearanceHeader.Options.UseFont = true;
            this.coltenKhoa.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenKhoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenKhoa.Caption = "Khoa";
            this.coltenKhoa.FieldName = "tenKhoa";
            this.coltenKhoa.Name = "coltenKhoa";
            this.coltenKhoa.OptionsColumn.AllowEdit = false;
            this.coltenKhoa.OptionsColumn.AllowFocus = false;
            this.coltenKhoa.Visible = true;
            this.coltenKhoa.VisibleIndex = 11;
            this.coltenKhoa.Width = 133;
            // 
            // btnThemSV
            // 
            this.btnThemSV.Caption = "Thêm SV";
            this.btnThemSV.Id = 1;
            this.btnThemSV.Name = "btnThemSV";
            // 
            // rpEdit
            // 
            this.rpEdit.ItemLinks.Add(this.btnXoaSV);
            this.rpEdit.ItemLinks.Add(this.btnSuaSV);
            this.rpEdit.Name = "rpEdit";
            this.rpEdit.Text = "Edit";
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Caption = "Xóa SV";
            this.btnXoaSV.Id = 2;
            this.btnXoaSV.Name = "btnXoaSV";
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Caption = "Sửa SV";
            this.btnSuaSV.Id = 3;
            this.btnSuaSV.Name = "btnSuaSV";
            // 
            // frmDTSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 449);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmDTSinhVien";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Đào tạo - Sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDTSinhVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDaoTaoDataSetSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpTrangChu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSapXep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gridCSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVSinhVien;
        private QuanLyDaoTao.QLDaoTaoDataSet qlDaoTaoDataSetSV;
        private DevExpress.XtraGrid.Columns.GridColumn colmaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colgioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colnoiSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colkhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colquyen;
        private DevExpress.XtraGrid.Columns.GridColumn colmaLop;
        private DevExpress.XtraGrid.Columns.GridColumn colmaNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colhinh;
        private DevExpress.XtraGrid.Columns.GridColumn coltenLop;
        private DevExpress.XtraGrid.Columns.GridColumn coltenNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colmaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn coltenKhoa;
        private QuanLyDaoTao.QLDaoTaoDataSetTableAdapters.selectAllSVTableAdapter selectAllSVTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnThemSV;
        private DevExpress.XtraBars.BarButtonItem btnXoaSV;
        private DevExpress.XtraBars.BarButtonItem btnSuaSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpEdit;
    }
}