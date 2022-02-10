using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.net_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Settings settings = (Settings)Application["settings"];
               
                LabelDefaultText1.Text = settings.DefaultText;
                LabelDefaultText2.Text = settings.DefaultText2;
            }
            catch (Exception)
            {
                
            }
        }
        
    }
}