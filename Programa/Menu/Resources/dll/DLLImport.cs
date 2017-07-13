using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Menu.Modelos;



namespace Resources.dll
{

    /*!
     *	\struct ConfigParam
     *  \brief Estructura que define las configuraciones del juego.
     */
    public struct ConfigParam
    {
        String clave;//!< Indica el nombre de la configuracion.

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        String valor;//!< Indica el valor de la configuracion.


        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public ConfigParam(String clave, int valor)
        {
            // TODO: Complete member initialization
            this.clave = clave;
            this.valor = valor.ToString();
        }

        public ConfigParam(String clave, String valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

    };
    /*!
     *	\struct GameHistory
     *  \brief Estructura que define la posibilidad de replicar todas las acciones realizadas en el ultimo juego.
     */
    public struct GameHistory
    {
        int cantidadDeJugadores;//!< Indica el nombre del trofeo.

        public int CantidadDeJugadores
        {
            get { return cantidadDeJugadores; }
            set { cantidadDeJugadores = value; }
        }
        int cantidadDeEnemigos;//!< Indica el nombre del trofeo.

        public int CantidadDeEnemigos
        {
            get { return cantidadDeEnemigos; }
            set { cantidadDeEnemigos = value; }
        }
        Jugador[] jugadores;//!< Indica los jugadores en la ultima partida.

        public Jugador[] Jugadores
        {
            get { return jugadores; }
            set { jugadores = value; }
        }
        Enemigo[] enemigos;//!< Indica los enemigos en la ultima partida.

        internal Enemigo[] Enemigos
        {
            get { return enemigos; }
            set { enemigos = value; }
        }
        int mapaID;//!< Indica el ID del mapa.

        public int MapaID
        {
            get { return mapaID; }
            set { mapaID = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(GameHistory))
            {
                if (((GameHistory)obj).MapaID == this.MapaID)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return MapaID;
        }
    };

    /*!
     *	\struct SaveGame
     *  \brief Estructura que define los elementos que se necesitan para cargar las ultima posicion de un jugador.
     */
    //agregar nombre a save
    public struct SaveGame
    {
        String nombreSave;

        public String NombreSave
        {
            get { return nombreSave; }
            set { nombreSave = value; }
        }

        Jugador jugador;//!< Indica el jugador que se va a guardar.

        public Jugador Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }
        int mapaID; //!< Indica el id del mapa que se guardara.

        public int MapaID
        {
            get { return mapaID; }
            set { mapaID = value; }
        }
        
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(SaveGame))
            {
                if (((SaveGame)obj).nombreSave.Equals(this.nombreSave))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    };

    


    public class DLLImport
    {
        public static bool errorOcurrido = false;
        public static GameHistory gameHistory;
        public static List<SaveGame> savedGames;
        public static List<ConfigParam> configuraciones;

        [DllImport("ClassLibraryC.dll")]
            public static extern void encriptar(String fileNameToRead, String fileNameToWrite);
        [DllImport("ClassLibraryC.dll")]
            public static extern void desencriptar(String fileNameToRead, String fileNameToWrite);
        [DllImport("ClassLibraryC.dll")]
            public static extern int confirmarCorrupcion(String fileNameComparado, String fileNameOriginal, String fileNameTemp);
        [DllImport("ClassLibraryC.dll")]
            public static extern int detectarCorrupcion(String fileName, int tipoDeArchivo, String fileNameTemp);
        [DllImport("ClassLibraryC.dll")]
            public static extern void medidasDeCorrupcion();
        [DllImport("ClassLibraryC.dll")]
        public static extern void loadSettings(String fileName, out IntPtr paramsReaded, out int length, out int statusCode);
        [DllImport("ClassLibraryC.dll")]
            public static extern void saveSettings(String fileName, ConfigParam[] paramsToWrite, int length, out int statusCode);
        [DllImport("ClassLibraryC.dll")]
            public static extern void loadGameHistory(String fileName, out GameHistory gameHistoryReaded, out int statusCode);
        [DllImport("ClassLibraryC.dll")]
            public static extern void saveGameHistory(String fileName, GameHistory gameHistoryToWrite, out int statusCode);
        [DllImport("ClassLibraryC.dll")]
        public static extern void loadSavedGame(String fileName, out IntPtr savedGamesReaded, out int length, out int statusCode);
        [DllImport("ClassLibraryC.dll")]
            public static extern void saveGame(String fileName, SaveGame[] savedGamesToWrite, int length,out int statusCode);

