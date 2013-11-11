using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

using UPC.SSIA2013.BL.BC;
using UPC.SSIA2013.DL.DataModel;
using UPC.SSIA2013.SI.DataContracts;
using UPC.SSIA2013.SI.ServiceContracts;

namespace UPC.SSIA2013.SI.ServiceImplementation
{
    [ServiceBehavior]
    public class Periodo : IPeriodo
    {
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        PeriodoCollectionDC IPeriodo.WSListarPeriodos()
        {
            PeriodoBC objPeriodoBC = new PeriodoBC();
            return TranslatorHelper.TranslateListarPeriodosLRToPeriodoCollectionDC(objPeriodoBC.listarPeriodos());
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        PeriodoDC IPeriodo.WSObtenerPeriodoActual()
        {
            PeriodoBC objPeriodoBC = new PeriodoBC();
            return TranslatorHelper.TranslatePeriodoLRToPeriodoDC(objPeriodoBC.obtenerPeriodo());
        }
    }
}
