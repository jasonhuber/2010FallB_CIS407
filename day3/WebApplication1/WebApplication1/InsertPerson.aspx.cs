using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class InsertPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection();
            Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/products.mdb");
            Conn.Open();
            //Response.Write(Conn.State);

            string strSQL = "insert into [users] ([username], firstname, lastname, email, [password]) values (?,?,?,?,?)";
            object returnVal;

            System.Data.OleDb.OleDbCommand Comm = new System.Data.OleDb.OleDbCommand();
            Comm.Connection = Conn;

            Comm.CommandText = "select [username] from [users] where [username] = ?";
            Comm.Parameters.AddWithValue("[username]", txtUserName.Text);
            returnVal = Comm.ExecuteScalar();
            if (returnVal == null)
            {
                Comm.Parameters.Clear();
                Comm.CommandText = strSQL;
                Comm.Parameters.AddWithValue("username", txtUserName.Text);
                Comm.Parameters.AddWithValue("firstname", txtFName.Text);
                Comm.Parameters.AddWithValue("lastname", txtLName.Text);
                Comm.Parameters.AddWithValue("email", txtEmail.Text);
                Comm.Parameters.AddWithValue("password", txtPassword.Text);
                Comm.ExecuteNonQuery();
            }
            else {
                Response.Write("Username already exists.");
            }
            Conn.Close();
            Conn = null;

        }
    }
}