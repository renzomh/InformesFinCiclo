using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class AccionMejoraReporteCollectionBE
    {
        private Collection<AccionMejoraReporteBE> _lstAccionMejoraReporte;

        public Collection<AccionMejoraReporteBE> LstAccionMejoraReporte
        {
            get { return _lstAccionMejoraReporte; }
            set { _lstAccionMejoraReporte = value; }
        }
    }
}
