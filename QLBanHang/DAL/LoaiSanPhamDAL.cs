using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    class LoaiSanPhamDAL
    {
        public DataTable GetDataToTable()
        {
            LoaiSanPham lsp = new LoaiSanPham();
            string query = "select * from LoaiSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        //Hàm kiểm tra khoá trùng
        public bool CheckKey(string ma)
        {
            string query = "select MaLoai from loaisanpham where MaLoai='" + ma + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public void SaveLoaiSP(LoaiSanPham lsp)
        {
            string query = "insert into loaisanpham (maloai,tenloai) values('" + lsp.MaLoai + "', N'" + lsp.TenLoai + "')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void UpdateLoaiSP(string ma, LoaiSanPham lsp)
        {
            string query = "update loaisanpham set TenLoai = N'" + lsp.TenLoai + "' where MaLoai = '" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DeleteLoaiSP(string ma)
        {
            string query = "delete from loaisanpham where MaLoai='" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
