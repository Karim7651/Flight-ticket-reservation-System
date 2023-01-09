using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Ticket
    {
        private string from;
        private string to;
        private int price;

        public Ticket(string from, string to, int price)
        {
            From = from;
            To = to;
            Price = price;
        }
        public string From { set; get; }
        public string To { set; get; }
        public int Price { set; get; }
    }
}
