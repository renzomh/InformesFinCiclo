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
    public class ResultadoPrograma : IResultadoPrograma
    {
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        ResultadoProgramaxCursoCollectionDC IResultadoPrograma.WSListarResultadoProgramaxCurso(int cursoId, int periodoId)
        {
            ResultadoProgramaBC objResultadoProgramaBC = new ResultadoProgramaBC();
            return TranslatorHelper.TranslateResultadoProgramasxCursoLRToResultadoProgramaCollection(objResultadoProgramaBC.listarResultadoProgramaxCurso(cursoId, periodoId));
        }
    }
}
