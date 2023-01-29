using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private int price;
        private float totalPrice;

        public Menu(string foodName, int count,int price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.FoodName =row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (int)Convert.ToDouble(row["Price"].ToString());
            this.TotalPrice = (float)(int)Convert.ToDouble(row["total"].ToString());
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int Price { get => price; set => price = value; }
    }
}
