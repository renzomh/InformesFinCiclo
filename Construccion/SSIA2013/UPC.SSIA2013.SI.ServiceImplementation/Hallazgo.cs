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
    public class Hallazgo : IHallazgo
    {
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoCollectionDC IHallazgo.WSRegistrarHallazgo(HallazgoDC objHallazgoDC)
        {
            HallazgoBC objHallazgoBC = new HallazgoBC();
            return TranslatorHelper.TranslateHallazgosRegistrarLRToHallazgosCollection(objHallazgoBC.registrarHallazgo(objHallazgoDC.InformeFinCicloId, objHallazgoDC.Descripcion, objHallazgoDC.PeriodoId));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoCollectionDC IHallazgo.WSListarHallazgosxInformeFinCiclo(HallazgoDC objHallazgoDC)
        {
            HallazgoBC objHallazgoBC = new HallazgoBC();
            return TranslatorHelper.TranslateHallazgosListarLRToHallazgosCollection(objHallazgoBC.listarHallazgosxInformeFinCiclo(objHallazgoDC.InformeFinCicloId));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoCollectionDC IHallazgo.WSEditarHallazgo(HallazgoDC objHallazgoDC)
        {
            HallazgoBC objHallazgoBC = new HallazgoBC();
            return TranslatorHelper.TranslateHallazgosEditarLRToHallazgosCollection(objHallazgoBC.editarHallazgo(objHallazgoDC.HallazgoId, objHallazgoDC.InformeFinCicloId, objHallazgoDC.Descripcion));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoCollectionDC IHallazgo.WSEliminarHallazgo(HallazgoDC objHallazgoDC)
        {
            HallazgoBC objHallazgoBC = new HallazgoBC();
            return TranslatorHelper.TranslateHallazgosEliminarLRToHallazgosCollection(objHallazgoBC.eliminarHallazgo(objHallazgoDC.HallazgoId, objHallazgoDC.InformeFinCicloId));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        HallazgoReporteCollectionDC IHallazgo.WSListarHallazgoReporte(InformeFinCicloDC objInformeFinCicloDC)
        {
            HallazgoBC objHallazgoBC = new HallazgoBC();
            return TranslatorHelper.TranslateHallazgoReporteLRToHallazgoReporteCollection(objHallazgoBC.listarReporteHallazgo(objInformeFinCicloDC.CursoId, objInformeFinCicloDC.PeriodoId));
        }
    }
}
