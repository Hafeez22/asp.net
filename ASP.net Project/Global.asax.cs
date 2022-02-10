using System ;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ASP.net_Project
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application.Add("key", "12345");
            String key = (String)Application["key"];

            Settings settings = Manager.LoadSettings(Server.MapPath("~/App_Start/settings.xml"));
            Application.Add("settings", settings);
            
        }
        void Session_Start(object sender, EventArgs e)
        {
            if (Application["Counter"] == null)
            {
                Application.Add("Counter", 0);
            }
            int counter = Convert.ToInt32(Application["Counter"]);
            counter++;
            Application["Counter"] = counter.ToString() ;
            
        }
    }
}