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
        private string _password;
        private int _permission;
        private string _name_user;
        private string _email;
        private int _phone;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public int Permission { get => _permission; set => _permission = value; }
        public string Name_user { get => _name_user; set => _name_user = value; }
        public string Email { get => _email; set => _email = value; }
        public int Phone { get => _phone; set => _phone = value; }

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
