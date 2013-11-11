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
    public interface IPracticaPreProfesional
    {
        #region metodos GPPP
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        PracticaPreProfesionalCollectionDC ListarPracticaPreProfesionalXPeriodoXCarreraXEstado(PracticaPreProfesionalDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 RegistrarPracticaPreProfesional(PracticaPreProfesionalDC objDC);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Int32 ActualizarPracticaPreProfesional(PracticaPreProfesionalDC objDC);
        #endregion
    }
}
