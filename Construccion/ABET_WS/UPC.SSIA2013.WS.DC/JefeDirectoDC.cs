using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class JefeDirectoDC
    {
        private String _JefeDirectoId;
        private String _Nombres;
        private String _Apellidos;
        private String _NOMBRECOMPLETO;
        private String _NroDocumento;
        private String _Telefono1;
        private String _Cargo;
        private String _Anexo;
        private String _FechaRegistro;
        private String _FechaModificacion;
        
        [DataMember]
        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        [DataMember]
        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        
        [DataMember]
        public String JefeDirectoId
        {
            get { return _JefeDirectoId; }
            set { _JefeDirectoId = value; }
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
        public String Anexo
        {
            get { return _Anexo; }
            set { _Anexo = value; }
        }

        [DataMember]
        public String Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        [DataMember]
        public String Telefono1
        {
            get { return _Telefono1; }
            set { _Telefono1 = value; }
        }

        [DataMember]
        public String NroDocumento
        {
            get { return _NroDocumento; }
            set { _NroDocumento = value; }
        }

        [DataMember]
        public String NOMBRECOMPLETO
        {
            get { return _NOMBRECOMPLETO; }
            set { _NOMBRECOMPLETO = value; }
        }

    }

    [DataContract]
    public class JefeDirecto2DC
    {
        private String _JefeDirectoId;
        private String _Nombres;        
        private String _Apellidos;        
        private String _NroDocumento;
        private String _Telefono1;
        private String _Cargo;
        private String _Anexo;
        private String _FechaRegistro;
        private String _FechaModificacion;
        private Int32 _Estado;

        [DataMember]
        public Int32 Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        [DataMember]
        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        [DataMember]
        public String JefeDirectoId
        {
            get { return _JefeDirectoId; }
            set { _JefeDirectoId = value; }
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
        public String Anexo
        {
            get { return _Anexo; }
            set { _Anexo = value; }
        }

        [DataMember]
        public String Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        [DataMember]
        public String Telefono1
        {
            get { return _Telefono1; }
            set { _Telefono1 = value; }
        }

        [DataMember]
        public String NroDocumento
        {
            get { return _NroDocumento; }
            set { _NroDocumento = value; }
        }
    }

}
