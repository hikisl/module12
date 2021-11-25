using System;
using System.Collections.Generic;

namespace module12
{
    public class ListUsers
    {
        private List<Users> usersList = new List<Users>();


        public List<Users> GetUsers()
        {
            usersList.Add(new Users { Login = "strit", Name = "Виктор", IsPremium = false });
            usersList.Add(new Users { Login = "GEbHS", Name = "Ирина", IsPremium = false });
            usersList.Add(new Users { Login = "hzveW", Name = "Михаил", IsPremium = true });
            usersList.Add(new Users { Login = "stcsa", Name = "Виктория", IsPremium = true });


            return usersList;
        }
    }
}
