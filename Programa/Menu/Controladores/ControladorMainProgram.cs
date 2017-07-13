using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources.dll;
using ClassLibraryScheme;




namespace Menu.Controladores
{
    class ControladorMainProgram : Modelos.Resolucion
    {
        
        public static ControladorMainProgram controlador;

        private Vistas.VistaMainProgram vista;

        public Vistas.VistaMainProgram Vista
        {
            get { return vista; }
            set { vista = value; }
        }

        private Modelos.Jugador jugador;

        public Modelos.Jugador Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* ========= Instancia de objetos de otros lenguajes ========= */
            IronSchemeMain schemeObject = new IronSchemeMain();

            /* =========================================================== */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            /* ========= Instancia de MainProgramControlador y controladores ========= */
            controlador = new ControladorMainProgram();
            ControladorCargarJuego.Instanciar();
            ControladorConfiguraciones.Instanciar();
            ControladorCrearUsuario.Instanciar();
            ControladorLaberinto.Instanciar();
            ControladorNuevoJuego.Instanciar();
            ControladorTeclasConfig.Instanciar();
            crearDirectorio();
            controlador.Vista = new Menu.Vistas.VistaMainProgram();

            /* ======================================================= */

            Application.Run(controlador.Vista);
        }

        private void cargarConfig()
        {
            Resources.dll.DLLImport.CargarConfiguraciones(controlador.vista.getNombreUsuario());
        }

        private static void crearDirectorio()
        {
            if (!System.IO.File.Exists("bin"))
                System.IO.Directory.CreateDirectory("bin");
            if (!System.IO.File.Exists("save"))
                System.IO.Directory.CreateDirectory("save");
            if (!System.IO.File.Exists("config"))
                System.IO.Directory.CreateDirectory("config");
            if (!System.IO.File.Exists("mapas"))
                System.IO.Directory.CreateDirectory("mapas");
        }

        public static void setVisible(bool accion)
        {
            // Siempre existira la vista y el controlador no se necesita colocar esos casos.
            controlador.Vista.Visible = accion;
            if (accion == true)
                controlador.Vista.BringToFront();
            if (controlador.resolucion.Width != controlador.Vista.Size.Width
             && controlador.resolucion.Height != controlador.Vista.Size.Height)
            {
                controlador.Vista.Size = new System.Drawing.Size(controlador.resolucion.Width, controlador.resolucion.Height);
            }
        }

        public void setDimensiones(Modelos.Resolucion resolucion)
        {
            this.resolucion = new System.Drawing.Size(resolucion.resolucion.Width, resolucion.resolucion.Height);
            this.ColorResolucion = resolucion.ColorResolucion;
            this.Frecuencia = resolucion.Frecuencia;
            controlador.Vista.Size = this.resolucion;
        }

        internal void instanciarJugador(int id, string nombreUsuario, string nombreJugador, int vida, int puntaje)
        {
            controlador.Jugador = new Modelos.Jugador(id, nombreUsuario, nombreJugador, vida, puntaje);
        }
    }
}
