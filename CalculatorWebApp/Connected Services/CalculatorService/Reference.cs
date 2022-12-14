//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorWebApp.CalculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name CalculterDescriptionResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculterDescription", ReplyAction="*")]
        CalculatorWebApp.CalculatorService.CalculterDescriptionResponse CalculterDescription(CalculatorWebApp.CalculatorService.CalculterDescriptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculterDescription", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.CalculterDescriptionResponse> CalculterDescriptionAsync(CalculatorWebApp.CalculatorService.CalculterDescriptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        int Subtract(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubtractAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        int Multiply(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        int Divide(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DivideAsync(int num1, int num2);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculterDescriptionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculterDescription", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorWebApp.CalculatorService.CalculterDescriptionRequestBody Body;
        
        public CalculterDescriptionRequest() {
        }
        
        public CalculterDescriptionRequest(CalculatorWebApp.CalculatorService.CalculterDescriptionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CalculterDescriptionRequestBody {
        
        public CalculterDescriptionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculterDescriptionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculterDescriptionResponse", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorWebApp.CalculatorService.CalculterDescriptionResponseBody Body;
        
        public CalculterDescriptionResponse() {
        }
        
        public CalculterDescriptionResponse(CalculatorWebApp.CalculatorService.CalculterDescriptionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculterDescriptionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CalculterDescriptionResult;
        
        public CalculterDescriptionResponseBody() {
        }
        
        public CalculterDescriptionResponseBody(string CalculterDescriptionResult) {
            this.CalculterDescriptionResult = CalculterDescriptionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : CalculatorWebApp.CalculatorService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<CalculatorWebApp.CalculatorService.WebService1Soap>, CalculatorWebApp.CalculatorService.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorWebApp.CalculatorService.CalculterDescriptionResponse CalculatorWebApp.CalculatorService.WebService1Soap.CalculterDescription(CalculatorWebApp.CalculatorService.CalculterDescriptionRequest request) {
            return base.Channel.CalculterDescription(request);
        }
        
        public string CalculterDescription() {
            CalculatorWebApp.CalculatorService.CalculterDescriptionRequest inValue = new CalculatorWebApp.CalculatorService.CalculterDescriptionRequest();
            inValue.Body = new CalculatorWebApp.CalculatorService.CalculterDescriptionRequestBody();
            CalculatorWebApp.CalculatorService.CalculterDescriptionResponse retVal = ((CalculatorWebApp.CalculatorService.WebService1Soap)(this)).CalculterDescription(inValue);
            return retVal.Body.CalculterDescriptionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.CalculterDescriptionResponse> CalculatorWebApp.CalculatorService.WebService1Soap.CalculterDescriptionAsync(CalculatorWebApp.CalculatorService.CalculterDescriptionRequest request) {
            return base.Channel.CalculterDescriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.CalculterDescriptionResponse> CalculterDescriptionAsync() {
            CalculatorWebApp.CalculatorService.CalculterDescriptionRequest inValue = new CalculatorWebApp.CalculatorService.CalculterDescriptionRequest();
            inValue.Body = new CalculatorWebApp.CalculatorService.CalculterDescriptionRequestBody();
            return ((CalculatorWebApp.CalculatorService.WebService1Soap)(this)).CalculterDescriptionAsync(inValue);
        }
        
        public int Add(int num1, int num2) {
            return base.Channel.Add(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int num1, int num2) {
            return base.Channel.AddAsync(num1, num2);
        }
        
        public int Subtract(int num1, int num2) {
            return base.Channel.Subtract(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int num1, int num2) {
            return base.Channel.SubtractAsync(num1, num2);
        }
        
        public int Multiply(int num1, int num2) {
            return base.Channel.Multiply(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int num1, int num2) {
            return base.Channel.MultiplyAsync(num1, num2);
        }
        
        public int Divide(int num1, int num2) {
            return base.Channel.Divide(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int num1, int num2) {
            return base.Channel.DivideAsync(num1, num2);
        }
    }
}
