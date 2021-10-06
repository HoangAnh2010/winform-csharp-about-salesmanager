using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DAL;
using QLBanHang.DTO;

namespace QLBanHang.BUS
{
    public class HoaDonBanBUS
    {
        private string currentKey;
        HoaDonBanDAL hdbdal = new HoaDonBanDAL();

        public HoaDonBanBUS()
        {
            this.currentKey = GetKey();
        }

        public string GetTenNVtheoMaNV(string manv)
        {
            return hdbdal.GetTenNVtheoMaNV(manv);
        }
        
        public string GetTenSPtheoMaSP(string masp)
        {
            return hdbdal.GetTenSPtheoMaSP(masp);
        }
        public string GetGiatheoMaSP(string masp)
        {
            return hdbdal.GetGiatheoMaSP(masp);
        }
        public DataTable GetDataToTable(string mahd, string masp)
        {
            return hdbdal.GetDataToTable(mahd, masp);
        }
        public DataTable GetMaNV()
        {
            return hdbdal.GetMaNV();
        }
        
        public DataTable GetMaSP()
        {
            return hdbdal.GetMaSP();
        }

        public string GetKey()
        {
            return hdbdal.CreateKey("HDB");
        }

        public string CreateKey(string tiento)
        {
            int t = int.Parse(this.currentKey.Replace("HDB", "")) + 1;
            this.currentKey = tiento + t;
            return this.currentKey;
        }
        public bool CheckMaHDB(string maHDB)
        {
            return hdbdal.CheckMaHDB(maHDB);
        }
        public bool CheckMaHDandMaSP(string mahd, string masp, List<CTHoaDonBan> chitiets)
        {
            return chitiets.Find(x => x.MaSP == masp && x.MaHDB == mahd) == null;
            
        }
        public int TangSoLuong ( string masp, List<CTHoaDonBan> chitiets, int soluong)
        {            
            return chitiets.FirstOrDefault(x => x.MaSP == masp).SoLg += soluong;
            
        }
        public double UpdateThanhTien(string masp, List<CTHoaDonBan> chitiets, double thanhtien)
        {
            return chitiets.FirstOrDefault(x => x.MaSP == masp).ThanhTien += thanhtien;

        }
        public int SoLuong(string masp, List<CTHoaDonBan> chitiets, int soluong)
        {
            return chitiets.FirstOrDefault(x => x.MaSP == masp).SoLg;
        }
        public int Index(string masp, List<CTHoaDonBan> chitiets)
        {
            return chitiets.FindLastIndex(x => x.MaSP == masp);
        }
        public void SaveHDB(HoaDonBan hdb)
        {
            hdbdal.SaveHDB(hdb);
        }
        public DataTable GetDataToTable(string mahd)
        {
            return hdbdal.GetDataToTable(mahd);
        }
        public DataTable GetDataToTable1(string mahd)
        {
            return hdbdal.GetDataToTable1(mahd);
        }
        public DataTable FindtheoMa(string mahd)
        {
            return hdbdal.FindtheoMa(mahd);
        }
        public DataTable FindtheoThangvaNam(int thang, int nam)
        {
            return hdbdal.FindtheoThangvaNam(thang, nam);
        }
        public DataTable FindtheoNam(int nam)
        {
            return hdbdal.FindtheoNam(nam);
        }
        public DataTable FindtheoMaNV(string manv)
        {
            return hdbdal.FindtheoMaNV(manv);
        }
        public DataTable FindtheoTenkhach(string ten)
        {
            return hdbdal.FindtheoTenkhach(ten);
        }
        public DataTable FindtheoTien(double tien)
        {
            return hdbdal.FindtheoTien(tien);
        }
        public DataTable FindtheoManvvaTien(string manv, double tien)
        {
            return hdbdal.FindtheoManvvaTien(manv, tien);
        }
        public DataTable FindtheoMahdvaTien(string mahd, double tien)
        {
            return hdbdal.FindtheoMahdvaTien(mahd, tien);   
        }
        public DataTable FindMahdvaThangNam(string ma, int thang, int nam)
        {
            return hdbdal.FindMahdvaThangNam(ma, thang, nam);
        }
        public DataTable GetDataToTable2(string mahd)
        {
            return hdbdal.GetDataToTable2(mahd);
        }
        public string GetMaNV(string mahd)
        {
            return hdbdal.GetMaNV(mahd);
        }
        public string GetNgayban(string ma)
        {
            return hdbdal.GetNgayban(ma);
        }
        public string GetTenKhach(string ma)
        {
            return hdbdal.GetTenKhach(ma);
        }
        public string GetSdt(string ma)
        {
            return hdbdal.GetSdt(ma);
        }
        public string GetDc(string ma)
        {
            return hdbdal.GetDc(ma);
        }
        public string GetTien(string ma)
        {
            return hdbdal.GetTien(ma);
        }
        public void DeleteHD(string mahd)
        {
            hdbdal.DeleteHD(mahd);
        }
        public DataTable StatisticBantheoNgay()
        {
            return hdbdal.StatisticBantheoNgay();
        }
        public DataTable StatisticBantheoThang()
        {
            return hdbdal.StatisticBantheoThang();
        }
        public DataTable StatisticBantheoNam()
        {
            return hdbdal.StatisticBantheoNam();
        }
    }
}
