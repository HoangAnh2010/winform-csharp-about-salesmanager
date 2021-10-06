using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DTO
{
    public class HoaDonBan
    {
        public HoaDonBan(string maHDB, DateTime ngayBan, string maNV, string tenKhach, string sdtKhach, string dcKhach, double tongTienTT)
        {
            this.MaHDB = maHDB;
            this.NgayBan = ngayBan;
            this.MaNV = maNV;
            this.TenKhach = tenKhach;
            this.SdtKhach = sdtKhach;
            this.DcKhach = dcKhach;
            this.TongTienTT = tongTienTT;
        }
        public HoaDonBan()
        {

        }
        private string maHDB;
        private DateTime ngayBan;
        private string maNV;
        private string tenKhach;
        private string sdtKhach;
        private string dcKhach;
        private double tongTienTT;

        public string MaHDB { get => maHDB; set => maHDB = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string SdtKhach { get => sdtKhach; set => sdtKhach = value; }
        public string DcKhach { get => dcKhach; set => dcKhach = value; }
        public double TongTienTT { get => tongTienTT; set => tongTienTT = value; }
        
    }
}
