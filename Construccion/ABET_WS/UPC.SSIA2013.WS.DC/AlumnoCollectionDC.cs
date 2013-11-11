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
    public class AlumnoCollectionDC
    {
        #region metodos GPPP
        private Collection<AlumnoDC> _lstAlumno;

        [DataMember]
        public Collection<AlumnoDC> lstAlumno
        {
            get { return _lstAlumno; }
            set { _lstAlumno = value; }
        }

        #endregion
    }
}
