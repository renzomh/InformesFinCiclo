using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

using UPC.SSIA2013.WS.DataContract;

namespace UPC.SSIA2013.WS.ServiceContract
{
    [ServiceContract]
    public interface IPeriodo
    {

        #region METODO SIGERCOV

        [OperationContract]
        PeriodoCollectionDC ListarPeriodoPorCarreraId(int CarreraId);

        [OperationContract]
        PeriodoDC ObtenerPeriodoActual();

        #endregion

        #region METODO IFCDC

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        PeriodoCollectionDC WSListarPeriodos();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        PeriodoDC WSObtenerPeriodoActual();

        #endregion


        #region metodos GPPP
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        PeriodoCollectionDC ListarPeriodoXEstadoXEsActual(PeriodoDC objDC);
        #endregion
    }
}
