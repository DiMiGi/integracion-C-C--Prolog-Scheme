using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClassLibraryServicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
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
        bool AddUsuario(int idJugador, String nombre, String contrasenia);

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
        int GetIdJugadorId(int idUsuario);
        
        [OperationContract]
        int GetIdJugadorNombre(String nombreJugador);

        [OperationContract]
        String GetNombreJugador(int idJugador);
          
        // TODO: Add your service operations here
        [OperationContract]
        bool UpdatePuntaje(int idJugador, int puntaje);
    }
}
