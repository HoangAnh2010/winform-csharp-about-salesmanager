using QLBanHang.BUS;
using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.GUI
{
    public partial class frmDaiLy : Form
    {
        DaiLyBUS dlbus = new DaiLyBUS();
        Regex regexTen = new Regex("^[A-Za-z À-Ỹà-ỹ]+$");
        Regex regexDc = new Regex("[a-zA-Z0-9-\\/à-ỹÀ-Ỹ]+$");
        Regex regexma = new Regex("[d][l][0-9]");
        Regex regexSdt = new Regex("[0-9]");
        public frmDaiLy()
        {
            InitializeComponent();
        }

        private void txtMaDL_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDL.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaDL, "Mã đại lý không được để trống");
                btnLuuDL.Enabled = false;
            }
            else
            {
                if (!regexma.IsMatch(txtMaDL.Text) || txtMaDL.Text.Trim().Length > 10)
                {
                    errorProvider1.SetError(txtMaDL, "Mã đại lý bắt đầu bằng dl và có độ rộng nhỏ hơn hoặc bằng 10 kí tự");
                    btnLuuDL.Enabled = false;
                    
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuDL.Enabled = true;
                }
            }
        }

        private void txtHoTenDL_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTenDL.Text.Trim() == "")
            {
                errorProvider1.SetError(txtHoTenDL, "Tên đại lý không được để trống");
                btnLuuDL.Enabled = false;
                btnSuaDL.Enabled = false;
            }
            else
            {
                if (!regexTen.IsMatch(txtHoTenDL.Text))
                {
                    errorProvider1.SetError(txtHoTenDL, "Tên đại lý không được chứa chữ số và kí tự đặc biệt");
                    btnLuuDL.Enabled = false;
                    btnSuaDL.Enabled = false; 
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuDL.Enabled = true;
                    btnSuaDL.Enabled = true;
                }
            }
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            if (txtSdt.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSdt, "Số điện thoại đại lý không được để trống");
                btnLuuDL.Enabled = false;
                btnSuaDL.Enabled = false;
            }
            else
            {
                if (!regexSdt.IsMatch(txtSdt.Text)||txtSdt.Text.Trim().Length>10)
                {
                    errorProvider1.SetError(txtSdt, "Số điện thoại gồm 10 số từ 0 đến 9 ");
                    btnLuuDL.Enabled = false;
                    btnSuaDL.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuDL.Enabled = true;
                    btnSuaDL.Enabled = true;
                }
            }
        }

        private void txtDiaChiDL_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChiDL.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDiaChiDL, "Địa chỉ đại lý không được để trống");
                btnLuuDL.Enabled = false;
                btnSuaDL.Enabled = false;
            }
            else
            {
                if (!regexDc.IsMatch(txtDiaChiDL.Text))
                {
                    errorProvider1.SetError(txtDiaChiDL, "Địa chỉ đại lý không được chứa kí tự đặc biệt");
                    btnLuuDL.Enabled = false;
                    btnSuaDL.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuDL.Enabled = true;
                    btnSuaDL.Enabled = true;
                }
            }
        }

        private void frmDaiLy_Load(object sender, EventArgs e)
        {
            btnLuuDL.Enabled = false;
            btnSuaDL.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            dgvDaiLy.DataSource = dlbus.GetDataToTable(); //Nguồn dữ liệu  

            dgvDaiLy.Columns[0].HeaderText = "Mã đại lý";
            dgvDaiLy.Columns[1].HeaderText = "Tên đại lý";
            dgvDaiLy.Columns[2].HeaderText = "Số điện thoại";
            dgvDaiLy.Columns[3].HeaderText = "Địa chỉ";

            dgvDaiLy.Columns[0].Width = 50;
            dgvDaiLy.Columns[1].Width = 200;
            dgvDaiLy.Columns[2].Width = 100;
            dgvDaiLy.Columns[3].Width = 250;

            dgvDaiLy.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvDaiLy.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void frmDaiLy_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoatDL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDaiLy_Click(object sender, EventArgs e)
        {
            txtMaDL.Text = dgvDaiLy.CurrentRow.Cells["MaDL"].Value.ToString();
            txtHoTenDL.Text = dgvDaiLy.CurrentRow.Cells["TenDL"].Value.ToString();
            txtSdt.Text = dgvDaiLy.CurrentRow.Cells["Sdt"].Value.ToString();
            txtDiaChiDL.Text = dgvDaiLy.CurrentRow.Cells["DiaChi"].Value.ToString();

            btnLuuDL.Enabled = false;
            btnSuaDL.Enabled = true;
            btnXoaDL.Enabled = true;
        }

        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            string ma = txtMaDL.Text;
            if (txtMaDL.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dlbus.DeleteDaiLy(ma);
                LoadDataGridView();
                if (dgvDaiLy.Rows.Count > 1)
                {
                    dgvDaiLy.CurrentCell = dgvDaiLy.Rows[dgvDaiLy.Rows.Count - 1].Cells[0];
                }
                ResetValue();
            }
        }

        private void btnThemDL_Click(object sender, EventArgs e)
        {
            btnSuaDL.Enabled = false;
            btnXoaDL.Enabled = false;
            btnLuuDL.Enabled = true;
            btnThemDL.Enabled = false;
            ResetValue();
            txtMaDL.Enabled = true;
            txtMaDL.Focus();
        }
        private void ResetValue()
        {
            txtMaDL.Text = "";
            txtHoTenDL.Text = "";
            txtSdt.Text = "";
            txtDiaChiDL.Text = "";
        }

        private void btnLuuDL_Click(object sender, EventArgs e)
        {
            string ma = txtMaDL.Text;
            string ten = txtHoTenDL.Text;
            string sdt = txtSdt.Text;
            string diachi = txtDiaChiDL.Text;
            if (txtMaDL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đại lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDL.Focus();
                return;
            }
            if (txtHoTenDL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đại lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenDL.Focus();
                return;
            }
            if (txtDiaChiDL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiDL.Focus();
                return;
            }
            if (txtSdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }
            if (txtSdt.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }

            if (dlbus.CheckKey(ma))
            {
                MessageBox.Show("Mã đại lý này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDL.Focus();
                txtMaDL.Text = "";
                return;
            }
            DaiLy dl = new DaiLy(ma, ten, sdt, diachi);
            dlbus.SaveDL(dl);
            LoadDataGridView();
            if (dgvDaiLy.Rows.Count > 1)
            {
                dgvDaiLy.CurrentCell = dgvDaiLy.Rows[dgvDaiLy.Rows.Count - 1].Cells[0];
            }
            ResetValue();
            btnXoaDL.Enabled = true;
            btnThemDL.Enabled = true;
            btnSuaDL.Enabled = true;
            txtMaDL.Enabled = false;
        }

        private void btnSuaDL_Click(object sender, EventArgs e)
        {
            string ma = txtMaDL.Text;
            string ten = txtHoTenDL.Text;
            string sdt = txtSdt.Text;
            string diachi = txtDiaChiDL.Text;
            if (dgvDaiLy.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaDL.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtHoTenDL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đại lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenDL.Focus();
                return;
            }
            if (txtDiaChiDL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiDL.Focus();
                return;
            }

            if (txtSdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }
            if (txtSdt.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }

            DaiLy dl = new DaiLy(ma, ten, sdt, diachi);
            dlbus.UpdateDL(ma, dl);
            LoadDataGridView();
            if (dgvDaiLy.Rows.Count > 1)
            {
                dgvDaiLy.CurrentCell = dgvDaiLy.Rows[dgvDaiLy.Rows.Count - 1].Cells[0];
            }
            ResetValue();
        }
    }
}
