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
    public class MallaEncuestaCollectionDC
    {
        #region metodos GPPP        
        private Collection<MallaEncuestaDC> _lstMallaEncuesta;
        
        [DataMember]
        public Collection<MallaEncuestaDC> lstMallaEncuesta
        {
            get { return _lstMallaEncuesta; }
            set { _lstMallaEncuesta = value; }
        }

        #endregion
    }
}
