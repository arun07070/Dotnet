using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.Modules
{
    internal class LoginModule
    {
        public bool AdminLogin()
        {
            Console.Write("User Name : ");
            string user = Console.ReadLine();

            Console.Write("Password : ");
            string pass = Console.ReadLine();

            if (user == "admin" && pass == "admin")
            {
                return true;
            }

            Console.WriteLine("Invalid Login");
            return false;
        }
    }
}