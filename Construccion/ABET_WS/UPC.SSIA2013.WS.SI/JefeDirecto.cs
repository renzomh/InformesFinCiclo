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
    public class JefeDirecto : IJefeDirecto
    {
        #region metodos GPPP
        [OperationBehavior]
        public JefeDirectoCollectionDC ListarJefeDirectoXNombreXApellidosXDNI(JefeDirectoDC objDC)
        {
            JefeDirectoLogic objBC = new JefeDirectoLogic();
            return JefeDirectoTL.TranslateJefeDirectoXNombreXApellidoXDNIToJefeDirectoCollectionDC(objBC.JefeDirecto_ListarXNombreXApellidoXDNI(objDC.Nombres, objDC.Apellidos, objDC.NroDocumento));
        }

        [OperationBehavior]
        public Int32 RegistrarJefeDirecto(JefeDirecto2DC objDC)
        {
            JefeDirectoLogic objBC = new JefeDirectoLogic();
            return objBC.JefeDirecto_Registrar(objDC);

        }
        #endregion
    }
}
