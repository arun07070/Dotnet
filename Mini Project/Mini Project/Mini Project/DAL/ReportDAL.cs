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

        public void ShowTrainReport()
        {
            SqlConnection con = db.GetConnection();

            string query = "SELECT * FROM TrainDetails WHERE IsDeleted=0";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\nTRAIN REPORT");

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["TrainNo"] + "\t" +
                    dr["TrainName"] + "\t" +
                    dr["FromStation"] + "\t" +
                    dr["ToStation"] + "\t" +
                    dr["Availability"]);
            }

            con.Close();
        }

        public void ShowBookingReport()
        {
            SqlConnection con = db.GetConnection();

            string query = "SELECT * FROM BookingDetails";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\nBOOKING REPORT");

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["BookingId"] + "\t" +
                    dr["TrainNo"] + "\t" +
                    dr["Passengers"] + "\t" +
                    dr["Amount"]);
            }

            con.Close();
        }
    }
}