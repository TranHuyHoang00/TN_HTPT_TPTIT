
namespace HTPT
{
    partial class FrmChuanBiThiSV
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
            this.gbInfoSV = new System.Windows.Forms.GroupBox();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.labeltenlop = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bdsMH_DangKy = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new HTPT.DS();
            this.gcGVDK = new DevExpress.XtraGrid.GridControl();
            this.bdsDangKyThi = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_DANGKYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIETBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbDangKyThi = new HTPT.DSTableAdapters.DANGKYTHITableAdapter();
            this.tableAdapterManager = new HTPT.DSTableAdapters.TableAdapterManager();
            this.tbMH_DangKy = new HTPT.DSTableAdapters.SP_LAY_MH_DANGKYTableAdapter();
            this.gbInfoSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH_DangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKyThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoSV
            // 
            this.gbInfoSV.Controls.Add(this.txtTenLop);
            this.gbInfoSV.Controls.Add(this.labeltenlop);
            this.gbInfoSV.Controls.Add(this.txtMaLop);
            this.gbInfoSV.Controls.Add(this.labelControl3);
            this.gbInfoSV.Controls.Add(this.txtHoTen);
            this.gbInfoSV.Controls.Add(this.labelControl1);
            this.gbInfoSV.Controls.Add(this.txtMaSV);
            this.gbInfoSV.Controls.Add(this.labelControl4);
            this.gbInfoSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfoSV.Enabled = false;
            this.gbInfoSV.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbInfoSV.Location = new System.Drawing.Point(0, 0);
            this.gbInfoSV.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.gbInfoSV.Name = "gbInfoSV";
            this.gbInfoSV.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.gbInfoSV.Size = new System.Drawing.Size(1230, 87);
            this.gbInfoSV.TabIndex = 3;
            this.gbInfoSV.TabStop = false;
            this.gbInfoSV.Text = "Thông tin sinh viên";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(877, 37);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Size = new System.Drawing.Size(156, 24);
            this.txtTenLop.TabIndex = 17;
            // 
            // labeltenlop
            // 
            this.labeltenlop.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltenlop.Appearance.Options.UseFont = true;
            this.labeltenlop.Location = new System.Drawing.Point(818, 40);
            this.labeltenlop.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.labeltenlop.Name = "labeltenlop";
            this.labeltenlop.Size = new System.Drawing.Size(45, 17);
            this.labeltenlop.TabIndex = 16;
            this.labeltenlop.Text = "Tên lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(621, 37);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(156, 24);
            this.txtMaLop.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(565, 40);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 17);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Mã lớp";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(364, 37);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Size = new System.Drawing.Size(156, 24);
            this.txtHoTen.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(293, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 17);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Họ và tên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(73, 37);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(156, 24);
            this.txtMaSV.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 40);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Mã SV";
            // 
            // bdsMH_DangKy
            // 
            this.bdsMH_DangKy.DataMember = "SP_LAY_MH_DANGKY";
            this.bdsMH_DangKy.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcGVDK
            // 
            this.gcGVDK.DataSource = this.bdsDangKyThi;
            this.gcGVDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGVDK.Location = new System.Drawing.Point(0, 87);
            this.gcGVDK.MainView = this.gridView1;
            this.gcGVDK.Name = "gcGVDK";
            this.gcGVDK.Size = new System.Drawing.Size(1230, 166);
            this.gcGVDK.TabIndex = 41;
            this.gcGVDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_DANGKYTHI,
            this.colTIETBD,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colSOCAUTHI,
            this.colTHOIGIAN,
            this.colMAMH,
            this.colMALOP,
            this.colLAN});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gcGVDK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            // 
            // colID_DANGKYTHI
            // 
            this.colID_DANGKYTHI.FieldName = "ID_DANGKYTHI";
            this.colID_DANGKYTHI.Name = "colID_DANGKYTHI";
            this.colID_DANGKYTHI.Visible = true;
            this.colID_DANGKYTHI.VisibleIndex = 0;
            // 
            // colTIETBD
            // 
            this.colTIETBD.FieldName = "TIETBD";
            this.colTIETBD.Name = "colTIETBD";
            this.colTIETBD.Visible = true;
            this.colTIETBD.VisibleIndex = 1;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 3;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 4;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 5;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 6;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 7;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 8;
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(528, 446);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(122, 40);
            this.btnThi.TabIndex = 42;
            this.btnThi.Text = "Bắt đầu thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(741, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 40);
            this.btnThoat.TabIndex = 43;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tbDangKyThi
            // 
            this.tbDangKyThi.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = this.tbDangKyThi;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOAICAUHOITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HTPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbMH_DangKy
            // 
            this.tbMH_DangKy.ClearBeforeFill = true;
            // 
            // FrmChuanBiThiSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 749);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.gcGVDK);
            this.Controls.Add(this.gbInfoSV);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChuanBiThiSV";
            this.Text = "Chuẩn bị thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChuanBiThiSV_Load);
            this.gbInfoSV.ResumeLayout(false);
            this.gbInfoSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH_DangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKyThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoSV;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gcGVDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Button btnThoat;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsDangKyThi;
        private DSTableAdapters.DANGKYTHITableAdapter tbDangKyThi;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DANGKYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTIETBD;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private System.Windows.Forms.BindingSource bdsMH_DangKy;
        private DSTableAdapters.SP_LAY_MH_DANGKYTableAdapter tbMH_DangKy;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.LabelControl labeltenlop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}