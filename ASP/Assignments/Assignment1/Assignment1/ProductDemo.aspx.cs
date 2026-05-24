using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class ProductDemo : System.Web.UI.Page
    {
        string dbConnection =
            ConfigurationManager.ConnectionStrings["EmployeeDBConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayProducts();
                ddlItems.Items.Insert(0,
                    new ListItem("--Choose Product--", ""));
            }
        }
        private void DisplayProducts()
        {
            using (SqlConnection sqlCon = new SqlConnection(dbConnection))
            {
                SqlCommand sqlCmd =
                    new SqlCommand("SELECT ProductId, ProductName FROM Products", sqlCon);
                sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                ddlItems.DataSource = reader;
                ddlItems.DataTextField = "ProductName";
                ddlItems.DataValueField = "ProductId";
                ddlItems.DataBind();
            }
        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlItems.SelectedValue == "")
            {
                imgItems.ImageUrl = "";
                lblAmount.Text = "";
                return;
            }
            int itemId = Convert.ToInt32(ddlItems.SelectedValue);
            using (SqlConnection sqlCon = new SqlConnection(dbConnection))
            {
                SqlCommand sqlCmd =
                    new SqlCommand("SELECT ImagePath FROM Products WHERE ProductId=@ProductId", sqlCon);
                sqlCmd.Parameters.AddWithValue("@ProductId", itemId);
                sqlCon.Open();
                string imageValue = Convert.ToString(sqlCmd.ExecuteScalar());
                sqlCon.Close();
                imgItems.ImageUrl = imageValue;
                lblAmount.Text = "";
            }
        }
        protected void btnShowPrice_Click(object sender, EventArgs e)
        {
            if (ddlItems.SelectedValue == "")
            {
                lblAmount.Text = "Select any product";
                return;
            }
            int itemId = Convert.ToInt32(ddlItems.SelectedValue);
            using (SqlConnection sqlCon = new SqlConnection(dbConnection))
            {
                SqlCommand sqlCmd =
                    new SqlCommand("SELECT Price FROM Products WHERE ProductId=@ProductId", sqlCon);
                sqlCmd.Parameters.AddWithValue("@ProductId", itemId);
                sqlCon.Open();
                object itemPrice = sqlCmd.ExecuteScalar();
                sqlCon.Close();
                lblAmount.Text = "Product Price : Rs. " + itemPrice;
            }
        }
    }
}