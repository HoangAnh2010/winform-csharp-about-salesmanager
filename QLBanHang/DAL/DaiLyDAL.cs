using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    class DaiLyDAL
    {
        public DataTable GetDataToTable()
        {
            string query = "select * from DaiLy";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void DeleteDaiLy(string ma)
        {
            string query = "delete from DaiLy where MaDL='" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public bool CheckKey(string ma)
        {
            string query = "select MaDL from DaiLy where MaDL='" + ma + "' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public void SaveDL(DaiLy dl)
        {
            string query = "insert into DaiLy(madl,tendl,sdt,diachi) values('" + dl.MaDL + "',N'" + dl.TenDL + "','" + dl.Sdt + "',N'" + dl.Dc + "')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void UpdateDL(string ma, DaiLy dl)
        {
            string query = "update DaiLy set TenDL=N'" + dl.TenDL + "',Sdt='" + dl.Sdt + "',DiaChi=N'" + dl.Dc + "' where MaDL='" + dl.MaDL + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
