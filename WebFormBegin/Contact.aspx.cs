using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormBegin
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            divMessage.Attributes.Add("style", "color:blue");
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = string.Format("You said your name is {0} and Your age is {1} and Your Email is {2}. Your Favourite Color is {3}",
                                           txtName.Text, txtAge.Text, textEmail.Text, ddlColor.SelectedValue);
            ltMessage.Text = message;
        }
    }
}