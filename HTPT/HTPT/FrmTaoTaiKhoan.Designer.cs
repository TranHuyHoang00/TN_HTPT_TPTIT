
namespace HTPT
{
    partial class FrmTaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaoTaiKhoan));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.cbbTenGV = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.cbbLoaiTK = new System.Windows.Forms.ComboBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbLoginName = new System.Windows.Forms.Label();
            this.lbLoaiTaiKhoan = new System.Windows.Forms.Label();
            this.DS = new HTPT.DS();
            this.bdsGVChuaDK = new System.Windows.Forms.BindingSource(this.components);
            this.tbGVChuaDK = new HTPT.DSTableAdapters.SP_GET_GV_CHUA_DKTableAdapter();
            this.tableAdapterManager = new HTPT.DSTableAdapters.TableAdapterManager();
            this.sP_GET_GV_CHUA_DKBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sP_GET_GV_CHUA_DKBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVChuaDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_GV_CHUA_DKBindingNavigator)).BeginInit();
            this.sP_GET_GV_CHUA_DKBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(378, 213);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(277, 27);
            this.txtPassword.TabIndex = 43;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(671, 171);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaGV.Size = new System.Drawing.Size(93, 26);
            this.txtMaGV.TabIndex = 42;
            // 
            // cbbTenGV
            // 
            this.cbbTenGV.DataSource = this.bdsGVChuaDK;
            this.cbbTenGV.DisplayMember = "HOTEN";
            this.cbbTenGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenGV.FormattingEnabled = true;
            this.cbbTenGV.Location = new System.Drawing.Point(378, 169);
            this.cbbTenGV.Margin = new System.Windows.Forms.Padding(1);
            this.cbbTenGV.Name = "cbbTenGV";
            this.cbbTenGV.Size = new System.Drawing.Size(277, 28);
            this.cbbTenGV.TabIndex = 41;
            this.cbbTenGV.ValueMember = "MAGV";
            this.cbbTenGV.SelectedIndexChanged += new System.EventHandler(this.cbbTenGV_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(523, 261);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 44);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(378, 261);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(1);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(132, 44);
            this.btnDangKy.TabIndex = 39;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(378, 128);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(277, 27);
            this.txtTenDangNhap.TabIndex = 38;
            // 
            // cbbLoaiTK
            // 
            this.cbbLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiTK.FormattingEnabled = true;
            this.cbbLoaiTK.Location = new System.Drawing.Point(378, 85);
            this.cbbLoaiTK.Margin = new System.Windows.Forms.Padding(1);
            this.cbbLoaiTK.Name = "cbbLoaiTK";
            this.cbbLoaiTK.Size = new System.Drawing.Size(277, 28);
            this.cbbLoaiTK.TabIndex = 37;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(263, 216);
            this.lbPass.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(75, 20);
            this.lbPass.TabIndex = 36;
            this.lbPass.Text = "Mật khẩu";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(254, 174);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(84, 20);
            this.lbUserName.TabIndex = 35;
            this.lbUserName.Text = "Giảng viên";
            // 
            // lbLoginName
            // 
            this.lbLoginName.AutoSize = true;
            this.lbLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginName.Location = new System.Drawing.Point(231, 131);
            this.lbLoginName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(116, 20);
            this.lbLoginName.TabIndex = 34;
            this.lbLoginName.Text = "Tên đăng nhập";
            // 
            // lbLoaiTaiKhoan
            // 
            this.lbLoaiTaiKhoan.AutoSize = true;
            this.lbLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTaiKhoan.Location = new System.Drawing.Point(239, 88);
            this.lbLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbLoaiTaiKhoan.Name = "lbLoaiTaiKhoan";
            this.lbLoaiTaiKhoan.Size = new System.Drawing.Size(108, 20);
            this.lbLoaiTaiKhoan.TabIndex = 33;
            this.lbLoaiTaiKhoan.Text = "Loại tài khoản";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGVChuaDK
            // 
            this.bdsGVChuaDK.DataMember = "SP_GET_GV_CHUA_DK";
            this.bdsGVChuaDK.DataSource = this.DS;
            // 
            // tbGVChuaDK
            // 
            this.tbGVChuaDK.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTHITableAdapter = null;
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
            // sP_GET_GV_CHUA_DKBindingNavigator
            // 
            this.sP_GET_GV_CHUA_DKBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sP_GET_GV_CHUA_DKBindingNavigator.BindingSource = this.bdsGVChuaDK;
            this.sP_GET_GV_CHUA_DKBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sP_GET_GV_CHUA_DKBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sP_GET_GV_CHUA_DKBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sP_GET_GV_CHUA_DKBindingNavigatorSaveItem});
            this.sP_GET_GV_CHUA_DKBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sP_GET_GV_CHUA_DKBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sP_GET_GV_CHUA_DKBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sP_GET_GV_CHUA_DKBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sP_GET_GV_CHUA_DKBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sP_GET_GV_CHUA_DKBindingNavigator.Name = "sP_GET_GV_CHUA_DKBindingNavigator";
            this.sP_GET_GV_CHUA_DKBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sP_GET_GV_CHUA_DKBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.sP_GET_GV_CHUA_DKBindingNavigator.TabIndex = 44;
            this.sP_GET_GV_CHUA_DKBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sP_GET_GV_CHUA_DKBindingNavigatorSaveItem
            // 
            this.sP_GET_GV_CHUA_DKBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sP_GET_GV_CHUA_DKBindingNavigatorSaveItem.Enabled = false;
            this.sP_GET_GV_CHUA_DKBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sP_GET_GV_CHUA_DKBindingNavigatorSaveItem.Image")));
            this.sP_GET_GV_CHUA_DKBindingNavigatorSaveItem.Name = "sP_GET_GV_CHUA_DKBindingNavigatorSaveItem";
            this.sP_GET_GV_CHUA_DKBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sP_GET_GV_CHUA_DKBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // FrmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.sP_GET_GV_CHUA_DKBindingNavigator);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.cbbTenGV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.cbbLoaiTK);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbLoginName);
            this.Controls.Add(this.lbLoaiTaiKhoan);
            this.Name = "FrmTaoTaiKhoan";
            this.Text = "FrmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.FrmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVChuaDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_GV_CHUA_DKBindingNavigator)).EndInit();
            this.sP_GET_GV_CHUA_DKBindingNavigator.ResumeLayout(false);
            this.sP_GET_GV_CHUA_DKBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private System.Windows.Forms.ComboBox cbbTenGV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.ComboBox cbbLoaiTK;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbLoginName;
        private System.Windows.Forms.Label lbLoaiTaiKhoan;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsGVChuaDK;
        private DSTableAdapters.SP_GET_GV_CHUA_DKTableAdapter tbGVChuaDK;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sP_GET_GV_CHUA_DKBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sP_GET_GV_CHUA_DKBindingNavigatorSaveItem;
    }
}