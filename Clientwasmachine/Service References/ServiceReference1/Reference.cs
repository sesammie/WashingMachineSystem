﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication13.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Garments", Namespace="http://schemas.datacontract.org/2004/07/WashSystem")]
    [System.SerializableAttribute()]
    public partial class Garments : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GarmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxTempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProgramField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeightField;
        
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
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GarmentId {
            get {
                return this.GarmentIdField;
            }
            set {
                if ((this.GarmentIdField.Equals(value) != true)) {
                    this.GarmentIdField = value;
                    this.RaisePropertyChanged("GarmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
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
        public string Program {
            get {
                return this.ProgramField;
            }
            set {
                if ((object.ReferenceEquals(this.ProgramField, value) != true)) {
                    this.ProgramField = value;
                    this.RaisePropertyChanged("Program");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((this.WeightField.Equals(value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Programs", Namespace="http://schemas.datacontract.org/2004/07/WashSystem")]
    [System.SerializableAttribute()]
    public partial class Programs : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CentrifugingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxWeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NormalDurationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ShortDurationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TemperatureField;
        
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
        public int Centrifuging {
            get {
                return this.CentrifugingField;
            }
            set {
                if ((this.CentrifugingField.Equals(value) != true)) {
                    this.CentrifugingField = value;
                    this.RaisePropertyChanged("Centrifuging");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxWeight {
            get {
                return this.MaxWeightField;
            }
            set {
                if ((this.MaxWeightField.Equals(value) != true)) {
                    this.MaxWeightField = value;
                    this.RaisePropertyChanged("MaxWeight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NormalDuration {
            get {
                return this.NormalDurationField;
            }
            set {
                if ((this.NormalDurationField.Equals(value) != true)) {
                    this.NormalDurationField = value;
                    this.RaisePropertyChanged("NormalDuration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ShortDuration {
            get {
                return this.ShortDurationField;
            }
            set {
                if ((this.ShortDurationField.Equals(value) != true)) {
                    this.ShortDurationField = value;
                    this.RaisePropertyChanged("ShortDuration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((this.TemperatureField.Equals(value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllGermants", ReplyAction="http://tempuri.org/IService1/GetAllGermantsResponse")]
        WindowsFormsApplication13.ServiceReference1.Garments[] GetAllGermants();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllGermants", ReplyAction="http://tempuri.org/IService1/GetAllGermantsResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication13.ServiceReference1.Garments[]> GetAllGermantsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPrograms", ReplyAction="http://tempuri.org/IService1/GetAllProgramsResponse")]
        WindowsFormsApplication13.ServiceReference1.Programs[] GetAllPrograms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPrograms", ReplyAction="http://tempuri.org/IService1/GetAllProgramsResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication13.ServiceReference1.Programs[]> GetAllProgramsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddGermant", ReplyAction="http://tempuri.org/IService1/AddGermantResponse")]
        bool AddGermant();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddGermant", ReplyAction="http://tempuri.org/IService1/AddGermantResponse")]
        System.Threading.Tasks.Task<bool> AddGermantAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateGermantLocation", ReplyAction="http://tempuri.org/IService1/UpdateGermantLocationResponse")]
        bool UpdateGermantLocation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateGermantLocation", ReplyAction="http://tempuri.org/IService1/UpdateGermantLocationResponse")]
        System.Threading.Tasks.Task<bool> UpdateGermantLocationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortGarments", ReplyAction="http://tempuri.org/IService1/SortGarmentsResponse")]
        string SortGarments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortGarments", ReplyAction="http://tempuri.org/IService1/SortGarmentsResponse")]
        System.Threading.Tasks.Task<string> SortGarmentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApplication13.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApplication13.ServiceReference1.IService1>, WindowsFormsApplication13.ServiceReference1.IService1 {
        
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
        
        public WindowsFormsApplication13.ServiceReference1.Garments[] GetAllGermants() {
            return base.Channel.GetAllGermants();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication13.ServiceReference1.Garments[]> GetAllGermantsAsync() {
            return base.Channel.GetAllGermantsAsync();
        }
        
        public WindowsFormsApplication13.ServiceReference1.Programs[] GetAllPrograms() {
            return base.Channel.GetAllPrograms();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication13.ServiceReference1.Programs[]> GetAllProgramsAsync() {
            return base.Channel.GetAllProgramsAsync();
        }
        
        public bool AddGermant() {
            return base.Channel.AddGermant();
        }
        
        public System.Threading.Tasks.Task<bool> AddGermantAsync() {
            return base.Channel.AddGermantAsync();
        }
        
        public bool UpdateGermantLocation() {
            return base.Channel.UpdateGermantLocation();
        }
        
        public System.Threading.Tasks.Task<bool> UpdateGermantLocationAsync() {
            return base.Channel.UpdateGermantLocationAsync();
        }
        
        public string SortGarments() {
            return base.Channel.SortGarments();
        }
        
        public System.Threading.Tasks.Task<string> SortGarmentsAsync() {
            return base.Channel.SortGarmentsAsync();
        }
    }
}