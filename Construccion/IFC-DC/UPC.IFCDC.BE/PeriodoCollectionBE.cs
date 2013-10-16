using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class PeriodoCollectionBE
    {
        private Collection<PeriodoBE> _LstPeriodos;

        public Collection<PeriodoBE> LstPeriodos
        {
            get { return _LstPeriodos; }
            set { _LstPeriodos = value; }
        }
    }
}
