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
    public class EmpresaTL
    {
        #region metodos GPPP
        public static EmpresaCollectionDC TranslateEmpresaXRazonSocialXRUCToEmpresaCollectionDC(List<uspEmpresa_ListarXRazonSocialXRucResult> objLR)
        {
            EmpresaCollectionDC collection;

            try
            {
                collection = new EmpresaCollectionDC();
                collection.LstEmpresa = new Collection<EmpresaDC>();

                for (int i = 0; i < objLR.Count; i++)
                {
                    collection.LstEmpresa.Add(TranslateEmpresaXRazonSocialXRUCToEmpresaDC(objLR[i]));
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

        public static EmpresaDC TranslateEmpresaXRazonSocialXRUCToEmpresaDC(uspEmpresa_ListarXRazonSocialXRucResult objLR)
        {
            EmpresaDC objDC;

            try
            {
                objDC = new EmpresaDC();

                objDC.Direccion = objLR.DIRECCION == null ? "" : objLR.DIRECCION;
                objDC.FechaRegistro = UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO);
                objDC.RazonSocial = objLR.RAZONSOCIAL == null ? "" : objLR.RAZONSOCIAL;
                objDC.RUC = objLR.RUC == null ? "" : objLR.RUC;
                objDC.EmpresaId = objLR.EMPRESAID;

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
