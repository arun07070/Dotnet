using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.Modules;

namespace Mini_Project.Menus
{
    internal class AdminMenu
    {
        public void Show()
        {
            TrainModule trainModule = new TrainModule();
            BookingModule bookingModule = new BookingModule();
            CancellationModule cancellationModule = new CancellationModule();
            ReportModule reportModule = new ReportModule();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("===== ADMIN MENU =====");
                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. View Trains");
                Console.WriteLine("3. Edit Train");
                Console.WriteLine("4. Delete Train");
                Console.WriteLine("5. View Bookings");
                Console.WriteLine("6. View Cancellations");
                Console.WriteLine("7. Reports");
                Console.WriteLine("8. Back To Main Menu");

                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        trainModule.AddTrain();
                        break;

                    case 2:
                        trainModule.ViewTrains();
                        break;

                    case 3:
                        trainModule.EditTrain();
                        break;

                    case 4:
                        Console.Write("Enter Train No : ");
                        int trainNo = Convert.ToInt32(Console.ReadLine());

                        trainModule.DeleteTrain(trainNo);
                        break;

                    case 5:
                        bookingModule.ViewBookings();
                        break;

                    case 6:
                        cancellationModule.ViewCancellations();
                        break;

                    case 7:
                        reportModule.ShowReport();
                        break;

                    case 8:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}