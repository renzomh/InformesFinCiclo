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
    public interface IResultadoPrograma
    {
        #region METODOS IFC-DC
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        ResultadoProgramaxCursoCollectionDC WSListarResultadoProgramaxCurso(int cursoId, int periodoId);
        #endregion

        #region metodos GPPP
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        ResultadoProgramaXCarreraXPeriodoCollectionDC ListarResultadoProgramaXCarreraXPeriodo(ResultadoProgramaXCarreraXPeriodoDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        ResultadoProgramaXMallaEncuestaXCarreraCollectionDC ListarResultadoProgramaXMallaEncuestaXCarrera(ResultadoProgramaXMallaEncuestaXCarreraDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 RegistrarResultadoProgramaXMallaEncuesta(List<ResultadoProgramaXMallaEncuestaDC> lstDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 RegistrarResultadoProgramaXCompetenciaAbet(List<ResultadoProgramaXCompetenciaAbetDC> lstDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 ActualizarResultadoProgramaxMallaEncuesta(List<ResultadoProgramaXMallaEncuestaDC> lstLR);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 ActualizarResultadoProgramaxCompetenciaAbet(List<ResultadoProgramaXCompetenciaAbetDC> lstLR);
        #endregion
    }
}
