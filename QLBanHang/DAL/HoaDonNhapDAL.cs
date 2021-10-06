using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    class HoaDonNhapDAL
    {
        public string GetTenDLtheoMaDL(string ma)
        {
            string query = "select tendl from Daily where madl='" + ma + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetSdttheoMaDL(string ma)
        {
            string query = "select sdt from Daily where madl='" + ma + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetDiachitheoMaDL(string ma)
        {
            string query = "select diachi from Daily where madl='" + ma + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetTenSPtheoMaSP(string masp)
        {
            string query = "select TenSP from SanPham where MaSP='" + masp + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }        
        public DataTable GetDataToTable(string mahd, string masp)
        {
            string query = "select ct.MaSP,sp.TenSP,ct.solg,gianhap,ct.ThanhTien from SanPham sp inner join ChiTietHDN ct on sp.MaSP = ct.MaSP where ct.MaHD = '" + mahd + "'and sp.MaSP = '" + masp + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        
        public DataTable GetMaSP()
        {
            string query = "select MaSP from SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetMaDL()
        {
            string query = "select Madl from DaiLy";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public string CreateKey(string tiento)
        {
            string key = DataProvider.Instance.ExecuteReader("select dbo.SP_getPrevKeyHDN()");
            if (key == "")
                return tiento + "0";
            key = key.Replace("HDN", "");
            int tempt = int.Parse(key);
            return tiento + tempt.ToString();
        }
        public bool CheckMaHDN(string maHD)
        {
            string query = "select MaHD from HoaDonNhap where MaHD='" + maHD + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public bool CheckMaHDandMaSP(string mahd, string masp)
        {
            string query = "select mahd,masp from ChiTietHDN where mahd='" + mahd + "' and masp='" + masp + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public void SaveHDN(HoaDonNhap hd)
        {
            string query = $"insert into HoaDonNhap values('{hd.MaHDN}',Cast('{hd.NgayNhap.ToString("MM / dd / yyyy")}' as datetime),'{hd.MaDL}','{hd.TongTien}')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public DataTable GetDataToTable(string mahd)
        {
            string query = "select hd.mahd,ngaynhap,tongtien,tendl,sdt,diachi from HoaDonNhap hd inner join Daily dl on hd.madl = dl.madl where hd.mahd = '" + mahd + "' and hd.madl = dl.madl";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetDataToTable1(string mahd)
        {
            string query = "select tensp,solg,gianhap,thanhtien from ChiTietHDN ct inner join SanPham sp on ct.masp = sp.masp where mahd = '" + mahd + "' and ct.masp = sp.masp";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoMa(string mahd)
        {
            string query = "select * from HoaDonNhap where mahd like '%" + mahd + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoThangvaNam(int thang, int nam)
        {
            string query = "select * from HoaDonNhap where month(ngaynhap)= '" + thang + "' and year(ngaynhap)= '" + nam + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoNam(int nam)
        {
            string query = "select * from HoaDonNhap where year(ngaynhap)= '" + nam + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public DataTable FindtheoTenDL(string ten)
        {
            string query = "select *from HoaDonNhap hd inner join DaiLy dl on hd.madl=dl.madl where tendl like N'%"+ten+"%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoDcDL(string dc)
        {
            string query = "select * from HoaDonNhap hd inner join DaiLy dl on hd.madl=dl.madl where diachi like N'%" + dc + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoTien(double tien)
        {
            string query = "select * from HoaDonNhap where tongtien > '" + tien + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoTenvaTien(string ten, double tien)
        {
            string query = "select * from HoaDonNhap where madl like '%" + ten + "%' and tongtien > '" + tien + "' ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindtheoMahdvaTien(string mahd, double tien)
        {
            string query = "select * from HoaDonNhap where mahd like '%" + mahd + "%' and tongtien > '" + tien + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable FindMahdvaThangNam(string ma, int thang, int nam)
        {
            string query = "select * from HoaDonNhap where mahd like '%" + ma + "%' and month(ngaynhap)= '" + thang + "' and year(ngaynhap)= '" + nam + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetDataToTable2(string mahd)
        {
            string query = "select * from ChiTietHDN where mahd='" + mahd + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public string GetMaDL(string mahd)
        {
            string query = "select madl from HoaDonNhap where mahd='" + mahd + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string GetNgayNhap(string ma)
        {
            string query = "select ngaynhap from HoaDonNhap where mahd='" + ma + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        
        public string GetTien(string ma)
        {
            string query = "select tongtien from HoaDonNhap where mahd='" + ma + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public void DeleteHD(string mahd)
        {
            string query = "delete from HoaDonnhap where MaHD='" + mahd + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public DataTable StatisticNhaptheoNgay()
        {            
            string query = $"select (ngaynhap) as [Ngày nhập],sum (tongtien) as [Tổng tiền] from HoaDonNhap group by (ngaynhap)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable StatisticNhaptheoThang()
        {
            string query = $"select month(ngaynhap) as [Tháng nhập],sum (tongtien) as [Tổng tiền] from HoaDonNhap group by month(ngaynhap)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable StatisticNhaptheoNam()
        {
            string query = $"select year(ngaynhap) as [Năm nhập],sum (tongtien) as [Tổng tiền] from HoaDonNhap group by year(ngaynhap)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
