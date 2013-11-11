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
    public class Encuesta : IEncuesta
    {
        #region metodos GPPP
        [OperationBehavior]
        public EncuestaGrillaCollectionDC ListarEncuestaXCarreraXPeriodoXPPPXEstadoXTipoRegistro(EncuestaGrillaDC objDC)
        {
            EncuestaLogic objBC = new EncuestaLogic();
            return EncuestaTL.TranslateEncuestaXCarreraXPeriodoXPPPXEstadoXTipoRegistroToEncuestaCollectionDC(objBC.encuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistro(objDC.CarreraId, objDC.PeriodoId, objDC.PracticaPreProfesionalId, objDC.MALLAENCUESTA_ESTADO, objDC.TipoRegistro));
        }

        [OperationBehavior]
        public Int32 ActualizarEncuesta(EncuestaDC objDC)
        {
            EncuestaLogic objBC = new EncuestaLogic();
            return objBC.encuesta_Actualizar(objDC);
        }

        [OperationBehavior]
        public Int32 EliminarEncuesta(Int32 encuestaId)
        {
            EncuestaLogic objBC = new EncuestaLogic();
            return objBC.encuesta_Eliminar(encuestaId);
        }

        [OperationBehavior]
        public EncuestaDC ObtenerEncuestaXEncuestaId(Int32 EncuestaId)
        {
            EncuestaLogic objBC = new EncuestaLogic();
            return objBC.encuesta_Obtener(EncuestaId);
        }

        [OperationBehavior]
        public Int32 RegistrarEncuesta(EncuestaDC objDC)
        {
            EncuestaLogic objBC = new EncuestaLogic();
            return objBC.encuesta_Registrar(objDC);
        }

        [OperationBehavior]
        public EncuestaGrillaCollectionDC ListarEncuestaXFechas(EncuestaFechasDC objDC)
        {
            EncuestaLogic objBC = new EncuestaLogic();
            return EncuestaTL.TranslateEncuestaXFechasToEncuestaCollectionDC(objBC.encuesta_ListarXFechas(Convert.ToDateTime(objDC.FechaFin), Convert.ToDateTime(objDC.FechaInicio)));
        }
        #endregion
    }
}
