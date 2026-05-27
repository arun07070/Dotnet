using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Code_Challenge_9
{
    public partial class MenuDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            int id = Convert.ToInt32(
                Request.QueryString["MenuId"]);
            SqlCommand cmd =
                new SqlCommand("SELECT * FROM MenuItems WHERE MenuId=@MenuId", con);
            cmd.Parameters.AddWithValue("@MenuId", id);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblDetails.Text =
                    "Item Name : " + dr["ItemName"] + "<br/>" +
                    "Category : " + dr["Category"] + "<br/>" +
                    "Food Type : " + dr["FoodType"] + "<br/>" +
                    "Price : " + dr["Price"];
            }
            con.Close();
        }
    }
}