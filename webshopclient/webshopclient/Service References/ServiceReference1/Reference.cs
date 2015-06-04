﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webshopclient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clothes", Namespace="http://schemas.datacontract.org/2004/07/WashSystem")]
    [System.SerializableAttribute()]
    public partial class Clothes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private webshopclient.ServiceReference1.ClothesTypes ClothesTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private webshopclient.ServiceReference1.Detergents DetergentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private webshopclient.ServiceReference1.Locations LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxTempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private webshopclient.ServiceReference1.WashTypes WashTypeField;
        
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
        public webshopclient.ServiceReference1.ClothesTypes ClothesType {
            get {
                return this.ClothesTypeField;
            }
            set {
                if ((this.ClothesTypeField.Equals(value) != true)) {
                    this.ClothesTypeField = value;
                    this.RaisePropertyChanged("ClothesType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public webshopclient.ServiceReference1.Detergents Detergent {
            get {
                return this.DetergentField;
            }
            set {
                if ((this.DetergentField.Equals(value) != true)) {
                    this.DetergentField = value;
                    this.RaisePropertyChanged("Detergent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Info {
            get {
                return this.InfoField;
            }
            set {
                if ((object.ReferenceEquals(this.InfoField, value) != true)) {
                    this.InfoField = value;
                    this.RaisePropertyChanged("Info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public webshopclient.ServiceReference1.Locations Location {
            get {
                return this.LocationField;
            }
            set {
                if ((this.LocationField.Equals(value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxTemp {
            get {
                return this.MaxTempField;
            }
            set {
                if ((this.MaxTempField.Equals(value) != true)) {
                    this.MaxTempField = value;
                    this.RaisePropertyChanged("MaxTemp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public webshopclient.ServiceReference1.WashTypes WashType {
            get {
                return this.WashTypeField;
            }
            set {
                if ((this.WashTypeField.Equals(value) != true)) {
                    this.WashTypeField = value;
                    this.RaisePropertyChanged("WashType");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClothesTypes", Namespace="http://schemas.datacontract.org/2004/07/WashSystem")]
    public enum ClothesTypes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pants = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sweater = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Vest = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Shirt = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Socks = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Underwear = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Detergents", Namespace="http://schemas.datacontract.org/2004/07/WashSystem")]
    public enum Detergents : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Black = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Super = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Normal = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Natural = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        White = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Colors = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Locations", Namespace="http://schemas.datacontract.org/2004/07/WashSystem")]
    public enum Locations : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Washer = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LaundryBasket = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Elsewhere = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WashTypes", Namespace="http://schemas.datacontract.org/2004/07/WashSystem")]
    public enum WashTypes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Coloureds = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WhiteWash = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Delicates = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HandWash = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WoolWax = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/x", ReplyAction="http://tempuri.org/IService1/xResponse")]
        webshopclient.ServiceReference1.ClothesTypes x(webshopclient.ServiceReference1.Clothes clothes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/x", ReplyAction="http://tempuri.org/IService1/xResponse")]
        System.Threading.Tasks.Task<webshopclient.ServiceReference1.ClothesTypes> xAsync(webshopclient.ServiceReference1.Clothes clothes);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : webshopclient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<webshopclient.ServiceReference1.IService1>, webshopclient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public webshopclient.ServiceReference1.ClothesTypes x(webshopclient.ServiceReference1.Clothes clothes) {
            return base.Channel.x(clothes);
        }
        
        public System.Threading.Tasks.Task<webshopclient.ServiceReference1.ClothesTypes> xAsync(webshopclient.ServiceReference1.Clothes clothes) {
            return base.Channel.xAsync(clothes);
        }
    }
}