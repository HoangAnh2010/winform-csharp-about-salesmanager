using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DAL
{
    public class DataProvider
    {
        private static DataProvider instance; //Ctrl + R + E --dong goi 
        public string connectionStr = @"Data Source=LAPTOP-SVECSKKU\MSSQLSERVER01;Initial Catalog=10119730_NguyenHoangAnh;Integrated Security=True";
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public void ExcuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public string ExecuteReader(string query)
        {

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                string data = "";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                        data = reader.GetValue(0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
                return data;
            }
        }

        public string ExcuteProcedure(string storedName, params object[] argsm)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(storedName, connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(command);
            for (int i = 1; i < command.Parameters.Count; i++)
            {
                command.Parameters[i].Value = argsm[i - 1];
            }
            int ressult = command.ExecuteNonQuery();
            return ressult > 0 ? "Lưu thành công!" : "Lưu không thành công!";
        }
    }
}
