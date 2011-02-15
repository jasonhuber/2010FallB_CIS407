using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _getProducts : System.Web.UI.Page
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

        if (Request.Params["categoryid"] != null && Request.Params["categoryid"].Length >0)
        {
            Comm.CommandText += " where categoryid = ?" ;
            Comm.Parameters.AddWithValue("anything", Request.Params["categoryid"].ToString()); 
        }

        dr = Comm.ExecuteReader();
        bool firstone = true;
        Response.Write("{\"product\":[");
        while (dr.Read())
        { 
             if (!firstone)
            {
                Response.Write(",");   
            }
            Response.Write(dr[0].ToString());
          
            firstone = false;

        }
        Response.Write("]}");


    }
}