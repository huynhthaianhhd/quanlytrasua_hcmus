using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTraSua.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        private string g_username;
        private string g_password;
        public void setUsername(string username, string password)
        {
            g_username = username;
            g_password = password;
        }
        public string getUsername()
        {
            return g_username;
        }
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance = value; }
        }
        private UserDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "US_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

        public bool ChangePassword(string currentPassword, string newPassword, string newPassword_2)
        {
            string query = "US_getInfor @userName";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { global.GetSetUsername });

            string truePassword = result.Rows[0]["PASSWORD"].ToString();
            string username = result.Rows[0]["USERNAME"].ToString();

            if (currentPassword == truePassword)
            {
                if (newPassword != "" && newPassword != null)
                {
                    if (newPassword == newPassword_2)
                    {
                        query = "US_updatePassword @username , @password , @passwordnew";
                        int result_2 = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, truePassword, newPassword });
                        return result_2 > 0;
                    }
                }
            }
            return false;
        }

        public List<string> LoadNhanVienDetail()
        {
            List<string> nvDetail = new List<string>();

            string query = "US_getInfor @userName";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { global.GetSetUsername });

            nvDetail.Add(result.Rows[0]["NAME_USER"].ToString());
            nvDetail.Add(result.Rows[0]["USERNAME"].ToString());
            nvDetail.Add(result.Rows[0]["PHONE"].ToString());
            nvDetail.Add(result.Rows[0]["EMAIL"].ToString());
            return nvDetail;
        }

    }
}
