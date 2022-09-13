using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class User
    {
        public string Login;
        public string Password;
        public Basket[] Baskets;
        public User(string login, string password, Basket[] baskets)
        {
            Login = login;
            Password = password;
            Baskets = baskets;
        }
    }
}
