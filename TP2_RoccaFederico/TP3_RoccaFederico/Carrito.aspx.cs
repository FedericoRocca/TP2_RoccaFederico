﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_RoccaFederico
{
    public partial class Carrito : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{

			}
			catch (Exception ex)
			{
				Session.Add(Session.SessionID + "exception", ex);
				Response.Redirect("error.aspx");
			}
        }
    }
}