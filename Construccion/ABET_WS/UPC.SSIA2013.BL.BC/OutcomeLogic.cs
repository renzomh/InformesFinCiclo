using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;

namespace UPC.SSIA2013.BusinessLogic
{
    public class OutcomeLogic
    {
        public List<OutcomeEntity> ListarOutcomePorCarreraId(int CarreraId)
        {
            OutcomeDataAccess oOutcomeDALC = new OutcomeDataAccess();
            try
            {
                return oOutcomeDALC.ListarOutcomePorCarreraId(CarreraId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
