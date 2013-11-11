using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    
    [DataContract]
    public class CursoxProfesorDC
    {
        private int _CursoId;
        private String _Codigo;
        private String _Nombre;
        private String _ProfesorId;

        [DataMember]
        public String ProfesorId
        {
            get { return _ProfesorId; }
            set { _ProfesorId = value; }
        }

        [DataMember]
        public int CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        [DataMember]
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    }
}
