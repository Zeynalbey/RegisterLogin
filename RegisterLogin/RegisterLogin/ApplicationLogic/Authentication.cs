using RegisterLogin.Database;
using RegisterLogin.Database.Repository;
using RegisterLogin.ValidationLogic.Validations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.ValidationLogic
{
    class Authentication
    {
        public static void Register()
        {


            Console.Write("Write name: ");
            string name = Console.ReadLine();
            Console.Write("Write surname: ");
            string lastName = Console.ReadLine();
            Console.Write("Write email: ");
            string email = Console.ReadLine();
            Console.Write("Write password: ");
            string password = Console.ReadLine();
            Console.Write("Please comfirm password: ");
            string comfirmPassword = Console.ReadLine();
            Console.WriteLine();


            ValidationName validationName = new ValidationName();
            ValidationLastName validationLastName = new ValidationLastName();
            ValidationEmailL validationEmail = new ValidationEmailL();
            ValidationPassword validationPassword = new ValidationPassword();

            if (validationName.IsCorrect(name) &
                validationLastName.IsCorrect(lastName) &
                validationEmail.IsEmailCorrect(email) &
                validationPassword.IsPasswordCorrect(password) &
                UserRepository.IsEqualComfirmPassword(password, comfirmPassword))
            {
                UserRepository.Add(name, lastName, email, password);

                Console.WriteLine($"{name}, you successfully registered, now you can login with your new account!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You couldn't register!");
                Console.WriteLine();
            }
        }

        public static void Login()
        {
            Console.Write("Please input your email: ");
            string email = Console.ReadLine();
            Console.Write("Please input your password: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            if (UserRepository.IsUserExistsByEmail(email, password))
            {
                Console.WriteLine("Well come to our application! ");
            }
            else if (email == "admin@gmail.com" && password == "123321")             //email:      admin@gmail.com        parol:  123321
            {
                Console.WriteLine("Welcome to your account, dear admin, Zeynal Mikayilli admin@gmail.com!");
                Console.WriteLine("/show-users");
                string command = Console.ReadLine();
                
                if (command == "/show-users")
                {
                    foreach (User user in UserRepository.ShowAllUsers())
                    {
                        Console.WriteLine(user.GetInfo());
                    }
                }
                else
                {
                    Console.WriteLine("not found");
                }
            }
            else
            {
                Console.WriteLine("Email or password is not correct! ");
            }

            Console.WriteLine();

            








        }
    }
}
