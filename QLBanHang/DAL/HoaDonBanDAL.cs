using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    class HoaDonBanDAL
    {
        public string GetTenNVtheoMaNV(string manv)
        {
            string query = "select TenNV from NhanVien where MaNV='" + manv + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetTenSPtheoMaSP(string masp)
        {
            string query = "select TenSP from SanPham where MaSP='" + masp + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetGiatheoMaSP(string masp)
        {
            string query = "select dongia from SanPham where MaSP='" + masp + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public DataTable GetDataToTable(string mahd, string masp)
        {
            string query = "select ct.mahd,ct.masp,ct.solg,sp.dongia,ct.ThanhTien from SanPham sp inner join ChiTietHDB ct on sp.MaSP = ct.MaSP  where ct.MaHD = '" + mahd + "'and sp.MaSP = '" + masp + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetMaNV()
        {
            string query = "select MaNV from NhanVien ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetMaSP()
        {
            string query = "select MaSP from SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public string CreateKey(string tiento)
        {
            string key = DataProvider.Instance.ExecuteReader("select dbo.SP_getPrevKeyHDB()");
            if (key == "")
                return tiento + "0";
            key = key.Replace("HDB", "");
            int tempt = int.Parse(key);
            return tiento + tempt.ToString();
        }
        public bool CheckMaHDB(string maHDB)
        {
            string query = "select * from HoaDonBan where MaHD='" + maHDB + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public bool CheckMaHDandMaSP(string mahd, string masp)
        {
            string query = "select mahd,masp from ChiTietHDB where mahd='" + mahd + "' and masp='" + masp + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public void SaveHDB(HoaDonBan hdb)
        {
            string query = $"insert into HoaDonBan values('{hdb.MaHDB}',Cast('{hdb.NgayBan.ToString("MM / dd / yyyy")}' as datetime),'{hdb.MaNV}',N'{hdb.TenKhach}','{hdb.SdtKhach}',N'{hdb.DcKhach}','{hdb.TongTienTT}')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public DataTable GetDataToTable(string mahd)
        {
            string query = "select hd.mahd,ngayban,tongtien,tenkhach,sdtkhach,dckhach, tennv from HoaDonBan hd inner join NhanVien nv on hd.manv = nv.manv where hd.mahd = '" + mahd + "' and hd.manv = nv.manv";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetDataToTable1(string mahd)
        {
            string query = "select tensp,solg,giaban,thanhtien from ChiTietHDB ct inner join SanPham sp on ct.masp = sp.masp where mahd = '" + mahd + "' and ct.masp = sp.masp";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoMa(string mahd)
        {
            string query = "select * from HoaDonBan where mahd like '%" + mahd + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoThangvaNam(int thang,int nam)
        {
            string query = "select * from HoaDonBan where month(ngayban)= '" + thang + "' and year(ngayban)= '" + nam + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoNam(int nam)
        {
            string query = "select * from HoaDonBan where year(ngayban)= '" + nam + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoMaNV(string manv)
        {
            string query = "select * from HoaDonBan where manv like '%" + manv + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoTenkhach(string ten)
        {
            string query = "select * from HoaDonBan where tenkhach like N'%" + ten + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoTien(double tien)
        {
            string query = "select * from HoaDonBan where tongtien > '" + tien + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoManvvaTien(string manv, double tien)
        {
            string query = "select * from HoaDonBan where manv like '%" + manv + "%' and tongtien > '" + tien + "' ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoMahdvaTien(string mahd, double tien)
        {
            string query = "select * from HoaDonBan where mahd like '%" + mahd + "%' and tongtien > '" + tien + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindMahdvaThangNam(string ma, int thang, int nam)
        {
            string query = "select * from HoaDonBan where mahd like '%" + ma + "%' and month(ngayban)= '" + thang + "' and year(ngayban)= '" + nam + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetDataToTable2(string mahd)
        {
            string query = "select * from ChiTietHDB where mahd='"+mahd+"'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public string GetMaNV(string mahd)
        {
            string query = "select manv from HoaDonBan where mahd='"+mahd+"'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetNgayban(string ma)
        {
            string query = "select ngayban from HoaDonBan where mahd='"+ma+"'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetTenKhach(string ma)
        {
            string query = "select tenkhach from HoaDonBan where mahd='"+ma+"'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetSdt(string ma)
        {
            string query = "select sdtkhach from HoaDonBan where mahd='"+ma+"'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetDc(string ma)
        {
            string query = "select dckhach from HoaDonBan where mahd='"+ma+"'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetTien(string ma)
        {
            string query = "select tongtien from HoaDonBan where mahd='"+ma+"'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public void DeleteHD(string mahd)
        {
            string query = "delete from HoaDonBan where MaHD='" + mahd + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public DataTable StatisticBantheoNgay()
        {
            string query = $"select (ngayban) as [Ngày bán],sum (tongtien) as [Tổng tiền] from HoaDonBan group by (ngayban)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable StatisticBantheoThang()
        {
            string query = $"select month(ngayban) as [Tháng bán],sum (tongtien) as [Tổng tiền] from HoaDonBan group by month(ngayban)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable StatisticBantheoNam()
        {
            string query = $"select year(ngayban) as [Năm bán],sum (tongtien) as [Tổng tiền] from HoaDonBan group by year(ngayban)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

    }
}
