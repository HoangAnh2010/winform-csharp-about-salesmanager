namespace QLBanHang.GUI
{
    partial class frmDaiLy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChiDL = new System.Windows.Forms.TextBox();
            this.txtHoTenDL = new System.Windows.Forms.TextBox();
            this.txtMaDL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoatDL = new System.Windows.Forms.Button();
            this.btnXoaDL = new System.Windows.Forms.Button();
            this.btnSuaDL = new System.Windows.Forms.Button();
            this.btnLuuDL = new System.Windows.Forms.Button();
            this.btnThemDL = new System.Windows.Forms.Button();
            this.dgvDaiLy = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDiaChiDL);
            this.panel1.Controls.Add(this.txtHoTenDL);
            this.panel1.Controls.Add(this.txtMaDL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 151);
            this.panel1.TabIndex = 0;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSdt.Location = new System.Drawing.Point(489, 37);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(364, 30);
            this.txtSdt.TabIndex = 2;
            this.txtSdt.TextChanged += new System.EventHandler(this.txtSdt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(405, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "SDT:";
            // 
            // txtDiaChiDL
            // 
            this.txtDiaChiDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiDL.Location = new System.Drawing.Point(489, 86);
            this.txtDiaChiDL.Name = "txtDiaChiDL";
            this.txtDiaChiDL.Size = new System.Drawing.Size(364, 30);
            this.txtDiaChiDL.TabIndex = 3;
            this.txtDiaChiDL.TextChanged += new System.EventHandler(this.txtDiaChiDL_TextChanged);
            // 
            // txtHoTenDL
            // 
            this.txtHoTenDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTenDL.Location = new System.Drawing.Point(118, 81);
            this.txtHoTenDL.Name = "txtHoTenDL";
            this.txtHoTenDL.Size = new System.Drawing.Size(276, 30);
            this.txtHoTenDL.TabIndex = 1;
            this.txtHoTenDL.TextChanged += new System.EventHandler(this.txtHoTenDL_TextChanged);
            // 
            // txtMaDL
            // 
            this.txtMaDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDL.Location = new System.Drawing.Point(118, 37);
            this.txtMaDL.Name = "txtMaDL";
            this.txtMaDL.Size = new System.Drawing.Size(276, 30);
            this.txtMaDL.TabIndex = 0;
            this.txtMaDL.TextChanged += new System.EventHandler(this.txtMaDL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(405, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên ĐL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã ĐL:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnThoatDL);
            this.panel2.Controls.Add(this.btnXoaDL);
            this.panel2.Controls.Add(this.btnSuaDL);
            this.panel2.Controls.Add(this.btnLuuDL);
            this.panel2.Controls.Add(this.btnThemDL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 112);
            this.panel2.TabIndex = 1;
            // 
            // btnThoatDL
            // 
            this.btnThoatDL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThoatDL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatDL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoatDL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoatDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatDL.Image = global::QLBanHang.Properties.Resources.exit;
            this.btnThoatDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatDL.Location = new System.Drawing.Point(673, 30);
            this.btnThoatDL.Name = "btnThoatDL";
            this.btnThoatDL.Size = new System.Drawing.Size(127, 57);
            this.btnThoatDL.TabIndex = 4;
            this.btnThoatDL.Text = "Thoát";
            this.btnThoatDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatDL.UseVisualStyleBackColor = false;
            this.btnThoatDL.Click += new System.EventHandler(this.btnThoatDL_Click);
            // 
            // btnXoaDL
            // 
            this.btnXoaDL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoaDL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaDL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaDL.Image = global::QLBanHang.Properties.Resources.delete;
            this.btnXoaDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDL.Location = new System.Drawing.Point(521, 30);
            this.btnXoaDL.Name = "btnXoaDL";
            this.btnXoaDL.Size = new System.Drawing.Size(113, 57);
            this.btnXoaDL.TabIndex = 3;
            this.btnXoaDL.Text = "Xóa";
            this.btnXoaDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDL.UseVisualStyleBackColor = false;
            this.btnXoaDL.Click += new System.EventHandler(this.btnXoaDL_Click);
            // 
            // btnSuaDL
            // 
            this.btnSuaDL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSuaDL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaDL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaDL.Image = global::QLBanHang.Properties.Resources.change;
            this.btnSuaDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDL.Location = new System.Drawing.Point(372, 30);
            this.btnSuaDL.Name = "btnSuaDL";
            this.btnSuaDL.Size = new System.Drawing.Size(110, 57);
            this.btnSuaDL.TabIndex = 2;
            this.btnSuaDL.Text = "Sửa";
            this.btnSuaDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDL.UseVisualStyleBackColor = false;
            this.btnSuaDL.Click += new System.EventHandler(this.btnSuaDL_Click);
            // 
            // btnLuuDL
            // 
            this.btnLuuDL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuuDL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuuDL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuuDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuDL.Image = global::QLBanHang.Properties.Resources.save;
            this.btnLuuDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuDL.Location = new System.Drawing.Point(224, 30);
            this.btnLuuDL.Name = "btnLuuDL";
            this.btnLuuDL.Size = new System.Drawing.Size(109, 57);
            this.btnLuuDL.TabIndex = 1;
            this.btnLuuDL.Text = "Lưu";
            this.btnLuuDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuDL.UseVisualStyleBackColor = false;
            this.btnLuuDL.Click += new System.EventHandler(this.btnLuuDL_Click);
            // 
            // btnThemDL
            // 
            this.btnThemDL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThemDL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemDL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemDL.Image = global::QLBanHang.Properties.Resources.add;
            this.btnThemDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDL.Location = new System.Drawing.Point(57, 30);
            this.btnThemDL.Name = "btnThemDL";
            this.btnThemDL.Size = new System.Drawing.Size(128, 57);
            this.btnThemDL.TabIndex = 0;
            this.btnThemDL.Text = "Thêm";
            this.btnThemDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDL.UseVisualStyleBackColor = false;
            this.btnThemDL.Click += new System.EventHandler(this.btnThemDL_Click);
            // 
            // dgvDaiLy
            // 
            this.dgvDaiLy.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDaiLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDaiLy.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDaiLy.Location = new System.Drawing.Point(0, 151);
            this.dgvDaiLy.Name = "dgvDaiLy";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDaiLy.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDaiLy.RowHeadersWidth = 51;
            this.dgvDaiLy.RowTemplate.Height = 24;
            this.dgvDaiLy.Size = new System.Drawing.Size(876, 335);
            this.dgvDaiLy.TabIndex = 2;
            this.dgvDaiLy.Click += new System.EventHandler(this.dgvDaiLy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 598);
            this.Controls.Add(this.dgvDaiLy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH MỤC ĐẠI LÝ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDaiLy_FormClosing);
            this.Load += new System.EventHandler(this.frmDaiLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChiDL;
        private System.Windows.Forms.TextBox txtHoTenDL;
        private System.Windows.Forms.TextBox txtMaDL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDaiLy;
        private System.Windows.Forms.Button btnThoatDL;
        private System.Windows.Forms.Button btnXoaDL;
        private System.Windows.Forms.Button btnSuaDL;
        private System.Windows.Forms.Button btnLuuDL;
        private System.Windows.Forms.Button btnThemDL;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}