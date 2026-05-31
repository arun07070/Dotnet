using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.Models;
using Mini_Project.BAL;

namespace Mini_Project.Modules
{
    internal class RegistrationModule
    {
        UserBAL userBAL = new UserBAL();

        public void Register()
        {
            User user = new User();

            Console.Write("User Name : ");
            user.UserName = Console.ReadLine();

            Console.Write("Password : ");
            user.Password = Console.ReadLine();

            user.UserType = "User";

            bool result = userBAL.Register(user);

            if (result)
                Console.WriteLine("Registration Successful");
            else
                Console.WriteLine("Registration Failed");
        }
    }
}