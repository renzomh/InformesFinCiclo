using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;

using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.BusinessEntity;


namespace UPC.SSIA2013.BusinessLogic
{
    public class AccionMejoraLogic
    {
        public List<up_Registrar_AccionMejoraResult> registrarAccionMejora(int hallazgoId, int informeFinCicloId, int cicloEjecucionId, String descripcion)
        {
            AccionMejoraDataAccess objAccionMejoraDataAccess;

            try
            {
                objAccionMejoraDataAccess = new AccionMejoraDataAccess();
                return objAccionMejoraDataAccess.registrarAccionMejora(hallazgoId, informeFinCicloId, cicloEjecucionId, descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Listar_AccionMejora_x_InformeFinCicloResult> listarAccionesMejoraxInformeFinCiclo(int informeFinCicloId)
        {
            AccionMejoraDataAccess objAccionesMejoraDALC;

            try
            {
                objAccionesMejoraDALC = new AccionMejoraDataAccess();
                return objAccionesMejoraDALC.listarAccionesMejoraxInformeFinCiclo(informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Listar_AccionMejora_PreviasResult> listarAccionesMejoraPrevias(int cursoId, int periodoId)
        {
            AccionMejoraDataAccess objAccionesMejoraDALC;

            try
            {
                objAccionesMejoraDALC = new AccionMejoraDataAccess();
                return objAccionesMejoraDALC.listarAccionesMejoraPrevias(cursoId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Editar_AccionMejoraResult> editarAccionMejora(int accionMejoraId, int informeFinCicloId, int cicloEjecucionId, String descripcion)
        {
            AccionMejoraDataAccess objAccionMejoraDataAccess;

            try
            {
                objAccionMejoraDataAccess = new AccionMejoraDataAccess();
                return objAccionMejoraDataAccess.editarAccionMejora(accionMejoraId, informeFinCicloId, cicloEjecucionId, descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Editar_AccionMejora_PreviaResult> editarAccionMejoraPrevia(int cursoId, int periodoId, int accionMejoraId, String estado)
        {
            AccionMejoraDataAccess objAccionMejoraDataAccess;

            try
            {
                objAccionMejoraDataAccess = new AccionMejoraDataAccess();
                return objAccionMejoraDataAccess.editarAccionMejoraPrevia(cursoId, periodoId, accionMejoraId, estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Eliminar_AccionMejoraResult> eliminarAccionMejora(int accionMejoraId, int informeFinCicloId)
        {
            AccionMejoraDataAccess objAccionMejoraDataAccess;

            try
            {
                objAccionMejoraDataAccess = new AccionMejoraDataAccess();
                return objAccionMejoraDataAccess.eliminarAccionMejora(accionMejoraId, informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Listar_Reporte_AccionMejoraResult> listarReporteAccionMejora(int cursoId, int periodoId, String estado)
        {
            AccionMejoraDataAccess objAccionMejoraDataAccess;

            try
            {
                objAccionMejoraDataAccess = new AccionMejoraDataAccess();
                return objAccionMejoraDataAccess.listarReporteAccionMejora(cursoId, periodoId, estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
