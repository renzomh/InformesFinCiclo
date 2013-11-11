using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.BusinessEntity;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class OutcomeTL
    {
        public static OutcomeEntity OutcomeDCConvertirOutcomeBE(OutcomeDC oOutcomeDC)
        {
            try
            {
                OutcomeEntity oOutcomeBE = new OutcomeEntity();
                oOutcomeBE.OutcomeId = oOutcomeDC.OutcomeId;
                oOutcomeBE.OutcomeNombre = oOutcomeDC.OutcomeNombre;

                return oOutcomeBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static OutcomeDC OutcomeBEConvertirOutcomeDC(OutcomeEntity oOutcomeBE)
        {
            try
            {
                OutcomeDC oOutcomeDC = new OutcomeDC();
                oOutcomeDC.OutcomeId = oOutcomeBE.OutcomeId;
                oOutcomeDC.OutcomeNombre = oOutcomeBE.OutcomeNombre;
                oOutcomeDC.OutcomeDescripcion = oOutcomeBE.OutcomeDescripcion;
                return oOutcomeDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static OutcomeCollectionDC OutcomeCollectionBEConvertirOutcomeCollectionDC(List<OutcomeEntity> listOutcomeBE)
        {
            OutcomeCollectionDC oOutcomeCollectionDC = new OutcomeCollectionDC();
            OutcomeDC oOutcomeDC;
            for (int i = 0; i < listOutcomeBE.Count; i++)
            {
                oOutcomeDC = OutcomeBEConvertirOutcomeDC(listOutcomeBE[i]);
                oOutcomeCollectionDC.Add(oOutcomeDC);
            }

            return oOutcomeCollectionDC;
        }
    }
}
