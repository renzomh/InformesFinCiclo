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
    public class AccionMejora : IAccionMejora
    {
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC IAccionMejora.WSRegistrarAccionMejora(AccionMejoraDC objAccionMejoraDC)
        {
            AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
            return TranslatorHelper.TranslateAccionesMejoraRegistrarLRToAccionMejoraCollection(objAccionMejoraBC.registrarAccionMejora(objAccionMejoraDC.HallazgoId, objAccionMejoraDC.InformeFinCicloId, objAccionMejoraDC.CicloEjecucionId, objAccionMejoraDC.Descripcion));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC IAccionMejora.WSListarAccionesMejoraxInformeFinCiclo(AccionMejoraDC objAccionMejoraDC)
        {
            AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
            return TranslatorHelper.TranslateAccionesMejoraListarLRToAccionMejoraCollection(objAccionMejoraBC.listarAccionesMejoraxInformeFinCiclo(objAccionMejoraDC.InformeFinCicloId));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC IAccionMejora.WSListarAccionesMejoraPrevias(InformeFinCicloDC informeFinCicloDC)
        {
            AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
            return TranslatorHelper.TranslateAccionesPreviasListarLRToAccionMejoraCollection(objAccionMejoraBC.listarAccionesMejoraPrevias(informeFinCicloDC.CursoId, informeFinCicloDC.PeriodoId));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC IAccionMejora.WSEditarAccionMejora(AccionMejoraDC objAccionMejoraDC)
        {
            AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
            return TranslatorHelper.TranslateAccionesMejoraEditarLRToAccionMejoraCollection(objAccionMejoraBC.editarAccionMejora(objAccionMejoraDC.AccionMejoraId, objAccionMejoraDC.InformeFinCicloId, objAccionMejoraDC.CicloEjecucionId, objAccionMejoraDC.Descripcion));
        }

        //AccionMejoraCollectionDC IAccionMejora.WSEditarAccionMejoraPrevia(InformeFinCicloDC objInformeFinCicloDC, AccionMejoraDC objAccionMejoraDC)
        //{
        //    AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
        //   return TranslatorHelper.TranslateAccionesMejoraPreviaEditarLRToAccionMejoraCollection(objAccionMejoraBC.editarAccionMejoraPrevia(objInformeFinCicloDC.CursoId, objInformeFinCicloDC.PeriodoId, objAccionMejoraDC.AccionMejoraId, objAccionMejoraDC.Estado));
        //}

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraCollectionDC IAccionMejora.WSEliminarAccionMejora(AccionMejoraDC objAccionMejoraDC)
        {
            AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
            return TranslatorHelper.TranslateAccionesMejoraEliminarLRToAccionMejoraCollection(objAccionMejoraBC.eliminarAccionMejora(objAccionMejoraDC.AccionMejoraId, objAccionMejoraDC.InformeFinCicloId));
        }

        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        AccionMejoraReporteCollectionDC IAccionMejora.WSListarAccionMejoraReporte(InformeFinCicloDC objInformeFinCicloDC)
        {
            AccionMejoraBC objAccionMejoraBC = new AccionMejoraBC();
            return TranslatorHelper.TranslateAccionesMejoraReporteLRToAccionMejoraCollection(objAccionMejoraBC.listarReporteAccionMejora(objInformeFinCicloDC.CursoId, objInformeFinCicloDC.PeriodoId, objInformeFinCicloDC.Estado));
        }
    }
}
