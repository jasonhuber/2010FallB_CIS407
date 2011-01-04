using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtNum2.Text = "4";
            txtNum1.Text = "5";
        }
    }
    protected void cmdAdd_Click(object sender, EventArgs e)
    {
        lblResult.Text = (int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text)).ToString();
    }
}
