using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace MY_Bank
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-V8J54HJ\\SQLEXPRESS;Initial Catalog=COMPANY;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO feeback (Name, Email, Message) VALUES (@Name, @Email, @Message)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Message", txtMessage.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "insertSuccess", "alert('Feedback submitted successfully!');", true);
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtMessage.Text = "";
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "insertFailed", "alert('Failed to submit feedback!');", true);
                }
            }


        }
    }
}