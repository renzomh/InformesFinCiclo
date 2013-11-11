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
    public class ResultadoPrograma : IResultadoPrograma
    {
        #region IFC-DC
        [OperationBehavior]
        ResultadoProgramaxCursoCollectionDC IResultadoPrograma.WSListarResultadoProgramaxCurso(int cursoId, int periodoId)
        {
            ResultadoProgramaLogic objResultadoProgramaBC = new ResultadoProgramaLogic();
            return ResultadoProgramaTL.TranslateResultadoProgramasxCursoLRToResultadoProgramaCollection(objResultadoProgramaBC.listarResultadoProgramaxCurso(cursoId, periodoId));
        }
        #endregion

        #region metodos GPPP
        [OperationBehavior]
        public ResultadoProgramaXCarreraXPeriodoCollectionDC ListarResultadoProgramaXCarreraXPeriodo(ResultadoProgramaXCarreraXPeriodoDC objDC)
        {
            ResultadoProgramaLogic objBC = new ResultadoProgramaLogic();
            return ResultadoProgramaTL.TranslateResultadoProgramaXCarreraXPeriodoLRToResultadoProgramaCollection(objBC.resultadoProgramaListarXCarreraXPeriodo(objDC.CarreraId, objDC.PeriodoId));
        }

        [OperationBehavior]
        public ResultadoProgramaXMallaEncuestaXCarreraCollectionDC ListarResultadoProgramaXMallaEncuestaXCarrera(ResultadoProgramaXMallaEncuestaXCarreraDC objDC)
        {
            ResultadoProgramaLogic objBC = new ResultadoProgramaLogic();
            return ResultadoProgramaTL.TranslateResultadoProgramaXMallaEncuestaXCarreraLRToResultadoProgramaCollection(objBC.resultadoProgramaListarXMallaEncuestaXCarrera(objDC.MallaEncuestaId, objDC.CarreraId));
        }

        [OperationBehavior]
        public Int32 RegistrarResultadoProgramaXMallaEncuesta(List<ResultadoProgramaXMallaEncuestaDC> lstDC)
        {
            ResultadoProgramaLogic objBC = new ResultadoProgramaLogic();
            return objBC.resultadoProgramaXMallaEncuestaRegistrar(lstDC);
        }

        [OperationBehavior]
        public Int32 RegistrarResultadoProgramaXCompetenciaAbet(List<ResultadoProgramaXCompetenciaAbetDC> lstDC)
        {
            ResultadoProgramaLogic objBC = new ResultadoProgramaLogic();
            return objBC.resultadoProgramaXCompetenciaAbetRegistrar(lstDC);
        }

        [OperationBehavior]
        public Int32 ActualizarResultadoProgramaxMallaEncuesta(List<ResultadoProgramaXMallaEncuestaDC> lstDC)
        {
            ResultadoProgramaLogic objBC = new ResultadoProgramaLogic();
            return objBC.resultadoProgramaXMallaEncuestaActualizar(lstDC);
        }

        [OperationBehavior]
        public Int32 ActualizarResultadoProgramaxCompetenciaAbet(List<ResultadoProgramaXCompetenciaAbetDC> lstDC)
        {
            ResultadoProgramaLogic objBC = new ResultadoProgramaLogic();
            return objBC.resultadoProgramaXCompetenciaAbetActualizar(lstDC);
        }
        #endregion
    }
}
