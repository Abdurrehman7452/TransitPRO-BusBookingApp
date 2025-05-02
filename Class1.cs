using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitPRO
{
    internal class UserValidation
    {
        public static bool ValidateUser(string username, string password)
        {
            // Read user credentials from a file

            string filePath = "users.txt";

            string[] users = File.ReadAllLines(filePath);

            foreach (string user in users)
            {

                string[] credentials = user.Split(':');

                string storedUsername = credentials[0];

                string storedPassword = credentials[1];

                if (storedUsername == username && storedPassword == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static void RegisterUser(string username, string password)
        {

            // Append new user credentials to the file

            string filePath = "users.txt";

            string newUser = username + ":" + password;

            File.AppendAllText(filePath, newUser + Environment.NewLine);

        }

    }
}
