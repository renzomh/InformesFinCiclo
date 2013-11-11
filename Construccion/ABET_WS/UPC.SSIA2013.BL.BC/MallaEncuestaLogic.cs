using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class MallaEncuestaLogic
    {
        #region metodos GPPP
        public List<uspMallaEncuesta_ListarXCarreraXPeriodoXPPPXEstadoResult> mallaEncuestaListarXCarreraXPeriodoXPPPXEstado(Int32 CarreraId, Int32 PeriodoId, Int32 PracticaPreProfesionalId, Int32? Estado)
        {
            MallaEncuestaDataAccess objDALC;

            try
            {
                objDALC = new MallaEncuestaDataAccess();
                return objDALC.mallaEncuestaListarXCarreraXPeriodoXPPPXEstado(CarreraId, PeriodoId, PracticaPreProfesionalId, Estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 mallaEncuestaRegistrar(Int32 CarreraId, Int32 PeriodoId, Int32 PracticaPreProfesionalId, String Nombre, Int32? Estado, String EstadoImageUrl)
        {
            MallaEncuestaDataAccess objDALC;
            try
            {
                objDALC = new MallaEncuestaDataAccess();
                return objDALC.mallaEncuestaRegistrar(CarreraId, PeriodoId, PracticaPreProfesionalId, Nombre, Estado, EstadoImageUrl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 mallaEncuestaActualizar(Int32 MallaEncuestaId, String Nombre, Int32 CarreraId, Int32 PeriodoId, Int32 PracticaPreProfesionalId, Int32? Estado, String Estado_ImageUrl)
        {
            MallaEncuestaDataAccess objDALC;
            try
            {
                objDALC = new MallaEncuestaDataAccess();
                
                Int32 resultCambiarEstado = objDALC.mallaEncuestaCambiarEstadoXMallaEncuestaIdXEstadoXUrl(MallaEncuestaId, Estado, Estado_ImageUrl, PeriodoId, CarreraId, PracticaPreProfesionalId);
                if (resultCambiarEstado > 0)
                {
                    Int32 resultActualizar = objDALC.mallaEncuestaActualizar(MallaEncuestaId, Nombre, CarreraId, PeriodoId, PracticaPreProfesionalId);
                    return resultActualizar;
                }
                else
                {
                    return resultCambiarEstado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 mallaEncuestaCambiarEstadoXMallaEncuestaIdXEstadoXUrl(Int32 MallaEncuestaId, Int32? Estado, String Estado_ImageUrl, Int32 PeriodoId, Int32 CarreraId, Int32 PracticaPreProfesionalId)
        {
            MallaEncuestaDataAccess objDALC;
            try
            {
                objDALC = new MallaEncuestaDataAccess();
                return objDALC.mallaEncuestaCambiarEstadoXMallaEncuestaIdXEstadoXUrl(MallaEncuestaId, Estado, Estado_ImageUrl, PeriodoId, CarreraId, PracticaPreProfesionalId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public uspMallaEncuesta_ObtenerXMallaEncuestaIdResult mallaObtenerxMallaEncuestaId(Int32 mallaEncuestaId)
        {
            MallaEncuestaDataAccess objDALC;

            try
            {
                objDALC = new MallaEncuestaDataAccess();
                return objDALC.mallaEncuestaObtenerxMallaEncuestaId(mallaEncuestaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<uspMallaEncuesta_ListarCompetenciasResult> mallaEncuestaListarCompetencias(Int32 mallaEncuestaId)
        {
            MallaEncuestaDataAccess objDALC;

            try
            {
                objDALC = new MallaEncuestaDataAccess();
                return objDALC.mallaEncuestaListarCompetencias(mallaEncuestaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}