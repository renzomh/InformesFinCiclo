using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.DataContract;

namespace UPC.SSIA2013.BusinessLogic
{
    public class ResultadoProgramaLogic
    {
        #region METODOS IFC-DC
        public List<up_Listar_ResultadoPrograma_x_CursoResult> listarResultadoProgramaxCurso(int cursoId, int periodoId)
        {
            ResultadoProgramaDataAccess objResultadoProgramaDataAccess;

            try
            {
                objResultadoProgramaDataAccess = new ResultadoProgramaDataAccess();
                return objResultadoProgramaDataAccess.listarResultadoProgramaxCurso(cursoId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region metodods GPPP
        public List<uspResultadoPrograma_ListarXCarreraXPeriodoResult> resultadoProgramaListarXCarreraXPeriodo(Int32? carreraId, Int32 periodoId)
        {
            ResultadoProgramaDataAccess objDALC;

            try
            {
                objDALC = new ResultadoProgramaDataAccess();
                return objDALC.resultadoProgramaListarXCarreraXPeriodo(carreraId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public List<uspResultadoPrograma_ListarXMallaEncuestaXCarreraResult> resultadoProgramaListarXMallaEncuestaXCarrera(int mallaId, int? carreraId)
        {
            ResultadoProgramaDataAccess objDALC;

            try
            {
                objDALC = new ResultadoProgramaDataAccess();
                return objDALC.resultadoProgramaListarXMallaEncuestaXCarrera(mallaId, carreraId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public Int32 resultadoProgramaXMallaEncuestaRegistrar(List<ResultadoProgramaXMallaEncuestaDC> lstLR)
        {
            ResultadoProgramaDataAccess objDALC;

            try
            {
                objDALC = new ResultadoProgramaDataAccess();
                return objDALC.resultadoProgramaXMallaEncuestaRegistrar(lstLR);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public Int32 resultadoProgramaXCompetenciaAbetRegistrar(List<ResultadoProgramaXCompetenciaAbetDC> lstLR)
        {
            ResultadoProgramaDataAccess objDALC;

            try
            {
                objDALC = new ResultadoProgramaDataAccess();
                objDALC.resultadoProgramaXCompetenciaAbetCambiarEstado(lstLR.ElementAt(0).MallaEncuestaId, lstLR.ElementAt(0).ResultadoProgramaId);
                return objDALC.resultadoProgramaXCompetenciaAbetRegistrar(lstLR);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public Int32 resultadoProgramaXMallaEncuestaActualizar(List<ResultadoProgramaXMallaEncuestaDC> lstLR)
        {
            ResultadoProgramaDataAccess objDALC;

            try
            {
                objDALC = new ResultadoProgramaDataAccess();
                return objDALC.resultadoProgramaXMallaEncuestaActualizar(lstLR);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public Int32 resultadoProgramaXCompetenciaAbetActualizar(List<ResultadoProgramaXCompetenciaAbetDC> lstLR)
        {
            ResultadoProgramaDataAccess objDALC;

            try
            {
                objDALC = new ResultadoProgramaDataAccess();
                objDALC.resultadoProgramaXCompetenciaAbetCambiarEstado(lstLR.ElementAt(0).MallaEncuestaId, lstLR.ElementAt(0).ResultadoProgramaId);
                return objDALC.resultadoProgramaXCompetenciaAbetActualizar(lstLR);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }
        #endregion
    }
}
