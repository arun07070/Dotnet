using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mini_Project.DAL
{
    internal class ReportDAL
    {
        DBHelper db = new DBHelper();

        public void TotalRevenue()
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT ISNULL(SUM(Amount),0)
              FROM BookingDetails";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            decimal revenue =
                Convert.ToDecimal(cmd.ExecuteScalar());

            Console.WriteLine();
            Console.WriteLine("Total Revenue : " + revenue);

            con.Close();
        }

        public void TotalBookings()
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT COUNT(*)
              FROM BookingDetails";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            int bookings =
                Convert.ToInt32(cmd.ExecuteScalar());

            Console.WriteLine();
            Console.WriteLine("Total Bookings : " + bookings);

            con.Close();
        }

        public void ActiveTrains()
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT COUNT(*)
              FROM TrainDetails
              WHERE IsDeleted=0";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            int trains =
                Convert.ToInt32(cmd.ExecuteScalar());

            Console.WriteLine();
            Console.WriteLine("Active Trains : " + trains);

            con.Close();
        }
    }
}