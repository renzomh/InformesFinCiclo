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
    public interface IHallazgo
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoCollectionDC WSRegistrarHallazgo(int informeFinCicloId, String descripcion, int periodoId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoCollectionDC WSListarHallazgosxInformeFinCiclo(int informeFinCicloId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoCollectionDC WSEditarHallazgo(int hallazgoId, int informeFinCicloId, String descripcion);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoCollectionDC WSEliminarHallazgo(int hallazgoId, int informeFinCicloId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoReporteCollectionDC WSListarHallazgoReporte(int cursoId, int periodoId);
    }
}
