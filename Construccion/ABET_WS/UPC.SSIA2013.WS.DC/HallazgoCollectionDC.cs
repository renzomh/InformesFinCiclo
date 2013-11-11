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
    public class HallazgoCollectionDC
    {
        private Collection<HallazgoDC> _lstHallazgos;

        [DataMember]
        public Collection<HallazgoDC> LstHallazgos
        {
            get { return _lstHallazgos; }
            set { _lstHallazgos = value; }
        }
    }
}
