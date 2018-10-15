using System;

namespace MenuShell_AndersJ.View
{
    class AdminAddUserView : ConsoleView
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public override string Display()
        {
            string result;

            do
            {
                base.Display();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("User creation menu\n");

                Console.Write("\nUsername: ");
                UserName = Console.ReadLine();

                Console.Write("\nPassword: ");
                Password = Console.ReadLine();

                Console.Write("\nRole: ");
                Role = Console.ReadLine();

                Console.WriteLine("Is this correct (Y)es or (N)o?");
                result = Console.ReadLine();
                Console.ResetColor();
            } while (result.ToUpper() != "Y");
            return result;
        }
    }
}