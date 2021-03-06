﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Feedback.BL.FeedbackService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServerFeedbackDto", Namespace="http://schemas.datacontract.org/2004/07/Feedback.Service.Dto")]
    [System.SerializableAttribute()]
    public partial class ServerFeedbackDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FeedbackService.IFeedbackService")]
    public interface IFeedbackService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeedbackService/AddFeedback", ReplyAction="http://tempuri.org/IFeedbackService/AddFeedbackResponse")]
        void AddFeedback(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeedbackService/AddFeedback", ReplyAction="http://tempuri.org/IFeedbackService/AddFeedbackResponse")]
        System.Threading.Tasks.Task AddFeedbackAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeedbackService/GetFeedbacks", ReplyAction="http://tempuri.org/IFeedbackService/GetFeedbacksResponse")]
        Feedback.BL.FeedbackService.ServerFeedbackDto[] GetFeedbacks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFeedbackService/GetFeedbacks", ReplyAction="http://tempuri.org/IFeedbackService/GetFeedbacksResponse")]
        System.Threading.Tasks.Task<Feedback.BL.FeedbackService.ServerFeedbackDto[]> GetFeedbacksAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFeedbackServiceChannel : Feedback.BL.FeedbackService.IFeedbackService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FeedbackServiceClient : System.ServiceModel.ClientBase<Feedback.BL.FeedbackService.IFeedbackService>, Feedback.BL.FeedbackService.IFeedbackService {
        
        public FeedbackServiceClient() {
        }
        
        public FeedbackServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FeedbackServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FeedbackServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FeedbackServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddFeedback(string message) {
            base.Channel.AddFeedback(message);
        }
        
        public System.Threading.Tasks.Task AddFeedbackAsync(string message) {
            return base.Channel.AddFeedbackAsync(message);
        }
        
        public Feedback.BL.FeedbackService.ServerFeedbackDto[] GetFeedbacks() {
            return base.Channel.GetFeedbacks();
        }
        
        public System.Threading.Tasks.Task<Feedback.BL.FeedbackService.ServerFeedbackDto[]> GetFeedbacksAsync() {
            return base.Channel.GetFeedbacksAsync();
        }
    }
}
