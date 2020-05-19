using System;
using System.Web.UI;
using Negocio;
using Dominio;
using System.Collections.Generic;

namespace TP3_RoccaFederico
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				throw new Exception("asdasdasd");
				ArticuloNegocio artNegocio = new ArticuloNegocio();
				List<Articulo> articulos = new List<Articulo>();
			}
			catch (Exception ex)
			{
				Session.Add( Session.SessionID + "exception", ex );
				Response.Redirect("error.aspx");
			}
        }
    }
}