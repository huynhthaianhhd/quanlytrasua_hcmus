using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.DTO
{
    public class Account
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private int _permission;

        public int Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }
        private string _name_user;

        public string Name_user
        {
            get { return _name_user; }
            set { _name_user = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private int _phone;

        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        

        public Account(string username, string password, int permission, string name_user, string email, int phone)
        {
            this.Username = username;
            this.Password = password;
            this.Permission = permission;
            this.Name_user = name_user;
            this.Email = email;
            this.Phone = phone;
        }

        public Account(DataRow row)
        {
            this.Username = row["USERNAME"].ToString();
            this.Password = row["PASSWORD"].ToString();
            //this.Permission = (int)row["PERMISSION"];
            this.Name_user = row["NAME_USER"].ToString();
            this.Email = row["EMAIL"].ToString();
            //this.Phone = (int)row["PHONE"];
        }
    }
}
