using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UPC.IFCDC.BC;
using UPC.IFCDC.BE;
using UPC.IFCDC.Utilitarios;

using System.Web.Security;

namespace UPC.IFCDC.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String sUsuario = null;
        String sPassword = null;

        PeriodoWS.PeriodoCollectionDC objPeriodoCollectionDC = null;
        PeriodoCollectionBE listaPeriodosFiltrado = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            obtenerPeriodos();
            setearCombo(); 
        }

        private void obtenerPeriodos()
        {
            PeriodoWS.PeriodoClient client = null;

            try
            {
                client = new PeriodoWS.PeriodoClient();
                objPeriodoCollectionDC = client.WSListarPeriodos();
                listaPeriodosFiltrado = obtenerPeriodosFiltrados(objPeriodoCollectionDC);
            }
            catch (Exception ex)
            {
                MostrarAlert("OBTENER PERIODOS: " + ex.Message);
            }
            finally
            {
                client = null;
            }
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
                        PeriodoWS.PeriodoDC objPeriodoDC = new PeriodoWS.PeriodoDC();
                        objPeriodoDC.PeriodoId = listaPeriodosFiltrado.LstPeriodos[combo_LoginCiclo.SelectedIndex].PeriodoId;
                        objPeriodoDC.Descripcion = listaPeriodosFiltrado.LstPeriodos[combo_LoginCiclo.SelectedIndex].Descripcion;
                        objPeriodoDC.FechaInicio = listaPeriodosFiltrado.LstPeriodos[combo_LoginCiclo.SelectedIndex].FechaInicio;
                        objPeriodoDC.FechaFin = listaPeriodosFiltrado.LstPeriodos[combo_LoginCiclo.SelectedIndex].FechaFin;

                        Session["PersonaId"] = personaDC.PersonaId;
                        Session["NombreCompletoPersona"] = personaDC.Apellidos + ", " + personaDC.Nombres;
                        Session["Periodo"] = objPeriodoDC;
                        Session["TipoPersona"] = personaDC.TipoPersona;

                        Session.Add("NombreCompletoPersona", personaDC.Apellidos + ", " + personaDC.Nombres);
                        Session.Add("TipoPersona", personaDC.TipoPersona);

                        FormsAuthentication.RedirectFromLoginPage(personaDC.PersonaId, false); 

                        /*
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
                        }*/
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

        private PeriodoCollectionBE obtenerPeriodosFiltrados(PeriodoWS.PeriodoCollectionDC listaPeriodosTotal)
        {
            int posicionPeriodoActual = 0;
            PeriodoCollectionBE lista = new PeriodoCollectionBE();
            lista.LstPeriodos = new System.Collections.ObjectModel.Collection<PeriodoBE>();

            for (int i = 0; i < listaPeriodosTotal.Count(); i++)
            {
                if (listaPeriodosTotal[i].EsActual == 1)
                {
                    posicionPeriodoActual = i;
                    break;
                }
            }

            for (int j = posicionPeriodoActual; j > posicionPeriodoActual - 3; j--)
            {
                if (j >= 0)
                {
                    PeriodoBE periodo = new PeriodoBE();
                    periodo.PeriodoId = listaPeriodosTotal[j].PeriodoId;
                    periodo.Descripcion = listaPeriodosTotal[j].Descripcion;
                    periodo.EsActual = listaPeriodosTotal[j].EsActual;
                    periodo.FechaInicio = listaPeriodosTotal[j].FechaInicio;
                    periodo.FechaFin = listaPeriodosTotal[j].FechaFin;

                    lista.LstPeriodos.Add(periodo);
                }
            }

            return lista;
        }

        private void setearCombo()
        {
            for (int i = 0; i < listaPeriodosFiltrado.LstPeriodos.Count; i++)
            {
                combo_LoginCiclo.Items.Add(new ListItem(listaPeriodosFiltrado.LstPeriodos[i].Descripcion, listaPeriodosFiltrado.LstPeriodos[i].PeriodoId.ToString()));
            }
        }

        private void MostrarAlert(String mensaje)
        {
            ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "MensajeError", String.Format("alert('{0}');", mensaje), true);
        }
    }
}