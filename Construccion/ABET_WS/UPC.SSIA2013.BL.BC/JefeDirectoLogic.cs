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
    public class JefeDirectoLogic
    {
        #region metodos GPPP
        public List<uspJefeDirecto_ListarXNombreXApellidoXDNIResult> JefeDirecto_ListarXNombreXApellidoXDNI(String Nombre, String Apellidos, String DNI)
        {
            JefeDirectoDataAccess objDALC;
            try
            {
                objDALC = new JefeDirectoDataAccess();
                return objDALC.JefeDirecto_ListarXNombreXApellidoXDNI(Nombre, Apellidos, DNI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Int32 JefeDirecto_Registrar(JefeDirecto2DC objDC)
        {
            JefeDirectoDataAccess objDALC;

            try
            {
                objDALC = new JefeDirectoDataAccess();
                return objDALC.JefeDirecto_Registrar(objDC);
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
