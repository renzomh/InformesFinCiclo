using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.DataModel;

using System.Collections.ObjectModel;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class ResultadoProgramaTL
    {
        #region METODOS IFC-DC
        public static ResultadoProgramaxCursoCollectionDC TranslateResultadoProgramasxCursoLRToResultadoProgramaCollection(List<up_Listar_ResultadoPrograma_x_CursoResult> lstLR)
        {
            ResultadoProgramaxCursoCollectionDC collection;

            try
            {
                collection = new ResultadoProgramaxCursoCollectionDC();
                collection.LstResultadoProgramaxCurso = new Collection<ResultadoProgramaxCursoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstResultadoProgramaxCurso.Add(TranslateHallazgoxInformeFinCicloLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ResultadoProgramaxCursoDC TranslateHallazgoxInformeFinCicloLRToHallazgoDC(up_Listar_ResultadoPrograma_x_CursoResult objLR)
        {
            ResultadoProgramaxCursoDC obj;

            try
            {
                obj = new ResultadoProgramaxCursoDC();

                obj.ResultadoProgramaId = objLR.ResultadoProgramaId;
                obj.CarreraId = objLR.CarreraId.Value;
                obj.Outcome = objLR.Outcome;
                obj.Descricpion = objLR.Descripcion;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region metodos GPPP
        public static ResultadoProgramaXCarreraXPeriodoCollectionDC TranslateResultadoProgramaXCarreraXPeriodoLRToResultadoProgramaCollection(List<uspResultadoPrograma_ListarXCarreraXPeriodoResult> lstLR)
        {
            ResultadoProgramaXCarreraXPeriodoCollectionDC collection;

            try
            {
                collection = new ResultadoProgramaXCarreraXPeriodoCollectionDC();
                collection.lstResultadoProgramaXCarreraXPeriodo = new Collection<ResultadoProgramaXCarreraXPeriodoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.lstResultadoProgramaXCarreraXPeriodo.Add(TranslateResultadoProgramaXCarreraXPeriodoLRToResultadoProgramaDC(lstLR[i]));
                }

                return collection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }

        }

        public static ResultadoProgramaXCarreraXPeriodoDC TranslateResultadoProgramaXCarreraXPeriodoLRToResultadoProgramaDC(uspResultadoPrograma_ListarXCarreraXPeriodoResult objLR)
        {
            ResultadoProgramaXCarreraXPeriodoDC objDC;

            try
            {
                objDC = new ResultadoProgramaXCarreraXPeriodoDC();

                objDC.ResultadoProgramaId = objLR.RESULTADOPROGRAMAID;
                objDC.Outcome = objLR.OUTCOME == null ? "" : objLR.OUTCOME;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;
                objDC.CarreraId = objLR.CARRERAID == null ? 0 : objLR.CARRERAID;
                objDC.PeriodoId = objLR.PERIODOID;

                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public static ResultadoProgramaXMallaEncuestaXCarreraCollectionDC TranslateResultadoProgramaXMallaEncuestaXCarreraLRToResultadoProgramaCollection(List<uspResultadoPrograma_ListarXMallaEncuestaXCarreraResult> lstLR)
        {
            ResultadoProgramaXMallaEncuestaXCarreraCollectionDC collection;

            try
            {
                collection = new ResultadoProgramaXMallaEncuestaXCarreraCollectionDC();
                collection.lstResultadoProgramaXMallaEncuestaXCarrera = new Collection<ResultadoProgramaXMallaEncuestaXCarreraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.lstResultadoProgramaXMallaEncuestaXCarrera.Add(TranslateResultadoProgramaXMallaEncuestaXCarreraLRToResultadoProgramaDC(lstLR[i]));
                }

                return collection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }

        }

        public static ResultadoProgramaXMallaEncuestaXCarreraDC TranslateResultadoProgramaXMallaEncuestaXCarreraLRToResultadoProgramaDC(uspResultadoPrograma_ListarXMallaEncuestaXCarreraResult objLR)
        {
            ResultadoProgramaXMallaEncuestaXCarreraDC objDC;

            try
            {
                objDC = new ResultadoProgramaXMallaEncuestaXCarreraDC();

                objDC.MallaEncuestaId = objLR.MALLAENCUESTAID;
                objDC.ResultadoProgramaId = objLR.RESULTADOPROGRAMAID;
                objDC.Outcome = objLR.OUTCOME == null ? "" : objLR.OUTCOME; ;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION; ;
                objDC.CarreraId = objLR.CARRERAID == null ? 0 : objLR.CARRERAID; ;
                objDC.Asignado = objLR.ASIGNADO == null ? false : objLR.ASIGNADO; ;

                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }
        #endregion
    }
}
