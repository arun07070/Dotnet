using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Code_Challenge_9
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            Application["ActiveUsers"] =
                Convert.ToInt32(Application["ActiveUsers"]) - 1;
            Application.UnLock();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}