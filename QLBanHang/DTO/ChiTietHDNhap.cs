using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DTO
{
    public class ChiTietHDNhap
    {
        public ChiTietHDNhap(string maHD, string maSP, int soLg, double giaNhap, double thanhTien)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SoLg = soLg;
            this.GiaNhap = giaNhap;
            this.ThanhTien = thanhTien;
        }
        public ChiTietHDNhap()
        {

        }
        private string maHD;
        private string maSP;
        private int soLg;
        private double giaNhap;
        private double thanhTien;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLg { get => soLg; set => soLg = value; }
        public double GiaNhap { get => giaNhap; set => giaNhap = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
