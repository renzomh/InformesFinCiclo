using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class AccionMejoraReporteBE
    {
        private int _AccionMejoraId;

        public int AccionMejoraId
        {
            get { return _AccionMejoraId; }
            set { _AccionMejoraId = value; }
        }

        private String _CodigoAccionMejora;

        public String CodigoAccionMejora
        {
            get { return _CodigoAccionMejora; }
            set { _CodigoAccionMejora = value; }
        }

        private String _CodigoHallazgo;

        public String CodigoHallazgo
        {
            get { return _CodigoHallazgo; }
            set { _CodigoHallazgo = value; }
        }

        private String _Descripcion;

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        private String _NombreCurso;

        public String NombreCurso
        {
            get { return _NombreCurso; }
            set { _NombreCurso = value; }
        }
    }
}
