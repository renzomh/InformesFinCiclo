using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class CompetenciaAbetLogic
    {
        #region metodods GPPP
        public List<uspCompetenciaAbet_ListarXCarreraXPeriodoResult> competenciaAbetListarXCarreraXPeriodo(int? carreraId, int? periodoId)
        {
            CompetenciaAbetDataAccess objDALC;

            try
            {
                objDALC = new CompetenciaAbetDataAccess();
                return objDALC.competenciaAbetListarXCarreraXPeriodo(carreraId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public List<uspCompetenciaAbet_ListarXMallaEncuestaXResultadoProgramaResult> competenciaAbetxMallaEncuestxResultadoPrograma(Int32 MallaEncuestaId, Int32 ResultadoProgramaId)
        {
            CompetenciaAbetDataAccess objDALC;

            try
            {
                objDALC = new CompetenciaAbetDataAccess();
                return objDALC.competenciaAbetListarxMallaEncuestaxResultadoPrograma(MallaEncuestaId,ResultadoProgramaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public List<uspCompetenciaAbet_ListarPDFXMallaEncuestaResult> competenciaAbetListarPDFXMallaEncuesta(Int32 MallaEncuestaId)
        {
            CompetenciaAbetDataAccess objDALC;
            try
            {
                objDALC = new CompetenciaAbetDataAccess();
                return objDALC.competenciaAbetListarPDFXMallaEncuesta(MallaEncuestaId);
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
