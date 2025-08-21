using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace MY_Bank
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string password = TextBox2.Text;

            string con = "Data Source=DESKTOP-V8J54HJ\\SQLEXPRESS;Initial Catalog=COMPANY;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                string query = "SELECT * FROM entry WHERE Name = @Name AND passwords = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute reader
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // ✅ Login successful
                        Session["Username"] = name;
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        string script = "alert('Invalid username or password!');";
                        ClientScript.RegisterStartupScript(this.GetType(), "loginFail", script, true);
                    }
                }
            }

        }

    }
}
                
            

        
        
    

        

