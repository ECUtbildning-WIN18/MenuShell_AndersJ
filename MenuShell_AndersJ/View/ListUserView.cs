using System;
using System.Threading;

namespace MenuShell_AndersJ.View
{
    class ListUserView : ConsoleView
    {
        public override string Display()
        {
            base.Display();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("List users\n");
            Console.WriteLine("You are only allowed to see the users username and their role");
            Console.WriteLine("The list are now loading...");
            Thread.Sleep(1000);
            Console.ReadLine();
            Console.ResetColor();
            return "";
        }
    }
}