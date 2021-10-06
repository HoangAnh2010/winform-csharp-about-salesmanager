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
    public partial class frmTimKiemHoaDonNhap : Form
    {
        HoaDonNhapBUS hdnbus = new HoaDonNhapBUS();
        Regex regex = new Regex("[0-9]");
        public frmTimKiemHoaDonNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemHoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmTimKiemHoaDonNhap_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKiem.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaHD.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            int thang = txtThang.Text == "" ? 0 : int.Parse(txtThang.Text);
            int nam = txtNam.Text == "" ? 0 : int.Parse(txtNam.Text);
            string tendl = txtTen.Text;
            string dc = txtDc.Text;
            double tien = txtTongTien.Text == "" ? -1 : double.Parse(txtTongTien.Text);

            if ((txtMaHD.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtTen.Text == "") && (txtDc.Text == "") &&
               (txtTongTien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaHD.Text != "" && txtTongTien.Text == "" && txtThang.Text == "" && txtNam.Text == "" && txtTen.Text == "" && txtDc.Text == "")
            {
                dgvTimKiem.DataSource = hdnbus.FindtheoMa(mahd);
                LoadDataGridView1();
            }
            else
            if (txtMaHD.Text == "" && txtTongTien.Text == "" && txtThang.Text != "" && txtNam.Text != "" && txtTen.Text == "" && txtDc.Text == "")
            {
                dgvTimKiem.DataSource = hdnbus.FindtheoThangvaNam(thang, nam);
                LoadDataGridView2();
            }
            else
            if (txtMaHD.Text == "" && txtTongTien.Text == "" && txtThang.Text == "" && txtNam.Text != "" && txtTen.Text == "" && txtDc.Text == "")
            {
                dgvTimKiem.DataSource = hdnbus.FindtheoNam(nam);
                LoadDataGridView3();
            }
            else
            if (txtMaHD.Text == "" && txtTongTien.Text == "" && txtThang.Text == "" && txtNam.Text == "" && txtTen.Text != "" && txtDc.Text == "")
            {
                dgvTimKiem.DataSource = hdnbus.FindtheoTenDL(tendl);
                LoadDataGridView4();
            }
            else
            if (txtMaHD.Text == "" && txtTongTien.Text == "" && txtThang.Text == "" && txtNam.Text == "" && txtTen.Text == "" && txtDc.Text != "")
            {
                dgvTimKiem.DataSource = hdnbus.FindtheoDcDL(dc);
                LoadDataGridView5();
            }
            else
            if (txtMaHD.Text == "" && txtTongTien.Text != "" && txtThang.Text == "" && txtNam.Text == "" && txtTen.Text == "" && txtDc.Text == "")
            {
                dgvTimKiem.DataSource = hdnbus.FindtheoTien(tien);
                LoadDataGridView6();
            }
            else
            if (txtMaHD.Text != "" && txtTongTien.Text != "" && txtThang.Text == "" && txtNam.Text == "" && txtTen.Text == "" && txtDc.Text == "")
            {
                dgvTimKiem.DataSource = hdnbus.FindtheoMahdvaTien(mahd, tien);
                LoadDataGridView7();
            }
            else
            if (txtMaHD.Text == "" && txtTongTien.Text != "" && txtThang.Text == "" && txtNam.Text == "" && txtTen.Text != "" && txtDc.Text == "")
            {
                dgvTimKiem.DataSource = hdnbus.FindtheoTenvaTien(tendl, tien);
                LoadDataGridView8();
            }
            else
            if (txtMaHD.Text != "" && txtTongTien.Text == "" && txtThang.Text != "" && txtNam.Text != "" && txtTen.Text == "" && txtDc.Text == "")
            {
                dgvTimKiem.DataSource = hdnbus.FindMahdvaThangNam(mahd, thang, nam);
                LoadDataGridView9();
            }

            if (dgvTimKiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int banGhi = dgvTimKiem.Rows.Count ;
                MessageBox.Show("Có " + banGhi + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        private void LoadDataGridView1()
        {
            string mahd = txtMaHD.Text;
            dgvTimKiem.DataSource = hdnbus.FindtheoMa(mahd);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView2()
        {
            int thang = int.Parse(txtThang.Text);
            int nam = int.Parse(txtNam.Text);
            dgvTimKiem.DataSource = hdnbus.FindtheoThangvaNam(thang, nam);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView3()
        {
            int nam = int.Parse(txtNam.Text);
            dgvTimKiem.DataSource = hdnbus.FindtheoNam(nam);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView4()
        {
            string tendl = txtTen.Text;
            dgvTimKiem.DataSource = hdnbus.FindtheoTenDL(tendl);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView5()
        {
            string dc = txtDc.Text;
            dgvTimKiem.DataSource = hdnbus.FindtheoDcDL(dc);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView6()
        {
            double tien = double.Parse(txtTongTien.Text);
            dgvTimKiem.DataSource = hdnbus.FindtheoTien(tien);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView7()
        {
            string mahd = txtMaHD.Text;
            double tien = double.Parse(txtTongTien.Text);

            dgvTimKiem.DataSource = hdnbus.FindtheoMahdvaTien(mahd, tien);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView8()
        {
            string tendl = txtTen.Text;
            double tien = double.Parse(txtTongTien.Text);

            dgvTimKiem.DataSource = hdnbus.FindtheoTenvaTien(tendl, tien);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView9()
        {
            string mahd = txtMaHD.Text;
            int thang = int.Parse(txtThang.Text);
            int nam = int.Parse(txtNam.Text);
            dgvTimKiem.DataSource = hdnbus.FindMahdvaThangNam(mahd, thang, nam);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐN";
            dgvTimKiem.Columns[1].HeaderText = "Ngày nhập";
            dgvTimKiem.Columns[2].HeaderText = "Mã đại lý";
            dgvTimKiem.Columns[3].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 100;
            dgvTimKiem.Columns[1].Width = 100;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        //private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        private void dgvTimKiem_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgvTimKiem.CurrentRow.Cells["MaHD"].Value.ToString();
                frmHoaDonNhap frm = new frmHoaDonNhap();
                frm.txtMaHDN.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {
            if (txtThang.Text.Trim() != "")
            {

                if (!regex.IsMatch(txtThang.Text) || txtThang.Text.Length > regex.Matches(txtThang.Text).Count || int.Parse(txtThang.Text) > 12)
                {
                    errorProvider1.SetError(txtThang, "Tháng là số nguyên dương, nằm trong khoảng giá trị từ 1 đến 12");
                    btnTim.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnTim.Enabled = true;
                }
            }
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if (txtNam.Text.Trim() != "")

            {
                if (!regex.IsMatch(txtNam.Text) || txtNam.Text.Length > regex.Matches(txtNam.Text).Count || int.Parse(txtNam.Text) > DateTime.UtcNow.Year)
                {
                    errorProvider1.SetError(txtNam, "Năm là số nguyên dương, có giá trị nhỏ hơn hoặc bằng năm hiện tại");
                    btnTim.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnTim.Enabled = true;
                }
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTongTien.Text.Trim() != "")

            {
                if (!regex.IsMatch(txtTongTien.Text) || txtTongTien.Text.Length > regex.Matches(txtTongTien.Text).Count)
                {
                    errorProvider1.SetError(txtTongTien, "Tổng tiền là số nguyên dương");
                    btnTim.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnTim.Enabled = true;
                }
            }
        }
    }
}
