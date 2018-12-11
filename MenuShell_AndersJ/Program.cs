using System.Collections.Generic;
using MenuShell_AndersJ.View;
using MenuShell_AndersJ.Entities;

namespace MenuShell_AndersJ
{
    class Program
    {
        public static List<User> users = new List<User>()

        {
            new User(userName: "admin", password: "secret", role: "Sysadmin"),
            new User(userName: "janedoe", password: "secret", role: "Receptionist"),
        };
      

        static void Main(string[] args)
        {
            LogInView loginview = new LogInView();
            loginview.Display(users);

            
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Display(users);
        }

    }
}