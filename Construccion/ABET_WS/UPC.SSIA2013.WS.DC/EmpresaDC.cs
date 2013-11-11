using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class EmpresaDC
    {
        private String _RUC;
        private String _RazonSocial;
        private String _Direccion;
        private String _FechaRegistro;
        private String _FechaModificacion;
        private Int32 _EmpresaId;
        private Int32 _Estado;

        [DataMember]
        public Int32 Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        public Int32 EmpresaId
        {
            get { return _EmpresaId; }
            set { _EmpresaId = value; }
        }

        [DataMember]
        public String FechaModificacion
        {
            get { return _FechaModificacion; }
            set { _FechaModificacion = value; }
        }

        [DataMember]
        public String FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }

        [DataMember]
        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        [DataMember]
        public String RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }

        }

        [DataMember]
        public String RUC
        {
            get { return _RUC; }
            set { _RUC = value; }
        }
    }
}
