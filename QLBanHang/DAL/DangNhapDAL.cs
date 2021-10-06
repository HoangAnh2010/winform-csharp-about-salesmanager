using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAL
{
    public class DangNhapDAL
    {
        public bool dangNhap(string tendn, int matkhau)
        {
            string query = "select TenDN,MatKhau from TaiKhoan where TenDN='" + tendn + "' and MatKhau='" + matkhau + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tendn, matkhau });
            return result.Rows.Count > 0;
        }
        public bool dangNhap(string tendn)
        {
            string query = "select * from TaiKhoan where TenDN='" + tendn + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tendn});
            return result.Rows.Count > 0;
        }
        public bool LoginwithBoss(string tenDN)
        {
            string query = "select * from TaiKhoan where TenDN='" + tenDN + "' and Loaitk=N'Chủ shop'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenDN });
            return data.Rows.Count > 0;
        }
        public bool LoginwithStaff(string tenDN)
        {
            string query = "select * from TaiKhoan where TenDN='" + tenDN + "' and Loaitk=N'Nhân viên'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenDN });
            return data.Rows.Count > 0;
        }
        public void UpdatePassword( string tendn, TaiKhoan tk)
        {
            string query = $"update TaiKhoan set matkhau='{tk.MatKhau}' where tendn='{tendn}'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public bool CheckKey(string tendn)
        {
            string query = "select * from TaiKhoan where tendn='"+tendn+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public void SignUp(TaiKhoan tk)
        {
            string query = "insert into TaiKhoan(tendn,matkhau,loaitk) values('"+tk.TenDN+"', "+tk.MatKhau+", N'"+tk.LoaiTK+"')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public DataTable GetDSUser()
        {
            string query = "select tk.tendn as [Tên đăng nhập],tennv as [Họ tên nhân viên], sdt as [Số điện thoại],diachi as [Địa chỉ], loaitk as [Loại tài khoản] from TaiKhoan tk left join NhanVien nv on tk.tendn = nv.tendn";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
