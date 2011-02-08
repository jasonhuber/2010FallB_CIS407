using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogon_Click(object sender, EventArgs e)
    {
        if (System.Web.Security.FormsAuthentication.Authenticate(txtUsername.Text, txtPassword.Text))
        {
            //System.Web.Security.FormsAuthentication.SetAuthCookie
            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
        }
        else
        {
            lblErr.Text = "You were not logged in!";
        }
    }
}