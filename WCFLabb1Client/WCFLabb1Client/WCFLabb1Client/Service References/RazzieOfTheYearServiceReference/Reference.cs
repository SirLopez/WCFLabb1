﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFLabb1Client.RazzieOfTheYearServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RazzieOfTheYearServiceReference.RazzieOfTheYearSoap")]
    public interface RazzieOfTheYearSoap {
        
        // CODEGEN: Generating message contract since element name input from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RazzieYear", ReplyAction="*")]
        WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearResponse RazzieYear(WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RazzieYear", ReplyAction="*")]
        System.Threading.Tasks.Task<WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearResponse> RazzieYearAsync(WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RazzieYearRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RazzieYear", Namespace="http://tempuri.org/", Order=0)]
        public WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequestBody Body;
        
        public RazzieYearRequest() {
        }
        
        public RazzieYearRequest(WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RazzieYearRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string input;
        
        public RazzieYearRequestBody() {
        }
        
        public RazzieYearRequestBody(string input) {
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RazzieYearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RazzieYearResponse", Namespace="http://tempuri.org/", Order=0)]
        public WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearResponseBody Body;
        
        public RazzieYearResponse() {
        }
        
        public RazzieYearResponse(WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RazzieYearResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RazzieYearResult;
        
        public RazzieYearResponseBody() {
        }
        
        public RazzieYearResponseBody(string RazzieYearResult) {
            this.RazzieYearResult = RazzieYearResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RazzieOfTheYearSoapChannel : WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieOfTheYearSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RazzieOfTheYearSoapClient : System.ServiceModel.ClientBase<WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieOfTheYearSoap>, WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieOfTheYearSoap {
        
        public RazzieOfTheYearSoapClient() {
        }
        
        public RazzieOfTheYearSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RazzieOfTheYearSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RazzieOfTheYearSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RazzieOfTheYearSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearResponse WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieOfTheYearSoap.RazzieYear(WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequest request) {
            return base.Channel.RazzieYear(request);
        }
        
        public string RazzieYear(string input) {
            WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequest inValue = new WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequest();
            inValue.Body = new WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequestBody();
            inValue.Body.input = input;
            WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearResponse retVal = ((WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieOfTheYearSoap)(this)).RazzieYear(inValue);
            return retVal.Body.RazzieYearResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearResponse> WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieOfTheYearSoap.RazzieYearAsync(WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequest request) {
            return base.Channel.RazzieYearAsync(request);
        }
        
        public System.Threading.Tasks.Task<WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearResponse> RazzieYearAsync(string input) {
            WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequest inValue = new WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequest();
            inValue.Body = new WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieYearRequestBody();
            inValue.Body.input = input;
            return ((WCFLabb1Client.RazzieOfTheYearServiceReference.RazzieOfTheYearSoap)(this)).RazzieYearAsync(inValue);
        }
    }
}