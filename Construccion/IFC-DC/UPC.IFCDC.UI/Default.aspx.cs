using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace UPC.IFCDC.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int tipo = 1;

            if (Session["TipoPersona"] != null)
                tipo = Convert.ToInt32(Session["TipoPersona"].ToString());

            switch (tipo)
            {
                case 1:
                    Response.Redirect("Administrativo.aspx");
                    break;
                case 2:
                    Response.Redirect("CursosxCoordinador.aspx");
                    break;
                default:
                    FormsAuthentication.SignOut();
                    Response.Redirect("Default.aspx");
                    break;
            }
        }
    }
}