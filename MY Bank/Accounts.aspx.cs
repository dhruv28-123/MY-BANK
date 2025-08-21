using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MY_Bank
{
    public partial class Accounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                string connectionString = "Data Source=DESKTOP-V8J54HJ\\SQLEXPRESS;Initial Catalog=COMPANY;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Accounts (FirstName, LastName, Address, MobileNumber, Gender, City) " +
                                   "VALUES (@FirstName, @LastName, @Address, @MobileNumber, @Gender, @City)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FirstName", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@LastName", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Address", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@MobileNumber", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Gender", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@City", TextBox6.Text);

                    int rowsInserted = cmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "insertSuccess", "alert('Account created successfully!');", true);

                        // Optionally clear form:
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "insertFailed", "alert('Failed to create account!');", true);
                    }
                }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
                string connectionString = "Data Source=DESKTOP-V8J54HJ\\SQLEXPRESS;Initial Catalog=COMPANY;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Accounts SET Address = @Address, MobileNumber = @MobileNumber, Gender = @Gender, City = @City " +
                                   "WHERE FirstName = @FirstName AND LastName = @LastName";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FirstName", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@LastName", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Address", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@MobileNumber", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Gender", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@City", TextBox6.Text);

                    int rowsUpdated = cmd.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "updateSuccess", "alert('Account updated successfully!');", true);

                        // Optionally clear form:
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "updateFailed", "alert('Update failed! No matching record found.');", true);
                    }
                }
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-V8J54HJ\\SQLEXPRESS;Initial Catalog=COMPANY;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Accounts WHERE FirstName = @FirstName AND LastName = @LastName";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", TextBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", TextBox2.Text);

                int rowsDeleted = cmd.ExecuteNonQuery();



                if (rowsDeleted > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "deleteSuccess", "alert('Account deleted successfully!');", true);

                    // Optional: Clear form fields
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "deleteFailed", "alert('Deletion failed! No matching record found.');", true);
                }
            }
        }
    }
}