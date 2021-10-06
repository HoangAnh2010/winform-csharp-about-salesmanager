using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DTO
{
    public class HoaDonNhap
    {
        public HoaDonNhap(string maHDN, DateTime ngayNhap, string maDL, double tongTien)
        {
            this.MaHDN = maHDN;
            this.NgayNhap = ngayNhap;
            this.MaDL = maDL;
            this.TongTien = tongTien;
        }
        public HoaDonNhap()
        {

        }
        private string maHDN;
        private DateTime ngayNhap;
        private string maDL;
        private double tongTien;

        public string MaHDN { get => maHDN; set => maHDN = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string MaDL { get => maDL; set => maDL = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
    }
}
