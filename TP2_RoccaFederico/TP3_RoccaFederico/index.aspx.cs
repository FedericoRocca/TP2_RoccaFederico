using System;
using System.Web.UI;
using Negocio;
using Dominio;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace TP3_RoccaFederico
{
    public partial class _Default : Page
    {
		public List<Articulo> articulos = new List<Articulo>();
		public Articulo item = new Articulo();
		private List<int> itemsID = new List<int>();
		protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				ArticuloNegocio artNegocio = new ArticuloNegocio();
				articulos = artNegocio.getArticulos();
				if(Request.QueryString["artID"] != null)
				{
					if( Session[ Session.SessionID + "listaIDsArticulos" ] != null )
					{
						itemsID = (List<int>)Session[Session.SessionID + "listaIDsArticulos"];
					}
					itemsID.Add(int.Parse(Request.QueryString["artID"]));
					Session.Add(Session.SessionID + "listaIDsArticulos", itemsID);
					Response.Redirect("index.aspx", false);
				}
			}
			catch (Exception ex)
			{
				Session.Add( Session.SessionID + "exception", ex );
				Response.Redirect("error.aspx");
			}
        }
	}
}