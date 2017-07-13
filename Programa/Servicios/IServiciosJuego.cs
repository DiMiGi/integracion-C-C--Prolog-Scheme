using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiciosJuego
    {

        //=== Usuario ===//

        [OperationContract]
        int GetIdUsuario(String nombreUsuario);

        [OperationContract]
        String GetNombreUsuario(int idUsuario);

        [OperationContract]
        String GetPassUsuarioNombre(String nombreUsuario);

        [OperationContract]
        String GetPassUsuarioId(int idUsuario);

        [OperationContract]
        bool AddUsuario(int idJugador,String nombre,String contrasenia);

        [OperationContract]
        bool EliminarUsuarioId(int idUsuario);

        [OperationContract]
        bool EliminarUsuarioNombre(String nombreUsuario);


        //=== Jugador ===//

        [OperationContract]
        bool EliminarJugadorId(int idJugador);

        [OperationContract]
        bool EliminarJugadorNombre(String nombreJugador);

        [OperationContract]
        bool AddJugador(String nombre);

        [OperationContract]
        int GetPuntajeJugadorId(int idJugador);

        [OperationContract]
        int GetPuntajeJugadorNombre(String nombreJugador);

        [OperationContract]
        int GetVidaJugadorNombre(String nombreJugador);

        [OperationContract]
        int GetVidaJugadorId(int idJugador);

        [OperationContract]
        int GetIdJugador(String nombreJugador);

        [OperationContract]
        String GetNombreJugador(int idJugador);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
