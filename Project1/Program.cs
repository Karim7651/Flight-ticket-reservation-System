using Project;

namespace Project1
{
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //read from file to customer list then to hashmap
            string[] lines = File.ReadAllLines("D:\\Customers.txt");
            int counter = 0;
            string username = " ";
            string Password = " ";
            int nationalId = 0;
            foreach (string line in lines)
            {
                if (counter == 0)
                {
                    username = line;
                    counter++;
                }
                else if (counter == 1)
                {
                    Password = line;
                    counter++;
                }
                else if (counter == 2)
                {
                    nationalId = int.Parse(line);
                    counter = 0;
                    Lists.customerList.Add(new Customer(username, Password, nationalId));
                }
            }
            //add userInfo from customerList to hashMap
            foreach (Customer current in Lists.customerList)
            {
                if (!Lists.hashMap.ContainsKey(current.UserName))
                {
                    Lists.hashMap.Add(current.UserName, current.Password);
                }

            }
            //read from file for frmAdminPanel to show total profit of tickets sold
            string[] ticketPrices = File.ReadAllLines("D:\\TotalNetPrices.txt");
            foreach (string ticket in ticketPrices)
            {
                int ticketPrice = int.Parse(ticket);
                Lists.soldTickets.Add(ticketPrice);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new frmRegister());
        }
    }
}