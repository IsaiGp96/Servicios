﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consumo.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Consumo.ServiceReference1.HelloWorldResponse HelloWorld(Consumo.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Consumo.ServiceReference1.HelloWorldResponse> HelloWorldAsync(Consumo.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Saludo", ReplyAction="*")]
        Consumo.ServiceReference1.SaludoResponse Saludo(Consumo.ServiceReference1.SaludoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Saludo", ReplyAction="*")]
        System.Threading.Tasks.Task<Consumo.ServiceReference1.SaludoResponse> SaludoAsync(Consumo.ServiceReference1.SaludoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento mensaje del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarLog", ReplyAction="*")]
        Consumo.ServiceReference1.GuardarLogResponse GuardarLog(Consumo.ServiceReference1.GuardarLogRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarLog", ReplyAction="*")]
        System.Threading.Tasks.Task<Consumo.ServiceReference1.GuardarLogResponse> GuardarLogAsync(Consumo.ServiceReference1.GuardarLogRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sumar", ReplyAction="*")]
        int Sumar(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sumar", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SumarAsync(int num1, int num2);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Consumo.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Consumo.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Consumo.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Consumo.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaludoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Saludo", Namespace="http://tempuri.org/", Order=0)]
        public Consumo.ServiceReference1.SaludoRequestBody Body;
        
        public SaludoRequest() {
        }
        
        public SaludoRequest(Consumo.ServiceReference1.SaludoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaludoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public SaludoRequestBody() {
        }
        
        public SaludoRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaludoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaludoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Consumo.ServiceReference1.SaludoResponseBody Body;
        
        public SaludoResponse() {
        }
        
        public SaludoResponse(Consumo.ServiceReference1.SaludoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaludoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SaludoResult;
        
        public SaludoResponseBody() {
        }
        
        public SaludoResponseBody(string SaludoResult) {
            this.SaludoResult = SaludoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GuardarLogRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GuardarLog", Namespace="http://tempuri.org/", Order=0)]
        public Consumo.ServiceReference1.GuardarLogRequestBody Body;
        
        public GuardarLogRequest() {
        }
        
        public GuardarLogRequest(Consumo.ServiceReference1.GuardarLogRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GuardarLogRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string mensaje;
        
        public GuardarLogRequestBody() {
        }
        
        public GuardarLogRequestBody(string mensaje) {
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GuardarLogResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GuardarLogResponse", Namespace="http://tempuri.org/", Order=0)]
        public Consumo.ServiceReference1.GuardarLogResponseBody Body;
        
        public GuardarLogResponse() {
        }
        
        public GuardarLogResponse(Consumo.ServiceReference1.GuardarLogResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GuardarLogResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GuardarLogResult;
        
        public GuardarLogResponseBody() {
        }
        
        public GuardarLogResponseBody(string GuardarLogResult) {
            this.GuardarLogResult = GuardarLogResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : Consumo.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<Consumo.ServiceReference1.WebServiceSoap>, Consumo.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Consumo.ServiceReference1.HelloWorldResponse Consumo.ServiceReference1.WebServiceSoap.HelloWorld(Consumo.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Consumo.ServiceReference1.HelloWorldRequest inValue = new Consumo.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Consumo.ServiceReference1.HelloWorldRequestBody();
            Consumo.ServiceReference1.HelloWorldResponse retVal = ((Consumo.ServiceReference1.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Consumo.ServiceReference1.HelloWorldResponse> Consumo.ServiceReference1.WebServiceSoap.HelloWorldAsync(Consumo.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Consumo.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            Consumo.ServiceReference1.HelloWorldRequest inValue = new Consumo.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Consumo.ServiceReference1.HelloWorldRequestBody();
            return ((Consumo.ServiceReference1.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Consumo.ServiceReference1.SaludoResponse Consumo.ServiceReference1.WebServiceSoap.Saludo(Consumo.ServiceReference1.SaludoRequest request) {
            return base.Channel.Saludo(request);
        }
        
        public string Saludo(string nombre) {
            Consumo.ServiceReference1.SaludoRequest inValue = new Consumo.ServiceReference1.SaludoRequest();
            inValue.Body = new Consumo.ServiceReference1.SaludoRequestBody();
            inValue.Body.nombre = nombre;
            Consumo.ServiceReference1.SaludoResponse retVal = ((Consumo.ServiceReference1.WebServiceSoap)(this)).Saludo(inValue);
            return retVal.Body.SaludoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Consumo.ServiceReference1.SaludoResponse> Consumo.ServiceReference1.WebServiceSoap.SaludoAsync(Consumo.ServiceReference1.SaludoRequest request) {
            return base.Channel.SaludoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Consumo.ServiceReference1.SaludoResponse> SaludoAsync(string nombre) {
            Consumo.ServiceReference1.SaludoRequest inValue = new Consumo.ServiceReference1.SaludoRequest();
            inValue.Body = new Consumo.ServiceReference1.SaludoRequestBody();
            inValue.Body.nombre = nombre;
            return ((Consumo.ServiceReference1.WebServiceSoap)(this)).SaludoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Consumo.ServiceReference1.GuardarLogResponse Consumo.ServiceReference1.WebServiceSoap.GuardarLog(Consumo.ServiceReference1.GuardarLogRequest request) {
            return base.Channel.GuardarLog(request);
        }
        
        public string GuardarLog(string mensaje) {
            Consumo.ServiceReference1.GuardarLogRequest inValue = new Consumo.ServiceReference1.GuardarLogRequest();
            inValue.Body = new Consumo.ServiceReference1.GuardarLogRequestBody();
            inValue.Body.mensaje = mensaje;
            Consumo.ServiceReference1.GuardarLogResponse retVal = ((Consumo.ServiceReference1.WebServiceSoap)(this)).GuardarLog(inValue);
            return retVal.Body.GuardarLogResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Consumo.ServiceReference1.GuardarLogResponse> Consumo.ServiceReference1.WebServiceSoap.GuardarLogAsync(Consumo.ServiceReference1.GuardarLogRequest request) {
            return base.Channel.GuardarLogAsync(request);
        }
        
        public System.Threading.Tasks.Task<Consumo.ServiceReference1.GuardarLogResponse> GuardarLogAsync(string mensaje) {
            Consumo.ServiceReference1.GuardarLogRequest inValue = new Consumo.ServiceReference1.GuardarLogRequest();
            inValue.Body = new Consumo.ServiceReference1.GuardarLogRequestBody();
            inValue.Body.mensaje = mensaje;
            return ((Consumo.ServiceReference1.WebServiceSoap)(this)).GuardarLogAsync(inValue);
        }
        
        public int Sumar(int num1, int num2) {
            return base.Channel.Sumar(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SumarAsync(int num1, int num2) {
            return base.Channel.SumarAsync(num1, num2);
        }
    }
}