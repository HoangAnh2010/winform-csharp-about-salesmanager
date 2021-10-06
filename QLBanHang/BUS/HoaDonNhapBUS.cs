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
    class HoaDonNhapBUS
    {
        private string currentKey;
        HoaDonNhapDAL hdndal = new HoaDonNhapDAL();

        public HoaDonNhapBUS()
        {
            this.currentKey = GetKey();
        }

        public string GetTenDLtheoMaDL(string ma)
        {
            return hdndal.GetTenDLtheoMaDL(ma);
        }
        public string GetSdttheoMaDL(string ma)
        {
            return hdndal.GetSdttheoMaDL(ma);
        }
        public string GetDiachitheoMaDL(string ma)
        {
            return hdndal.GetDiachitheoMaDL(ma);
        }
        public string GetTenSPtheoMaSP(string masp)
        {
            return hdndal.GetTenSPtheoMaSP(masp);
        }

        public DataTable GetDataToTable(string mahd, string masp)
        {
            return hdndal.GetDataToTable(mahd, masp);
        }

        public DataTable GetMaSP()
        {
            return hdndal.GetMaSP();
        }
        public DataTable GetMaDL()
        {
            return hdndal.GetMaDL();
        }

        public string GetKey()
        {
            return hdndal.CreateKey("HDN");
        }

        public string CreateKey(string tiento)
        {
            int t = int.Parse(this.currentKey.Replace("HDN", "")) + 1;
            this.currentKey = tiento + t;
            return this.currentKey;
        }
        public bool CheckMaHDN(string maHD)
        {
            return hdndal.CheckMaHDN(maHD);
        }
        
        public bool CheckMaHDandMaSP(string mahd, string masp, List<ChiTietHDNhap> chitiets)
        {
            return chitiets.Find(x => x.MaSP == masp && x.MaHD == mahd) == null;
        }
        public void SaveHDN(HoaDonNhap hd)
        {
            hdndal.SaveHDN(hd);
        }
        public DataTable GetDataToTable(string mahd)
        {
            return hdndal.GetDataToTable(mahd);
        }
        public DataTable GetDataToTable1(string mahd)
        {
            return hdndal.GetDataToTable1(mahd);
        }
        public DataTable FindtheoMa(string mahd)
        {
            return hdndal.FindtheoMa(mahd);
        }
        public DataTable FindtheoThangvaNam(int thang, int nam)
        {
            return hdndal.FindtheoThangvaNam(thang, nam);
        }
        public DataTable FindtheoNam(int nam)
        {
            return hdndal.FindtheoNam(nam);
        }

        public DataTable FindtheoTenDL(string ten)
        {
            return hdndal.FindtheoTenDL(ten);
        }
        public DataTable FindtheoDcDL(string dc)
        {
            return hdndal.FindtheoDcDL(dc);
        }
        public DataTable FindtheoTien(double tien)
        {
            return hdndal.FindtheoTien(tien);
        }
        public DataTable FindtheoTenvaTien(string ten, double tien)
        {
            return hdndal.FindtheoTenvaTien(ten, tien);
        }
        public DataTable FindtheoMahdvaTien(string mahd, double tien)
        {
            return hdndal.FindtheoMahdvaTien(mahd, tien);
        }
        public DataTable FindMahdvaThangNam(string ma, int thang, int nam)
        {
            return hdndal.FindMahdvaThangNam(ma, thang, nam);
        }
        public DataTable GetDataToTable2(string mahd)
        {
            return hdndal.GetDataToTable2(mahd);
        }
        public string GetMaDL(string mahd)
        {
            return hdndal.GetMaDL(mahd);
        }
        public string GetNgayNhap(string ma)
        {
            return hdndal.GetNgayNhap(ma);
        }

        public string GetTien(string ma)
        {
            return hdndal.GetTien(ma);
        }
        public void DeleteHD(string mahd)
        {
            hdndal.DeleteHD(mahd);
        }
        public DataTable StatisticNhaptheoNgay()
        {
            return hdndal.StatisticNhaptheoNgay();
        }
        public DataTable StatisticNhaptheoThang()
        {
            return hdndal.StatisticNhaptheoThang();
        }
        public DataTable StatisticNhaptheoNam()
        {
            return hdndal.StatisticNhaptheoNam();
        }
    }
}
