using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    class ChiTietHDNhapDAL
    {
        public bool CheckMaSP(string masp)
        {
            string query = "select MaSP from ChiTietHDN where MaSP='" + masp + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public string GetSoLgCo(string masp)
        {
            string query = "select SoLuongco from SanPham where MaSP='" + masp + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public void SaveChiTietHDN(ChiTietHDNhap ct)
        {
            string query = $"insert into ChiTietHDN values(N'{ct.MaHD}','{ct.MaSP}','{ct.SoLg}','{ct.GiaNhap}','{ct.ThanhTien}')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void CapNhatSoLg(string masp, int solgcon)
        {
            string query = "update SanPham set SoLuongco='" + solgcon + "' where MaSP='" + masp + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void CapNhatTongTien(string mahd, double tongTien)
        {
            string query = "update HoaDonNhap set TongTien='" + tongTien + "' where MaHD='" + mahd + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DeleteSP(string mahd, string maspxoa)
        {
            string query = "delete from ChiTietHDN where MaHD='" + mahd + "' and MaSP='" + maspxoa + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void CapNhatSoLgSauXoa(string maspxoa, int slg)
        {
            string query = "update SanPham set SoLuongco='" + slg + "' where MaSP='" + maspxoa + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public string ThemCTHDNhap(List<ChiTietHDNhap> cTHoaDonNhap)
        {
            string jsonString = JsonSerializer.Serialize(cTHoaDonNhap);
            return DataProvider.Instance.ExcuteProcedure("SP_insertHDNhap", jsonString);

        }
        public DataTable GetSoLgBan(string mahd)
        {
            string query = "select masp,SoLg from ChiTietHDN where Mahd='" + mahd + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void DeleteCT(string mahd)
        {
            string query = "delete from ChiTietHDN where MaHD='" + mahd + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
