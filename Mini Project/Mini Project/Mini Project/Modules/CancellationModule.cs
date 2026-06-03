using System;
using Mini_Project.BAL;

namespace Mini_Project.Modules
{
    internal class CancellationModule
    {
        CancellationBAL bal = new CancellationBAL();

        public void CancelTicket()
        {
            Console.Write("Booking Id : ");
            int bookingId = Convert.ToInt32(Console.ReadLine());

            bal.CancelTicket(bookingId);
        }
        public void ViewCancellations()
        {
            bal.ViewCancellations();
        }
    }
}