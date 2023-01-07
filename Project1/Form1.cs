using Project;
using System.Configuration;

namespace Project1
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "" || txtPassword.Text == "" || confrimPassword.Text == "" || nationalID.Text == "")
            {
                MessageBox.Show("Make sure to fill all fields", "Registeration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(txtPassword.Text != confrimPassword.Text){
                MessageBox.Show("passwords don't match", "Registeration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Registeration successful", "Your account have been created", MessageBoxButtons.OK);
                int national = int.Parse(nationalID.Text);
                string user = txtUserName.Text;
                string password = txtPassword.Text;
                Lists.customerList.Add(new Customer(user, password, national));
                // write that to end of the file or create
                StreamWriter sw = File.AppendText("D:\\Customers.txt");
                sw.WriteLine(user);
                sw.WriteLine(password);
                sw.WriteLine(national);
                sw.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                confrimPassword.PasswordChar = '\0';
            }
            else{
                txtPassword.PasswordChar = '*';
                confrimPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            confrimPassword.Text = "";
            nationalID.Text = "";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}