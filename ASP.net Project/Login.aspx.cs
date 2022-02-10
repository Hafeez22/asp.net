using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.net_Project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string UserName = WebConfigurationManager.AppSettings["LogUserName"];
            string PassWord = WebConfigurationManager.AppSettings["LogPassWord"];

            if (TextBoxUsername.Text == UserName && TextBoxPassword.Text == PassWord)
            {
                Session.Add("User", UserName);
                Response.Redirect("Admin.aspx");
            }
            else
            {
                LabelMessage.Text = "Invalid Credentials";
            }
        }
    }
}