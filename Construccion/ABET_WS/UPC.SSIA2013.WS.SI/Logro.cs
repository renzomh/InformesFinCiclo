using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.WS.ServiceContract;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.WS.TranslatorLayer;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.BusinessLogic;

using System.ServiceModel;
using System.ServiceModel.Activation;

using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.WS.ServiceLibrary
{
    [ServiceBehavior]
    public class Logro : ILogro
    {
        [OperationBehavior]
        LogroDC ILogro.WSListarLogroxCurso(int cursoId)
        {
            LogroLogic objLogroBC = new LogroLogic();
            return LogroTL.TranslateLogroLRToLogroDC(objLogroBC.obtenerLogroxCurso(cursoId));
        }
    }
}
