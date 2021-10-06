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
    public partial class frmHoaDonBan : Form
    {        
        HoaDonBanBUS hdbbus = new HoaDonBanBUS();
        ChiTietHDBanBUS ctbus = new ChiTietHDBanBUS();
        Regex regexTen = new Regex("^[A-Za-z À-Ỹà-ỹ]+$");
        Regex regexDc = new Regex("[a-zA-Z0-9-\\/à-ỹÀ-Ỹ]+$");        
        Regex regexSdt = new Regex("[0-9]");
        Regex regexSoLg = new Regex("[0-9]");
        List<CTHoaDonBan> pendingOrderDetails;
        private string maHoaDon;
        private BindingSource cthdSource;
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void txtHoTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTenKH.Text.Trim() == "")
            {
                errorProvider1.SetError(txtHoTenKH, "Tên khách hàng không được để trống");
                btnLuuHDX.Enabled = false;
                btnThemCT.Enabled = false;
            }
            else
            {
                if (!regexTen.IsMatch(txtHoTenKH.Text))
                {
                    errorProvider1.SetError(txtHoTenKH, "Tên khách hàng không chứa các kí tự số và kí tự đặc biệt");
                    btnLuuHDX.Enabled = false; 
                    btnThemCT.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuHDX.Enabled = true;
                    btnThemCT.Enabled = true;
                }
            }
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            if (txtSdt.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSdt, "Số điện thoại không được để trống");
                btnLuuHDX.Enabled = false;
                btnThemCT.Enabled = false;
            }
            else
            {
                if (!regexSdt.IsMatch(txtSdt.Text))
                {
                    errorProvider1.SetError(txtSdt, "Số điện thoại gồm 10 số từ 0 đến 9");
                    btnLuuHDX.Enabled = false;
                    btnThemCT.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuHDX.Enabled = true;
                    btnThemCT.Enabled = true;
                }
            }
        }

        private void txtDiaChiKH_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChiKH.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDiaChiKH, "Địa chỉ không được để trống");
                btnLuuHDX.Enabled = false;
                btnThemCT.Enabled = false;
            }
            else
            {
                if (!regexDc.IsMatch(txtDiaChiKH.Text))
                {
                    errorProvider1.SetError(txtDiaChiKH, "Địa chỉ không được chứa kí tự đặc biệt");
                    btnLuuHDX.Enabled = false;
                    btnThemCT.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    btnLuuHDX.Enabled = true;
                    btnThemCT.Enabled = true;
                }
            }
        }

        private void txtSoLgBan_TextChanged(object sender, EventArgs e)
        {
            
            if (txtSoLgBan.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSoLgBan, "Vui lòng nhập số lượng bán!");
                btnLuuHDX.Enabled = false;
                btnThemCT.Enabled = false;
            }
            else
            {
                if (!regexSoLg.IsMatch(txtSoLgBan.Text)|| txtSoLgBan.Text.Length> regexSoLg.Matches(txtSoLgBan.Text).Count)
                {
                    errorProvider1.SetError(txtSoLgBan, "Số lượng bán là một số nguyên dương");
                    btnLuuHDX.Enabled = false;
                    btnThemCT.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    txtThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSoLgBan.Text)).ToString();                    
                    btnLuuHDX.Enabled = true;
                    btnThemCT.Enabled = true;
                }
            }
        }
        
        private void frmHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            pendingOrderDetails = new List<CTHoaDonBan>();
            cthdSource = new BindingSource();
            cthdSource.DataSource = pendingOrderDetails;

            btnThemMoi.Enabled = true;
            btnLuuHDX.Enabled = false;
            btnInHDX.Enabled = false;
            txtTenNhanVien.ReadOnly = true;
            
            txtTenSP.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTienHDX.Text = "0";
            cboMaNhanVien.SelectedIndex = -1;
            cboMaSP.SelectedIndex = -1;

            

            LoadDataGridView(true);

            dgvHDX.DataSource = cthdSource;
            dgvHDX.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHDX.Columns[1].HeaderText = "Mã sản phẩm";
            dgvHDX.Columns[2].HeaderText = "Số lượng ";
            dgvHDX.Columns[3].HeaderText = "Giá bán";
            dgvHDX.Columns[4].HeaderText = "Thành tiền";

            dgvHDX.Columns[0].Width = 50;
            dgvHDX.Columns[1].Width = 150;
            dgvHDX.Columns[2].Width = 70;
            dgvHDX.Columns[3].Width = 70;
            dgvHDX.Columns[4].Width = 70;
        }

        private void cboMaNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            string manv = cboMaNhanVien.SelectedValue.ToString();
            txtTenNhanVien.Text = hdbbus.GetTenNVtheoMaNV(manv);
        }

        private void cboMaSP_SelectedValueChanged(object sender, EventArgs e)
        {
            string masp = cboMaSP.SelectedValue.ToString();
            txtTenSP.Text = hdbbus.GetTenSPtheoMaSP(masp);
            txtDonGia.Text = hdbbus.GetGiatheoMaSP(masp);
        }
        private void LoadDataGridView(bool f = false)
        {
            string mahd = txtMaHDBan.Text;
            string masp = cboMaSP.Text;

            cboMaSP.DataSource = hdbbus.GetMaSP();
            cboMaSP.ValueMember = "MaSP";
            cboMaSP.DisplayMember = "TenSP";

            cboMaNhanVien.DataSource = hdbbus.GetMaNV();
            cboMaNhanVien.ValueMember = "MaNV";
            cboMaNhanVien.DisplayMember = "HoTenNV";

            
            
            if (!f)
            {                
                dgvHDX.DataSource = hdbbus.GetDataToTable(mahd, masp);

                dgvHDX.Columns[0].HeaderText = "Mã hóa đơn";
                dgvHDX.Columns[1].HeaderText = "Mã sản phẩm";
                dgvHDX.Columns[2].HeaderText = "Số lượng ";
                dgvHDX.Columns[3].HeaderText = "Giá bán";
                dgvHDX.Columns[4].HeaderText = "Thành tiền";

                dgvHDX.Columns[0].Width = 50;
                dgvHDX.Columns[1].Width = 150;
                dgvHDX.Columns[2].Width = 70;
                dgvHDX.Columns[3].Width = 70;
                dgvHDX.Columns[4].Width = 70;

            }

            dgvHDX.AllowUserToAddRows = false;
            dgvHDX.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cthdSource.Clear();
            btnHuyHDX.Enabled = false;
            btnInHDX.Enabled = false;
            btnLuuHDX.Enabled = true;
            btnThemMoi.Enabled = false;
            ResetValues();
            maHoaDon = hdbbus.CreateKey("HDB");
            txtMaHDBan.Text = maHoaDon;
            LoadDataGridView(true);
        }
        private void ResetValues()
        {
            txtMaHDBan.Text = "";
            dateNgayBan.Text = DateTime.Now.ToShortDateString();
            cboMaNhanVien.Text = "";
            txtHoTenKH.Text = "";
            txtSdt.Text = "";
            txtDiaChiKH.Text = "";
            cboMaSP.Text = "";
            txtSoLgBan.Text = "";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnLuuHDX_Click(object sender, EventArgs e)
        {
            string maHDB = txtMaHDBan.Text;
            string maNV = cboMaNhanVien.Text;
            DateTime ngayBan = dateNgayBan.Value;
            string tenKhach = txtHoTenKH.Text;
            string sdt = txtSdt.Text;
            string dc = txtDiaChiKH.Text;
            double tongTienTT = 0;
            string masp = cboMaSP.Text;
            int soLgBan = int.Parse(txtSoLgBan.Text);
            
            if (!hdbbus.CheckMaHDB(maHDB))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa

                if (cboMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNhanVien.Focus();
                    return;
                }

                if (txtHoTenKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTenKH.Focus();
                    return;
                }


                if (txtSdt.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSdt.Focus();
                    return;
                }
                if (txtDiaChiKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChiKH.Focus();
                    return;
                }
                // Lưu thông tin của các mặt hàng
                foreach (var cthd in pendingOrderDetails)
                {
                    tongTienTT += cthd.GiaBan * cthd.SoLg;
                }
                txtTongTienHDX.Text = tongTienTT.ToString();

                HoaDonBan hdb = new HoaDonBan(maHDB, ngayBan, maNV,tenKhach,sdt,dc, tongTienTT);
                hdbbus.SaveHDB(hdb);

                MessageBox.Show(ctbus.ThemNhieuCTHDB(pendingOrderDetails));

                int onHand = Convert.ToInt32(ctbus.GetSoLgCo(masp));                
                ctbus.CapNhatSoLg(masp, onHand - soLgBan);

                //pendingOrderDetails.Clear();
                //cthdSource.Clear();

            }

            //ResetValuesSP();
            btnThemMoi.Enabled = true;
            btnLuuHDX.Enabled = true;
            btnInHDX.Enabled = true;
        }
        private void ResetValuesSP()
        {
            cboMaSP.Text = "";
            txtSoLgBan.Text = "";
            txtThanhTien.Text = "0";
            txtTongTienHDX.Text = "";
        }        
        public int GetSoLuong()
        {
            try
            {
                int soLgBan = int.Parse(txtSoLgBan.Text);
                return soLgBan;
            }
            catch
            {
                MessageBox.Show("Số lượng là số nguyên dương");
                return -1;
            }
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string masp = cboMaSP.Text; 
            double donGia = double.Parse(txtDonGia.Text);
            int soLgBan = txtSoLgBan.Text.Trim().Length > regexSoLg.Matches(txtSoLgBan.Text).Count? 0: int.Parse(txtSoLgBan.Text);
            string maHoaDon = txtMaHDBan.Text;
            double thanhtien = double.Parse( txtThanhTien.Text);
            double tongTien = double.Parse(txtTongTienHDX.Text);
            CTHoaDonBan hdb = new CTHoaDonBan(maHoaDon, masp, soLgBan, donGia, donGia * soLgBan);
            int onHand = Convert.ToInt32(ctbus.GetSoLgCo(masp));

            if (!hdbbus.CheckMaHDandMaSP(maHoaDon,masp, pendingOrderDetails))
            {
                hdbbus.TangSoLuong(masp, pendingOrderDetails,soLgBan);
                hdbbus.UpdateThanhTien(masp, pendingOrderDetails, thanhtien);
                tongTien += hdb.ThanhTien;
                txtTongTienHDX.Text = tongTien.ToString();
                dgvHDX.Refresh();
                dgvHDX.Update();
                return;

                //MessageBox.Show("Sản phẩm này đã có trong hóa đơn của bạn!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            if (soLgBan <= 0)
            {
                MessageBox.Show("Số lượng là số nguyên dương");
                return;
            }

            if (soLgBan > onHand)
            {
                MessageBox.Show("Số lượng không đủ để bán");
                return;
            }
            else
            {
                cthdSource.Add(hdb);
                tongTien += hdb.ThanhTien;
                txtTongTienHDX.Text = tongTien.ToString();

            }
            
            dgvHDX.Refresh();
            dgvHDX.Update();
        }

        private void btnInHDX_Click(object sender, EventArgs e)
        {
            string mahd=txtMaHDBan.Text;
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
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";

            // Biểu diễn thông tin chung của hóa đơn bán
            
            tblThongtinHD = hdbbus.GetDataToTable(mahd);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Điện thoại:";
            exRange.Range["C8:D8"].MergeCells = true;
            exRange.Range["C8:D8"].Value = "'"+tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Địa chỉ:";
            exRange.Range["C9:G9"].MergeCells = true;
            exRange.Range["C9:G9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            
            tblThongtinHang = hdbbus.GetDataToTable1(mahd);

            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B11"].ColumnWidth = 50;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Giá bán";
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
            //exRange.Range["F1"].MergeCells = false;
            exRange.Range["B1"].Font.Bold = true;
            exRange.Range["B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["B1"].Value = "đồng";
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
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn bán";
            exApp.Visible = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaHDBan.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHDBan.Focus();
                return;
            }
            else if (!hdbbus.CheckMaHDB(txtMaHDBan.Text) )
            {
                MessageBox.Show("Mã hóa đơn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHDBan.Focus();
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
            string ma = txtMaHDBan.Text;
            
            cboMaNhanVien.Text = hdbbus.GetMaNV(ma);
            dateNgayBan.Value = DateTime.Parse(hdbbus.GetNgayban(ma));
            txtHoTenKH.Text = hdbbus.GetTenKhach(ma);
            txtSdt.Text = hdbbus.GetSdt(ma);
            txtDiaChiKH.Text = hdbbus.GetDc(ma);
            txtTongTienHDX.Text = hdbbus.GetTien(ma);
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string mahd = txtMaHDBan.Text;

            dgvHDX.DataSource = hdbbus.GetDataToTable2(mahd);

            dgvHDX.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHDX.Columns[1].HeaderText = "Mã sản phẩm";
            dgvHDX.Columns[2].HeaderText = "Số lượng";
            dgvHDX.Columns[3].HeaderText = "Giá bán";
            dgvHDX.Columns[4].HeaderText = "Thành tiền";

            dgvHDX.Columns[0].Width = 150;
            dgvHDX.Columns[1].Width = 150;
            dgvHDX.Columns[2].Width = 100;
            dgvHDX.Columns[3].Width = 100;
            dgvHDX.Columns[4].Width = 100;
        }

        private void btnHuyHDX_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHDBan.Text;
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
                    
                    ctbus.CapNhatSoLgSauXoa(tblHang.Rows[hang][0].ToString(),slcon);
                }

                //Xóa chi tiết hóa đơn
                //ctbus.DeleteCT(mahd);

                //Xóa hóa đơn
                hdbbus.DeleteHD(mahd);

                ResetValues();
                dgvHDX.DataSource = null;
                btnHuyHDX.Enabled = false;
                btnInHDX.Enabled = false;
            }
        }

        private void dgvHDX_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = txtMaHDBan.Text;
            string mahdb;
            string maspxoa;
            double donGiaXoa, ThanhTienxoa, tong, tongmoi;
            int SoLuongxoa, sl, slcon;
            if (dgvHDX.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mahdb = dgvHDX.CurrentRow.Cells["MaHDB"].Value.ToString();
                maspxoa = dgvHDX.CurrentRow.Cells["MaSP"].Value.ToString();
                SoLuongxoa = Convert.ToInt32(dgvHDX.CurrentRow.Cells["SoLg"].Value.ToString());
                donGiaXoa = Convert.ToDouble(dgvHDX.CurrentRow.Cells["GiaBan"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHDX.CurrentRow.Cells["ThanhTien"].Value.ToString());

                cthdSource.RemoveAt(e.RowIndex);

                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToInt32(ctbus.GetSoLgCo(maspxoa));
                slcon = sl + SoLuongxoa;
                ctbus.CapNhatSoLgSauXoa(maspxoa, slcon);

                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(txtTongTienHDX.Text);
                tongmoi = tong - ThanhTienxoa;
                ctbus.CapNhatTongTien(mahdb, tongmoi);
                txtTongTienHDX.Text = tongmoi.ToString();

            }
        }

        
    }
}
