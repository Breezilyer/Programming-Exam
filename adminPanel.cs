using BankSystem.File_Handling_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmerings_Eksamen
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginPage = new loginPage();
            loginPage.Show();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username != "" && password != "")
            {
                Customer c = new Customer(username, password, "0");
                Customer f = Customer.CreateFolder(username);
                c.Create();

                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                MessageBox.Show("Customer Created");
            }
            else
            {
                MessageBox.Show("Insufficient Customer Creation");
            }
        }

        private void read_Customer_button_Click(object sender, EventArgs e)
        {
            Customer c = Customer.deleteCustomer(deleteCustomerTextBox.Text);
            deleteCustomerTextBox.Text = "";
        }

        private void SendMailButton_Click(object sender, EventArgs e)
        {
            string path = $@"{username}s Mail";
            string filename = @"test.txt";
            string finalpath = Path.Combine(path + "s Mail", filename);
        }
    }
}