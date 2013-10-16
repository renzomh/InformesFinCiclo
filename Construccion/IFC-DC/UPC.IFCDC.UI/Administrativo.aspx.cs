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
        CursoCollectionBE objCursoCollectionBE = null;
        PeriodoCollectionBE objPeriodoCollectionBE = null;
        PeriodoCollectionBE listaPeriodosFiltrados = null;

        CursoBC objCursoBC = null;
        PeriodoBC objPeriodoBC = null;

        HallazgoReporteCollectionBE reporteHallazgosBE = null;
        AccionMejoraReporteCollectionBE reporteAccionesBE = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                objCursoBC = new CursoBC();
                objCursoCollectionBE = objCursoBC.listarCursos();
                if (objCursoCollectionBE == null) objCursoCollectionBE = new CursoCollectionBE();

                objPeriodoBC = new PeriodoBC();
                objPeriodoCollectionBE = objPeriodoBC.listarPeriodos();
                if (objPeriodoCollectionBE == null) objPeriodoCollectionBE = new PeriodoCollectionBE();

                listaPeriodosFiltrados = obtenerPeriodosFiltrados(objPeriodoCollectionBE);
                setearCombos(); 
            }

            reporteInformeFinCicloDataBind();
            reporteHallazgoDataBind();
            reporteAccionMejoraDataBind();
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
            PDFGenerator pdf = new PDFGenerator();

            //HALLAZGOS
            DataTable tableHallazgos = new DataTable();
            tableHallazgos.Columns.Add("Codigo");
            tableHallazgos.Columns.Add("Descripcion");
            tableHallazgos.Columns.Add("Curso");

            for (int i = 0; i < reporteHallazgosBE.LstHallazgoReporte.Count; i++)
            {
                DataRow row = tableHallazgos.NewRow();
                row[0] = reporteHallazgosBE.LstHallazgoReporte[i].CodigoHallazgo;
                row[1] = reporteHallazgosBE.LstHallazgoReporte[i].Descripcion;
                row[2] = reporteHallazgosBE.LstHallazgoReporte[i].NombreCurso;
                tableHallazgos.Rows.Add(row);
            }

            pdf.generearReporteHallazgos(combo_HallazgoCurso.SelectedItem.Text, combo_HallazgoCiclo.SelectedItem.Text, tableHallazgos);
        }

        protected void btnExportaAcciones_Click(object sender, EventArgs e)
        {
            PDFGenerator pdf = new PDFGenerator();

            //ACCIONES
            DataTable tableAcciones = new DataTable();
            tableAcciones.Columns.Add("Codigo");
            tableAcciones.Columns.Add("Hallazgo");
            tableAcciones.Columns.Add("Descripcion");
            tableAcciones.Columns.Add("Curso");
            tableAcciones.Columns.Add("Estado");

            for (int i = 0; i < reporteAccionesBE.LstAccionMejoraReporte.Count; i++)
            {
                DataRow row = tableAcciones.NewRow();
                row[0] = reporteAccionesBE.LstAccionMejoraReporte[i].CodigoAccionMejora;
                row[1] = reporteAccionesBE.LstAccionMejoraReporte[i].CodigoHallazgo;
                row[2] = reporteAccionesBE.LstAccionMejoraReporte[i].Descripcion;
                row[3] = reporteAccionesBE.LstAccionMejoraReporte[i].NombreCurso;
                row[4] = reporteAccionesBE.LstAccionMejoraReporte[i].Estado;
                tableAcciones.Rows.Add(row);
            }

            pdf.generearReporteAcciones(combo_AccionMejoraCurso.SelectedItem.Text, combo_AccionMejoraCiclo.SelectedItem.Text, combo_AccionMejoraEstado.SelectedItem.Text, tableAcciones);
        }

        public void grdInformes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper().Equals("CMDINICIAR"))
                {
                    InformeFinCicloBE objInformeFinCicloBE = new InformeFinCicloBE();
                    objInformeFinCicloBE.InformeFinCicloId = Convert.ToInt32(e.CommandArgument.ToString());
                    objInformeFinCicloBE = new InformeFinCicloBC().obtenerInformeFinCicloxId(objInformeFinCicloBE);

                    AccionMejoraCollectionBE objAccionPreviasCollectionBE = null;
                    InformeFinCicloBE objAccionPreviaBE = new InformeFinCicloBE();
                    objAccionPreviaBE.CursoId = objInformeFinCicloBE.CursoId;
                    objAccionPreviaBE.PeriodoId = objInformeFinCicloBE.PeriodoId;
                    objAccionPreviasCollectionBE = new AccionMejoraBC().listarAccionesPrevias(objAccionPreviaBE);

                    HallazgoCollectionBE objHallazgoCollectionBE = null;
                    HallazgoBE objHallazgoBE = new HallazgoBE();
                    objHallazgoBE.InformeFinCicloId = objInformeFinCicloBE.InformeFinCicloId;
                    objHallazgoCollectionBE = new HallazgoBC().listarHallazgos(objHallazgoBE);

                    AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;
                    AccionMejoraBE objAccionMejoraBE = new AccionMejoraBE();
                    objAccionMejoraBE.InformeFinCicloId = objInformeFinCicloBE.InformeFinCicloId;
                    objAccionMejoraCollectionBE = new AccionMejoraBC().listarAccionesMejora(objAccionMejoraBE);

                    ResultadoProgramaxCursoCollectionBE objResultadoProgramaCollectionBE = null;
                    ResultadoProgramaxCursoBE objResultadoPrograma = new ResultadoProgramaxCursoBE();
                    objResultadoPrograma.CursoId = objInformeFinCicloBE.CursoId;
                    objResultadoProgramaCollectionBE = new ResultadoProgramaxCursoBC().listarResultadoProgramaxCurso(objResultadoPrograma);

                    LogroBE objLogroBE = new LogroBE();
                    objLogroBE.CursoId = objInformeFinCicloBE.CursoId;
                    objLogroBE = new LogroBC().obtenerLogroxCurso(objLogroBE);

                    //-------------------------------------------------------------------------------------------------------------------------

                    //PERSONA
                    PersonaBE objPersonaBE = new PersonaBE();
                    objPersonaBE.PersonaId = objInformeFinCicloBE.CoordinadorId;
                    objPersonaBE = new PersonaBC().obtenerPersona(objPersonaBE);

                    //CURSO
                    CursoCollectionBE objCursoCollectionBE = new CursoBC().listarCursos();
                    CursoBE objCursoBE = null;

                    for (int i = 0; i < objCursoCollectionBE.LstCursos.Count; i++)
                    {
                        if(objInformeFinCicloBE.CursoId == objCursoCollectionBE.LstCursos[i].CursoId)
                            objCursoBE = objCursoCollectionBE.LstCursos[i];               
                    }

                    //PERIODO
                    PeriodoCollectionBE objPeriodoCollectionBE = new PeriodoBC().listarPeriodos();
                    PeriodoBE objPeriodoBE = null;

                    for (int i = 0; i < objPeriodoCollectionBE.LstPeriodos.Count; i++)
                    {
                        if (objInformeFinCicloBE.PeriodoId == objPeriodoCollectionBE.LstPeriodos[i].PeriodoId)
                            objPeriodoBE = objPeriodoCollectionBE.LstPeriodos[i];
                    }

                    //ACCIONES PREVIAS
                    DataTable tableAccionesPrevias = new DataTable();
                    tableAccionesPrevias.Columns.Add("Codigo");
                    tableAccionesPrevias.Columns.Add("Descripcion");
                    tableAccionesPrevias.Columns.Add("Estado");

                    for (int i = 0; i < objAccionPreviasCollectionBE.LstAccionesMejora.Count; i++)
                    {
                        DataRow rowAccionPrevias = tableAccionesPrevias.NewRow();
                        rowAccionPrevias[0] = objAccionPreviasCollectionBE.LstAccionesMejora[i].Codigo;
                        rowAccionPrevias[1] = objAccionPreviasCollectionBE.LstAccionesMejora[i].Descripcion;
                        rowAccionPrevias[2] = objAccionPreviasCollectionBE.LstAccionesMejora[i].Estado;
                        tableAccionesPrevias.Rows.Add(rowAccionPrevias);
                    }

                    //HALLAZGOS
                    DataTable tableHallazgos = new DataTable();
                    tableHallazgos.Columns.Add("Codigo");
                    tableHallazgos.Columns.Add("Descripcion del hallazgo");

                    for (int i = 0; i < objHallazgoCollectionBE.LstHallazgos.Count; i++)
                    {
                        DataRow rowHallazgo = tableHallazgos.NewRow();
                        rowHallazgo[0] = objHallazgoCollectionBE.LstHallazgos[i].Codigo;
                        rowHallazgo[1] = objHallazgoCollectionBE.LstHallazgos[i].Descripcion;
                        tableHallazgos.Rows.Add(rowHallazgo);
                    }

                    //ACCIONES DE MEJORA
                    DataTable tableAccionMejora = new DataTable();
                    tableAccionMejora.Columns.Add("Codigo");
                    tableAccionMejora.Columns.Add("Descripción de la Acción a Realizar");
                    tableAccionMejora.Columns.Add("Hallazgo");

                    for (int i = 0; i < objAccionMejoraCollectionBE.LstAccionesMejora.Count; i++)
                    {
                        DataRow rowAccionMejora = tableAccionMejora.NewRow();
                        rowAccionMejora[0] = objAccionMejoraCollectionBE.LstAccionesMejora[i].Codigo;
                        rowAccionMejora[1] = objAccionMejoraCollectionBE.LstAccionesMejora[i].Descripcion;
                        rowAccionMejora[2] = objAccionMejoraCollectionBE.LstAccionesMejora[i].CodigoHallazgo;
                        tableAccionMejora.Rows.Add(rowAccionMejora);
                    }
                    
                    //STUDENT OUTCUMES
                    DataTable tableOutcomes = new DataTable();
                    tableOutcomes.Columns.Add("Outcome");
                    tableOutcomes.Columns.Add("Descripción");

                    for (int i = 0; i < objResultadoProgramaCollectionBE.LstResultadoProgramaxCurso.Count; i++)
                    {
                        DataRow rowOutcome = tableOutcomes.NewRow();
                        rowOutcome[0] = objResultadoProgramaCollectionBE.LstResultadoProgramaxCurso[i].Outcome;
                        rowOutcome[1] = objResultadoProgramaCollectionBE.LstResultadoProgramaxCurso[i].Descricpion;
                        tableOutcomes.Rows.Add(rowOutcome);
                    }

                    PDFGenerator objPDF = new PDFGenerator();
                    objPDF.generarPdf(objPeriodoBE.Descripcion, objCursoBE.Codigo + " - " + objCursoBE.Nombre, objPersonaBE.Apellidos + ", " + objPersonaBE.Nombres, tableOutcomes, objLogroBE.Descripcion, tableAccionesPrevias, tableHallazgos, tableAccionMejora, objInformeFinCicloBE, "IFC_" + objPeriodoBE.Descripcion + "_" + objCursoBE.Codigo);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private PeriodoCollectionBE obtenerPeriodosFiltrados(PeriodoCollectionBE listaPeriodosTotal)
        {
            int posicionPeriodoActual = 0;
            PeriodoCollectionBE lista =  new PeriodoCollectionBE();
            lista.LstPeriodos = new System.Collections.ObjectModel.Collection<PeriodoBE>();

            for (int i = 0; i < listaPeriodosTotal.LstPeriodos.Count; i++)
            {
                if (listaPeriodosTotal.LstPeriodos[i].EsActual == true)
                {
                    posicionPeriodoActual = i;
                    break;
                }
            }

            for (int j = posicionPeriodoActual; j > posicionPeriodoActual - 3; j--)
            {
                if(j>=0)
                    lista.LstPeriodos.Add(listaPeriodosTotal.LstPeriodos[j]);
            }
               
            return lista;
        }

        private void reporteInformeFinCicloDataBind()
        {
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
        }

        private void reporteHallazgoDataBind()
        {
            InformeFinCicloBE informe = new InformeFinCicloBE();
            informe.CursoId = Convert.ToInt32(combo_HallazgoCurso.SelectedItem.Value);
            informe.PeriodoId = Convert.ToInt32(combo_HallazgoCiclo.SelectedItem.Value);

            HallazgoBC objHallazgoBC = new HallazgoBC();
            reporteHallazgosBE = objHallazgoBC.listarReporteHallazgo(informe);

            grdHallazgos.DataSource = reporteHallazgosBE.LstHallazgoReporte;
            grdHallazgos.DataBind();
        }

        private void reporteAccionMejoraDataBind()
        {
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
        }

        private void setearCombos()
        {
            combo_InformeFinCicloCurso.Items.Add(new ListItem("TODOS", "0"));
            combo_InformeFinCicloCiclo.Items.Add(new ListItem("TODOS", "0"));

            combo_HallazgoCurso.Items.Add(new ListItem("TODOS", "0"));
            combo_HallazgoCiclo.Items.Add(new ListItem("TODOS", "0"));

            combo_AccionMejoraCurso.Items.Add(new ListItem("TODOS", "0"));
            combo_AccionMejoraCiclo.Items.Add(new ListItem("TODOS", "0"));

            for (int i = 0; i < objCursoCollectionBE.LstCursos.Count; i++)
            {
                combo_InformeFinCicloCurso.Items.Add(new ListItem(objCursoCollectionBE.LstCursos[i].Codigo + " - " + objCursoCollectionBE.LstCursos[i].Nombre, objCursoCollectionBE.LstCursos[i].CursoId.ToString()));
                combo_HallazgoCurso.Items.Add(new ListItem(objCursoCollectionBE.LstCursos[i].Codigo + " - " + objCursoCollectionBE.LstCursos[i].Nombre, objCursoCollectionBE.LstCursos[i].CursoId.ToString()));
                combo_AccionMejoraCurso.Items.Add(new ListItem(objCursoCollectionBE.LstCursos[i].Codigo + " - " + objCursoCollectionBE.LstCursos[i].Nombre, objCursoCollectionBE.LstCursos[i].CursoId.ToString()));
            }

            for (int i = 0; i < listaPeriodosFiltrados.LstPeriodos.Count; i++)
            {
                combo_InformeFinCicloCiclo.Items.Add(new ListItem(listaPeriodosFiltrados.LstPeriodos[i].Descripcion, listaPeriodosFiltrados.LstPeriodos[i].PeriodoId.ToString()));
                combo_HallazgoCiclo.Items.Add(new ListItem(listaPeriodosFiltrados.LstPeriodos[i].Descripcion, listaPeriodosFiltrados.LstPeriodos[i].PeriodoId.ToString()));
                combo_AccionMejoraCiclo.Items.Add(new ListItem(listaPeriodosFiltrados.LstPeriodos[i].Descripcion, listaPeriodosFiltrados.LstPeriodos[i].PeriodoId.ToString()));
            }
        }
    }
}