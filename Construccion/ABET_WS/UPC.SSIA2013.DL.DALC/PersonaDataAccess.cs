using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DataModel;
using System.Configuration;

namespace UPC.SSIA2013.DataAccess
{
    public class PersonaDataAccess
    {
        public up_Obtener_PersonaResult obtenerPersona(String personaId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                up_Obtener_PersonaResult persona = dataContext.up_Obtener_Persona(personaId).SingleOrDefault();

                return persona;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }
    }
}
