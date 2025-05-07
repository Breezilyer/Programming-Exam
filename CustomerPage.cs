using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Programmerings_Eksamen
{
    public partial class CustomerPage : Form
    {
        public string user { get; set; }
        public CustomerPage(string username, string password)
        {
            InitializeComponent();
            WelcomeLabel.Text = $"Welcome, {username}";
            user = username;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginPage = new loginPage();
            loginPage.Show();
        }

        private void read_mails_button_Click(object sender, EventArgs e)
        {   
            string baseDir = @"";
            string folderName = $"{user}s Mail";
            string folderPath = Path.Combine(baseDir, folderName);

            if (Directory.Exists(folderPath))
            {
                var files = Directory.GetFiles(folderPath, "*.txt");
                if (files.Length > 0)
                {
                    string firstFile = files[0];

                    try
                    {
                        Process process = Process.Start(new ProcessStartInfo
                        {
                            FileName = firstFile,
                            UseShellExecute = true
                        });
                        process.WaitForExit();

                        File.Delete(firstFile);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening or deleting file: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("No message files found.");
                }
            }
            else
            {
                MessageBox.Show("User folder not found.");
            }
        }
    }
}
