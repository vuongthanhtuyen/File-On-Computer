using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO()
        {

        }
        public  List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "SELECT * FROM dbo.FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuyre(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }
        public Category GetCatoryByID(int id)
        {
            Category category = null;
            string query = "SELECT * FROM dbo.FoodCategory where id = "+id;
            DataTable data = DataProvider.Instance.ExecuteQuyre(query);
            foreach (DataRow item in data.Rows)
            {
                 category = new Category(item);
                return category;
            }
            return category; 

        }
    }
}
