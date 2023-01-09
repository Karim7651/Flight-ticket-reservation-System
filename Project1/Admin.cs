using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Admin
    {
        private string username;
        private string password;
        public Admin() { }
        public Admin(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public string UserName { set; get; }
        public string Password { set; get; }
    }
}
