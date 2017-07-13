using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServicioJuego : IServiciosJuego
    {
        //=== Usuario ===//

        public int GetIdUsuario(String nombreUsuario)
        {
            int id;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Usuarios\" WHERE Nombre_Usuario = '" + nombreUsuario + "'", Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                id = (int)tablaPersona.Rows[0]["Id_Usuario"];
                Conexion.Close();
            }
            catch
            {
                id = -1;
            }
            return id;
        }

        public String GetNombreUsuario(int idUsuario)
        {
            String res;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Usuarios\" WHERE Id_Jugador = " + idUsuario, Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                res = (String)tablaPersona.Rows[0]["Nombre_Usuario"];
                Conexion.Close();
            }
            catch
            {
                res = "~";
            }
            return res;
        }

        public bool AddUsuario(int idJugador,String nombreUsuario,String contrasenia)
        {
            try
            {
                SqlConnection Conexion = GetSqlConeccion();

                SqlCommand CMD = new SqlCommand("INSERT INTO \"Usuarios\" (Id_Jugador,Nombre_Usuario,Contrasenia_Usuario) VALUES ("+idJugador+",'" + nombreUsuario + "','" + contrasenia + "')", Conexion);
                Conexion.Open();
                CMD.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarUsuarioId(int idUsuario)
        {
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                SqlCommand CMD = new SqlCommand("DELETE FROM \"Usuarios\" WHERE Id_Jugador = " + idUsuario, Conexion);
                Conexion.Open();
                CMD.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarUsuarioNombre(String nombreUsuario)
        {
            try
            {
                SqlConnection Conexion = GetSqlConeccion();

                SqlCommand CMD = new SqlCommand("DELETE FROM \"Usuarios\" WHERE Nombre_Usuario = '" + nombreUsuario + "'", Conexion);
                Conexion.Open();
                CMD.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public String GetPassUsuarioNombre(String nombreUsuario)
        {
            String res;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Usuarios\" WHERE Nombre_Usuario = '" + nombreUsuario + "'", Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                res = (String)tablaPersona.Rows[0]["Contrasenia_Usuario"];
                Conexion.Close();
            }
            catch
            {
                res = "~";
            }
            return res;
        }

        public String GetPassUsuarioId(int idUsuario)
        {
            String res;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Usuarios\" WHERE Id_Jugador = " + idUsuario, Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                res = (String)tablaPersona.Rows[0]["Contrasenia_Usuario"];
                Conexion.Close();
            }
            catch
            {
                res = "~";
            }
            return res;
        }

        
        //=== Jugador ===//

        // Obtiene el id de un jugador con el nombre dado, retorna -1 si ocurre una excepcion
        public int GetIdJugador(String nombreJugador)
        {
            int id;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Jugadores\" WHERE Nombre_Jugador = '" + nombreJugador + "'", Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                id = (int)tablaPersona.Rows[0]["Id_Jugador"];
                Conexion.Close();
            }
            catch
            {
                id = -1;
            }
            return id;
        }

        public bool AddJugador(String nombre)
        {
            try
            {
                SqlConnection Conexion = GetSqlConeccion();

                SqlCommand CMD = new SqlCommand("INSERT INTO \"Jugadores\" (Nombre_Jugador) VALUES ('" + nombre + "')", Conexion);
                Conexion.Open();
                CMD.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool EliminarJugadorId(int idJugador)
        {
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                SqlCommand CMD = new SqlCommand("DELETE FROM \"Jugadores\" WHERE Id_Jugador = " + idJugador, Conexion);
                Conexion.Open();
                CMD.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarJugadorNombre(String nombreJugador)
        {
            try
            {
                SqlConnection Conexion = GetSqlConeccion();

                SqlCommand CMD = new SqlCommand("DELETE FROM \"Jugadores\" WHERE Nombre_Jugador = '" + nombreJugador + "'", Conexion);
                Conexion.Open();
                CMD.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
                
        public int GetPuntajeJugadorId(int idJugador)
        {
            int id;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Jugadores\" WHERE Id_Jugador = " + idJugador, Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                id = (int)tablaPersona.Rows[0]["Mejor_Puntaje_Jugador"];
                Conexion.Close();
            }
            catch
            {
                id = -1;
            }
            return id;
        }

        public int GetPuntajeJugadorNombre(String nombreJugador)
        {
            int puntaje;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Jugadores\" WHERE Nombre_Jugador = '" + nombreJugador + "'", Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                puntaje = (int)tablaPersona.Rows[0]["Mejor_Puntaje_Jugador"];
                Conexion.Close();
            }
            catch
            {
                puntaje = -1;
            }
            return puntaje;
        }

        public int GetVidaJugadorNombre(String nombreJugador)
        {
            int vida;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Jugadores\" WHERE Nombre_Jugador = '" + nombreJugador + "'", Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                vida = (int)tablaPersona.Rows[0]["Vida_Jugador"];
                Conexion.Close();
            }
            catch
            {
                vida = -1;
            }
            return vida;
        }
        
        public int GetVidaJugadorId(int idJugador)
        {
            int vida;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Jugadores\" WHERE Id_Jugador = " + idJugador, Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                vida = (int)tablaPersona.Rows[0]["Vida_Jugador"];
                Conexion.Close();
            }
            catch
            {
                vida = -1;
            }
            return vida;
        }

        public String GetNombreJugador(int idJugador)
        {
            String ret;
            try
            {
                SqlConnection Conexion = GetSqlConeccion();
                Conexion.Open();
                SqlDataAdapter CMD = new SqlDataAdapter("SELECT * FROM \"Jugadores\" WHERE Id_Jugador = " + idJugador, Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                ret = (String)tablaPersona.Rows[0]["Nombre_Jugador"];
                Conexion.Close();
            }
            catch
            {
                ret = "~";
            }
            return ret;
        }

        private SqlConnection GetSqlConeccion()
        {
            SqlConnection Conexion = new SqlConnection("Data Source=\"U:\\Universidad\\1-2015\\PARADIGMAS (L)\\C#\\Programa\\Servicios\\App_Data\\BaseDeDatos.sdf\";Initial Catalog=Juego;Integrated Security=True");
            return Conexion;
        }

    }
}
