using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;


using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.DataAccess
{
    public class CompetenciaAbetDataAccess
    {
        #region metodos GPPP        
        public List<uspCompetenciaAbet_ListarXCarreraXPeriodoResult> competenciaAbetListarXCarreraXPeriodo(Int32? carreraId, Int32? periodoId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspCompetenciaAbet_ListarXCarreraXPeriodoResult> lst = dc.uspCompetenciaAbet_ListarXCarreraXPeriodo(carreraId, periodoId).ToList();
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

        public List<uspCompetenciaAbet_ListarXMallaEncuestaXResultadoProgramaResult> competenciaAbetListarxMallaEncuestaxResultadoPrograma(Int32 MallaEncuestaId, Int32 ResultadoProgramaId)        
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspCompetenciaAbet_ListarXMallaEncuestaXResultadoProgramaResult> lst = dc.uspCompetenciaAbet_ListarXMallaEncuestaXResultadoPrograma(MallaEncuestaId,ResultadoProgramaId).ToList();
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

        public List<uspCompetenciaAbet_ListarPDFXMallaEncuestaResult> competenciaAbetListarPDFXMallaEncuesta(Int32 MallaEncuestaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspCompetenciaAbet_ListarPDFXMallaEncuestaResult> lst = dc.uspCompetenciaAbet_ListarPDFXMallaEncuesta(MallaEncuestaId).ToList();
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
