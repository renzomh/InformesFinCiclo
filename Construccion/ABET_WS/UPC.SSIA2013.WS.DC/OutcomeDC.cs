using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class OutcomeDC
    {
        [DataMember]
        public int OutcomeId { get; set; }
        [DataMember]
        public String OutcomeNombre { get; set; }
        [DataMember]
        public String OutcomeDescripcion { get; set; }
    }
}
