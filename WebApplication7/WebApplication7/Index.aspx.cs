using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication7
{
    public partial class Index : System.Web.UI.Page
    {
        SqlConnection conn;
        String st;
        protected void Page_Load(object sender, EventArgs e)
        {
            st = @"Data Source=GRAD24\MSSQLSERVER1;Initial Catalog=Sample;Integrated Security=True";
            conn= new SqlConnection(st);
        }

    
        protected void Button3_Click(object sender, EventArgs e)
        {
            
          
         
            using (conn)
            {
                String query = "INSERT INTO Emp (FirstName, LastName, Address1, Address2, EmailID) VALUES (@FN,@LN,@A1,@A2, @email)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    Response.Write("Connection MAde");
                    command.Parameters.AddWithValue("@FN", TextBox1.Text);
                    command.Parameters.AddWithValue("@LN", TextBox2.Text);
                    command.Parameters.AddWithValue("@A1", TextBox3.Text);
                    command.Parameters.AddWithValue("@A2", TextBox4.Text);
                    command.Parameters.AddWithValue("@email", TextBox5.Text);

                    conn.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        Response.Write("Connection MAde");
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        TextBox1.Text = null;
                        TextBox2.Text = null;
                        TextBox3.Text = null;
                        TextBox4.Text = null;
                        TextBox5.Text = null;

                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from Emp", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Response.Write("Connection MAde");
            GridView1.DataSource = dr;
            Response.Write("Connection MAde");
            GridView1.DataBind();
            Response.Write("Connection MAde");


        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}