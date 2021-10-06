using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DTO
{
    public class CTHoaDonBan
    {
        private string maHDB;
        private string maSP;
        private int soLg;
        private double giaBan;
        private double thanhTien;
        public CTHoaDonBan(string maHDB, string maSP, int soLg, double giaBan, double thanhTien)
        {
            this.MaHDB = maHDB;
            this.MaSP = maSP;
            this.SoLg = soLg;
            this.GiaBan = giaBan;
            this.ThanhTien = thanhTien;
        }
        public CTHoaDonBan()
        {

        }
        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLg { get => soLg; set => soLg = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        
    }
}
