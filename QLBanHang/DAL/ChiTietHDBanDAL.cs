using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QLBanHang.DAL
{
    class ChiTietHDBanDAL
    {
        public bool CheckMaSP(string masp)
        {
            string query = "select MaSP from ChiTietHDB where MaSP='" + masp + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public string GetSoLgCo(string masp)
        {
            string query = "select SoLuongco from SanPham where MaSP='" + masp + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public void SaveChiTietHDB(CTHoaDonBan ct)
        {
            string query = $"insert into ChiTietHDB values(N'{ct.MaHDB}','{ct.MaSP}','{ct.SoLg}','{ct.GiaBan}','{ct.ThanhTien}')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void CapNhatSoLg(string masp, int solgcon)
        {
            string query = "update SanPham set SoLuongco='" + solgcon + "' where MaSP='" + masp + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void CapNhatTongTien(string mahd, double tongTien)
        {
            string query = "update HoaDonBan set TongTien='" + tongTien + "' where MaHD='" + mahd + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DeleteSP(string mahdb, string maspxoa)
        {
            string query = "delete from ChiTietHDB where MaHD='" + mahdb + "' and MaSP='" + maspxoa + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void CapNhatSoLgSauXoa(string maspxoa, int slg)
        {
            string query = "update SanPham set SoLuongco='" + slg + "' where MaSP='" + maspxoa + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public string ThemCTHDBans(List<CTHoaDonBan> cTHoaDonBans)
        {
            string jsonString = JsonSerializer.Serialize(cTHoaDonBans);
            return DataProvider.Instance.ExcuteProcedure("SP_insertHDBan", jsonString);
        }
        public DataTable GetSoLgBan(string mahd)
        {
            string query = "select masp,SoLg from ChiTietHDB where Mahd='" + mahd + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void DeleteCT(string mahdb)
        {
            string query = "delete from ChiTietHDB where MaHD='" + mahdb + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
