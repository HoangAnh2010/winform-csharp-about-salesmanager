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
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace QLBanHang.GUI
{
    public partial class frmDangKyTaiKhoan : Form
    {
        DangNhapBUS dnbus = new DangNhapBUS();
        Regex regexTendn = new Regex("^[A-Za-z]+$");
        Regex regexMatKhau = new Regex("[0-9]");
        Regex regexChucVu = new Regex("^[A-Za-z À-Ỹà-ỹ]+$");
        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
        }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                btnDangKy.Enabled = false;
            }
            else
            {
                if (!regexTendn.IsMatch(txtTenDangNhap.Text))
                {
                    errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không có dấu và không chứa các kí tự đặc biệt!");
                    btnDangKy.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnDangKy.Enabled = true;
                }
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
                btnDangKy.Enabled = false;
            }
            else
            {
                if (!regexMatKhau.IsMatch(txtMatKhau.Text)||txtMatKhau.Text.Length>regexMatKhau.Matches(txtMatKhau.Text).Count)
                {
                    errorProvider1.SetError(txtMatKhau, "Mật khẩu chỉ chứa các kí tự số!");
                    btnDangKy.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnDangKy.Enabled = true;
                }
            }
        }

        private void txtChucvu_TextChanged(object sender, EventArgs e)
        {
            if (txtChucvu.Text.Trim() == "")
            {
                errorProvider1.SetError(txtChucvu, "Chức vụ không được để trống");
                btnDangKy.Enabled = false;
            }
            else
            {
                if (!regexChucVu.IsMatch(txtChucvu.Text))
                {
                    errorProvider1.SetError(txtChucvu, "Chức vụ không được có kí tự đặc biệt");
                    btnDangKy.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnDangKy.Enabled = true;
                }
            }
        }

        private void frmDangKyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tendn = txtTenDangNhap.Text;
            int mk = txtMatKhau.Text.Length > regexMatKhau.Matches(txtMatKhau.Text).Count|| txtMatKhau.Text=="" ? 0: int.Parse(txtMatKhau.Text);
            string chucVu = txtChucvu.Text;
            if (txtTenDangNhap.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (txtChucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChucvu.Focus();
                return;
            }

            if (dnbus.CheckKey(tendn))
            {
                MessageBox.Show("Tên đăng nhập này đã có, bạn phải nhập tên đăng nhập khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }
            TaiKhoan tk = new TaiKhoan(tendn, mk, chucVu);

            dnbus.SignUp(tk);
            MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue();
        }
        private void ResetValue()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtChucvu.Text = "";
        }

        private void btnPWShow_Click(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }
    }
}
