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
    public interface ICarrera
    {
        [OperationContract]
        CarreraCollectionDC ListarCarreras();

        #region metodos GPPP
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CarreraCollectionDC ListarCarreraXEscuela(CarreraDC objDC);
        #endregion
    }
}
