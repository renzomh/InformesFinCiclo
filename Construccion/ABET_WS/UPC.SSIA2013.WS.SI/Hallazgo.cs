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
    public class Hallazgo : IHallazgo
    {
        [OperationBehavior]
        HallazgoCollectionDC IHallazgo.WSRegistrarHallazgo(int informeFinCicloId, String descripcion, int periodoId)
        {
            HallazgoLogic objHallazgoBC = new HallazgoLogic();
            return HallazgoTL.TranslateHallazgosRegistrarLRToHallazgosCollection(objHallazgoBC.registrarHallazgo(informeFinCicloId, descripcion, periodoId));
        }

        [OperationBehavior]
        HallazgoCollectionDC IHallazgo.WSListarHallazgosxInformeFinCiclo(int informeFinCicloId)
        {
            HallazgoLogic objHallazgoBC = new HallazgoLogic();
            return HallazgoTL.TranslateHallazgosListarLRToHallazgosCollection(objHallazgoBC.listarHallazgosxInformeFinCiclo(informeFinCicloId));
        }

        [OperationBehavior]
        HallazgoCollectionDC IHallazgo.WSEditarHallazgo(int hallazgoId, int informeFinCicloId, String descripcion)
        {
            HallazgoLogic objHallazgoBC = new HallazgoLogic();
            return HallazgoTL.TranslateHallazgosEditarLRToHallazgosCollection(objHallazgoBC.editarHallazgo(hallazgoId, informeFinCicloId, descripcion));
        }

        [OperationBehavior]
        HallazgoCollectionDC IHallazgo.WSEliminarHallazgo(int hallazgoId, int informeFinCicloId)
        {
            HallazgoLogic objHallazgoBC = new HallazgoLogic();
            return HallazgoTL.TranslateHallazgosEliminarLRToHallazgosCollection(objHallazgoBC.eliminarHallazgo(hallazgoId, informeFinCicloId));
        }

        [OperationBehavior]
        HallazgoReporteCollectionDC IHallazgo.WSListarHallazgoReporte(int cursoId, int periodoId)
        {
            HallazgoLogic objHallazgoBC = new HallazgoLogic();
            return HallazgoTL.TranslateHallazgoReporteLRToHallazgoReporteCollection(objHallazgoBC.listarReporteHallazgo(cursoId, periodoId));
        }
    }
}
