using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmerings_Eksamen
{
    public partial class CustomerPage : Form
    {
        public CustomerPage(string username, string password, string amount)
        {
            InitializeComponent();
            WelcomeLabel.Text = $"Welcome, {username}";
            MailLabel.Text = $"You have {amount} unread mails";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginPage = new loginPage();
            loginPage.Show();
        }
    }
}
