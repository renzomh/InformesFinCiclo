using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class PersonaLogic
    {
        public up_Obtener_PersonaResult obtenerPersona(String personaId)
        {
            PersonaDataAccess objPersonaDataAccess;

            try
            {
                objPersonaDataAccess = new PersonaDataAccess();
                return objPersonaDataAccess.obtenerPersona(personaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
