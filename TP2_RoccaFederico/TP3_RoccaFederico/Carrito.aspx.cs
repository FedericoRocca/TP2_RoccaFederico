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
        public double totalAPagar = 0;
		protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				if(Session[Session.SessionID + "carrito"] != null)
				{
					carritoArticulos = (CarritoArticulos)Session[Session.SessionID + "carrito"];
					carritoRepeater.DataSource = carritoArticulos.elementos;
					carritoRepeater.DataBind();

                    foreach (var item in carritoArticulos.elementos)
                    {
                        totalAPagar += item.precio;
                    }

				}
			}
			catch (Exception ex)
			{
				Session.Add(Session.SessionID + "exception", ex);
				Response.Redirect("error.aspx");
			}
        }

        protected void btnQuitarDelCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsPostBack)
                {
                    int idArticulo = int.Parse(((Button)sender).CommandArgument);
                    CarritoArticulos aux = new CarritoArticulos();
                    aux.elementos = carritoArticulos.elementos.Where(x => x.id != idArticulo).ToList();
                    Session[Session.SessionID + "carrito"] = aux;
                    Response.Redirect("Carrito.aspx", false);
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