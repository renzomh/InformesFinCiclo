using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class LogroDC
    {
        private Int32 _LogroId;

        [DataMember]
        public Int32 LogroId
        {
            get { return _LogroId; }
            set { _LogroId = value; }
        }

        private Int32? _CursoId;

        [DataMember]
        public Int32? CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        private String _Descripcion;

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private Boolean _Estado;

        [DataMember]
        public Boolean Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
