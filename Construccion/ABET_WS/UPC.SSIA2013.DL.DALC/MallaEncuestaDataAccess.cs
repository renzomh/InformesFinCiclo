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
    public class MallaEncuestaDataAccess
    {
        #region metodos GPPP        
        public List<uspMallaEncuesta_ListarXCarreraXPeriodoXPPPXEstadoResult> mallaEncuestaListarXCarreraXPeriodoXPPPXEstado(Int32 CarreraId, Int32 PeriodoId, Int32 PracticaPreProfesionalId, Int32? Estado)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspMallaEncuesta_ListarXCarreraXPeriodoXPPPXEstadoResult> lst = dc.uspMallaEncuesta_ListarXCarreraXPeriodoXPPPXEstado(CarreraId, PeriodoId, PracticaPreProfesionalId, Estado).ToList();
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

        public Int32 mallaEncuestaRegistrar(Int32 CarreraId, Int32 PeriodoId, Int32 PracticaPreProfesionalId, String Nombre, Int32? Estado, String EstadoImageUrl)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                int mallaEncuestaId = dc.uspMallaEncuesta_Registrar(CarreraId, PeriodoId, PracticaPreProfesionalId, Nombre, Estado, EstadoImageUrl);
                return mallaEncuestaId;
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

        public Int32 mallaEncuestaActualizar(Int32 MallaEncuestaId, String Nombre, Int32 CarreraId, Int32 PeriodoId, Int32 PracticaPreProfesionalId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                int mallaEncuestaId = dc.uspMallaEncuesta_Actualizar(MallaEncuestaId, Nombre, CarreraId, PeriodoId, PracticaPreProfesionalId);
                return mallaEncuestaId;
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

        public Int32 mallaEncuestaCambiarEstadoXMallaEncuestaIdXEstadoXUrl(Int32 MallaEncuestaId, Int32? Estado, String Estado_ImageURL, Int32 PeriodoId, Int32 CarreraId, Int32 PracticaPreProfesionalId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                int mallaEncuestaId = dc.uspMallaEncuesta_CambiarEstadoXMallaEncuestaXEstadoXURL(MallaEncuestaId, Estado, Estado_ImageURL, PeriodoId, CarreraId, PracticaPreProfesionalId);
                return mallaEncuestaId;
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

        public uspMallaEncuesta_ObtenerXMallaEncuestaIdResult mallaEncuestaObtenerxMallaEncuestaId(Int32 mallaEncuestaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                uspMallaEncuesta_ObtenerXMallaEncuestaIdResult obj = dc.uspMallaEncuesta_ObtenerXMallaEncuestaId(mallaEncuestaId).SingleOrDefault();
                return obj;
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

        public List<uspMallaEncuesta_ListarCompetenciasResult> mallaEncuestaListarCompetencias(Int32 mallaEncuestaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspMallaEncuesta_ListarCompetenciasResult> obj = dc.uspMallaEncuesta_ListarCompetencias(mallaEncuestaId).ToList();
                return obj;
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
