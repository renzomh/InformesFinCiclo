using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    #region metodos GPPP
    [DataContract]
    public class AlumnoDC
    {
        private String _AlumnoId;
        private String _Nombres;
        private String _Apellidos;
        private Int32? _CarreraId;
        private String _CarreraNombre;
        private Int32? _PeriodoId;
        private String _Descripcion;
        private Int32 _PracticaPreProfesionalId;
        private String _PPPNombre;
        private Int32? _CreditosAprobados;
        private Int32? _CreditosPPPCumplidos;
        private Int32? _Estado;

        [DataMember]
        public Int32? Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
                
        [DataMember]
        public Int32? CreditosPPPCumplidos
        {
            get { return _CreditosPPPCumplidos; }
            set { _CreditosPPPCumplidos = value; }
        }

        [DataMember]
        public Int32? CreditosAprobados
        {
            get { return _CreditosAprobados; }
            set { _CreditosAprobados = value; }
        }

        [DataMember]
        public String PPPNombre
        {
            get { return _PPPNombre; }
            set { _PPPNombre = value; }
        }

        [DataMember]
        public Int32 PracticaPreProfesionalId
        {
            get { return _PracticaPreProfesionalId; }
            set { _PracticaPreProfesionalId = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public Int32? PeriodoId
        {
            get { return _PeriodoId; }
            set { _PeriodoId = value; }
        }

        [DataMember]
        public String CarreraNombre
        {
            get { return _CarreraNombre; }
            set { _CarreraNombre = value; }
        }

        [DataMember]
        public Int32? CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }

        [DataMember]
        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        [DataMember]
        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        [DataMember]
        public String AlumnoId
        {
            get { return _AlumnoId; }
            set { _AlumnoId = value; }
        }
    }
    #endregion
}
