using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class PersonaDC
    {
        private String _PersonaId;

        [DataMember]
        public String PersonaId
        {
            get { return _PersonaId; }
            set { _PersonaId = value; }
        }

        private String _Nombres;

        [DataMember]
        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        private String _Apellidos;

        [DataMember]
        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        private int _TipoPersona;
     
        [DataMember]    
        public int TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }
    }
}
