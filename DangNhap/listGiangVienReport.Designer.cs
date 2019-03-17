namespace DangNhap
{
    partial class listGiangVienReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listGiangVienReport));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.panel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.txtMaGV = new DevExpress.XtraReports.UI.XRRichText();
            this.txtHoTen = new DevExpress.XtraReports.UI.XRRichText();
            this.txtKhoa = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txtNgaySinh = new DevExpress.XtraReports.UI.XRRichText();
            this.txtGioiTinh = new DevExpress.XtraReports.UI.XRRichText();
            this.txtNoiSinh = new DevExpress.XtraReports.UI.XRRichText();
            this.txtDiaChi = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSoDT = new DevExpress.XtraReports.UI.XRRichText();
            this.txtTrinhDo = new DevExpress.XtraReports.UI.XRRichText();
            this.txtEmail = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrinhDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DangNhap.Properties.Settings.QuanLyDaoTaoConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "GiangVien_SelectAll";
            storedProcQuery1.StoredProcName = "GiangVien_SelectAll";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.panel1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 2874.458F;
            this.Detail.MultiColumn.ColumnSpacing = 25F;
            this.Detail.MultiColumn.ColumnWidth = 902F;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 200F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // panel1
            // 
            this.panel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.panel1.CanGrow = false;
            this.panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.txtMaGV,
            this.txtHoTen,
            this.txtKhoa,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel4,
            this.xrPictureBox1,
            this.xrPictureBox2,
            this.txtNgaySinh,
            this.txtGioiTinh,
            this.txtNoiSinh,
            this.txtDiaChi,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.txtSoDT,
            this.txtTrinhDo,
            this.txtEmail,
            this.xrLine1});
            this.panel1.Dpi = 254F;
            this.panel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 24.99977F);
            this.panel1.Name = "panel1";
            this.panel1.SizeF = new System.Drawing.SizeF(1829F, 2757.271F);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtMaGV.Dpi = 254F;
            this.txtMaGV.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[maGV]")});
            this.txtMaGV.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtMaGV.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 689.6042F);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtMaGV.SerializableRtfString = resources.GetString("txtMaGV.SerializableRtfString");
            this.txtMaGV.SizeF = new System.Drawing.SizeF(874.7084F, 58.41998F);
            this.txtMaGV.StylePriority.UseBorders = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtHoTen.Dpi = 254F;
            this.txtHoTen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[hoTen]")});
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtHoTen.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 790.1459F);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtHoTen.SerializableRtfString = resources.GetString("txtHoTen.SerializableRtfString");
            this.txtHoTen.SizeF = new System.Drawing.SizeF(874.7084F, 58.42004F);
            this.txtHoTen.StylePriority.UseBorders = false;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtKhoa.Dpi = 254F;
            this.txtKhoa.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[tenKhoa]")});
            this.txtKhoa.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtKhoa.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 1393.396F);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtKhoa.SerializableRtfString = resources.GetString("txtKhoa.SerializableRtfString");
            this.txtKhoa.SizeF = new System.Drawing.SizeF(874.7084F, 58.42004F);
            this.txtKhoa.StylePriority.UseBorders = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(480F, 790.1459F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(177.2708F, 58.42004F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.Text = "Họ tên";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(480F, 689.6042F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(177.2708F, 58.41998F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.Text = "Mã GV";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(551.4376F, 22.64259F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(486.8334F, 58.42F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.Text = "BỘ GIÁO DỤC VÀ ĐÀO TẠO";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(612.2919F, 81.0626F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(336.0209F, 58.41996F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.Text = "ĐẠI HỌC GIA ĐỊNH";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBox1.Dpi = 254F;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(535.5626F, 139.4825F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(486.8334F, 351.8959F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            this.xrPictureBox1.StylePriority.UseBorders = false;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Dpi = 254F;
            this.xrPictureBox2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "[hinh]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[hinh]")});
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 737.2294F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(453.5419F, 508.2121F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtNgaySinh.Dpi = 254F;
            this.txtNgaySinh.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[ngaySinh]")});
            this.txtNgaySinh.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNgaySinh.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 971.311F);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtNgaySinh.SerializableRtfString = resources.GetString("txtNgaySinh.SerializableRtfString");
            this.txtNgaySinh.SizeF = new System.Drawing.SizeF(874.7084F, 58.42004F);
            this.txtNgaySinh.StylePriority.UseBorders = false;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtGioiTinh.Dpi = 254F;
            this.txtGioiTinh.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[gioiTinh]")});
            this.txtGioiTinh.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtGioiTinh.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 888.0419F);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtGioiTinh.SerializableRtfString = resources.GetString("txtGioiTinh.SerializableRtfString");
            this.txtGioiTinh.SizeF = new System.Drawing.SizeF(874.7084F, 58.42004F);
            this.txtGioiTinh.StylePriority.UseBorders = false;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtNoiSinh.Dpi = 254F;
            this.txtNoiSinh.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[noiSinh]")});
            this.txtNoiSinh.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNoiSinh.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 1086.479F);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtNoiSinh.SerializableRtfString = resources.GetString("txtNoiSinh.SerializableRtfString");
            this.txtNoiSinh.SizeF = new System.Drawing.SizeF(874.7084F, 58.42004F);
            this.txtNoiSinh.StylePriority.UseBorders = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtDiaChi.Dpi = 254F;
            this.txtDiaChi.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[diaChi]")});
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtDiaChi.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 1187.021F);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtDiaChi.SerializableRtfString = resources.GetString("txtDiaChi.SerializableRtfString");
            this.txtDiaChi.SizeF = new System.Drawing.SizeF(874.7084F, 58.41992F);
            this.txtDiaChi.StylePriority.UseBorders = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(480F, 888.0419F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(177.2708F, 58.42004F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.Text = "Giới tính";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(480F, 983.2919F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(177.2708F, 58.4201F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.Text = "Ngày sinh";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(480F, 1086.479F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(177.2708F, 58.42004F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.Text = "Nơi sinh";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(480F, 1187.021F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(177.2708F, 58.41992F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.Text = "Địa chỉ";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(480F, 1282.271F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(177.2708F, 58.41992F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.Text = "Trình độ";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(480F, 1393.396F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(177.2708F, 58.42004F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.Text = "Khoa";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(480F, 1483.355F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(177.2708F, 58.42004F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.Text = "Số ĐT";
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(480F, 1586.542F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(177.2708F, 58.42017F);
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.Text = "Email";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtSoDT.Dpi = 254F;
            this.txtSoDT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[SDT]")});
            this.txtSoDT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSoDT.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 1483.355F);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtSoDT.SerializableRtfString = resources.GetString("txtSoDT.SerializableRtfString");
            this.txtSoDT.SizeF = new System.Drawing.SizeF(874.7084F, 58.42004F);
            this.txtSoDT.StylePriority.UseBorders = false;
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtTrinhDo.Dpi = 254F;
            this.txtTrinhDo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[trinhDo]")});
            this.txtTrinhDo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtTrinhDo.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 1282.271F);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtTrinhDo.SerializableRtfString = resources.GetString("txtTrinhDo.SerializableRtfString");
            this.txtTrinhDo.SizeF = new System.Drawing.SizeF(874.7084F, 58.41992F);
            this.txtTrinhDo.StylePriority.UseBorders = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtEmail.Dpi = 254F;
            this.txtEmail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "[email]")});
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEmail.LocationFloat = new DevExpress.Utils.PointFloat(675.7919F, 1586.542F);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtEmail.SerializableRtfString = resources.GetString("txtEmail.SerializableRtfString");
            this.txtEmail.SizeF = new System.Drawing.SizeF(874.7084F, 58.42017F);
            this.txtEmail.StylePriority.UseBorders = false;
            // 
            // xrLine1
            // 
            this.xrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine1.Dpi = 254F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(278.9166F, 546.7291F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1005.417F, 58.42004F);
            this.xrLine1.StylePriority.UseBorders = false;
            // 
            // PageFooter
            // 
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 254F;
            this.PageFooter.Name = "PageFooter";
            // 
            // listGiangVienReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "GiangVien_SelectAll";
            this.DataSource = this.sqlDataSource1;
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(130, 141, 200, 0);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 12;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrinhDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel panel1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRRichText txtMaGV;
        private DevExpress.XtraReports.UI.XRRichText txtHoTen;
        private DevExpress.XtraReports.UI.XRRichText txtKhoa;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRRichText txtNgaySinh;
        private DevExpress.XtraReports.UI.XRRichText txtGioiTinh;
        private DevExpress.XtraReports.UI.XRRichText txtNoiSinh;
        private DevExpress.XtraReports.UI.XRRichText txtDiaChi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRRichText txtSoDT;
        private DevExpress.XtraReports.UI.XRRichText txtTrinhDo;
        private DevExpress.XtraReports.UI.XRRichText txtEmail;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
    }
}
