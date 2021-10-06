using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(string tenDN, int matKhau, string loaiTK)
        {
            this.TenDN = tenDN;
            this.MatKhau = matKhau;
            this.LoaiTK = loaiTK;
        }
        public TaiKhoan(string tenDN, int matKhau)
        {
            this.TenDN = tenDN;
            this.MatKhau = matKhau;
        }
        public TaiKhoan()
        {

        }

        private string tenDN;
        private int matKhau;
        private string loaiTK;

        public string TenDN { get => tenDN; set => tenDN = value; }
        public int MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiTK { get => loaiTK; set => loaiTK = value; }
    }
}
