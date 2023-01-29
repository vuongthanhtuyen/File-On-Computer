using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DTO
{
    public class Food
    {
       private int id;
       private string name;
        private int idCatorogy;
        private int price;

        public Food(int id, string name, int idCatorogy, int price)
        {
            this.Id = id;
            this.Name = name;
            this.IdCatogory = idCatorogy;
            this.Price = price;
        }
        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdCatogory = (int)row["idCatogory"]; 
            this.Price = (int)Convert.ToDouble(row["Price"].ToString());
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCatogory { get => idCatorogy; set => idCatorogy = value; }
        public int Price { get => price; set => price = value; }
    }
}
