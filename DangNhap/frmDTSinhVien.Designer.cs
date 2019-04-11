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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThemSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaSV = new DevExpress.XtraBars.BarButtonItem();
            this.rpTrangChu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceSapXep = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTatCa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLop = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKhoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceNganh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKhoaHoc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceGioiTinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel2 = new System.Windows.Forms.Panel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.laEmail = new System.Windows.Forms.LinkLabel();
            this.laSoDT = new System.Windows.Forms.Label();
            this.laLop = new System.Windows.Forms.Label();
            this.laNganh = new System.Windows.Forms.Label();
            this.laHoTen = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picSinhVien = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridCSinhVien = new DevExpress.XtraGrid.GridControl();
            this.qlDaoTaoDataSet = new DangNhap.QLDaoTaoDataSet();
            this.gridVSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoiSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectAllSVTableAdapter = new DangNhap.QLDaoTaoDataSetTableAdapters.selectAllSVTableAdapter();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDaoTaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThemSV,
            this.btnXoaSV,
            this.btnSuaSV,
            this.btnIn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpTrangChu});
            this.ribbon.Size = new System.Drawing.Size(899, 154);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnThemSV
            // 
            this.btnThemSV.Caption = "Thêm SV";
            this.btnThemSV.Id = 1;
            this.btnThemSV.ImageOptions.Image = global::DangNhap.Properties.Resources.student_add_512;
            this.btnThemSV.ImageOptions.SvgImage = global::DangNhap.Properties.Resources.add_friend;
            this.btnThemSV.LargeWidth = 80;
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemSV_ItemClick);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Caption = "Xóa SV";
            this.btnXoaSV.Id = 2;
            this.btnXoaSV.ImageOptions.Image = global::DangNhap.Properties.Resources.delete_user_512;
            this.btnXoaSV.ImageOptions.SvgImage = global::DangNhap.Properties.Resources.remove;
            this.btnXoaSV.LargeWidth = 80;
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaSV_ItemClick);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Caption = "Sửa SV";
            this.btnSuaSV.Id = 3;
            this.btnSuaSV.ImageOptions.SvgImage = global::DangNhap.Properties.Resources.user;
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaSV_ItemClick);
            // 
            // rpTrangChu
            // 
            this.rpTrangChu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rpEdit,
            this.ribbonPageGroup2});
            this.rpTrangChu.Name = "rpTrangChu";
            this.rpTrangChu.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThemSV);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "New";
            // 
            // rpEdit
            // 
            this.rpEdit.ItemLinks.Add(this.btnXoaSV);
            this.rpEdit.ItemLinks.Add(this.btnSuaSV);
            this.rpEdit.Name = "rpEdit";
            this.rpEdit.Text = "Edit";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnIn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tool";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 482);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(899, 22);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 10);
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
            this.accordionControl1.Size = new System.Drawing.Size(114, 318);
            this.accordionControl1.TabIndex = 3;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceSapXep
            // 
            this.aceSapXep.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceTatCa,
            this.aceLop,
            this.aceKhoa,
            this.aceNganh,
            this.aceKhoaHoc,
            this.aceGioiTinh});
            this.aceSapXep.Expanded = true;
            this.aceSapXep.Name = "aceSapXep";
            this.aceSapXep.Text = "Sắp xếp";
            // 
            // aceTatCa
            // 
            this.aceTatCa.Name = "aceTatCa";
            this.aceTatCa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceTatCa.Text = "Tất cả";
            this.aceTatCa.Click += new System.EventHandler(this.aceTatCa_Click);
            // 
            // aceLop
            // 
            this.aceLop.Name = "aceLop";
            this.aceLop.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLop.Text = "Lớp";
            this.aceLop.Click += new System.EventHandler(this.aceLop_Click);
            // 
            // aceKhoa
            // 
            this.aceKhoa.Name = "aceKhoa";
            this.aceKhoa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKhoa.Text = "Khoa";
            this.aceKhoa.Click += new System.EventHandler(this.aceKhoa_Click);
            // 
            // aceNganh
            // 
            this.aceNganh.Name = "aceNganh";
            this.aceNganh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceNganh.Text = "Ngành";
            this.aceNganh.Click += new System.EventHandler(this.aceNganh_Click);
            // 
            // aceKhoaHoc
            // 
            this.aceKhoaHoc.Name = "aceKhoaHoc";
            this.aceKhoaHoc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKhoaHoc.Text = "Khóa học";
            this.aceKhoaHoc.Click += new System.EventHandler(this.aceKhoaHoc_Click);
            // 
            // aceGioiTinh
            // 
            this.aceGioiTinh.Name = "aceGioiTinh";
            this.aceGioiTinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceGioiTinh.Text = "Giới tính";
            this.aceGioiTinh.Click += new System.EventHandler(this.aceGioiTinh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.separatorControl1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(463, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 318);
            this.panel2.TabIndex = 4;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl1.Location = new System.Drawing.Point(0, 186);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(436, 23);
            this.separatorControl1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.laEmail);
            this.panel5.Controls.Add(this.laSoDT);
            this.panel5.Controls.Add(this.laLop);
            this.panel5.Controls.Add(this.laNganh);
            this.panel5.Controls.Add(this.laHoTen);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.picSinhVien);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(436, 186);
            this.panel5.TabIndex = 0;
            // 
            // laEmail
            // 
            this.laEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEmail.Location = new System.Drawing.Point(204, 156);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(232, 30);
            this.laEmail.TabIndex = 7;
            this.laEmail.TabStop = true;
            this.laEmail.Text = "Email";
            // 
            // laSoDT
            // 
            this.laSoDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.laSoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSoDT.Location = new System.Drawing.Point(204, 122);
            this.laSoDT.Name = "laSoDT";
            this.laSoDT.Size = new System.Drawing.Size(232, 34);
            this.laSoDT.TabIndex = 6;
            this.laSoDT.Text = "Số đt";
            this.laSoDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laLop
            // 
            this.laLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.laLop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLop.Location = new System.Drawing.Point(204, 99);
            this.laLop.Name = "laLop";
            this.laLop.Size = new System.Drawing.Size(232, 23);
            this.laLop.TabIndex = 5;
            this.laLop.Text = "Lớp";
            this.laLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laNganh
            // 
            this.laNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.laNganh.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNganh.Location = new System.Drawing.Point(204, 46);
            this.laNganh.Name = "laNganh";
            this.laNganh.Size = new System.Drawing.Size(232, 53);
            this.laNganh.TabIndex = 4;
            this.laNganh.Text = "Ngành";
            this.laNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laHoTen
            // 
            this.laHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.laHoTen.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHoTen.Location = new System.Drawing.Point(204, 0);
            this.laHoTen.Name = "laHoTen";
            this.laHoTen.Size = new System.Drawing.Size(232, 46);
            this.laHoTen.TabIndex = 3;
            this.laHoTen.Text = "Họ tên";
            this.laHoTen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(196, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 186);
            this.panel7.TabIndex = 2;
            // 
            // picSinhVien
            // 
            this.picSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSinhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.picSinhVien.Image = global::DangNhap.Properties.Resources._19d8a051527db023e96c;
            this.picSinhVien.Location = new System.Drawing.Point(10, 0);
            this.picSinhVien.Name = "picSinhVien";
            this.picSinhVien.Size = new System.Drawing.Size(186, 186);
            this.picSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSinhVien.TabIndex = 1;
            this.picSinhVien.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 186);
            this.panel6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(453, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 318);
            this.panel3.TabIndex = 5;
            // 
            // gridCSinhVien
            // 
            this.gridCSinhVien.DataMember = "selectAllSV";
            this.gridCSinhVien.DataSource = this.qlDaoTaoDataSet;
            this.gridCSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCSinhVien.Location = new System.Drawing.Point(114, 164);
            this.gridCSinhVien.MainView = this.gridVSinhVien;
            this.gridCSinhVien.MenuManager = this.ribbon;
            this.gridCSinhVien.Name = "gridCSinhVien";
            this.gridCSinhVien.Size = new System.Drawing.Size(339, 318);
            this.gridCSinhVien.TabIndex = 8;
            this.gridCSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVSinhVien});
            // 
            // qlDaoTaoDataSet
            // 
            this.qlDaoTaoDataSet.DataSetName = "QLDaoTaoDataSet";
            this.qlDaoTaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colemail,
            this.colhinh,
            this.colkhoa,
            this.colmaLop,
            this.colmaNganh,
            this.coltenNganh,
            this.colmaKhoa,
            this.coltenKhoa});
            this.gridVSinhVien.GridControl = this.gridCSinhVien;
            this.gridVSinhVien.Name = "gridVSinhVien";
            this.gridVSinhVien.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridVSinhVien_RowCellClick);
            // 
            // colmaSV
            // 
            this.colmaSV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmaSV.AppearanceHeader.Options.UseFont = true;
            this.colmaSV.AppearanceHeader.Options.UseTextOptions = true;
            this.colmaSV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmaSV.Caption = "Mã SV";
            this.colmaSV.FieldName = "maSV";
            this.colmaSV.Name = "colmaSV";
            this.colmaSV.OptionsColumn.AllowEdit = false;
            this.colmaSV.OptionsColumn.AllowFocus = false;
            this.colmaSV.Visible = true;
            this.colmaSV.VisibleIndex = 0;
            this.colmaSV.Width = 48;
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
            this.colhoTen.Width = 100;
            // 
            // colgioiTinh
            // 
            this.colgioiTinh.AppearanceCell.Options.UseTextOptions = true;
            this.colgioiTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.colgioiTinh.Width = 59;
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
            this.coldiaChi.Width = 171;
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
            this.colSDT.Width = 76;
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
            this.colngaySinh.VisibleIndex = 4;
            this.colngaySinh.Width = 67;
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
            this.colnoiSinh.VisibleIndex = 5;
            this.colnoiSinh.Width = 77;
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
            this.colemail.Width = 153;
            // 
            // colhinh
            // 
            this.colhinh.FieldName = "hinh";
            this.colhinh.Name = "colhinh";
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
            this.colkhoa.VisibleIndex = 6;
            this.colkhoa.Width = 46;
            // 
            // colmaLop
            // 
            this.colmaLop.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmaLop.AppearanceHeader.Options.UseFont = true;
            this.colmaLop.AppearanceHeader.Options.UseTextOptions = true;
            this.colmaLop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmaLop.Caption = "Lớp";
            this.colmaLop.FieldName = "maLop";
            this.colmaLop.Name = "colmaLop";
            this.colmaLop.OptionsColumn.AllowEdit = false;
            this.colmaLop.OptionsColumn.AllowFocus = false;
            // 
            // colmaNganh
            // 
            this.colmaNganh.FieldName = "maNganh";
            this.colmaNganh.Name = "colmaNganh";
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
            this.coltenNganh.Width = 115;
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
            this.coltenKhoa.VisibleIndex = 7;
            this.coltenKhoa.Width = 149;
            // 
            // selectAllSVTableAdapter
            // 
            this.selectAllSVTableAdapter.ClearBeforeFill = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 1;
            this.btnIn.ImageOptions.SvgImage = global::DangNhap.Properties.Resources.iconfinder_print_172530;
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // frmDTSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 504);
            this.Controls.Add(this.gridCSinhVien);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDaoTaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThemSV;
        private DevExpress.XtraBars.BarButtonItem btnXoaSV;
        private DevExpress.XtraBars.BarButtonItem btnSuaSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpEdit;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label laSoDT;
        private System.Windows.Forms.Label laLop;
        private System.Windows.Forms.Label laNganh;
        private System.Windows.Forms.Label laHoTen;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox picSinhVien;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel laEmail;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTatCa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLop;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKhoa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceNganh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKhoaHoc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceGioiTinh;
        private DevExpress.XtraGrid.GridControl gridCSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVSinhVien;
        private QLDaoTaoDataSet qlDaoTaoDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colmaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colgioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colnoiSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colhinh;
        private DevExpress.XtraGrid.Columns.GridColumn colkhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colmaLop;
        private DevExpress.XtraGrid.Columns.GridColumn colmaNganh;
        private DevExpress.XtraGrid.Columns.GridColumn coltenNganh;
        private DevExpress.XtraGrid.Columns.GridColumn colmaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn coltenKhoa;
        private QLDaoTaoDataSetTableAdapters.selectAllSVTableAdapter selectAllSVTableAdapter;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}