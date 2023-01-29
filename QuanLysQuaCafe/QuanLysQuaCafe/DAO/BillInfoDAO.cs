using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysQuaCafe.DAO
{
    public  class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO()
        {

        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuyre("SELECT * FROM dbo.BillInfo WHERE idBill = " + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);

            }
            return listBillInfo;
        }
        public void InsertBillinfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteQuyre("EXEC USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood,count });

        }
        public void DeleteBillInfoByIdFood(int id)
        {
            DataProvider.Instance.ExecuteQuyre("DELETE dbo.BillInfo WHERE idFood = "+id);
        }
    }
}
