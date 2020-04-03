using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormBegin
{
    public partial class ErrorHandling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string message = string.Empty;
            try
            {
                decimal expectedDecimal = decimal.Parse(txtDecimal.Text);
                message  = "Your decimal is: " + expectedDecimal;
            }
            catch(Exception ex)
            {
                message = ex.Message.ToString();
            }

            lblMessage.Text = message;
            lblMessage.Visible = true;
        }
    }
}