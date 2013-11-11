using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.SI.DataContracts
{  
    [DataContract]
    public class InformeFinCicloDC
    {
        private int _InformeFinCicloId;
        private String _CoordinadorId;
        private int _CursoId;
        private int _PeriodoId;
        private String _DesarrolloUnidades;
        private String _ComentarioInfraestructura;
        private String _ComentarioAlumnos;
        private String _ComentarioDelegados;
        private String _ComentarioEncuesta;
        private String _Estado;
        private String _UltimaActualizacion;

        [DataMember]
        public int InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        [DataMember]
        public String CoordinadorId
        {
            get { return _CoordinadorId; }
            set { _CoordinadorId = value; }
        }

        [DataMember]
        public int CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }

        [DataMember]
        public int PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        [DataMember]
        public String DesarrolloUnidades
        {
            get { return _DesarrolloUnidades; }
            set { _DesarrolloUnidades = value; }
        }

        [DataMember]
        public String ComentarioInfraestructura
        {
            get { return _ComentarioInfraestructura; }
            set { _ComentarioInfraestructura = value; }
        }

        [DataMember]
        public String ComentarioAlumnos
        {
            get { return _ComentarioAlumnos; }
            set { _ComentarioAlumnos = value; }
        }

        [DataMember]
        public String ComentarioDelegados
        {
            get { return _ComentarioDelegados; }
            set { _ComentarioDelegados = value; }
        }

        [DataMember]
        public String ComentarioEncuesta
        {
            get { return _ComentarioEncuesta; }
            set { _ComentarioEncuesta = value; }
        }

        [DataMember]
        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        public String UltimaActualizacion
        {
            get { return _UltimaActualizacion; }
            set { _UltimaActualizacion = value; }
        }
    }
}
