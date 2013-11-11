using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.DataContract;

namespace UPC.SSIA2013.BusinessLogic
{
    public class PracticaPreProfesionalLogic
    {
        #region metodos GPPP
        public List<uspPractica_ListarXPeriodoXCarreraXEstadoResult> practicaPreProfesionalListarXPeriodoXCarreraXEstado(Int32 PeriodoId, Int32 CarreraId, Int32? Estado)
        {
            PracticaPreProfesionalDataAccess objDALC;

            try
            {
                objDALC = new PracticaPreProfesionalDataAccess();
                return objDALC.practicaPreProfesionalListarXPeriodoXCarreraXEstado(PeriodoId, CarreraId, Estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public int practicaPreProfesionalInsertar(PracticaPreProfesionalDC objDC)
        {
            PracticaPreProfesionalDataAccess objDALC;

            try
            {
                objDALC = new PracticaPreProfesionalDataAccess();
                return objDALC.practicaPreProfesionalInsertar(objDC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public int practicaPreProfesionalActualizar(PracticaPreProfesionalDC objDC)
        {
            PracticaPreProfesionalDataAccess objDALC;

            try
            {
                objDALC = new PracticaPreProfesionalDataAccess();
                return objDALC.practicaPreProfesionalActualizar(objDC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }
        #endregion
    }
}
