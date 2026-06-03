using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.DAL;
using Mini_Project.Models;

namespace Mini_Project.BAL
{
    internal class BookingBAL
    {
        BookingDAL bookingDAL = new BookingDAL();

        public void BookTicket(Booking booking)
        {
            if (booking.Passengers > 3)
            {
                Console.WriteLine("Maximum 3 Passengers Allowed");
                return;
            }

            bookingDAL.BookTicket(booking);
        }
        public void ViewBookings()
        {
            bookingDAL.ViewBookings();
        }

        public void ViewMyBookings(int trainNo)
        {
            bookingDAL.ViewMyBookings(trainNo);
        }
    }
}