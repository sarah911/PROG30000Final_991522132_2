﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginClient_991522132.TourService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/FinalTourService_991522132")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TourService.IAuthenticateUserService")]
    public interface IAuthenticateUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticateUserService/Login", ReplyAction="http://tempuri.org/IAuthenticateUserService/LoginResponse")]
        string Login(LoginClient_991522132.TourService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticateUserService/Login", ReplyAction="http://tempuri.org/IAuthenticateUserService/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(LoginClient_991522132.TourService.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthenticateUserServiceChannel : LoginClient_991522132.TourService.IAuthenticateUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticateUserServiceClient : System.ServiceModel.ClientBase<LoginClient_991522132.TourService.IAuthenticateUserService>, LoginClient_991522132.TourService.IAuthenticateUserService {
        
        public AuthenticateUserServiceClient() {
        }
        
        public AuthenticateUserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticateUserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateUserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateUserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Login(LoginClient_991522132.TourService.User user) {
            return base.Channel.Login(user);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(LoginClient_991522132.TourService.User user) {
            return base.Channel.LoginAsync(user);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TourService.IDBOperationService")]
    public interface IDBOperationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBOperationService/InsertATour", ReplyAction="http://tempuri.org/IDBOperationService/InsertATourResponse")]
        string InsertATour(LoginClient_991522132.TourService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBOperationService/InsertATour", ReplyAction="http://tempuri.org/IDBOperationService/InsertATourResponse")]
        System.Threading.Tasks.Task<string> InsertATourAsync(LoginClient_991522132.TourService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBOperationService/RetrieveTourInfo", ReplyAction="http://tempuri.org/IDBOperationService/RetrieveTourInfoResponse")]
        LoginClient_991522132.TourService.User[] RetrieveTourInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBOperationService/RetrieveTourInfo", ReplyAction="http://tempuri.org/IDBOperationService/RetrieveTourInfoResponse")]
        System.Threading.Tasks.Task<LoginClient_991522132.TourService.User[]> RetrieveTourInfoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBOperationServiceChannel : LoginClient_991522132.TourService.IDBOperationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBOperationServiceClient : System.ServiceModel.ClientBase<LoginClient_991522132.TourService.IDBOperationService>, LoginClient_991522132.TourService.IDBOperationService {
        
        public DBOperationServiceClient() {
        }
        
        public DBOperationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBOperationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBOperationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBOperationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertATour(LoginClient_991522132.TourService.User user) {
            return base.Channel.InsertATour(user);
        }
        
        public System.Threading.Tasks.Task<string> InsertATourAsync(LoginClient_991522132.TourService.User user) {
            return base.Channel.InsertATourAsync(user);
        }
        
        public LoginClient_991522132.TourService.User[] RetrieveTourInfo() {
            return base.Channel.RetrieveTourInfo();
        }
        
        public System.Threading.Tasks.Task<LoginClient_991522132.TourService.User[]> RetrieveTourInfoAsync() {
            return base.Channel.RetrieveTourInfoAsync();
        }
    }
}
