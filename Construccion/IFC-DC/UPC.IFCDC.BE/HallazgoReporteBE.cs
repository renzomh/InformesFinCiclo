using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.BE
{
    public class HallazgoReporteBE
    {
        private int _HallazogId;

        public int HallazogId
        {
            get { return _HallazogId; }
            set { _HallazogId = value; }
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

        private String _NombreCurso;

        public String NombreCurso
        {
            get { return _NombreCurso; }
            set { _NombreCurso = value; }
        }
    }
}
