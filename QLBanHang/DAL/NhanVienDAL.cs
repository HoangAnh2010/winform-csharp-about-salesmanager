using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    public class NhanVienDAL
    {
        public DataTable GetDataToTable()
        {
            string query = "select * from NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool CheckKey(string ma)
        {
            string query = "select manv from NhanVien where manv='" + ma + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public bool CheckTenDN(string tendn)
        {
            string query = "select * from TaiKhoan where tendn = '"+tendn+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public bool CheckTenDN2(string tendn)
        {
            string query = "select Tendn from NhanVien where tendn='" + tendn + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public void SaveNV(NhanVien nv)
        {
            string query = $"insert into NhanVien(manv,tennv,sdt,diachi,tendn) values('{nv.MaNV}', '{nv.TenNV}',  {nv.Sdt}, N'{nv.DiaChi}', '{nv.TenDN}')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void UpdateNV(string ma, NhanVien nv)
        {
            string query = $"update NhanVien set TenNV=N'{nv.TenNV}',Sdt='{nv.Sdt}',DiaChi=N'{nv.DiaChi}',TenDn='{nv.TenDN}' where MaNV='{ma}'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DeleteNhanVien(string ma)
        {
            string query = "delete from NhanVien where MaNV='" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
    
}
