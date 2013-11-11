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
    public interface IInformeFinCiclo
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        InformeFinCicloDC WSObtenerInformeFinCicloxId(int informeFinCicloId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        InformeFinCicloDC WSObtenerInformeFinCiclo(String coordinadorId, int cursoId, int periodoId);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        InformeFinCicloDC WSEditarInformeFinCiclo(int informeFinCicloId, String estado, String desarrolloUnidades, String infraestructura, String alumnos, String delegados, String encuesta);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        InformeFinCicloReporteCollectionDC WSListarInformeFinCicloReporte(int cursoId, int periodoId, String estado);
    }
}
