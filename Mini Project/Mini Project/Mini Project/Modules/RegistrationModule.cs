using System;
using Mini_Project.Models;
using Mini_Project.BAL;

namespace Mini_Project.Modules
{
    internal class RegistrationModule
    {
        UserBAL userBAL = new UserBAL();

        public void Register()
        {
            Console.WriteLine("\n--- REGISTRATION ---");

            User user = new User();

            Console.Write("Name: ");
            user.UserName = Console.ReadLine();

            Console.Write("Password: ");
            user.Password = Console.ReadLine();

            user.UserType = "User";

            userBAL.Register(user);

            Console.WriteLine("User Registered Successfully");
        }
    }
}