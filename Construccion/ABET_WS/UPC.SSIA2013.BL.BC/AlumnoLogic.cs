using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class AlumnoLogic
    {
        #region metodos GPPP
        public List<uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstadoResult> alumnoListarXAlumnoXCarreraXPeriodoXPPPXEstado(String AlumnoId, Int32? CarreraId, Int32? PeriodoId, Int32 PracticaPreProfesionalId, Int32? Estado, Boolean busqueda)
        {
            AlumnoDataAccess objDALC;

            try
            {
                objDALC = new AlumnoDataAccess();
                return objDALC.alumnoListarXAlumnoXCarreraXPeriodoXPPPXEstado(AlumnoId, CarreraId, PeriodoId, PracticaPreProfesionalId, Estado,busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
