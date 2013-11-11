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
    public class MallaEncuesta : IMallaEncuesta
    {
        #region metodos GPPP
        [OperationBehavior]
        public MallaEncuestaCollectionDC ListarMallaEncuestaXCarreraXPeriodoXPPPXEstado(MallaEncuestaDC objDC)
        {
            MallaEncuestaLogic objBC = new MallaEncuestaLogic();
            return MallaEncuestaTL.TranslateMallaEncuestaXCarreraXPeriodoXPPPXEstadoLRToMallaEncuestaCollection(objBC.mallaEncuestaListarXCarreraXPeriodoXPPPXEstado(objDC.CarreraId, objDC.PeriodoId, objDC.PracticaPreProfesionalId, objDC.Estado));
        }

        [OperationBehavior]
        public Int32 RegistrarMallaEncuesta(MallaEncuestaDC objDC)
        {
            MallaEncuestaLogic objBC = new MallaEncuestaLogic();
            return objBC.mallaEncuestaRegistrar(objDC.CarreraId, objDC.PeriodoId, objDC.PracticaPreProfesionalId, objDC.Nombre, objDC.Estado, objDC.Estado_ImageUrl);
        }

        [OperationBehavior]
        public Int32 ActualizarMallaEncuesta(MallaEncuestaDC objDC)
        {
            MallaEncuestaLogic objBC = new MallaEncuestaLogic();
            return objBC.mallaEncuestaActualizar(objDC.MallaEncuestaId, objDC.Nombre, objDC.CarreraId, objDC.PeriodoId, objDC.PracticaPreProfesionalId, objDC.Estado, objDC.Estado_ImageUrl);
        }

        [OperationBehavior]
        public Int32 CambiarEstadoMallaEncuestaXMallaEncuestaIdXEstadoXUrl(MallaEncuestaDC objDC)
        {
            MallaEncuestaLogic objBC = new MallaEncuestaLogic();
            return objBC.mallaEncuestaCambiarEstadoXMallaEncuestaIdXEstadoXUrl(objDC.MallaEncuestaId, objDC.Estado, objDC.Estado_ImageUrl, objDC.PeriodoId, objDC.CarreraId, objDC.PracticaPreProfesionalId);
        }

        [OperationBehavior]
        public MallaEncuestaDC ObtenerMallaEncuestaxMallaEncuestaId(Int32 MallaEncuestaId)
        {
            MallaEncuestaLogic objBC = new MallaEncuestaLogic();
            return MallaEncuestaTL.TranslateMallaEncuestaObtenerToMallaEncuestaDC(objBC.mallaObtenerxMallaEncuestaId(MallaEncuestaId));
        }

        [OperationBehavior]
        public CompetenciaAbetxEncuestaCollectionDC ListarCompetenciasxMallaEncuestaId(Int32 MallaEncuestaId)
        {
            MallaEncuestaLogic objBC = new MallaEncuestaLogic();
            return CompetenciaAbetTL.TranslateCompetenciasAbetxMallaEncuestaIdToCompetenciaAbetxEncuestaDC(objBC.mallaEncuestaListarCompetencias(MallaEncuestaId));
        }
        #endregion
    }
}
