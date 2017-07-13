using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu.Controladores
{

    class ControladorLaberinto : Modelos.Resolucion
    {
        public static ControladorLaberinto controlador;

        private Vistas.VistaLaberinto vista;
        
        public Vistas.VistaLaberinto Vista
        {
            get { return vista; }
            set { vista = value; }
        }

        private int trofeosRestantes;

        public int TrofeosRestantes
        {
            get { return trofeosRestantes; }
            set { trofeosRestantes = value; }
        }

        private ClassLibraryProlog.PrologMain prologClass;

        public ClassLibraryProlog.PrologMain PrologClass
        {
            get { return prologClass; }
            set { prologClass = value; }
        }
        private ClassLibraryScheme.IronSchemeMain ironSchemeClass;

        public ClassLibraryScheme.IronSchemeMain IronSchemeClass
        {
            get { return ironSchemeClass; }
            set { ironSchemeClass = value; }
        }

        private int anchoCamino;

        public int AnchoCamino
        {
            get { return anchoCamino; }
            set { anchoCamino = value; }
        }
        private int largoCamino;

        public int LargoCamino
        {
            get { return largoCamino; }
            set { largoCamino = value; }
        }
        private const int constVel = 1;

        public int ConstVel
        {
            get { return constVel; }
        }

        private int puntaje;

        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
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


        private List<List<System.Windows.Forms.Panel>> matrizPaneles;

        public List<List<System.Windows.Forms.Panel>> MatrizPaneles
        {
            get { return matrizPaneles; }
            set { matrizPaneles = value; }
        }

        private Modelos.Jugador jugador;


        public Modelos.Jugador Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

        public static void Instanciar()
        {
            controlador = new ControladorLaberinto();
            controlador.Vista = new Vistas.VistaLaberinto();
            controlador.Puntaje = 0;
        }

        public static void Run()
        {
            controlador.TrofeosRestantes = 0;
            if (controlador == null)
                Instanciar();
            if (ControladorNuevoJuego.controlador.RepresentacionLaberinto)
                ControladorLaberinto.controlador.cargarIronScheme();
            else
                ControladorLaberinto.controlador.cargarProlog();
        }

        private void cargarIronScheme()
        {
            controlador.IronSchemeClass = new ClassLibraryScheme.IronSchemeMain();
            controlador.IronSchemeClass.CrearLaberinto(ControladorNuevoJuego.controlador.DimX, ControladorNuevoJuego.controlador.DimY);
            
            Vista.cargar(controlador.IronSchemeClass.Laberinto);
            setVisible(true);
        }

        public int calcularPuntaje()
        {
            return controlador.DimX * controlador.DimY * controlador.trofeosRestantes;
        }

        private void cargarProlog()
        {
            controlador.PrologClass = new ClassLibraryProlog.PrologMain();
            controlador.PrologClass.crearLaberinto(ControladorNuevoJuego.controlador.DimX, ControladorNuevoJuego.controlador.DimY, ControladorNuevoJuego.controlador.Dificultad);
            Vista.cargar(controlador.PrologClass.Laberinto);
            setVisible(true);
        }

        public static void setVisible(bool accion)
        {
            if (controlador != null)
                controlador.Vista.Visible = accion;
            else
                Run();
            if (accion == true)
                ControladorLaberinto.controlador.Vista.BringToFront();
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
