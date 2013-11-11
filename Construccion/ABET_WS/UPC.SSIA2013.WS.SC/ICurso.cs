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
    public interface ICurso
    {


        #region METODO SIGERCOV

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CursoCollectionDC ListarCursosPorTipoCursoCarreraId(int CarreraId, int TipoCurso);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CursoCollectionDC ListarCursosPorCarreraPorNivelPorPeriodoActual(int CarreraId, int nivel);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        void ActualizarCursosPorCarreraPorNivelPorPeriodoActual(int cursoId, bool esControl, bool esVerificacion);

        #endregion


        #region METODO IFCDC

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CursoCollectionDC ListarCursos();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CursoxProfesorCollectionDC ListarCursosxProfesor(String profesorId);

        #endregion

    }
}
