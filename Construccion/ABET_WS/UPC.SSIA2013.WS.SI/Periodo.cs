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

namespace UPC.SSIA2013.WS.ServiceLibrary
{

   public class Periodo:IPeriodo
    {
       [OperationBehavior]
       public PeriodoCollectionDC ListarPeriodoPorCarreraId(int CarreraId)
       {
           PeriodoLogic oPeriodoLogic = new PeriodoLogic();
           return PeriodoTL.PeriodoCollectionBEConvertirPeriodoCollectionDC(oPeriodoLogic.ListarPeriodoPorCarreraId(CarreraId));
       }
       [OperationBehavior]
       public PeriodoDC ObtenerPeriodoActual()
       {
           PeriodoLogic oPeriodoLogic = new PeriodoLogic();
           return PeriodoTL.PeriodoBEConvertirPeriodoDC(oPeriodoLogic.ObtenerPeriodoActual());
       }
       
       #region METODO IFCDC

       [OperationBehavior]
       public PeriodoCollectionDC WSListarPeriodos()
       {
           PeriodoLogic objPeriodoBC = new PeriodoLogic();
           return PeriodoTL.TranslateListarPeriodosLRToPeriodoCollectionDC(objPeriodoBC.listarPeriodos());
       }

       [OperationBehavior]
       public PeriodoDC WSObtenerPeriodoActual()
       {
           PeriodoLogic objPeriodoBC = new PeriodoLogic();
           return PeriodoTL.TranslatePeriodoLRToPeriodoDC(objPeriodoBC.obtenerPeriodo());
       }

       #endregion

       #region metodos GPPP
       public PeriodoCollectionDC ListarPeriodoXEstadoXEsActual(PeriodoDC objDC)
       {
           PeriodoLogic objBC = new PeriodoLogic();
           return PeriodoTL.TranslatePeriodoLRToPeriodoCollection(objBC.periodoListarXEstadoXEsActual(objDC.Estado, objDC.EsActual));
       }
       #endregion
    }
}
