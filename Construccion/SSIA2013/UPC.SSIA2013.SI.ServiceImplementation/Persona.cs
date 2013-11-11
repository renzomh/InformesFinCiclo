using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

using UPC.SSIA2013.BL.BC;
using UPC.SSIA2013.DL.DataModel;
using UPC.SSIA2013.SI.DataContracts;
using UPC.SSIA2013.SI.ServiceContracts;

namespace UPC.SSIA2013.SI.ServiceImplementation
{
    [ServiceBehavior]
    public class Persona : IPersona
    {
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        PersonaDC IPersona.WSObtenerPersona(PersonaDC objPersonaDC)
        {
            PersonaBC objPersonaBC = new PersonaBC();
            return TranslatorHelper.TranslatePersonaLRToPersonaDC(objPersonaBC.obtenerPersona(objPersonaDC.PersonaId));

        }
    }
}
