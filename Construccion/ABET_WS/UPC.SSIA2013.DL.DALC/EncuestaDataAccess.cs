using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;

using System.Globalization;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.DataContract;

namespace UPC.SSIA2013.DataAccess
{
    public class EncuestaDataAccess
    {
        #region metodos GPPP
        public List<uspEncuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistroResult> encuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistro(Int32 Carrera, Int32 Periodo, Int32 PPP, Int32? Estado, String TipoRegistro)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspEncuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistroResult> lst = dc.uspEncuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistro(Carrera,Periodo,PPP,Estado,TipoRegistro).ToList();
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

        public uspEncuesta_ObetenerXEncuestaIdResult encuesta_ObtenerxEncuestaId(Int32 EncuestaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                uspEncuesta_ObetenerXEncuestaIdResult lst = dc.uspEncuesta_ObetenerXEncuestaId(EncuestaId).SingleOrDefault();                
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

        public List<uspEncuesta_ListarCompetenciasResult> encuesta_ListarCompetencias(Int32 EncuestaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspEncuesta_ListarCompetenciasResult> lst = dc.uspEncuesta_ListarCompetencias(EncuestaId).ToList();
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

        public Int32 encuesta_Registrar(EncuestaDC objEncuesta)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                DateTime? fRegistro = null;
                if (objEncuesta.FechaRegistroJefe != null)
                    fRegistro = Convert.ToDateTime(objEncuesta.FechaRegistroJefe);
                Int32 lst = dc.uspEncuesta_Registrar(Convert.ToInt32(objEncuesta.MallaEncuestaId), Convert.ToInt32(objEncuesta.EmpresaId), objEncuesta.JefeDirectoId, objEncuesta.AlumnoId, objEncuesta.Nombre, Convert.ToDateTime(objEncuesta.FECHAINICIO), Convert.ToDateTime(objEncuesta.FECHAFIN), Convert.ToInt32(objEncuesta.TotalHoras), objEncuesta.Comentario, objEncuesta.TipoRegistro, fRegistro, Convert.ToInt32(objEncuesta.ENCUESTA_ESTADO));
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

        public Int32 Encuesta_RegistrarCompetencias(CompetenciaAbetxEncuestaDC objEncuesta)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                Int32 lst = dc.uspCompetenciaAbetXEncuesta_Registrar(Convert.ToInt32(objEncuesta.EncuestaId), Convert.ToInt32(objEncuesta.MallaEncuestaId), Convert.ToInt32(objEncuesta.ResutadoProgramaId), Convert.ToInt32(objEncuesta.CompetenciaAbetId), Convert.ToInt32(objEncuesta.Puntuacion));
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

        public Int32 encuesta_Actualizar(EncuestaDC objEncuesta)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                Int32 lst = dc.uspEncuesta_Actualizar(Convert.ToInt32(objEncuesta.EncuestaId), Convert.ToInt32(objEncuesta.EmpresaId), objEncuesta.JefeDirectoId, Convert.ToDateTime(objEncuesta.FECHAINICIO), Convert.ToDateTime(objEncuesta.FECHAFIN), Convert.ToInt32(objEncuesta.TotalHoras), objEncuesta.Comentario, objEncuesta.TipoRegistro, Convert.ToDateTime(objEncuesta.FechaRegistroJefe), Convert.ToInt32(objEncuesta.ENCUESTA_ESTADO));
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

        public Int32 encuesta_ActualizarCompetencias(CompetenciaAbetxEncuestaDC objEncuesta)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                Int32 lst = dc.uspCompetenciaAbetXEncuesta_Actualizar(Convert.ToInt32(objEncuesta.EncuestaId), Convert.ToInt32(objEncuesta.MallaEncuestaId), Convert.ToInt32(objEncuesta.ResutadoProgramaId), Convert.ToInt32(objEncuesta.CompetenciaAbetId), Convert.ToInt32(objEncuesta.Puntuacion));
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

        public Int32 encuesta_Eliminar(Int32 EncuestaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                Int32 lst = dc.uspEncuesta_Eliminar(EncuestaId);
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

        public List<uspEncuesta_ListarXFechasResult> encuesta_ListarXFechas(DateTime FechaFin, DateTime FechaInicio)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspEncuesta_ListarXFechasResult> lst = dc.uspEncuesta_ListarXFechas(FechaFin, FechaInicio).ToList();
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