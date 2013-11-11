using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [DataContract]
    public class EncuestaGrillaDC
    {

        private Int32 _CarreraId;
        private String _CARRERA_NOMBRE; 
        private Int32? _MALLAENCUESTA_ESTADO;
        private Int32 _PeriodoId;
        private Int32 _PracticaPreProfesionalId;
        private String _PRACTICAPREPROFESIONAL_NOMBRE;
        private String _TipoRegistro;
        private Int32 _EncuestaId;
        private Int32 _MallaEncuestaId;
        private String _Descripcion;
        private String _MALLAENCUESTA_NOMBRE;
        private Int32 _EmpresaId;
        private String _JefeDirectoId;
        //private String _PersonaId;
        private String _AlumnoId;
        private String _ALUMNO_NOMBRES;
        private String _ALUMNO_APELLIDOS;
        private Int32? _TotalHoras;
        //private String _JEFEDIRECTO_NOMBRES;
        //private String _JEFEDIRECTO_APELLIDOS;
        private String _RazonSocial;
        private Int32? _ENCUESTA_ESTADO;
        private String _FechaRegistroDigital;

        [DataMember]
        public String FechaRegistroDigital
        {
            get { return _FechaRegistroDigital; }
            set { _FechaRegistroDigital = value; }
        }

        [DataMember]
        public String PRACTICAPREPROFESIONAL_NOMBRE
        {
            get { return _PRACTICAPREPROFESIONAL_NOMBRE; }
            set { _PRACTICAPREPROFESIONAL_NOMBRE = value; }
        }

        [DataMember]
        public String CARRERA_NOMBRE
        {
            get { return _CARRERA_NOMBRE; }
            set { _CARRERA_NOMBRE = value; }
        }
       
        [DataMember]
        public Int32? ENCUESTA_ESTADO
        {
            get { return _ENCUESTA_ESTADO; }
            set { _ENCUESTA_ESTADO = value; }
        }

        [DataMember]
        public String JefeDirectoId
        {
            get { return _JefeDirectoId; }
            set { _JefeDirectoId = value; }
        }

        [DataMember]
        public String MALLAENCUESTA_NOMBRE
        {
            get { return _MALLAENCUESTA_NOMBRE; }
            set { _MALLAENCUESTA_NOMBRE = value; }
        }

        [DataMember]
        public Int32? MALLAENCUESTA_ESTADO
        {
            get { return _MALLAENCUESTA_ESTADO; }
            set { _MALLAENCUESTA_ESTADO = value; }
        }

        [DataMember]
        public Int32 EmpresaId
        {
            get { return _EmpresaId; }
            set { _EmpresaId = value; }
        }

        //[DataMember]
        //public String PersonaId
        //{
        //    get { return _PersonaId; }
        //    set { _PersonaId = value; }
        //}

        [DataMember]
        public String AlumnoId
        {
            get { return _AlumnoId; }
            set { _AlumnoId = value; }
        }

        [DataMember]
        public String ALUMNO_NOMBRES
        {
            get { return _ALUMNO_NOMBRES; }
            set { _ALUMNO_NOMBRES = value; }
        }

        [DataMember]
        public String ALUMNO_APELLIDOS
        {
            get { return _ALUMNO_APELLIDOS; }
            set { _ALUMNO_APELLIDOS = value; }
        }

        [DataMember]
        public Int32? TotalHoras
        {
            get { return _TotalHoras; }
            set { _TotalHoras = value; }
        }

        [DataMember]
        public String TipoRegistro
        {
            get { return _TipoRegistro; }
            set { _TipoRegistro = value; }
        }

        //[DataMember]
        //public String JEFEDIRECTO_NOMBRES
        //{
        //    get { return _JEFEDIRECTO_NOMBRES; }
        //    set { _JEFEDIRECTO_NOMBRES = value; }
        //}

        //[DataMember]
        //public String JEFEDIRECTO_APELLIDOS
        //{
        //    get { return _JEFEDIRECTO_APELLIDOS; }
        //    set { _JEFEDIRECTO_APELLIDOS = value; }
        //}

        [DataMember]
        public String RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public Int32 MallaEncuestaId
        {
            get { return _MallaEncuestaId; }
            set { _MallaEncuestaId = value; }
        }

        [DataMember]
        public Int32 CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        [DataMember]
        public Int32 PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        [DataMember]
        public Int32 PracticaPreProfesionalId
        {
            get { return _PracticaPreProfesionalId; }
            set { _PracticaPreProfesionalId = value; }
        }

        [DataMember]
        public Int32 EncuestaId
        {
            get { return _EncuestaId; }
            set { _EncuestaId = value; }
        }

    }

    [DataContract]
    public class EncuestaDC
    {
        private Int32 _EncuestaId;
        private Int32 _MallaEncuestaId;
        private Int32 _CarreraId;
        private Int32 _PeriodoId;        
        private String _Descripcion;
        private Int32 _PracticaPreProfesionalId;
        private String _MALLAENCUESTA_NOMBRE;
        private Int32? _MALLAENCUESTA_ESTADO;
        private Int32? _ENCUESTA_ESTADO;
        private Int32 _EmpresaId;
        private String _JefeDirectoId;
        private String _PersonaId;
        private String _AlumnoId;
        private String _ALUMNO_NOMBRES;
        private String _ALUMNO_APELLIDOS;
        private String _FECHAINICIO;              
        private String _FECHAFIN;       
        private Int32? _TotalHoras;
        private String _TipoRegistro;
        private String _JEFEDIRECTO_NOMBRES;
        private String _JEFEDIRECTO_APELLIDOS;
        private String _RazonSocial;
        private String _Telefono1;
        private String _RUC;       
        private String _Direccion;        
        private String _Cargo;
        private String _NroDocumento;
        private String _Anexo;
        private String _Comentario;
        private String _FechaRegistroJefe;
        private String _Nombre;
        private List<CompetenciaAbetxEncuestaDC> _Competencias;

        [DataMember]
        public String Telefono1
        {
            get { return _Telefono1; }
            set { _Telefono1 = value; }
        }

        [DataMember]
        public List<CompetenciaAbetxEncuestaDC> Competencias
        {
            get { return _Competencias; }
            set { _Competencias = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DataMember]
        public String FechaRegistroJefe
        {
            get { return _FechaRegistroJefe; }
            set { _FechaRegistroJefe = value; }
        }

        [DataMember]
        public String Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; }
        }

        [DataMember]
        public String Anexo
        {
            get { return _Anexo; }
            set { _Anexo = value; }
        }

        [DataMember]
        public String NroDocumento
        {
            get { return _NroDocumento; }
            set { _NroDocumento = value; }
        }

        [DataMember]
        public String Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        [DataMember]
        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        [DataMember]
        public String RUC
        {
            get { return _RUC; }
            set { _RUC = value; }
        }

        [DataMember]
        public String FECHAFIN
        {
            get { return _FECHAFIN; }
            set { _FECHAFIN = value; }
        }

        [DataMember]
        public String FECHAINICIO
        {
            get { return _FECHAINICIO; }
            set { _FECHAINICIO = value; }
        }

        [DataMember]
        public Int32? ENCUESTA_ESTADO
        {
            get { return _ENCUESTA_ESTADO; }
            set { _ENCUESTA_ESTADO = value; }
        }

        [DataMember]
        public String JefeDirectoId
        {
            get { return _JefeDirectoId; }
            set { _JefeDirectoId = value; }
        }

        [DataMember]
        public String MALLAENCUESTA_NOMBRE
        {
            get { return _MALLAENCUESTA_NOMBRE; }
            set { _MALLAENCUESTA_NOMBRE = value; }
        }

        [DataMember]
        public Int32? MALLAENCUESTA_ESTADO
        {
            get { return _MALLAENCUESTA_ESTADO; }
            set { _MALLAENCUESTA_ESTADO = value; }
        }

        [DataMember]
        public Int32 EmpresaId
        {
            get { return _EmpresaId; }
            set { _EmpresaId = value; }
        }

        [DataMember]
        public String PersonaId
        {
            get { return _PersonaId; }
            set { _PersonaId = value; }
        }

        [DataMember]
        public String AlumnoId
        {
            get { return _AlumnoId; }
            set { _AlumnoId = value; }
        }

        [DataMember]
        public String ALUMNO_NOMBRES
        {
            get { return _ALUMNO_NOMBRES; }
            set { _ALUMNO_NOMBRES = value; }
        }

        [DataMember]
        public String ALUMNO_APELLIDOS
        {
            get { return _ALUMNO_APELLIDOS; }
            set { _ALUMNO_APELLIDOS = value; }
        }

        [DataMember]
        public Int32? TotalHoras
        {
            get { return _TotalHoras; }
            set { _TotalHoras = value; }
        }

        [DataMember]
        public String TipoRegistro
        {
            get { return _TipoRegistro; }
            set { _TipoRegistro = value; }
        }

        [DataMember]
        public String JEFEDIRECTO_NOMBRES
        {
            get { return _JEFEDIRECTO_NOMBRES; }
            set { _JEFEDIRECTO_NOMBRES = value; }
        }

        [DataMember]
        public String JEFEDIRECTO_APELLIDOS
        {
            get { return _JEFEDIRECTO_APELLIDOS; }
            set { _JEFEDIRECTO_APELLIDOS = value; }
        }

        [DataMember]
        public String RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public Int32 MallaEncuestaId
        {
            get { return _MallaEncuestaId; }
            set { _MallaEncuestaId = value; }
        }

        [DataMember]
        public Int32 CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        [DataMember]
        public Int32 PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        [DataMember]
        public Int32 PracticaPreProfesionalId
        {
            get { return _PracticaPreProfesionalId; }
            set { _PracticaPreProfesionalId = value; }
        }

        [DataMember]
        public Int32 EncuestaId
        {
            get { return _EncuestaId; }
            set { _EncuestaId = value; }
        }

    }

    [DataContract]
    public class EncuestaFechasDC
    {
        private String _FechaInicio;
        private String _FechaFin;

        [DataMember]
        public String FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }

        [DataMember]
        public String FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }
    }
}
    