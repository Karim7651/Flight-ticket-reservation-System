using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    //static global lists for all forms
    static public class Lists
    {
        static public List<Customer> customerList = new List<Customer>();
        static public List<Ticket> ticketList = new List<Ticket>();
        static public Dictionary<string, string> hashMap = new Dictionary<string, string>();
    }
}
