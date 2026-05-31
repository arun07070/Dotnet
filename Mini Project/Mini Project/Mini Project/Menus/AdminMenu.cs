using System;
using Mini_Project.Modules;

namespace Mini_Project.Menus
{
    internal class AdminMenu
    {
        public void Show()
        {
            TrainModule train = new TrainModule();

            while (true)
            {
                Console.WriteLine("1.Add Train");
                Console.WriteLine("2.View Trains");
                Console.WriteLine("3.Back");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        train.AddTrain();
                        break;

                    case 2:
                        train.ViewTrains();
                        break;

                    case 3:
                        return;
                }
            }
        }
    }
}