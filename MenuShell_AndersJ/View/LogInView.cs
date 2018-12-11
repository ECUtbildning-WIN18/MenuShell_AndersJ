using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell_AndersJ.Entities;
using MenuShell_AndersJ.Services;

namespace MenuShell_AndersJ.View
{
    class LogInView
    {

        public void Display(List<User> users) 
        {
            User loggedInUser = null;
            var authentication = new AuthenticationService();
            string keyInfo ="";

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" MenuShell v1.1\n");
                Console.WriteLine("Please log in\n");

                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.Write("\nIs this correct? (Y)es (N)o: ");
                keyInfo = Console.ReadLine();
                Console.ResetColor();

                if (keyInfo.ToUpper() == "Y")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Checking your login against the mainframe");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Console.ResetColor();
                 
                    loggedInUser = authentication.Authenticate(username, password, users);

                    if (loggedInUser == null)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Login failed, you will be redirected to login-page");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                    }
                }
            } while (keyInfo.ToUpper() != "Y" || loggedInUser == null);
            
        }
    }
}