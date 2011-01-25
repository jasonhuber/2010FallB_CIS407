using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ReadData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection();
            Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/products.mdb");
            Conn.Open();
            //Response.Write(Conn.State);

            System.Data.OleDb.OleDbCommand Comm = new System.Data.OleDb.OleDbCommand();
            Comm.Connection = Conn;

            Comm.CommandText = "select firstname, lastname, email, [username] from [users]";

            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();

            da.SelectCommand = Comm;
            da.Fill(ds);

            Repeater1.DataSource = ds.Tables[0];
            Repeater1.DataBind();

             /*  
            //need to get a dataset or reader back here.
            System.Data.OleDb.OleDbDataReader DR;
            DR = Comm.ExecuteReader();

            Repeater1.DataSource = DR;
            Repeater1.DataBind();
            */

            Conn.Close();
            Conn = null;
        }
    }
}