using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Email : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEmailMe_Click(object sender, EventArgs e)
    {
        System.Net.Mail.MailMessage MM = new System.Net.Mail.MailMessage(
            "website@mywebsite.com",
            "Jasonhuber@gmail.com",
            "Thank you for your order!",
            "We just received an order for some new shoes.<br /> You have large feet."
            );

        MM.IsBodyHtml = true;

        System.Net.Mail.SmtpClient SMTPs = new System.Net.Mail.SmtpClient("localhost");

        SMTPs.Send(MM);

        

    }
}