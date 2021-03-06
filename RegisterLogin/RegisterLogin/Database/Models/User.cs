using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.Database
{
    class User
    {
        public DateTime RegisterDate { get; set; }
        public int Id { get; set; }

        private static int IdCounter = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public string Password { get; set; } 

        public User(string firstName, string lastName, string email, string password)
        {
            RegisterDate = DateTime.Now;
            Id = IdCounter++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public  string GetInfo()
        {
            return FirstName + " " + LastName + " " + Email + " " + RegisterDate;
        }

    }
}
