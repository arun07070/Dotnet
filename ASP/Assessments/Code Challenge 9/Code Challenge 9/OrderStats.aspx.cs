using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Code_Challenge_9
{
    public partial class OrderStats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            lblStats.Text =
                "Total Visitors : " + Application["Visitors"] +
                "<br/><br/>Current Active Users : " +
                Application["ActiveUsers"];
            if (Cache["FoodCategoryStats"] == null)
            {
                Cache["FoodCategoryStats"] =
                    "Cached Food Summary Created at : " +
                    DateTime.Now.ToString();
                Cache.Insert(
                    "FoodCategoryStats",
                    Cache["FoodCategoryStats"],
                    null,
                    DateTime.Now.AddMinutes(5),
                    System.Web.Caching.Cache.NoSlidingExpiration);
            }
            lblStats.Text +=
                "<br/><br/>Cache Data : " +
                Cache["FoodCategoryStats"];
        }
    }
}