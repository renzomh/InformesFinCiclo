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
    public interface ICurso
    {
        [OperationContract]
        CursoCollectionDC WSListarCursos();

        [OperationContract]
        CursoxProfesorCollectionDC WSListarCursosxProfesor(CursoxProfesorDC objCursoxProfesorDC);
    }
}
