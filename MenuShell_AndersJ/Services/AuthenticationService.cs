﻿using MenuShell_AndersJ.Entities;
using System.Collections.Generic;

namespace MenuShell_AndersJ.Services
{
    class AuthenticationService : IAuthenticationService
    {
        public User Authenticate(string username, string password, List<User> users )
        {
            User _user = null;
 
            foreach (User user in users)
            {
                if (user.UserName == username && user.Password == password)
                {         
                    _user = user;
                    break;
                }
            }
            return _user;
        }
    }
}