using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DTO
{
    public   class BillInfo
    {
        private int iD;
        private int iDBIll;
        private int iDfood;
        private int count;

        public BillInfo(int iD, int iDBIll, int iDfood, int count)
        {
            this.ID = iD;
            this.IDBIll = iDBIll;
            this.IDfood = iDfood;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.IDBIll = (int)row["iDBIll"];
            this.IDfood = (int)row["iDfood"];
            this.Count = (int)row["count"];

        }

        public int ID { get => iD; set => iD = value; }
        public int IDBIll { get => iDBIll; set => iDBIll = value; }
        public int IDfood { get => iDfood; set => iDfood = value; }
        public int Count { get => count; set => count = value; }
    }
}
