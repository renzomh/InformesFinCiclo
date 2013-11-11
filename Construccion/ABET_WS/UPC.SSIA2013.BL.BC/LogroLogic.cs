using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class LogroLogic
    {
        public up_Obtener_Logro_x_CursoResult obtenerLogroxCurso(int? cursoId)
        {
            LogroDataAccess objLogroDataAccess;

            try
            {
                objLogroDataAccess = new LogroDataAccess();
                return objLogroDataAccess.obtenerLogroxCurso(cursoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
