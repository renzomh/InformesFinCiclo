using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    #region metodos GPPP
    [DataContract]
    public class CompetenciaAbetXCarreraXPeriodoDC
    {
        private Int32 _CompetenciaId;
        private String _Codigo;
        private String _Descripcion;
        private bool? _Estado;
        private String _FechaRegistro;
        private String _FechaModificacion;
        private Int32? _CarreraId;
        private Int32? _PeriodoId;
        private bool _Asignado;

        [DataMember]
        public bool Asignado
        {
            get { return _Asignado; }
            set { _Asignado = value; }
        }

        [DataMember]
        public Int32? PeriodoId
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
        public Int32 CompetenciaId
        {
            get { return _CompetenciaId; }
            set { _CompetenciaId = value; }
        }
    }

    [DataContract]
    public class CompetenciaAbetXMallaEncuestaDC
    {
        private Int32 _MallaEncuestaId;
        private Int32? _CarreraId;
        private Int32? _PeriodoId;
        private Int32 _ResultadoProgramaId;
        private Int32 _CompetenciaAbetId;
        private String _Descripcion;
        private bool? _Asignado;

        [DataMember]
        public bool? Asignado
        {
            get { return _Asignado; }
            set { _Asignado = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public Int32 CompetenciaAbetId
        {
            get { return _CompetenciaAbetId; }
            set { _CompetenciaAbetId = value; }
        }

        [DataMember]
        public Int32 ResultadoProgramaId
        {
            get { return _ResultadoProgramaId; }
            set { _ResultadoProgramaId = value; }
        }

        [DataMember]
        public Int32? PeriodoId
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
        public Int32 MallaEncuestaId
        {
            get { return _MallaEncuestaId; }
            set { _MallaEncuestaId = value; }
        }
    }

    [DataContract]
    public class CompetenciaAbetxEncuestaDC
    {
        private Int32 _CompetenciaAbetId;
        private Int32 _Puntuacion;
        private String _Codigo;
        private String _Nombre;
        private String _Descripcion;
        private Int32 _MallaEncuestaId;
        private Int32 _EncuestaId;
        private Int32 _ResutadoProgramaId;

        [DataMember]
        public Int32 MallaEncuestaId
        {
            get { return _MallaEncuestaId; }
            set { _MallaEncuestaId = value; }
        }
        
        [DataMember]
        public Int32 ResutadoProgramaId
        {
            get { return _ResutadoProgramaId; }
            set { _ResutadoProgramaId = value; }
        }
        
        [DataMember]
        public Int32 EncuestaId
        {
            get { return _EncuestaId; }
            set { _EncuestaId = value; }
        }

        [DataMember]
        public Int32 CompetenciaAbetId
        {
            get { return _CompetenciaAbetId; }
            set { _CompetenciaAbetId = value; }
        }

        [DataMember]
        public Int32 Puntuacion
        {
            get { return _Puntuacion; }
            set { _Puntuacion = value; }
        }

        [DataMember]
        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
    }

    #endregion
}
