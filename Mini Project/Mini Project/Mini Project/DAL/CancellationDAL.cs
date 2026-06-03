using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mini_Project.DAL
{
    internal class CancellationDAL
    {
        DBHelper db = new DBHelper();

        public void CancelTicket(int bookingId)
        {
            SqlConnection con = db.GetConnection();

            con.Open();

            SqlTransaction trans = con.BeginTransaction();

            try
            {
                SqlCommand cmd =
                new SqlCommand(
                "SELECT Passengers,TrainNo FROM BookingDetails WHERE BookingId=@Id",
                con, trans);

                cmd.Parameters.AddWithValue("@Id", bookingId);

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                int passengers = Convert.ToInt32(dr["Passengers"]);
                int trainNo = Convert.ToInt32(dr["TrainNo"]);

                dr.Close();

                decimal refund = passengers * 900;

                SqlCommand cmd2 = new SqlCommand(
                @"INSERT INTO CancellationDetails
                VALUES(@Bid,@Tickets,@Refund)",
                con, trans);

                cmd2.Parameters.AddWithValue("@Bid", bookingId);
                cmd2.Parameters.AddWithValue("@Tickets", passengers);
                cmd2.Parameters.AddWithValue("@Refund", refund);

                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand(
                @"UPDATE TrainDetails
                SET Availability = Availability + @Tickets
                WHERE TrainNo=@No",
                con, trans);

                cmd3.Parameters.AddWithValue("@Tickets", passengers);
                cmd3.Parameters.AddWithValue("@No", trainNo);

                cmd3.ExecuteNonQuery();

                trans.Commit();

                Console.WriteLine("Ticket Cancelled");
            }
            catch
            {
                trans.Rollback();
            }

            con.Close();
        }
        public void ViewCancellations()
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT *
      FROM CancellationDetails";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine();
            Console.WriteLine("CANCELLATION DETAILS");
            Console.WriteLine("------------------------------------------------");

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["CId"] + "\t" +
                    dr["BookingId"] + "\t" +
                    dr["NoTickets"] + "\t" +
                    dr["RefundAmount"]);
            }

            dr.Close();
            con.Close();
        }
    }
}