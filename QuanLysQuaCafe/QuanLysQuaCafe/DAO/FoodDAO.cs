using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO()
        {
             
        }
        public List<Food> GetListCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM dbo.Food WHERE idCatogory = " +id;
            DataTable data = DataProvider.Instance.ExecuteQuyre(query); 
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM dbo.Food ";
            DataTable data = DataProvider.Instance.ExecuteQuyre(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("SELECT * FROM dbo.Food WHERE name = N'{0}'",name);
            DataTable data = DataProvider.Instance.ExecuteQuyre(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string name,int idCatogory, float price)
        {
            string query = string.Format("INSERT dbo.Food(name, idCatogory, Price)VALUES(   N'{0}', {1},  {2} )",name,idCatogory,price);
            int result = DataProvider.Instance.ExecuteNonQuyre(query);
            return result > 0;
        }
        public bool UpdatetFood(int id,string name, int idCatogory, float price)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCatogory = {1}, Price = {2} WHERE id = {3}", name, idCatogory, price, id);
            int result = DataProvider.Instance.ExecuteNonQuyre(query);
            return result > 0;
        }
        public bool DeletefoodById(int id)
        {
            string query = string.Format("	DELETE dbo.Food WHERE id = "+ id);
            int result = DataProvider.Instance.ExecuteNonQuyre(query);
            return result > 0;
        }
    }
}
