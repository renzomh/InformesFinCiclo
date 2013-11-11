using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class HallazgoLogic
    {
        public List<up_Registrar_HallazgoResult> registrarHallazgo(int informeFinCicloId, String descripcion, int periodoId)
        {
            HallazgoDataAccess objHallazgoDataAccess;

            try
            {
                objHallazgoDataAccess = new HallazgoDataAccess();

                return objHallazgoDataAccess.registrarHallazgo(informeFinCicloId, descripcion, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Listar_Hallazgos_x_InformeFinCicloResult> listarHallazgosxInformeFinCiclo(int informeFinCicloId)
        {
            HallazgoDataAccess objHallazgoDataAccess;

            try
            {
                objHallazgoDataAccess = new HallazgoDataAccess();
                return objHallazgoDataAccess.listarHallazgosxInformeFinCiclo(informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Editar_HallazgoResult> editarHallazgo(int hallazgoId, int informeFinCicloId, String descripcion)
        {
            HallazgoDataAccess objHallazgoDataAccess;

            try
            {
                objHallazgoDataAccess = new HallazgoDataAccess();
                return objHallazgoDataAccess.editarHallazgo(hallazgoId, informeFinCicloId, descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Eliminar_HallazgoResult> eliminarHallazgo(int hallazgoId, int informeFinCicloId)
        {
            HallazgoDataAccess objHallazgoDataAccess;

            try
            {
                objHallazgoDataAccess = new HallazgoDataAccess();
                return objHallazgoDataAccess.eliminarHallazgo(hallazgoId, informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Listar_Reporte_HallazgoResult> listarReporteHallazgo(int cursoId, int periodoId)
        {
            HallazgoDataAccess objHallazgoDataAccess;

            try
            {
                objHallazgoDataAccess = new HallazgoDataAccess();
                return objHallazgoDataAccess.listarReporteHallazgo(cursoId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
