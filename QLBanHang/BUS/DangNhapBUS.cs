
using QLBanHang.DAL;
using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS
{
    public class DangNhapBUS
    {
        DangNhapDAL dndal = new DangNhapDAL();
        public bool dangNhap(string tendn, int matkhau)
        {
            return dndal.dangNhap(tendn, matkhau);
        }
        public bool dangNhap(string tendn)
        {
            return dndal.dangNhap(tendn);
        }
        public bool LoginwithBoss(string tenDN)
        {
            return dndal.LoginwithBoss(tenDN);
        }
        public bool LoginwithStaff(string tenDN)
        {
            return dndal.LoginwithStaff(tenDN);
        }
        public void UpdatePassword( string tendn, TaiKhoan tk)
        {
            dndal.UpdatePassword( tendn,tk);
        }
        public void SignUp(TaiKhoan tk)
        {
            dndal.SignUp(tk);
        }
        public bool CheckKey(string tendn)
        {
            return dndal.CheckKey(tendn);
        }
        public DataTable GetDSUser()
        {
            return dndal.GetDSUser();
        }
    }
}
