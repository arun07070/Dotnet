using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mini_Project.Models;

namespace Mini_Project.DAL
{
    internal class TrainDAL
    {
        DBHelper db = new DBHelper();

        public void AddTrain(Trains train)
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"INSERT INTO TrainDetails
            (TrainNo,TrainName,FromStation,ToStation,TravelClass,Availability,Charges,IsDeleted)
            VALUES
            (@TrainNo,@TrainName,@FromStation,@ToStation,@TravelClass,@Availability,@Charges,0)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TrainNo", train.TrainNo);
            cmd.Parameters.AddWithValue("@TrainName", train.TrainName);
            cmd.Parameters.AddWithValue("@FromStation", train.FromStation);
            cmd.Parameters.AddWithValue("@ToStation", train.ToStation);
            cmd.Parameters.AddWithValue("@TravelClass", train.TravelClass);
            cmd.Parameters.AddWithValue("@Availability", train.Availability);
            cmd.Parameters.AddWithValue("@Charges", train.Charges);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Train Added Successfully");
            }
            else
            {
                Console.WriteLine("Failed to Add Train");
            }

            con.Close();
        }

        public void ViewTrains()
        {
            SqlConnection con = db.GetConnection();

            string query =
            "SELECT * FROM TrainDetails WHERE IsDeleted = 0";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine();
            Console.WriteLine("TRAIN DETAILS");
            Console.WriteLine("------------------------------------------------------------");

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["TrainNo"] + "\t" +
                    dr["TrainName"] + "\t" +
                    dr["FromStation"] + "\t" +
                    dr["ToStation"] + "\t" +
                    dr["TravelClass"] + "\t" +
                    dr["Availability"] + "\t" +
                    dr["Charges"]);
            }

            dr.Close();
            con.Close();
        }

        public void DeleteTrain(int trainNo)
        {
            SqlConnection con = db.GetConnection();

            con.Open();

            string checkQuery =
            "SELECT COUNT(*) FROM BookingDetails WHERE TrainNo=@TrainNo";

            SqlCommand checkCmd =
            new SqlCommand(checkQuery, con);

            checkCmd.Parameters.AddWithValue("@TrainNo", trainNo);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                Console.WriteLine("Cannot Delete Train. Booking Exists.");

                con.Close();
                return;
            }

            string deleteQuery =
            @"UPDATE TrainDetails
              SET IsDeleted = 1
              WHERE TrainNo=@TrainNo";

            SqlCommand deleteCmd =
            new SqlCommand(deleteQuery, con);

            deleteCmd.Parameters.AddWithValue("@TrainNo", trainNo);

            int rows = deleteCmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Train Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Train Not Found");
            }

            con.Close();
        }

        public void SearchTrain(string fromStation, string toStation)
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT *
      FROM TrainDetails
      WHERE FromStation=@FromStation
      AND ToStation=@ToStation
      AND IsDeleted=0";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@FromStation", fromStation);
            cmd.Parameters.AddWithValue("@ToStation", toStation);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine();
            Console.WriteLine("TRAIN DETAILS");
            Console.WriteLine("------------------------------------------------------------");

            bool found = false;

            while (dr.Read())
            {
                found = true;

                Console.WriteLine(
                    dr["TrainNo"] + "\t" +
                    dr["TrainName"] + "\t" +
                    dr["FromStation"] + "\t" +
                    dr["ToStation"] + "\t" +
                    dr["TravelClass"] + "\t" +
                    dr["Availability"] + "\t" +
                    dr["Charges"]);
            }

            if (!found)
            {
                Console.WriteLine("No Trains Found");
            }
            dr.Close();
            con.Close();
        }
        public void EditTrain(Trains train)
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"UPDATE TrainDetails
      SET TrainName=@TrainName,
          FromStation=@FromStation,
          ToStation=@ToStation,
          TravelClass=@TravelClass,
          Availability=@Availability,
          Charges=@Charges
      WHERE TrainNo=@TrainNo";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TrainNo", train.TrainNo);
            cmd.Parameters.AddWithValue("@TrainName", train.TrainName);
            cmd.Parameters.AddWithValue("@FromStation", train.FromStation);
            cmd.Parameters.AddWithValue("@ToStation", train.ToStation);
            cmd.Parameters.AddWithValue("@TravelClass", train.TravelClass);
            cmd.Parameters.AddWithValue("@Availability", train.Availability);
            cmd.Parameters.AddWithValue("@Charges", train.Charges);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Train Updated Successfully");
            }
            else
            {
                Console.WriteLine("Train Not Found");
            }

            con.Close();
        }
    }
}