using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebFormBegin
{
    public partial class SqlConnection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DbConnection"];
            using (System.Data.SqlClient.SqlConnection dbConnection = new System.Data.SqlClient.SqlConnection(connectionFromConfiguration.ConnectionString))
            {
                try
                {
                    dbConnection.Open();
                    ltConnectionMessage.Text = "Connection Successful";
                    try
                    {
                        System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("Select * From Employee", dbConnection);
                        System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ltOutput.Text += string.Format("<li>{0}</li>", reader.GetString(1));
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        ltOutput.Text = "<li>" + ex.Message + "</li>";
                    }

                }
                catch(System.Data.SqlClient.SqlException ex)
                {
                    ltConnectionMessage.Text = "Connection Failed: " + ex.Message;
                }
                finally
                {
                    dbConnection.Close();
                    dbConnection.Dispose();
                }
            }

        }
    }
}