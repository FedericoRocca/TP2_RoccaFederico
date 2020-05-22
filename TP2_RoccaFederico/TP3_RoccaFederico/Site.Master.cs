using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_RoccaFederico
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Carrito.aspx");
            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "exception", ex);
                Response.Redirect("error.aspx");
            }
        }
    }
}