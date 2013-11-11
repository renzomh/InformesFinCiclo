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
    public class CarreraTL
    {
        public static CarreraEntity CarreraDCConvertirCarreraBE(CarreraDC oCarreraDC)
        {
            try
            {
                CarreraEntity oCarreraEntity = new CarreraEntity();
                oCarreraEntity.CarreraId = oCarreraDC.CarreraId;
                oCarreraEntity.CarreraNombre = oCarreraDC.Nombre;

                return oCarreraEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CarreraDC CarreraBEConvertirCarreraDC(CarreraEntity oCarreraBE)
        {
            try
            {
                CarreraDC oCarreraDC = new CarreraDC();
                oCarreraDC.CarreraId = oCarreraBE.CarreraId;
                oCarreraDC.Nombre = oCarreraBE.CarreraNombre;

                return oCarreraDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CarreraCollectionDC CarreraCollectionBEConvertirCarreraCollectionDC(List<CarreraEntity> listCarreraBE)
        {
            CarreraCollectionDC oCarreraCollectionDC = new CarreraCollectionDC();
            CarreraDC oCarreraDC;
            for (int i = 0; i < listCarreraBE.Count; i++)
            {
                oCarreraDC = CarreraBEConvertirCarreraDC(listCarreraBE[i]);
                oCarreraCollectionDC.Add(oCarreraDC);
            }

            return oCarreraCollectionDC;
        }

        #region metodos GPPP
        public static CarreraCollectionDC TranslateCarreraXEscuelaLRToCarreraCollection(List<uspCarrera_ListarXEscuelaResult> lstLR)
        {
            CarreraCollectionDC collection;

            try
            {
                collection = new CarreraCollectionDC();
                //collection.lstCarrera = new Collection<CarreraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.Add(TranslateCarreraXEscuelaLRToCarreraDC(lstLR[i]));
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

        public static CarreraDC TranslateCarreraXEscuelaLRToCarreraDC(uspCarrera_ListarXEscuelaResult objLR)
        {
            CarreraDC objDC;

            try
            {
                objDC = new CarreraDC();

                objDC.EscuelaId = objLR.ESCUELAID == null ? 0 : objLR.ESCUELAID;
                objDC.CarreraId = objLR.CARRERAID;
                objDC.Nombre = objLR.NOMBRE == null ? "" : objLR.NOMBRE;

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
