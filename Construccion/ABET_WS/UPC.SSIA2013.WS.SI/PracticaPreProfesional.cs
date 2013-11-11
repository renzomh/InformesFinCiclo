using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.WS.ServiceContract;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.WS.TranslatorLayer;
using UPC.SSIA2013.DataModel;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.BusinessLogic;

using System.ServiceModel;
using System.ServiceModel.Activation;

namespace UPC.SSIA2013.WS.ServiceLibrary
{
    #region metodos GPPP
    [ServiceBehavior]
    public class PracticaPreProfesional : IPracticaPreProfesional
    {
        [OperationBehavior]
        public PracticaPreProfesionalCollectionDC ListarPracticaPreProfesionalXPeriodoXCarreraXEstado(PracticaPreProfesionalDC objDC)
        {
            PracticaPreProfesionalLogic objBC = new PracticaPreProfesionalLogic();
            return PracticaPreProfesionalTL.TranslatePracticaPreProfesionalXPeriodoXCarreraXEstadoLRToPracticaPreProfesionalCollection(objBC.practicaPreProfesionalListarXPeriodoXCarreraXEstado(objDC.PeriodoId, objDC.CarreraId, objDC.Estado));
        }

        [OperationBehavior]
        public Int32 RegistrarPracticaPreProfesional(PracticaPreProfesionalDC objDC)
        {
            PracticaPreProfesionalLogic objBC = new PracticaPreProfesionalLogic();
            return objBC.practicaPreProfesionalInsertar(objDC);
        }

        [OperationBehavior]
        public Int32 ActualizarPracticaPreProfesional(PracticaPreProfesionalDC objDC)
        {
            PracticaPreProfesionalLogic objBC = new PracticaPreProfesionalLogic();
            return objBC.practicaPreProfesionalActualizar(objDC);

        }
    #endregion
    }
}
