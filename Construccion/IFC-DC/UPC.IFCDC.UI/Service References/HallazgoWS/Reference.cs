﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.IFCDC.UI.HallazgoWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HallazgoCollectionDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class HallazgoCollectionDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UPC.IFCDC.UI.HallazgoWS.HallazgoDC[] LstHallazgosField;
        
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
        public UPC.IFCDC.UI.HallazgoWS.HallazgoDC[] LstHallazgos {
            get {
                return this.LstHallazgosField;
            }
            set {
                if ((object.ReferenceEquals(this.LstHallazgosField, value) != true)) {
                    this.LstHallazgosField = value;
                    this.RaisePropertyChanged("LstHallazgos");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HallazgoDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class HallazgoDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HallazgoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InformeFinCicloIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PeriodoIdField;
        
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
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HallazgoId {
            get {
                return this.HallazgoIdField;
            }
            set {
                if ((this.HallazgoIdField.Equals(value) != true)) {
                    this.HallazgoIdField = value;
                    this.RaisePropertyChanged("HallazgoId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HallazgoReporteCollectionDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class HallazgoReporteCollectionDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UPC.IFCDC.UI.HallazgoWS.HallazgoReporteDC[] LstHallazgoReporteField;
        
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
        public UPC.IFCDC.UI.HallazgoWS.HallazgoReporteDC[] LstHallazgoReporte {
            get {
                return this.LstHallazgoReporteField;
            }
            set {
                if ((object.ReferenceEquals(this.LstHallazgoReporteField, value) != true)) {
                    this.LstHallazgoReporteField = value;
                    this.RaisePropertyChanged("LstHallazgoReporte");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HallazgoReporteDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class HallazgoReporteDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoHallazgoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HallazogIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCursoField;
        
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
        public string CodigoHallazgo {
            get {
                return this.CodigoHallazgoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoHallazgoField, value) != true)) {
                    this.CodigoHallazgoField = value;
                    this.RaisePropertyChanged("CodigoHallazgo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HallazogId {
            get {
                return this.HallazogIdField;
            }
            set {
                if ((this.HallazogIdField.Equals(value) != true)) {
                    this.HallazogIdField = value;
                    this.RaisePropertyChanged("HallazogId");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HallazgoWS.IHallazgo")]
    public interface IHallazgo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHallazgo/WSRegistrarHallazgo", ReplyAction="http://tempuri.org/IHallazgo/WSRegistrarHallazgoResponse")]
        UPC.IFCDC.UI.HallazgoWS.HallazgoCollectionDC WSRegistrarHallazgo(int informeFinCicloId, string descripcion, int periodoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHallazgo/WSListarHallazgosxInformeFinCiclo", ReplyAction="http://tempuri.org/IHallazgo/WSListarHallazgosxInformeFinCicloResponse")]
        UPC.IFCDC.UI.HallazgoWS.HallazgoCollectionDC WSListarHallazgosxInformeFinCiclo(int informeFinCicloId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHallazgo/WSEditarHallazgo", ReplyAction="http://tempuri.org/IHallazgo/WSEditarHallazgoResponse")]
        UPC.IFCDC.UI.HallazgoWS.HallazgoCollectionDC WSEditarHallazgo(int hallazgoId, int informeFinCicloId, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHallazgo/WSEliminarHallazgo", ReplyAction="http://tempuri.org/IHallazgo/WSEliminarHallazgoResponse")]
        UPC.IFCDC.UI.HallazgoWS.HallazgoCollectionDC WSEliminarHallazgo(int hallazgoId, int informeFinCicloId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHallazgo/WSListarHallazgoReporte", ReplyAction="http://tempuri.org/IHallazgo/WSListarHallazgoReporteResponse")]
        UPC.IFCDC.UI.HallazgoWS.HallazgoReporteCollectionDC WSListarHallazgoReporte(int cursoId, int periodoId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHallazgoChannel : UPC.IFCDC.UI.HallazgoWS.IHallazgo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HallazgoClient : System.ServiceModel.ClientBase<UPC.IFCDC.UI.HallazgoWS.IHallazgo>, UPC.IFCDC.UI.HallazgoWS.IHallazgo {
        
        public HallazgoClient() {
        }
        
        public HallazgoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HallazgoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HallazgoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HallazgoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UPC.IFCDC.UI.HallazgoWS.HallazgoCollectionDC WSRegistrarHallazgo(int informeFinCicloId, string descripcion, int periodoId) {
            return base.Channel.WSRegistrarHallazgo(informeFinCicloId, descripcion, periodoId);
        }
        
        public UPC.IFCDC.UI.HallazgoWS.HallazgoCollectionDC WSListarHallazgosxInformeFinCiclo(int informeFinCicloId) {
            return base.Channel.WSListarHallazgosxInformeFinCiclo(informeFinCicloId);
        }
        
        public UPC.IFCDC.UI.HallazgoWS.HallazgoCollectionDC WSEditarHallazgo(int hallazgoId, int informeFinCicloId, string descripcion) {
            return base.Channel.WSEditarHallazgo(hallazgoId, informeFinCicloId, descripcion);
        }
        
        public UPC.IFCDC.UI.HallazgoWS.HallazgoCollectionDC WSEliminarHallazgo(int hallazgoId, int informeFinCicloId) {
            return base.Channel.WSEliminarHallazgo(hallazgoId, informeFinCicloId);
        }
        
        public UPC.IFCDC.UI.HallazgoWS.HallazgoReporteCollectionDC WSListarHallazgoReporte(int cursoId, int periodoId) {
            return base.Channel.WSListarHallazgoReporte(cursoId, periodoId);
        }
    }
}
