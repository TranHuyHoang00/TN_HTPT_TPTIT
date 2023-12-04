
namespace HTPT
{
    partial class FrmDangKyThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKyThi));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcDangKyThi = new DevExpress.XtraGrid.GridControl();
            this.bdsDangKyThi = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new HTPT.DS();
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
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NVPGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAUHOI_CS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAUHOI_CS2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numTietBD = new DevExpress.XtraEditors.SpinEdit();
            this.txtCauThiCS2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtCauThiCS1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cbbTenPGV = new System.Windows.Forms.ComboBox();
            this.bdsGetPGV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaPGV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbbTenGV = new System.Windows.Forms.ComboBox();
            this.bdsGetGV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.labelTenKhoa = new DevExpress.XtraEditors.LabelControl();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbbTenMon = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaMon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.numThoiGian = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.numSoCau = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tbDangKyThi = new HTPT.DSTableAdapters.DANGKYTHITableAdapter();
            this.tableAdapterManager = new HTPT.DSTableAdapters.TableAdapterManager();
            this.tbThi = new HTPT.DSTableAdapters.THITableAdapter();
            this.bdsThi = new System.Windows.Forms.BindingSource(this.components);
            this.tbMonHoc = new HTPT.DSTableAdapters.MONHOCTableAdapter();
            this.tbLop = new HTPT.DSTableAdapters.LOPTableAdapter();
            this.tbGetGV = new HTPT.DSTableAdapters.SP_GET_GVTableAdapter();
            this.tbGetPGV = new HTPT.DSTableAdapters.SP_GET_PGVTableAdapter();
            this.cbbTrinhDo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKyThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKyThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTietBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauThiCS2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauThiCS1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGetPGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGetGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThi)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnHuy,
            this.btnGhi,
            this.btnUndo,
            this.btnRedo,
            this.btnTaiLai,
            this.btnThoat});
            this.barManager2.MainMenu = this.bar6;
            this.barManager2.MaxItemId = 22;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.FloatLocation = new System.Drawing.Point(138, 122);
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaiLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.ActAsDropDown = true;
            this.btnThem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 13;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 14;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 15;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnHuy.Caption = "Hủy thêm/sửa";
            this.btnHuy.Id = 16;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 17;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 18;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRedo
            // 
            this.btnRedo.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnRedo.Caption = "Quay lại";
            this.btnRedo.Id = 19;
            this.btnRedo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedo.ImageOptions.SvgImage")));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnTaiLai.Caption = "Tải lại";
            this.btnTaiLai.Id = 20;
            this.btnTaiLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiLai.ImageOptions.SvgImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 21;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControl1.Size = new System.Drawing.Size(984, 26);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 461);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControl2.Size = new System.Drawing.Size(984, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 26);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControl3.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(984, 26);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControl4.Size = new System.Drawing.Size(0, 435);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Chuyển khoa";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Khoa";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(384, 11);
            this.cbbCoSo.Margin = new System.Windows.Forms.Padding(1);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(234, 23);
            this.cbbCoSo.TabIndex = 14;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbCoSo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 42);
            this.panel1.TabIndex = 5;
            // 
            // gcDangKyThi
            // 
            this.gcDangKyThi.DataSource = this.bdsDangKyThi;
            this.gcDangKyThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDangKyThi.Location = new System.Drawing.Point(0, 68);
            this.gcDangKyThi.MainView = this.gridView1;
            this.gcDangKyThi.MenuManager = this.barManager2;
            this.gcDangKyThi.Name = "gcDangKyThi";
            this.gcDangKyThi.Size = new System.Drawing.Size(984, 393);
            this.gcDangKyThi.TabIndex = 6;
            this.gcDangKyThi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsDangKyThi
            // 
            this.bdsDangKyThi.DataMember = "DANGKYTHI";
            this.bdsDangKyThi.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colLAN,
            this.colMAGV,
            this.colMA_NVPGV,
            this.colCAUHOI_CS1,
            this.colCAUHOI_CS2});
            this.gridView1.GridControl = this.gcDangKyThi;
            this.gridView1.Name = "gridView1";
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
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            // 
            // colMA_NVPGV
            // 
            this.colMA_NVPGV.FieldName = "MA_NVPGV";
            this.colMA_NVPGV.Name = "colMA_NVPGV";
            this.colMA_NVPGV.Visible = true;
            this.colMA_NVPGV.VisibleIndex = 10;
            // 
            // colCAUHOI_CS1
            // 
            this.colCAUHOI_CS1.FieldName = "CAUHOI_CS1";
            this.colCAUHOI_CS1.Name = "colCAUHOI_CS1";
            this.colCAUHOI_CS1.Visible = true;
            this.colCAUHOI_CS1.VisibleIndex = 11;
            // 
            // colCAUHOI_CS2
            // 
            this.colCAUHOI_CS2.FieldName = "CAUHOI_CS2";
            this.colCAUHOI_CS2.Name = "colCAUHOI_CS2";
            this.colCAUHOI_CS2.Visible = true;
            this.colCAUHOI_CS2.VisibleIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbTrinhDo);
            this.panel2.Controls.Add(this.numTietBD);
            this.panel2.Controls.Add(this.txtCauThiCS2);
            this.panel2.Controls.Add(this.labelControl11);
            this.panel2.Controls.Add(this.txtCauThiCS1);
            this.panel2.Controls.Add(this.labelControl10);
            this.panel2.Controls.Add(this.cbbTenPGV);
            this.panel2.Controls.Add(this.txtMaPGV);
            this.panel2.Controls.Add(this.labelControl5);
            this.panel2.Controls.Add(this.cbbTenGV);
            this.panel2.Controls.Add(this.txtMaGV);
            this.panel2.Controls.Add(this.labelTenKhoa);
            this.panel2.Controls.Add(this.cbbTenLop);
            this.panel2.Controls.Add(this.txtMaLop);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.cbbTenMon);
            this.panel2.Controls.Add(this.txtMaMon);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.cbbLanThi);
            this.panel2.Controls.Add(this.labelControl6);
            this.panel2.Controls.Add(this.numThoiGian);
            this.panel2.Controls.Add(this.labelControl8);
            this.panel2.Controls.Add(this.numSoCau);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.dateNgayThi);
            this.panel2.Controls.Add(this.labelControl7);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.labelControl9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 137);
            this.panel2.TabIndex = 7;
            // 
            // numTietBD
            // 
            this.numTietBD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangKyThi, "TIETBD", true));
            this.numTietBD.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTietBD.Enabled = false;
            this.numTietBD.Location = new System.Drawing.Point(82, 12);
            this.numTietBD.MenuManager = this.barManager2;
            this.numTietBD.Name = "numTietBD";
            this.numTietBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numTietBD.Size = new System.Drawing.Size(128, 20);
            this.numTietBD.TabIndex = 67;
            // 
            // txtCauThiCS2
            // 
            this.txtCauThiCS2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangKyThi, "CAUHOI_CS2", true));
            this.txtCauThiCS2.Enabled = false;
            this.txtCauThiCS2.Location = new System.Drawing.Point(846, 103);
            this.txtCauThiCS2.MenuManager = this.barManager2;
            this.txtCauThiCS2.Name = "txtCauThiCS2";
            this.txtCauThiCS2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauThiCS2.Properties.Appearance.Options.UseFont = true;
            this.txtCauThiCS2.Size = new System.Drawing.Size(120, 24);
            this.txtCauThiCS2.TabIndex = 66;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(765, 109);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(75, 17);
            this.labelControl11.TabIndex = 65;
            this.labelControl11.Text = "Câu thi_CS2";
            // 
            // txtCauThiCS1
            // 
            this.txtCauThiCS1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangKyThi, "CAUHOI_CS1", true));
            this.txtCauThiCS1.Enabled = false;
            this.txtCauThiCS1.Location = new System.Drawing.Point(846, 71);
            this.txtCauThiCS1.MenuManager = this.barManager2;
            this.txtCauThiCS1.Name = "txtCauThiCS1";
            this.txtCauThiCS1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauThiCS1.Properties.Appearance.Options.UseFont = true;
            this.txtCauThiCS1.Size = new System.Drawing.Size(120, 24);
            this.txtCauThiCS1.TabIndex = 64;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(765, 77);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(75, 17);
            this.labelControl10.TabIndex = 63;
            this.labelControl10.Text = "Câu thi_CS1";
            // 
            // cbbTenPGV
            // 
            this.cbbTenPGV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDangKyThi, "MA_NVPGV", true));
            this.cbbTenPGV.DataSource = this.bdsGetPGV;
            this.cbbTenPGV.DisplayMember = "HOTEN";
            this.cbbTenPGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenPGV.Enabled = false;
            this.cbbTenPGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenPGV.FormattingEnabled = true;
            this.cbbTenPGV.Location = new System.Drawing.Point(645, 40);
            this.cbbTenPGV.Name = "cbbTenPGV";
            this.cbbTenPGV.Size = new System.Drawing.Size(195, 25);
            this.cbbTenPGV.TabIndex = 62;
            this.cbbTenPGV.ValueMember = "MAGV";
            // 
            // bdsGetPGV
            // 
            this.bdsGetPGV.DataMember = "SP_GET_PGV";
            this.bdsGetPGV.DataSource = this.DS;
            // 
            // txtMaPGV
            // 
            this.txtMaPGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGetPGV, "MAGV", true));
            this.txtMaPGV.Enabled = false;
            this.txtMaPGV.Location = new System.Drawing.Point(846, 40);
            this.txtMaPGV.MenuManager = this.barManager2;
            this.txtMaPGV.Name = "txtMaPGV";
            this.txtMaPGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaPGV.Size = new System.Drawing.Size(120, 24);
            this.txtMaPGV.TabIndex = 61;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(583, 44);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 17);
            this.labelControl5.TabIndex = 60;
            this.labelControl5.Text = "PGV";
            // 
            // cbbTenGV
            // 
            this.cbbTenGV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDangKyThi, "MAGV", true));
            this.cbbTenGV.DataSource = this.bdsGetGV;
            this.cbbTenGV.DisplayMember = "HOTEN";
            this.cbbTenGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenGV.Enabled = false;
            this.cbbTenGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenGV.FormattingEnabled = true;
            this.cbbTenGV.Location = new System.Drawing.Point(645, 9);
            this.cbbTenGV.Name = "cbbTenGV";
            this.cbbTenGV.Size = new System.Drawing.Size(195, 25);
            this.cbbTenGV.TabIndex = 59;
            this.cbbTenGV.ValueMember = "MAGV";
            // 
            // bdsGetGV
            // 
            this.bdsGetGV.DataMember = "SP_GET_GV";
            this.bdsGetGV.DataSource = this.DS;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGetGV, "MAGV", true));
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(846, 9);
            this.txtMaGV.MenuManager = this.barManager2;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaGV.Size = new System.Drawing.Size(120, 24);
            this.txtMaGV.TabIndex = 58;
            // 
            // labelTenKhoa
            // 
            this.labelTenKhoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKhoa.Appearance.Options.UseFont = true;
            this.labelTenKhoa.Location = new System.Drawing.Point(583, 13);
            this.labelTenKhoa.Name = "labelTenKhoa";
            this.labelTenKhoa.Size = new System.Drawing.Size(56, 17);
            this.labelTenKhoa.TabIndex = 57;
            this.labelTenKhoa.Text = "Giáo viên";
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDangKyThi, "MALOP", true));
            this.cbbTenLop.DataSource = this.bdsLop;
            this.cbbTenLop.DisplayMember = "TENLOP";
            this.cbbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenLop.Enabled = false;
            this.cbbTenLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(336, 106);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(182, 25);
            this.cbbTenLop.TabIndex = 56;
            this.cbbTenLop.ValueMember = "MALOP";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(524, 107);
            this.txtMaLop.MenuManager = this.barManager2;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(120, 24);
            this.txtMaLop.TabIndex = 55;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(275, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 17);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "Lớp";
            // 
            // cbbTenMon
            // 
            this.cbbTenMon.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDangKyThi, "MAMH", true));
            this.cbbTenMon.DataSource = this.bdsMonHoc;
            this.cbbTenMon.DisplayMember = "TENMH";
            this.cbbTenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenMon.Enabled = false;
            this.cbbTenMon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenMon.FormattingEnabled = true;
            this.cbbTenMon.Location = new System.Drawing.Point(336, 74);
            this.cbbTenMon.Name = "cbbTenMon";
            this.cbbTenMon.Size = new System.Drawing.Size(182, 25);
            this.cbbTenMon.TabIndex = 53;
            this.cbbTenMon.ValueMember = "MAMH";
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DS;
            // 
            // txtMaMon
            // 
            this.txtMaMon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.txtMaMon.Enabled = false;
            this.txtMaMon.Location = new System.Drawing.Point(524, 75);
            this.txtMaMon.MenuManager = this.barManager2;
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Properties.Appearance.Options.UseFont = true;
            this.txtMaMon.Size = new System.Drawing.Size(120, 24);
            this.txtMaMon.TabIndex = 52;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(275, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 17);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Môn học";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDangKyThi, "LAN", true));
            this.cbbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanThi.Enabled = false;
            this.cbbLanThi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(336, 43);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(128, 25);
            this.cbbLanThi.TabIndex = 50;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(275, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 17);
            this.labelControl6.TabIndex = 49;
            this.labelControl6.Text = "Lần thi";
            // 
            // numThoiGian
            // 
            this.numThoiGian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangKyThi, "THOIGIAN", true));
            this.numThoiGian.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numThoiGian.Enabled = false;
            this.numThoiGian.Location = new System.Drawing.Point(336, 10);
            this.numThoiGian.MenuManager = this.barManager2;
            this.numThoiGian.Name = "numThoiGian";
            this.numThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThoiGian.Properties.Appearance.Options.UseFont = true;
            this.numThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numThoiGian.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numThoiGian.Properties.MinValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numThoiGian.Size = new System.Drawing.Size(128, 24);
            this.numThoiGian.TabIndex = 48;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(275, 15);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 17);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "Thời gian";
            // 
            // numSoCau
            // 
            this.numSoCau.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangKyThi, "SOCAUTHI", true));
            this.numSoCau.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSoCau.Enabled = false;
            this.numSoCau.Location = new System.Drawing.Point(82, 103);
            this.numSoCau.MenuManager = this.barManager2;
            this.numSoCau.Name = "numSoCau";
            this.numSoCau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoCau.Properties.Appearance.Options.UseFont = true;
            this.numSoCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numSoCau.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numSoCau.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSoCau.Size = new System.Drawing.Size(128, 24);
            this.numSoCau.TabIndex = 46;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 17);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Tổng câu";
            // 
            // dateNgayThi
            // 
            this.dateNgayThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangKyThi, "NGAYTHI", true));
            this.dateNgayThi.EditValue = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            this.dateNgayThi.Enabled = false;
            this.dateNgayThi.Location = new System.Drawing.Point(82, 71);
            this.dateNgayThi.MenuManager = this.barManager2;
            this.dateNgayThi.Name = "dateNgayThi";
            this.dateNgayThi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThi.Properties.Appearance.Options.UseFont = true;
            this.dateNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Properties.CalendarTimeProperties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.dateNgayThi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateNgayThi.Size = new System.Drawing.Size(128, 24);
            this.dateNgayThi.TabIndex = 44;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(20, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 17);
            this.labelControl7.TabIndex = 43;
            this.labelControl7.Text = "Ngày thi";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 17);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Trình độ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(20, 13);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 17);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "Tiết BD";
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
            this.tableAdapterManager.THITableAdapter = this.tbThi;
            this.tableAdapterManager.UpdateOrder = HTPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbThi
            // 
            this.tbThi.ClearBeforeFill = true;
            // 
            // bdsThi
            // 
            this.bdsThi.DataMember = "FK__THI__ID_DANGKYTH__5165187F";
            this.bdsThi.DataSource = this.bdsDangKyThi;
            // 
            // tbMonHoc
            // 
            this.tbMonHoc.ClearBeforeFill = true;
            // 
            // tbLop
            // 
            this.tbLop.ClearBeforeFill = true;
            // 
            // tbGetGV
            // 
            this.tbGetGV.ClearBeforeFill = true;
            // 
            // tbGetPGV
            // 
            this.tbGetPGV.ClearBeforeFill = true;
            // 
            // cbbTrinhDo
            // 
            this.cbbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDangKyThi, "TRINHDO", true));
            this.cbbTrinhDo.Enabled = false;
            this.cbbTrinhDo.FormattingEnabled = true;
            this.cbbTrinhDo.Location = new System.Drawing.Point(82, 43);
            this.cbbTrinhDo.Name = "cbbTrinhDo";
            this.cbbTrinhDo.Size = new System.Drawing.Size(128, 21);
            this.cbbTrinhDo.TabIndex = 68;
            // 
            // FrmDangKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gcDangKyThi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FrmDangKyThi";
            this.Text = "FrmDangKyThi";
            this.Load += new System.EventHandler(this.FrmDangKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDangKyThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKyThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTietBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauThiCS2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCauThiCS1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGetPGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGetGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcDangKyThi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NVPGV;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI_CS1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI_CS2;
        private DSTableAdapters.THITableAdapter tbThi;
        private System.Windows.Forms.BindingSource bdsThi;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit numThoiGian;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit numSoCau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateNgayThi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbbTenMon;
        private DevExpress.XtraEditors.TextEdit txtMaMon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbbTenPGV;
        private DevExpress.XtraEditors.TextEdit txtMaPGV;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbbTenGV;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.LabelControl labelTenKhoa;
        private DevExpress.XtraEditors.TextEdit txtCauThiCS2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtCauThiCS1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSTableAdapters.MONHOCTableAdapter tbMonHoc;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter tbLop;
        private System.Windows.Forms.BindingSource bdsGetGV;
        private DSTableAdapters.SP_GET_GVTableAdapter tbGetGV;
        private System.Windows.Forms.BindingSource bdsGetPGV;
        private DSTableAdapters.SP_GET_PGVTableAdapter tbGetPGV;
        private DevExpress.XtraEditors.SpinEdit numTietBD;
        private System.Windows.Forms.ComboBox cbbTrinhDo;
    }
}