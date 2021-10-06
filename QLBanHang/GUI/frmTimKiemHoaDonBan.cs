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
    public partial class frmTimKiemHoaDonBan : Form
    {
        HoaDonBanBUS hdbbus = new HoaDonBanBUS();
        Regex regex = new Regex("[0-9]");
        public frmTimKiemHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmTimKiemHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmTimKiemHoaDonBan_Load(object sender, EventArgs e)
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
            string mahd=txtMaHD.Text;
            int thang= txtThang.Text=="" ? 0:int.Parse(txtThang.Text);
            int nam = txtNam.Text == "" ? 0: int.Parse(txtNam.Text);
            string manv = txtMaNV.Text;
            string tenkhach = txtTenKhach.Text;
            double tien = txtTongTien.Text == "" ? -1: double.Parse(txtTongTien.Text);

            if ((txtMaHD.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMaNV.Text == "") && (txtTenKhach.Text == "") &&
               (txtTongTien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaHD.Text != "" && (txtThang.Text == "") && (txtNam.Text == "") && (txtMaNV.Text == "") && (txtTenKhach.Text == "") && (txtTongTien.Text == ""))
            {
                dgvTimKiem.DataSource = hdbbus.FindtheoMa(mahd);
                LoadDataGridView1();
            }
            else
            if ((txtMaHD.Text == "") && (txtThang.Text != "") && (txtNam.Text != "") &&
               (txtMaNV.Text == "") && (txtTenKhach.Text == "") &&
               (txtTongTien.Text == ""))
            {
                
                dgvTimKiem.DataSource = hdbbus.FindtheoThangvaNam(thang, nam);
                LoadDataGridView2();
            }
            else
            if ((txtMaHD.Text == "") && (txtThang.Text == "") && (txtNam.Text != "") &&
               (txtMaNV.Text == "") && (txtTenKhach.Text == "") &&
               (txtTongTien.Text == ""))
            {
                dgvTimKiem.DataSource = hdbbus.FindtheoNam(nam);
                LoadDataGridView3();
            }
            else
            if ((txtMaHD.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMaNV.Text != "") && (txtTenKhach.Text == "") &&
               (txtTongTien.Text == ""))
            {
                dgvTimKiem.DataSource = hdbbus.FindtheoMaNV(manv);
                LoadDataGridView4();
            }
            else
            if ((txtMaHD.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMaNV.Text == "") && (txtTenKhach.Text != "") &&
               (txtTongTien.Text == ""))
            {
                dgvTimKiem.DataSource = hdbbus.FindtheoTenkhach(tenkhach);
                LoadDataGridView5();
            }
            else
            if ((txtMaHD.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMaNV.Text == "") && (txtTenKhach.Text == "") &&
               (txtTongTien.Text != ""))
            {
                dgvTimKiem.DataSource = hdbbus.FindtheoTien(tien);
                LoadDataGridView6();
            }
            else
            if ((txtMaHD.Text != "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMaNV.Text == "") && (txtTenKhach.Text == "") &&
               (txtTongTien.Text != ""))
            {
                dgvTimKiem.DataSource = hdbbus.FindtheoMahdvaTien(mahd, tien);
                LoadDataGridView7();
            }
            else
            if ((txtMaHD.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMaNV.Text != "") && (txtTenKhach.Text == "") &&
               (txtTongTien.Text != ""))
            {
                dgvTimKiem.DataSource = hdbbus.FindtheoManvvaTien(manv, tien);
                LoadDataGridView8();
            }
            else
            if ((txtMaHD.Text != "") && (txtThang.Text != "") && (txtNam.Text != "") &&
               (txtMaNV.Text == "") && (txtTenKhach.Text == "") &&
               (txtTongTien.Text == ""))
            {
                dgvTimKiem.DataSource = hdbbus.FindMahdvaThangNam(mahd, thang, nam);
                LoadDataGridView9();
            }

            if (dgvTimKiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int banGhi = dgvTimKiem.Rows.Count;
                MessageBox.Show("Có " + banGhi + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void LoadDataGridView1()
        {
            string mahd = txtMaHD.Text;
            dgvTimKiem.DataSource = hdbbus.FindtheoMa(mahd);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView2()
        {
            int thang = int.Parse(txtThang.Text);
            int nam = int.Parse(txtNam.Text);
            dgvTimKiem.DataSource = hdbbus.FindtheoThangvaNam(thang, nam);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView3()
        {
            int nam = int.Parse(txtNam.Text);
            dgvTimKiem.DataSource = hdbbus.FindtheoNam(nam);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView4()
        {
            string manv = txtMaNV.Text;
            dgvTimKiem.DataSource = hdbbus.FindtheoMaNV(manv);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView5()
        {
            string tenkhach = txtTenKhach.Text;
            dgvTimKiem.DataSource = hdbbus.FindtheoTenkhach(tenkhach);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView6()
        {
            double tien = double.Parse(txtTongTien.Text);
            dgvTimKiem.DataSource = hdbbus.FindtheoTien(tien);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView7()
        {
            string mahd = txtMaHD.Text;
            double tien = double.Parse(txtTongTien.Text);
            dgvTimKiem.DataSource = hdbbus.FindtheoMahdvaTien(mahd, tien);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView8()
        {
            string manv = txtMaNV.Text;
            double tien = double.Parse(txtTongTien.Text);

            dgvTimKiem.DataSource = hdbbus.FindtheoManvvaTien(manv, tien);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

            dgvTimKiem.AllowUserToAddRows = false;
            dgvTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView9()
        {
            string mahd = txtMaHD.Text;
            int thang = int.Parse(txtThang.Text);
            int nam = int.Parse(txtNam.Text);

            dgvTimKiem.DataSource = hdbbus.FindMahdvaThangNam(mahd, thang, nam);

            dgvTimKiem.Columns[0].HeaderText = "Mã HĐB";
            dgvTimKiem.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiem.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiem.Columns[3].HeaderText = "Tên khách";
            dgvTimKiem.Columns[4].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[5].HeaderText = "Địa chỉ";
            dgvTimKiem.Columns[6].HeaderText = "Tổng tiền";

            dgvTimKiem.Columns[0].Width = 70;
            dgvTimKiem.Columns[1].Width = 70;
            dgvTimKiem.Columns[2].Width = 80;
            dgvTimKiem.Columns[3].Width = 150;
            dgvTimKiem.Columns[4].Width = 80;
            dgvTimKiem.Columns[5].Width = 80;
            dgvTimKiem.Columns[6].Width = 80;

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
                frmHoaDonBan frm = new frmHoaDonBan();
                frm.txtMaHDBan.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {
            if (txtThang.Text.Trim() != "")
            {

                if (!regex.IsMatch(txtThang.Text) || txtThang.Text.Length > regex.Matches(txtThang.Text).Count||int.Parse(txtThang.Text)>12)
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
