using QLTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTraSua.DAO
{
    public class IncomeDAO
    {
        private static IncomeDAO instance;
        public static IncomeDAO Instance
        {
            get { if (instance == null) instance = new IncomeDAO(); return instance; }
            private set { instance = value; }
        }
        private IncomeDAO() { }

        public string GetTotalIncome()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT SUM(TOTAL_PRICE) AS 'TOTAL_INCOME' FROM dbo.BILL");
            string temp = result.Rows[0]["TOTAL_INCOME"].ToString();
            return (temp != "") ? temp : "0";
        }

        public string GetCountTotal()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT COUNT(*) AS 'COUNT_TOTAL' FROM dbo.BILL");
            string temp = result.Rows[0]["COUNT_TOTAL"].ToString();
            return (temp != "") ? temp : "0";
        }
        public string GetTakeAwayIncome()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT SUM(TOTAL_PRICE) AS 'TOTAL_INCOME' FROM dbo.BILL WHERE IS_TAKEAWAY = N'1'");
            string temp = result.Rows[0]["TOTAL_INCOME"].ToString();
            return (temp != "") ? temp : "0";
        }

        public string GetCountTakeAway()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT COUNT(*) AS 'COUNT_TOTAL' FROM dbo.BILL WHERE IS_TAKEAWAY = N'1'");
            string temp = result.Rows[0]["COUNT_TOTAL"].ToString();
            return (temp != "") ? temp : "0";
        }
        public string GetNotTakeAwayIncome()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT SUM(TOTAL_PRICE) AS 'TOTAL_INCOME' FROM dbo.BILL WHERE IS_TAKEAWAY = N'0'");
            string temp = result.Rows[0]["TOTAL_INCOME"].ToString();
            return (temp != "") ? temp : "0";
        }

        public string GetCountNotTakeAway()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT COUNT(*) AS 'COUNT_TOTAL' FROM dbo.BILL WHERE IS_TAKEAWAY = N'0'");
            string temp = result.Rows[0]["COUNT_TOTAL"].ToString();
            return (temp != "") ? temp : "0";
        }
    }
}
