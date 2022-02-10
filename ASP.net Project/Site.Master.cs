using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.net_Project
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Settings settings = (Settings)Application["settings"];
           
            

            if (Session["User"] == null)
            {
                LinkButtonLogout.Visible = false;
            }
            else
            {
                LinkButtonLogout.Visible = true;
            }
            LabelCounter.Text = Application["Counter"].ToString();
            try
            {
               
                LabelHeaderText.Text = settings.HeaderText;
                LabelFooterText.Text = settings.FooterText;
            }
            catch (Exception)
            {

            }
        }

        protected void LinkButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("Default.aspx");
        }
        
    }
}