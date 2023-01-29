using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLysQuaCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;// ctrl + E + R
      private string stringconnext = @"Data Source=VTT\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        public static DataProvider Instance { 
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } 
            private set { DataProvider.instance = value; } 
        }
        private DataProvider() 
        {
        }
        public DataTable ExecuteQuyre(string query, object[] parameter = null)
        {
            DataTable dataTable = new DataTable();
            using ( SqlConnection connection = new SqlConnection(stringconnext)){
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                        string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item,parameter[i]);
                            i++;
                        }  
                    }
                }
                SqlDataAdapter sqlDataReader = new SqlDataAdapter(command);
                sqlDataReader.Fill( dataTable);
                connection.Close(); 
            }
            return dataTable;
        }
        public int ExecuteNonQuyre(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(stringconnext))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(stringconnext))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
