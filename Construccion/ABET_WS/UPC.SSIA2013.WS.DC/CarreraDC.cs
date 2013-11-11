using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class CarreraDC
    {
        private Int32 _CarreraId;
        private String _Nombre;
        private Int32? _EscuelaId;

        [DataMember]
        public Int32? EscuelaId
        {
            get { return _EscuelaId; }
            set { _EscuelaId = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DataMember]
        public Int32 CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }
    }
}
