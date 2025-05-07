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
                Customer c = new Customer(username, password);
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

        private void read_Customer_button_Click(object sender, EventArgs e) // Gider virkelig fucking ikke at ændre 10 forskellige programmer for at der skal så DeleteButton i stedet for read. Fuck mig legit
        {
            Customer c = Customer.deleteCustomer(deleteCustomerTextBox.Text);
            deleteCustomerTextBox.Text = "";
        }

        private void SendMailButton_Click(object sender, EventArgs e)
        {
            string path = @"Customers.csv";
            foreach (var line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                string username = parts[0].Trim();

                // Create folder name
                string folderName = $"{username}s Mail";
                string folderPath = Path.Combine("", folderName);

                if (Directory.Exists(folderPath))
                {
                    string filePath = Path.Combine(folderName, $"{HeaderTextBox.Text}.txt");
                    File.WriteAllText(filePath, AdvertTextBox.Text + $"\nSent: {DateTextBox.Text}");
                    Console.WriteLine($"Written message for {username} in: {folderPath}");
                }
                else
                {
                    Console.WriteLine($"Folder not found: {folderPath}");
                }
            }
            MessageBox.Show("Send a mail to all Customers!");
            HeaderTextBox.Text = "";
            AdvertTextBox.Text = "";
            DateTextBox.Text = "";
        }
    }
}