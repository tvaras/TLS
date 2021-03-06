﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_TLS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["CURRENT_USER"] != null)
                {
                    lblUsuarioConectado.Text = ((SVR_Login.UsuarioLogin)Session["CURRENT_USER"]).alias;
                }
                else
                {
                    Response.Redirect("~/FRM_Login");
                }
            }
        }
    }
}