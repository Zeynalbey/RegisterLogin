using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.Database
{
    class User
    {
        public int Id { get; set; }

        private static int IdCounter = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public string Password { get; set; } 

        public User(string firstName, string lastName, string email, string password)
        {
            Id = IdCounter++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

    }
}
