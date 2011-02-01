using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updateproduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection();
            Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/productsdb.mdb");
            Conn.Open();

            System.Data.OleDb.OleDbCommand Comm = new System.Data.OleDb.OleDbCommand();
            Comm.Connection = Conn;

            Comm.CommandText = "select productid, productname, productiondescription, price, qoh, imagelocation from products where productid = ?";
            Comm.Parameters.AddWithValue("productid", Request.Params["productid"].ToString());
            System.Data.OleDb.OleDbDataReader DR;
            DR = Comm.ExecuteReader();
            while (DR.Read())
            {
                txtProductId.Text = DR.GetValue(0).ToString();
                txtName.Text = DR.GetValue(1).ToString();
                txtDescription.Text = DR.GetValue(2).ToString();
                txtPrice.Text = DR.GetValue(3).ToString();
                txtQOH.Text = DR.GetValue(4).ToString();
            }

        }

}
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection();
        Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/productsdb.mdb");
        Conn.Open();
        //Response.Write(Conn.State);

        string strSQL = "update products set productname = ?, productiondescription = ?, price = ?, qoh = ? where productid = ?";
       
        System.Data.OleDb.OleDbCommand Comm = new System.Data.OleDb.OleDbCommand();
        Comm.Connection = Conn;

            try
            {
                Comm.Parameters.Clear();
                Comm.CommandText = strSQL;
                Comm.Parameters.AddWithValue("productname", txtName.Text);
                Comm.Parameters.AddWithValue("productiondescription", txtDescription.Text);
                Comm.Parameters.AddWithValue("price", txtPrice.Text);
                Comm.Parameters.AddWithValue("qoh", txtQOH.Text);
                Comm.Parameters.AddWithValue("productid", txtProductId.Text);
                Comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                //.rollback
            }
            finally
            { 
                //.commit
            }
      
        Conn.Close();
        Conn = null;

        Response.Redirect("default.aspx");
    }
}