
namespace HTPT
{
    partial class LuaChon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbNoiDung = new System.Windows.Forms.RadioButton();
            this.lbThuTu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbNoiDung
            // 
            this.rbNoiDung.AutoSize = true;
            this.rbNoiDung.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoiDung.Location = new System.Drawing.Point(38, 2);
            this.rbNoiDung.Name = "rbNoiDung";
            this.rbNoiDung.Size = new System.Drawing.Size(73, 21);
            this.rbNoiDung.TabIndex = 17;
            this.rbNoiDung.TabStop = true;
            this.rbNoiDung.Text = "Đáp án ";
            this.rbNoiDung.UseVisualStyleBackColor = true;
            this.rbNoiDung.CheckedChanged += new System.EventHandler(this.rbNoiDung_CheckedChanged);
            // 
            // lbThuTu
            // 
            this.lbThuTu.AutoSize = true;
            this.lbThuTu.Location = new System.Drawing.Point(6, 6);
            this.lbThuTu.Name = "lbThuTu";
            this.lbThuTu.Size = new System.Drawing.Size(14, 13);
            this.lbThuTu.TabIndex = 18;
            this.lbThuTu.Text = "A";
            // 
            // LuaChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lbThuTu);
            this.Controls.Add(this.rbNoiDung);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LuaChon";
            this.Size = new System.Drawing.Size(470, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbNoiDung;
        private System.Windows.Forms.Label lbThuTu;
    }
}
