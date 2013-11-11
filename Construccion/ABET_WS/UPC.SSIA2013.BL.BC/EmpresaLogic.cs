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
    public class EmpresaLogic
    {
        #region metodos GPPP
        public List<uspEmpresa_ListarXRazonSocialXRucResult> Empresa_ListarXRazonSocialXRUC(String RazonSocial, String RUC)
        {
            EmpresaDataAccess objDALC;
            try
            {
                objDALC = new EmpresaDataAccess();
                return objDALC.Empresa_ListarXRazonSocialXRUC(RazonSocial, RUC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 Empresa_Registrar(EmpresaDC objDC)
        {
            EmpresaDataAccess objDALC;
            try
            {
                objDALC = new EmpresaDataAccess();
                return objDALC.Empresa_Registrar(objDC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
