﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DTO
{
    public  class Category
    {
        private int id;
        private string name;

        public Category(int id, string name)
        {
            this.Id = id;
            this.Name  = name;
        }
        public Category(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString() ;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
