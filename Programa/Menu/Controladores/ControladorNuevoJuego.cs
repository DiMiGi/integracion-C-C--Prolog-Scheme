using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Controladores
{
    class ControladorNuevoJuego : Modelos.Resolucion
    {
        
        public static ControladorNuevoJuego controlador;

        private Vistas.VistaNuevoJuego vista;

        public Vistas.VistaNuevoJuego Vista
        {
            get { return vista; }
            set { vista = value; }
        }

        public static void Instanciar()
        {
            controlador = new ControladorNuevoJuego();
            controlador.Vista = new Vistas.VistaNuevoJuego();
        }


        private int dimX;

        public int DimX
        {
            get { return dimX; }
            set { dimX = value; }
        }

        private int dimY;

        public int DimY
        {
            get { return dimY; }
            set { dimY = value; }
        }

        private int dificultad;
        public int Dificultad
        {
            get { return dificultad; }
            set { dificultad = value; }
        }

        private bool representacionLaberinto;

        // true = scheme, false = prolog
        public bool RepresentacionLaberinto
        {
            get { return representacionLaberinto; }
            set { representacionLaberinto = value; }
        }
        private bool enemigos;

        public bool Enemigos
        {
            get { return enemigos; }
            set { enemigos = value; }
        }
        private bool hardCore;

        public bool HardCore
        {
            get { return hardCore; }
            set { hardCore = value; }
        }

        public static void Run()
        {
            if(controlador == null)
                ControladorNuevoJuego.controlador = new ControladorNuevoJuego();
            ControladorNuevoJuego.controlador.Vista = new Vistas.VistaNuevoJuego();
            setVisible(true);
        }

        public static void setVisible(bool accion)
        {
            if (controlador.Vista != null)
                ControladorNuevoJuego.controlador.Vista.Visible = accion;
            else
                Run();
            if(accion == true)
                ControladorNuevoJuego.controlador.Vista.BringToFront();
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
