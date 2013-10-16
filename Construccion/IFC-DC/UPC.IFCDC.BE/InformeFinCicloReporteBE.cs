using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class InformeFinCicloReporteBE
    {
        private int _InformeFinCicloId;

        public int InformeFinCicloId
        {
            get { return _InformeFinCicloId; }
            set { _InformeFinCicloId = value; }
        }

        private String _CodigoCurso;

        public String CodigoCurso
        {
            get { return _CodigoCurso; }
            set { _CodigoCurso = value; }
        }

        private String _NombreCurso;

        public String NombreCurso
        {
            get { return _NombreCurso; }
            set { _NombreCurso = value; }
        }

        private String _NombreProfesor;

        public String NombreProfesor
        {
            get { return _NombreProfesor; }
            set { _NombreProfesor = value; }
        }

        private String _FechaActualizacion;

        public String FechaActualizacion
        {
            get { return _FechaActualizacion; }
            set { _FechaActualizacion = value; }
        }

        private String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        private String _Periodo;

        public String Periodo
        {
            get { return _Periodo; }
            set { _Periodo = value; }
        }
    }
}
