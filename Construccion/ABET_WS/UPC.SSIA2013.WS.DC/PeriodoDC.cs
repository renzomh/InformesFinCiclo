using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class PeriodoDC
    {
        private Int32 _PeriodoId;
        private String _Descripcion;
        private Int32? _Estado;
        private Int32? _EsActual;

        [DataMember]
        public Int32? EsActual
        {
            get { return _EsActual; }
            set { _EsActual = value; }
        }

        [DataMember]
        public Int32? Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        public Int32 PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


        #region METODO IFCDC

        [DataMember]
        public String FechaInicio { get; set; }
        [DataMember]
        public String FechaFin { get; set; }


        #endregion

    }
}
