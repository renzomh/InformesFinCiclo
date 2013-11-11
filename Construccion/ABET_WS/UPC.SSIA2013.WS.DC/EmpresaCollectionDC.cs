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
    public class EmpresaCollectionDC
    {
        private Collection<EmpresaDC> _lstEmpresa;
        
        [DataMember]
        public Collection<EmpresaDC> LstEmpresa
        {
            get { return _lstEmpresa; }
            set { _lstEmpresa = value; }
        }
    }
}
