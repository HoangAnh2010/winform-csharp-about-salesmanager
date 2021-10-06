using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DTO
{
    public class SanPham
    {
        public SanPham(string masp, string tensp, string maloai, DateTime nsx, DateTime hsd, int solg, double dongia)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.MaLoai = maloai;
            this.Nsx = nsx;
            this.Hsd = hsd;
            this.SoLg = solg;
            this.DonGia = dongia;
        }
        public SanPham()
        {

        }
        private string maSP;
        private string tenSP;
        private string maLoai;
        private DateTime nsx;
        private DateTime hsd;
        private int soLg;
        private double donGia;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public DateTime Nsx { get => nsx; set => nsx = value; }
        public DateTime Hsd { get => hsd; set => hsd = value; }
        public int SoLg { get => soLg; set => soLg = value; }
        public double DonGia { get => donGia; set => donGia = value; }
    }
}
