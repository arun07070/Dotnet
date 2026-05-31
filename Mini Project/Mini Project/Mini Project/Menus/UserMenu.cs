using System;
using Mini_Project.Modules;

namespace Mini_Project.Menus
{
    internal class UserMenu
    {
        public void Show()
        {
            BookingModule booking = new BookingModule();
            CancellationModule cancel = new CancellationModule();

            while (true)
            {
                Console.WriteLine("1.Book Ticket");
                Console.WriteLine("2.Cancel Ticket");
                Console.WriteLine("3.Back");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        booking.BookTicket();
                        break;

                    case 2:
                        cancel.CancelTicket();
                        break;

                    case 3:
                        return;
                }
            }
        }
    }
}