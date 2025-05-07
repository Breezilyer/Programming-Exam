using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem.File_Handling_Folder
{
    public class Customer
    {
        static string path = @"Customers.csv";
        public string Username { get; set; }
        public string Password { get; set; }
        public string Amount { get; set; }


        public Customer(string username, string password, string amount)
        {
            Username = username;
            Password = password;
            Amount = amount;
        }

        public void Create()
        {
            File_Handling_Folder.FileHandling.CustomerCreate(this);
        }


        public static Customer CreateFolder(string username)
        {
            string path = $@"{username}";
            Directory.CreateDirectory(path + "s Mail");

            // For testing
            string filename = @"test.txt";
            string finalpath = Path.Combine(path + "s Mail", filename);

            return null;
        }


        public static Customer deleteCustomer(string username)
        {
            string tempPath = @"Customers_temp.csv";
            string folderPath = $@"{username}s Mail";
            bool deleted = false;

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(tempPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Split(',')[0] != username)
                    {
                        writer.WriteLine(line);
                    }
                    else
                    {
                        deleted = true;
                    }
                }
            }

            if (deleted)
            {
                File.Delete(path);
                Directory.Delete(folderPath, true);
                File.Move(tempPath, path);
                MessageBox.Show("The customer was deleted successfully!", "Deleting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.Delete(tempPath);
            }
            return null;
        }

        public static Customer FromFileFormat(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                return new Customer(parts[0], parts[1], parts[2]);
            }
            return null;
        }
    }
}