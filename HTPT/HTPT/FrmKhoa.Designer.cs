
namespace HTPT
{
    partial class FrmKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoa));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new HTPT.DS();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKhoaLop = new DevExpress.XtraEditors.TextEdit();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtActivate = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoSo = new DevExpress.XtraEditors.TextEdit();
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.labelMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.ctxMenuLop = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuyLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUndoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRedoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaiLaiLop = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbKhoa = new HTPT.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new HTPT.DSTableAdapters.TableAdapterManager();
            this.tbDangKyThi = new HTPT.DSTableAdapters.DANGKYTHITableAdapter();
            this.tbGiaoVien = new HTPT.DSTableAdapters.GIAOVIENTableAdapter();
            this.tbLop = new HTPT.DSTableAdapters.LOPTableAdapter();
            this.tbMonHoc = new HTPT.DSTableAdapters.MONHOCTableAdapter();
            this.tbSinhVien = new HTPT.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDangKyThi = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            this.ctxMenuLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKyThi)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbCoSo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 42);
            this.panel1.TabIndex = 4;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbbTenKhoa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMaKhoaLop);
            this.panel2.Controls.Add(this.labelTenLop);
            this.panel2.Controls.Add(this.txtTenLop);
            this.panel2.Controls.Add(this.labelMaLop);
            this.panel2.Controls.Add(this.txtMaLop);
            this.panel2.Controls.Add(this.txtActivate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCoSo);
            this.panel2.Controls.Add(this.tENMHLabel);
            this.panel2.Controls.Add(this.txtTenKhoa);
            this.panel2.Controls.Add(this.labelMaKhoa);
            this.panel2.Controls.Add(this.txtMaKhoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 83);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên khoa";
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLop, "MAKH", true));
            this.cbbTenKhoa.DataSource = this.bdsKhoa;
            this.cbbTenKhoa.DisplayMember = "TENKH";
            this.cbbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhoa.Enabled = false;
            this.cbbTenKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(788, 46);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(165, 25);
            this.cbbTenKhoa.TabIndex = 25;
            this.cbbTenKhoa.ValueMember = "MAKH";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.DS;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã khoa";
            // 
            // txtMaKhoaLop
            // 
            this.txtMaKhoaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKH", true));
            this.txtMaKhoaLop.Enabled = false;
            this.txtMaKhoaLop.Location = new System.Drawing.Point(575, 49);
            this.txtMaKhoaLop.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaKhoaLop.Name = "txtMaKhoaLop";
            this.txtMaKhoaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoaLop.Size = new System.Drawing.Size(121, 24);
            this.txtMaKhoaLop.TabIndex = 24;
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenLop.Location = new System.Drawing.Point(733, 16);
            this.labelTenLop.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(53, 17);
            this.labelTenLop.TabIndex = 21;
            this.labelTenLop.Text = "Tên lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(788, 13);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Size = new System.Drawing.Size(165, 24);
            this.txtTenLop.TabIndex = 22;
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaLop.Location = new System.Drawing.Point(522, 16);
            this.labelMaLop.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(50, 17);
            this.labelMaLop.TabIndex = 19;
            this.labelMaLop.Text = "Mã lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(574, 13);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(122, 24);
            this.txtMaLop.TabIndex = 20;
            // 
            // txtActivate
            // 
            this.txtActivate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "ACTIVATE", true));
            this.txtActivate.Enabled = false;
            this.txtActivate.Location = new System.Drawing.Point(279, 49);
            this.txtActivate.Margin = new System.Windows.Forms.Padding(1);
            this.txtActivate.Name = "txtActivate";
            this.txtActivate.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivate.Properties.Appearance.Options.UseFont = true;
            this.txtActivate.Size = new System.Drawing.Size(199, 24);
            this.txtActivate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã cơ sở";
            // 
            // txtCoSo
            // 
            this.txtCoSo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtCoSo.Enabled = false;
            this.txtCoSo.Location = new System.Drawing.Point(74, 49);
            this.txtCoSo.Margin = new System.Windows.Forms.Padding(1);
            this.txtCoSo.Name = "txtCoSo";
            this.txtCoSo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoSo.Properties.Appearance.Options.UseFont = true;
            this.txtCoSo.Size = new System.Drawing.Size(123, 24);
            this.txtCoSo.TabIndex = 15;
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENMHLabel.Location = new System.Drawing.Point(214, 16);
            this.tENMHLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(63, 17);
            this.tENMHLabel.TabIndex = 12;
            this.tENMHLabel.Text = "Tên khoa";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.txtTenKhoa.Enabled = false;
            this.txtTenKhoa.Location = new System.Drawing.Point(279, 13);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(199, 24);
            this.txtTenKhoa.TabIndex = 13;
            // 
            // labelMaKhoa
            // 
            this.labelMaKhoa.AutoSize = true;
            this.labelMaKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKhoa.Location = new System.Drawing.Point(7, 16);
            this.labelMaKhoa.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelMaKhoa.Name = "labelMaKhoa";
            this.labelMaKhoa.Size = new System.Drawing.Size(60, 17);
            this.labelMaKhoa.TabIndex = 10;
            this.labelMaKhoa.Text = "Mã khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(74, 13);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(123, 24);
            this.txtMaKhoa.TabIndex = 11;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcKhoa.Location = new System.Drawing.Point(0, 68);
            this.gcKhoa.MainView = this.gridView1;
            this.gcKhoa.MenuManager = this.barManager2;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(500, 310);
            this.gcKhoa.TabIndex = 38;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colACTIVATE,
            this.colMACS});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gcKhoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colACTIVATE
            // 
            this.colACTIVATE.FieldName = "ACTIVATE";
            this.colACTIVATE.Name = "colACTIVATE";
            this.colACTIVATE.Visible = true;
            this.colACTIVATE.VisibleIndex = 2;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 3;
            // 
            // gcLop
            // 
            this.gcLop.ContextMenuStrip = this.ctxMenuLop;
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gcLop.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcLop.Location = new System.Drawing.Point(500, 68);
            this.gcLop.MainView = this.gridView2;
            this.gcLop.MenuManager = this.barManager2;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(484, 310);
            this.gcLop.TabIndex = 39;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // ctxMenuLop
            // 
            this.ctxMenuLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxMenuLop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemLop,
            this.btnSuaLop,
            this.btnXoaLop,
            this.btnHuyLop,
            this.btnGhiLop,
            this.btnUndoLop,
            this.btnRedoLop,
            this.btnTaiLaiLop});
            this.ctxMenuLop.Name = "ctxMenuLop";
            this.ctxMenuLop.Size = new System.Drawing.Size(182, 180);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(181, 22);
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(181, 22);
            this.btnSuaLop.Text = "Sửa lớp";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(181, 22);
            this.btnXoaLop.Text = "Xóa lớp";
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnHuyLop
            // 
            this.btnHuyLop.Name = "btnHuyLop";
            this.btnHuyLop.Size = new System.Drawing.Size(181, 22);
            this.btnHuyLop.Text = "Hủy thêm/sửa lớp";
            this.btnHuyLop.Click += new System.EventHandler(this.btnHuyLop_Click);
            // 
            // btnGhiLop
            // 
            this.btnGhiLop.Name = "btnGhiLop";
            this.btnGhiLop.Size = new System.Drawing.Size(181, 22);
            this.btnGhiLop.Text = "Ghi lớp";
            this.btnGhiLop.Click += new System.EventHandler(this.btnGhiLop_Click);
            // 
            // btnUndoLop
            // 
            this.btnUndoLop.Name = "btnUndoLop";
            this.btnUndoLop.Size = new System.Drawing.Size(181, 22);
            this.btnUndoLop.Text = "Phục hồi lớp";
            // 
            // btnRedoLop
            // 
            this.btnRedoLop.Name = "btnRedoLop";
            this.btnRedoLop.Size = new System.Drawing.Size(181, 22);
            this.btnRedoLop.Text = "Quay lại lớp";
            // 
            // btnTaiLaiLop
            // 
            this.btnTaiLaiLop.Name = "btnTaiLaiLop";
            this.btnTaiLaiLop.Size = new System.Drawing.Size(181, 22);
            this.btnTaiLaiLop.Text = "Tải lại lớp";
            this.btnTaiLaiLop.Click += new System.EventHandler(this.btnTaiLaiLop_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH1});
            this.gridView2.DetailHeight = 458;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView2.GridControl = this.gcLop;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 2;
            // 
            // tbKhoa
            // 
            this.tbKhoa.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = this.tbDangKyThi;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.tbGiaoVien;
            this.tableAdapterManager.KHOATableAdapter = this.tbKhoa;
            this.tableAdapterManager.LOAICAUHOITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.tbLop;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.tbMonHoc;
            this.tableAdapterManager.SINHVIENTableAdapter = this.tbSinhVien;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HTPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbDangKyThi
            // 
            this.tbDangKyThi.ClearBeforeFill = true;
            // 
            // tbGiaoVien
            // 
            this.tbGiaoVien.ClearBeforeFill = true;
            // 
            // tbLop
            // 
            this.tbLop.ClearBeforeFill = true;
            // 
            // tbMonHoc
            // 
            this.tbMonHoc.ClearBeforeFill = true;
            // 
            // tbSinhVien
            // 
            this.tbSinhVien.ClearBeforeFill = true;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "FK__MONHOC__MAKH__36B12243";
            this.bdsMonHoc.DataSource = this.bdsKhoa;
            // 
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "FK__GIAOVIEN__MAKH__300424B4";
            this.bdsGiaoVien.DataSource = this.bdsKhoa;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK__SINHVIEN__MALOP__32E0915F";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // bdsDangKyThi
            // 
            this.bdsDangKyThi.DataMember = "FK__DANGKYTHI__MALOP__4BAC3F29";
            this.bdsDangKyThi.DataSource = this.bdsLop;
            // 
            // FrmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.gcLop);
            this.Controls.Add(this.gcKhoa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FrmKhoa";
            this.Text = "FrmKhoa";
            this.Load += new System.EventHandler(this.FrmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            this.ctxMenuLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKyThi)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DSTableAdapters.KHOATableAdapter tbKhoa;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTableAdapter tbLop;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.MONHOCTableAdapter tbMonHoc;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSTableAdapters.GIAOVIENTableAdapter tbGiaoVien;
        private System.Windows.Forms.BindingSource bdsGiaoVien;
        private DSTableAdapters.SINHVIENTableAdapter tbSinhVien;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DSTableAdapters.DANGKYTHITableAdapter tbDangKyThi;
        private System.Windows.Forms.BindingSource bdsDangKyThi;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCoSo;
        private System.Windows.Forms.Label tENMHLabel;
        private DevExpress.XtraEditors.TextEdit txtTenKhoa;
        private System.Windows.Forms.Label labelMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private System.Windows.Forms.ContextMenuStrip ctxMenuLop;
        private System.Windows.Forms.ToolStripMenuItem btnThemLop;
        private System.Windows.Forms.ToolStripMenuItem btnSuaLop;
        private System.Windows.Forms.ToolStripMenuItem btnXoaLop;
        private System.Windows.Forms.ToolStripMenuItem btnHuyLop;
        private System.Windows.Forms.ToolStripMenuItem btnGhiLop;
        private System.Windows.Forms.ToolStripMenuItem btnUndoLop;
        private System.Windows.Forms.ToolStripMenuItem btnRedoLop;
        private System.Windows.Forms.ToolStripMenuItem btnTaiLaiLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVATE;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtActivate;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMaKhoaLop;
        private System.Windows.Forms.Label labelTenLop;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private System.Windows.Forms.Label labelMaLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
    }
}