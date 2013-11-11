using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.TranslatorLayer;

using System.Collections.ObjectModel;

namespace UPC.SSIA2013.WS.ServiceLibrary
{
    public class PracticaPreProfesionalTL
    {
        #region metodos GPPP
        public static PracticaPreProfesionalCollectionDC TranslatePracticaPreProfesionalXPeriodoXCarreraXEstadoLRToPracticaPreProfesionalCollection(List<uspPractica_ListarXPeriodoXCarreraXEstadoResult> lstLR)
        {
            PracticaPreProfesionalCollectionDC collection;

            try
            {
                collection = new PracticaPreProfesionalCollectionDC();
                collection.lstPracticaPreProfesional = new Collection<PracticaPreProfesionalDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.lstPracticaPreProfesional.Add(TranslatePracticaPreProfesionalXPeriodoXCarreraXEstadoLRToPracticaPreProfesionalDC(lstLR[i]));
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

        public static PracticaPreProfesionalDC TranslatePracticaPreProfesionalXPeriodoXCarreraXEstadoLRToPracticaPreProfesionalDC(uspPractica_ListarXPeriodoXCarreraXEstadoResult objLR)
        {
            PracticaPreProfesionalDC objDC;

            try
            {
                objDC = new PracticaPreProfesionalDC();

                objDC.PracticaPreProfesionalId = objLR.PRACTICAPREPROFESIONALID;
                objDC.PeriodoId = objLR.PERIODOID;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;
                objDC.CarreraId = objLR.CARRERAID;
                objDC.NombreCarrera = objLR.NombreCarrera == null ? "" : objLR.NombreCarrera;
                objDC.Numero = objLR.NUMERO == null ? 0 : objLR.NUMERO;
                objDC.Nombre = objLR.NOMBRE == null ? "" : objLR.NOMBRE;
                objDC.NombreInforme = objLR.NOMBREINFORME == null ? "" : objLR.NOMBREINFORME;
                objDC.CreditosACumplirInicio = objLR.CREDITOSACUMPLIRINICIO == null ? 0 : objLR.CREDITOSACUMPLIRINICIO;
                objDC.CreditosACumplirFin = objLR.CREDITOSACUMPLIRFIN == null ? 0 : objLR.CREDITOSACUMPLIRFIN;
                objDC.MinimoCreditosInicio = objLR.MINIMOCREDITOSINICIO == null ? 0 : objLR.MINIMOCREDITOSINICIO;
                objDC.MinimoCreditosFin = objLR.MINIMOCREDITOSFIN == null ? 0 : objLR.MINIMOCREDITOSFIN;
                objDC.CreditosACumplirMaximo = objLR.CREDITOSACUMPLIRMAXIMO == null ? 0 : objLR.CREDITOSACUMPLIRMAXIMO;
                objDC.FechaRegistro = UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO);
                objDC.FechaModificacion = UtilitarioTL.ConvertDateToString(objLR.FECHAMODIFICACION) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAMODIFICACION);
                objDC.Estado = objLR.ESTADO == null ? 0 : objLR.ESTADO;

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
