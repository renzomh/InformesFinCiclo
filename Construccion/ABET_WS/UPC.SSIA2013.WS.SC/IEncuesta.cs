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
    public interface IEncuesta
    {
        #region metodos GPPP
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        EncuestaGrillaCollectionDC ListarEncuestaXCarreraXPeriodoXPPPXEstadoXTipoRegistro(EncuestaGrillaDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 EliminarEncuesta(Int32 encuestaId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 ActualizarEncuesta(EncuestaDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        EncuestaDC ObtenerEncuestaXEncuestaId(Int32 EncuestaId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 RegistrarEncuesta(EncuestaDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        EncuestaGrillaCollectionDC ListarEncuestaXFechas(EncuestaFechasDC objDC);
        #endregion
    }
}
