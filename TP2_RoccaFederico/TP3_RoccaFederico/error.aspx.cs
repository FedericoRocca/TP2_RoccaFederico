using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_RoccaFederico
{
    public partial class error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorText.Text = "Se produjo un error en la web. Por favor contacte al administrador informando lo siguiente: ";
            errorText.Text += Session[Session.SessionID + "exception"].ToString();
            errorText.Rows = 45;
            errorText.Columns = 140;
            errorText.Style["resize"] = "none";
        }
    }
}