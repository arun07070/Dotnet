using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mini_Project.Models;

namespace Mini_Project.DAL
{
    internal class BookingDAL
    {
        DBHelper db = new DBHelper();

        public void BookTicket(Booking booking)
        {
            SqlConnection con = db.GetConnection();

            con.Open();

            SqlTransaction trans = con.BeginTransaction();

            try
            {
                SqlCommand cmd1 = new SqlCommand(
                "SELECT Availability,Charges FROM TrainDetails WHERE TrainNo=@No",
                con, trans);

                cmd1.Parameters.AddWithValue("@No", booking.TrainNo);

                SqlDataReader dr = cmd1.ExecuteReader();

                dr.Read();

                int available = Convert.ToInt32(dr["Availability"]);
                decimal charge = Convert.ToDecimal(dr["Charges"]);

                dr.Close();

                if (booking.Passengers > 3)
                {
                    Console.WriteLine("Maximum 3 Passengers Allowed");
                    return;
                }

                if (available < booking.Passengers)
                {
                    Console.WriteLine("Tickets Not Available");
                    return;
                }

                decimal amount = charge * booking.Passengers;

                SqlCommand cmd2 = new SqlCommand(
                @"INSERT INTO BookingDetails
                (TravelDate,TrainNo,TravelClass,Passengers,Amount)
                VALUES(@Date,@No,@Class,@Passengers,@Amount)",
                con, trans);

                cmd2.Parameters.AddWithValue("@Date", booking.TravelDate);
                cmd2.Parameters.AddWithValue("@No", booking.TrainNo);
                cmd2.Parameters.AddWithValue("@Class", booking.TravelClass);
                cmd2.Parameters.AddWithValue("@Passengers", booking.Passengers);
                cmd2.Parameters.AddWithValue("@Amount", amount);

                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand(
                @"UPDATE TrainDetails
                SET Availability = Availability - @Passengers
                WHERE TrainNo=@No",
                con, trans);

                cmd3.Parameters.AddWithValue("@Passengers", booking.Passengers);
                cmd3.Parameters.AddWithValue("@No", booking.TrainNo);

                cmd3.ExecuteNonQuery();

                trans.Commit();

                Console.WriteLine("Booking Successful");
            }
            catch
            {
                trans.Rollback();
            }

            con.Close();
        }
        public void ViewBookings()
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT *
      FROM BookingDetails";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine();
            Console.WriteLine("BOOKING DETAILS");
            Console.WriteLine("------------------------------------------------------------");

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["BookingId"] + "\t" +
                    Convert.ToDateTime(dr["BookDate"]).ToShortDateString() + "\t" +
                    Convert.ToDateTime(dr["TravelDate"]).ToShortDateString() + "\t" +
                    dr["TrainNo"] + "\t" +
                    dr["TravelClass"] + "\t" +
                    dr["Passengers"] + "\t" +
                    dr["Amount"]);
            }

            dr.Close();
            con.Close();
        }
        public void ViewMyBookings(int trainNo)
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT *
      FROM BookingDetails
      WHERE TrainNo=@TrainNo";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TrainNo", trainNo);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine();
            Console.WriteLine("MY BOOKINGS");
            Console.WriteLine("------------------------------------------------------------");

            bool found = false;

            while (dr.Read())
            {
                found = true;

                Console.WriteLine(
                    dr["BookingId"] + "\t" +
                    Convert.ToDateTime(dr["TravelDate"]).ToShortDateString() + "\t" +
                    dr["TrainNo"] + "\t" +
                    dr["TravelClass"] + "\t" +
                    dr["Passengers"] + "\t" +
                    dr["Amount"]);
            }

            if (!found)
            {
                Console.WriteLine("No Booking Found");
            }

            dr.Close();
            con.Close();
        }
    }
}