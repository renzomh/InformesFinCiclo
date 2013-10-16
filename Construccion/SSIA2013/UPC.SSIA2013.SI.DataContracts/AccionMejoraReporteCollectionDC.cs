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
    public class AccionMejoraReporteCollectionDC
    {
        private Collection<AccionMejoraReporteDC> _lstAccionMejoraReporte;

        [DataMember]
        public Collection<AccionMejoraReporteDC> LstAccionMejoraReporte
        {
            get { return _lstAccionMejoraReporte; }
            set { _lstAccionMejoraReporte = value; }
        }
    }
}
