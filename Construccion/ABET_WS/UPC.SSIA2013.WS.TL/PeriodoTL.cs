using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class PeriodoTL
    {

        #region METODO SIGERCOV

        public static PeriodoEntity PeriodoDCConvertirPeriodoBE(PeriodoDC oPeriodoDC)
        {
            try
            {
                PeriodoEntity oPeriodoBE = new PeriodoEntity();
                oPeriodoBE.PeriodoId = oPeriodoDC.PeriodoId;
                oPeriodoBE.PeriodoNombre = oPeriodoDC.Descripcion;

                return oPeriodoBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static PeriodoDC PeriodoBEConvertirPeriodoDC(PeriodoEntity oPeriodoBE)
        {
            try
            {
                PeriodoDC oPeriodoDC = new PeriodoDC();
                oPeriodoDC.PeriodoId = oPeriodoBE.PeriodoId;
                oPeriodoDC.Descripcion = oPeriodoBE.PeriodoNombre;

                return oPeriodoDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static PeriodoCollectionDC PeriodoCollectionBEConvertirPeriodoCollectionDC(List<PeriodoEntity> listPeriodoBE)
        {
            PeriodoCollectionDC oPeriodoCollectionDC = new PeriodoCollectionDC();
            PeriodoDC oPeriodoDC;
            for (int i = 0; i < listPeriodoBE.Count; i++)
            {
                oPeriodoDC = PeriodoBEConvertirPeriodoDC(listPeriodoBE[i]);
                oPeriodoCollectionDC.Add(oPeriodoDC);
            }

            return oPeriodoCollectionDC;
        }

        #endregion

        #region METODO IFCDC

        public static PeriodoCollectionDC TranslateListarPeriodosLRToPeriodoCollectionDC(List<up_Listar_PeriodosResult> lstLR)
        {
            PeriodoCollectionDC collection;

            try
            {
                collection = new PeriodoCollectionDC();

                for (int i = 0; i < lstLR.Count; i++)
                    collection.Add(TranslateListarPeriodosLRToPeriodoDC(lstLR[i]));

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static PeriodoDC TranslateListarPeriodosLRToPeriodoDC(up_Listar_PeriodosResult objLR)
        {
            PeriodoDC objPerdiodoDC;

            try
            {
                objPerdiodoDC = new PeriodoDC();
                if (objLR != null)
                {
                    objPerdiodoDC.PeriodoId = Int32.Parse(objLR.PeriodoId.ToString());
                    objPerdiodoDC.Descripcion = objLR.Descripcion;
                    objPerdiodoDC.FechaInicio = objLR.FechaInicio.ToString();
                    objPerdiodoDC.FechaFin = objLR.FechaFin.ToString();
                    objPerdiodoDC.EsActual = objLR.EsActual == null ? 0 : Convert.ToInt32(objLR.EsActual);
                }
                return objPerdiodoDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static PeriodoDC TranslatePeriodoLRToPeriodoDC(up_Obtener_PeriodoActualResult objLR)
        {
            PeriodoDC objPerdiodoDC;

            try
            {
                objPerdiodoDC = new PeriodoDC();
                if (objLR != null)
                {
                    objPerdiodoDC.PeriodoId = Int32.Parse(objLR.PeriodoId.ToString());
                    objPerdiodoDC.Descripcion = objLR.Descripcion;
                    objPerdiodoDC.FechaInicio = objLR.FechaInicio;
                    objPerdiodoDC.FechaFin = objLR.FechaFin;
                    objPerdiodoDC.EsActual = objLR.EsActual == null ? 0 : Convert.ToInt32(objLR.EsActual);
                }
                return objPerdiodoDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        
        #region metodos GPPP
        public static PeriodoCollectionDC TranslatePeriodoLRToPeriodoCollection(List<uspPeriodo_ListarXEstadoXEsActualResult> lstLR)
        {
            PeriodoCollectionDC collection;

            try
            {
                collection = new PeriodoCollectionDC();
                //collection.lstPeriodo = new Collection<PeriodoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.Add(TranslatePeriodoLRToPeriodoDC(lstLR[i]));
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

        public static PeriodoDC TranslatePeriodoLRToPeriodoDC(uspPeriodo_ListarXEstadoXEsActualResult objLR)
        {
            PeriodoDC objDC;

            try
            {
                objDC = new PeriodoDC();

                objDC.PeriodoId = objLR.PERIODOID;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;

                objDC.Estado = objLR.ESTADO == null ? 0 : Convert.ToInt32(objLR.ESTADO);
                objDC.EsActual = objLR.ESACTUAL == null ? 0 : Convert.ToInt32(objLR.ESACTUAL);

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