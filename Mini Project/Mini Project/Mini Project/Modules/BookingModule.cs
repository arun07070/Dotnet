using System;
using Mini_Project.BAL;
using Mini_Project.Models;

namespace Mini_Project.Modules
{
    internal class BookingModule
    {
        BookingBAL bal = new BookingBAL();

        public void BookTicket()
        {
            Booking booking = new Booking();

            Console.Write("Train No : ");
            booking.TrainNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Travel Date : ");
            booking.TravelDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Class : ");
            booking.TravelClass = Console.ReadLine();

            Console.Write("Passengers(Max 3) : ");
            booking.Passengers = Convert.ToInt32(Console.ReadLine());

            bal.BookTicket(booking);
        }
    }
}