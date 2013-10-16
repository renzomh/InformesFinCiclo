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
    public class PeriodoCollectionDC
    {
        private Collection<PeriodoDC> _lstPeriodos;

        [DataMember]
        public Collection<PeriodoDC> LstPeriodos
        {
            get { return _lstPeriodos; }
            set { _lstPeriodos = value; }
        }
    }
}
