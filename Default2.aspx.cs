using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 :  System.Web.UI.Page
{
    private const string CmdText = "insert into userinfo(FirstName,LastName,Username,Password) values (@FirstName, @LastName, @Username, @Password)";

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand(CmdText, con);
        cmd.Parameters.AddWithValue("@FirstName",TextBox1.Text);
        cmd.Parameters.AddWithValue("@LastName", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Username", TextBox3.Text);
     
        cmd.Parameters.AddWithValue("@Password", TextBox4.Text);
       
         cmd.ExecuteNonQuery();
        Response.Redirect("Default.aspx");



    }
}