using QLBanHang.BUS;
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
    public partial class frmDangNhap : Form
    {
        DangNhapBUS dnbus = new DangNhapBUS();
        Regex regexTendn = new Regex("^[A-Za-z]+$");
        Regex regexMatKhau = new Regex("[0-9]");
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống");
                btnDangNhap.Enabled = false;
            }
            else
            {
                if (!regexTendn.IsMatch(txtTenDangNhap.Text))
                {
                    errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không có dấu và không chứa các kí tự đặc biệt");
                    btnDangNhap.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnDangNhap.Enabled = true;
                }
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
                btnDangNhap.Enabled = false;
            }
            else
            {
                if (!regexMatKhau.IsMatch(txtMatKhau.Text))
                {
                    errorProvider1.SetError(txtMatKhau, "Mật khẩu chỉ chứa các kí tự số");
                    btnDangNhap.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnDangNhap.Enabled = true;
                }
            }
        }
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát chương trình?", "Thông báo",
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        int click = 0;
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text;
            int mk = txtMatKhau.Text.Length > regexMatKhau.Matches(txtMatKhau.Text).Count || txtMatKhau.Text == "" ? 0 : int.Parse(txtMatKhau.Text);

            if (dnbus.dangNhap(tenDN, mk) && dnbus.LoginwithBoss(tenDN))
            {
                MDIGiaoDienBoss f = new MDIGiaoDienBoss();
                this.Hide();
                f.ShowDialog();
                this.Show();                
            }
            else if (dnbus.dangNhap(tenDN, mk) && dnbus.LoginwithStaff(tenDN))
            {
                MDIGiaoDienStaff f = new MDIGiaoDienStaff();
                this.Hide();
                f.ShowDialog();
                this.Show();                
            }
            else
            {
                click++;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                if (click == 2 || click == 1)
                {
                    MessageBox.Show("Bạn còn " + (3 - click) + " lần đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTenDangNhap.Focus();
                }
                else if(click==3)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnDangNhap.Enabled = false;
                    frmKhoaTK f = new frmKhoaTK();
                    f.ShowDialog();
                    this.Hide();
                }                
            }        
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmDangKyTaiKhoan f = new frmDangKyTaiKhoan();
            f.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string tendn;
            tendn = txtTenDangNhap.Text;
            frmQuenMatKhau f = new frmQuenMatKhau();
            f.txtTenDangNhap.Text = tendn;
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();

        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
        }
    }
}
