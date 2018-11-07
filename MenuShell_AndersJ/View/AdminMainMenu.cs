using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell_AndersJ.Entities;

namespace MenuShell_AndersJ.View
{
    class AdminMainMenu
    {
        public void Display(List<User> users)
        {
            var manageUser = new ManageUserView();
            int result = 0;

            while (true)
            {
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" ADMIN MENU \n");
                Console.WriteLine("(1) Manage users");
                Console.ResetColor();
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("(2) Exit");
                Console.ResetColor();
              

                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch
                {
                    result = 0;
                }

                switch (result)
                {
                    case 1:
                        manageUser.Display(users);
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Wrong input");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;
                }

            }
        }
    }
}