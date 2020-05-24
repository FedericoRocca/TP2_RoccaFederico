using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_RoccaFederico
{
    public partial class Carrito : System.Web.UI.Page
    {
		public CarritoArticulos carritoArticulos = new CarritoArticulos();
		protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				if(Session[Session.SessionID + "carrito"] != null)
				{
					carritoArticulos = (CarritoArticulos)Session[Session.SessionID + "carrito"];
					carritoRepeater.DataSource = carritoArticulos.elementos;
					carritoRepeater.DataBind();
				}
			}
			catch (Exception ex)
			{
				Session.Add(Session.SessionID + "exception", ex);
				Response.Redirect("error.aspx");
			}
        }
    }
}