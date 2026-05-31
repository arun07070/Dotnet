using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mini_Project.Models;

namespace Mini_Project.DAL
{
    internal class UserDAL
    {
        DBHelper db = new DBHelper();

        public bool Register(User user)
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"INSERT INTO Users(UserName,Password,UserType)
              VALUES(@u,@p,@t)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@u", user.UserName);
            cmd.Parameters.AddWithValue("@p", user.Password);
            cmd.Parameters.AddWithValue("@t", user.UserType);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            con.Close();

            return rows > 0;
        }
    }
}