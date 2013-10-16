using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.SI.DataContracts
{
    [DataContract]
    public class CursoCollectionDC
    {
        private Collection<CursoDC> _lstCursos;

        [DataMember]
        public Collection<CursoDC> LstCursos
        {
            get { return _lstCursos; }
            set { _lstCursos = value; }
        }
    }
}
