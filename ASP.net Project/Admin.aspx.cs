using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.net_Project
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                Settings settings = (Settings)Application["settings"];
                TextBoxDefaultText1.Text = settings.DefaultText;    
                TextBoxDefaultText2.Text = settings.DefaultText2;
                TextBoxHeaderText.Text = settings.HeaderText;
                TextBoxFooterText.Text = settings.FooterText;
            }
            

        }

        protected void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            Settings settings = (Settings)Application["settings"];
            settings.DefaultText = TextBoxDefaultText1.Text;
            settings.DefaultText2 = TextBoxDefaultText2.Text;
            settings.HeaderText = TextBoxHeaderText.Text;
            settings.FooterText = TextBoxFooterText.Text;
            Manager.SaveSettings(Server.MapPath("~/App_Start/settings.xml"), settings);
            Application["settings"] = settings;  
        }
    }
}