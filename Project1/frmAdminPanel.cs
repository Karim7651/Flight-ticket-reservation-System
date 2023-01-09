using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
            int counter = 0;
            int price = 0;
            foreach(int x in Lists.soldTickets)
            {
                counter++;
                price += x;
            }
            lblTotalNum.Text = "Total Number of Sold Tickets : " + counter.ToString();
            lblTotalProfit.Text = "Total Value of Tickets : " +  price.ToString() + " $" ;


        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
