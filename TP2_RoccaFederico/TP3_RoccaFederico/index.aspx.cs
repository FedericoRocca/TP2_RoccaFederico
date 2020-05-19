using System;
using System.Web.UI;
using Negocio;
using Dominio;
using System.Collections.Generic;

namespace TP3_RoccaFederico
{
    public partial class _Default : Page
    {
		public List<Articulo> articulos = new List<Articulo>();
		protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				ArticuloNegocio artNegocio = new ArticuloNegocio();
				articulos = artNegocio.getArticulos();
			}
			catch (Exception ex)
			{
				Session.Add( Session.SessionID + "exception", ex );
				Response.Redirect("error.aspx");
			}
        }
    }
}