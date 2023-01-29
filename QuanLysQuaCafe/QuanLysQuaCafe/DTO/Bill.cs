using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int iDTable;
        private int status;
        private int discount;
        public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, int iDTable, int status, int discount = 0 )
        {
            this.ID = iD;
            this.DateCheckIn = dateCheckIn;
            
            this.DateCheckOut = dateCheckOut;
            this.IDTable = iDTable;
            this.Status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var DateCheckOutTepm = row["dateCheckOut"];
            if(DateCheckOutTepm.ToString() != "")
                this.DateCheckOut = (DateTime?)DateCheckOutTepm;
            this.IDTable = (int)row["iDTable"]; 
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int IDTable { get => iDTable; set => iDTable = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
