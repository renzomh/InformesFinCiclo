using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class HallazgoReporteCollectionBE
    {
        private Collection<HallazgoReporteBE> _lstHallazgoReporte;

        public Collection<HallazgoReporteBE> LstHallazgoReporte
        {
            get { return _lstHallazgoReporte; }
            set { _lstHallazgoReporte = value; }
        }
    }
}
