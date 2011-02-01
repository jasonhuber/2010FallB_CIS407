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
        System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection();
        Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/productsdb.mdb");
        Conn.Open();
        //Response.Write(Conn.State);

        System.Data.OleDb.OleDbCommand Comm = new System.Data.OleDb.OleDbCommand();
        Comm.Connection = Conn;

        Comm.CommandText = "select productid, productname, productiondescription, price, qoh, imagelocation from products";

        System.Data.DataSet ds = new System.Data.DataSet();
        System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();

        da.SelectCommand = Comm;
        da.Fill(ds);

        Repeater1.DataSource = ds.Tables[0];
        Repeater1.DataBind();

    }
}