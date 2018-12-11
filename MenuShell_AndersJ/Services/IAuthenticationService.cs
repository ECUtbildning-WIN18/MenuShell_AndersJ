using MenuShell_AndersJ.Entities;
using System.Collections.Generic;

namespace MenuShell_AndersJ.Services
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password, List<User> _users);  
    }
}