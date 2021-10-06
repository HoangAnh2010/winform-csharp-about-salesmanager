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
    public class NhanVienBUS
    {
        NhanVienDAL nvdal = new NhanVienDAL();
        public DataTable GetDataToTable()
        {
            return nvdal.GetDataToTable();
        }
        public bool CheckKey(string ma)
        {
            return nvdal.CheckKey(ma);
        }
        public bool CheckTenDN(string tendn)
        {
            return nvdal.CheckTenDN(tendn);
        }
        public bool CheckTenDN2(string tendn)
        {
            return nvdal.CheckTenDN2(tendn);
        }
        public void SaveNV(NhanVien nv)
        {
            nvdal.SaveNV(nv);
        }
        public void UpdateNV(string ma, NhanVien nv)
        {
            nvdal.UpdateNV(ma, nv);
        }
        public void DeleteNhanVien(string ma)
        {
            nvdal.DeleteNhanVien(ma);
        }
    }
}
