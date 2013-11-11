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
    public class MallaEncuestaTL
    {
        #region metodos GPPP
        public static MallaEncuestaCollectionDC TranslateMallaEncuestaXCarreraXPeriodoXPPPXEstadoLRToMallaEncuestaCollection(List<uspMallaEncuesta_ListarXCarreraXPeriodoXPPPXEstadoResult> lstLR)
        {
            MallaEncuestaCollectionDC collection;

            try
            {
                collection = new MallaEncuestaCollectionDC();
                collection.lstMallaEncuesta = new Collection<MallaEncuestaDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.lstMallaEncuesta.Add(TranslateMallaEncuestaXCarreraXPeriodoXPPPXEstadoLRToMallaEncuestaDC(lstLR[i]));
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

        public static MallaEncuestaDC TranslateMallaEncuestaXCarreraXPeriodoXPPPXEstadoLRToMallaEncuestaDC(uspMallaEncuesta_ListarXCarreraXPeriodoXPPPXEstadoResult objLR)
        {
            MallaEncuestaDC objDC;

            try
            {
                objDC = new MallaEncuestaDC();

                objDC.MallaEncuestaId = objLR.MALLAENCUESTAID;
                objDC.CarreraId = objLR.CARRERAID;
                objDC.PeriodoId = objLR.PERIODOID;
                objDC.PracticaPreProfesionalId = objLR.PRACTICAPREPROFESIONALID;
                objDC.Nombre = objLR.NOMBRE == null ? "" : objLR.NOMBRE;
                objDC.Estado = objLR.ESTADO == null ? 0 : objLR.ESTADO;
                objDC.Estado_ImageUrl = objLR.ESTADO_IMAGEURL == null ? "" : objLR.ESTADO_IMAGEURL;
                objDC.FechaRegistro = UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO);
                objDC.FechaModificacion = UtilitarioTL.ConvertDateToString(objLR.FECHAMODIFICACION) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAMODIFICACION);

                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public static MallaEncuestaDC TranslateMallaEncuestaObtenerToMallaEncuestaDC(uspMallaEncuesta_ObtenerXMallaEncuestaIdResult objres)
        {
            MallaEncuestaDC objDC;

            try
            {
                objDC = new MallaEncuestaDC();

                objDC.MallaEncuestaId = objres.MALLAENCUESTAID;
                objDC.CarreraId = objres.CARRERAID;
                objDC.PeriodoId = objres.PERIODOID;
                objDC.PracticaPreProfesionalId = objres.PRACTICAPREPROFESIONALID;
                objDC.Nombre = objres.NOMBRE == null ? "" : objres.NOMBRE;
                objDC.Estado = objres.ESTADO == null ? 0 : objres.ESTADO;
                objDC.Estado_ImageUrl = objres.ESTADO_IMAGEURL == null ? "" : objres.ESTADO_IMAGEURL;
                objDC.FechaRegistro = UtilitarioTL.ConvertDateToString(objres.FECHAREGISTRO) == null ? "" : UtilitarioTL.ConvertDateToString(objres.FECHAREGISTRO);
                objDC.FechaModificacion = UtilitarioTL.ConvertDateToString(objres.FECHAMODIFICACION) == null ? "" : UtilitarioTL.ConvertDateToString(objres.FECHAMODIFICACION);

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
