﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.IFCDC.UI.InformeFinCicloWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InformeFinCicloDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class InformeFinCicloDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComentarioAlumnosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComentarioDelegadosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComentarioEncuestaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComentarioInfraestructuraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoordinadorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CursoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DesarrolloUnidadesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InformeFinCicloIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PeriodoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UltimaActualizacionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ComentarioAlumnos {
            get {
                return this.ComentarioAlumnosField;
            }
            set {
                if ((object.ReferenceEquals(this.ComentarioAlumnosField, value) != true)) {
                    this.ComentarioAlumnosField = value;
                    this.RaisePropertyChanged("ComentarioAlumnos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ComentarioDelegados {
            get {
                return this.ComentarioDelegadosField;
            }
            set {
                if ((object.ReferenceEquals(this.ComentarioDelegadosField, value) != true)) {
                    this.ComentarioDelegadosField = value;
                    this.RaisePropertyChanged("ComentarioDelegados");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ComentarioEncuesta {
            get {
                return this.ComentarioEncuestaField;
            }
            set {
                if ((object.ReferenceEquals(this.ComentarioEncuestaField, value) != true)) {
                    this.ComentarioEncuestaField = value;
                    this.RaisePropertyChanged("ComentarioEncuesta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ComentarioInfraestructura {
            get {
                return this.ComentarioInfraestructuraField;
            }
            set {
                if ((object.ReferenceEquals(this.ComentarioInfraestructuraField, value) != true)) {
                    this.ComentarioInfraestructuraField = value;
                    this.RaisePropertyChanged("ComentarioInfraestructura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CoordinadorId {
            get {
                return this.CoordinadorIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CoordinadorIdField, value) != true)) {
                    this.CoordinadorIdField = value;
                    this.RaisePropertyChanged("CoordinadorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CursoId {
            get {
                return this.CursoIdField;
            }
            set {
                if ((this.CursoIdField.Equals(value) != true)) {
                    this.CursoIdField = value;
                    this.RaisePropertyChanged("CursoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DesarrolloUnidades {
            get {
                return this.DesarrolloUnidadesField;
            }
            set {
                if ((object.ReferenceEquals(this.DesarrolloUnidadesField, value) != true)) {
                    this.DesarrolloUnidadesField = value;
                    this.RaisePropertyChanged("DesarrolloUnidades");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InformeFinCicloId {
            get {
                return this.InformeFinCicloIdField;
            }
            set {
                if ((this.InformeFinCicloIdField.Equals(value) != true)) {
                    this.InformeFinCicloIdField = value;
                    this.RaisePropertyChanged("InformeFinCicloId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PeriodoId {
            get {
                return this.PeriodoIdField;
            }
            set {
                if ((this.PeriodoIdField.Equals(value) != true)) {
                    this.PeriodoIdField = value;
                    this.RaisePropertyChanged("PeriodoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UltimaActualizacion {
            get {
                return this.UltimaActualizacionField;
            }
            set {
                if ((object.ReferenceEquals(this.UltimaActualizacionField, value) != true)) {
                    this.UltimaActualizacionField = value;
                    this.RaisePropertyChanged("UltimaActualizacion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InformeFinCicloReporteCollectionDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class InformeFinCicloReporteCollectionDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloReporteDC[] LstInformeFinCicloReporteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloReporteDC[] LstInformeFinCicloReporte {
            get {
                return this.LstInformeFinCicloReporteField;
            }
            set {
                if ((object.ReferenceEquals(this.LstInformeFinCicloReporteField, value) != true)) {
                    this.LstInformeFinCicloReporteField = value;
                    this.RaisePropertyChanged("LstInformeFinCicloReporte");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InformeFinCicloReporteDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class InformeFinCicloReporteDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoCursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaActualizacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InformeFinCicloIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreProfesorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PeriodoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoCurso {
            get {
                return this.CodigoCursoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoCursoField, value) != true)) {
                    this.CodigoCursoField = value;
                    this.RaisePropertyChanged("CodigoCurso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaActualizacion {
            get {
                return this.FechaActualizacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaActualizacionField, value) != true)) {
                    this.FechaActualizacionField = value;
                    this.RaisePropertyChanged("FechaActualizacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InformeFinCicloId {
            get {
                return this.InformeFinCicloIdField;
            }
            set {
                if ((this.InformeFinCicloIdField.Equals(value) != true)) {
                    this.InformeFinCicloIdField = value;
                    this.RaisePropertyChanged("InformeFinCicloId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCurso {
            get {
                return this.NombreCursoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCursoField, value) != true)) {
                    this.NombreCursoField = value;
                    this.RaisePropertyChanged("NombreCurso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreProfesor {
            get {
                return this.NombreProfesorField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreProfesorField, value) != true)) {
                    this.NombreProfesorField = value;
                    this.RaisePropertyChanged("NombreProfesor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Periodo {
            get {
                return this.PeriodoField;
            }
            set {
                if ((object.ReferenceEquals(this.PeriodoField, value) != true)) {
                    this.PeriodoField = value;
                    this.RaisePropertyChanged("Periodo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InformeFinCicloWS.IInformeFinCiclo")]
    public interface IInformeFinCiclo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformeFinCiclo/WSObtenerInformeFinCicloxId", ReplyAction="http://tempuri.org/IInformeFinCiclo/WSObtenerInformeFinCicloxIdResponse")]
        UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloDC WSObtenerInformeFinCicloxId(int informeFinCicloId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformeFinCiclo/WSObtenerInformeFinCiclo", ReplyAction="http://tempuri.org/IInformeFinCiclo/WSObtenerInformeFinCicloResponse")]
        UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloDC WSObtenerInformeFinCiclo(string coordinadorId, int cursoId, int periodoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformeFinCiclo/WSEditarInformeFinCiclo", ReplyAction="http://tempuri.org/IInformeFinCiclo/WSEditarInformeFinCicloResponse")]
        UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloDC WSEditarInformeFinCiclo(int informeFinCicloId, string estado, string desarrolloUnidades, string infraestructura, string alumnos, string delegados, string encuesta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformeFinCiclo/WSListarInformeFinCicloReporte", ReplyAction="http://tempuri.org/IInformeFinCiclo/WSListarInformeFinCicloReporteResponse")]
        UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloReporteCollectionDC WSListarInformeFinCicloReporte(int cursoId, int periodoId, string estado);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInformeFinCicloChannel : UPC.IFCDC.UI.InformeFinCicloWS.IInformeFinCiclo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InformeFinCicloClient : System.ServiceModel.ClientBase<UPC.IFCDC.UI.InformeFinCicloWS.IInformeFinCiclo>, UPC.IFCDC.UI.InformeFinCicloWS.IInformeFinCiclo {
        
        public InformeFinCicloClient() {
        }
        
        public InformeFinCicloClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InformeFinCicloClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InformeFinCicloClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InformeFinCicloClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloDC WSObtenerInformeFinCicloxId(int informeFinCicloId) {
            return base.Channel.WSObtenerInformeFinCicloxId(informeFinCicloId);
        }
        
        public UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloDC WSObtenerInformeFinCiclo(string coordinadorId, int cursoId, int periodoId) {
            return base.Channel.WSObtenerInformeFinCiclo(coordinadorId, cursoId, periodoId);
        }
        
        public UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloDC WSEditarInformeFinCiclo(int informeFinCicloId, string estado, string desarrolloUnidades, string infraestructura, string alumnos, string delegados, string encuesta) {
            return base.Channel.WSEditarInformeFinCiclo(informeFinCicloId, estado, desarrolloUnidades, infraestructura, alumnos, delegados, encuesta);
        }
        
        public UPC.IFCDC.UI.InformeFinCicloWS.InformeFinCicloReporteCollectionDC WSListarInformeFinCicloReporte(int cursoId, int periodoId, string estado) {
            return base.Channel.WSListarInformeFinCicloReporte(cursoId, periodoId, estado);
        }
    }
}