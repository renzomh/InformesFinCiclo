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
    [ServiceBehavior]
    public class CompetenciaAbet : ICompetenciaAbet
    {
        #region metodos GPPP
        [OperationBehavior]
        public CompetenciaAbetXCarreraXPeriodoCollectionDC ListarCompetenciaAbetXCarreraXPeriodo(CompetenciaAbetXCarreraXPeriodoDC objDC)
        {
            CompetenciaAbetLogic objBC = new CompetenciaAbetLogic();
            return CompetenciaAbetTL.TranslateCompetenciaAbetXCarreraXPeriodoLRToCompetenciaAbetCollection(objBC.competenciaAbetListarXCarreraXPeriodo(objDC.CarreraId, objDC.PeriodoId));
        }

        [OperationBehavior]
        public CompetenciaAbetXMallaEncuestaCollectionDC ListarCompetenciaAbetxMallaEncuestaxResultadoPrograma(ResultadoProgramaXMallaEncuestaXCarreraDC objDC)
        {
            CompetenciaAbetLogic objBC = new CompetenciaAbetLogic();
            return CompetenciaAbetTL.TranslateCompetenciaAbetxMallaEncuestaXResultadoProgramaToCompetenciaAbetCollection(objBC.competenciaAbetxMallaEncuestxResultadoPrograma(objDC.MallaEncuestaId, objDC.ResultadoProgramaId));
        }

        [OperationBehavior]
        public CompetenciaAbetXMallaEncuestaCollectionDC ListarCompetenciaAbetPDFXMallaEncuesta(CompetenciaAbetXMallaEncuestaDC objDC)
        {
            CompetenciaAbetLogic objBC = new CompetenciaAbetLogic();
            return CompetenciaAbetTL.TranslateCompetenciaAbetPDFXMallaEncuestaLRToCompetenciaAbetCollection(objBC.competenciaAbetListarPDFXMallaEncuesta(objDC.MallaEncuestaId));
        }
        #endregion
    }
}
