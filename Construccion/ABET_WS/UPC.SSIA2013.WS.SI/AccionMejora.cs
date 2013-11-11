using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.WS.ServiceContract;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.WS.TranslatorLayer;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.BusinessLogic;

using System.ServiceModel;
using System.ServiceModel.Activation;

using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.WS.ServiceLibrary
{
    [ServiceBehavior]
    public class AccionMejora : IAccionMejora
    {
        [OperationBehavior]
        public AccionMejoraCollectionDC WSRegistrarAccionMejora(int hallazgoId, int informeFinCicloId, int periodoEjecucionId, String descripcion)
        {
            AccionMejoraLogic objAccionMejoraLogic = new AccionMejoraLogic();
            return AccionMejoraTL.TranslateAccionesMejoraRegistrarLRToAccionMejoraCollection(objAccionMejoraLogic.registrarAccionMejora(hallazgoId, informeFinCicloId, periodoEjecucionId, descripcion));
        }

        [OperationBehavior]
        public AccionMejoraCollectionDC WSListarAccionesMejoraxInformeFinCiclo(int informeFinCicloId)
        {
            AccionMejoraLogic objAccionMejoraLogic = new AccionMejoraLogic();
            return AccionMejoraTL.TranslateAccionesMejoraListarLRToAccionMejoraCollection(objAccionMejoraLogic.listarAccionesMejoraxInformeFinCiclo(informeFinCicloId));
        }

        [OperationBehavior]
        public AccionMejoraCollectionDC WSListarAccionesMejoraPrevias(int cursoId, int periodoId)
        {
            AccionMejoraLogic objAccionMejoraLogic = new AccionMejoraLogic();
            return AccionMejoraTL.TranslateAccionesPreviasListarLRToAccionMejoraCollection(objAccionMejoraLogic.listarAccionesMejoraPrevias(cursoId, periodoId));
        }

        [OperationBehavior]
        public AccionMejoraCollectionDC WSEditarAccionMejora(int accionMejoraId, int informeFinCicloId, int periodoEjecucionId, String descripcion)
        {
            AccionMejoraLogic objAccionMejoraLogic = new AccionMejoraLogic();
            return AccionMejoraTL.TranslateAccionesMejoraEditarLRToAccionMejoraCollection(objAccionMejoraLogic.editarAccionMejora(accionMejoraId, informeFinCicloId, periodoEjecucionId, descripcion));
        }

        [OperationBehavior]
        public AccionMejoraCollectionDC WSEditarAccionMejoraPrevia(int cursoId, int periodoId, int accionMejoraId, String estado)
        {
            AccionMejoraLogic objAccionMejoraLogic = new AccionMejoraLogic();
            return AccionMejoraTL.TranslateAccionesMejoraPreviaEditarLRToAccionMejoraCollection(objAccionMejoraLogic.editarAccionMejoraPrevia(cursoId, periodoId, accionMejoraId, estado));
        }

        [OperationBehavior]
        public AccionMejoraCollectionDC WSEliminarAccionMejora(int accionMejoraId, int informeFinCicloId)
        {
            AccionMejoraLogic objAccionMejoraLogic = new AccionMejoraLogic();
            return AccionMejoraTL.TranslateAccionesMejoraEliminarLRToAccionMejoraCollection(objAccionMejoraLogic.eliminarAccionMejora(accionMejoraId, informeFinCicloId));
        }

       [OperationBehavior]
        public AccionMejoraReporteCollectionDC WSListarAccionMejoraReporte(int cursoId, int periodoId, String estado)
        {
            AccionMejoraLogic objAccionMejoraLogic = new AccionMejoraLogic();
            return AccionMejoraTL.TranslateAccionesMejoraReporteLRToAccionMejoraCollection(objAccionMejoraLogic.listarReporteAccionMejora(cursoId, periodoId, estado));
        }
    }
}
