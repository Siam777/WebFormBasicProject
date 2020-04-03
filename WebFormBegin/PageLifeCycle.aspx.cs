using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormBegin
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPageLoad.Text = "set this text during the page load and this is where you will usually perform a task";
            if (Page.IsPostBack)
                lblPostBack.Text = "I set this page when the page posted back";
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            bool isPostBack = Page.IsPostBack;
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            lblInit.Text = "I see this text during Page_Init";
        }

        protected void Page_InitComplete(Object sender,EventArgs e)
        {

        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblButtonEvent.Text = "set this text when my button onclick method was fired";
        }
    }
}