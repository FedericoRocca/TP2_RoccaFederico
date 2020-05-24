using System;
using System.Web.UI;
using Negocio;
using Dominio;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace TP3_RoccaFederico
{
    public partial class _Default : Page
    {
		public List<Articulo> articulos = new List<Articulo>();
		public Carrito miCarrito = new Carrito();
		protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				ArticuloNegocio artNegocio = new ArticuloNegocio();
				articulos = artNegocio.getArticulos();
				if(!IsPostBack)
				{
					articulosRepeater.DataSource = articulos;
					articulosRepeater.DataBind();
				}
			}
			catch (Exception ex)
			{
				Session.Add(Session.SessionID + "exception", ex);
				Response.Redirect("error.aspx");
			}
		}

		protected void btnAgregarAlCarrito_Click(object sender, EventArgs e)
		{
			try
			{
				ArticuloNegocio artNegocio = new ArticuloNegocio();
				int idArticulo = int.Parse(((Button)sender).CommandArgument);
				//miCarrito.elementos.Add( artNegocio. );
			}
			catch (Exception ex)
			{
				Session.Add(Session.SessionID + "exception", ex);
				Response.Redirect("error.aspx");
			}
		}
	}
}