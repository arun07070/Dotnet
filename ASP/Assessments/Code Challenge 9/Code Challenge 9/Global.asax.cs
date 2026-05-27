using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.SessionState;
using System.Web.Http;

namespace Code_Challenge_9
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["Visitors"] = 0;
            Application["ActiveUsers"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["Visitors"] =
                Convert.ToInt32(Application["Visitors"]) + 1;
            Application.UnLock();
        }
    }
}