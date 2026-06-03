using System;
using System.Data.SqlClient;
using Mini_Project.Models;

namespace Mini_Project.DAL
{
    internal class UserDAL
    {
        DBHelper db = new DBHelper();

        public bool Login(string username, string password, string userType)
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT COUNT(*)
              FROM Users
              WHERE UserName=@UserName
              AND Password=@Password
              AND UserType=@UserType";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@UserType", userType);

            con.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            return count > 0;
        }

        public void Register(User user)
        {
            SqlConnection con = db.GetConnection();

            string query =
            @"INSERT INTO Users
            (UserName,Password,UserType)
            VALUES
            (@UserName,@Password,@UserType)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@UserType", user.UserType);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}