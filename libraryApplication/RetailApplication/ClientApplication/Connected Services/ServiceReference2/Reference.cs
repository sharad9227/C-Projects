﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplication.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/RetailApplication")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Commodity", Namespace="http://schemas.datacontract.org/2004/07/RetailApplication")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientApplication.ServiceReference2.Laptop))]
    public partial class Commodity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string brandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int sizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeReferenceField;
        
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
        public string brand {
            get {
                return this.brandField;
            }
            set {
                if ((object.ReferenceEquals(this.brandField, value) != true)) {
                    this.brandField = value;
                    this.RaisePropertyChanged("brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idNum {
            get {
                return this.idNumField;
            }
            set {
                if ((this.idNumField.Equals(value) != true)) {
                    this.idNumField = value;
                    this.RaisePropertyChanged("idNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int size {
            get {
                return this.sizeField;
            }
            set {
                if ((this.sizeField.Equals(value) != true)) {
                    this.sizeField = value;
                    this.RaisePropertyChanged("size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string typeReference {
            get {
                return this.typeReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.typeReferenceField, value) != true)) {
                    this.typeReferenceField = value;
                    this.RaisePropertyChanged("typeReference");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Laptop", Namespace="http://schemas.datacontract.org/2004/07/RetailApplication")]
    [System.SerializableAttribute()]
    public partial class Laptop : ClientApplication.ServiceReference2.Commodity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPUField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPU {
            get {
                return this.CPUField;
            }
            set {
                if ((object.ReferenceEquals(this.CPUField, value) != true)) {
                    this.CPUField = value;
                    this.RaisePropertyChanged("CPU");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ClientApplication.ServiceReference2.CompositeType GetDataUsingDataContract(ClientApplication.ServiceReference2.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference2.CompositeType> GetDataUsingDataContractAsync(ClientApplication.ServiceReference2.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCommodityByTypeNo", ReplyAction="http://tempuri.org/IService1/GetCommodityByTypeNoResponse")]
        string GetCommodityByTypeNo(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCommodityByTypeNo", ReplyAction="http://tempuri.org/IService1/GetCommodityByTypeNoResponse")]
        System.Threading.Tasks.Task<string> GetCommodityByTypeNoAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCommodityByTypeFeature", ReplyAction="http://tempuri.org/IService1/GetCommodityByTypeFeatureResponse")]
        string GetCommodityByTypeFeature(int Type, string features);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCommodityByTypeFeature", ReplyAction="http://tempuri.org/IService1/GetCommodityByTypeFeatureResponse")]
        System.Threading.Tasks.Task<string> GetCommodityByTypeFeatureAsync(int Type, string features);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCommodity", ReplyAction="http://tempuri.org/IService1/AddCommodityResponse")]
        bool AddCommodity(ClientApplication.ServiceReference2.Commodity commodity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCommodity", ReplyAction="http://tempuri.org/IService1/AddCommodityResponse")]
        System.Threading.Tasks.Task<bool> AddCommodityAsync(ClientApplication.ServiceReference2.Commodity commodity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllLaptops", ReplyAction="http://tempuri.org/IService1/getAllLaptopsResponse")]
        ClientApplication.ServiceReference2.Laptop[] getAllLaptops();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllLaptops", ReplyAction="http://tempuri.org/IService1/getAllLaptopsResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference2.Laptop[]> getAllLaptopsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientApplication.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientApplication.ServiceReference2.IService1>, ClientApplication.ServiceReference2.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ClientApplication.ServiceReference2.CompositeType GetDataUsingDataContract(ClientApplication.ServiceReference2.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference2.CompositeType> GetDataUsingDataContractAsync(ClientApplication.ServiceReference2.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string GetCommodityByTypeNo(int value) {
            return base.Channel.GetCommodityByTypeNo(value);
        }
        
        public System.Threading.Tasks.Task<string> GetCommodityByTypeNoAsync(int value) {
            return base.Channel.GetCommodityByTypeNoAsync(value);
        }
        
        public string GetCommodityByTypeFeature(int Type, string features) {
            return base.Channel.GetCommodityByTypeFeature(Type, features);
        }
        
        public System.Threading.Tasks.Task<string> GetCommodityByTypeFeatureAsync(int Type, string features) {
            return base.Channel.GetCommodityByTypeFeatureAsync(Type, features);
        }
        
        public bool AddCommodity(ClientApplication.ServiceReference2.Commodity commodity) {
            return base.Channel.AddCommodity(commodity);
        }
        
        public System.Threading.Tasks.Task<bool> AddCommodityAsync(ClientApplication.ServiceReference2.Commodity commodity) {
            return base.Channel.AddCommodityAsync(commodity);
        }
        
        public ClientApplication.ServiceReference2.Laptop[] getAllLaptops() {
            return base.Channel.getAllLaptops();
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference2.Laptop[]> getAllLaptopsAsync() {
            return base.Channel.getAllLaptopsAsync();
        }
    }
}
