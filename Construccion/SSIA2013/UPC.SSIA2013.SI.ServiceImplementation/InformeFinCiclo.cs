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
    public class InformeFinCiclo : IInformeFinCiclo
    {
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        InformeFinCicloDC IInformeFinCiclo.WSObtenerInformeFinCicloxId(InformeFinCicloDC objInformeFinCicloDC)
        {
            InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
            return TranslatorHelper.TranslateInformeFinCicloxIdLRToInformeFinCicloDC(objInformeFinCicloBC.obtenerInformeFinCicloxId(objInformeFinCicloDC.InformeFinCicloId));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        InformeFinCicloDC IInformeFinCiclo.WSObtenerInformeFinCiclo(InformeFinCicloDC objInformeFinCicloDC)
        {
            InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
            return TranslatorHelper.TranslateInformeFinCicloLRToInformeFinCicloDC(objInformeFinCicloBC.obtenerInformeFinCiclo(objInformeFinCicloDC.CoordinadorId, objInformeFinCicloDC.CursoId, objInformeFinCicloDC.PeriodoId));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        InformeFinCicloDC IInformeFinCiclo.WSEditarInformeFinCiclo(InformeFinCicloDC objInformeFinCicloDC)
        {
            InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
            return TranslatorHelper.TranslateEditarInformeFinCicloLRToInformeFinCicloDC(objInformeFinCicloBC.editarInformeFinCiclo(objInformeFinCicloDC.InformeFinCicloId, objInformeFinCicloDC.Estado, objInformeFinCicloDC.DesarrolloUnidades,
                    objInformeFinCicloDC.ComentarioInfraestructura, objInformeFinCicloDC.ComentarioAlumnos, objInformeFinCicloDC.ComentarioDelegados, objInformeFinCicloDC.ComentarioEncuesta));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        InformeFinCicloReporteCollectionDC IInformeFinCiclo.WSListarInformeFinCicloReporte(InformeFinCicloDC objInformeFinCicloDC)
        {
            InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
            return TranslatorHelper.TranslateInformeFinCicloReporteLRToInformeFinCicloReporteCollection(objInformeFinCicloBC.listarReporteInformeFinCiclo(objInformeFinCicloDC.CursoId, objInformeFinCicloDC.PeriodoId, objInformeFinCicloDC.Estado));
        }
    }
}
