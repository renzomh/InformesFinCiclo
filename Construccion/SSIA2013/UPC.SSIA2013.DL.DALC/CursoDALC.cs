using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class CursoDALC
    {
        public List<up_Listar_CursosResult> listarCursos()
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_Listar_CursosResult> lstCursos = dataContext.up_Listar_Cursos().ToList();

                return lstCursos;
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

        public List<up_Listar_Cursos_x_ProfesorResult> listarCursosxProfesor(string profesorId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_Listar_Cursos_x_ProfesorResult> lstCursosxProfesor = dataContext.up_Listar_Cursos_x_Profesor(profesorId).ToList();

                return lstCursosxProfesor;
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
