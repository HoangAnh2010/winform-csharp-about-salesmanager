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
using QLBanHang.BUS;
using QLBanHang.DTO;

namespace QLBanHang.GUI
{
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nvbus = new NhanVienBUS();
        Regex regexTen = new Regex("^[A-Za-z À-Ỹà-ỹ]+$");
        Regex regexDc = new Regex("[a-zA-Z0-9-\\/à-ỹÀ-Ỹ]+$");
        Regex regexma = new Regex("[n][v][0-9]");
        Regex regexSdt = new Regex("[0-9]");
        public frmNhanVien()
        {
            InitializeComponent();
        }       

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaNV, "Mã nhân viên không được để trống");
                btnLuuNV.Enabled = false;
                btnSuaNV.Enabled = false;
            }
            else
            {
                if (!regexma.IsMatch(txtMaNV.Text) || txtMaNV.Text.Trim().Length > 10)
                {
                    errorProvider1.SetError(txtMaNV, "Mã nhân viên bắt đầu bằng nv và có độ rộng nhỏ hơn 10 kí tự");
                    btnLuuNV.Enabled = false;
                    btnSuaNV.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuNV.Enabled = true;
                    btnSuaNV.Enabled = true;
                }
            }
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text.Trim() == "")
            {
                errorProvider1.SetError(txtHoTenNV, "Tên nhân viên không được để trống");
                btnLuuNV.Enabled = false;
                btnSuaNV.Enabled = false;
            }
            else
            {
                if (!regexTen.IsMatch(txtHoTenNV.Text))
                {
                    errorProvider1.SetError(txtHoTenNV, "Tên nhân viên không được có số và kí tự đặc biệt");
                    btnLuuNV.Enabled = false;
                    btnSuaNV.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuNV.Enabled = true;
                    btnSuaNV.Enabled = true;
                }
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại nhân viên không được để trống");
                btnLuuNV.Enabled = false;
                btnSuaNV.Enabled = false;
            }
            else
            {
                if (!regexSdt.IsMatch(txtSDT.Text)||txtSDT.Text.Length!=10)
                {
                    errorProvider1.SetError(txtSDT, "Số điện thoại gồm 10 số từ 0 đến 9");
                    btnLuuNV.Enabled = false;
                    btnSuaNV.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuNV.Enabled = true;
                    btnSuaNV.Enabled = true;
                }
            }
        }

        private void txtDiaChiNV_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChiNV.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDiaChiNV, "Địa chỉ nhân viên không được để trống");
                btnLuuNV.Enabled = false;
                btnSuaNV.Enabled = false;
            }
            else
            {
                if (!regexDc.IsMatch(txtDiaChiNV.Text))
                {
                    errorProvider1.SetError(txtDiaChiNV, "Địa chỉ nhân viên không được có kí tự đặc biệt");
                    btnLuuNV.Enabled = false;
                    btnSuaNV.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuNV.Enabled = true;
                    btnSuaNV.Enabled = true;
                }
            }
        }
        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnLuuNV.Enabled = false;
            btnSuaNV.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            dgvNhanVien.DataSource = nvbus.GetDataToTable(); //Nguồn dữ liệu  

            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Họ tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText = "Tên đăng nhập";

            dgvNhanVien.Columns[0].Width = 50;
            dgvNhanVien.Columns[1].Width = 110;
            dgvNhanVien.Columns[2].Width = 80;
            dgvNhanVien.Columns[3].Width = 300;
            dgvNhanVien.Columns[4].Width = 50;

            dgvNhanVien.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtHoTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells["Sdt"].Value.ToString();
            txtDiaChiNV.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtTenDN.Text = dgvNhanVien.CurrentRow.Cells["TenDN"].Value.ToString();

            btnLuuNV.Enabled = false;
            btnSuaNV.Enabled = true;
            btnXoaNV.Enabled = true;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnLuuNV.Enabled = true;
            btnThemNV.Enabled = false;
            ResetValue();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }
        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            txtSDT.Text = "";
            txtTenDN.Text = "";
            txtDiaChiNV.Text = "";
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string tennv = txtHoTenNV.Text;
            string tendn = txtTenDN.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChiNV.Text;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtHoTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }
            if (txtDiaChiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtTenDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }
            if (nvbus.CheckKey(ma))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }
            if (!nvbus.CheckTenDN(tendn) )
            {
                MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                txtTenDN.Text = "";
                return;
            }
            if (nvbus.CheckTenDN2(tendn))
            {
                MessageBox.Show("Tên đăng nhập này đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                txtTenDN.Text = "";
                return;
            }
            NhanVien nv = new NhanVien(ma, tennv, sdt, diachi, tendn);
            nvbus.SaveNV(nv);
            LoadDataGridView();
            if (dgvNhanVien.Rows.Count > 1)
            {
                dgvNhanVien.CurrentCell = dgvNhanVien.Rows[dgvNhanVien.Rows.Count - 1].Cells[0];
            }
            ResetValue();
            btnXoaNV.Enabled = true;
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = true;
            txtMaNV.Enabled = false;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                nvbus.DeleteNhanVien(ma);
                LoadDataGridView();
                if (dgvNhanVien.Rows.Count > 1)
                {
                    dgvNhanVien.CurrentCell = dgvNhanVien.Rows[dgvNhanVien.Rows.Count - 1].Cells[0];
                }
                ResetValue();
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string tennv = txtHoTenNV.Text;
            string tendn = txtTenDN.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChiNV.Text;
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtHoTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }
            if (txtDiaChiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiNV.Focus();
                return;
            }

            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtTenDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                return;
            }

            if (nvbus.CheckTenDN(tendn) == false)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                txtTenDN.Text = "";
                return;
            }

            NhanVien nv = new NhanVien(ma, tennv, sdt, diachi, tendn);
            nvbus.UpdateNV(ma, nv);
            LoadDataGridView();
            if (dgvNhanVien.Rows.Count > 1)
            {
                dgvNhanVien.CurrentCell = dgvNhanVien.Rows[dgvNhanVien.Rows.Count - 1].Cells[0];
            }
            ResetValue();
        }
    }
}
