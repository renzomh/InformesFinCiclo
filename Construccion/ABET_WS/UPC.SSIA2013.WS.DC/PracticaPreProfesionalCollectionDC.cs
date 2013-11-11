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
    public class PracticaPreProfesionalCollectionDC
    {
        #region metodosGPPP

        private Collection<PracticaPreProfesionalDC> _lstPracticaPreProfesional;
        [DataMember]
        public Collection<PracticaPreProfesionalDC> lstPracticaPreProfesional
        {
            get { return _lstPracticaPreProfesional; }
            set { _lstPracticaPreProfesional = value; }
        }

        #endregion
    }
}
