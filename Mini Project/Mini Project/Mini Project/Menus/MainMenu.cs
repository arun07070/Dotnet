using System;

namespace Mini_Project.Menus
{
    internal class MainMenu
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("===== TRAIN RESERVATION SYSTEM =====");
                Console.WriteLine("1.Admin");
                Console.WriteLine("2.User");
                Console.WriteLine("3.Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        new AdminMenu().Show();
                        break;

                    case 2:
                        new UserMenu().Show();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}