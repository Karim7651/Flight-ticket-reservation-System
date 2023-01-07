using Project;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //add userInfo from customerList to hashMap
            foreach (Customer current in Lists.customerList)
            {
                Lists.hashMap.Add(current.UserName, current.Password);
            }
            if (txtUserName.Text == "" || txtPassword.Text == "" )
            {
                MessageBox.Show("Make sure to fill all fields", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // validate login
            else if (Lists.hashMap.ContainsKey(txtUserName.Text) && Lists.hashMap["txtUserName.Text"] == txtPassword.Text)
            {
                MessageBox.Show("Succeseful Login", "Credentials Match", MessageBoxButtons.OK);
                new frmProgram().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unsucceseful Login", "Credentials don't Match", MessageBoxButtons.OK);
            }
            
        }
    }
}
