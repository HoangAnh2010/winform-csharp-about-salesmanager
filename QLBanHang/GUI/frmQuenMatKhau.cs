using QLBanHang.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.DTO;
using System.Text.RegularExpressions;

namespace QLBanHang.GUI
{
    public partial class frmQuenMatKhau : Form
    {
        DangNhapBUS dnbus = new DangNhapBUS();
        Regex regexTendn = new Regex("^[A-Za-z]+$");
        Regex regexMatKhau = new Regex("[0-9]");
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnPWShowAgain_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.UseSystemPasswordChar = false;
        }

        private void btnReWrite_Click(object sender, EventArgs e)
        {
            txtNhapLaiMK.UseSystemPasswordChar = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tendn = txtTenDangNhap.Text;
            int mkm = txtMatKhauMoi.Text.Length > regexMatKhau.Matches(txtMatKhauMoi.Text).Count || txtMatKhauMoi.Text == "" ? 0 : int.Parse(txtMatKhauMoi.Text);
            int mkNhaplai = txtNhapLaiMK.Text.Length > regexMatKhau.Matches(txtNhapLaiMK.Text).Count || txtNhapLaiMK.Text == "" ? 0 : int.Parse(txtNhapLaiMK.Text);
            if (!dnbus.dangNhap(tendn))
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!");
                return;
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

        private void btnThoatTK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
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
