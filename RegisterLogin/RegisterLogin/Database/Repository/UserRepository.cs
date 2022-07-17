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
            //Console.WriteLine(DateTime.Now.ToString());


        }

        public static bool IsEqualComfirmPassword(string password, string comfirmPassword)
        {
            if (comfirmPassword == password )
            {

                return true;
            }

            Console.WriteLine("Passwords don't match! ");

            return false;
        }
    
        
        public static bool IsUserExistsByEmail(string email, string comfirmPassword)
        {
            foreach (User user in users)
            {
                if (user.Email == email && user.Password == comfirmPassword)
                {
                    foreach (User user1 in users)
                    {
                        if (user1.Id == user.Id)
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }

            return false;
        }


           













    }
}
