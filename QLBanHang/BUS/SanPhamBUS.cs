using QLBanHang.DAL;
using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS
{
    class SanPhamBUS
    {
        SanPhamDAL spdal = new SanPhamDAL();
        public DataTable GetDataToTable()
        {
            return spdal.GetDataToTable();
        }
        public DataTable GetMaLoai()
        {
            return spdal.GetMaLoai();
        }
        public string GetTenLoaitheoMaLoai(string maloai)
        {
            return spdal.GetTenLoaitheoMaLoai(maloai);
        }
        public void DeleteSanPham(string ma)
        {
            spdal.DeleteSanPham(ma);
        }
        public DataTable FindSanPhamtheoMa(string ma)
        {
            return spdal.FindSanPhamtheoMa(ma);
        }
        public DataTable FindSanPhamtheoTen(string ten)
        {
            return spdal.FindSanPhamtheoTen(ten);
        }
        public DataTable FindSanPhamtheoMavaTen(string ma, string ten)
        {
            return spdal.FindSanPhamtheoMavaTen(ma, ten);
        }
        public bool CheckKey(string ma)
        {
            return spdal.CheckKey(ma);
        }
        public void SaveSP(SanPham sp)
        {
            spdal.SaveSP(sp);
        }
        public void UpdateSP(string ma, SanPham sp)
        {
            spdal.UpdateSP(ma, sp);
        }
    }
}
