using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    #region metodosGPPP

    [DataContract]
    public class PracticaPreProfesionalDC
    {
        private Int32 _PracticaPreProfesionalId;
        private Int32 _PeriodoId;
        private String _Descripcion;
        private Int32 _CarreraId;
        private String _NombreCarrera;
        private Int32? _Numero;
        private String _Nombre;
        private String _NombreInforme;
        private Int32? _CreditosACumplirInicio;
        private Int32? _CreditosACumplirFin;
        private Int32? _MinimoCreditosInicio;
        private Int32? _MinimoCreditosFin;
        private Int32? _CreditosACumplirMaximo;
        private String _FechaRegistro;
        private String _FechaModificacion;
        private Int32? _Estado;

        [DataMember]
        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DataMember]
        public String FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }

        [DataMember]
        public String FechaModificacion
        {
            get { return _FechaModificacion; }
            set { _FechaModificacion = value; }
        }

        [DataMember]
        public Int32? Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        [DataMember]
        public String NombreInforme
        {
            get { return _NombreInforme; }
            set { _NombreInforme = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DataMember]
        public Int32? Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        [DataMember]
        public Int32? MinimoCreditosInicio
        {
            get { return _MinimoCreditosInicio; }
            set { _MinimoCreditosInicio = value; }
        }

        [DataMember]
        public Int32? MinimoCreditosFin
        {
            get { return _MinimoCreditosFin; }
            set { _MinimoCreditosFin = value; }
        }

        [DataMember]
        public Int32? CreditosACumplirInicio
        {
            get { return _CreditosACumplirInicio; }
            set { _CreditosACumplirInicio = value; }
        }

        [DataMember]
        public Int32? CreditosACumplirFin
        {
            get { return _CreditosACumplirFin; }
            set { _CreditosACumplirFin = value; }
        }

        [DataMember]
        public Int32? CreditosACumplirMaximo
        {
            get { return _CreditosACumplirMaximo; }
            set { _CreditosACumplirMaximo = value; }
        }

        [DataMember]
        public String NombreCarrera
        {
            get { return _NombreCarrera; }
            set { _NombreCarrera = value; }
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
    }

    #endregion
}
