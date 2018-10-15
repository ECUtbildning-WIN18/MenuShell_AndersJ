using MenuShell_AndersJ.Entities;
using System;
using System.Collections.Generic;

namespace MenuShell_AndersJ.Services
{
    class ListUser
    {
        public void ListAllUsers(List<User> users)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var user in users)
            {
                Console.WriteLine($" Name:{user.UserName} Role:{user.Role}");
            }

            Console.ReadLine();
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}