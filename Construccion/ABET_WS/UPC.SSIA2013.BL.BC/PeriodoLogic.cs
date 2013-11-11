using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataAccess;

using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class PeriodoLogic
    {

        #region METODO SIGERCOV

        public List<PeriodoEntity> ListarPeriodoPorCarreraId(int CarreraId)
        {
            PeriodoDataAccess oPeriodoDALC = new PeriodoDataAccess();
            try
            {
                return oPeriodoDALC.ListarPeriodoPorCarreraId(CarreraId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PeriodoEntity ObtenerPeriodoActual()
        {
            PeriodoDataAccess oPeriodoDALC = new PeriodoDataAccess();
            try
            {
                return oPeriodoDALC.ObtenerPeriodoActual();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        #region METODO IFCDC

        public List<up_Listar_PeriodosResult> listarPeriodos()
        {
            PeriodoDataAccess objPeriodoDALC;

            try
            {
                objPeriodoDALC = new PeriodoDataAccess();
                return objPeriodoDALC.listarPeriodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public up_Obtener_PeriodoActualResult obtenerPeriodo()
        {
            PeriodoDataAccess objPeriodoDALC;

            try
            {
                objPeriodoDALC = new PeriodoDataAccess();
                return objPeriodoDALC.obtenerPeriodoActual();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region metodosGPP
        public List<uspPeriodo_ListarXEstadoXEsActualResult> periodoListarXEstadoXEsActual(int? estado, int? esActual)
        {
            PeriodoDataAccess objDALC;

            try
            {
                objDALC = new PeriodoDataAccess();
                return objDALC.periodoListarXEstadoXEsActual(estado, esActual);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
