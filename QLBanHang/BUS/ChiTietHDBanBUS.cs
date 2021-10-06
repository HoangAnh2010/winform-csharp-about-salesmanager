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
    class ChiTietHDBanBUS
    {
        ChiTietHDBanDAL ctdal = new ChiTietHDBanDAL();
        public bool CheckMaSP(string masp)
        {
            return ctdal.CheckMaSP(masp);
        }
        public string GetSoLgCo(string masp)
        {
            return ctdal.GetSoLgCo(masp);
        }
        public void SaveChiTietHDB(CTHoaDonBan ct)
        {
            ctdal.SaveChiTietHDB(ct);
        }
        public void CapNhatSoLg(string masp, int solgcon)
        {
            ctdal.CapNhatSoLg(masp, solgcon);
        }
        public bool CapNhatSoLuong(string masp, List<CTHoaDonBan> chitiets, int solgcon)
        {
            return chitiets.FirstOrDefault(x => x.MaSP == masp).SoLg>solgcon - chitiets.FirstOrDefault(x => x.MaSP == masp).SoLg;
        }
        

        public void CapNhatTongTien(string mahd, double tongTien)
        {
            ctdal.CapNhatTongTien(mahd, tongTien);
        }
        public void DeleteSP(string mahdb, string maspxoa)
        {
            ctdal.DeleteSP(mahdb, maspxoa);
        }
        public void CapNhatSoLgSauXoa(string maspxoa, int slg)
        {
            ctdal.CapNhatSoLgSauXoa(maspxoa, slg);
        }
        public string ThemNhieuCTHDB(List<CTHoaDonBan> cTHoaDonBans)
        {
            return ctdal.ThemCTHDBans(cTHoaDonBans);
        }
        public DataTable GetSoLgBan(string mahd)
        {
            return ctdal.GetSoLgBan(mahd);
        }
        public void DeleteCT(string mahdb)
        {
             ctdal.DeleteCT(mahdb);
        }
    }
}
