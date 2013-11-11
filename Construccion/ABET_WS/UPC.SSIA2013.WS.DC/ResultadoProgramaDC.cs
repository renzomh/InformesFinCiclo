using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{    
    #region metodos GPPP
    [DataContract]
    public class ResultadoProgramaXCarreraXPeriodoDC
    {
        private Int32 _ResultadoProgramaId;
        private String _Outcome;
        private String _Descripcion;
        private Int32? _CarreraId;
        private Int32 _PeriodoId;

        private Int32 _MallaId;

        [DataMember]
        public Int32 MallaId
        {
            get { return _MallaId; }
            set { _MallaId = value; }
        }

        [DataMember]
        public Int32 PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        [DataMember]
        public Int32? CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public String Outcome
        {
            get { return _Outcome; }
            set { _Outcome = value; }
        }

        [DataMember]
        public Int32 ResultadoProgramaId
        {
            get { return _ResultadoProgramaId; }
            set { _ResultadoProgramaId = value; }
        }
    }

    [DataContract]
    public class ResultadoProgramaXMallaEncuestaXCarreraDC
    {
        private Int32 _MallaEncuestaId;
        private Int32 _ResultadoProgramaId;
        private String _Outcome;
        private String _Descripcion;
        private Int32? _CarreraId;
        private bool? _Asignado;

        [DataMember]
        public bool? Asignado
        {
            get { return _Asignado; }
            set { _Asignado = value; }
        }

        [DataMember]
        public Int32 MallaEncuestaId
        {
            get { return _MallaEncuestaId; }
            set { _MallaEncuestaId = value; }
        }

        [DataMember]
        public Int32? CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public String Outcome
        {
            get { return _Outcome; }
            set { _Outcome = value; }
        }

        [DataMember]
        public Int32 ResultadoProgramaId
        {
            get { return _ResultadoProgramaId; }
            set { _ResultadoProgramaId = value; }
        }
    }

    [DataContract]
    public class ResultadoProgramaXMallaEncuestaDC
    {
        private Int32 _MallaEncuestaId;
        private Int32 _ResultadoProgramaId;
        private bool? _Asignado;
        private String _Outcome;
        private string _Descripcion;
        private Int32 _CarreraId;

        [DataMember]
        public Int32 CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        [DataMember]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public String Outcome
        {
            get { return _Outcome; }
            set { _Outcome = value; }
        }

        [DataMember]
        public bool? Asignado
        {
            get { return _Asignado; }
            set { _Asignado = value; }
        }

        [DataMember]
        public Int32 MallaEncuestaId
        {
            get { return _MallaEncuestaId; }
            set { _MallaEncuestaId = value; }
        }

        [DataMember]
        public Int32 ResultadoProgramaId
        {
            get { return _ResultadoProgramaId; }
            set { _ResultadoProgramaId = value; }
        }
    }

    [DataContract]
    public class ResultadoProgramaXCompetenciaAbetDC
    {
        private Int32 _ResultadoProgramaId;
        private Int32 _CompetenciaAbetId;
        private bool? _Asignado;
        private Int32 _MallaEncuestaId;
        private Int32 _CarreraId;
        private Int32 _PeriodoId;
        private String _Codigo;
        private String _Descripcion;
        private bool? _Estado;
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
        public bool? Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
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
        public Int32 CompetenciaAbetId
        {
            get { return _CompetenciaAbetId; }
            set { _CompetenciaAbetId = value; }
        }

        [DataMember]
        public bool? Asignado
        {
            get { return _Asignado; }
            set { _Asignado = value; }
        }

        [DataMember]
        public Int32 MallaEncuestaId
        {
            get { return _MallaEncuestaId; }
            set { _MallaEncuestaId = value; }
        }

        [DataMember]
        public Int32 ResultadoProgramaId
        {
            get { return _ResultadoProgramaId; }
            set { _ResultadoProgramaId = value; }
        }
    }
    #endregion
}
