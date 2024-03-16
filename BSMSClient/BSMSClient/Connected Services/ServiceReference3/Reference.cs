﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BSMSClient.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/Book_Store_Management_System")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int book_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime order_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
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
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int book_id {
            get {
                return this.book_idField;
            }
            set {
                if ((this.book_idField.Equals(value) != true)) {
                    this.book_idField = value;
                    this.RaisePropertyChanged("book_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime order_date {
            get {
                return this.order_dateField;
            }
            set {
                if ((this.order_dateField.Equals(value) != true)) {
                    this.order_dateField = value;
                    this.RaisePropertyChanged("order_date");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.IService3")]
    public interface IService3 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/Insert", ReplyAction="http://tempuri.org/IService3/InsertResponse")]
        bool Insert(BSMSClient.ServiceReference3.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/Insert", ReplyAction="http://tempuri.org/IService3/InsertResponse")]
        System.Threading.Tasks.Task<bool> InsertAsync(BSMSClient.ServiceReference3.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/Update", ReplyAction="http://tempuri.org/IService3/UpdateResponse")]
        bool Update(BSMSClient.ServiceReference3.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/Update", ReplyAction="http://tempuri.org/IService3/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(BSMSClient.ServiceReference3.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/Delete", ReplyAction="http://tempuri.org/IService3/DeleteResponse")]
        bool Delete(int order_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/Delete", ReplyAction="http://tempuri.org/IService3/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int order_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/FetchBooks", ReplyAction="http://tempuri.org/IService3/FetchBooksResponse")]
        System.Collections.Generic.Dictionary<int, string> FetchBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/FetchBooks", ReplyAction="http://tempuri.org/IService3/FetchBooksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> FetchBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/FetchId", ReplyAction="http://tempuri.org/IService3/FetchIdResponse")]
        int FetchId(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/FetchId", ReplyAction="http://tempuri.org/IService3/FetchIdResponse")]
        System.Threading.Tasks.Task<int> FetchIdAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService3Channel : BSMSClient.ServiceReference3.IService3, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service3Client : System.ServiceModel.ClientBase<BSMSClient.ServiceReference3.IService3>, BSMSClient.ServiceReference3.IService3 {
        
        public Service3Client() {
        }
        
        public Service3Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service3Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service3Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service3Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Insert(BSMSClient.ServiceReference3.Order order) {
            return base.Channel.Insert(order);
        }
        
        public System.Threading.Tasks.Task<bool> InsertAsync(BSMSClient.ServiceReference3.Order order) {
            return base.Channel.InsertAsync(order);
        }
        
        public bool Update(BSMSClient.ServiceReference3.Order order) {
            return base.Channel.Update(order);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(BSMSClient.ServiceReference3.Order order) {
            return base.Channel.UpdateAsync(order);
        }
        
        public bool Delete(int order_id) {
            return base.Channel.Delete(order_id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int order_id) {
            return base.Channel.DeleteAsync(order_id);
        }
        
        public System.Collections.Generic.Dictionary<int, string> FetchBooks() {
            return base.Channel.FetchBooks();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> FetchBooksAsync() {
            return base.Channel.FetchBooksAsync();
        }
        
        public int FetchId(string username) {
            return base.Channel.FetchId(username);
        }
        
        public System.Threading.Tasks.Task<int> FetchIdAsync(string username) {
            return base.Channel.FetchIdAsync(username);
        }
    }
}