        // representacion true: Scheme, false: Prolog
        public static void cargarMapa(int id,bool representacion)
        {
            String path = "mapas/" + id.ToString() + ".txt";
            String[] lecturas,lecturasAux;
            int x,y,t,dimX, dimY;
            if (System.IO.File.Exists(path))
            {
                lecturas = System.IO.File.ReadAllLines(path);
                dimX = Convert.ToInt32(lecturas[1].Split(' ').ElementAt(0));
                dimY = Convert.ToInt32(lecturas[1].Split(' ').ElementAt(1));
                if (lecturas[0].Equals("Scheme"))
                {
                    //obtiene los vectores
                    for (int i = 2; i < lecturas.Length; i++)
                    {
                        lecturasAux = lecturas[i].Split(' ');
                        for (int j = 0; j < lecturasAux.Length; j++)
                        {
                            x = Convert.ToInt32(lecturasAux[0]);
                            y = Convert.ToInt32(lecturasAux[1]);
                            t = Convert.ToInt32(lecturasAux[2]);
                        }
                    }
                }
                else if (lecturas[0].Equals("Prolog"))
                {
                    
                }

            }
                
        }

        // representacion true: Scheme, false: Prolog
        public static void guardarMapa(bool representacion)
        {
            int idMapa = 0;
            while (System.IO.File.Exists("mapas/" + idMapa.ToString() + ".txt"))
                idMapa++;
            System.IO.StreamWriter writer = System.IO.File.CreateText("mapas/" + idMapa.ToString() + ".txt");
            if (representacion) 
            {

                try
                {
                    writer.WriteLine("Scheme");
                    writer.WriteLine(Menu.Controladores.ControladorLaberinto.controlador.IronSchemeClass.Laberinto.DimX + " " + Menu.Controladores.ControladorLaberinto.controlador.IronSchemeClass.Laberinto.DimY);
                    foreach (ClassLibraryScheme.Vector3 vector in Menu.Controladores.ControladorLaberinto.controlador.IronSchemeClass.Laberinto.laberinto)
                        writer.WriteLine(vector.ToString());
                    writer.Close();
                }
                catch (NullReferenceException)
                {
                    //scheme class es nulo
                }
            }
            else
            {
                try
                {
                    writer.WriteLine("Prolog");
                    writer.WriteLine(Menu.Controladores.ControladorLaberinto.controlador.PrologClass.Laberinto.DimX + " " + Menu.Controladores.ControladorLaberinto.controlador.PrologClass.Laberinto.DimY);
                    for (int i = 0; i < Menu.Controladores.ControladorLaberinto.controlador.PrologClass.Laberinto.laberinto.Count; i++)
                        writer.WriteLine(Menu.Controladores.ControladorLaberinto.controlador.PrologClass.Laberinto.laberinto.ElementAt(i));
                    writer.Close();

                }
                catch (NullReferenceException)
                {
                    //prolog class es nulo
                }

            }
        }

        public static bool GuardarJuego(String archivo)
        {
            int error = 0;
            if (archivo == null)
                archivo = "Player";
            String directorio = "SaveGame/" + archivo + ".txt"; 
            bool escribirSave = false;
            
            SaveGame save = new SaveGame();

            guardarMapa(Menu.Controladores.ControladorNuevoJuego.controlador.RepresentacionLaberinto);

            save.Jugador = Menu.Controladores.ControladorMainProgram.controlador.Jugador;

            if (savedGames.Contains(save))
            {
                System.Windows.Forms.DialogResult dialog =
                    System.Windows.Forms.MessageBox.Show
                    ("Se ha encontrado una coincidencia con el nombre especificado del archivo que se desea guardar, ¿desea reemplazarlo?", "Coincidencia Encontrada.", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);

                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    escribirSave = true;
                }
                else
                {
                    escribirSave = false;
                }

                //mostrar mensaje de que existe el save si desea reemplazarlo

            }
            else
            {
                savedGames.Add(save);
                escribirSave = true;
            }
            
            if (escribirSave == true)
                saveGame(directorio, savedGames.ToArray(), savedGames.Count, out error);
            else
                error = 456;

            /* === Revision de Error === */

            if (error == 0)
            {
                errorOcurrido = false;
                
            }
            else if (error == 456)
            {
                errorOcurrido = false;
                // se cancela el agregar un juego

            }
            else
            {
                errorOcurrido = true;

            }
            return errorOcurrido;
        }

        public static bool CargarJuego(String archivo)
        {
            String directorio = "SaveGame/" + archivo + ".txt";
            
            int length = 0, error = 0;
            SaveGame[] gamesArray = null;

            IntPtr games;

            loadSavedGame(directorio,out games,out length,out error);

            int structSize = Marshal.SizeOf(typeof(SaveGame));
            gamesArray = new SaveGame[length];
            //Se desplaza por los punteros y se castea elemento a elemento del array
            for (int i = 0; i < length; i++)
            {
                IntPtr data = new IntPtr(games.ToInt64() + structSize * i);
                gamesArray[i] = (SaveGame)Marshal.PtrToStructure(data, typeof(SaveGame));
            }


            if (length != 0){
                gamesArray = new SaveGame[length];
                
            }
            else
                savedGames = null;

            if (error == 0)
            {
                errorOcurrido = false;

            }
            else
            {
                errorOcurrido = true;

            }
            return errorOcurrido;
        }

