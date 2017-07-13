using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Menu.Controladores
{
    class ControladorConfiguraciones : Modelos.Resolucion
    {

        public static ControladorConfiguraciones controlador;

        private Vistas.VistaConfiguraciones vista;

        public Vistas.VistaConfiguraciones Vista
        {
            get { return vista; }
            set { vista = value; }
        }

        public static void Instanciar()
        {
            controlador = new ControladorConfiguraciones();
            controlador.Vista = new Vistas.VistaConfiguraciones();
            Resources.dll.DLLImport.CargarConfiguraciones("Player");
            controlador.KeyArribaDef = (Keys)Convert.ToChar(Resources.dll.DLLImport.configuraciones.ElementAt(3).Valor);
            controlador.KeyAbajoDef = (Keys)Convert.ToChar(Resources.dll.DLLImport.configuraciones.ElementAt(4).Valor);
            controlador.KeyIzqDef = (Keys)Convert.ToChar(Resources.dll.DLLImport.configuraciones.ElementAt(5).Valor);
            controlador.KeyDerDef = (Keys)Convert.ToChar(Resources.dll.DLLImport.configuraciones.ElementAt(6).Valor);
        }

        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(
              string deviceName, int modeNum, ref DEVMODE devMode);

        const int ENUM_CURRENT_SETTINGS = -1;

        const int ENUM_REGISTRY_SETTINGS = -2;

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            private const int CCHDEVICENAME = 0x20;
            private const int CCHFORMNAME = 0x20;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;

        }

        /* === DECLARACION DE ATRIBUTOS === */

        // representa la posicion de la resolucion en resoluciones
        private int resolucionActual;

        public int ResolucionActual
        {
            get { return resolucionActual; }
            set { resolucionActual = value; }
        }

        private int resolucionOriginal;

        public int ResolucionOriginal
        {
            get { return resolucionOriginal; }
        }

        private List<Modelos.Resolucion> resoluciones;

        public List<Modelos.Resolucion> Resoluciones
        {
            get { return resoluciones; }
            set { resoluciones = value; }
        }

        private Keys keyArribaDef;

        public Keys KeyArribaDef
        {
            get { return keyArribaDef; }
            set { keyArribaDef = value; }
        }
        private Keys keyAbajoDef;

        public Keys KeyAbajoDef
        {
            get { return keyAbajoDef; }
            set { keyAbajoDef = value; }
        }
        private Keys keyDerDef;

        public Keys KeyDerDef
        {
            get { return keyDerDef; }
            set { keyDerDef = value; }
        }
        private Keys keyIzqDef = Keys.A;

        public Keys KeyIzqDef
        {
            get { return keyIzqDef; }
            set { keyIzqDef = value; }
        }

        private Keys keyArriba;

        public Keys KeyArriba
        {
            get { return keyArriba; }
            set { keyArriba = value; }
        }
        private Keys keyAbajo;

        public Keys KeyAbajo
        {
            get { return keyAbajo; }
            set { keyAbajo = value; }
        }
        private Keys keyIzquierda;

        public Keys KeyIzquierda
        {
            get { return keyIzquierda; }
            set { keyIzquierda = value; }
        }
        private Keys keyDrecha;

        public Keys KeyDerecha
        {
            get { return keyDrecha; }
            set { keyDrecha = value; }
        }
        /* DECLARACION DE METODOS*/

        public static void Run()
        {
            if (controlador == null)
                Instanciar();
            if (controlador.Resoluciones == null)
                controlador.Resoluciones = controlador.getResoluciones();
            controlador.Vista.actualizarResoluciones();
            setVisible(true);
        }

        private List<Modelos.Resolucion> getResoluciones()
        {
            int i;
            Modelos.Resolucion resAux;
            List<Modelos.Resolucion> resoluciones = new List<Modelos.Resolucion>();
            DEVMODE vDevMode = new DEVMODE();
            for (i = 0; EnumDisplaySettings(null, i, ref vDevMode); i++)
            {
                resAux = new Modelos.Resolucion(vDevMode.dmPelsWidth,
                                                vDevMode.dmPelsHeight,
                                                vDevMode.dmBitsPerPel,
                                                vDevMode.dmDisplayFrequency
                                    );
                if (!resoluciones.Contains(resAux))
                    resoluciones.Add(resAux);
            }
            return resoluciones;
        }

        public Modelos.Resolucion getResolucion(int index)
        {
            if (index < 0 && index > Resoluciones.Count)
                resolucionActual = 0;
            Modelos.Resolucion retorno = Resoluciones.ElementAt(index);
            return retorno;
        }

        public static void setVisible(bool accion)
        {
            if (controlador != null)
                ControladorConfiguraciones.controlador.Vista.Visible = accion;
            else
                Run();
            if(accion == true)
                ControladorConfiguraciones.controlador.Vista.BringToFront();
            if (controlador.resolucion.Width!=controlador.Vista.Size.Width  
                && controlador.resolucion.Height!=controlador.Vista.Size.Height)
            {
                controlador.Vista.Size = new System.Drawing.Size(controlador.resolucion.Width, controlador.resolucion.Height);
            }
        }

        public void setDimensiones(Modelos.Resolucion resolucion)
        {
            controlador.resolucion = new System.Drawing.Size(resolucion.resolucion.Width, resolucion.resolucion.Height);
            controlador.ColorResolucion = resolucion.ColorResolucion;
            controlador.Frecuencia = resolucion.Frecuencia;
            controlador.Vista.Size = controlador.resolucion;
        }

        // aplica la configuracion al aplicar los cambios
        internal void guardarResolucion()
        {
            controlador.resolucionOriginal = controlador.resolucionActual;
            Modelos.Resolucion res = getResolucion(controlador.resolucionOriginal);
            ControladorCargarJuego.controlador.setDimensiones(res);
            ControladorConfiguraciones.controlador.setDimensiones(res);
            ControladorCrearUsuario.controlador.setDimensiones(res);
            ControladorLaberinto.controlador.setDimensiones(res);
            ControladorMainProgram.controlador.setDimensiones(res);
            ControladorNuevoJuego.controlador.setDimensiones(res);
            if(ControladorMainProgram.controlador.Jugador == null)
                Resources.dll.DLLImport.GuardarConfiguraciones(null);
            else
                Resources.dll.DLLImport.GuardarConfiguraciones(ControladorMainProgram.controlador.Jugador.NombreUsuario);
        }

        // aplica la configuracion para una viualizacion previa de la vista y revisar si se acepta o no
        internal void aplicarDimensiones(bool esActual)
        {
            if (esActual)
            {
                controlador.setDimensiones(getResolucion(controlador.resolucionActual));
                System.Windows.Forms.DialogResult dialog =
                    System.Windows.Forms.MessageBox.Show
                    ("¿Desea conservar las modificaciones realizadas?", "¿Conservar cambios?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);

                if (dialog == System.Windows.Forms.DialogResult.Yes)
                    guardarResolucion();
                else
                    controlador.setDimensiones(getResolucion(controlador.resolucionOriginal));
            }
            else
                controlador.setDimensiones(getResolucion(controlador.resolucionOriginal));
        }

        
    }
}
