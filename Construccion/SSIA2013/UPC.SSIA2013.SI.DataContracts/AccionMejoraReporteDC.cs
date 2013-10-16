using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class AccionMejoraReporteDC
    {
        private int _AccionMejoraId;

        [DataMember]
        public int AccionMejoraId
        {
            get { return _AccionMejoraId; }
            set { _AccionMejoraId = value; }
        }

        private String _CodigoAccionMejora;

        [DataMember]
        public String CodigoAccionMejora
        {
            get { return _CodigoAccionMejora; }
            set { _CodigoAccionMejora = value; }
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

        private String _Estado;

        [DataMember]
        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
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
