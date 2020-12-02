﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DfcuTester.FINAPI {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dfcugroup.com/", ConfigurationName="FINAPI.webserviceSoap")]
    public interface webserviceSoap {
        
        // CODEGEN: Generating message contract since element name utilityCode from namespace http://dfcugroup.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dfcugroup.com/InquireUtility", ReplyAction="*")]
        DfcuTester.FINAPI.InquireUtilityResponse InquireUtility(DfcuTester.FINAPI.InquireUtilityRequest request);
        
        // CODEGEN: Generating message contract since element name utilityCode from namespace http://dfcugroup.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dfcugroup.com/PostUtilityTransaction", ReplyAction="*")]
        DfcuTester.FINAPI.PostUtilityTransactionResponse PostUtilityTransaction(DfcuTester.FINAPI.PostUtilityTransactionRequest request);
        
        // CODEGEN: Generating message contract since element name utilityCode from namespace http://dfcugroup.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dfcugroup.com/PostIUIUTransaction", ReplyAction="*")]
        DfcuTester.FINAPI.PostIUIUTransactionResponse PostIUIUTransaction(DfcuTester.FINAPI.PostIUIUTransactionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InquireUtilityRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InquireUtility", Namespace="http://dfcugroup.com/", Order=0)]
        public DfcuTester.FINAPI.InquireUtilityRequestBody Body;
        
        public InquireUtilityRequest() {
        }
        
        public InquireUtilityRequest(DfcuTester.FINAPI.InquireUtilityRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dfcugroup.com/")]
    public partial class InquireUtilityRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string utilityCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string utilityArea;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string custRef;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ApiUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ApiPassword;
        
        public InquireUtilityRequestBody() {
        }
        
        public InquireUtilityRequestBody(string utilityCode, string utilityArea, string custRef, string ApiUsername, string ApiPassword) {
            this.utilityCode = utilityCode;
            this.utilityArea = utilityArea;
            this.custRef = custRef;
            this.ApiUsername = ApiUsername;
            this.ApiPassword = ApiPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InquireUtilityResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InquireUtilityResponse", Namespace="http://dfcugroup.com/", Order=0)]
        public DfcuTester.FINAPI.InquireUtilityResponseBody Body;
        
        public InquireUtilityResponse() {
        }
        
        public InquireUtilityResponse(DfcuTester.FINAPI.InquireUtilityResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dfcugroup.com/")]
    public partial class InquireUtilityResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InquireUtilityResult;
        
        public InquireUtilityResponseBody() {
        }
        
        public InquireUtilityResponseBody(string InquireUtilityResult) {
            this.InquireUtilityResult = InquireUtilityResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PostUtilityTransactionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PostUtilityTransaction", Namespace="http://dfcugroup.com/", Order=0)]
        public DfcuTester.FINAPI.PostUtilityTransactionRequestBody Body;
        
        public PostUtilityTransactionRequest() {
        }
        
        public PostUtilityTransactionRequest(DfcuTester.FINAPI.PostUtilityTransactionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dfcugroup.com/")]
    public partial class PostUtilityTransactionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string utilityCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string utilityArea;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string custRef;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ApiUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ApiPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string custPhone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string payreference;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string umemePayType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string reserve1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string reserve2;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string reserve3;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string reserve4;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string reserve5;
        
        public PostUtilityTransactionRequestBody() {
        }
        
        public PostUtilityTransactionRequestBody(string utilityCode, string utilityArea, string custRef, string ApiUsername, string ApiPassword, string custPhone, string Amount, string payreference, string umemePayType, string reserve1, string reserve2, string reserve3, string reserve4, string reserve5) {
            this.utilityCode = utilityCode;
            this.utilityArea = utilityArea;
            this.custRef = custRef;
            this.ApiUsername = ApiUsername;
            this.ApiPassword = ApiPassword;
            this.custPhone = custPhone;
            this.Amount = Amount;
            this.payreference = payreference;
            this.umemePayType = umemePayType;
            this.reserve1 = reserve1;
            this.reserve2 = reserve2;
            this.reserve3 = reserve3;
            this.reserve4 = reserve4;
            this.reserve5 = reserve5;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PostUtilityTransactionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PostUtilityTransactionResponse", Namespace="http://dfcugroup.com/", Order=0)]
        public DfcuTester.FINAPI.PostUtilityTransactionResponseBody Body;
        
        public PostUtilityTransactionResponse() {
        }
        
        public PostUtilityTransactionResponse(DfcuTester.FINAPI.PostUtilityTransactionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dfcugroup.com/")]
    public partial class PostUtilityTransactionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PostUtilityTransactionResult;
        
        public PostUtilityTransactionResponseBody() {
        }
        
        public PostUtilityTransactionResponseBody(string PostUtilityTransactionResult) {
            this.PostUtilityTransactionResult = PostUtilityTransactionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PostIUIUTransactionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PostIUIUTransaction", Namespace="http://dfcugroup.com/", Order=0)]
        public DfcuTester.FINAPI.PostIUIUTransactionRequestBody Body;
        
        public PostIUIUTransactionRequest() {
        }
        
        public PostIUIUTransactionRequest(DfcuTester.FINAPI.PostIUIUTransactionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dfcugroup.com/")]
    public partial class PostIUIUTransactionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string utilityCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string studyYear;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string semester;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string custRef;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ApiUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ApiPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string custPhone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string payreference;
        
        public PostIUIUTransactionRequestBody() {
        }
        
        public PostIUIUTransactionRequestBody(string utilityCode, string studyYear, string semester, string custRef, string ApiUsername, string ApiPassword, string custPhone, string Amount, string payreference) {
            this.utilityCode = utilityCode;
            this.studyYear = studyYear;
            this.semester = semester;
            this.custRef = custRef;
            this.ApiUsername = ApiUsername;
            this.ApiPassword = ApiPassword;
            this.custPhone = custPhone;
            this.Amount = Amount;
            this.payreference = payreference;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PostIUIUTransactionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PostIUIUTransactionResponse", Namespace="http://dfcugroup.com/", Order=0)]
        public DfcuTester.FINAPI.PostIUIUTransactionResponseBody Body;
        
        public PostIUIUTransactionResponse() {
        }
        
        public PostIUIUTransactionResponse(DfcuTester.FINAPI.PostIUIUTransactionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dfcugroup.com/")]
    public partial class PostIUIUTransactionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PostIUIUTransactionResult;
        
        public PostIUIUTransactionResponseBody() {
        }
        
        public PostIUIUTransactionResponseBody(string PostIUIUTransactionResult) {
            this.PostIUIUTransactionResult = PostIUIUTransactionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface webserviceSoapChannel : DfcuTester.FINAPI.webserviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class webserviceSoapClient : System.ServiceModel.ClientBase<DfcuTester.FINAPI.webserviceSoap>, DfcuTester.FINAPI.webserviceSoap {
        
        public webserviceSoapClient() {
        }
        
        public webserviceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public webserviceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public webserviceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public webserviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DfcuTester.FINAPI.InquireUtilityResponse DfcuTester.FINAPI.webserviceSoap.InquireUtility(DfcuTester.FINAPI.InquireUtilityRequest request) {
            return base.Channel.InquireUtility(request);
        }
        
        public string InquireUtility(string utilityCode, string utilityArea, string custRef, string ApiUsername, string ApiPassword) {
            DfcuTester.FINAPI.InquireUtilityRequest inValue = new DfcuTester.FINAPI.InquireUtilityRequest();
            inValue.Body = new DfcuTester.FINAPI.InquireUtilityRequestBody();
            inValue.Body.utilityCode = utilityCode;
            inValue.Body.utilityArea = utilityArea;
            inValue.Body.custRef = custRef;
            inValue.Body.ApiUsername = ApiUsername;
            inValue.Body.ApiPassword = ApiPassword;
            DfcuTester.FINAPI.InquireUtilityResponse retVal = ((DfcuTester.FINAPI.webserviceSoap)(this)).InquireUtility(inValue);
            return retVal.Body.InquireUtilityResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DfcuTester.FINAPI.PostUtilityTransactionResponse DfcuTester.FINAPI.webserviceSoap.PostUtilityTransaction(DfcuTester.FINAPI.PostUtilityTransactionRequest request) {
            return base.Channel.PostUtilityTransaction(request);
        }
        
        public string PostUtilityTransaction(string utilityCode, string utilityArea, string custRef, string ApiUsername, string ApiPassword, string custPhone, string Amount, string payreference, string umemePayType, string reserve1, string reserve2, string reserve3, string reserve4, string reserve5) {
            DfcuTester.FINAPI.PostUtilityTransactionRequest inValue = new DfcuTester.FINAPI.PostUtilityTransactionRequest();
            inValue.Body = new DfcuTester.FINAPI.PostUtilityTransactionRequestBody();
            inValue.Body.utilityCode = utilityCode;
            inValue.Body.utilityArea = utilityArea;
            inValue.Body.custRef = custRef;
            inValue.Body.ApiUsername = ApiUsername;
            inValue.Body.ApiPassword = ApiPassword;
            inValue.Body.custPhone = custPhone;
            inValue.Body.Amount = Amount;
            inValue.Body.payreference = payreference;
            inValue.Body.umemePayType = umemePayType;
            inValue.Body.reserve1 = reserve1;
            inValue.Body.reserve2 = reserve2;
            inValue.Body.reserve3 = reserve3;
            inValue.Body.reserve4 = reserve4;
            inValue.Body.reserve5 = reserve5;
            DfcuTester.FINAPI.PostUtilityTransactionResponse retVal = ((DfcuTester.FINAPI.webserviceSoap)(this)).PostUtilityTransaction(inValue);
            return retVal.Body.PostUtilityTransactionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DfcuTester.FINAPI.PostIUIUTransactionResponse DfcuTester.FINAPI.webserviceSoap.PostIUIUTransaction(DfcuTester.FINAPI.PostIUIUTransactionRequest request) {
            return base.Channel.PostIUIUTransaction(request);
        }
        
        public string PostIUIUTransaction(string utilityCode, string studyYear, string semester, string custRef, string ApiUsername, string ApiPassword, string custPhone, string Amount, string payreference) {
            DfcuTester.FINAPI.PostIUIUTransactionRequest inValue = new DfcuTester.FINAPI.PostIUIUTransactionRequest();
            inValue.Body = new DfcuTester.FINAPI.PostIUIUTransactionRequestBody();
            inValue.Body.utilityCode = utilityCode;
            inValue.Body.studyYear = studyYear;
            inValue.Body.semester = semester;
            inValue.Body.custRef = custRef;
            inValue.Body.ApiUsername = ApiUsername;
            inValue.Body.ApiPassword = ApiPassword;
            inValue.Body.custPhone = custPhone;
            inValue.Body.Amount = Amount;
            inValue.Body.payreference = payreference;
            DfcuTester.FINAPI.PostIUIUTransactionResponse retVal = ((DfcuTester.FINAPI.webserviceSoap)(this)).PostIUIUTransaction(inValue);
            return retVal.Body.PostIUIUTransactionResult;
        }
    }
}