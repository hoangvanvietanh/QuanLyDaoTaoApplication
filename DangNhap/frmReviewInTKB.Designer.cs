namespace DangNhap
{
    partial class frmReviewInTKB
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
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.crystalReportTKBGV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.inThoiKhoaBieu1 = new DangNhap.inThoiKhoaBieu();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(25, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // crystalReportTKBGV
            // 
            this.crystalReportTKBGV.ActiveViewIndex = 0;
            this.crystalReportTKBGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportTKBGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportTKBGV.Location = new System.Drawing.Point(177, 29);
            this.crystalReportTKBGV.Name = "crystalReportTKBGV";
            this.crystalReportTKBGV.ReportSource = this.inThoiKhoaBieu1;
            this.crystalReportTKBGV.Size = new System.Drawing.Size(668, 348);
            this.crystalReportTKBGV.TabIndex = 2;
            this.crystalReportTKBGV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            // 
            // frmReviewInTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 432);
            this.Controls.Add(this.crystalReportTKBGV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmReviewInTKB";
            this.Text = "In Thời Khóa Biểu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.TextBox textBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportTKBGV;
        private inThoiKhoaBieu inThoiKhoaBieu1;
    }
}