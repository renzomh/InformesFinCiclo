using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UPC.IFCDC.BE;
using UPC.IFCDC.BC;
using UPC.IFCDC.Utilitarios;

using System.Data;

namespace UPC.IFCDC.UI
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        /*
        CursoCollectionBE objCursoCollectionBE = null;
        PeriodoCollectionBE objPeriodoCollectionBE = null;
        PeriodoCollectionBE listaPeriodosFiltrados = null;

        CursoBC objCursoBC = null;
        PeriodoBC objPeriodoBC = null;

        HallazgoReporteCollectionBE reporteHallazgosBE = null;
        AccionMejoraReporteCollectionBE reporteAccionesBE = null;
        */

        CursoWS.CursoCollectionDC objCursoCollectionDC = null;
        PeriodoWS.PeriodoCollectionDC objPeriodoCollectionDC = null;
        PeriodoCollectionBE listaPeriodosFiltrado = null;

        HallazgoWS.HallazgoReporteCollectionDC listaHallazgos = null;
        AccionMejoraWS.AccionMejoraReporteCollectionDC listaAcciones = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                obtenerCurso();
                obtenerPeriodos();
                setearCombos(); 
            }

            reporteInformeFinCicloDataBind();
            reporteHallazgoDataBind();
            reporteAccionMejoraDataBind();
        }

        private void obtenerCurso()
        {
            CursoWS.CursoClient client = null;

            try
            {
                client = new CursoWS.CursoClient();
                objCursoCollectionDC = client.ListarCursos();
            }
            catch (Exception ex)
            {
                MostrarAlert("OBTENER CURSOS: " + ex.Message);
            }
            finally
            {
                client = null;
            }
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

        protected void btnBuscaInformesFinCiclo_Click(object sender, EventArgs e)
        {
            reporteInformeFinCicloDataBind();
        }

        protected void btnBuscaHallazgos_Click(object sender, EventArgs e)
        {
            reporteHallazgoDataBind();
        }

        protected void btnBuscaAcciones_Click(object sender, EventArgs e)
        {
            reporteAccionMejoraDataBind();
        }

        protected void btnExportaHallazgo_Click(object sender, EventArgs e)
        {
            if (listaHallazgos.LstHallazgoReporte.Count() <= 0)
            {
                MostrarAlert("No existen hallazgos en la bandeja.");
            }
            else
            {
                PDFGenerator pdf = new PDFGenerator();

                HallazgoWS.HallazgoClient client = null;
                HallazgoWS.HallazgoReporteCollectionDC hallazgos = null;

                try
                {
                    client = new HallazgoWS.HallazgoClient();
                    hallazgos = client.WSListarHallazgoReporte(
                            Convert.ToInt32(combo_HallazgoCurso.SelectedItem.Value),
                            Convert.ToInt32(combo_HallazgoCiclo.SelectedItem.Value));

                    //HALLAZGOS
                    DataTable tableHallazgos = new DataTable();
                    tableHallazgos.Columns.Add("Codigo");
                    tableHallazgos.Columns.Add("Descripcion");
                    tableHallazgos.Columns.Add("Curso");

                    for (int i = 0; i < hallazgos.LstHallazgoReporte.Count(); i++)
                    {
                        DataRow row = tableHallazgos.NewRow();
                        row[0] = hallazgos.LstHallazgoReporte[i].CodigoHallazgo;
                        row[1] = hallazgos.LstHallazgoReporte[i].Descripcion;
                        row[2] = hallazgos.LstHallazgoReporte[i].NombreCurso;
                        tableHallazgos.Rows.Add(row);
                    }

                    String ruta = Server.MapPath("~/Reportes/Hallazgos.pdf");

                    pdf.generearReporteHallazgos(combo_HallazgoCurso.SelectedItem.Text, combo_HallazgoCiclo.SelectedItem.Text, tableHallazgos, ruta);
                }
                catch (Exception ex)
                {
                    MostrarAlert("EXPORTAR HALLAZGOS: " + ex.Message);
                }
                finally
                {
                    client = null;
                }
            }
        }

        protected void btnExportaAcciones_Click(object sender, EventArgs e)
        {
            PDFGenerator pdf = null;

            if(listaAcciones.LstAccionMejoraReporte.Count() <= 0)
            {
                MostrarAlert("No existen acciones de mejora en la bandeja.");
            }

            else
            {
                pdf = new PDFGenerator();
            
                AccionMejoraWS.AccionMejoraClient client = null;
                AccionMejoraWS.AccionMejoraReporteCollectionDC acciones = null;

                String sEstado = null;

                client = new AccionMejoraWS.AccionMejoraClient();

                try
                {
                    client = new AccionMejoraWS.AccionMejoraClient();

                    if (combo_AccionMejoraEstado.SelectedItem.Value.Equals("TODOS"))
                        sEstado = "";
                    else
                        sEstado = combo_AccionMejoraEstado.SelectedItem.Value;

                    acciones = client.WSListarAccionMejoraReporte(
                                Convert.ToInt32(combo_AccionMejoraCurso.SelectedItem.Value), 
                                Convert.ToInt32(combo_AccionMejoraCiclo.SelectedItem.Value), sEstado);

                    //ACCIONES
                    DataTable tableAcciones = new DataTable();
                    tableAcciones.Columns.Add("Codigo");
                    tableAcciones.Columns.Add("Hallazgo");
                    tableAcciones.Columns.Add("Descripcion");
                    tableAcciones.Columns.Add("Curso");
                    tableAcciones.Columns.Add("Estado");

                    for (int i = 0; i < acciones.LstAccionMejoraReporte.Count(); i++)
                    {
                        DataRow row = tableAcciones.NewRow();
                        row[0] = acciones.LstAccionMejoraReporte[i].CodigoAccionMejora;
                        row[1] = acciones.LstAccionMejoraReporte[i].CodigoHallazgo;
                        row[2] = acciones.LstAccionMejoraReporte[i].Descripcion;
                        row[3] = acciones.LstAccionMejoraReporte[i].NombreCurso;
                        row[4] = acciones.LstAccionMejoraReporte[i].Estado;
                        tableAcciones.Rows.Add(row);
                    }

                    String ruta = Server.MapPath("~/Reportes/AccionesDeMejora.pdf");

                    pdf.generearReporteAcciones(combo_AccionMejoraCurso.SelectedItem.Text, combo_AccionMejoraCiclo.SelectedItem.Text, combo_AccionMejoraEstado.SelectedItem.Text, tableAcciones, ruta);
                }
                catch (Exception ex)
                {
                    MostrarAlert("EXPORTAR ACCIONES: " + ex.Message);
                }
                finally
                {
                    client = null;
                }
            }      
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

        private PeriodoCollectionBE obtenerPeriodosFiltrados(PeriodoWS.PeriodoCollectionDC listaPeriodosTotal)
        {
            int posicionPeriodoActual = 0;
            PeriodoCollectionBE lista =  new PeriodoCollectionBE();
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

        private void reporteInformeFinCicloDataBind()
        {
            InformeFinCicloWS.InformeFinCicloClient client = null;
            String sEstado = null;

            try
            {
                client = new InformeFinCicloWS.InformeFinCicloClient();

                if (combo_InformeFinCicloEstado.SelectedItem.Value.Equals("TODOS"))
                    sEstado = "";
                else
                    sEstado = combo_InformeFinCicloEstado.SelectedItem.Value;

                grdInformes.DataSource = client.WSListarInformeFinCicloReporte(Convert.ToInt32(combo_InformeFinCicloCurso.SelectedItem.Value), Convert.ToInt32(combo_InformeFinCicloCiclo.SelectedItem.Value), sEstado).LstInformeFinCicloReporte;
                grdInformes.DataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert("DATA BIND, REPORTE INFORMES: " + ex.Message);
            }
            finally
            {
                client = null;
            }

            /*
            InformeFinCicloBE informe = new InformeFinCicloBE();
            informe.CursoId = Convert.ToInt32(combo_InformeFinCicloCurso.SelectedItem.Value);
            informe.PeriodoId = Convert.ToInt32(combo_InformeFinCicloCiclo.SelectedItem.Value);
            if (combo_InformeFinCicloEstado.SelectedItem.Value.Equals("TODOS"))
                informe.Estado = " ";
            else
                informe.Estado = combo_InformeFinCicloEstado.SelectedItem.Value;

            InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
            InformeFinCicloReporteCollectionBE reporteBE = objInformeFinCicloBC.listarReporteInformeFinCiclo(informe);

            grdInformes.DataSource = reporteBE.LstInformeFinCicloReporte;
            grdInformes.DataBind();
            */
        }

        private void reporteHallazgoDataBind()
        {
            HallazgoWS.HallazgoClient client = null;

            try
            {
                client = new HallazgoWS.HallazgoClient();
                listaHallazgos = client.WSListarHallazgoReporte(Convert.ToInt32(combo_HallazgoCurso.SelectedItem.Value), Convert.ToInt32(combo_HallazgoCiclo.SelectedItem.Value));
                grdHallazgos.DataSource = listaHallazgos.LstHallazgoReporte;
                grdHallazgos.DataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert("DATA BIND, REPORTE HALLAZGOS: " + ex.Message);
            }
            finally
            {
                client = null;
            }

            /*
            InformeFinCicloBE informe = new InformeFinCicloBE();
            informe.CursoId = Convert.ToInt32(combo_HallazgoCurso.SelectedItem.Value);
            informe.PeriodoId = Convert.ToInt32(combo_HallazgoCiclo.SelectedItem.Value);

            HallazgoBC objHallazgoBC = new HallazgoBC();
            reporteHallazgosBE = objHallazgoBC.listarReporteHallazgo(informe);

            grdHallazgos.DataSource = reporteHallazgosBE.LstHallazgoReporte;
            grdHallazgos.DataBind();
            */
        }

        private void reporteAccionMejoraDataBind()
        {
            AccionMejoraWS.AccionMejoraClient client = null;
            String sEstado = null;

            try
            {
                client = new AccionMejoraWS.AccionMejoraClient();

                if (combo_AccionMejoraEstado.SelectedItem.Value.Equals("TODOS"))
                    sEstado = "";
                else
                    sEstado = combo_AccionMejoraEstado.SelectedItem.Value;

                listaAcciones = client.WSListarAccionMejoraReporte(Convert.ToInt32(combo_AccionMejoraCurso.SelectedItem.Value), Convert.ToInt32(combo_AccionMejoraCiclo.SelectedItem.Value), sEstado);
                grdAccionesMejora.DataSource = listaAcciones.LstAccionMejoraReporte;
                grdAccionesMejora.DataBind();
            }
            catch (Exception ex)
            {
                MostrarAlert("DATA BIND, REPORTE ACCION MEJORA: " + ex.Message);
            }
            finally
            {
                client = null;
            }

            /*
            InformeFinCicloBE informe = new InformeFinCicloBE();
            informe.CursoId = Convert.ToInt32(combo_AccionMejoraCurso.SelectedItem.Value);
            informe.PeriodoId = Convert.ToInt32(combo_AccionMejoraCiclo.SelectedItem.Value);
            if (combo_AccionMejoraEstado.SelectedItem.Value.Equals("TODOS"))
                informe.Estado = " ";
            else
                informe.Estado = combo_AccionMejoraEstado.SelectedItem.Value;

            AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
            reporteAccionesBE = objAccionMejoraBC.listarReporteAccionMejora(informe);

            grdAccionesMejora.DataSource = reporteAccionesBE.LstAccionMejoraReporte;
            grdAccionesMejora.DataBind();
            */
        }

        private void setearCombos()
        {
            combo_InformeFinCicloCurso.Items.Add(new ListItem("TODOS", "0"));
            combo_InformeFinCicloCiclo.Items.Add(new ListItem("TODOS", "0"));

            combo_HallazgoCurso.Items.Add(new ListItem("TODOS", "0"));
            combo_HallazgoCiclo.Items.Add(new ListItem("TODOS", "0"));

            combo_AccionMejoraCurso.Items.Add(new ListItem("TODOS", "0"));
            combo_AccionMejoraCiclo.Items.Add(new ListItem("TODOS", "0"));

            for (int i = 0; i < objCursoCollectionDC.Count(); i++)
            {
                combo_InformeFinCicloCurso.Items.Add(new ListItem(objCursoCollectionDC[i].Codigo + " - " + objCursoCollectionDC[i].Nombre, objCursoCollectionDC[i].CursoId.ToString()));
                combo_HallazgoCurso.Items.Add(new ListItem(objCursoCollectionDC[i].Codigo + " - " + objCursoCollectionDC[i].Nombre, objCursoCollectionDC[i].CursoId.ToString()));
                combo_AccionMejoraCurso.Items.Add(new ListItem(objCursoCollectionDC[i].Codigo + " - " + objCursoCollectionDC[i].Nombre, objCursoCollectionDC[i].CursoId.ToString()));
            }

            for (int i = 0; i < listaPeriodosFiltrado.LstPeriodos.Count; i++)
            {
                combo_InformeFinCicloCiclo.Items.Add(new ListItem(listaPeriodosFiltrado.LstPeriodos[i].Descripcion, listaPeriodosFiltrado.LstPeriodos[i].PeriodoId.ToString()));
                combo_HallazgoCiclo.Items.Add(new ListItem(listaPeriodosFiltrado.LstPeriodos[i].Descripcion, listaPeriodosFiltrado.LstPeriodos[i].PeriodoId.ToString()));
                combo_AccionMejoraCiclo.Items.Add(new ListItem(listaPeriodosFiltrado.LstPeriodos[i].Descripcion, listaPeriodosFiltrado.LstPeriodos[i].PeriodoId.ToString()));
            }
        }

        private void MostrarAlert(String mensaje)
        {
            ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "MensajeError", String.Format("alert('{0}');", mensaje), true);
        }
    }
}