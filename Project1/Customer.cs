using Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public class Customer : Admin
    {
        private int nationalId;

        public Customer(string username, string password, int nationalId):base(username, password)
        {
            NationalId = nationalId;
        }

        public int NationalId{ set; get; }
    }
}
