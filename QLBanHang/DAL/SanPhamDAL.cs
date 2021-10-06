using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    class SanPhamDAL
    {
        public DataTable GetDataToTable()
        {
            string query = "select * from SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetMaLoai()
        {
            string query = "select MaLoai from loaisanpham ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string GetTenLoaitheoMaLoai(string maloai)
        {
            string query = "select  TenLoai from loaisanpham where MaLoai='" + maloai + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public void DeleteSanPham(string ma)
        {
            string query = "delete from SanPham where MaSP='" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public DataTable FindSanPhamtheoMa(string ma)
        {
            string query = "select * from SanPham where MaSP like '%" + ma + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable FindSanPhamtheoTen(string ten)
        {
            string query = "select * from SanPham where TenSP like '%" + ten + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable FindSanPhamtheoMavaTen(string ma, string ten)
        {
            string query = "select * from SanPham where MaSP like '%" + ma + "%' and TenSP like '%" + ten + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool CheckKey(string ma)
        {
            string query = "select * from SanPham where MaSP='" + ma + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public void SaveSP(SanPham sp)
        {
            string query = $"insert into SanPham values('{sp.MaSP}',N'{sp.TenSP}','{sp.MaLoai}',Cast('{sp.Nsx.ToString("MM/dd/yyyy")}' as datetime),Cast('{sp.Hsd.ToString("MM/dd/yyyy")}' as datetime),'{sp.SoLg}','{sp.DonGia}')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void UpdateSP(string ma, SanPham sp)
        {
            string query = $"update SanPham set TenSP=N'{sp.TenSP}',MaLoai='{sp.MaLoai}',Nsx=Cast('{sp.Nsx.ToString("MM/dd/yyyy")}' as datetime),Hsd=Cast('{sp.Hsd.ToString("MM/dd/yyyy")}' as datetime),soluongco='{sp.SoLg}',dongia='{sp.DonGia}' where MaSP='{ma}'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
