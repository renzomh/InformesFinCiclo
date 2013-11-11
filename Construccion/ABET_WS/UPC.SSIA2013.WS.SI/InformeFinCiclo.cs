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
    public class InformeFinCiclo : IInformeFinCiclo
    {
         [OperationBehavior]
        InformeFinCicloDC IInformeFinCiclo.WSObtenerInformeFinCicloxId(int informeFinCicloId)
        {
            InformeFinCicloLogic objInformeFinCicloBC = new InformeFinCicloLogic();
            return InformeFinCicloTL.TranslateInformeFinCicloxIdLRToInformeFinCicloDC(objInformeFinCicloBC.obtenerInformeFinCicloxId(informeFinCicloId));
        }

         [OperationBehavior]
        InformeFinCicloDC IInformeFinCiclo.WSObtenerInformeFinCiclo(String coordinadorId, int cursoId, int periodoId)
        {
            InformeFinCicloLogic objInformeFinCicloBC = new InformeFinCicloLogic();
            return InformeFinCicloTL.TranslateInformeFinCicloLRToInformeFinCicloDC(objInformeFinCicloBC.obtenerInformeFinCiclo(coordinadorId, cursoId, periodoId));
        }

         [OperationBehavior]
        InformeFinCicloDC IInformeFinCiclo.WSEditarInformeFinCiclo(int informeFinCicloId, String estado, String desarrolloUnidades, String infraestructura, String alumnos, String delegados, String encuesta)
        {
            InformeFinCicloLogic objInformeFinCicloBC = new InformeFinCicloLogic();
            return InformeFinCicloTL.TranslateEditarInformeFinCicloLRToInformeFinCicloDC(objInformeFinCicloBC.editarInformeFinCiclo(informeFinCicloId, estado, desarrolloUnidades, infraestructura, alumnos, delegados, encuesta));
        }

         [OperationBehavior]
        InformeFinCicloReporteCollectionDC IInformeFinCiclo.WSListarInformeFinCicloReporte(int cursoId, int periodoId, String estado)
        {
            InformeFinCicloLogic objInformeFinCicloBC = new InformeFinCicloLogic();
            return InformeFinCicloTL.TranslateInformeFinCicloReporteLRToInformeFinCicloReporteCollection(objInformeFinCicloBC.listarReporteInformeFinCiclo(cursoId, periodoId, estado));
        }
    }
}
