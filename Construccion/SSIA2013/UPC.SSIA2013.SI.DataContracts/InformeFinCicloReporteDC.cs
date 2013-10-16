using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class InformeFinCicloReporteDC
    {
        private int _InformeFinCicloId;

        [DataMember]
        public int InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        private String _CodigoCurso;

        [DataMember]
        public String CodigoCurso
        {
            get { return _CodigoCurso; }
            set { _CodigoCurso = value; }
        }

        private String _NombreCurso;

        [DataMember]
        public String NombreCurso
        {
            get { return _NombreCurso; }
            set { _NombreCurso = value; }
        }

        private String _NombreProfesor;

        [DataMember]
        public String NombreProfesor
        {
            get { return _NombreProfesor; }
            set { _NombreProfesor = value; }
        }

        private String _FechaActualizacion;

        [DataMember]
        public String FechaActualizacion
        {
            get { return _FechaActualizacion; }
            set { _FechaActualizacion = value; }
        }

        private String _Estado;

        [DataMember]
        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        private String _Periodo;

        [DataMember]
        public String Periodo
        {
            get { return _Periodo; }
            set { _Periodo = value; }
        }
    }
}
