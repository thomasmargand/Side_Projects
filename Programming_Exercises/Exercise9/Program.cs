using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordEncryption
{
    class Program
    {

        static string username;
        static string password;
        static Dictionary<string, string> userSystem = new Dictionary<string, string>();

        static void Main()
        {
            Console.WriteLine("Password Authenticaton System" + "\n");
            Console.WriteLine("Please select one option" + "\n" + "1. Establish Account" + "\n" + 
                "2. Authenticate a user" + "\n" + "3. Exit the system");

            try
            {
                START:
                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        establishAccount();
                        break;
                    case 2:
                        authenticateUser();
                        break;
                    case 3:
                        foreach(KeyValuePair<string, string> element in userSystem)
                        {
                            string Name = element.Key;
                            string Password = element.Value;
                            Console.WriteLine($"Username: {Name}, Password: {Password}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid selection please try again");
                        goto START;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Selection please try again");
                Main();
            }

            void establishAccount()
            {
            START:
                Console.WriteLine("Please enter a username" + "\n");
                username = Console.ReadLine();

                if (userSystem.ContainsKey(username))
                {
                    Console.WriteLine("Sorry this username already exists, please try another");
                    goto START;
                }

                Console.WriteLine("Now please enter a password");
                password = Console.ReadLine();

                userSystem.Add(username, encryptPassword(password));
                Main();
            }

            string encryptPassword(string password)
            {
                MD5 md5Hash = MD5.Create();
                byte[] encryptedPassword = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder hashedPassword = new StringBuilder();
                for (int i = 0; i < encryptedPassword.Length; i++)
                {
                    hashedPassword.Append(encryptedPassword[i].ToString());
                }
                return hashedPassword.ToString();
            }
            
            void authenticateUser()
            {
                Console.WriteLine("Please enter your username");
                username = Console.ReadLine();

                if(userSystem.ContainsKey(username) == false)
                {
                    Console.WriteLine("This username does not exist, please try again");
                    Main();
                }
                else if (userSystem.ContainsKey(username))
                {
                    Console.WriteLine("Please enter your password");
                    password = Console.ReadLine();

                    string comparePassword = encryptPassword(password);
                    if (comparePassword == userSystem[username])
                    {
                        Console.WriteLine("User Authenticated");
                        Main();
                    }
                    else if (comparePassword != userSystem[username])
                    {
                        Console.WriteLine("Incorrect password please try again");
                        Main();
                    }
                }
            }
        }
    }
}
