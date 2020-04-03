using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormBegin.Models;

namespace WebFormBegin
{
    public partial class ProjectCalculation : System.Web.UI.Page
    {
        public decimal BasePrice = 100.00m;
        protected void Page_Load(object sender, EventArgs e)
        {
            ltBasePrice.Text = BasePrice.ToString("C");
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            State state = new State();
            decimal fee = state.GetFeeForState(ddlState.SelectedValue);
            decimal FinalPrice = BasePrice + fee;
            ltCustomPrice.Text = FinalPrice.ToString("C");
        }
    }
}