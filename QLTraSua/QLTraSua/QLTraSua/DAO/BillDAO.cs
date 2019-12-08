
using QLTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BILL WHERE ID_TABLE = " + id +" AND IS_PAID = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int id, int isTakeaway)
        {
            DataProvider.Instance.ExecuteNonQuery("US_InsertBill @idTable , @isTakeAway", new object[] { id , isTakeaway});
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID_BILL) FROM dbo.BILL");
            }
            catch
            {
                return 1;
            }
        }
        public int GetBillByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BILL WHERE ID_TABLE = " + id);
            int numRows = data.Rows.Count;
            if (numRows > 0)
            {
                Bill bill = new Bill(data.Rows[numRows-1]);
                return bill.Status;
            }
            return 0;
        }

        public bool UpdateIsPaidBillByTableID(int id)
        {
            string query = string.Format("UPDATE dbo.BILL SET IS_PAID = N'0' WHERE ID_TABLE = N'{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public void checkOut(int id, float totalPrice)
        {
            string query = "UPDATE dbo.BILL SET ORDERTIME = GETDATE(), IS_PAID = 1, " + " TOTAL_PRICE = " + totalPrice + " WHERE ID_BILL = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetListByDate(DateTime dateFrom,DateTime dateTo)
        {
           return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @dateFrom , @dateTo", new object[]{dateFrom,dateTo});
        }
    }
}
