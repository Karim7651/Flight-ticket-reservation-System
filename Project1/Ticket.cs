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
        private string level;
        private int price;
        private int quantity;

        Ticket(string from, string to, string level, int price, int quantity)
        {
            this.from = from;
            this.to = to;
            this.level = level;
            this.price = price;
            this.quantity = quantity;
        }
        public string From { set; get; }
        public string To { set; get; }
        public string Level { set; get; }
        public int Price { set; get; }
        public int Quantity { set; get; }
    }
}
