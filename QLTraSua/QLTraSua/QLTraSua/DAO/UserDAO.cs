using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance = value; }
        }
        private UserDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "US_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query , new object[] {userName,passWord});

            return result.Rows.Count>0;
        }
    }
}
