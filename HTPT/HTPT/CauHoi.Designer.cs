
namespace HTPT
{
    partial class CauHoi
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
            this.labelCauSo = new System.Windows.Forms.Label();
            this.labelNoiDung = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLC = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelCauSo
            // 
            this.labelCauSo.AutoSize = true;
            this.labelCauSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCauSo.Location = new System.Drawing.Point(57, 14);
            this.labelCauSo.Name = "labelCauSo";
            this.labelCauSo.Size = new System.Drawing.Size(45, 19);
            this.labelCauSo.TabIndex = 0;
            this.labelCauSo.Text = "Câu: ";
            // 
            // labelNoiDung
            // 
            this.labelNoiDung.AutoSize = true;
            this.labelNoiDung.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoiDung.Location = new System.Drawing.Point(57, 37);
            this.labelNoiDung.Name = "labelNoiDung";
            this.labelNoiDung.Size = new System.Drawing.Size(61, 17);
            this.labelNoiDung.TabIndex = 1;
            this.labelNoiDung.Text = "Nội dung";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 10);
            this.panel1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLC
            // 
            this.flowLC.Location = new System.Drawing.Point(61, 57);
            this.flowLC.Name = "flowLC";
            this.flowLC.Size = new System.Drawing.Size(662, 140);
            this.flowLC.TabIndex = 17;
            // 
            // CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.flowLC);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNoiDung);
            this.Controls.Add(this.labelCauSo);
            this.Name = "CauHoi";
            this.Size = new System.Drawing.Size(984, 216);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCauSo;
        private System.Windows.Forms.Label labelNoiDung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.FlowLayoutPanel flowLC;
    }
}
