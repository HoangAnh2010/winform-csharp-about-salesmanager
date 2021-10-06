using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DTO
{
    public class DaiLy
    {
        public DaiLy(string maDL, string tenDL, string sdt, string dc)
        {
            this.MaDL = maDL;
            this.TenDL = tenDL;
            this.Sdt = sdt;
            this.Dc = dc;
        }
        public DaiLy()
        {

        }
        private string maDL;
        private string tenDL;
        private string sdt;
        private string dc;

        public string MaDL { get => maDL; set => maDL = value; }
        public string TenDL { get => tenDL; set => tenDL = value; }
        public string Dc { get => dc; set => dc = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
