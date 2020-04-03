using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormBegin
{
    public partial class viewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                ltPostBack.Text = "I'm PostBack!This form is\"sticky\" and your input has been loaded into the page";
            else
            {
                ltPostBack.Text = "Fill out this form.Don't worry,your data won't get lost when you submit.";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}