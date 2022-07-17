using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

            UserRepository.Add("Zeynal", "Mikayilli", "Admin@gmail.com", "123321");


            while (true)
            {
                Console.WriteLine("/register");
                Console.WriteLine("/login");
                Console.WriteLine("/exit");
                Console.WriteLine();
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
                else if (command == "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found! ");
                }
                
            }
            

        }
    }
}
