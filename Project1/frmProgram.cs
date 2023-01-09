using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmProgram : Form
    {
        public frmProgram()
        {
            InitializeComponent();
            lblWelc.Text = "Welcome" + " " + Lists.userToWelcome;
            lblTotal.Text = "Total = " + Lists.price + " $";
        }

        private void frmProgram_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (Lists.price == 0)
            {
                MessageBox.Show("Make Sure to Book a Ticket First", "Checkout Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Lists.soldTickets.Add(Lists.price);
                StreamWriter sw = File.AppendText("D:\\TotalNetPrices.txt");
                sw.WriteLine(Lists.price);
                sw.Close();
                new frmCheckOut().Show();
                this.Hide();
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNoOfTickets_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbBoxTo.SelectedIndex == -1 || cmbBoxFrom.SelectedIndex == -1 || cmBoxNoTickets.SelectedIndex == -1)
            {
                MessageBox.Show("Make Sure to fill all Information", "Booking Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(DateTime.Compare(DateTime.Now,dateTimePicker1.Value) > 0)
            {
                MessageBox.Show("Invalid Date", "Make Sure to Make Reservation a Day prior", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Booking Successful", "Ticket has been booked", MessageBoxButtons.OK);
                int price = 1000;
                price = (chkBoxVip.Checked) ? price + 100 : price;
                price = (chkBoxWindow.Checked) ? price + 50 : price;
                int noTickets = int.Parse(cmBoxNoTickets.SelectedItem.ToString());
                price = price * noTickets;
                Lists.price += price;
                lblTotal.Text = "Total = " + Lists.price + " $";

            }
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Tickets have been unbooked", "Fell Free To Book Another Flight", MessageBoxButtons.OK);
            Lists.price = 0;
            lblTotal.Text= "Total = " + Lists.price + " $";
        }
    }
}
