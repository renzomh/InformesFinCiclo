﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections.ObjectModel;

using UPC.IFCDC.BE;
using UPC.IFCDC.BC;
using UPC.IFCDC.Utilitarios;
using System.Text;
using System.Data;

using System.Web.Security;

namespace UPC.IFCDC.UI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        PeriodoWS.PeriodoDC objPeriodoDC = null;
        InformeFinCicloWS.InformeFinCicloDC objInformeDC = null;
        CursoWS.CursoxProfesorDC objCursoxProfesorDC = null;

        PeriodoWS.PeriodoCollectionDC listaPeriodosTotal = null;
        PeriodoCollectionBE listaPeriodosFiltrada = null;

        AccionMejoraWS.AccionMejoraCollectionDC listaAccionesPrevias = null;

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["TipoPersona"].ToString()) != 2)
            {
                FormsAuthentication.SignOut();
                Response.Redirect("Default.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            objPeriodoDC = (PeriodoWS.PeriodoDC)Session["Periodo"];
            objInformeDC = (InformeFinCicloWS.InformeFinCicloDC)Session["Informe"];
            objCursoxProfesorDC = (CursoWS.CursoxProfesorDC)Session["CursoxProfesor"];

            if (!Page.IsPostBack)
            {
                texto_PeriodoActual.Text = objPeriodoDC.Descripcion;
                texto_FechaLimite.Text = objPeriodoDC.FechaFin;
                texto_DescripcionCurso.Text = objCursoxProfesorDC.Codigo + " - " + objCursoxProfesorDC.Nombre;

                //SETEANDO DATOS DE INFORME DE FIN DE CICLO
                txt_DesarrolloAprendizaje.Text = objInformeDC.DesarrolloUnidades;
                txt_Infraestructura.Text = objInformeDC.ComentarioInfraestructura;
                txt_Alumnos.Text = objInformeDC.ComentarioAlumnos;
                txt_Delegados.Text = objInformeDC.ComentarioDelegados;
                txt_EncuestaAcademica.Text = objInformeDC.ComentarioEncuesta;

                //OBTENIENDO PERIODOS
                setearPeriodos();
            }

                //OBTENIENDO LOGRO TERMINAL
                setearLogros();

                //OBTENIENDO STUDENT OUTCOMES
                grdOutcomesDataBind();

                //OBTENIENDO HALLAZGOS
                grdHallazgosDataBind();

                //OBTENER ACCIONES DE MEJORA
                grdAccionesMejoraDataBind();

                //OBTENER ACCIONES PREVIAS
                grdAccionesPreviasDataBind();

                //OBTENER ANTECEDENTES
                reporteInformeFinCicloDataBind();
        }

        private void setearPeriodos()
        {
            PeriodoWS.PeriodoClient client = null;

            try
            {
                client = new PeriodoWS.PeriodoClient();
                listaPeriodosTotal = client.WSListarPeriodos();
                listaPeriodosFiltrada = obtenerPeriodosFiltrados(listaPeriodosTotal);
                setearCombosPeriodos();
            }
            catch (Exception ex)
            {
                MostrarAlert("SETEAR PERIODOS: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        private void setearLogros()
        {
            LogroWS.LogroClient client = null;

            try
            {
                client = new LogroWS.LogroClient();
                texto_LogroTerminal.Text = client.WSListarLogroxCurso(objInformeDC.CursoId).Descripcion;
            }
            catch (Exception ex)
            {
                MostrarAlert("SETEAR LOGROS: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        //DATA BINDS

        private void reporteInformeFinCicloDataBind()
        {
            InformeFinCicloWS.InformeFinCicloClient client = null;
            String sEstado = "";

            try
            {
                client = new InformeFinCicloWS.InformeFinCicloClient();

                grdInformes.DataSource = client.WSListarInformeFinCicloReporte(objCursoxProfesorDC.CursoId, 0, sEstado).LstInformeFinCicloReporte;
                grdInformes.DataBind();

                if (client.WSListarInformeFinCicloReporte(objCursoxProfesorDC.CursoId, 0, sEstado).LstInformeFinCicloReporte.Count() <= 0)
                {
                    grdInformes.Visible = false;
                    txtAntecedentesVacio.Visible = true;
                }
                else
                {
                    grdInformes.Visible = true;
                    txtAntecedentesVacio.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MostrarAlert("DATA BIND, REPORTE INFORMES: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        private void grdHallazgosDataBind()
        {
            HallazgoWS.HallazgoClient hallazgoClient = null;

            try
            {
                hallazgoClient = new HallazgoWS.HallazgoClient();
                grdHallazgos.DataSource = hallazgoClient.WSListarHallazgosxInformeFinCiclo(objInformeDC.InformeFinCicloId).LstHallazgos;
                grdHallazgos.DataBind();

                if (hallazgoClient.WSListarHallazgosxInformeFinCiclo(objInformeDC.InformeFinCicloId).LstHallazgos.Count() <= 0)
                {
                    grdHallazgos.Visible = false;
                    txt_HallazgosVacio.Visible = true;
                }
                else
                {
                    grdHallazgos.Visible = true;
                    txt_HallazgosVacio.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MostrarAlert("DATA BIND HALLAZGOS: " + ex.Message);
            }
            finally
            {
                hallazgoClient = null;
            }
        }

        private void grdOutcomesDataBind()
        {
            ResultadoProgramaWS.ResultadoProgramaClient resultadoProgramaClient = null;
            
            try
            {
                resultadoProgramaClient = new ResultadoProgramaWS.ResultadoProgramaClient();
                grdOutcomes.DataSource = resultadoProgramaClient.WSListarResultadoProgramaxCurso(objInformeDC.CursoId, objInformeDC.PeriodoId).LstResultadoProgramaxCurso;
                grdOutcomes.DataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert("DATA BIND OUTCOMES: " + ex.Message);
            }
            finally
            {
                resultadoProgramaClient = null;
            }
        }

        private void grdAccionesMejoraDataBind()
        {
            AccionMejoraWS.AccionMejoraClient accionMejoraClient = null;

            try
            {
                accionMejoraClient = new AccionMejoraWS.AccionMejoraClient();
                grdAccionesdeMejora.DataSource = accionMejoraClient.WSListarAccionesMejoraxInformeFinCiclo(objInformeDC.InformeFinCicloId).LstAccionesMejora;
                grdAccionesdeMejora.DataBind();

                if (accionMejoraClient.WSListarAccionesMejoraxInformeFinCiclo(objInformeDC.InformeFinCicloId).LstAccionesMejora.Count() <= 0)
                {
                    grdAccionesdeMejora.Visible = false;
                    txt_AccionesMejoraVacia.Visible = true;
                }
                else
                {
                    grdAccionesdeMejora.Visible = true;
                    txt_AccionesMejoraVacia.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MostrarAlert("DATA BIND ACCIONES MEJORA: " + ex.Message);
            }
            finally
            {
                accionMejoraClient = null;
            }
        }

        private void grdAccionesPreviasDataBind()
        {
            AccionMejoraWS.AccionMejoraClient accionPreviaClient = null;

            try
            {
                accionPreviaClient = new AccionMejoraWS.AccionMejoraClient();
                listaAccionesPrevias = accionPreviaClient.WSListarAccionesMejoraPrevias(objInformeDC.CursoId, objInformeDC.PeriodoId);
                grdAccionesPrevias.DataSource = listaAccionesPrevias.LstAccionesMejora;
                grdAccionesPrevias.DataBind();

                if (listaAccionesPrevias.LstAccionesMejora.Count() <= 0)
                {
                    grdAccionesPrevias.Visible = false;
                    txt_AccionPreviaVacia.Visible = true;
                }
                else
                {
                    grdAccionesPrevias.Visible = true;
                    txt_AccionPreviaVacia.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MostrarAlert("DATA BIND ACCIONES PREVIAS: " + ex.Message);
            }
            finally
            {
                accionPreviaClient = null;
            }
        }


        //POPUPS
        
        protected void popup_buttonRegistrarHallazgo_Click(object sender, EventArgs e)
        {
            HallazgoWS.HallazgoClient client = null;

            try
            {
                client = new HallazgoWS.HallazgoClient();
                client.WSRegistrarHallazgo(objInformeDC.InformeFinCicloId, popup_textoDescripcionHallazgoRegistrar.Text.ToString().Trim(), objInformeDC.PeriodoId);
                grdHallazgosDataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert("NUEVO HALLAZGO: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        protected void popup_buttonEditarHallazgo_Click(object sender, EventArgs e)
        {
            HallazgoWS.HallazgoClient client = null;

            try
            {
                client = new HallazgoWS.HallazgoClient();
                client.WSEditarHallazgo(Convert.ToInt32(hiddenAE2.Value), objInformeDC.InformeFinCicloId, popup_textoDescripcionHallazgoEditar.Text.ToString().Trim());
                grdHallazgosDataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert("EDITAR HALLAZGO: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        protected void popup_buttonRegistrarAccioMejora_Click(object sender, EventArgs e)
        {
            AccionMejoraWS.AccionMejoraClient client = null;

            try
            {
                client = new AccionMejoraWS.AccionMejoraClient();
                client.WSRegistrarAccionMejora(Convert.ToInt32(hiddenAC2.Value), objInformeDC.InformeFinCicloId, Convert.ToInt32(combo_AccionMejoraRegistrar.SelectedValue), popup_textoDescripcionAccionMejoraRegistrar.Text.ToString().Trim());
                grdAccionesMejoraDataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert("NUEVA ACCION MEJORA: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        protected void popup_buttonEditarAccioMejora_Click(object sender, EventArgs e)
        {
            AccionMejoraWS.AccionMejoraClient client = null;

            try
            {
                client = new AccionMejoraWS.AccionMejoraClient();
                client.WSEditarAccionMejora(Convert.ToInt32(hiddenEAC2.Value), objInformeDC.InformeFinCicloId, Convert.ToInt32(combo_AccionMejoraEditar.SelectedValue), popup_textoDescripcionAccionMejoraEditar.Text.ToString().Trim());
                grdAccionesMejoraDataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert("EDITAR ACCION MEJORA: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        //ROW COMMANDS

        public void grdHallazgos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            HallazgoWS.HallazgoClient client = null;

            try
            {
                if (e.CommandName.ToUpper().Equals("CMDELIMINARHALLAZGO"))
                {
                    client = new HallazgoWS.HallazgoClient();
                    client.WSEliminarHallazgo(Convert.ToInt32(e.CommandArgument.ToString()), objInformeDC.InformeFinCicloId);
                    grdHallazgosDataBind();
                    grdAccionesMejoraDataBind();
                }
            }
            catch (Exception ex)
            {
                MostrarAlert("ELIMINAR HALLAZGO: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        public void grdAccionesMejora_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AccionMejoraWS.AccionMejoraClient client = null;

            try
            {
                if (e.CommandName.ToUpper().Equals("CMDELIMINARACCIONMEJORA"))
                {
                    client = new AccionMejoraWS.AccionMejoraClient();
                    client.WSEliminarAccionMejora(Convert.ToInt32(e.CommandArgument.ToString()), objInformeDC.InformeFinCicloId);
                    grdAccionesMejoraDataBind();
                }
            }

            catch (Exception ex)
            {
                MostrarAlert("ELIMINAR ACCION MEJORA: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }

        /*
        public void  grdHallazgos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AccionMejoraWS.AccionMejoraClient client = null;

            try
            {
                if (e.CommandName.ToUpper().Equals("CMDEDITARACCIONPREVIA"))
                {
                    client = new AccionMejoraWS.AccionMejoraClient();
                    client.WSEditarAccionMejoraPrevia(objInformeDC.CursoId, objInformeDC.PeriodoId, Convert.ToInt32(e.CommandArgument.ToString()), e.CommandArgument);
                    grdAccionesMejoraDataBind();
                }
            }

            catch (Exception ex)
            {
                MostrarAlert("ELIMINAR ACCION MEJORA: " + ex.Message);
            }
            finally
            {
                client = null;
            }
        }*/

        protected void gvAccionesPrevias_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = grdAccionesPrevias.Rows[e.NewEditIndex];

            DropDownList ddl = row.FindControl("dpdListEstatus") as DropDownList;
            String value = ddl.SelectedValue;
        }

        protected void grdvAccionesPrevias_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            int indexEstado = 0;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if(listaAccionesPrevias.LstAccionesMejora[e.Row.RowIndex].Estado == "NO REALIZADO")
                {
                    indexEstado = 0;
                }
                else if(listaAccionesPrevias.LstAccionesMejora[e.Row.RowIndex].Estado == "EN PROCESO")
                {
                    indexEstado = 1;
                }
                else
                {
                    indexEstado = 2;
                }
                
                ((DropDownList)e.Row.FindControl("dpdListEstatus")).SelectedIndex = indexEstado;
            }
        }

        protected void dpdListEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;

            //upLblDescripcion.Triggers.Add(new AsyncPostBackTrigger()
            //{
            //    ControlID = (ddl).UniqueID,
            //    EventName = "SelectedIndexChanged",
            //});

            String valor = ddl.SelectedValue;
        }

        public void OnConfirm(object sender, EventArgs e)
        {
            InformeFinCicloWS.InformeFinCicloClient client = null;
            HallazgoWS.HallazgoClient hallazgoClient = null;

            HallazgoWS.HallazgoCollectionDC objHallazgoCollection = null;

            String sEstado = "EN PROCESO";
            int informeID = objInformeDC.InformeFinCicloId;
            String sUnidades = txt_DesarrolloAprendizaje.Text.ToString().Trim();
            String sInfraestructura = txt_Infraestructura.Text.ToString().Trim();
            String sAlumnos = txt_Alumnos.Text.ToString().Trim();
            String sDelegados = txt_Delegados.Text.ToString().Trim();
            String sEncuesta = txt_EncuestaAcademica.Text.ToString().Trim();

            try
            {
                client = new InformeFinCicloWS.InformeFinCicloClient();
                hallazgoClient = new HallazgoWS.HallazgoClient();
                objHallazgoCollection = hallazgoClient.WSListarHallazgosxInformeFinCiclo(informeID);
    
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue == "YES")
                {
                    if (!existenCamposVacios() && objHallazgoCollection.LstHallazgos.Count() > 0)
                    {
                        sEstado = "FINALIZADO";
                        objInformeDC = client.WSEditarInformeFinCiclo(informeID, sEstado, sUnidades, sInfraestructura, sAlumnos, sDelegados, sEncuesta);
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usted ha finalizado el Informe de Fin de Ciclo satisfactorimente.')", true);
                    }

                    else
                    {
                        objInformeDC = client.WSEditarInformeFinCiclo(informeID, sEstado, sUnidades, sInfraestructura, sAlumnos, sDelegados, sEncuesta);
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usted debe llenar todos los campos para completar el Informe de Fin de Ciclo.')", true);
                    }

                }
                else
                {
                    objInformeDC = client.WSEditarInformeFinCiclo(informeID, sEstado, sUnidades, sInfraestructura, sAlumnos, sDelegados, sEncuesta);
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La información ha sido almacenada. Para finalizar el Informe de Fin de Ciclo, debe enviar el Informe.')", true);
                }
            }
            catch (Exception ex)
            {
                MostrarAlert("GUARDAR INFORME: " + ex.Message);
            }
            finally
            {
                client = null;
            }

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
            for (int i = 0; i < listaPeriodosFiltrada.LstPeriodos.Count(); i++)
            {
                combo_AccionMejoraRegistrar.Items.Add(new ListItem(listaPeriodosFiltrada.LstPeriodos[i].Descripcion, listaPeriodosFiltrada.LstPeriodos[i].PeriodoId.ToString()));
                combo_AccionMejoraEditar.Items.Add(new ListItem(listaPeriodosFiltrada.LstPeriodos[i].Descripcion, listaPeriodosFiltrada.LstPeriodos[i].PeriodoId.ToString()));
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

            for (int j = posicionPeriodoActual + 1; j > posicionPeriodoActual - 1; j--)
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

        private void MostrarAlert(String mensaje)
        {
            ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "MensajeError", String.Format("alert('{0}');", mensaje), true);
        }

        public void grdInformes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            InformeFinCicloWS.InformeFinCicloClient informeFinCicloClient = null;
            ResultadoProgramaWS.ResultadoProgramaClient resultadoClient = null;
            LogroWS.LogroClient logroClient = null;
            HallazgoWS.HallazgoClient hallazgoClient = null;
            AccionMejoraWS.AccionMejoraClient accionClient = null;
            PersonaWS.PersonaClient personaClient = null;
            CursoWS.CursoClient cursoClient = null;
            PeriodoWS.PeriodoClient periodoClient = null;

            try
            {
                informeFinCicloClient = new InformeFinCicloWS.InformeFinCicloClient();
                resultadoClient = new ResultadoProgramaWS.ResultadoProgramaClient();
                logroClient = new LogroWS.LogroClient();
                hallazgoClient = new HallazgoWS.HallazgoClient();
                accionClient = new AccionMejoraWS.AccionMejoraClient();
                personaClient = new PersonaWS.PersonaClient();
                cursoClient = new CursoWS.CursoClient();
                periodoClient = new PeriodoWS.PeriodoClient();

                if (e.CommandName.ToUpper().Equals("CMDINICIAR"))
                {
                    InformeFinCicloWS.InformeFinCicloDC informe = informeFinCicloClient.WSObtenerInformeFinCicloxId(Convert.ToInt32(e.CommandArgument.ToString()));
                    ResultadoProgramaWS.ResultadoProgramaxCursoCollectionDC outcomes = resultadoClient.WSListarResultadoProgramaxCurso(informe.CursoId, informe.PeriodoId);
                    LogroWS.LogroDC logro = logroClient.WSListarLogroxCurso(informe.CursoId);
                    HallazgoWS.HallazgoCollectionDC hallazgos = hallazgoClient.WSListarHallazgosxInformeFinCiclo(informe.InformeFinCicloId);
                    AccionMejoraWS.AccionMejoraCollectionDC accionesmejora = accionClient.WSListarAccionesMejoraxInformeFinCiclo(informe.InformeFinCicloId);
                    AccionMejoraWS.AccionMejoraCollectionDC accionesprevias = accionClient.WSListarAccionesMejoraPrevias(informe.CursoId, informe.PeriodoId);

                    PersonaWS.PersonaDC persona = personaClient.WSObtenerPersona(informe.CoordinadorId);

                    CursoWS.CursoCollectionDC cursos = cursoClient.ListarCursos();
                    CursoWS.CursoDC curso = null;

                    for (int i = 0; i < cursos.Count(); i++)
                        if (informe.CursoId == cursos[i].CursoId)
                            curso = cursos[i];

                    PeriodoWS.PeriodoCollectionDC periodos = periodoClient.WSListarPeriodos();
                    PeriodoWS.PeriodoDC periodo = null;

                    for (int i = 0; i < periodos.Count(); i++)
                        if (informe.PeriodoId == periodos[i].PeriodoId)
                            periodo = periodos[i];
                    //-------------------------------------------------------------------------------------------------------------------------

                    //ACCIONES PREVIAS
                    DataTable tableAccionesPrevias = new DataTable();
                    tableAccionesPrevias.Columns.Add("Código");
                    tableAccionesPrevias.Columns.Add("Descripción");
                    tableAccionesPrevias.Columns.Add("Estado");

                    for (int i = 0; i < accionesprevias.LstAccionesMejora.Count(); i++)
                    {
                        DataRow rowAccionPrevias = tableAccionesPrevias.NewRow();
                        rowAccionPrevias[0] = accionesprevias.LstAccionesMejora[i].Codigo;
                        rowAccionPrevias[1] = accionesprevias.LstAccionesMejora[i].Descripcion;
                        rowAccionPrevias[2] = accionesprevias.LstAccionesMejora[i].Estado;
                        tableAccionesPrevias.Rows.Add(rowAccionPrevias);
                    }

                    //HALLAZGOS
                    DataTable tableHallazgos = new DataTable();
                    tableHallazgos.Columns.Add("Código");
                    tableHallazgos.Columns.Add("Descripción");

                    for (int i = 0; i < hallazgos.LstHallazgos.Count(); i++)
                    {
                        DataRow rowHallazgo = tableHallazgos.NewRow();
                        rowHallazgo[0] = hallazgos.LstHallazgos[i].Codigo;
                        rowHallazgo[1] = hallazgos.LstHallazgos[i].Descripcion;
                        tableHallazgos.Rows.Add(rowHallazgo);
                    }

                    //ACCIONES DE MEJORA
                    DataTable tableAccionMejora = new DataTable();
                    tableAccionMejora.Columns.Add("Código");
                    tableAccionMejora.Columns.Add("Descripción");
                    tableAccionMejora.Columns.Add("Hallazgo");

                    for (int i = 0; i < accionesmejora.LstAccionesMejora.Count(); i++)
                    {
                        DataRow rowAccionMejora = tableAccionMejora.NewRow();
                        rowAccionMejora[0] = accionesmejora.LstAccionesMejora[i].Codigo;
                        rowAccionMejora[1] = accionesmejora.LstAccionesMejora[i].Descripcion;
                        rowAccionMejora[2] = accionesmejora.LstAccionesMejora[i].CodigoHallazgo;
                        tableAccionMejora.Rows.Add(rowAccionMejora);
                    }

                    //STUDENT OUTCUMES
                    DataTable tableOutcomes = new DataTable();
                    tableOutcomes.Columns.Add("Outcome");
                    tableOutcomes.Columns.Add("Descripción");

                    for (int i = 0; i < outcomes.LstResultadoProgramaxCurso.Count(); i++)
                    {
                        DataRow rowOutcome = tableOutcomes.NewRow();
                        rowOutcome[0] = outcomes.LstResultadoProgramaxCurso[i].Outcome;
                        rowOutcome[1] = outcomes.LstResultadoProgramaxCurso[i].Descricpion;
                        tableOutcomes.Rows.Add(rowOutcome);
                    }

                    String ruta = Server.MapPath("~/Reportes/" + periodo.Descripcion + "_" + curso.Codigo + "_InformeFinCiclo.pdf");

                    PDFGenerator objPDF = new PDFGenerator();
                    objPDF.generarPdf(periodo.Descripcion, curso.Codigo + " - " + curso.Nombre, persona.Apellidos + ", " + persona.Nombres, tableOutcomes, logro.Descripcion, tableAccionesPrevias, tableHallazgos, tableAccionMejora,
                        informe.DesarrolloUnidades, informe.ComentarioInfraestructura, informe.ComentarioAlumnos, informe.ComentarioDelegados, informe.ComentarioEncuesta,
                        ruta);
                }
            }

            catch (Exception ex)
            {
                MostrarAlert("EXPORTAR INFORME: " + ex.Message);
            }

            finally
            {
                informeFinCicloClient = null;
                resultadoClient = null;
                logroClient = null;
                hallazgoClient = null;
                accionClient = null;
                cursoClient = null;
                periodoClient = null;
            }
        }
    }
}