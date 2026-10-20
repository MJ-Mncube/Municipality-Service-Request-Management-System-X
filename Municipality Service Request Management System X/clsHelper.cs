using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_Service_Request_Management_System_X
{
        public class FileHelper
        {
            // Define the path to your text file
            private static readonly string FilePath = @"C:\Users\User\Documents\Lagash ltd\Residents.txt";

            // The combined method that searches and extracts in one go
            public static UserDetails GetUserByEmail(string emailToFind)
            {
                if (!File.Exists(FilePath)) return null;

                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                // Assuming format://SM0708|Simamkele|Mncube|19|Male|Black|simamkelemncube@gmail.com|0708296350083|0760458770|Mzilankatha
                string[] parts = line.Split('|');

                    if (parts.Length >= 10)
                    {
                        string fileEmail = parts[6].Trim();

                        if (fileEmail.Equals(emailToFind, StringComparison.OrdinalIgnoreCase))
                        {
                            // Create and return the object immediately
                            return new UserDetails
                            {
                                UserID = parts[0].Trim(),
                                Name = parts[1].Trim(),
                                Surname = parts[2].Trim(),
                                Phonenumber = parts[8].Trim(),
                                Email = fileEmail
                            };
                        }
                    }
                }
                return null; // Not found
            }
        }

        // The simple data holder nested right below it
        public class UserDetails
        {
            public string UserID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Phonenumber { get; set; }
        }
    
}