        public static bool GuardarHistoria(String archivo)
        {
            int error = 0;
            if (archivo == null)
                archivo = "Player";
            String directorio = "temp/" + archivo + ".txt";
            bool escribirSave = false;

            GameHistory save = new GameHistory();

            
            if (gameHistory.Equals(save))
            {
                System.Windows.Forms.DialogResult dialog =
                    System.Windows.Forms.MessageBox.Show
                    ("Se ha encontrado una coincidencia con el nombre especificado del archivo que se desea guardar, ¿desea reemplazarlo?", "Coincidencia Encontrada.", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);

                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    escribirSave = true;
                }
                else
                {
                    escribirSave = false;
                }

                //mostrar mensaje de que existe el save si desea reemplazarlo

            }
            else
            {
                //savedGames.Add(save);
                escribirSave = true;
            }

            if (escribirSave == true)
                saveGame(directorio, savedGames.ToArray(), savedGames.Count, out error);
            else
                error = 456;

            /* === Revision de Error === */

            if (error == 0)
            {
                errorOcurrido = false;

            }
            else if (error == 456)
            {
                errorOcurrido = false;
                // se cancela el agregar un juego

            }
            else
            {
                errorOcurrido = true;

            }
            return errorOcurrido;
        }

        public static bool CargarHistoria(String archivo)
        {
            String directorio = "temp/" + archivo + ".txt";

            int length = 0, error = 0;
            IntPtr games;

            loadSavedGame(directorio, out games, out length, out error);
            SaveGame[] save = new SaveGame[length];

            int structSize = Marshal.SizeOf(typeof(SaveGame));
            //Se desplaza por los punteros y se castea elemento a elemento del array
            for (int i = 0; i < length; i++)
            {
                IntPtr data = new IntPtr(games.ToInt64() + structSize * i);
                save[i] = (SaveGame)Marshal.PtrToStructure(data, typeof(SaveGame));
            }

            

            if (length != 0)
                savedGames = save.ToList();
            else
                savedGames = null;

            if (error == 0)
            {
                errorOcurrido = false;

            }
            else
            {
                errorOcurrido = true;

            }
            return errorOcurrido;
        }

        // EL NOMBRE DEL ARCHIVO ES LA CONFIGURACION PERSONAL SI ARCHIVO ES NULO POR DEFECTO SERÁ Player
        public static bool GuardarConfiguraciones(String archivo)
        {
            if (archivo == null)
                archivo = "Player";
            int error = 0;
            String directorio = "config/" + archivo + ".txt";
            

            ConfigParam[] save = new ConfigParam[7];

            Resolucion CONFIG = Menu.Controladores.ControladorConfiguraciones.controlador.getResolucion(Menu.Controladores.ControladorConfiguraciones.controlador.ResolucionActual);

            save[0] = new ConfigParam("Height",CONFIG.resolucion.Height);
            save[1] = new ConfigParam("Width",CONFIG.resolucion.Width);
            save[2] = new ConfigParam("Frecuencia", CONFIG.Frecuencia);
            save[3] = new ConfigParam("Arriba", Menu.Controladores.ControladorConfiguraciones.controlador.KeyArriba.ToString());
            save[4] = new ConfigParam("Abajo", Menu.Controladores.ControladorConfiguraciones.controlador.KeyAbajo.ToString());
            save[5] = new ConfigParam("Izquierda", Menu.Controladores.ControladorConfiguraciones.controlador.KeyIzquierda.ToString());
            save[6] = new ConfigParam("Derecha", Menu.Controladores.ControladorConfiguraciones.controlador.KeyDerecha.ToString());

                    
            configuraciones = save.ToList();
            saveSettings(directorio, configuraciones.ToArray(), configuraciones.Count, out error);
            if (error == 0)
            {
                errorOcurrido = false;

            }
            else
            {
                errorOcurrido = true;

            }
            return errorOcurrido;
        }

        public static bool CargarConfiguraciones(String archivo)
        {
            String directorio = "config/" + archivo + ".txt";

            int length = 0, error = 0;
            IntPtr configPtr;
            ConfigParam[] config = null;

            loadSettings(directorio, out configPtr, out length, out error);

            config = new ConfigParam[length];
            int structSize = Marshal.SizeOf(typeof(ConfigParam));
            //Se desplaza por los punteros y se castea elemento a elemento del array
            for (int i = 0; i < length; i++)
            {
                IntPtr data = new IntPtr(configPtr.ToInt64() + structSize * i);
                config[i] = (ConfigParam)Marshal.PtrToStructure(data, typeof(ConfigParam));
            }

            if (length != 0)
                configuraciones = config.ToList();
            else
                configuraciones = null;

            if (error == 0)
            {
                errorOcurrido = false;

            }
            else
            {
                errorOcurrido = true;

            }
            return errorOcurrido;
        }

    }
}
