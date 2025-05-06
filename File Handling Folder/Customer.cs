using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem.File_Handling_Folder
{
    public class Customer
    {
        static string path = @"Customers.csv";
        public string Username { get; set; }
        public string Password { get; set; }
        

        public Customer(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void Create()
        {
            File_Handling_Folder.FileHandling.CustomerCreate(this);
        }


        public static Customer readCustomer(string CPRNumber)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] subs = s.Split(',');

                    if (subs[3] == CPRNumber)
                    {
                        return new Customer(subs[0], subs[1]);
                    }
                }
            }
            return null;
        }


        public static Customer deleteCustomer(string originalCPR)
        {
            string tempPath = @"Customers_temp.csv";
            bool deleted = false;

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(tempPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Split(',')[3] != originalCPR)
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
                File.Move(tempPath, path);
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
            if (parts.Length == 7)
            {
                return new Customer(parts[0], parts[1]);
            }
            return null;
        }
    }
}