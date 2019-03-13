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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.laHoTen = new System.Windows.Forms.Label();
            this.picGiangVien = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGiangVien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDaoTaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThemGV,
            this.btnXoaGV,
            this.btnSuaGV});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(867, 154);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 481);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(867, 22);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 154);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(152, 327);
            this.accordionControl1.TabIndex = 2;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Tìm kiếm";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Giới tính";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Trình độ";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Khoa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Load);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.picGiangVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(657, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 327);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(26, 255);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.laHoTen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 29);
            this.panel3.TabIndex = 1;
            // 
            // laHoTen
            // 
            this.laHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laHoTen.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.laHoTen.Location = new System.Drawing.Point(0, 0);
            this.laHoTen.Name = "laHoTen";
            this.laHoTen.Size = new System.Drawing.Size(210, 29);
            this.laHoTen.TabIndex = 0;
            this.laHoTen.Text = "Họ tên";
            this.laHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGiangVien
            // 
            this.picGiangVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.picGiangVien.Location = new System.Drawing.Point(0, 0);
            this.picGiangVien.Name = "picGiangVien";
            this.picGiangVien.Size = new System.Drawing.Size(210, 211);
            this.picGiangVien.TabIndex = 0;
            this.picGiangVien.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCGiangVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(152, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 327);
            this.panel2.TabIndex = 4;
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
            this.gridCGiangVien.Size = new System.Drawing.Size(505, 327);
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
            this.gridVGiangVien.GroupCount = 1;
            this.gridVGiangVien.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, " - Tổng: {0:n0}")});
            this.gridVGiangVien.Name = "gridVGiangVien";
            this.gridVGiangVien.OptionsFind.AlwaysVisible = true;
            this.gridVGiangVien.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltenKhoa, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colmaGV.Width = 57;
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
            this.colhoTen.Width = 124;
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
            this.colgioiTinh.Width = 67;
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
            this.coldiaChi.Width = 201;
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
            this.colSDT.Width = 69;
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
            this.colngaySinh.Width = 68;
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
            this.coltrinhDo.Visible = true;
            this.coltrinhDo.VisibleIndex = 7;
            this.coltrinhDo.Width = 54;
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
            this.colthamNien.VisibleIndex = 8;
            this.colthamNien.Width = 86;
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
            this.colemail.VisibleIndex = 9;
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
            this.coltenKhoa.Visible = true;
            this.coltenKhoa.VisibleIndex = 10;
            // 
            // giangVien_SelectAllTableAdapter
            // 
            this.giangVien_SelectAllTableAdapter.ClearBeforeFill = true;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(67, 285);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 4;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // frmDTGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmDTGiangVien";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Đào tạo - Giảng Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDTGiangVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGiangVien)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDaoTaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label laHoTen;
        private System.Windows.Forms.PictureBox picGiangVien;
        private DevExpress.XtraBars.BarButtonItem btnThemGV;
        private DevExpress.XtraBars.BarButtonItem btnXoaGV;
        private DevExpress.XtraBars.BarButtonItem btnSuaGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.Button Load;
    }
}