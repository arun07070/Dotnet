using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Code_Challenge_9
{
    public partial class MenuList : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                LoadMenu();
            }
        }

        void LoadMenu()
        {
            SqlDataAdapter da =
                new SqlDataAdapter("SELECT * FROM MenuItems", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvMenu.DataSource = dt;
            gvMenu.DataBind();
        }

        protected void gvMenu_RowDeleting(object sender,
            System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(
                gvMenu.DataKeys[e.RowIndex].Value);
            SqlCommand cmd =
                new SqlCommand("DELETE FROM MenuItems WHERE MenuId=@MenuId", con);
            cmd.Parameters.AddWithValue("@MenuId", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            LoadMenu();
        }
    }
}