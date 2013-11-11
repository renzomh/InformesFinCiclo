using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UPC.IFCDC.BC;
using UPC.IFCDC.BE;
using UPC.IFCDC.Utilitarios;

namespace UPC.IFCDC.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String sUsuario = null;
        String sPassword = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresar_Click(object sender, EventArgs e)
        {
            sUsuario = texto_usuario.Text.ToString().Trim();
            sPassword = "password";

            PersonaWS.PersonaClient personaClient = new PersonaWS.PersonaClient();
            PersonaWS.PersonaDC personaDC = personaClient.WSObtenerPersona(sUsuario);

            try
            {
                if (!texto_usuario.Text.ToString().Trim().Equals("") && !texto_password.Text.ToString().Trim().Equals(""))
                {
                    if (personaDC != null && texto_password.Text.ToString().Trim().Equals(sPassword))
                    {
                        Session["PersonaId"] = personaDC.PersonaId;
                        Session["NombreCompletoPersona"] = personaDC.Apellidos + ", " + personaDC.Nombres;

                        switch (personaDC.TipoPersona)
                        {
                            //ADMINISTRATIVO
                            case 1:
                                Response.Redirect("Administrativo.aspx");
                                break;
                            //COORDINADOR
                            case 2:
                                Response.Redirect("CursosxCoordinador.aspx");
                                break;

                            //NO PERMITIDO
                            case -1:
                                MostrarAlert("El usuario ingresado no es soportado por la aplicación.");
                                break;

                            default: break;
                        }
                    }
                    else
                    {
                        MostrarAlert("El usuario y/o contraseña son incorrectos.");
                    }
                }
                else
                {
                    MostrarAlert("Debe ingresar el usuario y contraseña obligatoriamente.");
                }
                
            }
            catch (Exception ex)
            {
                MostrarAlert(ex.Message);
            }
        }

        private void MostrarAlert(String mensaje)
        {
            ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "MensajeError", String.Format("alert('{0}');", mensaje), true);
        }
    }
}