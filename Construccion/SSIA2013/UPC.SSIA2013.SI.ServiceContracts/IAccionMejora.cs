using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.ServiceModel;

using UPC.SSIA2013.SI.DataContracts;

namespace UPC.SSIA2013.SI.ServiceContracts
{
    [ServiceContract]
    public interface IAccionMejora
    {
        [OperationContract]
        AccionMejoraCollectionDC WSRegistrarAccionMejora(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraCollectionDC WSListarAccionesMejoraxInformeFinCiclo(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraCollectionDC WSListarAccionesMejoraPrevias(InformeFinCicloDC informeFinCicloDC);

        [OperationContract]
        AccionMejoraCollectionDC WSEditarAccionMejora(AccionMejoraDC objAccionMejoraDC);

        //[OperationContract]
        //AccionMejoraCollectionDC WSEditarAccionMejoraPrevia(InformeFinCicloDC informeFinCicloDc, AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraCollectionDC WSEliminarAccionMejora(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraReporteCollectionDC WSListarAccionMejoraReporte(InformeFinCicloDC objInformeFinCicloDC);
    }
}
