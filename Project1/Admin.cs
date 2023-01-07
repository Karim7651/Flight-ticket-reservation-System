using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Admin
    {
        private string userName;
        private string password;
        public Admin() { }
        public Admin(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public string UserName { set; get; }
        public string Password { set; get; }
    }
}
