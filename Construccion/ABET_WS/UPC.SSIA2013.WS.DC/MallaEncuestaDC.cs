using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class MallaEncuestaDC
    {
        private Int32 _MallaEncuestaId;
        private Int32 _CarreraId;
        private Int32 _PeriodoId;
        private Int32 _PracticaPreProfesionalId;
        private String _Nombre;
        private Int32? _Estado;
        private String _Estado_ImageUrl;
        private String _FechaRegistro;
        private String _FechaModificacion;

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
        public String Estado_ImageUrl
        {
            get { return _Estado_ImageUrl; }
            set { _Estado_ImageUrl = value; }
        }

        [DataMember]
        public Int32? Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DataMember]
        public Int32 PracticaPreProfesionalId
        {
            get { return _PracticaPreProfesionalId; }
            set { _PracticaPreProfesionalId = value; }
        }

        [DataMember]
        public Int32 PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        [DataMember]
        public Int32 CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        [DataMember]
        public Int32 MallaEncuestaId
        {
            get { return _MallaEncuestaId; }
            set { _MallaEncuestaId = value; }
        }
    }    
}
