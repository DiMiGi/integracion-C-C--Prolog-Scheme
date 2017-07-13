using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClassLibraryServicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        //=== Usuario ===//

        /* DADO UN NOMBRE DE USARIO OBTIENE SU ID EN CASO DE QUE OCURRA UNA EXCEPCION RETORNARA -1*/
        public int GetIdUsuario(String nombreUsuario)
        {
            int id;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Usuarios\" WHERE Nombre_Usuario = '" + nombreUsuario + "'", Conexion);
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

        /* DADO EL ID DEL USUARIO OBTIENE SU NOMBRE, EN CASO DE QUE OCURRA UNA EXCEPCION RETORNARA ~ */
        public String GetNombreUsuario(int idUsuario)
        {
            String res;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Usuarios\" WHERE Id_Usuario = " + idUsuario, Conexion);
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

        /* AGREGA UN USUARIO NUEVO A LA BASE DE DATOS UNA VEZ QUE HA SIDO CREADO EL JUGADOR Y SE PUEDE OBTENER SU ID, ADEMAS DEL
         * NOMBRE Y CONTRASENIA DE USUARIO
         */
        public bool AddUsuario(int idJugador, String nombreUsuario, String contrasenia)
        {
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();

                SqlCeCommand CMD = new SqlCeCommand("INSERT INTO \"Usuarios\" (Id_Jugador,Nombre_Usuario,Contrasenia_Usuario) VALUES (" + idJugador + ",'" + nombreUsuario + "','" + contrasenia + "')", Conexion);
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

        /* METODO QUE ACTUALIZA DE LA BASE DE DATOS EL PUNTAJE DEL JUGADOR, NO DEL USUARIO Y SI NO EXISTE LO CREA
         * RETORNA TRUE SI SE ACTUALIZA FALSE EN CASO CONTRARIO*/
        public bool UpdatePuntaje(int idJugador, int puntaje)
        {
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                
                SqlCeCommand CMD = new SqlCeCommand("UPDATE \"Puntajes\" SET Mejor_Puntuacion = "+puntaje+" WHERE (Puntajes.Id_Jugador = "+idJugador+")", Conexion);
                Conexion.Open();
                int rowsAfectadas = CMD.ExecuteNonQuery();
                
                if (rowsAfectadas == 0)
                {
                    CMD = new SqlCeCommand("INSERT INTO \"Puntajes\" (Id_Jugador,Mejor_Puntuacion) VALUES (" + idJugador + "," + puntaje +")", Conexion);
                    CMD.ExecuteNonQuery();
                }
                Conexion.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("ACA : "+e.ToString());
                return false;
            }
        }

        /* ELMININA AL USUARIO DE LA BASE DE DATOS POR SU ID 
         * RETORNA TRUE SI LO ELIMINA FALSE SI NO
         */
        public bool EliminarUsuarioId(int idUsuario)
        {
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                SqlCeCommand CMD = new SqlCeCommand("DELETE FROM \"Usuarios\" WHERE Id_Usuario = " + idUsuario, Conexion);
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

        /* ELIMINA AL USUARIO DE LA BASE DE DATOS POR SU NOMBRE
         * RETORNA TRUE SI LO ELIMINA FALSE SI NO
         */
        public bool EliminarUsuarioNombre(String nombreUsuario)
        {
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();

                SqlCeCommand CMD = new SqlCeCommand("DELETE FROM \"Usuarios\" WHERE Nombre_Usuario = '" + nombreUsuario + "'", Conexion);
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

        /* OBTIENE LA CONTRASENIA DEL USUARIO DADO SU NOMBRE DESDE LA BASE DE DATOS 
         * EN CASO DE UNA EXCEPCION RETORNA ~
         */
        public String GetPassUsuarioNombre(String nombreUsuario)
        {
            String res;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Usuarios\" WHERE Nombre_Usuario = '" + nombreUsuario + "'", Conexion);
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

        /* OBTIENE LA CONTRASENIA DEL USUARIO DADO SU ID DESDE LA BASE DE DATOS
         * EN CASO DE UNA EXCEPCION RETORNA ~
         */
        public String GetPassUsuarioId(int idUsuario)
        {
            String res;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Usuarios\" WHERE Id_Usuario = " + idUsuario, Conexion);
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
        public int GetIdJugadorNombre(String nombreJugador)
        {
            int id;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Jugadores\" WHERE Nombre_Jugador = '" + nombreJugador + "'", Conexion);
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
        
        
        public int GetIdJugadorId(int idUsuario)
        {
            int id;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Usuarios\" WHERE Id_Usuario = " + idUsuario, Conexion);
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

        /* AGREGA UN JUGADOR DADO SU NOMBRE
         * RETORNA TURE SI FUE AGREGADO, FALSE EN CASO CONTRARIO
         */
        public bool AddJugador(String nombre)
        {
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();

                SqlCeCommand CMD = new SqlCeCommand("INSERT INTO \"Jugadores\" (Nombre_Jugador) VALUES ('" + nombre + "')", Conexion);
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

        /* ELIMINA UN JUGADOR POR SU ID 
         * RETORNA TURE SI FUE AGREGADO, FALSE EN CASO CONTRARIO
         */
        public bool EliminarJugadorId(int idJugador)
        {
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                SqlCeCommand CMD = new SqlCeCommand("DELETE FROM \"Jugadores\" WHERE Id_Jugador = " + idJugador, Conexion);
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

        /* ELIMINA UN JUGADOR POR SU NOMBRE 
         * RETORNA TURE SI FUE AGREGADO, FALSE EN CASO CONTRARIO
         */
        public bool EliminarJugadorNombre(String nombreJugador)
        {
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();

                SqlCeCommand CMD = new SqlCeCommand("DELETE FROM \"Jugadores\" WHERE Nombre_Jugador = '" + nombreJugador + "'", Conexion);
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

        /* SE OBTIENE EL MEJOR PUNTAJE DEL JUGADOR DADO SU ID */
        public int GetPuntajeJugadorId(int idJugador)
        {
            int id;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Puntajes\" WHERE Id_Jugador = " + idJugador, Conexion);
                DataSet DS = new DataSet();
                CMD.Fill(DS, "Table");
                DataTable tablaPersona = DS.Tables[0];
                id = (int)tablaPersona.Rows[0]["Mejor_Puntuacion"];
                Conexion.Close();
            }
            catch
            {
                id = -1;
            }
            return id;
        }

        /* SE OBTIENE EL MEJOR PUNTAJE DEL JUGADOR DADO SU NOMBRE */
        public int GetPuntajeJugadorNombre(String nombreJugador)
        {
            int puntaje;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Jugadores\" WHERE Nombre_Jugador = '" + nombreJugador + "'", Conexion);
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

        /* SE OBTIENE LA VIDA DEL JUGADOR DADO SU NOMBRE (NO IMPLEMENTADO) */
        public int GetVidaJugadorNombre(String nombreJugador)
        {
            int vida;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Jugadores\" WHERE Nombre_Jugador = '" + nombreJugador + "'", Conexion);
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

        /* SE OBTIENE LA VIDA DEL JUGADOR DADO SU ID (NO IMPLEMENTADO) */
        public int GetVidaJugadorId(int idJugador)
        {
            int vida;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Jugadores\" WHERE Id_Jugador = " + idJugador, Conexion);
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

        /* SE OBTIENE EL NOMBRE DE UN JUGADOR DADO SU ID
         * RETORNA ~ SI OCURRE UNA EXCEPCION
         */
        public String GetNombreJugador(int idJugador)
        {
            String ret;
            try
            {
                SqlCeConnection Conexion = GetSqlConexion();
                Conexion.Open();
                SqlCeDataAdapter CMD = new SqlCeDataAdapter("SELECT * FROM \"Jugadores\" WHERE Id_Jugador = " + idJugador, Conexion);
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

        /* RETORNA LA CONEXION A LA BASE DE DATOS */
        private SqlCeConnection GetSqlConexion()
        {
            SqlCeConnection Conexion = new SqlCeConnection("Data Source=\"U:\\Universidad\\1-2015\\PARADIGMAS (L)\\C#\\Programa\\ClassLibraryServicios\\BaseDatos\\BaseDeDatos.sdf\"");
            return Conexion;
        }
    }
}
