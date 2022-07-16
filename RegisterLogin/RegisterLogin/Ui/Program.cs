using System;
using RegisterLogin.Database;
using RegisterLogin.Database.Repository;
using RegisterLogin.ValidationLogic.Validations;

namespace RegisterLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Our commands:");
            Console.WriteLine("/register");
            Console.WriteLine("/login");

            string command = Console.ReadLine();

            if (command == "/register")
            {
                Console.Write("Write name:");
                string name = Console.ReadLine();
                Console.Write("Write surname:");
                string lastName = Console.ReadLine();
                Console.Write("Write email:");
                string email = Console.ReadLine();
                Console.Write("Write password:");
                string password = Console.ReadLine();
                ValidationName validationName = new ValidationName();
                ValidationLastName validationLastName = new ValidationLastName();
                ValidationEmailL validationEmail = new ValidationEmailL();

                if (validationName.IsCorrect(name) & validationLastName.IsCorrect(lastName)& validationEmail.IsEmailCorrect(email))
                {
                    UserRepository.Add(name,lastName,email,password);
                    Console.WriteLine($"{name} {lastName} added" );
                }
                else
                {
                    Console.WriteLine("Qeydiyyat bas tutmadi.");
                }

            }
            else if(command == "/login")
            {
                
            }
            else
            {
                Console.WriteLine("Duzgun komanda daxil edin.");
            }

        }
    }
}
