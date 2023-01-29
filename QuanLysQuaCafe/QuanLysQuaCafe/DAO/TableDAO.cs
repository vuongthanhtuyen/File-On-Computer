using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static int TableWight = 120;
        public static int TableHeight = 60; 
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { instance = value; }

        }
        private TableDAO()
        {

        }
        public void SwitchTable(int id1, int id2)
        {
            DataTable data = DataProvider.Instance.ExecuteQuyre("USP_SwitchTable @idTable1 , @idTable2 ",new object[] { id1,id2});




        }
        public List<Table> LoadTablelist()
        {
             List<Table> TableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuyre("USP_GetlistTable");

            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                TableList.Add(table);
            }

            return TableList;
        }
    }
}
