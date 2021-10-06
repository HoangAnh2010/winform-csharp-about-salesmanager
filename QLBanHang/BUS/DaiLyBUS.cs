using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DAL;
using QLBanHang.DTO;
using System.Data;
namespace QLBanHang.BUS
{
    class DaiLyBUS
    {
        DaiLyDAL dldal = new DaiLyDAL();
        public DataTable GetDataToTable()
        {
            return dldal.GetDataToTable();
        }
        public void DeleteDaiLy(string ma)
        {
            dldal.DeleteDaiLy(ma);
        }
        public bool CheckKey(string ma)
        {
            return dldal.CheckKey(ma);
        }
        public void SaveDL(DaiLy dl)
        {
            dldal.SaveDL(dl);
        }
        public void UpdateDL(string ma, DaiLy dl)
        {
            dldal.UpdateDL(ma, dl);
        }
    }
}
