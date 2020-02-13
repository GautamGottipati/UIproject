using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JqueryProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\GAUTAM_GOTTIPATI\SOURCE\REPOS\UIPROJECT\JQUERYPROJECT\APP_DATA\DATABASE1.MDF;Integrated Security=True"))
            {
                //With Sql Injection 

                // email = c@g.com'delete from Login where id=3;--'
                string query = $"SELECT COUNT(1) FROM Login WHERE Name='"+Text1.Value+"'"+ "AND Emailid ='"+Text2.Value+"'";
                SqlCommand cmd = new SqlCommand(query, scon);
                // Inorder to prevent SQL injection we execute the below code 
                //string query = $"SELECT COUNT(1) FROM Login WHERE Name=@Name AND Emailid =@Email";
                // SqlCommand cmd = new SqlCommand(query, scon);
                // cmd.Parameters.AddWithValue("@Name", Text1.Value.Trim());
                // cmd.Parameters.AddWithValue("@Email", Text2.Value.Trim());
                scon.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count == 1)
                {
                    Session["username"] = Text1.Value.Trim();
                    Response.Redirect("Success.aspx");
                }
                else
                {
                    Label5.Visible = true;
                }


            }
        }
    }
}