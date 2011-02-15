using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _getProductDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection();
        Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/productsdb.mdb");
        Conn.Open();
        //Response.Write(Conn.State);

        System.Data.OleDb.OleDbCommand Comm = new System.Data.OleDb.OleDbCommand();
        System.Data.OleDb.OleDbDataReader dr;
        Comm.Connection = Conn;


        Comm.CommandText = "select productid, productname, productiondescription, price, qoh, imagelocation from products";

        if (Request.Params["prodid"] != null && Request.Params["prodid"].Length >0)
        {
            Comm.CommandText += " where productid = ?" ;
            Comm.Parameters.AddWithValue("anything", Request.Params["prodid"].ToString()); 
        }

        dr = Comm.ExecuteReader();
        bool firstone = true;
        if (!dr.HasRows)
        {
            Response.Write("Sorry that productid was not found!");
        }
        while (dr.Read())
        {
            Response.Write("<h3>" + dr[1].ToString() + "</h3>");

        }
        


    }
}