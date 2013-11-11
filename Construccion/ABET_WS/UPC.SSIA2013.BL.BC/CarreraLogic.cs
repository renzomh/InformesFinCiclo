using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class CarreraLogic
    {
        public List<CarreraEntity> ListarCarreras()
        {
            CarreraDataAccess oCarreraDALC = new CarreraDataAccess();

            try
            {
                return oCarreraDALC.ListarCarreras();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region metodos GPPP
        public List<uspCarrera_ListarXEscuelaResult> carreraListarXEscuela(Int32? escuelaId)
        {
            CarreraDataAccess objDALC;

            try
            {
                objDALC = new CarreraDataAccess();
                return objDALC.carreraListarXEscuela(escuelaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
