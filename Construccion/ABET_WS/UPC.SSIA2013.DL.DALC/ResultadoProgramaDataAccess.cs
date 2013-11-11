using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;
using System.Configuration;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.DataContract;

namespace UPC.SSIA2013.DataAccess
{
    public class ResultadoProgramaDataAccess
    {
        #region METODOS IFC-DC
        public List<up_Listar_ResultadoPrograma_x_CursoResult> listarResultadoProgramaxCurso(int cursoId, int periodoId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<up_Listar_ResultadoPrograma_x_CursoResult> lstResultadoProgramas = dataContext.up_Listar_ResultadoPrograma_x_Curso(cursoId, periodoId).ToList();

                return lstResultadoProgramas;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }
        #endregion

        #region metodos GPPP
        public List<uspResultadoPrograma_ListarXCarreraXPeriodoResult> resultadoProgramaListarXCarreraXPeriodo(Int32? carreraId, Int32 periodoId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspResultadoPrograma_ListarXCarreraXPeriodoResult> lst = dc.uspResultadoPrograma_ListarXCarreraXPeriodo(carreraId, periodoId).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }

        public List<uspResultadoPrograma_ListarXMallaEncuestaXCarreraResult> resultadoProgramaListarXMallaEncuestaXCarrera(int mallaId, int? carreraId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspResultadoPrograma_ListarXMallaEncuestaXCarreraResult> lst = dc.uspResultadoPrograma_ListarXMallaEncuestaXCarrera(mallaId, carreraId).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }

        public Int32 resultadoProgramaXMallaEncuestaRegistrar(List<ResultadoProgramaXMallaEncuestaDC> lstLR)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());

                Int32 response = -1;
                for (int i = 0; i < lstLR.Count(); i++)
                {
                    response = dc.uspResultadoProgramaXMallaEncuesta_RegistrarXMallaEncuesta(lstLR[i].MallaEncuestaId, lstLR[i].ResultadoProgramaId, lstLR[i].Asignado);

                    if (response == -1)
                    {
                        return response;
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }

        public Int32 resultadoProgramaXCompetenciaAbetRegistrar(List<ResultadoProgramaXCompetenciaAbetDC> lstLR)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());

                Int32 response = -1;
                for (int i = 0; i < lstLR.Count(); i++)
                {
                    response = dc.uspResultadoProgramaXCompetenciaAbet_RegistrarXMallaEncuesta(lstLR[i].ResultadoProgramaId, lstLR[i].CompetenciaAbetId, lstLR[i].Asignado, lstLR[i].MallaEncuestaId);

                    if (response == -1)
                    {
                        return response;
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }

        public Int32 resultadoProgramaXMallaEncuestaActualizar(List<ResultadoProgramaXMallaEncuestaDC> lstLR)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                int ResultadoProgramaId = -1;
                for (int i = 0; i < lstLR.Count(); i++)
                {

                    ResultadoProgramaId = dc.uspResultadoProgramaXMallaEncuesta_ActualizarXMallaEncuesta(lstLR[i].MallaEncuestaId, lstLR[i].ResultadoProgramaId, lstLR[i].Asignado);

                }
                return ResultadoProgramaId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }

        public Int32 resultadoProgramaXCompetenciaAbetActualizar(List<ResultadoProgramaXCompetenciaAbetDC> lstLR)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                int CompetenciaAbetId = -1;
                for (int i = 0; i < lstLR.Count(); i++)
                {
                    CompetenciaAbetId = dc.uspResultadoProgramaXCompetenciaAbet_ActualizarXMallaEncuesta(lstLR[i].ResultadoProgramaId, lstLR[i].CompetenciaAbetId, lstLR[i].Asignado, lstLR[i].MallaEncuestaId);
                }

                return CompetenciaAbetId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }

        public Int32 resultadoProgramaXCompetenciaAbetCambiarEstado(Int32 MallaEncuestaId, Int32 ResultadoProgramaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                Int32 lst = dc.uspResultadoProgramaXCompetenciaAbet_CambiarEstados(MallaEncuestaId, ResultadoProgramaId);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }
        #endregion
    }
}
