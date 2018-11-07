using System;
using System.Collections.Generic;
using MenuShell_AndersJ.Entities;
using MenuShell_AndersJ.Services;
using MenuShell_AndersJ.View;

namespace MenuShell_AndersJ.View
{
    class AdminAddUserView : ConsoleView
    {
        public void Display(UserFinder userFinder, List<User> users)
        {

            string result;

            do
            { 
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" To create a new user account. Please add correct details \n");

                Console.Write("\nUsername: ");
                string userName = Console.ReadLine();

                Console.Write("\nPassword: ");
                string password = Console.ReadLine();

                Console.Write("\nRole: ");
                string role = Console.ReadLine();

                Console.WriteLine("Is this correct (Y)es or (N)o?");
                result = Console.ReadLine();

                if (result.ToUpper() == "Y")
                {                 
                    userFinder.AddUser(userName, password, role, users);
                }
            } while (result.ToUpper() != "Y");

        }
    }
}