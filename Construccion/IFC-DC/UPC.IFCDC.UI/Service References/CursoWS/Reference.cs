﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.IFCDC.UI.CursoWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CursoCollectionDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract", ItemName="CursoDC")]
    [System.SerializableAttribute()]
    public class CursoCollectionDC : System.Collections.Generic.List<UPC.IFCDC.UI.CursoWS.CursoDC> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CursoDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class CursoDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CursoControlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CursoCreditosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CursoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CursoVerificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CursoControl {
            get {
                return this.CursoControlField;
            }
            set {
                if ((this.CursoControlField.Equals(value) != true)) {
                    this.CursoControlField = value;
                    this.RaisePropertyChanged("CursoControl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CursoCreditos {
            get {
                return this.CursoCreditosField;
            }
            set {
                if ((this.CursoCreditosField.Equals(value) != true)) {
                    this.CursoCreditosField = value;
                    this.RaisePropertyChanged("CursoCreditos");
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
        public bool CursoVerificacion {
            get {
                return this.CursoVerificacionField;
            }
            set {
                if ((this.CursoVerificacionField.Equals(value) != true)) {
                    this.CursoVerificacionField = value;
                    this.RaisePropertyChanged("CursoVerificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CursoxProfesorCollectionDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class CursoxProfesorCollectionDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UPC.IFCDC.UI.CursoWS.CursoxProfesorDC[] LstCursosxProfesorField;
        
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
        public UPC.IFCDC.UI.CursoWS.CursoxProfesorDC[] LstCursosxProfesor {
            get {
                return this.LstCursosxProfesorField;
            }
            set {
                if ((object.ReferenceEquals(this.LstCursosxProfesorField, value) != true)) {
                    this.LstCursosxProfesorField = value;
                    this.RaisePropertyChanged("LstCursosxProfesor");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CursoxProfesorDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class CursoxProfesorDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CursoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProfesorIdField;
        
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
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
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
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProfesorId {
            get {
                return this.ProfesorIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfesorIdField, value) != true)) {
                    this.ProfesorIdField = value;
                    this.RaisePropertyChanged("ProfesorId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CursoWS.ICurso")]
    public interface ICurso {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurso/ListarCursosPorTipoCursoCarreraId", ReplyAction="http://tempuri.org/ICurso/ListarCursosPorTipoCursoCarreraIdResponse")]
        UPC.IFCDC.UI.CursoWS.CursoCollectionDC ListarCursosPorTipoCursoCarreraId(int CarreraId, int TipoCurso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurso/ListarCursosPorCarreraPorNivelPorPeriodoActual", ReplyAction="http://tempuri.org/ICurso/ListarCursosPorCarreraPorNivelPorPeriodoActualResponse")]
        UPC.IFCDC.UI.CursoWS.CursoCollectionDC ListarCursosPorCarreraPorNivelPorPeriodoActual(int CarreraId, int nivel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurso/ActualizarCursosPorCarreraPorNivelPorPeriodoActual", ReplyAction="http://tempuri.org/ICurso/ActualizarCursosPorCarreraPorNivelPorPeriodoActualRespo" +
            "nse")]
        void ActualizarCursosPorCarreraPorNivelPorPeriodoActual(int cursoId, bool esControl, bool esVerificacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurso/ListarCursos", ReplyAction="http://tempuri.org/ICurso/ListarCursosResponse")]
        UPC.IFCDC.UI.CursoWS.CursoCollectionDC ListarCursos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurso/ListarCursosxProfesor", ReplyAction="http://tempuri.org/ICurso/ListarCursosxProfesorResponse")]
        UPC.IFCDC.UI.CursoWS.CursoxProfesorCollectionDC ListarCursosxProfesor(string profesorId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICursoChannel : UPC.IFCDC.UI.CursoWS.ICurso, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CursoClient : System.ServiceModel.ClientBase<UPC.IFCDC.UI.CursoWS.ICurso>, UPC.IFCDC.UI.CursoWS.ICurso {
        
        public CursoClient() {
        }
        
        public CursoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CursoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UPC.IFCDC.UI.CursoWS.CursoCollectionDC ListarCursosPorTipoCursoCarreraId(int CarreraId, int TipoCurso) {
            return base.Channel.ListarCursosPorTipoCursoCarreraId(CarreraId, TipoCurso);
        }
        
        public UPC.IFCDC.UI.CursoWS.CursoCollectionDC ListarCursosPorCarreraPorNivelPorPeriodoActual(int CarreraId, int nivel) {
            return base.Channel.ListarCursosPorCarreraPorNivelPorPeriodoActual(CarreraId, nivel);
        }
        
        public void ActualizarCursosPorCarreraPorNivelPorPeriodoActual(int cursoId, bool esControl, bool esVerificacion) {
            base.Channel.ActualizarCursosPorCarreraPorNivelPorPeriodoActual(cursoId, esControl, esVerificacion);
        }
        
        public UPC.IFCDC.UI.CursoWS.CursoCollectionDC ListarCursos() {
            return base.Channel.ListarCursos();
        }
        
        public UPC.IFCDC.UI.CursoWS.CursoxProfesorCollectionDC ListarCursosxProfesor(string profesorId) {
            return base.Channel.ListarCursosxProfesor(profesorId);
        }
    }
}