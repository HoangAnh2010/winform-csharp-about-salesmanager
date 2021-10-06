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

namespace QLBanHang.GUI
{
    public partial class frmDanhSachNguoiDung : Form
    {
        DangNhapBUS dnbus = new DangNhapBUS();
        public frmDanhSachNguoiDung()
        {
            InitializeComponent();
        }

        private void frmDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            dgvDs.DataSource = dnbus.GetDSUser();

            dgvDs.Columns[0].Width = 50;
            dgvDs.Columns[1].Width = 100;
            dgvDs.Columns[2].Width = 85;
            dgvDs.Columns[3].Width = 250;
            dgvDs.Columns[4].Width = 100;
        }

        private void dgvDs_DoubleClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn chuyển đến danh mục nhân viên?","Question",MessageBoxButtons.OK,MessageBoxIcon.Question)==DialogResult.OK)
            {
                frmNhanVien nv = new frmNhanVien();
                nv.ShowDialog();
            }
        }
    }
}
