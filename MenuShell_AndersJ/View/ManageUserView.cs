using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell_AndersJ.Entities;
using MenuShell_AndersJ.Services;

namespace MenuShell_AndersJ.View
{
    class ManageUserView
    {

        public void Display(List<User> users)
        {
            var addUser = new AdminAddUserView();
            var searchUser = new AdminSearchUserView();
            var userHandler = new UserFinder();

            bool correctSelection = false;
            int choice = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" MANAGE USERS ");
                Console.WriteLine("(1) Add user");
                Console.WriteLine("(2) Search user");
                Console.Write(" > ");
                Console.ResetColor();

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    choice = 0;
                }


                switch (choice)
                {
                    
                    case 1:
                        addUser.Display(userHandler, users);
                        correctSelection = true;
                        break;

                    case 2:
                        searchUser.Display(userHandler, users);
                        correctSelection = true;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You can only choose by numbers 1-2");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        correctSelection = false;
                        break;
                }
            }
            while (correctSelection == false);
        }
 
    }
}