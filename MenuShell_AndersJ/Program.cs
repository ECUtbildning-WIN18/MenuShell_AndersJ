using MenuShell_AndersJ.Entities;
using MenuShell_AndersJ.Services;
using MenuShell_AndersJ.View;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MenuShell_AndersJ
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            {
                users.Add(new User(userName: "admin", password: "secret", role: "Sysadmin"));
                users.Add (new User(userName: "janedoe", password: "secret", role: "Receptionist"));
            };

            var logInView = new LogInView();
            var authentication = new AuthenticationService();
            var receptionistMainMenu = new ReceptionistMainMenu();
            var adminMainMenu = new AdminMainMenu();
            var adminAddUser = new AdminAddUserView();
            var manageUser = new ManageUserView();
            var addUser = new AddUser();
            var listUser = new ListUserView();
            var listAllUser = new ListUser();
            var adminDeleteUser = new AdminDeleteUserView();
            var deleteUser = new DeleteUser();
            User loggedInUser = null;
            string result;
            
            do
            {
                result = logInView.Display();
                if (result.ToUpper() == "Y")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.WriteLine("Checking your log in information against the mainframe...");
                    Thread.Sleep(1500);
                    loggedInUser = authentication.Authenticate(logInView.Username, logInView.Password, users);
                    Console.ResetColor();

                    if (loggedInUser==null)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Login failed, you will be sent to the login-page");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                    }
                }
            }
            while (loggedInUser == null);

            do
            {
                if (loggedInUser.Role == "Receptionist")
                {
                    result = receptionistMainMenu.Display();
                    switch (result)
                    {
                        case "1":
                            listUser.Display();
                            listAllUser.ListAllUsers(users);
                            break;
                        case "2":
                            logInView.Display();
                            break;
                        case "3":
                            Console.WriteLine("Terminating application");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Sorry, but it seems something went wrong");
                            Console.ResetColor();
                            break;
                    }
                }
                else if (loggedInUser.Role == "Sysadmin")
                {
                    result = adminMainMenu.Display();
                    switch (result)
                    {
                        case "1":
                            result = manageUser.Display();
                            if (result.ToUpper() == "1")
                            {
                                adminAddUser.Display();
                                addUser.AddNewUser(adminAddUser.UserName, adminAddUser.Password, adminAddUser.Role, users);
                            }
                            else if (result.ToUpper() == "2")
                            {
                                adminDeleteUser.Display();
                                deleteUser.DeleteOfUser(users);
                            }
                            break;
                        case "2":
                            logInView.Display();
                            break;
                        case "3":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid selection, please try again!");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            break;
                    }
                }
            } while (loggedInUser != null);
        }
    }
}