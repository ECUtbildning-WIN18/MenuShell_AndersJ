using System;
using System.Collections.Generic;
using System.Threading;

namespace MenuShell_AndersJ.View
{
    class AdminDeleteUserView : ConsoleView
    {
        public override string Display()
        {
            base.Display();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("User deletion menu");
            Console.WriteLine("Choose user to delete by number");
            Thread.Sleep(1000);
            Console.ResetColor();

            return "";
        }
    }
}