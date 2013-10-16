using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class InformeFinCicloReporteCollectionBE
    {
        private Collection<InformeFinCicloReporteBE> _lstInformeFinCicloReporte;

        public Collection<InformeFinCicloReporteBE> LstInformeFinCicloReporte
        {
            get { return _lstInformeFinCicloReporte; }
            set { _lstInformeFinCicloReporte = value; }
        }
    }
}
