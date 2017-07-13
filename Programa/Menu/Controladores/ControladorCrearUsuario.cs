using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Controladores
{
    class ControladorCrearUsuario : Modelos.Resolucion
    {
        private Vistas.VistaCrearUsuario vista;

        public Vistas.VistaCrearUsuario Vista
        {
            get { return vista; }
            set { vista = value; }
        }

        public static ControladorCrearUsuario controlador;

        public static void Instanciar()
        {
            controlador = new ControladorCrearUsuario();
            controlador.Vista = new Vistas.VistaCrearUsuario();
        }

        public static void Run()
        {
            if (controlador == null)
                Instanciar();
            //controlador.Vista = new Vistas.VistaCrearUsuario();
            setVisible(true);
        }

        public void crearUsuario(String nombreUsuario, String contrasenia, String nombreJugador)
        {
            Servicios.Service1Client servicio = new Servicios.Service1Client();
            if (servicio.AddJugador(nombreJugador))
            {
                if (servicio.AddUsuario(servicio.GetIdJugadorNombre(nombreJugador),nombreUsuario, contrasenia))
                    controlador.Vista.CreacionJugadorMensaje(true);
                else
                {
                    servicio.EliminarJugadorNombre(nombreJugador);
                    controlador.Vista.CreacionJugadorMensaje(false);
                }
            }
            else
            {
                controlador.Vista.CreacionJugadorMensaje(false);
            }
        }

        public static void setVisible(bool accion)
        {
            if (controlador != null)
                controlador.Vista.Visible = accion;
            else
                Run();
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
    }
}
