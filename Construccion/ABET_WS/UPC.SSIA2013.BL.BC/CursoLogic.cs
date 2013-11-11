using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class CursoLogic
    {

        #region METODO SIGERCOV


        public List<CursoEntity> ListarCursosPorTipoCursoCarreraId(int CarreraId, int TipoCurso)
        {
            CursoDataAccess oCursoDALC = new CursoDataAccess();

            try
            {
                return oCursoDALC.ListarCursosPorTipoCursoCarreraId(CarreraId, TipoCurso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CursoEntity> ListarCursosPorCarreraPorNivelPorPeriodoActual(int? carreraId, int? nivel)
        {
            CursoDataAccess oCursoDALC = new CursoDataAccess();

            try
            {
                return oCursoDALC.ListarCursosPorCarreraPorNivelPorPeriodoActual(carreraId, nivel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarCursosPorCarreraPorNivelPorPeriodoActual(int? cursoId, bool esControl, bool esVerificacion)
        {
            CursoDataAccess oCursoDALC = new CursoDataAccess();

            try
            {
                oCursoDALC.ActualizarCursosPorCarreraPorNivelPorPeriodoActual(cursoId, esControl, esVerificacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region METODO IFCDC

        public List<up_Listar_CursosResult> listarCursos()
        {
            CursoDataAccess objCursoDALC;

            try
            {
                objCursoDALC = new CursoDataAccess();
                return objCursoDALC.listarCursos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Listar_Cursos_x_ProfesorResult> listarCursosxProfesor(string profesorId)
        {
            CursoDataAccess objCursoDALC;

            try
            {
                objCursoDALC = new CursoDataAccess();
                return objCursoDALC.listarCursosxProfesor(profesorId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
