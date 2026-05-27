using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Code_Challenge_9
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" &&
                txtPassword.Text == "food@123")
            {
                Session["Username"] = txtUsername.Text;
                Session["Role"] = "Admin";
                Application.Lock();
                Application["ActiveUsers"] =
                    Convert.ToInt32(Application["ActiveUsers"]) + 1;
                Application.UnLock();
                Response.Redirect("MenuList.aspx");
            }
            else
            {
                lblMessage.Text =
                    "Invalid login. You are not authorized.";
            }
        }
    }
}