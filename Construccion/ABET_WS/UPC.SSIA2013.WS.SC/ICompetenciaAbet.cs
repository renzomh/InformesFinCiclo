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
    public interface ICompetenciaAbet
    {
        #region metodos GPPP
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CompetenciaAbetXCarreraXPeriodoCollectionDC ListarCompetenciaAbetXCarreraXPeriodo(CompetenciaAbetXCarreraXPeriodoDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CompetenciaAbetXMallaEncuestaCollectionDC ListarCompetenciaAbetxMallaEncuestaxResultadoPrograma(ResultadoProgramaXMallaEncuestaXCarreraDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CompetenciaAbetXMallaEncuestaCollectionDC ListarCompetenciaAbetPDFXMallaEncuesta(CompetenciaAbetXMallaEncuestaDC objDC);
        #endregion
    }
}
