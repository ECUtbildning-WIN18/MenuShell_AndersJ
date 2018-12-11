using MenuShell_AndersJ.Entities;
using System.Collections.Generic;

namespace MenuShell_AndersJ.Services
{
    class AddUser
    {
        public void AddNewUser(string userName, string password, string role, List<User> users)
        {
            users.Add(new User(userName, password, role));
        }
    }
}