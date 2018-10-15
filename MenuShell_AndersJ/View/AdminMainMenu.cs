using System;

namespace MenuShell_AndersJ.View
{
    class AdminMainMenu : ConsoleView
    {
        public override string Display()
        {
            base.Display();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sysadmin menu\n");
            Console.WriteLine("1. Manage users");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("2. Log out");
            Console.WriteLine("3. Exit");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string result = Console.ReadLine();
            Console.ResetColor();
            return result; 
        }
    }
}