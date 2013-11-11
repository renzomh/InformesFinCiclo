using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

using UPC.SSIA2013.BL.BC;
using UPC.SSIA2013.DL.DataModel;
using UPC.SSIA2013.SI.DataContracts;
using UPC.SSIA2013.SI.ServiceContracts;

namespace UPC.SSIA2013.SI.ServiceImplementation
{
    [ServiceBehavior]
    public class Curso : ICurso
    {
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CursoCollectionDC ICurso.WSListarCursos()
        {
            CursoBC objCursoBC = new CursoBC();
            return TranslatorHelper.TranslateListarCursosLRToCursoCollectionDC(objCursoBC.listarCursos());
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        CursoxProfesorCollectionDC ICurso.WSListarCursosxProfesor(CursoxProfesorDC objCursoxProfesorDC)
        {
            CursoBC objCursoBC = new CursoBC();
            return TranslatorHelper.TranslateCursosxProfesorLRToCursosxProfesorCollection(objCursoBC.listarCursosxProfesor(objCursoxProfesorDC.ProfesorId));
        }
    }
}
