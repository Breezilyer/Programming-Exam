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
            string path = @"Customer.csv";
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }

            if (username == "admin" && password == "1234")
            {
                this.Hide();
                var adminPanel = new adminPanel();
                adminPanel.Show();
            }
        }
    }
}
