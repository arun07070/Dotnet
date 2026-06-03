using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.Modules;

namespace Mini_Project.Menus
{
    internal class MainMenu
    {
        public void Show()
        {
            LoginModule loginModule = new LoginModule();
            RegistrationModule registrationModule = new RegistrationModule();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("===== TRAIN RESERVATION SYSTEM =====");
                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. User Login");
                Console.WriteLine("3. Register");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine();
                        Console.WriteLine("--- ADMIN LOGIN ---");

                        if (loginModule.Login("Admin"))
                        {
                            AdminMenu adminMenu = new AdminMenu();
                            adminMenu.Show();
                        }

                        break;

                    case 2:

                        Console.WriteLine();
                        Console.WriteLine("--- USER LOGIN ---");

                        if (loginModule.Login("User"))
                        {
                            UserMenu userMenu = new UserMenu();
                            userMenu.Show();
                        }

                        break;

                    case 3:

                        registrationModule.Register();

                        break;

                    case 4:

                        Console.WriteLine("Thank You For Using Train Reservation System");
                        Environment.Exit(0);

                        break;

                    default:

                        Console.WriteLine("Invalid Choice");

                        break;
                }
            }
        }
    }
}