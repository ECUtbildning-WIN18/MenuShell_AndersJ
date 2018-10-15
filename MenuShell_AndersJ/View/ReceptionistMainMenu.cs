using System;

namespace MenuShell_AndersJ.View
{
    class ReceptionistMainMenu : ConsoleView
    {
        public override string Display()
        {
            base.Display();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Receptionist menu\n");
            Console.WriteLine("1. List users");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("2. Log out");
            Console.WriteLine("3. Exit");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            return Console.ReadLine();
            Console.ResetColor();
        }
    }
}