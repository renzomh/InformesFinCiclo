﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.CarreraWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CarreraCollectionDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract", ItemName="CarreraDC")]
    [System.SerializableAttribute()]
    public class CarreraCollectionDC : System.Collections.Generic.List<ConsoleApplication1.CarreraWS.CarreraDC> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarreraDC", Namespace="http://schemas.datacontract.org/2004/07/UPC.SSIA2013.WS.DataContract")]
    [System.SerializableAttribute()]
    public partial class CarreraDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarreraIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarreraNombreField;
        
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
        public int CarreraId {
            get {
                return this.CarreraIdField;
            }
            set {
                if ((this.CarreraIdField.Equals(value) != true)) {
                    this.CarreraIdField = value;
                    this.RaisePropertyChanged("CarreraId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CarreraNombre {
            get {
                return this.CarreraNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.CarreraNombreField, value) != true)) {
                    this.CarreraNombreField = value;
                    this.RaisePropertyChanged("CarreraNombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarreraWS.ICarrera")]
    public interface ICarrera {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarrera/ListarCarreras", ReplyAction="http://tempuri.org/ICarrera/ListarCarrerasResponse")]
        ConsoleApplication1.CarreraWS.CarreraCollectionDC ListarCarreras();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarreraChannel : ConsoleApplication1.CarreraWS.ICarrera, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarreraClient : System.ServiceModel.ClientBase<ConsoleApplication1.CarreraWS.ICarrera>, ConsoleApplication1.CarreraWS.ICarrera {
        
        public CarreraClient() {
        }
        
        public CarreraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarreraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarreraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarreraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleApplication1.CarreraWS.CarreraCollectionDC ListarCarreras() {
            return base.Channel.ListarCarreras();
        }
    }
}