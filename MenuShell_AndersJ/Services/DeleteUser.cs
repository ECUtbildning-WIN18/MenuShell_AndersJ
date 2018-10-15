using MenuShell_AndersJ.Entities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MenuShell_AndersJ.Services
{
    class DeleteUser
    {
        public void DeleteOfUser(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($" ({ i + 1}) {users[i].UserName}");
            }

            Console.WriteLine("Pick the user you want to delete by number");
            int deleteChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("You will now delete this user!");
            Thread.Sleep(1000);
            users.RemoveAt(deleteChoice - 1);

        }
    }
}