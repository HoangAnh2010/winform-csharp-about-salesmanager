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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLBanHang.GUI
{
    public partial class frmThongKeDoanhThu : Form
    {
        HoaDonBanBUS hdbbus = new HoaDonBanBUS();
        HoaDonNhapBUS hdnbus = new HoaDonNhapBUS();
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_FormClosing(object sender, FormClosingEventArgs e)
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
        
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvThongke.DataSource = null;
        }
        private void ResetValues()
        {
            checkBan.Checked = false;
            checkNhap.Checked = false;
            rabtnNgay.Checked = false;
            rabtnThang.Checked = false;
            rabtnNam.Checked = false;
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {         
            if (checkBan.Checked==false && checkNhap.Checked ==false)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBan.Checked == true && checkNhap.Checked == true)
            {
                MessageBox.Show("Vui lòng chọn một danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(rabtnNgay.Checked==false &&rabtnThang.Checked==false&&rabtnNam.Checked==false)
            {
                MessageBox.Show("Vui lòng chọn thời gian thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(checkBan.Checked==true &&rabtnNgay.Checked==true)
            {                
                LoadDataGridView1();
            }
            if (checkBan.Checked == true && rabtnThang.Checked == true)
            {
                LoadDataGridView2();
            }
            if (checkBan.Checked == true && rabtnNam.Checked == true)
            {
                LoadDataGridView3();
            }
            if (checkNhap.Checked == true && rabtnNgay.Checked == true)
            {
                LoadDataGridView4();
            }
            if (checkNhap.Checked == true && rabtnThang.Checked == true)
            {
                LoadDataGridView5();
            }
            if (checkNhap.Checked == true && rabtnNam.Checked == true)
            {
                LoadDataGridView6();
            }
        }
        private void LoadDataGridView1()
        {
            dgvThongke.DataSource = hdbbus.StatisticBantheoNgay();

            dgvThongke.AllowUserToAddRows = false;
            dgvThongke.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView2()
        {
            dgvThongke.DataSource = hdbbus.StatisticBantheoThang();

            dgvThongke.AllowUserToAddRows = false;
            dgvThongke.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView3()
        {
            dgvThongke.DataSource = hdbbus.StatisticBantheoNam();

            dgvThongke.AllowUserToAddRows = false;
            dgvThongke.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView4()
        {
            dgvThongke.DataSource = hdnbus.StatisticNhaptheoNgay();

            dgvThongke.AllowUserToAddRows = false;
            dgvThongke.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView5()
        {
            dgvThongke.DataSource = hdnbus.StatisticNhaptheoThang();

            dgvThongke.AllowUserToAddRows = false;
            dgvThongke.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridView6()
        {
            dgvThongke.DataSource = hdnbus.StatisticNhaptheoNam();

            dgvThongke.AllowUserToAddRows = false;
            dgvThongke.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


    }
}
