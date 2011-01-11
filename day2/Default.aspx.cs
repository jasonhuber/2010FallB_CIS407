using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdLogon_Click(object sender, EventArgs e)
    {
        if (!invalidateUsername(txtUsername.Text))
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string sql = "select firstname, lastname from [users] where [username] = '" + username + "'";
            sql += " and [password] = '" + password + "'";
        }
    }

    //valid username characters:
    //aA1_.

    public bool invalidateUsername(string s)
    {
        bool bad = false;
        int n = 0;
        while (n < s.Length && !bad)
        {
            switch (s.Substring(n,1).ToLower())
            {
                case "a":
                case "b":
                case "c":
                case "d": 
                case "e":
                case "f":
                case "g":
                case "h":
                case "i":
                case "j":
                case "k":
                case "l":
                case "m":
                case "n":
                case "o":
                case "p":
                case "q":
                case "r":
                case "s":
                case "t":
                case "u":
                case "v":
                case "w":
                case "x":
                case "y":
                case "z":
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case ".":
                case "_":
                    //we are good!   
                    bad = false;
                break;

                default:
                    bad = true;
                    //uh oh
                    break;
            }
            n++;
        }
        return bad;
    }
}