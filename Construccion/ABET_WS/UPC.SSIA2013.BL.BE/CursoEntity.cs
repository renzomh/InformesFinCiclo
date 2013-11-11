using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.SSIA2013.BusinessEntity
{
    public class CursoEntity
    {
        public int CursoId { get; set; }
        public String CursoNombre { get; set; }

        public int CursoCreditos { get; set; }
        public Boolean CursoControl { get; set; }
        public Boolean CursoVerificacion { get; set; }
    }
}
