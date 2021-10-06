namespace QLBanHang.GUI
{
    partial class frmDanhSachNguoiDung
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDs = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(291, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 346);
            this.panel1.TabIndex = 1;
            // 
            // dgvDs
            // 
            this.dgvDs.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDs.Location = new System.Drawing.Point(0, 0);
            this.dgvDs.Name = "dgvDs";
            this.dgvDs.RowHeadersWidth = 51;
            this.dgvDs.RowTemplate.Height = 24;
            this.dgvDs.Size = new System.Drawing.Size(865, 346);
            this.dgvDs.TabIndex = 0;
            this.dgvDs.DoubleClick += new System.EventHandler(this.dgvDs_DoubleClick);
            // 
            // frmDanhSachNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(865, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmDanhSachNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH SÁCH NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frmDanhSachNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDs;
    }
}