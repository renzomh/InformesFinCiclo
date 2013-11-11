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
    public class ResultadoProgramaXCarreraXPeriodoCollectionDC
    {
        private Collection<ResultadoProgramaXCarreraXPeriodoDC> _lstResultadoProgramaXCarreraXPeriodo;
        [DataMember]
        public Collection<ResultadoProgramaXCarreraXPeriodoDC> lstResultadoProgramaXCarreraXPeriodo
        {
            get { return _lstResultadoProgramaXCarreraXPeriodo; }
            set { _lstResultadoProgramaXCarreraXPeriodo = value; }
        }
    }

    [DataContract]
    public class ResultadoProgramaXMallaEncuestaXCarreraCollectionDC
    {
        private Collection<ResultadoProgramaXMallaEncuestaXCarreraDC> _lstResultadoProgramaXMallaEncuestaXCarrera;
        [DataMember]
        public Collection<ResultadoProgramaXMallaEncuestaXCarreraDC> lstResultadoProgramaXMallaEncuestaXCarrera
        {
            get { return _lstResultadoProgramaXMallaEncuestaXCarrera; }
            set { _lstResultadoProgramaXMallaEncuestaXCarrera = value; }
        }
    }

    [DataContract]
    public class ResultadoProgramaXMallaEncuestaCollectionDC
    {
        private Collection<ResultadoProgramaXMallaEncuestaDC> _lstResultadoProgramaXMallaEncuesta;

        [DataMember]
        public Collection<ResultadoProgramaXMallaEncuestaDC> lstResultadoProgramaXMallaEncuesta
        {
            get { return _lstResultadoProgramaXMallaEncuesta; }
            set { _lstResultadoProgramaXMallaEncuesta = value; }
        }
    }
}
