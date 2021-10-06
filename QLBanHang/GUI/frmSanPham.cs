using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLBanHang.DTO;
using QLBanHang.BUS;
using System.Globalization;

namespace QLBanHang.GUI
{
    public partial class frmSanPham : Form
    {
        SanPhamBUS spbus = new SanPhamBUS();
        Regex regexTen = new Regex("^[A-Za-z À-Ỹà-ỹ]+$");
        Regex regexMa = new Regex("[s][p][0-9]");
        Regex regexSolg = new Regex("[0-9]");
        Regex regexDongia = new Regex("[0-9]");
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoatSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm không được để trống");
                btnLuuSP.Enabled = false;
                btnSuaSP.Enabled = false;
            }
            else
            {
                if (!regexMa.IsMatch(txtMaSP.Text) || txtMaSP.Text.Trim().Length > 10)
                {
                    errorProvider1.SetError(txtMaSP, "Mã sản phẩm bắt đầu bằng sp và có độ rộng nhỏ hơn 10 kí tự");
                    btnLuuSP.Enabled = false;
                    btnSuaSP.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuSP.Enabled = true;
                    btnSuaSP.Enabled = true;
                }
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được để trống");
                btnLuuSP.Enabled = false;
                btnSuaSP.Enabled = false;
            }
            else
            {
                if (!regexTen.IsMatch(txtTenSP.Text))
                {
                    errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được có kí tự đặc biệt");
                    btnLuuSP.Enabled = false;
                    btnSuaSP.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuSP.Enabled = true;
                    btnSuaSP.Enabled = true;
                }
            }
        }
        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoluong.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSoluong, "Số lượng không được để trống");
                btnLuuSP.Enabled = false;
                btnSuaSP.Enabled = false;
            }
            else
            {
                if (!regexSolg.IsMatch(txtSoluong.Text) || txtSoluong.Text.Length > regexSolg.Matches(txtSoluong.Text).Count)
                {
                    errorProvider1.SetError(txtSoluong, "Số lượng là số nguyên dương");
                    btnLuuSP.Enabled = false;
                    btnSuaSP.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuSP.Enabled = true;
                    btnSuaSP.Enabled = true;
                }
            }
        }
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {            
            if (txtDonGia.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtDonGia, "Đơn giá không được để trống");
                btnLuuSP.Enabled = false;
                btnSuaSP.Enabled = false;
            }
            else
            {
                if (!regexDongia.IsMatch(txtDonGia.Text) || txtDonGia.Text.Length > regexDongia.Matches(txtDonGia.Text).Count)
                {
                    errorProvider1.SetError(txtDonGia, "Đơn giá là số nguyên dương");
                    btnLuuSP.Enabled = false;
                    btnSuaSP.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuSP.Enabled = true;
                    btnSuaSP.Enabled = true;
                }
            }
        }

        private void cboMaLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            string maloai = cboMaLoai.SelectedValue.ToString();
            txtTenLoai.Text = spbus.GetTenLoaitheoMaLoai(maloai);
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ResetValue();
            btnLuuSP.Enabled = false;
            btnSuaSP.Enabled = false;
            btnTim.Enabled = true;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            //txtMaSP.Enabled = false;
            dgvSanPham.DataSource = spbus.GetDataToTable(); //Nguồn dữ liệu  

            cboMaLoai.DataSource = spbus.GetMaLoai();
            cboMaLoai.ValueMember = "MaLoai";
            cboMaLoai.DisplayMember = "TenLoai";

            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Mã loại";
            dgvSanPham.Columns[3].HeaderText = "Ngày sản xuất";
            dgvSanPham.Columns[4].HeaderText = "Hạn sử dụng";
            dgvSanPham.Columns[5].HeaderText = "Số lượng";
            dgvSanPham.Columns[6].HeaderText = "Đơn giá";

            dgvSanPham.Columns[0].Width = 50;
            dgvSanPham.Columns[1].Width = 250;
            dgvSanPham.Columns[2].Width = 70;
            dgvSanPham.Columns[3].Width = 120;
            dgvSanPham.Columns[4].Width = 120;
            dgvSanPham.Columns[5].Width = 50;
            dgvSanPham.Columns[6].Width = 70;

            dgvSanPham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSP.Text = dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgvSanPham.CurrentRow.Cells["TenSP"].Value.ToString();
            cboMaLoai.Text = dgvSanPham.CurrentRow.Cells["MaLoai"].Value.ToString();
            string maloai = cboMaLoai.SelectedValue.ToString();
            txtTenLoai.Text = spbus.GetTenLoaitheoMaLoai(maloai);
            dateNsx.Text = dgvSanPham.CurrentRow.Cells["Nsx"].Value.ToString();
            dateHsd.Text = dgvSanPham.CurrentRow.Cells["Hsd"].Value.ToString();
            txtSoluong.Text = dgvSanPham.CurrentRow.Cells["SoLuongCo"].Value.ToString();
            txtDonGia.Text = dgvSanPham.CurrentRow.Cells["DonGia"].Value.ToString();

            //txtMaSP.Enabled = false;
            btnLuuSP.Enabled = false;
            btnSuaSP.Enabled = true;
            btnXoaSP.Enabled = true;
            btnTim.Enabled = true;
        }


        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            if (dgvSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                spbus.DeleteSanPham(ma);
                LoadDataGridView();
                if (dgvSanPham.Rows.Count > 1)
                {
                    dgvSanPham.CurrentCell = dgvSanPham.Rows[dgvSanPham.Rows.Count - 1].Cells[0];
                }
                ResetValue();
            }            
        }
        private void ResetValue()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cboMaLoai.Text = "";
            txtTenLoai.Text = "";
            dateNsx.Text = "";
            dateHsd.Text = "";
            txtSoluong.Text = "0";
            txtDonGia.Text = "0";
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            btnSuaSP.Enabled = false;
            btnXoaSP.Enabled = false;
            btnLuuSP.Enabled = true;
            btnThemSP.Enabled = false;
            ResetValue();
            txtMaSP.Enabled = true;
            txtMaSP.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            string ten = txtTenSP.Text;
            if ((txtMaSP.Text == "") && (txtTenSP.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtMaSP.Text != ""))
            {
                dgvSanPham.DataSource = spbus.FindSanPhamtheoMa(ma);
            }
            if ((txtTenSP.Text != ""))
            {
                dgvSanPham.DataSource = spbus.FindSanPhamtheoTen(ten);
            }
            if ((txtMaSP.Text != "") && (txtTenSP.Text != ""))
            {
                dgvSanPham.DataSource = spbus.FindSanPhamtheoMavaTen(ma, ten);
            }
            if (dgvSanPham.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dgvSanPham.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (txtMaSP.Text != "")
            {
                LoadDataGridView1();
            }
            if (txtTenSP.Text != "")
            {
                LoadDataGridView2();
            }
            if (txtMaSP.Text != "" && txtTenSP.Text != "")
            {
                LoadDataGridView3();

            }
            ResetValue();
        }
        public void LoadDataGridView1()
        {
            string ma = txtMaSP.Text;
            dgvSanPham.DataSource = spbus.FindSanPhamtheoMa(ma); //Nguồn dữ liệu  

            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Mã loại";
            dgvSanPham.Columns[3].HeaderText = "Ngày sản xuất";
            dgvSanPham.Columns[4].HeaderText = "Hạn sử dụng";
            dgvSanPham.Columns[5].HeaderText = "Số lượng";
            dgvSanPham.Columns[6].HeaderText = "Đơn giá";

            dgvSanPham.Columns[0].Width = 50;
            dgvSanPham.Columns[1].Width = 250;
            dgvSanPham.Columns[2].Width = 70;
            dgvSanPham.Columns[3].Width = 120;
            dgvSanPham.Columns[4].Width = 120;
            dgvSanPham.Columns[5].Width = 50;
            dgvSanPham.Columns[6].Width = 70;

            dgvSanPham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        public void LoadDataGridView2()
        {
            string ten = txtTenSP.Text;
            dgvSanPham.DataSource = spbus.FindSanPhamtheoTen(ten); //Nguồn dữ liệu  

            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Mã loại";
            dgvSanPham.Columns[3].HeaderText = "Ngày sản xuất";
            dgvSanPham.Columns[4].HeaderText = "Hạn sử dụng";
            dgvSanPham.Columns[5].HeaderText = "Số lượng";
            dgvSanPham.Columns[6].HeaderText = "Đơn giá";

            dgvSanPham.Columns[0].Width = 50;
            dgvSanPham.Columns[1].Width = 250;
            dgvSanPham.Columns[2].Width = 70;
            dgvSanPham.Columns[3].Width = 120;
            dgvSanPham.Columns[4].Width = 120;
            dgvSanPham.Columns[5].Width = 50;
            dgvSanPham.Columns[6].Width = 70;

            dgvSanPham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        public void LoadDataGridView3()
        {
            string ma = txtMaSP.Text;
            string ten = txtTenSP.Text;
            dgvSanPham.DataSource = spbus.FindSanPhamtheoMavaTen(ma, ten); //Nguồn dữ liệu  

            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Mã loại";
            dgvSanPham.Columns[3].HeaderText = "Ngày sản xuất";
            dgvSanPham.Columns[4].HeaderText = "Hạn sử dụng";
            dgvSanPham.Columns[5].HeaderText = "Số lượng";
            dgvSanPham.Columns[6].HeaderText = "Đơn giá";

            dgvSanPham.Columns[0].Width = 50;
            dgvSanPham.Columns[1].Width = 250;
            dgvSanPham.Columns[2].Width = 70;
            dgvSanPham.Columns[3].Width = 120;
            dgvSanPham.Columns[4].Width = 120;
            dgvSanPham.Columns[5].Width = 50;
            dgvSanPham.Columns[6].Width = 70;

            dgvSanPham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            string maloai = cboMaLoai.Text;
            DateTime nsx = dateNsx.Value;
            DateTime hsd = dateHsd.Value;
            int solg = txtSoluong.Text.Length > regexSolg.Matches(txtSoluong.Text).Count ? 0 : int.Parse(txtSoluong.Text);
            double dongia =  txtDonGia.Text.Length > regexDongia.Matches(txtDonGia.Text).Count ? 0 :  double.Parse(txtDonGia.Text);
            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            if (cboMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaLoai.Focus();
                return;
            }
            if (dateNsx.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sản xuất phải trước hoặc là ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNsx.Focus();
                return;
            }
            if (dateNsx.Value >= dateHsd.Value)
            {
                MessageBox.Show("Hạn sử dụng phải sau ngày sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateHsd.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0|| txtSoluong.Text.Length > regexSolg.Matches(txtSoluong.Text).Count)
            {
                MessageBox.Show("Số lượng là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0|| txtDonGia.Text.Length > regexDongia.Matches(txtDonGia.Text).Count)
            {
                MessageBox.Show("Đơn giá là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (spbus.CheckKey(masp))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                txtMaSP.Text = "";
                return;
            }
            SanPham sp = new SanPham(masp, tensp, maloai, nsx, hsd, solg, dongia);
            spbus.SaveSP(sp);
            LoadDataGridView();
            if (dgvSanPham.Rows.Count > 1)
            {
                dgvSanPham.CurrentCell = dgvSanPham.Rows[dgvSanPham.Rows.Count - 1].Cells[0];
            }
            ResetValue();
            btnXoaSP.Enabled = true;
            btnThemSP.Enabled = true;
            btnSuaSP.Enabled = true;
            txtMaSP.Enabled = false;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            string maloai = cboMaLoai.Text;
            DateTime nsx = dateNsx.Value;
            DateTime hsd = dateHsd.Value;
            int solg = txtSoluong.Text.Length > regexSolg.Matches(txtSoluong.Text).Count ? 0 : int.Parse(txtSoluong.Text);
            double dongia = txtDonGia.Text.Length > regexDongia.Matches(txtDonGia.Text).Count ? 0 : double.Parse(txtDonGia.Text);
            if (dgvSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            if (cboMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaLoai.Focus();
                return;
            }
            if (dateNsx.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sản xuất phải trước hoặc là ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNsx.Focus();
                return;
            }
            if (dateNsx.Value >= dateHsd.Value)
            {
                MessageBox.Show("Hạn sử dụng phải sau ngày sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateHsd.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0 || txtSoluong.Text.Length > regexSolg.Matches(txtSoluong.Text).Count)
            {
                MessageBox.Show("Số lượng là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0 || txtDonGia.Text.Length > regexDongia.Matches(txtDonGia.Text).Count)
            {
                MessageBox.Show("Đơn giá là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            SanPham sp = new SanPham(masp, tensp, maloai, nsx, hsd, solg, dongia);
            spbus.UpdateSP(masp, sp);
            LoadDataGridView();
            if (dgvSanPham.Rows.Count > 1)
            {
                dgvSanPham.CurrentCell = dgvSanPham.Rows[dgvSanPham.Rows.Count - 1].Cells[0];
            }
            ResetValue();
        }

        
    }
}
