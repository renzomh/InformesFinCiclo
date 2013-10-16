using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class CursoCollectionBE
    {
        private Collection<CursoBE> _LstCursos;

        public Collection<CursoBE> LstCursos
        {
            get { return _LstCursos; }
            set { _LstCursos = value; }
        }
    }
}
