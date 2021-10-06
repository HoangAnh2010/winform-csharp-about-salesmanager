using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DTO
{
    public class NhanVien
    {
        public NhanVien(string maNV, string tenNV, string sdt, string diaChi, string tenDN)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.TenDN = tenDN;
        }
        public NhanVien()
        {

        }
        private string maNV;
        private string tenNV;
        private string sdt;
        private string diaChi;
        private string tenDN;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
    }
}
