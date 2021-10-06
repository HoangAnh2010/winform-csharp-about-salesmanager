namespace QLBanHang.GUI
{
    partial class frmHoaDonNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnThoatHDX = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnInHDX = new System.Windows.Forms.Button();
            this.btnLuuHDX = new System.Windows.Forms.Button();
            this.btnHuyHDX = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSoLg = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMasp = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboMaDL = new System.Windows.Forms.ComboBox();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtDc = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTendl = new System.Windows.Forms.TextBox();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 794);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.btnThemCT);
            this.panel4.Controls.Add(this.btnThoatHDX);
            this.panel4.Controls.Add(this.btnThemMoi);
            this.panel4.Controls.Add(this.btnInHDX);
            this.panel4.Controls.Add(this.btnLuuHDX);
            this.panel4.Controls.Add(this.btnHuyHDX);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 665);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1199, 129);
            this.panel4.TabIndex = 2;
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThemCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemCT.Image = global::QLBanHang.Properties.Resources.add1;
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCT.Location = new System.Drawing.Point(204, 34);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(189, 60);
            this.btnThemCT.TabIndex = 1;
            this.btnThemCT.Text = "Thêm vào hđ";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnThoatHDX
            // 
            this.btnThoatHDX.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoatHDX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoatHDX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoatHDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatHDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatHDX.Image = global::QLBanHang.Properties.Resources.exit;
            this.btnThoatHDX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatHDX.Location = new System.Drawing.Point(1026, 34);
            this.btnThoatHDX.Name = "btnThoatHDX";
            this.btnThoatHDX.Size = new System.Drawing.Size(145, 60);
            this.btnThoatHDX.TabIndex = 5;
            this.btnThoatHDX.Text = "Thoát";
            this.btnThoatHDX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatHDX.UseVisualStyleBackColor = false;
            this.btnThoatHDX.Click += new System.EventHandler(this.btnThoatHDX_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThemMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMoi.Image = global::QLBanHang.Properties.Resources.add;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(26, 34);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(158, 60);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnInHDX
            // 
            this.btnInHDX.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnInHDX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInHDX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInHDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInHDX.Image = global::QLBanHang.Properties.Resources.print;
            this.btnInHDX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHDX.Location = new System.Drawing.Point(831, 34);
            this.btnInHDX.Name = "btnInHDX";
            this.btnInHDX.Size = new System.Drawing.Size(175, 60);
            this.btnInHDX.TabIndex = 4;
            this.btnInHDX.Text = "In hóa đơn";
            this.btnInHDX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHDX.UseVisualStyleBackColor = false;
            this.btnInHDX.Click += new System.EventHandler(this.btnInHDX_Click);
            // 
            // btnLuuHDX
            // 
            this.btnLuuHDX.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuuHDX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuuHDX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuuHDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuHDX.Image = global::QLBanHang.Properties.Resources.save;
            this.btnLuuHDX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHDX.Location = new System.Drawing.Point(413, 34);
            this.btnLuuHDX.Name = "btnLuuHDX";
            this.btnLuuHDX.Size = new System.Drawing.Size(186, 60);
            this.btnLuuHDX.TabIndex = 2;
            this.btnLuuHDX.Text = "Lưu hóa đơn";
            this.btnLuuHDX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuHDX.UseVisualStyleBackColor = false;
            this.btnLuuHDX.Click += new System.EventHandler(this.btnLuuHDX_Click);
            // 
            // btnHuyHDX
            // 
            this.btnHuyHDX.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnHuyHDX.Enabled = false;
            this.btnHuyHDX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuyHDX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuyHDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyHDX.Image = global::QLBanHang.Properties.Resources.delete;
            this.btnHuyHDX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyHDX.Location = new System.Drawing.Point(619, 34);
            this.btnHuyHDX.Name = "btnHuyHDX";
            this.btnHuyHDX.Size = new System.Drawing.Size(192, 60);
            this.btnHuyHDX.TabIndex = 3;
            this.btnHuyHDX.Text = "Hủy hóa đơn";
            this.btnHuyHDX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyHDX.UseVisualStyleBackColor = false;
            this.btnHuyHDX.Click += new System.EventHandler(this.btnHuyHDX_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1199, 429);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtTongTien);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 349);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1193, 77);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBanHang.Properties.Resources.clear;
            this.pictureBox1.Location = new System.Drawing.Point(23, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 68);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::QLBanHang.Properties.Resources.clear;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(1093, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "VND";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(859, 14);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(228, 30);
            this.txtTongTien.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(742, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Tổng tiền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(103, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Nháy đúp 1 dòng để xóa";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvHDN);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1193, 190);
            this.panel5.TabIndex = 1;
            // 
            // dgvHDN
            // 
            this.dgvHDN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDN.Location = new System.Drawing.Point(0, 0);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.RowHeadersWidth = 51;
            this.dgvHDN.RowTemplate.Height = 24;
            this.dgvHDN.Size = new System.Drawing.Size(1193, 190);
            this.dgvHDN.TabIndex = 0;
            this.dgvHDN.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDN_CellContentDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.txtSoLg);
            this.panel3.Controls.Add(this.txtThanhTien);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cboMasp);
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtTensp);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1193, 141);
            this.panel3.TabIndex = 0;
            // 
            // txtSoLg
            // 
            this.txtSoLg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLg.Location = new System.Drawing.Point(557, 78);
            this.txtSoLg.Name = "txtSoLg";
            this.txtSoLg.Size = new System.Drawing.Size(122, 30);
            this.txtSoLg.TabIndex = 3;
            this.txtSoLg.TextChanged += new System.EventHandler(this.txtSoLg_TextChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhTien.Location = new System.Drawing.Point(818, 78);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(228, 30);
            this.txtThanhTien.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(701, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 25);
            this.label12.TabIndex = 58;
            this.label12.Text = "Thành tiền:";
            // 
            // cboMasp
            // 
            this.cboMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMasp.FormattingEnabled = true;
            this.cboMasp.Location = new System.Drawing.Point(242, 30);
            this.cboMasp.Name = "cboMasp";
            this.cboMasp.Size = new System.Drawing.Size(164, 33);
            this.cboMasp.TabIndex = 0;
            this.cboMasp.SelectedValueChanged += new System.EventHandler(this.cboMasp_SelectedValueChanged);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(242, 81);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(164, 30);
            this.txtGia.TabIndex = 1;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(146, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "Giá nhập:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(455, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "Số lượng:";
            // 
            // txtTensp
            // 
            this.txtTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTensp.Location = new System.Drawing.Point(557, 30);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.ReadOnly = true;
            this.txtTensp.Size = new System.Drawing.Size(489, 30);
            this.txtTensp.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(455, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 25);
            this.label15.TabIndex = 53;
            this.label15.Text = "Tên SP:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(146, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 25);
            this.label16.TabIndex = 52;
            this.label16.Text = "Mã SP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1199, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.cboMaDL);
            this.panel2.Controls.Add(this.dateNgayNhap);
            this.panel2.Controls.Add(this.txtDc);
            this.panel2.Controls.Add(this.txtSdt);
            this.panel2.Controls.Add(this.txtTendl);
            this.panel2.Controls.Add(this.txtMaHDN);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 215);
            this.panel2.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Image = global::QLBanHang.Properties.Resources.search;
            this.btnTim.Location = new System.Drawing.Point(533, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(63, 54);
            this.btnTim.TabIndex = 2;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboMaDL
            // 
            this.cboMaDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMaDL.FormattingEnabled = true;
            this.cboMaDL.Location = new System.Drawing.Point(757, 28);
            this.cboMaDL.Name = "cboMaDL";
            this.cboMaDL.Size = new System.Drawing.Size(390, 33);
            this.cboMaDL.TabIndex = 3;
            this.cboMaDL.SelectedValueChanged += new System.EventHandler(this.cboMaDL_SelectedValueChanged);
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNhap.Location = new System.Drawing.Point(269, 76);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(245, 30);
            this.dateNgayNhap.TabIndex = 1;
            // 
            // txtDc
            // 
            this.txtDc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDc.Location = new System.Drawing.Point(757, 156);
            this.txtDc.Name = "txtDc";
            this.txtDc.ReadOnly = true;
            this.txtDc.Size = new System.Drawing.Size(390, 30);
            this.txtDc.TabIndex = 6;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSdt.Location = new System.Drawing.Point(757, 115);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.ReadOnly = true;
            this.txtSdt.Size = new System.Drawing.Size(390, 30);
            this.txtSdt.TabIndex = 5;
            // 
            // txtTendl
            // 
            this.txtTendl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTendl.Location = new System.Drawing.Point(757, 73);
            this.txtTendl.Name = "txtTendl";
            this.txtTendl.ReadOnly = true;
            this.txtTendl.Size = new System.Drawing.Size(390, 30);
            this.txtTendl.TabIndex = 4;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDN.Location = new System.Drawing.Point(269, 28);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(245, 30);
            this.txtMaHDN.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(146, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ngày nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(672, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(672, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "SDT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(672, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tên ĐL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(672, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã ĐL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(146, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã HĐN:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 794);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHoaDonNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDonNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoLg;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMasp;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboMaDL;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.TextBox txtDc;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTendl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnThoatHDX;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnInHDX;
        private System.Windows.Forms.Button btnLuuHDX;
        private System.Windows.Forms.Button btnHuyHDX;
        private System.Windows.Forms.Button btnTim;
        public System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}