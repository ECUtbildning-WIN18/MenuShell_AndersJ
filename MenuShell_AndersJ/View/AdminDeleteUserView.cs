using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell_AndersJ.Entities;
using MenuShell_AndersJ.Services;

namespace MenuShell_AndersJ.View
{
    class AdminDeleteUserView
    {

        public void Display(string userName, List<User> users)
        {
            var userHandler = new UserFinder();
            bool foundInList = false;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" DELETE USER ");
            Console.WriteLine("\n");
            Console.ResetColor();

            foreach (var user in users)
            {
                if (user.UserName == userName)
                {
                    userHandler.RemoveUser(user, users);
                    foundInList = true;
                    break;
                }
            }

            if (foundInList == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("This user will now be deleted!");
                Console.ResetColor();
                Thread.Sleep(1000);
            }

            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("No user match the criteria");
                Thread.Sleep(1000);
            }
        }
    }
}