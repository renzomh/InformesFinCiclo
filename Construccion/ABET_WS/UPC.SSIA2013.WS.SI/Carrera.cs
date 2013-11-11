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
    public class Carrera : ICarrera
    {
        [OperationBehavior]
        public CarreraCollectionDC ListarCarreras()
        {
            CarreraLogic oCarreraLogic = new CarreraLogic();
            return CarreraTL.CarreraCollectionBEConvertirCarreraCollectionDC(oCarreraLogic.ListarCarreras());
        }

        #region metodos GPPP
        [OperationBehavior]
        public CarreraCollectionDC ListarCarreraXEscuela(CarreraDC objDC)
        {
            CarreraLogic objBC = new CarreraLogic();            
            return CarreraTL.TranslateCarreraXEscuelaLRToCarreraCollection(objBC.carreraListarXEscuela(objDC.EscuelaId));
        }
        #endregion
    }
}
