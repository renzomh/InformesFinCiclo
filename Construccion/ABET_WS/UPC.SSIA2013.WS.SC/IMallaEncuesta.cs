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
    public interface IMallaEncuesta
    {
        #region metodos GPPP
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        MallaEncuestaCollectionDC ListarMallaEncuestaXCarreraXPeriodoXPPPXEstado(MallaEncuestaDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 RegistrarMallaEncuesta(MallaEncuestaDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 ActualizarMallaEncuesta(MallaEncuestaDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 CambiarEstadoMallaEncuestaXMallaEncuestaIdXEstadoXUrl(MallaEncuestaDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        MallaEncuestaDC ObtenerMallaEncuestaxMallaEncuestaId(Int32 MallaEncuestaId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CompetenciaAbetxEncuestaCollectionDC ListarCompetenciasxMallaEncuestaId(Int32 MallaEncuestaId);
        #endregion
    }
}
