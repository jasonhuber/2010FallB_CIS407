using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class insertproduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection();
        Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/productsdb.mdb");
        Conn.Open();
        //Response.Write(Conn.State);

        string strSQL = "insert into products (productid, productname, productiondescription, price, qoh, imagelocation) values (?,?,?,?,?,?)";
        object returnVal;

        System.Data.OleDb.OleDbCommand Comm = new System.Data.OleDb.OleDbCommand();
        Comm.Connection = Conn;

        Comm.CommandText = "select productid from products where productid = ?";
        Comm.Parameters.AddWithValue("productid", txtProductId.Text);
        returnVal = Comm.ExecuteScalar();
        if (returnVal == null)
        {//begintrans
            try
            {
                Comm.Parameters.Clear();
                Comm.CommandText = strSQL;
                Comm.Parameters.AddWithValue("productid", txtProductId.Text);
                Comm.Parameters.AddWithValue("productname", txtName.Text);
                Comm.Parameters.AddWithValue("productiondescription", txtDescription.Text);
                Comm.Parameters.AddWithValue("price", txtPrice.Text);
                Comm.Parameters.AddWithValue("qoh", txtQOH.Text);


                //wait to save the record to the db in case this fails.
                string thefile = txtFile.PostedFile.FileName;
                string filename = "", filepath, fullpath;
                if (thefile.Length > 0)
                {
                    filepath = MapPath("") + "\\images\\";
                    filename = thefile.Substring(thefile.LastIndexOf("\\") + 1);
                    fullpath = filepath + filename;
                    if (!System.IO.File.Exists(fullpath))
                    {
                        txtFile.PostedFile.SaveAs(fullpath);
                    }
                    else
                    {
                        throw new Exception("File already exists!");
                        //file already there
                    }
                }
                Comm.Parameters.AddWithValue("imagelocation", filename);
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
      
        }
        else
        {
            Response.Write("ProductId already exists--please try again.");
        }
        Conn.Close();
        Conn = null;

    }
}