using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public  class CursoDC
    {
        [DataMember]
        public int CursoId { get; set; }
        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public int CursoCreditos { get; set; }
        [DataMember]
        public Boolean CursoControl { get; set; }
        [DataMember]
        public Boolean CursoVerificacion { get; set; }

        #region METODO IFCDC

        [DataMember]
        public String Codigo { get; set; }

        #endregion
        

    }
}
