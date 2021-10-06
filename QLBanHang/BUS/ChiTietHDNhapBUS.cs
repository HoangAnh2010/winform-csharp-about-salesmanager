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
    class ChiTietHDNhapBUS
    {
        ChiTietHDNhapDAL ctdal = new ChiTietHDNhapDAL();
        public bool CheckMaSP(string masp)
        {
            return ctdal.CheckMaSP(masp);
        }
        public string GetSoLgCo(string masp)
        {
            return ctdal.GetSoLgCo(masp);
        }
        public void SaveChiTietHDN(ChiTietHDNhap ct)
        {
            ctdal.SaveChiTietHDN(ct);
        }
        public void CapNhatSoLg(string masp, int solgcon)
        {
            ctdal.CapNhatSoLg(masp, solgcon);
        }
        public void CapNhatTongTien(string mahd, double tongTien)
        {
            ctdal.CapNhatTongTien(mahd, tongTien);
        }
        public void DeleteSP(string mahd, string maspxoa)
        {
            ctdal.DeleteSP(mahd, maspxoa);
        }
        public void CapNhatSoLgSauXoa(string maspxoa, int slg)
        {
            ctdal.CapNhatSoLgSauXoa(maspxoa, slg);
        }
        public string ThemNhieuCTHDN(List<ChiTietHDNhap> cTHoaDonNhap)
        {
            return ctdal.ThemCTHDNhap(cTHoaDonNhap);
        }
        public DataTable GetSoLgBan(string mahd)
        {
            return ctdal.GetSoLgBan(mahd);
        }
        public void DeleteCT(string mahd)
        {
            ctdal.DeleteCT(mahd);
        }
    }
}
