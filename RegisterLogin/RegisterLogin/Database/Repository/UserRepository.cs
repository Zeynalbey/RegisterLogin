using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.Database.Repository
{
    class UserRepository
    {
        public static List<User> users = new List<User>();
        public static void Add(string name, string lastName, string email, string password)
        {
            User user = new User(name, lastName, email, password);
            users.Add(user);

        }
    }
}
