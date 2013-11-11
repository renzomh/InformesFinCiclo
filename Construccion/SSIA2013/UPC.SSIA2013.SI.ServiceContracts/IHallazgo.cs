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
    public interface IHallazgo
    {
        [OperationContract]
        HallazgoCollectionDC WSRegistrarHallazgo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoCollectionDC WSListarHallazgosxInformeFinCiclo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoCollectionDC WSEditarHallazgo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoCollectionDC WSEliminarHallazgo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoReporteCollectionDC WSListarHallazgoReporte(InformeFinCicloDC objInformeFinCicloDC);
    }
}
