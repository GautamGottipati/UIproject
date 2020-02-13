using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIproject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Connecting the database 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\GAUTAM_GOTTIPATI\SOURCE\REPOS\UIPROJECT\UIPROJECT\APP_DATA\DATABASE1.MDF;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Country", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Clearing all the elements from the DropDownList2 
            DropDownList2.Items.Clear();
            // Adding element ' Select State ' 
            DropDownList2.Items.Add("Select State");
            // Connecting the database
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\GAUTAM_GOTTIPATI\SOURCE\REPOS\UIPROJECT\UIPROJECT\APP_DATA\DATABASE1.MDF; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from State where cid=" + DropDownList1.SelectedItem.Value, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clearing all the elements from the DropDownList2 
            DropDownList3.Items.Clear();
            // Adding elemets ' Select State '
            DropDownList3.Items.Add("Select State");
            // Connecting the Database
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\GAUTAM_GOTTIPATI\SOURCE\REPOS\UIPROJECT\UIPROJECT\APP_DATA\DATABASE1.MDF;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from City where sid=" + DropDownList2.SelectedItem.Value, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DropDownList3.DataSource = dt;
            DropDownList3.DataBind();

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged1(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(TextBox2.Text.Trim() == String.Empty)
            {
                Response.Write("<script>alert('Last name required!');</script>");
            }
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\GAUTAM_GOTTIPATI\SOURCE\REPOS\UIPROJECT\UIPROJECT\APP_DATA\DATABASE1.MDF; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RegistrationValues values(@FirstName, @LastName, @Email, @ContactNumber,@Gender, @Country, @State, @City, @DOB)", con);
            cmd.Parameters.AddWithValue("FirstName", TextBox1.Text);
            cmd.Parameters.AddWithValue("LastName", TextBox2.Text);
            cmd.Parameters.AddWithValue("Email", TextBox3.Text);
            cmd.Parameters.AddWithValue("ContactNumber", TextBox4.Text);
            String AddGender;
            if (Male.Checked)
            {
                AddGender = "Male";
            }
            else
            {
                AddGender = "Female";
            }
            cmd.Parameters.AddWithValue("Gender", AddGender);
            cmd.Parameters.AddWithValue("Country", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("State", DropDownList2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("City", DropDownList3.SelectedItem.Text);
            cmd.Parameters.AddWithValue("DOB", Calendar1.SelectedDate.ToShortDateString());
            cmd.ExecuteNonQuery();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}