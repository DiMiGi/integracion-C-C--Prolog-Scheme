using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Controladores
{
    public class ControladorTeclasConfig
    {
        public static ControladorTeclasConfig controlador;

        private Vistas.VistaTeclasConfig vista;

        public Vistas.VistaTeclasConfig Vista
        {
            get { return vista; }
            set { vista = value; }
        }

        private bool keyPress;

        public bool KeyPress
        {
            get { return keyPress; }
            set { keyPress = value; }
        }

        public static void Instanciar()
        {
            controlador = new ControladorTeclasConfig();
            controlador.Vista = new Vistas.VistaTeclasConfig();
        }

        public static void Run()
        {
            if (controlador == null)
                Instanciar();
            //controlador.Vista = new Vistas.VistaCrearUsuario();
            setVisible(true);
        }

        public static void setVisible(bool accion)
        {
            if (controlador != null)
                controlador.Vista.Visible = accion;
            else
                Run();
            if (accion == true)
            {

                controlador.Vista.Size = Controladores.ControladorConfiguraciones.controlador.Vista.Size;
                controlador.Vista.Location = Controladores.ControladorConfiguraciones.controlador.Vista.Location;
                controlador.Vista.setText();
                controlador.Vista.BringToFront();
            }
        }

        public void mouseClose(System.Windows.Forms.MouseEventArgs e){
            if(!KeyPress)
                Controladores.ControladorConfiguraciones.controlador.Vista.cambiar(e);
        }

        public void keyClose(System.Windows.Forms.KeyEventArgs e)
        {
            if(KeyPress)
                Controladores.ControladorConfiguraciones.controlador.Vista.cambiar(e);
        }

    }
}
