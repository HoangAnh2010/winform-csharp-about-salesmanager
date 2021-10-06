using QLBanHang.BUS;
using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLBanHang.GUI
{
    public partial class frmHoaDonNhap : Form
    {
        HoaDonNhapBUS hdnbus = new HoaDonNhapBUS();
        ChiTietHDNhapBUS ctbus = new ChiTietHDNhapBUS();
        List<ChiTietHDNhap> pendingOrderDetails;
        private string maHoaDon;
        private BindingSource cthdSource;
        Regex regexSoLg = new Regex("[0-9]");
        Regex regexGia=new Regex("[0-9]");
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        private void txtSoLg_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtGia.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                
                btnThemCT.Enabled = false;
                btnLuuHDX.Enabled = false;
                return;
            }
            
            if (txtSoLg.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSoLg, "Vui lòng nhập số lượng!");
                btnThemCT.Enabled = false;
                btnLuuHDX.Enabled = false;
            }
            else
            {
                if (!regexSoLg.IsMatch(txtSoLg.Text)|| txtSoLg.Text.Trim().Length > regexSoLg.Matches(txtSoLg.Text).Count)
                {
                    errorProvider1.SetError(txtSoLg, "Số lượng là một số nguyên dương");
                    btnThemCT.Enabled = false;
                    btnLuuHDX.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    txtThanhTien.Text = (double.Parse(txtGia.Text) * int.Parse(txtSoLg.Text)).ToString();
                    txtThanhTien.Text= String.Format(culture, "{0:N0}", value);
                    txtThanhTien.Select(txtThanhTien.Text.Length, 0);
                    btnThemCT.Enabled = true;
                    btnLuuHDX.Enabled = true;
                }
            }
        }
        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtGia.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                errorProvider1.SetError(txtGia, "Vui lòng nhập giá nhập!");
                btnThemCT.Enabled = false;
                btnLuuHDX.Enabled = false;
                return;
            }
            txtGia.Text = String.Format(culture, "{0:N0}", value);
            txtGia.Select(txtGia.Text.Length, 0);
            if (txtGia.Text.Trim() == "")
            {
                errorProvider1.SetError(txtGia, "Vui lòng nhập giá nhập!");
                btnThemCT.Enabled = false;
                btnLuuHDX.Enabled = false;
            }
            else
            {
                if (!regexGia.IsMatch(txtGia.Text) || txtGia.Text.Length > regexGia.Matches(txtGia.Text).Count)
                {
                    errorProvider1.SetError(txtGia, "Giá nhập là một số nguyên dương");
                    btnThemCT.Enabled = false;
                    btnLuuHDX.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnThemCT.Enabled = true;
                    btnLuuHDX.Enabled = true;
                }
            }

        }
        private void cboMasp_SelectedValueChanged(object sender, EventArgs e)
        {
            string masp = cboMasp.SelectedValue.ToString();
            txtTensp.Text = hdnbus.GetTenSPtheoMaSP(masp);
        }
        private void frmHoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoatHDX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            pendingOrderDetails = new List<ChiTietHDNhap>();
            cthdSource = new BindingSource();
            cthdSource.DataSource = pendingOrderDetails;

            btnThemMoi.Enabled = true;
            btnLuuHDX.Enabled = false;
            btnInHDX.Enabled = false;
            txtTendl.ReadOnly = true;

            txtTensp.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.Text = "0";
            cboMaDL.SelectedIndex = -1;
            cboMasp.SelectedIndex = -1;

            LoadDataGridView(true);

            dgvHDN.DataSource = cthdSource;
            dgvHDN.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHDN.Columns[1].HeaderText = "Mã sản phẩm";
            dgvHDN.Columns[2].HeaderText = "Số lượng ";
            dgvHDN.Columns[3].HeaderText = "Giá nhập";
            dgvHDN.Columns[4].HeaderText = "Thành tiền";

            dgvHDN.Columns[0].Width = 50;
            dgvHDN.Columns[1].Width = 150;
            dgvHDN.Columns[2].Width = 70;
            dgvHDN.Columns[3].Width = 70;
            dgvHDN.Columns[4].Width = 70;
        }

        private void cboMaDL_SelectedValueChanged(object sender, EventArgs e)
        {
            string madl = cboMaDL.SelectedValue.ToString();
            txtTendl.Text = hdnbus.GetTenDLtheoMaDL(madl);
            txtSdt.Text = hdnbus.GetSdttheoMaDL(madl);
            txtDc.Text = hdnbus.GetDiachitheoMaDL(madl);
        }
        private void LoadDataGridView(bool f = false)
        {
            string mahd = txtMaHDN.Text;
            string masp = cboMasp.Text;

            cboMasp.DataSource = hdnbus.GetMaSP();
            cboMasp.ValueMember = "MaSP";
            cboMasp.DisplayMember = "TenSP";

            cboMaDL.DataSource = hdnbus.GetMaDL();
            cboMaDL.ValueMember = "MaDL";
            cboMaDL.DisplayMember = "TenDL";



            if (!f)
            {
                dgvHDN.DataSource = hdnbus.GetDataToTable(mahd, masp);

                dgvHDN.Columns[0].HeaderText = "Mã hóa đơn";
                dgvHDN.Columns[1].HeaderText = "Mã sản phẩm";
                dgvHDN.Columns[2].HeaderText = "Số lượng ";
                dgvHDN.Columns[3].HeaderText = "Giá nhập";
                dgvHDN.Columns[4].HeaderText = "Thành tiền";

                dgvHDN.Columns[0].Width = 50;
                dgvHDN.Columns[1].Width = 150;
                dgvHDN.Columns[2].Width = 70;
                dgvHDN.Columns[3].Width = 70;
                dgvHDN.Columns[4].Width = 70;

            }

            dgvHDN.AllowUserToAddRows = false;
            dgvHDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cthdSource.Clear();
            btnHuyHDX.Enabled = false;
            btnInHDX.Enabled = false;
            btnLuuHDX.Enabled = true;
            btnThemMoi.Enabled = false;
            ResetValues();
            maHoaDon = hdnbus.CreateKey("HDN");
            txtMaHDN.Text = maHoaDon;
            LoadDataGridView(true);
        }
        private void ResetValues()
        {
            txtMaHDN.Text = "";
            dateNgayNhap.Text = DateTime.Now.ToShortDateString();
            cboMaDL.Text = "";
            txtTendl.Text = "";
            txtSdt.Text = "";
            txtDc.Text = "";
            cboMasp.Text = "";
            txtSoLg.Text = "";
            txtGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnLuuHDX_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHDN.Text;
            string maDL = cboMaDL.Text;
            DateTime ngayNhap = dateNgayNhap.Value;            
            double tongTien = 0;
            
            if (!hdnbus.CheckMaHDN(maHD))
            {
                if (cboMaDL.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đại lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaDL.Focus();
                    return;
                }             
                // Lưu thông tin của các mặt hàng
                foreach (var cthd in pendingOrderDetails)
                {
                    tongTien += cthd.GiaNhap * cthd.SoLg;
                }
                txtTongTien.Text = tongTien.ToString();

                HoaDonNhap hdn = new HoaDonNhap(maHD, ngayNhap, maDL, tongTien);
                hdnbus.SaveHDN(hdn);

                MessageBox.Show(ctbus.ThemNhieuCTHDN(pendingOrderDetails));
                //pendingOrderDetails.Clear();
                //cthdSource.Clear();
            }
            //ResetValuesSP();
            btnThemMoi.Enabled = true;
            btnInHDX.Enabled = true;
        }
        private void ResetValuesSP()
        {
            cboMasp.Text = "";
            txtGia.Text = "";
            txtSoLg.Text = "";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "";
        }
        
        public int GetSoLuong()
        {
            try
            {
                int soLgBan = int.Parse(txtSoLg.Text);
                return soLgBan;
            }
            catch
            {
                MessageBox.Show("Số lượng là một số nguyên dương");
                return -1;
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string masp = cboMasp.Text;
            double gia = txtGia.Text.Length > regexGia.Matches(txtGia.Text).Count ? 0 : double.Parse(txtGia.Text);
            int soLgNhap = txtSoLg.Text.Length> regexSoLg.Matches(txtSoLg.Text).Count ? 0 : int.Parse(txtSoLg.Text);
            string maHoaDon = txtMaHDN.Text;
            double tongTien =  double.Parse(txtTongTien.Text);
            if (!hdnbus.CheckMaHDandMaSP(maHoaDon, masp, pendingOrderDetails))
            {
                MessageBox.Show("Sản phẩm này đã có trong hóa đơn của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (soLgNhap <= 10)
            {
                MessageBox.Show("Số lượng nhập là một số nguyên dương > 10");
                return;
            }

            int onHand = Convert.ToInt32(ctbus.GetSoLgCo(masp));
            if ( onHand > 20)
            {
                MessageBox.Show("Số lượng còn đủ để bán");
                return;
            }
            ctbus.CapNhatSoLg(masp, onHand + soLgNhap);
            ChiTietHDNhap hdn = new ChiTietHDNhap(maHoaDon, masp, soLgNhap, gia, gia * soLgNhap);
            cthdSource.Add(hdn);
            tongTien += hdn.ThanhTien;
            txtTongTien.Text = tongTien.ToString();
            dgvHDN.Refresh();
            dgvHDN.Update();
        }

        private void btnInHDX_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHDN.Text;
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;

            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Mỹ phẩm giá sỉ";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "66 đường Nguyễn Thiện Thuật, Bần Yên Nhân, Mỹ Hào, Hưng Yên";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0354.551.296";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";

            // Biểu diễn thông tin chung của hóa đơn bán

            tblThongtinHD = hdnbus.GetDataToTable(mahd);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Đại lý:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Điện thoại:";
            exRange.Range["C8:D8"].MergeCells = true;
            exRange.Range["C8:D8"].Value = "'" + tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Địa chỉ:";
            exRange.Range["C9:G9"].MergeCells = true;
            exRange.Range["C9:G9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng

            tblThongtinHang = hdnbus.GetDataToTable1(mahd);

            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B11"].ColumnWidth = 50;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Giá nhập";
            exRange.Range["E11:E11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Mỹ Hào, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Người nhập";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHDN.Focus();
                return;
            }
            else if (!hdnbus.CheckMaHDN(txtMaHDN.Text))
            {
                MessageBox.Show("Mã hóa đơn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHDN.Focus();
                return;
            }
            LoadInfoHoaDon();
            LoadDataGridView();
            btnHuyHDX.Enabled = true;
            btnLuuHDX.Enabled = true;
            btnInHDX.Enabled = true;
        }
        private void LoadInfoHoaDon()
        {
            string ma = txtMaHDN.Text;

            cboMaDL.Text = hdnbus.GetMaDL(ma);
            dateNgayNhap.Value = DateTime.Parse(hdnbus.GetNgayNhap(ma));            
            txtTongTien.Text = hdnbus.GetTien(ma);
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string mahd = txtMaHDN.Text;

            dgvHDN.DataSource = hdnbus.GetDataToTable2(mahd);

            dgvHDN.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHDN.Columns[1].HeaderText = "Mã sản phẩm";
            dgvHDN.Columns[2].HeaderText = "Số lượng";
            dgvHDN.Columns[3].HeaderText = "Giá nhập";
            dgvHDN.Columns[4].HeaderText = "Thành tiền";

            dgvHDN.Columns[0].Width = 150;
            dgvHDN.Columns[1].Width = 150;
            dgvHDN.Columns[2].Width = 100;
            dgvHDN.Columns[3].Width = 100;
            dgvHDN.Columns[4].Width = 100;
        }

        private void btnHuyHDX_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHDN.Text;
            int sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable tblHang = ctbus.GetSoLgBan(mahd);

                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToInt32(ctbus.GetSoLgCo(tblHang.Rows[hang][0].ToString()));
                    slxoa = Convert.ToInt32(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;

                    ctbus.CapNhatSoLgSauXoa(tblHang.Rows[hang][0].ToString(), slcon);
                }

                //Xóa chi tiết hóa đơn
                ctbus.DeleteCT(mahd);

                //Xóa hóa đơn
                hdnbus.DeleteHD(mahd);

                ResetValues();
                dgvHDN.DataSource = null;
                btnHuyHDX.Enabled = false;
                btnInHDX.Enabled = false;
            }
        }

        private void dgvHDN_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = txtMaHDN.Text;
            string mahdn;
            string maspxoa;
            double donGiaXoa, ThanhTienxoa, tong, tongmoi;
            int SoLuongxoa, sl, slcon;
            if (dgvHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mahdn = dgvHDN.CurrentRow.Cells["MaHD"].Value.ToString();
                maspxoa = dgvHDN.CurrentRow.Cells["MaSP"].Value.ToString();
                SoLuongxoa = Convert.ToInt32(dgvHDN.CurrentRow.Cells["SoLg"].Value.ToString());
                donGiaXoa = Convert.ToDouble(dgvHDN.CurrentRow.Cells["GiaNhap"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHDN.CurrentRow.Cells["ThanhTien"].Value.ToString());

                cthdSource.RemoveAt(e.RowIndex);

                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToInt32(ctbus.GetSoLgCo(maspxoa));
                slcon = sl + SoLuongxoa;
                ctbus.CapNhatSoLgSauXoa(maspxoa, slcon);

                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(txtTongTien.Text);
                tongmoi = tong - ThanhTienxoa;
                ctbus.CapNhatTongTien(mahdn, tongmoi);
                txtTongTien.Text = tongmoi.ToString();

            }
        }
    }
}
