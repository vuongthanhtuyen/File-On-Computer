using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DAO
{
    public  class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get {if(instance == null) instance = new BillDAO();return instance;}
            private set { BillDAO.instance = value; } 
        } 

        private BillDAO()
        {
             
        }
        /// <summary>
        /// Thành công khi : bill iD
        /// Thất bại : -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GeUnCheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuyre("SELECT * FROM dbo.Bill WHERE idTable = "+id+" AND status = 0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID; 
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteQuyre("EXEC dbo.USP_InsertBill @idTable  ",new object[] {id});
        }
        public DataTable GetBillListByDay(DateTime dayCheckIn, DateTime datCheckOUt)
        {
            return DataProvider.Instance.ExecuteQuyre("EXEC dbo.USP_GetListBillByDate @checkIn , @checkOut", new object[] { dayCheckIn, datCheckOUt });
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = " UPDATE dbo.Bill SET	dateCheckOut = GetDate(), status = 1,  discount = "+discount+ ", totalPrice = "+totalPrice+" WHERE  id = " + id;
            DataProvider.Instance.ExecuteQuyre(query);
        }
        public int GetMaxIdBill()
        {
            try
            {
              return  (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");

            }
            catch
            {
                return 1;
            }
        }
    }
}
