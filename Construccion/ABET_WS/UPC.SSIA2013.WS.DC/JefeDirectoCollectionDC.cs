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
    public class JefeDirectoCollectionDC
    {
        private Collection<JefeDirectoDC> _lstJefeDirecto;

        [DataMember]
        public Collection<JefeDirectoDC> LstJefeDirecto
        {
            get { return _lstJefeDirecto; }
            set { _lstJefeDirecto = value; }
        }
    }

}
