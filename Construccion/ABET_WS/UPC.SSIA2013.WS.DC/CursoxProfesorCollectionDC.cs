using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class CursoxProfesorCollectionDC
    {
        private Collection<CursoxProfesorDC> _lstCursosxProfesor;

        [DataMember]
        public Collection<CursoxProfesorDC> LstCursosxProfesor
        {
            get { return _lstCursosxProfesor; }
            set { _lstCursosxProfesor = value; }
        }
    }
}
