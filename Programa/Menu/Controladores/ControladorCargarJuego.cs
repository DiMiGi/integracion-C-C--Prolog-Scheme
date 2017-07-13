using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Controladores
{
    class ControladorCargarJuego : Modelos.Resolucion
    {

        public static ControladorCargarJuego controlador;

        private Vistas.VistaCargarJuego vista;

        public Vistas.VistaCargarJuego Vista
        {
            get { return vista; }
            set { vista = value; }
        }

        public static void Instanciar()
        {
            controlador = new ControladorCargarJuego();
            controlador.Vista = new Vistas.VistaCargarJuego();
        }

        /*
         * Metodo: Run()
         * Descripcion: Se encarga de cargar y asegurar la exisencia de un controlador con su vista
         *              dejandola visible.
         * */
        public static void Run()
        {
            if (controlador == null)
                Instanciar();
            //controlador.Vista = new Vistas.VistaCargarJuego();
            setVisible(true);
        }

        public static void setVisible(bool accion)
        {
            if (controlador != null)
                ControladorCargarJuego.controlador.Vista.Visible = accion;
            else
                Run();
            if (accion == true)
                ControladorCargarJuego.controlador.Vista.BringToFront();
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
            controlador.Vista.Size = new System.Drawing.Size(resolucion.resolucion.Width, resolucion.resolucion.Height);
        }
    }
}
