using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.WS.ServiceContract;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.WS.TranslatorLayer;
using UPC.SSIA2013.DataModel;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.BusinessLogic;

using System.ServiceModel;
using System.ServiceModel.Activation;

namespace UPC.SSIA2013.WS.ServiceLibrary
{
    [ServiceBehavior]
    public class Empresa : IEmpresa
    {
        #region metodos GPPP
        [OperationBehavior]
        public Int32 RegistrarEmpresa(EmpresaDC objDC)
        {
            EmpresaLogic objBC = new EmpresaLogic();
            return objBC.Empresa_Registrar(objDC);

        }

        [OperationBehavior]
        public EmpresaCollectionDC ListarEmpresaXRazonSocialXRUC(EmpresaDC objDC)
        {
            EmpresaLogic objBC = new EmpresaLogic();
            return EmpresaTL.TranslateEmpresaXRazonSocialXRUCToEmpresaCollectionDC(objBC.Empresa_ListarXRazonSocialXRUC(objDC.RazonSocial, objDC.RUC));
        }
        #endregion
    }
}
