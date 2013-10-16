using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class HallazgoReporteDC
    {
        private int _HallazogId;

        [DataMember]
        public int HallazogId
        {
            get { return _HallazogId; }
            set { _HallazogId = value; }
        }

        private String _CodigoHallazgo;

        [DataMember]
        public String CodigoHallazgo
        {
            get { return _CodigoHallazgo; }
            set { _CodigoHallazgo = value; }
        }

        private String _Descripcion;

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private String _NombreCurso;

        [DataMember]
        public String NombreCurso
        {
            get { return _NombreCurso; }
            set { _NombreCurso = value; }
        }
    }
}
