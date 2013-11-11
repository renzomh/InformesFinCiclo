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
    [ServiceBehavior]
    public class Curso : ICurso
    {


        #region METODO SIGERCOV

        [OperationBehavior]
        public CursoCollectionDC ListarCursosPorTipoCursoCarreraId(int CarreraId, int TipoCurso)
        {
            CursoLogic oCursoLogic = new CursoLogic();
            return CursoTL.CursoCollectionBEConvertirCursoCollectionDC(oCursoLogic.ListarCursosPorTipoCursoCarreraId(CarreraId, TipoCurso));
        }

        [OperationBehavior]
        public CursoCollectionDC ListarCursosPorCarreraPorNivelPorPeriodoActual(int CarreraId, int nivel)
        {
            CursoLogic oCursoLogic = new CursoLogic();
            return CursoTL.CursoCollectionBEConvertirCursoCollectionDC(oCursoLogic.ListarCursosPorCarreraPorNivelPorPeriodoActual(CarreraId, nivel));
        }

        [OperationBehavior]
        public void ActualizarCursosPorCarreraPorNivelPorPeriodoActual(int cursoId, bool esControl, bool esVerificacion)
        {
            CursoLogic oCursoLogic = new CursoLogic();
            oCursoLogic.ActualizarCursosPorCarreraPorNivelPorPeriodoActual(cursoId, esControl, esVerificacion);
        }

        #endregion

        #region METODO IFCDC

        [OperationBehavior]
        public CursoCollectionDC ListarCursos()
        {
            CursoLogic objCursoBC = new CursoLogic();
            return CursoTL.TranslateListarCursosLRToCursoCollectionDC(objCursoBC.listarCursos());
        }

        [OperationBehavior]
        public CursoxProfesorCollectionDC ListarCursosxProfesor(String profesorId)
        {
            CursoLogic objCursoBC = new CursoLogic();
            return CursoTL.TranslateCursosxProfesorLRToCursosxProfesorCollection(objCursoBC.listarCursosxProfesor(profesorId));
        }

        #endregion


    }
}