﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente_CSharp.srEscuelaCSharp {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srEscuelaCSharp.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(string idP, string nombre, string apellidos, string fechaNacimiento, string sexo, string estadoCivil, string ocupacion, string direccion, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(string idP, string nombre, string apellidos, string fechaNacimiento, string sexo, string estadoCivil, string ocupacion, string direccion, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarFoto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AgregarFoto(string titulo, string img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarFoto", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarFotoAsync(string titulo, string img);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Cliente_CSharp.srEscuelaCSharp.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Cliente_CSharp.srEscuelaCSharp.WebService1Soap>, Cliente_CSharp.srEscuelaCSharp.WebService1Soap {
        
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
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string[] Agregar(string idP, string nombre, string apellidos, string fechaNacimiento, string sexo, string estadoCivil, string ocupacion, string direccion, string telefono) {
            return base.Channel.Agregar(idP, nombre, apellidos, fechaNacimiento, sexo, estadoCivil, ocupacion, direccion, telefono);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(string idP, string nombre, string apellidos, string fechaNacimiento, string sexo, string estadoCivil, string ocupacion, string direccion, string telefono) {
            return base.Channel.AgregarAsync(idP, nombre, apellidos, fechaNacimiento, sexo, estadoCivil, ocupacion, direccion, telefono);
        }
        
        public string[] AgregarFoto(string titulo, string img) {
            return base.Channel.AgregarFoto(titulo, img);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarFotoAsync(string titulo, string img) {
            return base.Channel.AgregarFotoAsync(titulo, img);
        }
    }
}