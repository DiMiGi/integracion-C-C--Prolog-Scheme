﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Menu.Servicios {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servicios.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIdUsuario", ReplyAction="http://tempuri.org/IService1/GetIdUsuarioResponse")]
        int GetIdUsuario(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIdUsuario", ReplyAction="http://tempuri.org/IService1/GetIdUsuarioResponse")]
        System.Threading.Tasks.Task<int> GetIdUsuarioAsync(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNombreUsuario", ReplyAction="http://tempuri.org/IService1/GetNombreUsuarioResponse")]
        string GetNombreUsuario(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNombreUsuario", ReplyAction="http://tempuri.org/IService1/GetNombreUsuarioResponse")]
        System.Threading.Tasks.Task<string> GetNombreUsuarioAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPassUsuarioNombre", ReplyAction="http://tempuri.org/IService1/GetPassUsuarioNombreResponse")]
        string GetPassUsuarioNombre(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPassUsuarioNombre", ReplyAction="http://tempuri.org/IService1/GetPassUsuarioNombreResponse")]
        System.Threading.Tasks.Task<string> GetPassUsuarioNombreAsync(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPassUsuarioId", ReplyAction="http://tempuri.org/IService1/GetPassUsuarioIdResponse")]
        string GetPassUsuarioId(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPassUsuarioId", ReplyAction="http://tempuri.org/IService1/GetPassUsuarioIdResponse")]
        System.Threading.Tasks.Task<string> GetPassUsuarioIdAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUsuario", ReplyAction="http://tempuri.org/IService1/AddUsuarioResponse")]
        bool AddUsuario(int idJugador, string nombre, string contrasenia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUsuario", ReplyAction="http://tempuri.org/IService1/AddUsuarioResponse")]
        System.Threading.Tasks.Task<bool> AddUsuarioAsync(int idJugador, string nombre, string contrasenia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuarioId", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioIdResponse")]
        bool EliminarUsuarioId(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuarioId", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioIdResponse")]
        System.Threading.Tasks.Task<bool> EliminarUsuarioIdAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuarioNombre", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioNombreResponse")]
        bool EliminarUsuarioNombre(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuarioNombre", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioNombreResponse")]
        System.Threading.Tasks.Task<bool> EliminarUsuarioNombreAsync(string nombreUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarJugadorId", ReplyAction="http://tempuri.org/IService1/EliminarJugadorIdResponse")]
        bool EliminarJugadorId(int idJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarJugadorId", ReplyAction="http://tempuri.org/IService1/EliminarJugadorIdResponse")]
        System.Threading.Tasks.Task<bool> EliminarJugadorIdAsync(int idJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarJugadorNombre", ReplyAction="http://tempuri.org/IService1/EliminarJugadorNombreResponse")]
        bool EliminarJugadorNombre(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarJugadorNombre", ReplyAction="http://tempuri.org/IService1/EliminarJugadorNombreResponse")]
        System.Threading.Tasks.Task<bool> EliminarJugadorNombreAsync(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddJugador", ReplyAction="http://tempuri.org/IService1/AddJugadorResponse")]
        bool AddJugador(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddJugador", ReplyAction="http://tempuri.org/IService1/AddJugadorResponse")]
        System.Threading.Tasks.Task<bool> AddJugadorAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPuntajeJugadorId", ReplyAction="http://tempuri.org/IService1/GetPuntajeJugadorIdResponse")]
        int GetPuntajeJugadorId(int idJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPuntajeJugadorId", ReplyAction="http://tempuri.org/IService1/GetPuntajeJugadorIdResponse")]
        System.Threading.Tasks.Task<int> GetPuntajeJugadorIdAsync(int idJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPuntajeJugadorNombre", ReplyAction="http://tempuri.org/IService1/GetPuntajeJugadorNombreResponse")]
        int GetPuntajeJugadorNombre(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPuntajeJugadorNombre", ReplyAction="http://tempuri.org/IService1/GetPuntajeJugadorNombreResponse")]
        System.Threading.Tasks.Task<int> GetPuntajeJugadorNombreAsync(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVidaJugadorNombre", ReplyAction="http://tempuri.org/IService1/GetVidaJugadorNombreResponse")]
        int GetVidaJugadorNombre(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVidaJugadorNombre", ReplyAction="http://tempuri.org/IService1/GetVidaJugadorNombreResponse")]
        System.Threading.Tasks.Task<int> GetVidaJugadorNombreAsync(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVidaJugadorId", ReplyAction="http://tempuri.org/IService1/GetVidaJugadorIdResponse")]
        int GetVidaJugadorId(int idJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVidaJugadorId", ReplyAction="http://tempuri.org/IService1/GetVidaJugadorIdResponse")]
        System.Threading.Tasks.Task<int> GetVidaJugadorIdAsync(int idJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIdJugadorId", ReplyAction="http://tempuri.org/IService1/GetIdJugadorIdResponse")]
        int GetIdJugadorId(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIdJugadorId", ReplyAction="http://tempuri.org/IService1/GetIdJugadorIdResponse")]
        System.Threading.Tasks.Task<int> GetIdJugadorIdAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIdJugadorNombre", ReplyAction="http://tempuri.org/IService1/GetIdJugadorNombreResponse")]
        int GetIdJugadorNombre(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIdJugadorNombre", ReplyAction="http://tempuri.org/IService1/GetIdJugadorNombreResponse")]
        System.Threading.Tasks.Task<int> GetIdJugadorNombreAsync(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNombreJugador", ReplyAction="http://tempuri.org/IService1/GetNombreJugadorResponse")]
        string GetNombreJugador(int idJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNombreJugador", ReplyAction="http://tempuri.org/IService1/GetNombreJugadorResponse")]
        System.Threading.Tasks.Task<string> GetNombreJugadorAsync(int idJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePuntaje", ReplyAction="http://tempuri.org/IService1/UpdatePuntajeResponse")]
        bool UpdatePuntaje(int idJugador, int puntaje);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePuntaje", ReplyAction="http://tempuri.org/IService1/UpdatePuntajeResponse")]
        System.Threading.Tasks.Task<bool> UpdatePuntajeAsync(int idJugador, int puntaje);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Menu.Servicios.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Menu.Servicios.IService1>, Menu.Servicios.IService1 {
        
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
        
        public int GetIdUsuario(string nombreUsuario) {
            return base.Channel.GetIdUsuario(nombreUsuario);
        }
        
        public System.Threading.Tasks.Task<int> GetIdUsuarioAsync(string nombreUsuario) {
            return base.Channel.GetIdUsuarioAsync(nombreUsuario);
        }
        
        public string GetNombreUsuario(int idUsuario) {
            return base.Channel.GetNombreUsuario(idUsuario);
        }
        
        public System.Threading.Tasks.Task<string> GetNombreUsuarioAsync(int idUsuario) {
            return base.Channel.GetNombreUsuarioAsync(idUsuario);
        }
        
        public string GetPassUsuarioNombre(string nombreUsuario) {
            return base.Channel.GetPassUsuarioNombre(nombreUsuario);
        }
        
        public System.Threading.Tasks.Task<string> GetPassUsuarioNombreAsync(string nombreUsuario) {
            return base.Channel.GetPassUsuarioNombreAsync(nombreUsuario);
        }
        
        public string GetPassUsuarioId(int idUsuario) {
            return base.Channel.GetPassUsuarioId(idUsuario);
        }
        
        public System.Threading.Tasks.Task<string> GetPassUsuarioIdAsync(int idUsuario) {
            return base.Channel.GetPassUsuarioIdAsync(idUsuario);
        }
        
        public bool AddUsuario(int idJugador, string nombre, string contrasenia) {
            return base.Channel.AddUsuario(idJugador, nombre, contrasenia);
        }
        
        public System.Threading.Tasks.Task<bool> AddUsuarioAsync(int idJugador, string nombre, string contrasenia) {
            return base.Channel.AddUsuarioAsync(idJugador, nombre, contrasenia);
        }
        
        public bool EliminarUsuarioId(int idUsuario) {
            return base.Channel.EliminarUsuarioId(idUsuario);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarUsuarioIdAsync(int idUsuario) {
            return base.Channel.EliminarUsuarioIdAsync(idUsuario);
        }
        
        public bool EliminarUsuarioNombre(string nombreUsuario) {
            return base.Channel.EliminarUsuarioNombre(nombreUsuario);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarUsuarioNombreAsync(string nombreUsuario) {
            return base.Channel.EliminarUsuarioNombreAsync(nombreUsuario);
        }
        
        public bool EliminarJugadorId(int idJugador) {
            return base.Channel.EliminarJugadorId(idJugador);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarJugadorIdAsync(int idJugador) {
            return base.Channel.EliminarJugadorIdAsync(idJugador);
        }
        
        public bool EliminarJugadorNombre(string nombreJugador) {
            return base.Channel.EliminarJugadorNombre(nombreJugador);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarJugadorNombreAsync(string nombreJugador) {
            return base.Channel.EliminarJugadorNombreAsync(nombreJugador);
        }
        
        public bool AddJugador(string nombre) {
            return base.Channel.AddJugador(nombre);
        }
        
        public System.Threading.Tasks.Task<bool> AddJugadorAsync(string nombre) {
            return base.Channel.AddJugadorAsync(nombre);
        }
        
        public int GetPuntajeJugadorId(int idJugador) {
            return base.Channel.GetPuntajeJugadorId(idJugador);
        }
        
        public System.Threading.Tasks.Task<int> GetPuntajeJugadorIdAsync(int idJugador) {
            return base.Channel.GetPuntajeJugadorIdAsync(idJugador);
        }
        
        public int GetPuntajeJugadorNombre(string nombreJugador) {
            return base.Channel.GetPuntajeJugadorNombre(nombreJugador);
        }
        
        public System.Threading.Tasks.Task<int> GetPuntajeJugadorNombreAsync(string nombreJugador) {
            return base.Channel.GetPuntajeJugadorNombreAsync(nombreJugador);
        }
        
        public int GetVidaJugadorNombre(string nombreJugador) {
            return base.Channel.GetVidaJugadorNombre(nombreJugador);
        }
        
        public System.Threading.Tasks.Task<int> GetVidaJugadorNombreAsync(string nombreJugador) {
            return base.Channel.GetVidaJugadorNombreAsync(nombreJugador);
        }
        
        public int GetVidaJugadorId(int idJugador) {
            return base.Channel.GetVidaJugadorId(idJugador);
        }
        
        public System.Threading.Tasks.Task<int> GetVidaJugadorIdAsync(int idJugador) {
            return base.Channel.GetVidaJugadorIdAsync(idJugador);
        }
        
        public int GetIdJugadorId(int idUsuario) {
            return base.Channel.GetIdJugadorId(idUsuario);
        }
        
        public System.Threading.Tasks.Task<int> GetIdJugadorIdAsync(int idUsuario) {
            return base.Channel.GetIdJugadorIdAsync(idUsuario);
        }
        
        public int GetIdJugadorNombre(string nombreJugador) {
            return base.Channel.GetIdJugadorNombre(nombreJugador);
        }
        
        public System.Threading.Tasks.Task<int> GetIdJugadorNombreAsync(string nombreJugador) {
            return base.Channel.GetIdJugadorNombreAsync(nombreJugador);
        }
        
        public string GetNombreJugador(int idJugador) {
            return base.Channel.GetNombreJugador(idJugador);
        }
        
        public System.Threading.Tasks.Task<string> GetNombreJugadorAsync(int idJugador) {
            return base.Channel.GetNombreJugadorAsync(idJugador);
        }
        
        public bool UpdatePuntaje(int idJugador, int puntaje) {
            return base.Channel.UpdatePuntaje(idJugador, puntaje);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePuntajeAsync(int idJugador, int puntaje) {
            return base.Channel.UpdatePuntajeAsync(idJugador, puntaje);
        }
    }
}
