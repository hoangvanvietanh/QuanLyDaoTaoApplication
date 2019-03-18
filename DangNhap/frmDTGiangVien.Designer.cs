namespace DangNhap
{
    partial class frmDTGiangVien
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
            this.btnThemGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.picGiangVien = new System.Windows.Forms.PictureBox();
            this.gridCGiangVien = new DevExpress.XtraGrid.GridControl();
            this.qlDaoTaoDataSet = new DangNhap.QLDaoTaoDataSet();
            this.gridVGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoiSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrinhDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthamNien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giangVien_SelectAllTableAdapter = new DangNhap.QLDaoTaoDataSetTableAdapters.GiangVien_SelectAllTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceSapXep = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTatCa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKhoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTrinhDo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceGioiTinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThamNien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel2 = new System.Windows.Forms.Panel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.laEmail = new System.Windows.Forms.LinkLabel();
            this.laSoDT = new System.Windows.Forms.Label();
            this.laKhoa = new System.Windows.Forms.Label();
            this.laTrinhDo = new System.Windows.Forms.Label();
            this.laHoTen = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDaoTaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThemGV,
            this.btnXoaGV,
            this.btnSuaGV,
            this.btnIn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(868, 154);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnThemGV
            // 
            this.btnThemGV.Caption = "Thêm GV";
            this.btnThemGV.Id = 1;
            this.btnThemGV.ImageOptions.SvgImage = global::DangNhap.Properties.Resources.businessman;
            this.btnThemGV.LargeWidth = 80;
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemGV_ItemClick);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Caption = "Xóa GV";
            this.btnXoaGV.Id = 2;
            this.btnXoaGV.ImageOptions.SvgImage = global::DangNhap.Properties.Resources.delete_modern_user;
            this.btnXoaGV.LargeWidth = 80;
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaGV_ItemClick);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Caption = "Sửa GV";
            this.btnSuaGV.Id = 3;
            this.btnSuaGV.ImageOptions.SvgImage = global::DangNhap.Properties.Resources.edit_woman_with_bund_profile;
            this.btnSuaGV.LargeWidth = 80;
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaGV_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 4;
            this.btnIn.ImageOptions.SvgImage = global::DangNhap.Properties.Resources.iconfinder_print_172530;
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang Chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThemGV);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "New";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXoaGV);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSuaGV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Edit";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnIn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "In";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 511);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(868, 22);
            // 
            // picGiangVien
            // 
            this.picGiangVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGiangVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.picGiangVien.Image = global::DangNhap.Properties.Resources._19d8a051527db023e96c;
            this.picGiangVien.Location = new System.Drawing.Point(10, 0);
            this.picGiangVien.Name = "picGiangVien";
            this.picGiangVien.Size = new System.Drawing.Size(186, 186);
            this.picGiangVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGiangVien.TabIndex = 0;
            this.picGiangVien.TabStop = false;
            // 
            // gridCGiangVien
            // 
            this.gridCGiangVien.DataMember = "GiangVien_SelectAll";
            this.gridCGiangVien.DataSource = this.qlDaoTaoDataSet;
            this.gridCGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCGiangVien.Location = new System.Drawing.Point(0, 0);
            this.gridCGiangVien.MainView = this.gridVGiangVien;
            this.gridCGiangVien.MenuManager = this.ribbon;
            this.gridCGiangVien.Name = "gridCGiangVien";
            this.gridCGiangVien.Size = new System.Drawing.Size(288, 341);
            this.gridCGiangVien.TabIndex = 0;
            this.gridCGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVGiangVien});
            // 
            // qlDaoTaoDataSet
            // 
            this.qlDaoTaoDataSet.DataSetName = "QLDaoTaoDataSet";
            this.qlDaoTaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridVGiangVien
            // 
            this.gridVGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaGV,
            this.colhoTen,
            this.colgioiTinh,
            this.coldiaChi,
            this.colSDT,
            this.colngaySinh,
            this.colnoiSinh,
            this.coltrinhDo,
            this.colthamNien,
            this.colemail,
            this.colhinh,
            this.colmaKhoa,
            this.coltenKhoa});
            this.gridVGiangVien.GridControl = this.gridCGiangVien;
            this.gridVGiangVien.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, " - Tổng: {0:n0}")});
            this.gridVGiangVien.Name = "gridVGiangVien";
            this.gridVGiangVien.OptionsFind.AlwaysVisible = true;
            this.gridVGiangVien.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridVGiangVien_RowCellClick_1);
            // 
            // colmaGV
            // 
            this.colmaGV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmaGV.AppearanceHeader.Options.UseFont = true;
            this.colmaGV.AppearanceHeader.Options.UseTextOptions = true;
            this.colmaGV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmaGV.Caption = "Mã GV";
            this.colmaGV.FieldName = "maGV";
            this.colmaGV.Name = "colmaGV";
            this.colmaGV.OptionsColumn.AllowEdit = false;
            this.colmaGV.OptionsColumn.AllowFocus = false;
            this.colmaGV.Visible = true;
            this.colmaGV.VisibleIndex = 0;
            this.colmaGV.Width = 101;
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
            this.colhoTen.Width = 203;
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
            this.colgioiTinh.Width = 84;
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
            this.coldiaChi.Width = 334;
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
            this.colSDT.Width = 34;
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
            this.colngaySinh.Width = 176;
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
            this.colnoiSinh.Width = 130;
            // 
            // coltrinhDo
            // 
            this.coltrinhDo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coltrinhDo.AppearanceHeader.Options.UseFont = true;
            this.coltrinhDo.AppearanceHeader.Options.UseTextOptions = true;
            this.coltrinhDo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrinhDo.Caption = "Trình độ";
            this.coltrinhDo.FieldName = "trinhDo";
            this.coltrinhDo.Name = "coltrinhDo";
            this.coltrinhDo.OptionsColumn.AllowEdit = false;
            this.coltrinhDo.OptionsColumn.AllowFocus = false;
            this.coltrinhDo.Width = 53;
            // 
            // colthamNien
            // 
            this.colthamNien.AppearanceCell.Options.UseTextOptions = true;
            this.colthamNien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthamNien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colthamNien.AppearanceHeader.Options.UseFont = true;
            this.colthamNien.AppearanceHeader.Options.UseTextOptions = true;
            this.colthamNien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthamNien.Caption = "Thâm niên";
            this.colthamNien.FieldName = "thamNien";
            this.colthamNien.Name = "colthamNien";
            this.colthamNien.OptionsColumn.AllowEdit = false;
            this.colthamNien.OptionsColumn.AllowFocus = false;
            this.colthamNien.Visible = true;
            this.colthamNien.VisibleIndex = 6;
            this.colthamNien.Width = 107;
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
            this.colemail.Width = 260;
            // 
            // colhinh
            // 
            this.colhinh.FieldName = "hinh";
            this.colhinh.Name = "colhinh";
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
            // 
            // giangVien_SelectAllTableAdapter
            // 
            this.giangVien_SelectAllTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 16);
            this.panel1.TabIndex = 7;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceSapXep});
            this.accordionControl1.Location = new System.Drawing.Point(0, 170);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(106, 341);
            this.accordionControl1.TabIndex = 8;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceSapXep
            // 
            this.aceSapXep.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceTatCa,
            this.aceKhoa,
            this.aceTrinhDo,
            this.aceGioiTinh,
            this.aceThamNien});
            this.aceSapXep.Expanded = true;
            this.aceSapXep.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
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
            // aceKhoa
            // 
            this.aceKhoa.Name = "aceKhoa";
            this.aceKhoa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKhoa.Text = "Khoa";
            this.aceKhoa.Click += new System.EventHandler(this.aceKhoa_Click);
            // 
            // aceTrinhDo
            // 
            this.aceTrinhDo.Name = "aceTrinhDo";
            this.aceTrinhDo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceTrinhDo.Text = "Trình độ";
            this.aceTrinhDo.Click += new System.EventHandler(this.aceTrinhDo_Click);
            // 
            // aceGioiTinh
            // 
            this.aceGioiTinh.Name = "aceGioiTinh";
            this.aceGioiTinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceGioiTinh.Text = "Giới tính";
            this.aceGioiTinh.Click += new System.EventHandler(this.aceGioiTinh_Click);
            // 
            // aceThamNien
            // 
            this.aceThamNien.Name = "aceThamNien";
            this.aceThamNien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThamNien.Text = "Thâm niên";
            this.aceThamNien.Click += new System.EventHandler(this.aceThamNien_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.separatorControl1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(404, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 341);
            this.panel2.TabIndex = 9;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl1.Location = new System.Drawing.Point(0, 186);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(464, 24);
            this.separatorControl1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.laEmail);
            this.panel5.Controls.Add(this.laSoDT);
            this.panel5.Controls.Add(this.laKhoa);
            this.panel5.Controls.Add(this.laTrinhDo);
            this.panel5.Controls.Add(this.laHoTen);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.picGiangVien);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(464, 186);
            this.panel5.TabIndex = 1;
            // 
            // laEmail
            // 
            this.laEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laEmail.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEmail.Location = new System.Drawing.Point(211, 153);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(253, 33);
            this.laEmail.TabIndex = 6;
            this.laEmail.TabStop = true;
            this.laEmail.Text = "Email";
            // 
            // laSoDT
            // 
            this.laSoDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.laSoDT.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSoDT.Location = new System.Drawing.Point(211, 121);
            this.laSoDT.Name = "laSoDT";
            this.laSoDT.Size = new System.Drawing.Size(253, 32);
            this.laSoDT.TabIndex = 5;
            this.laSoDT.Text = "Số điện thoại";
            this.laSoDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laKhoa
            // 
            this.laKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.laKhoa.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laKhoa.Location = new System.Drawing.Point(211, 90);
            this.laKhoa.Name = "laKhoa";
            this.laKhoa.Size = new System.Drawing.Size(253, 31);
            this.laKhoa.TabIndex = 4;
            this.laKhoa.Text = "Khoa";
            // 
            // laTrinhDo
            // 
            this.laTrinhDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.laTrinhDo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTrinhDo.Location = new System.Drawing.Point(211, 48);
            this.laTrinhDo.Name = "laTrinhDo";
            this.laTrinhDo.Size = new System.Drawing.Size(253, 42);
            this.laTrinhDo.TabIndex = 3;
            this.laTrinhDo.Text = "Trình độ";
            this.laTrinhDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laHoTen
            // 
            this.laHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.laHoTen.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHoTen.Location = new System.Drawing.Point(211, 0);
            this.laHoTen.Name = "laHoTen";
            this.laHoTen.Size = new System.Drawing.Size(253, 48);
            this.laHoTen.TabIndex = 2;
            this.laHoTen.Text = "Họ tên";
            this.laHoTen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(196, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 186);
            this.panel7.TabIndex = 1;
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
            this.panel3.Location = new System.Drawing.Point(394, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 341);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridCGiangVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(106, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 341);
            this.panel4.TabIndex = 11;
            // 
            // frmDTGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 533);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmDTGiangVien";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Đào tạo - Giảng Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDTGiangVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDaoTaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.PictureBox picGiangVien;
        private DevExpress.XtraBars.BarButtonItem btnThemGV;
        private DevExpress.XtraBars.BarButtonItem btnXoaGV;
        private DevExpress.XtraBars.BarButtonItem btnSuaGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridCGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVGiangVien;
        private QLDaoTaoDataSet qlDaoTaoDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colmaGV;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colgioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colnoiSinh;
        private DevExpress.XtraGrid.Columns.GridColumn coltrinhDo;
        private DevExpress.XtraGrid.Columns.GridColumn colthamNien;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colhinh;
        private DevExpress.XtraGrid.Columns.GridColumn colmaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn coltenKhoa;
        private QLDaoTaoDataSetTableAdapters.GiangVien_SelectAllTableAdapter giangVien_SelectAllTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSapXep;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel laEmail;
        private System.Windows.Forms.Label laSoDT;
        private System.Windows.Forms.Label laTrinhDo;
        private System.Windows.Forms.Label laHoTen;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTatCa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKhoa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTrinhDo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceGioiTinh;
        private System.Windows.Forms.Label laKhoa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThamNien;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}