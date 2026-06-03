using System;
using Mini_Project.BAL;

namespace Mini_Project.Modules
{
    internal class LoginModule
    {
        UserBAL userBAL = new UserBAL();

        public bool Login(string type)
        {
            Console.WriteLine("\n--- LOGIN ---");

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            bool result =
                userBAL.Login(username, password, type);

            if (result)
            {
                Console.WriteLine("Login Successful");
                return true;
            }

            Console.WriteLine("Invalid Login");

            return false;
        }
    }
}