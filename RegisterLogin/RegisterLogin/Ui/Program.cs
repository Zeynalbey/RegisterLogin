using System;
using RegisterLogin.Database;
using RegisterLogin.Database.Repository;
using RegisterLogin.ValidationLogic;
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
            Console.WriteLine();

            while (true)
            {
                string command = Console.ReadLine();
                Console.WriteLine();

                if (command == "/register")
                {
                    Authentication.Register();
                }
                else if (command == "/login")
                {
                    Authentication.Login();
                }
                else
                {
                    Console.WriteLine("Command not found! ");
                }
            }
            

        }
    }
}
