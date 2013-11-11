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
    public class EncuestaGrillaCollectionDC
    {
        private Collection<EncuestaGrillaDC> _lstEncuesta;

        [DataMember]
        public Collection<EncuestaGrillaDC> LstEncuesta
        {
            get { return _lstEncuesta; }
            set { _lstEncuesta = value; }
        }

    }

    [DataContract]
    public class EncuestaCollectionDC
    {
        private Collection<EncuestaDC> _lstEncuesta;

        [DataMember]
        public Collection<EncuestaDC> LstEncuesta
        {
            get { return _lstEncuesta; }
            set { _lstEncuesta = value; }
        }

    }

}
