﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFLabb1Client.NameDayReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NameDayReference.NameDaySoap")]
    public interface NameDaySoap {
        
        // CODEGEN: Generating message contract since element name input from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DateDependingOnTheName", ReplyAction="*")]
        WCFLabb1Client.NameDayReference.DateDependingOnTheNameResponse DateDependingOnTheName(WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DateDependingOnTheName", ReplyAction="*")]
        System.Threading.Tasks.Task<WCFLabb1Client.NameDayReference.DateDependingOnTheNameResponse> DateDependingOnTheNameAsync(WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DateDependingOnTheNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DateDependingOnTheName", Namespace="http://tempuri.org/", Order=0)]
        public WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequestBody Body;
        
        public DateDependingOnTheNameRequest() {
        }
        
        public DateDependingOnTheNameRequest(WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DateDependingOnTheNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string input;
        
        public DateDependingOnTheNameRequestBody() {
        }
        
        public DateDependingOnTheNameRequestBody(string input) {
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DateDependingOnTheNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DateDependingOnTheNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public WCFLabb1Client.NameDayReference.DateDependingOnTheNameResponseBody Body;
        
        public DateDependingOnTheNameResponse() {
        }
        
        public DateDependingOnTheNameResponse(WCFLabb1Client.NameDayReference.DateDependingOnTheNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DateDependingOnTheNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DateDependingOnTheNameResult;
        
        public DateDependingOnTheNameResponseBody() {
        }
        
        public DateDependingOnTheNameResponseBody(string DateDependingOnTheNameResult) {
            this.DateDependingOnTheNameResult = DateDependingOnTheNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NameDaySoapChannel : WCFLabb1Client.NameDayReference.NameDaySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NameDaySoapClient : System.ServiceModel.ClientBase<WCFLabb1Client.NameDayReference.NameDaySoap>, WCFLabb1Client.NameDayReference.NameDaySoap {
        
        public NameDaySoapClient() {
        }
        
        public NameDaySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NameDaySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameDaySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameDaySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCFLabb1Client.NameDayReference.DateDependingOnTheNameResponse WCFLabb1Client.NameDayReference.NameDaySoap.DateDependingOnTheName(WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequest request) {
            return base.Channel.DateDependingOnTheName(request);
        }
        
        public string DateDependingOnTheName(string input) {
            WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequest inValue = new WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequest();
            inValue.Body = new WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequestBody();
            inValue.Body.input = input;
            WCFLabb1Client.NameDayReference.DateDependingOnTheNameResponse retVal = ((WCFLabb1Client.NameDayReference.NameDaySoap)(this)).DateDependingOnTheName(inValue);
            return retVal.Body.DateDependingOnTheNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WCFLabb1Client.NameDayReference.DateDependingOnTheNameResponse> WCFLabb1Client.NameDayReference.NameDaySoap.DateDependingOnTheNameAsync(WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequest request) {
            return base.Channel.DateDependingOnTheNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<WCFLabb1Client.NameDayReference.DateDependingOnTheNameResponse> DateDependingOnTheNameAsync(string input) {
            WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequest inValue = new WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequest();
            inValue.Body = new WCFLabb1Client.NameDayReference.DateDependingOnTheNameRequestBody();
            inValue.Body.input = input;
            return ((WCFLabb1Client.NameDayReference.NameDaySoap)(this)).DateDependingOnTheNameAsync(inValue);
        }
    }
}