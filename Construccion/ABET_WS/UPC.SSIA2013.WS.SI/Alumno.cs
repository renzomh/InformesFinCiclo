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
    public class Alumno : IAlumno
    {
        #region metodos GPPP
        [OperationBehavior]
        public AlumnoCollectionDC ListarAlumnoXAlumnoXCarreraXPeriodoXPPPXEstado(AlumnoDC objDC)
        {
            AlumnoLogic objBC = new AlumnoLogic();
            return AlumnoTL.TranslateAlumnoXAlumnoXCarreraXPeriodoXPPPXEstadoToAlumnoCollectionDC(objBC.alumnoListarXAlumnoXCarreraXPeriodoXPPPXEstado(objDC.AlumnoId, objDC.CarreraId, objDC.PeriodoId, objDC.PracticaPreProfesionalId, objDC.Estado, objDC.CreditosAprobados == 1 ? true : false));
        }
        #endregion
    }
}
