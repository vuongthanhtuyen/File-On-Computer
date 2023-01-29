using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DTO
{
    public  class Account
    {
        private string username;
        private string passWord;
        private string dispalyName;
        private int type;

        public Account(string username, string dispalyName, int type, string passWord = null)
        {
            this.Username = username;
            this.PassWord = passWord;
            this.DispalyName = dispalyName;
            this.Type = type;
        }
            public Account(DataRow row)
            {
                this.Username = (string)row["username"];
                this.PassWord = (string)row["passWord"];
                this.DispalyName = (string)row["displayName"];
                this.Type = (int)row["type"];
            }

        public string Username { get => username; set => username = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string DispalyName { get => dispalyName; set => dispalyName = value; }
        public int Type { get => type; set => type = value; }
    }
}
