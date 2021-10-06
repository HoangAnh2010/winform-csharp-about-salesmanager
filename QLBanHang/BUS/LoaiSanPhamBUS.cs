using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBanHang.DAL;
using QLBanHang.DTO;
namespace QLBanHang.BUS
{
    class LoaiSanPhamBUS
    {
        LoaiSanPhamDAL lspdal = new LoaiSanPhamDAL();
        public DataTable GetDataToTable()
        {
            return lspdal.GetDataToTable();
        }
        //Hàm kiểm tra khoá trùng
        public bool CheckKey(string ma)
        {
            return lspdal.CheckKey(ma);
        }
        public void SaveLoaiSP(LoaiSanPham lsp)
        {
            lspdal.SaveLoaiSP(lsp);
        }
        public void UpdateLoaiSP(string ma, LoaiSanPham lsp)
        {
            lspdal.UpdateLoaiSP(ma, lsp);
        }
        public void DeleteLoaiSP(string ma)
        {
            lspdal.DeleteLoaiSP(ma);
        }
    }
}
