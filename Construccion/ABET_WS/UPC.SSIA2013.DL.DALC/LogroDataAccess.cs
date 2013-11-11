using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DataModel;
using System.Configuration;

namespace UPC.SSIA2013.DataAccess
{
    public class LogroDataAccess
    {
        public up_Obtener_Logro_x_CursoResult obtenerLogroxCurso(Int32? cursoId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                up_Obtener_Logro_x_CursoResult logro = dataContext.up_Obtener_Logro_x_Curso(cursoId).SingleOrDefault();

                return logro;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }
    }
}
