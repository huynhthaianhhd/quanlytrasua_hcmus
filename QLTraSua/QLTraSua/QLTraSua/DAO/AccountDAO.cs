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
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public List<Account> LoadNhanVienList()
        {
            List<Account> nvList = new List<Account>();
            string query = "SELECT * FROM dbo.USERS";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                Account account = new Account(item);
                nvList.Add(account);
            }
            return nvList;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT USERNAME, PERMISSION, NAME_USER, EMAIL, PHONE FROM dbo.USERS");
        }
        public bool InsertAccount(string username, int permission, string name_user, string email, int phone)
        {
            string query = string.Format("INSERT dbo.USERS ( USERNAME, PASSWORD, PERMISSION, NAME_USER, EMAIL, PHONE )VALUES  (N'{0}', N'{1}', {2}, N'{3}', N'{4}', {5})", username, 0, permission, name_user, email, phone);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount(string username, int permission, string name_user, string email, int phone)
        {
            string query = string.Format("UPDATE dbo.USERS SET PERMISSION = N'{1}', NAME_USER = N'{2}', EMAIL = N'{3}', PHONE = N'{4}' WHERE USERNAME = N'{0}'", username, permission, name_user, email, phone);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            if (global.GetSetUsername == username)
            {
                MessageBox.Show("Bạn đang đăng nhập bằng tài khoản này", "Error");
            }
            else
            {
                string query = string.Format("DELETE dbo.USERS WHERE USERNAME = N'{0}'", username);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            return false;
        }


        public bool ResetPassword(string username)
        {
            string query = string.Format("UPDATE dbo.USERS SET PASSWORD = N'0' WHERE USERNAME = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
