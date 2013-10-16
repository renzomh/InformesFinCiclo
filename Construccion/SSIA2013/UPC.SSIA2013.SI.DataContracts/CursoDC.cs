using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class CursoDC
    {
        private int _CursoId;

        [DataMember]
        public int CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        private String _Codigo;

        [DataMember]
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private String _Nombre;

        [DataMember]
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    }
}
