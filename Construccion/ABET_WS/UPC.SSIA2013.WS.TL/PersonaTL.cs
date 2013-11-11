using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class PersonaTL
    {
        #region METODO IFCDC

        public static PersonaDC TranslatePersonaLRToPersonaDC(up_Obtener_PersonaResult objLR)
        {
            PersonaDC objPersonaDC;

            try
            {
                objPersonaDC = new PersonaDC();

                if (objLR != null)
                {
                    objPersonaDC.PersonaId = objLR.PersonaId;
                    objPersonaDC.Nombres = objLR.Nombres;
                    objPersonaDC.Apellidos = objLR.Apellidos;
                    objPersonaDC.TipoPersona = Int32.Parse(objLR.TipoPersona.ToString());
                }

                return objPersonaDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
