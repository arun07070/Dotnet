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
    public partial class AddEditMenu : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString);
        int menuId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (Request.QueryString["MenuId"] != null)
            {
                menuId = Convert.ToInt32(
                    Request.QueryString["MenuId"]);
                if (!IsPostBack)
                {
                    LoadData();
                }
            }
        }
        void LoadData()
        {
            SqlCommand cmd =
                new SqlCommand("SELECT * FROM MenuItems WHERE MenuId=@MenuId", con);
            cmd.Parameters.AddWithValue("@MenuId", menuId);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtItemName.Text = dr["ItemName"].ToString();
                txtCategory.Text = dr["Category"].ToString();
                ddlFoodType.Text = dr["FoodType"].ToString();
                txtPrice.Text = dr["Price"].ToString();
                txtQuantity.Text = dr["AvailableQuantity"].ToString();
                chkAvailable.Checked =
                    Convert.ToBoolean(dr["IsAvailable"]);
            }

            con.Close();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            if (Request.QueryString["MenuId"] != null)
            {
                cmd = new SqlCommand(
                    "UPDATE MenuItems SET ItemName=@ItemName,Category=@Category,FoodType=@FoodType,Price=@Price,AvailableQuantity=@Qty,IsAvailable=@Available WHERE MenuId=@MenuId", con);

                cmd.Parameters.AddWithValue("@MenuId", menuId);
            }
            else
            {
                cmd = new SqlCommand(
                    "INSERT INTO MenuItems VALUES(@ItemName,@Category,@FoodType,@Price,@Qty,@Available,GETDATE())", con);
            }
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@FoodType", ddlFoodType.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@Qty", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@Available", chkAvailable.Checked);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("MenuList.aspx");
        }
    }
}