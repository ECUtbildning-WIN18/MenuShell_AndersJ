using System;
using System.Collections.Generic;
using MenuShell_AndersJ.Entities;
using MenuShell_AndersJ.View;

namespace MenuShell_AndersJ.Services
{
    class UserFinder
    {
        ManageUserView manageUserView = new ManageUserView();

        public void AddUser(string userName, string password, string role, List<User> users)
        {
            users.Add(new User(userName, password, role));
        }

        public void RemoveUser(User user, List<User> users)
        {
            users.Remove(user);   
        }

        public List<User> FindUsers(string searchWord, List<User> users)
        {
            List<User> _users = null;

            _users = users.FindAll(x => x.UserName.ToLower().Contains(searchWord.ToLower()));
       
            return _users;
        }

        public void ListUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($" Name:{user.UserName}");
            }
        }
    }
}