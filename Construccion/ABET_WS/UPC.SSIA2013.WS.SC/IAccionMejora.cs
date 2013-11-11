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
    public interface IAccionMejora
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC WSRegistrarAccionMejora(int hallazgoId, int informeFinCicloId, int periodoEjecucionId, String descripcion);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC WSListarAccionesMejoraxInformeFinCiclo(int informeFinCicloId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC WSListarAccionesMejoraPrevias(int cursoId, int periodoId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC WSEditarAccionMejora(int accionMejoraId, int informeFinCicloId, int periodoEjecucionId, String descripcion);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC WSEditarAccionMejoraPrevia(int cursoId, int periodoId, int accionMejoraId, String estado);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC WSEliminarAccionMejora(int accionMejoraId, int informeFinCicloId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraReporteCollectionDC WSListarAccionMejoraReporte(int cursoId, int periodoId, String estado);
    }
}
