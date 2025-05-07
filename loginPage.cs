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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string path = @"Customers.csv";
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == "admin" && password == "1234")
            {
                this.Hide();
                var adminPanel = new adminPanel();
                adminPanel.Show();
            }

            foreach (string line in File.ReadLines(path))
            {
                Customer customer = Customer.FromFileFormat(line);
                if (customer != null && customer.Username == username && customer.Password == password)
                {
                    this.Hide();
                    var customerPage = new CustomerPage(customer.Username, customer.Password);
                    customerPage.Show();
                }
            }
        }
    }
}
