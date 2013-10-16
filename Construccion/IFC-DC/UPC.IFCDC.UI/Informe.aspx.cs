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
    public partial class WebForm2 : System.Web.UI.Page
    {
        PeriodoBE objPeriodoBE = null;
        InformeFinCicloBE objInformeBE = null;
        CursoxProfesorBE objCursoxProfesorBE = null;

        LogroBE objLogroBE = null;
        ResultadoProgramaxCursoCollectionBE objResultadoProgramaxCursoCollectionBE = null;
        HallazgoCollectionBE objHallazgoCollectionBE = null;
        AccionMejoraCollectionBE objAccionesMejoraCollectionBE = null;
        AccionMejoraCollectionBE objAccionesPreviasCollectionBE = null;

        PeriodoCollectionBE listaPeriodosTotal = null;
        PeriodoCollectionBE listaPeriodosFiltrada = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            objPeriodoBE = (PeriodoBE)Session["Periodo"];
            objInformeBE = (InformeFinCicloBE)Session["Informe"];
            objCursoxProfesorBE = (CursoxProfesorBE)Session["CursoxProfesor"];

            if (!Page.IsPostBack)
            {
                texto_PeriodoActual.Text = objPeriodoBE.Descripcion;
                texto_FechaLimite.Text = objPeriodoBE.FechaFin;
                texto_DescripcionCurso.Text = objCursoxProfesorBE.Codigo + " - " + objCursoxProfesorBE.Nombre;

                //SETEANDO DATOS DE INFORME DE FIN DE CICLO
                txt_DesarrolloAprendizaje.Text = objInformeBE.DesarrolloUnidades;
                txt_Infraestructura.Text = objInformeBE.ComentarioInfraestructura;
                txt_Alumnos.Text = objInformeBE.ComentarioAlumnos;
                txt_Delegados.Text = objInformeBE.ComentarioDelegados;
                txt_EncuestaAcademica.Text = objInformeBE.ComentarioEncuesta;

                //OBTENIENDO PERIODOS
                listaPeriodosTotal = new PeriodoBC().listarPeriodos();
                listaPeriodosFiltrada = obtenerPeriodosFiltrados(listaPeriodosTotal);
                setearCombosPeriodos();
            }

                //OBTENIENDO LOGRO TERMINAL
                objLogroBE = new LogroBE();
                objLogroBE.CursoId = objCursoxProfesorBE.CursoId;
                objLogroBE = new LogroBC().obtenerLogroxCurso(objLogroBE);

                texto_LogroTerminal.Text = objLogroBE.Descripcion;

                //OBTENIENDO STUDENT OUTCOMES
                grdOutcomesDataBind();

                //OBTENIENDO HALLAZGOS
                grdHallazgosDataBind();

                //OBTENER ACCIONES DE MEJORA
                grdAccionesMejoraDataBind();

                //OBTENER ACCIONES PREVIAS
                grdAccionesPreviasDataBind();
            
        }

        //DATA BINDS

        private void grdHallazgosDataBind()
        {
            HallazgoBE objHallazgoBE = new HallazgoBE();
            objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            
            objHallazgoCollectionBE = new HallazgoBC().listarHallazgos(objHallazgoBE);
            grdHallazgos.DataSource = objHallazgoCollectionBE.LstHallazgos;
            grdHallazgos.DataBind();
        }

        private void grdOutcomesDataBind()
        {
            ResultadoProgramaxCursoBE objResultadoProgramaBE = new ResultadoProgramaxCursoBE();
            objResultadoProgramaBE.CursoId = objCursoxProfesorBE.CursoId;
            
            objResultadoProgramaxCursoCollectionBE = new ResultadoProgramaxCursoBC().listarResultadoProgramaxCurso(objResultadoProgramaBE);
            grdOutcomes.DataSource = objResultadoProgramaxCursoCollectionBE.LstResultadoProgramaxCurso;
            grdOutcomes.DataBind();
        }

        private void grdAccionesMejoraDataBind()
        {
            AccionMejoraBE objAccionMejoraBE = new AccionMejoraBE();
            objAccionMejoraBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            
            objAccionesMejoraCollectionBE = new AccionMejoraBC().listarAccionesMejora(objAccionMejoraBE);
            grdAccionesdeMejora.DataSource = objAccionesMejoraCollectionBE.LstAccionesMejora;
            grdAccionesdeMejora.DataBind();
        }

        private void grdAccionesPreviasDataBind()
        {
            InformeFinCicloBE objInformeAccionPreviaBE = new InformeFinCicloBE();
            objInformeAccionPreviaBE.CursoId = objCursoxProfesorBE.CursoId;
            objInformeAccionPreviaBE.PeriodoId = objPeriodoBE.PeriodoId;

            objAccionesPreviasCollectionBE = new AccionMejoraBC().listarAccionesPrevias(objInformeAccionPreviaBE);
            grdAccionesPrevias.DataSource = objAccionesPreviasCollectionBE.LstAccionesMejora;
            grdAccionesPrevias.DataBind();
        }


        //POPUPS
        
        protected void popup_buttonRegistrarHallazgo_Click(object sender, EventArgs e)
        {
            HallazgoBE objHallazgoBE = new HallazgoBE();
            objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objHallazgoBE.Descripcion = popup_textoDescripcionHallazgoRegistrar.Text;
            objHallazgoBE.PeriodoId = objPeriodoBE.PeriodoId;
            objHallazgoCollectionBE = new HallazgoBC().resgistrarHallazgo(objHallazgoBE);
            grdHallazgosDataBind();
        }

        protected void popup_buttonEditarHallazgo_Click(object sender, EventArgs e)
        {
            HallazgoBE objHallazgoBE = new HallazgoBE();
            objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objHallazgoBE.Descripcion = popup_textoDescripcionHallazgoEditar.Text;
            objHallazgoBE.HallazgoId = Convert.ToInt32(hiddenAE2.Value);

            objHallazgoCollectionBE = new HallazgoBC().editarHallazgo(objHallazgoBE);
            grdHallazgosDataBind();
        }

        protected void popup_buttonRegistrarAccioMejora_Click(object sender, EventArgs e)
        {
            AccionMejoraBE objAccionMejoraBE = new AccionMejoraBE();
            objAccionMejoraBE.HallazgoId = Convert.ToInt32(hiddenAC2.Value);
            objAccionMejoraBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objAccionMejoraBE.CicloEjecucionId = Convert.ToInt32(combo_AccionMejoraRegistrar.SelectedValue);
            objAccionMejoraBE.Descripcion = popup_textoDescripcionAccionMejoraRegistrar.Text;

            objAccionesMejoraCollectionBE = new AccionMejoraBC().registrarAccionesMejora(objAccionMejoraBE);
            grdAccionesMejoraDataBind();
        }

        protected void popup_buttonEditarAccioMejora_Click(object sender, EventArgs e)
        {
            AccionMejoraBE objAccionMejoraBE = new AccionMejoraBE();
            objAccionMejoraBE.AccionMejoraId = Convert.ToInt32(hiddenEAC2.Value);
            objAccionMejoraBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objAccionMejoraBE.CicloEjecucionId = Convert.ToInt32(combo_AccionMejoraEditar.SelectedValue);

            objAccionMejoraBE.Descripcion = popup_textoDescripcionAccionMejoraEditar.Text;
            objAccionesMejoraCollectionBE = new AccionMejoraBC().editarAccionesMejora(objAccionMejoraBE);

            grdAccionesMejoraDataBind();
        }

        //ROW COMMANDS

        public void grdHallazgos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper().Equals("CMDELIMINARHALLAZGO"))
                {
                    HallazgoBE objHallazgoBE = new HallazgoBE();
                    objHallazgoBE.HallazgoId = Convert.ToInt32(e.CommandArgument.ToString());
                    objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
                    objHallazgoCollectionBE = new HallazgoBC().eliminarHallazgo(objHallazgoBE);
                    grdHallazgosDataBind();
                    grdAccionesMejoraDataBind();
                }

                if (e.CommandName.ToUpper().Equals("CMDAGREGARACCIONMEJORA"))
                {
                }

                if (e.CommandName.ToUpper().Equals("CMDEDITARHALLAZGO"))
                {
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void grdAccionesMejora_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper().Equals("CMDELIMINARACCIONMEJORA"))
                {
                    AccionMejoraBE objAccionMejoraBE = new AccionMejoraBE();
                    objAccionMejoraBE.AccionMejoraId = Convert.ToInt32(e.CommandArgument.ToString());
                    objAccionMejoraBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
                    //objAccionesMejoraCollectionBE = objAccionMejoraBC.eliminarAccionMejora(objAccionMejoraBE);

                    objAccionesMejoraCollectionBE = new AccionMejoraBC().eliminarAccionMejora(objAccionMejoraBE);
                    grdAccionesMejoraDataBind();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdvAccionesPrevias_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }

        protected void dpdListEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        /*
        public void selectedItem( CommandEventArgs e)
        {
            for (int i = 0; i < objAccionesPreviasCollectionBE.LstAccionesMejora.Count; i++)
            {
                if (int.Parse(e.CommandName) == objAccionesPreviasCollectionBE.LstAccionesMejora[i].AccionMejoraId)
                {
                    if (objAccionesPreviasCollectionBE.LstAccionesMejora[i].Estado == "EN PROCESO")
                    { 
                        //seteo el index en EN PROCESO
                        grdAccionesPrevias.
                        dpdListEstatus.SelectedIndex = 0;
                    }
                    if (objAccionesPreviasCollectionBE.LstAccionesMejora[i].Estado == "NO REALIZADO")
                    {
                        //seteo el index en EN PROCESO
                        dpdListEstatus.SelectedIndex = 1;
                    }
                    if (objAccionesPreviasCollectionBE.LstAccionesMejora[i].Estado == "IMPLEMENTADO")
                    {
                        //seteo el index en EN PROCESO
                        dpdListEstatus.SelectedIndex = 2;
                    }
                }
            }
        }*/
        public void OnConfirm(object sender, EventArgs e)
        {   
            InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
            InformeFinCicloBE objInformeFinCicloBE = new InformeFinCicloBE();

            objInformeFinCicloBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objInformeFinCicloBE.DesarrolloUnidades = txt_DesarrolloAprendizaje.Text;
            objInformeFinCicloBE.ComentarioInfraestructura = txt_Infraestructura.Text;
            objInformeFinCicloBE.ComentarioAlumnos = txt_Alumnos.Text;
            objInformeFinCicloBE.ComentarioDelegados = txt_Delegados.Text;
            objInformeFinCicloBE.ComentarioEncuesta = txt_EncuestaAcademica.Text;
            objInformeFinCicloBE.Estado = "EN PROCESO";

            //string confirmValue = Request.Form["confirm_value"];
            //if (confirmValue == "YES")
            //{
                if (!existenCamposVacios() && objHallazgoCollectionBE.LstHallazgos.Count > 0)
                {
                    objInformeFinCicloBE.Estado = "FINALIZADO";
                    objInformeBE = objInformeFinCicloBC.editarInformeFinCiclo(objInformeFinCicloBE);
                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usted ha finalizado el Informe de Fin de Ciclo satisfactorimente.')", true);
                }

                else
                {
                    objInformeBE = objInformeFinCicloBC.editarInformeFinCiclo(objInformeFinCicloBE);
                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usted debe llenar todos los campos para completar el Informe de Fin de Ciclo.')", true);
                }
     
            //}
            //else
            //{
            //    objInformeBE = objInformeFinCicloBC.editarInformeFinCiclo(objInformeFinCicloBE);
            //    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La información ha sido almacenada. Para finalizar el Informe de Fin de Ciclo, debe enviar el Informe.')", true);
            //}
        }

        public void OnCancel(object sender, EventArgs e)
        {
            Response.Redirect("CursosxCoordinador.aspx");
        }

        private bool existenCamposVacios()
        {
            if (txt_DesarrolloAprendizaje.Text.Equals("") || txt_Infraestructura.Text.Equals("") ||
                txt_Alumnos.Text.Equals("") || txt_Delegados.Text.Equals("") ||
                txt_EncuestaAcademica.Text.Equals(""))
                return true;
            return false;
        }

        private void setearCombosPeriodos()
        {
            for (int i = 0; i < listaPeriodosFiltrada.LstPeriodos.Count; i++)
            {
                combo_AccionMejoraRegistrar.Items.Add(new ListItem(listaPeriodosFiltrada.LstPeriodos[i].Descripcion, listaPeriodosFiltrada.LstPeriodos[i].PeriodoId.ToString()));
                combo_AccionMejoraEditar.Items.Add(new ListItem(listaPeriodosFiltrada.LstPeriodos[i].Descripcion, listaPeriodosFiltrada.LstPeriodos[i].PeriodoId.ToString()));
            }
        }

        private PeriodoCollectionBE obtenerPeriodosFiltrados(PeriodoCollectionBE listaPeriodosTotal)
        {
            int posicionPeriodoActual = 0;
            PeriodoCollectionBE lista = new PeriodoCollectionBE();
            lista.LstPeriodos = new System.Collections.ObjectModel.Collection<PeriodoBE>();

            for (int i = 0; i < listaPeriodosTotal.LstPeriodos.Count; i++)
            {
                if (listaPeriodosTotal.LstPeriodos[i].EsActual == true)
                {
                    posicionPeriodoActual = i;
                    break;
                }
            }

            for (int j = posicionPeriodoActual + 1; j > posicionPeriodoActual - 1; j--)
            {
                if (j >= 0)
                    lista.LstPeriodos.Add(listaPeriodosTotal.LstPeriodos[j]);
            }

            return lista;
        }
    }
}