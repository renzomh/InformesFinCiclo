using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UPC.IFCDC.BE;
using UPC.IFCDC.BC;
using UPC.IFCDC.Utilitarios;

namespace UPC.IFCDC.UI
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private String sPersonaId = null;

        //PeriodoWS.PeriodoClient periodoClient = null;
        PeriodoWS.PeriodoDC objPeriodoDC = null;

        CursoWS.CursoClient cursoClient = null;
        CursoWS.CursoxProfesorCollectionDC objCursoCollectionDC = null;



        protected void Page_Load(object sender, EventArgs e)
        {
            sPersonaId = Session["PersonaId"].ToString();

            try
            {
                if (sPersonaId != null)
                {
                    //periodoClient = new PeriodoWS.PeriodoClient();
                    //objPeriodoDC = periodoClient.WSObtenerPeriodoActual();
                    objPeriodoDC = (PeriodoWS.PeriodoDC) Session["Periodo"];

                    texto_PeriodoActual.Text = objPeriodoDC.Descripcion;
                    texto_FechaLimite.Text = objPeriodoDC.FechaFin;

                    grdCursosDataBind();
                }
            }
            catch (Exception ex)
            {
                MostrarAlert(ex.Message);
            }
            finally
            {
                //periodoClient = null;
            }
            
        }

        private void grdCursosDataBind()
        {
            try
            {
                cursoClient = new CursoWS.CursoClient();
                objCursoCollectionDC = cursoClient.ListarCursosxProfesor(sPersonaId);

                grdCursos.DataSource = objCursoCollectionDC.LstCursosxProfesor;
                grdCursos.DataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert(ex.Message);
            }
            finally
            {
                cursoClient = null;
            }
        }

        public void grdCursos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            InformeFinCicloWS.InformeFinCicloClient informeClient = null;
            InformeFinCicloWS.InformeFinCicloDC objInformeFinCicloDC = null;

            try
            {
                if (e.CommandName.ToUpper().Equals("CMDINICIAR"))
                {
                    informeClient = new InformeFinCicloWS.InformeFinCicloClient();
                    objInformeFinCicloDC = informeClient.WSObtenerInformeFinCiclo(sPersonaId, Convert.ToInt32(e.CommandArgument.ToString()), objPeriodoDC.PeriodoId);

                    if (objInformeFinCicloDC != null)
                    {
                        if (!objInformeFinCicloDC.Estado.Equals(Constantes.ESTADO_INFORME_FINALIZADO))
                        {
                            Session["Informe"] = objInformeFinCicloDC;
                            Session["Periodo"] = objPeriodoDC;
                            Session["CursoxProfesor"] = obtenerCurso(objInformeFinCicloDC.CursoId);

                            Response.Redirect("Informe.aspx");
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                MostrarAlert(ex.Message);
            }

            finally
            {
                informeClient = null;
            }
        }

        protected void grdCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private CursoWS.CursoxProfesorDC obtenerCurso(int cursoId)
        {
            CursoWS.CursoxProfesorDC objCursoxProfesor = null;

            for (int i = 0; i < objCursoCollectionDC.LstCursosxProfesor.Count(); i++)
            {
                if (objCursoCollectionDC.LstCursosxProfesor[i].CursoId == cursoId)
                    objCursoxProfesor = objCursoCollectionDC.LstCursosxProfesor[i];
            }

            return objCursoxProfesor;
        }

        private void MostrarAlert(String mensaje)
        {
            ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "MensajeError", String.Format("alert('{0}');", mensaje), true);
        }
    }
}