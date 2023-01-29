using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DAO
{
    public class AccountDAO
    { 
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get{if(instance==null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }

        }
        
        public bool Login(string username, string password)
        {
            string query = "USP_Login @userName , @passWork";
            DataTable result = DataProvider.Instance.ExecuteQuyre(query, new object[] {username,password});
            return result.Rows.Count>0;
        }

        public bool UpdateAccount(string username, string password, string newpassword, string disPlayname)
        {
            int result = DataProvider.Instance.ExecuteNonQuyre("EXEC USP_UpdateAccount @displayName , @username , @password , @newpassword ", new object[] {disPlayname,username,password,newpassword});
            return result>0;
        }
        public Account GetAccountByUsername( string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuyre(" Select * from Account where Username = '"+ username+"'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
