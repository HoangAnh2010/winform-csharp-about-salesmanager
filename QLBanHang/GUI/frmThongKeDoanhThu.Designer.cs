namespace QLBanHang.GUI
{
    partial class frmThongKeDoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkNhap = new System.Windows.Forms.CheckBox();
            this.checkBan = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rabtnNgay = new System.Windows.Forms.RadioButton();
            this.rabtnThang = new System.Windows.Forms.RadioButton();
            this.rabtnNam = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 234);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 435);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvThongke);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(928, 315);
            this.panel4.TabIndex = 2;
            // 
            // dgvThongke
            // 
            this.dgvThongke.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongke.Location = new System.Drawing.Point(0, 0);
            this.dgvThongke.Name = "dgvThongke";
            this.dgvThongke.RowHeadersWidth = 51;
            this.dgvThongke.RowTemplate.Height = 24;
            this.dgvThongke.Size = new System.Drawing.Size(928, 315);
            this.dgvThongke.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnThongke);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 120);
            this.panel3.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::QLBanHang.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(525, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 60);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongke.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThongke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongke.Image = global::QLBanHang.Properties.Resources.statistics;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(274, 35);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(162, 60);
            this.btnThongke.TabIndex = 0;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkNhap);
            this.groupBox1.Controls.Add(this.checkBan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục thống kê";
            // 
            // checkNhap
            // 
            this.checkNhap.AutoSize = true;
            this.checkNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkNhap.Location = new System.Drawing.Point(92, 103);
            this.checkNhap.Name = "checkNhap";
            this.checkNhap.Size = new System.Drawing.Size(193, 29);
            this.checkNhap.TabIndex = 8;
            this.checkNhap.Text = "Chi phí nhập hàng";
            this.checkNhap.UseVisualStyleBackColor = true;
            // 
            // checkBan
            // 
            this.checkBan.AutoSize = true;
            this.checkBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBan.Location = new System.Drawing.Point(92, 46);
            this.checkBan.Name = "checkBan";
            this.checkBan.Size = new System.Drawing.Size(211, 29);
            this.checkBan.TabIndex = 7;
            this.checkBan.Text = "Doanh thu bán hàng";
            this.checkBan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rabtnNam);
            this.groupBox2.Controls.Add(this.rabtnThang);
            this.groupBox2.Controls.Add(this.rabtnNgay);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(475, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian thống kê";
            // 
            // rabtnNgay
            // 
            this.rabtnNgay.AutoSize = true;
            this.rabtnNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rabtnNgay.Location = new System.Drawing.Point(74, 45);
            this.rabtnNgay.Name = "rabtnNgay";
            this.rabtnNgay.Size = new System.Drawing.Size(207, 29);
            this.rabtnNgay.TabIndex = 0;
            this.rabtnNgay.TabStop = true;
            this.rabtnNgay.Text = "Thống kê theo ngày";
            this.rabtnNgay.UseVisualStyleBackColor = true;
            // 
            // rabtnThang
            // 
            this.rabtnThang.AutoSize = true;
            this.rabtnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rabtnThang.Location = new System.Drawing.Point(74, 102);
            this.rabtnThang.Name = "rabtnThang";
            this.rabtnThang.Size = new System.Drawing.Size(213, 29);
            this.rabtnThang.TabIndex = 1;
            this.rabtnThang.TabStop = true;
            this.rabtnThang.Text = "Thống kê theo tháng";
            this.rabtnThang.UseVisualStyleBackColor = true;
            // 
            // rabtnNam
            // 
            this.rabtnNam.AutoSize = true;
            this.rabtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rabtnNam.Location = new System.Drawing.Point(74, 164);
            this.rabtnNam.Name = "rabtnNam";
            this.rabtnNam.Size = new System.Drawing.Size(202, 29);
            this.rabtnNam.TabIndex = 2;
            this.rabtnNam.TabStop = true;
            this.rabtnNam.Text = "Thống kê theo năm";
            this.rabtnNam.UseVisualStyleBackColor = true;
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THỐNG KÊ DOANH THU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKeDoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rabtnNam;
        private System.Windows.Forms.RadioButton rabtnThang;
        private System.Windows.Forms.RadioButton rabtnNgay;
        private System.Windows.Forms.CheckBox checkNhap;
        private System.Windows.Forms.CheckBox checkBan;
    }
}