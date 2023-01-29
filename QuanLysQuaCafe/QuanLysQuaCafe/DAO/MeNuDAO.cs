using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DAO
{
    public class MeNuDAO
    {
        private static MeNuDAO instance;
        public static MeNuDAO Instance
        {
            get { if (instance == null) instance = new MeNuDAO(); return instance; }
            private set { MeNuDAO.instance = value; }
        }
        public MeNuDAO() { }
        public List<Menu> GetListMenuByTable (int id)
        {
            string query = "SELECT f.name , bf.count,f.Price, f.Price*bf.count AS Total FROM dbo.BillInfo AS bf,Bill AS b,dbo.Food AS f WHERE bf.idBill = b.id AND bf.idFood= f.id AND b.status = 0 AND b.idTable = " + id;
            List<Menu> listMenu = new List<Menu>();
            DataTable data = DataProvider.Instance.ExecuteQuyre(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
