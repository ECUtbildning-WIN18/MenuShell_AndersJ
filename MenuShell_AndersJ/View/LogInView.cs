using System;

namespace MenuShell_AndersJ.View
{
    class LogInView : ConsoleView
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string Display()
        {
            string keyInfo ="";

            do
            {
                base.Display();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Welcome to Menushell System 1.0\n");
                Console.WriteLine("Please log in\n");

                Console.Write("Username:");
                Username = Console.ReadLine();

                Console.Write("Password:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Black;
                Password = Console.ReadLine();
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nIs this correct? (Y)es (N)o: ");
                keyInfo = Console.ReadLine();
                Console.ResetColor();

            } while (keyInfo.ToUpper() != "Y");

            return keyInfo;
        }
    }
}