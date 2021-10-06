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
    public partial class frmThongTinTaiKhoan : Form
    {
        DangNhapBUS dnbus = new DangNhapBUS();
        Regex regexTendn = new Regex("^[A-Za-z]+$");
        Regex regexMatKhau = new Regex("[0-9]");
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        private void btnPWShow_Click(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void btnPWShowAgain_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.UseSystemPasswordChar = false;
        }

        private void btnReWrite_Click(object sender, EventArgs e)
        {
            txtNhapLaiMK.UseSystemPasswordChar = false;
        }

        private void frmThongTinTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoatTK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tendn = txtTenDangNhap.Text;
            int mk = txtMatKhau.Text.Length > regexMatKhau.Matches(txtMatKhau.Text).Count || txtMatKhau.Text == "" ? 0 : int.Parse(txtMatKhau.Text);
            txtMatKhauMoi.Enabled = true;
            txtNhapLaiMK.Enabled = true;
            btnCapNhat.Enabled = true;
            int mkm = txtMatKhauMoi.Text.Length > regexMatKhau.Matches(txtMatKhauMoi.Text).Count || txtMatKhauMoi.Text == "" ? 0 : int.Parse(txtMatKhauMoi.Text);
            int mkNhaplai = txtNhapLaiMK.Text.Length > regexMatKhau.Matches(txtNhapLaiMK.Text).Count || txtNhapLaiMK.Text == "" ? 0 : int.Parse(txtNhapLaiMK.Text);

            if (!dnbus.dangNhap(tendn, mk))
            {

                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            if (txtMatKhauMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }
            if (txtNhapLaiMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu đã thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapLaiMK.Focus();
                return;
            }
            if (mkm != mkNhaplai)
            {
                MessageBox.Show("Bạn nhập lại mật khẩu chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapLaiMK.Focus();
                return;
            }

            TaiKhoan tk = new TaiKhoan(tendn, mkm);
            dnbus.UpdatePassword(tendn, tk);
            MessageBox.Show("Đổi mật khẩu thành công!");
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                btnCapNhat.Enabled = false;
            }
            else
            {
                if (!regexTendn.IsMatch(txtTenDangNhap.Text))
                {
                    errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không có dấu và không chứa các kí tự đặc biệt!");
                    btnCapNhat.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnCapNhat.Enabled = true;
                }
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
                btnCapNhat.Enabled = false;
            }
            else
            {
                if (!regexMatKhau.IsMatch(txtMatKhau.Text) || txtMatKhau.Text.Length > regexMatKhau.Matches(txtMatKhau.Text).Count)
                {
                    errorProvider1.SetError(txtMatKhau, "Mật khẩu chỉ chứa các kí tự số!");
                    btnCapNhat.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnCapNhat.Enabled = true;
                }
            }
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMatKhauMoi, "Vui lòng nhập mật khẩu!");
                btnCapNhat.Enabled = false;
            }
            else
            {
                if (!regexMatKhau.IsMatch(txtMatKhauMoi.Text) || txtMatKhauMoi.Text.Length > regexMatKhau.Matches(txtMatKhauMoi.Text).Count)
                {
                    errorProvider1.SetError(txtMatKhauMoi, "Mật khẩu chỉ chứa các kí tự số!");
                    btnCapNhat.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnCapNhat.Enabled = true;
                }
            }
        }

        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNhapLaiMK, "Vui lòng nhập mật khẩu!");
                btnCapNhat.Enabled = false;
            }
            else
            {
                if (!regexMatKhau.IsMatch(txtNhapLaiMK.Text) || txtNhapLaiMK.Text.Length > regexMatKhau.Matches(txtNhapLaiMK.Text).Count)
                {
                    errorProvider1.SetError(txtNhapLaiMK, "Mật khẩu chỉ chứa các kí tự số!");
                    btnCapNhat.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnCapNhat.Enabled = true;
                }
            }
        }
    }
}
