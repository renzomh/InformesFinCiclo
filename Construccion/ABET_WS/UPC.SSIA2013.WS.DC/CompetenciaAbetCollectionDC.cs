using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.WS.DataContract
{
    #region metodos GPPP

    [DataContract]
    public class CompetenciaAbetXCarreraXPeriodoCollectionDC
    {        
        private Collection<CompetenciaAbetXCarreraXPeriodoDC> _lstCompetenciaAbetXCarreraXPeriodo;
        [DataMember]
        public Collection<CompetenciaAbetXCarreraXPeriodoDC> lstCompetenciaAbetXCarreraXPeriodo
        {
            get { return _lstCompetenciaAbetXCarreraXPeriodo; }
            set { _lstCompetenciaAbetXCarreraXPeriodo = value; }
        }
    }

    [DataContract]
    public class CompetenciaAbetXMallaEncuestaCollectionDC
    {
        private Collection<CompetenciaAbetXMallaEncuestaDC> _lstCompetenciaAbetXMallaEncuesta;
        [DataMember]
        public Collection<CompetenciaAbetXMallaEncuestaDC> LstCompetenciaAbetXMallaEncuesta
        {
            get { return _lstCompetenciaAbetXMallaEncuesta; }
            set { _lstCompetenciaAbetXMallaEncuesta = value; }
        }
    }

    [DataContract]
    public class CompetenciaAbetxEncuestaCollectionDC
    {
        private Collection<CompetenciaAbetxEncuestaDC> _lstCompetenciaAbetxEncuesta;
        [DataMember]
        public Collection<CompetenciaAbetxEncuestaDC> LstCompetenciaAbetxEncuesta
        {
            get { return _lstCompetenciaAbetxEncuesta; }
            set { _lstCompetenciaAbetxEncuesta = value; }
        }
    }

    #endregion
}
