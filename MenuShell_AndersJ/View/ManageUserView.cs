using System;

namespace MenuShell_AndersJ.View
{
    class ManageUserView : ConsoleView
    {
        public override string Display()
        {
            base.Display();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Manage users");
            Console.WriteLine("1. Add user");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("2. Delete user");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string addOrDelete = Console.ReadLine();
            Console.ResetColor();
            return addOrDelete;
        }
 
    }
}