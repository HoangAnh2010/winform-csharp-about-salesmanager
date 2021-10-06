using QLBanHang.BUS;
using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.GUI
{
    public partial class frmLoaiSanPham : Form
    {
        LoaiSanPhamBUS lspbus = new LoaiSanPhamBUS();        
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            dgvLoaiSP.DataSource = lspbus.GetDataToTable(); //Nguồn dữ liệu            
            dgvLoaiSP.Columns[0].HeaderText = "Mã loại sản phẩm";
            dgvLoaiSP.Columns[1].HeaderText = "Tên loại sản phẩm";
            dgvLoaiSP.Columns[0].Width = 150;
            dgvLoaiSP.Columns[1].Width = 200;
            dgvLoaiSP.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvLoaiSP.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvLoaiSP_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }
            txtMa.Text = dgvLoaiSP.CurrentRow.Cells["maLoai"].Value.ToString();
            txtTen.Text = dgvLoaiSP.CurrentRow.Cells["tenLoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMa.Enabled = true; //cho phép nhập mới
            txtMa.Focus();
        }
        private void ResetValue()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            if (txtMa.Text.Trim().Length == 0) //Nếu chưa nhập mã loại
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0) //Nếu chưa nhập tên loại
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            
            if (lspbus.CheckKey(ma))//Kiểm tra mã trùng
            {
                MessageBox.Show("Mã loại này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                return;
            }
            LoaiSanPham lsp = new LoaiSanPham(ma, ten);

            lspbus.SaveLoaiSP(lsp);

            LoadDataGridView(); //Nạp lại DataGridView
            if (dgvLoaiSP.Rows.Count > 1)
            {
                dgvLoaiSP.CurrentCell = dgvLoaiSP.Rows[dgvLoaiSP.Rows.Count - 1].Cells[0];
            }
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            
            btnSua.Enabled = true;
            
            btnLuu.Enabled = false;
            
            txtMa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            LoaiSanPham lsp = new LoaiSanPham(ma, ten);
            if (dgvLoaiSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMa.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTen.Text.Trim().Length == 0) //Nếu chưa nhập tên loại
            {
                MessageBox.Show("Bạn chưa nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            lspbus.UpdateLoaiSP(ma, lsp);
            LoadDataGridView(); //Nạp lại DataGridView
            if (dgvLoaiSP.Rows.Count > 1)
            {
                dgvLoaiSP.CurrentCell = dgvLoaiSP.Rows[dgvLoaiSP.Rows.Count - 1].Cells[0];
            }
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            if (dgvLoaiSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMa.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lspbus.DeleteLoaiSP(ma);
                LoadDataGridView();
                if (dgvLoaiSP.Rows.Count > 1)
                {
                    dgvLoaiSP.CurrentCell = dgvLoaiSP.Rows[dgvLoaiSP.Rows.Count - 1].Cells[0];
                }
                ResetValue();
            }
        }
    }
}
