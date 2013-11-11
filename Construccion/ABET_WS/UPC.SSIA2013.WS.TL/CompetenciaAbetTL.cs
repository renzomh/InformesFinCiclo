using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.TranslatorLayer;

using System.Collections.ObjectModel;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class CompetenciaAbetTL
    {
        #region metodos GPPP
        public static CompetenciaAbetXCarreraXPeriodoCollectionDC TranslateCompetenciaAbetXCarreraXPeriodoLRToCompetenciaAbetCollection(List<uspCompetenciaAbet_ListarXCarreraXPeriodoResult> lstLR)
        {
            CompetenciaAbetXCarreraXPeriodoCollectionDC collection;

            try
            {
                collection = new CompetenciaAbetXCarreraXPeriodoCollectionDC();
                collection.lstCompetenciaAbetXCarreraXPeriodo = new Collection<CompetenciaAbetXCarreraXPeriodoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.lstCompetenciaAbetXCarreraXPeriodo.Add(TranslateCompetenciaAbetXCarreraXPeriodoLRToCompetenciaAbetDC(lstLR[i]));
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

        public static CompetenciaAbetXCarreraXPeriodoDC TranslateCompetenciaAbetXCarreraXPeriodoLRToCompetenciaAbetDC(uspCompetenciaAbet_ListarXCarreraXPeriodoResult objLR)
        {
            CompetenciaAbetXCarreraXPeriodoDC objDC;

            try
            {
                objDC = new CompetenciaAbetXCarreraXPeriodoDC();

                objDC.CarreraId = objLR.CARRERAID == null ? 0 : objLR.CARRERAID;
                objDC.PeriodoId = objLR.PERIODOID == null ? 0 : objLR.PERIODOID;
                objDC.CompetenciaId = objLR.COMPETENCIAID;
                objDC.Codigo = objLR.CODIGO == null ? "" : objLR.CODIGO;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;
                objDC.Estado = objLR.ESTADO == null ? false : objLR.ESTADO;
                objDC.FechaRegistro = UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO);
                objDC.FechaModificacion = UtilitarioTL.ConvertDateToString(objLR.FECHAMODIFICACION) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO);

                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public static CompetenciaAbetXMallaEncuestaCollectionDC TranslateCompetenciaAbetxMallaEncuestaXResultadoProgramaToCompetenciaAbetCollection(List<uspCompetenciaAbet_ListarXMallaEncuestaXResultadoProgramaResult> objLR)
        {
            CompetenciaAbetXMallaEncuestaCollectionDC collection;

            try
            {
                collection = new CompetenciaAbetXMallaEncuestaCollectionDC();
                collection.LstCompetenciaAbetXMallaEncuesta = new Collection<CompetenciaAbetXMallaEncuestaDC>();

                for (int i = 0; i < objLR.Count; i++)
                {
                    collection.LstCompetenciaAbetXMallaEncuesta.Add(TranslateCompetenciaAbetxMallaencuestaXResultadoProgramaToCompetenciaAbetDC(objLR[i]));
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

        public static CompetenciaAbetXMallaEncuestaDC TranslateCompetenciaAbetxMallaencuestaXResultadoProgramaToCompetenciaAbetDC(uspCompetenciaAbet_ListarXMallaEncuestaXResultadoProgramaResult objLR)
        {
            CompetenciaAbetXMallaEncuestaDC objDC;

            try
            {
                objDC = new CompetenciaAbetXMallaEncuestaDC();

                objDC.MallaEncuestaId = objLR.MALLAENCUESTAID;
                objDC.CarreraId = objLR.CARRERAID == null ? 0 : objLR.CARRERAID;
                objDC.PeriodoId = objLR.PERIODOID == null ? 0 : objLR.PERIODOID;
                objDC.ResultadoProgramaId = objLR.RESULTADOPROGRAMAID;
                objDC.CompetenciaAbetId = objLR.COMPETENCIAABETID;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;
                objDC.Asignado = objLR.ASIGNADO == null ? false : objLR.ASIGNADO;

                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public static CompetenciaAbetXMallaEncuestaCollectionDC TranslateCompetenciaAbetPDFXMallaEncuestaLRToCompetenciaAbetCollection(List<uspCompetenciaAbet_ListarPDFXMallaEncuestaResult> lstLR)
        {
            CompetenciaAbetXMallaEncuestaCollectionDC collection;

            try
            {
                collection = new CompetenciaAbetXMallaEncuestaCollectionDC();
                collection.LstCompetenciaAbetXMallaEncuesta = new Collection<CompetenciaAbetXMallaEncuestaDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstCompetenciaAbetXMallaEncuesta.Add(TranslateCompetenciaAbetPDFXMallaEncuestaLRToCompetenciaAbetDC(lstLR[i]));
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

        public static CompetenciaAbetXMallaEncuestaDC TranslateCompetenciaAbetPDFXMallaEncuestaLRToCompetenciaAbetDC(uspCompetenciaAbet_ListarPDFXMallaEncuestaResult objLR)
        {
            CompetenciaAbetXMallaEncuestaDC objDC;

            try
            {
                objDC = new CompetenciaAbetXMallaEncuestaDC();

                objDC.MallaEncuestaId = objLR.MALLAENCUESTAID;
                objDC.CarreraId = objLR.CARRERAID == null ? 0 : objLR.CARRERAID;
                objDC.PeriodoId = objLR.PERIODOID == null ? 0 : objLR.PERIODOID;
                objDC.ResultadoProgramaId = objLR.RESULTADOPROGRAMAID;
                objDC.CompetenciaAbetId = objLR.COMPETENCIAABETID;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;
                objDC.Asignado = objLR.ASIGNADO == null ? false : objLR.ASIGNADO;

                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public static CompetenciaAbetxEncuestaCollectionDC TranslateCompetenciasAbetxMallaEncuestaIdToCompetenciaAbetxEncuestaDC(List<uspMallaEncuesta_ListarCompetenciasResult> lstLR)
        {
            CompetenciaAbetxEncuestaCollectionDC collection;

            try
            {
                collection = new CompetenciaAbetxEncuestaCollectionDC();
                collection.LstCompetenciaAbetxEncuesta = new Collection<CompetenciaAbetxEncuestaDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    CompetenciaAbetxEncuestaDC objDC = new CompetenciaAbetxEncuestaDC();
                    objDC.Codigo = lstLR.ElementAt(i).Codigo;
                    objDC.CompetenciaAbetId = lstLR.ElementAt(i).CompetenciaAbetId;
                    objDC.Descripcion = lstLR.ElementAt(i).Descripcion;
                    objDC.Nombre = lstLR.ElementAt(i).Nombre;
                    objDC.ResutadoProgramaId = lstLR.ElementAt(i).ResultadoProgramaId;
                    collection.LstCompetenciaAbetxEncuesta.Add(objDC);
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
        #endregion
    }
}
