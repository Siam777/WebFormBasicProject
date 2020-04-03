using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormBegin
{
    public partial class DataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDataForGridView();
            }
        }

        protected void gvEnployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ltError.Text = string.Empty;
            GridViewRow gvRow = (GridViewRow)gvEmployee.Rows[e.RowIndex];
            HiddenField hdEmployeeId = (HiddenField)gvRow.FindControl("hdnEmployeeId");
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DbConnection"];

            using (System.Data.SqlClient.SqlConnection dbConnection = new System.Data.SqlClient.SqlConnection(connectionFromConfiguration.ConnectionString))
            {
                try
                {
                    dbConnection.Open();
                    string sql = string.Format("DELETE FROM Employee WHERE EmployeeId={0}", hdEmployeeId.Value);
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
                    command.ExecuteNonQuery();
                    gvEmployee.EditIndex = -1;
                    BindDataForGridView();
                }
                catch(Exception ex)
                {
                    ltError.Text = ex.Message;
                }
                finally
                {
                    dbConnection.Close();
                    dbConnection.Dispose();
                }
            }
        }

        protected void gvEnployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ltError.Text = string.Empty;
            gvEmployee.EditIndex = e.NewEditIndex;
            BindDataForGridView();
        }

        protected void gvEnployee_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            ltError.Text = string.Empty;
            GridViewRow gvRow = (GridViewRow)gvEmployee.Rows[e.RowIndex];
            HiddenField hdEmployeeId = (HiddenField)gvRow.FindControl("hdnEmployeeId");
            TextBox EmployeeName = (TextBox)gvRow.Cells[1].Controls[0];
            TextBox Age = (TextBox)gvRow.Cells[2].Controls[0];
            TextBox Address = (TextBox)gvRow.Cells[3].Controls[0];
            TextBox DepartmentId = (TextBox)gvRow.Cells[4].Controls[0];

            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DbConnection"];

            using (System.Data.SqlClient.SqlConnection dbConnection = new System.Data.SqlClient.SqlConnection(connectionFromConfiguration.ConnectionString))
            {
                try
                {
                    dbConnection.Open();
                    string sql = string.Format("Update Employee set EmployeeName='{0}',Age='{1}',Address='{2}',DepartmentId='{3}' Where EmployeeId = '{4}'",EmployeeName.Text,Convert.ToInt32(Age.Text),Address.Text, Convert.ToInt32(DepartmentId.Text), hdEmployeeId.Value);
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
                    command.ExecuteNonQuery();
                    gvEmployee.EditIndex = -1;
                    BindDataForGridView();
                }
                catch (Exception ex)
                {
                    ltError.Text += ex.Message;
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }

        protected void gvEnployee_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEmployee.EditIndex = -1;
            BindDataForGridView();
        }

        protected void btnAddRow_Click(object sender, EventArgs e)
        {
            ltError.Text = string.Empty;
            
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DbConnection"];

            using (System.Data.SqlClient.SqlConnection dbConnection = new System.Data.SqlClient.SqlConnection(connectionFromConfiguration.ConnectionString))
            {
                try
                {
                    dbConnection.Open();
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("INSERT INTO Employee (EmployeeName,Age,Address,DepartmentId) values('','','',1)", dbConnection);
                    //System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, );
                    command.ExecuteNonQuery();
                    //gvEmployee.EditIndex = -1;
                    BindDataForGridView();
                }
                catch (Exception ex)
                {
                    ltError.Text = ex.Message;
                }
                finally
                {
                    dbConnection.Close();
                    dbConnection.Dispose();
                }
            }
        }
    
        public void BindDataForGridView()
        {
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DbConnection"];

            using(System.Data.SqlClient.SqlConnection dbConnection = new System.Data.SqlClient.SqlConnection(connectionFromConfiguration.ConnectionString))
            {
                try
                {
                    dbConnection.Open();
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("Select * From Employee",dbConnection);
                    System.Data.SqlClient.SqlDataAdapter dataAdapter = new System.Data.SqlClient.SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        gvEmployee.DataSource = dataSet;
                        gvEmployee.DataBind();
                    } 
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    ltError.Text = "Error: " + ex.Message;
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