using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Menu.Vistas
{
    public partial class VistaLaberinto : Form
    {
        

        public VistaLaberinto()
        {
            InitializeComponent();
        }

        private bool repitiendoMovimientos;
        private bool firstMove =false;

        private void agregarJugador(int posX, int posY)
        {
            int aux1, aux2;
            if (Controladores.ControladorLaberinto.controlador.Jugador == null)
            {
                Controladores.ControladorLaberinto.controlador.Jugador = new Modelos.Jugador();
                Controladores.ControladorLaberinto.controlador.Jugador.Movimientos = new List<Point>();
                Controladores.ControladorLaberinto.controlador.Jugador.MovimientosEvents = new List<KeyEventArgs>();
                Controladores.ControladorLaberinto.controlador.Jugador.Representacion = new Panel();
                Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Name = "jugador";
                aux1 = Controladores.ControladorLaberinto.controlador.AnchoCamino / 4;
                aux2 = Controladores.ControladorLaberinto.controlador.LargoCamino / 4;
                Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Size = new Size(aux2, aux1);
                aux1 = (posX * Controladores.ControladorLaberinto.controlador.LargoCamino) + (3 * Controladores.ControladorLaberinto.controlador.LargoCamino / 8);
                aux2 = (posY * Controladores.ControladorLaberinto.controlador.AnchoCamino) + (3 * Controladores.ControladorLaberinto.controlador.AnchoCamino / 8);
                Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location = new Point(aux1, aux2);
                Controladores.ControladorLaberinto.controlador.Jugador.Movimientos.Add(new Point(aux1, aux2));
                Controladores.ControladorLaberinto.controlador.Jugador.Representacion.BackColor = Color.White;
            }
        }

        private void asignarPropiedades(Panel panel,Point punto)
        {
            panel.Location = punto;
            panel.Name = "panel";
            panel.TabIndex = 0;
            panel.BackColor = Color.Brown;
        }

        private void restarPuntaje(){
            //Resta puntaje del atributo en el controladorLaberinto y luego de 0,5 seg. vuelve a restar hasta que el puntaje sea 0
            while (Controladores.ControladorLaberinto.controlador.Puntaje != 0)
            {
                Controladores.ControladorLaberinto.controlador.Puntaje--;
                Thread.Sleep(500);
            }
        }

        //actualiza el puntaje del lbl Puntaje cada vez que se mueve el personaje
        public void actualizarPuntaje()
        {
            this.lblPuntajeEdit.Text = Controladores.ControladorLaberinto.controlador.Puntaje.ToString();
        }

        private void LaberintoVista_KeyDown(object sender, KeyEventArgs e)
        {
            if (!firstMove)
            {
                //si se ha comenzado a mover comienza el descuento de puntaje
                Thread thread = new Thread(restarPuntaje);
                thread.Name = "restarPuntajeThread";
                thread.Start();
                firstMove = true;
            }
            //actualizacion del puntaje
            actualizarPuntaje();
            Point punto;
            int posXMatriz, posYMatriz;
            //posiciones anteriores del jugador
            posXMatriz = (Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.X / Controladores.ControladorLaberinto.controlador.LargoCamino) - 3 / 8;
            posYMatriz = (Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.Y / Controladores.ControladorLaberinto.controlador.AnchoCamino) - 3 / 8;
            //sender utiliza Para los movimientos
            //al llamar recursivamente se iran agregando infinitamente.
            if (!repitiendoMovimientos)
                Controladores.ControladorLaberinto.controlador.Jugador.MovimientosEvents.Add(e);
            if (e.KeyCode ==  Controladores.ControladorConfiguraciones.controlador.KeyArribaDef)
            {
                if (posYMatriz - 1 >= 0 && Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz - 1).ElementAt(posXMatriz).BackColor != Color.Gray)
                {
                    punto = new Point(Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.X,
                        Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.Y - (Controladores.ControladorLaberinto.controlador.ConstVel * Controladores.ControladorLaberinto.controlador.AnchoCamino));
                    Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location = punto;
                    if (!repitiendoMovimientos)
                        Controladores.ControladorLaberinto.controlador.Jugador.Movimientos.Add(punto);
                }
            }
            else if (e.KeyCode == Controladores.ControladorConfiguraciones.controlador.KeyAbajoDef)
            {
                if (posYMatriz + 1 < Controladores.ControladorLaberinto.controlador.DimY*2+1 && 
                    Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz + 1).ElementAt(posXMatriz).BackColor != Color.Gray)
                {
                    punto = new Point(Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.X, 
                        Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.Y + (Controladores.ControladorLaberinto.controlador.ConstVel * 
                        Controladores.ControladorLaberinto.controlador.AnchoCamino));
                    Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location = punto;
                    if (!repitiendoMovimientos)
                        Controladores.ControladorLaberinto.controlador.Jugador.Movimientos.Add(punto);
                }
            }
            else if (e.KeyCode == Controladores.ControladorConfiguraciones.controlador.KeyDerDef)
            {
                if (posXMatriz + 1 < Controladores.ControladorLaberinto.controlador.DimX*2 + 1 && 
                    Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz).ElementAt(posXMatriz + 1).BackColor != Color.Gray)
                {
                    punto = new Point(Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.X +
                        (Controladores.ControladorLaberinto.controlador.ConstVel * Controladores.ControladorLaberinto.controlador.LargoCamino),
                        Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.Y);
                    Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location = punto;
                    if (!repitiendoMovimientos)
                        Controladores.ControladorLaberinto.controlador.Jugador.Movimientos.Add(punto);
                }
                else if (posYMatriz + 2 < Controladores.ControladorLaberinto.controlador.DimY*2+1 &&
                    Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz + 2).ElementAt(0).BackColor != Color.Gray)
                {
                    punto = new Point(3 * Controladores.ControladorLaberinto.controlador.LargoCamino / 8, 
                        Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.Y +
                        (Controladores.ControladorLaberinto.controlador.ConstVel * Controladores.ControladorLaberinto.controlador.AnchoCamino) * 2);
                    Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location = punto;
                    if (!repitiendoMovimientos)
                        Controladores.ControladorLaberinto.controlador.Jugador.Movimientos.Add(punto);
                }
            }
            else if (e.KeyCode == Controladores.ControladorConfiguraciones.controlador.KeyIzqDef)
            {
                if (posXMatriz - 1 >= 0 && Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz).ElementAt(posXMatriz - 1).BackColor != Color.Gray)
                {
                    punto = new Point(Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.X - (Controladores.ControladorLaberinto.controlador.ConstVel * Controladores.ControladorLaberinto.controlador.LargoCamino), Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.Y);
                    Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location = punto;
                    if (!repitiendoMovimientos)
                        Controladores.ControladorLaberinto.controlador.Jugador.Movimientos.Add(punto);
                }
                else if(posYMatriz-2 >=0 &&
                    Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz-2).ElementAt(Controladores.ControladorNuevoJuego.controlador.DimX*2).BackColor != Color.Gray)
                {
                    punto = new Point(Controladores.ControladorLaberinto.controlador.ConstVel * Controladores.ControladorLaberinto.controlador.LargoCamino *
                        (Controladores.ControladorNuevoJuego.controlador.DimX * 2) + (3 * Controladores.ControladorLaberinto.controlador.LargoCamino / 8),
                        Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.Y - (Controladores.ControladorLaberinto.controlador.ConstVel *
                        Controladores.ControladorLaberinto.controlador.AnchoCamino)*2);
                    Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location = punto;
                    if(!repitiendoMovimientos)
                        Controladores.ControladorLaberinto.controlador.Jugador.Movimientos.Add(punto);
                }
            }
            //posicion actual del jugador
            posXMatriz = (Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.X / Controladores.ControladorLaberinto.controlador.LargoCamino) - 3 / 8;
            posYMatriz = (Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location.Y / Controladores.ControladorLaberinto.controlador.AnchoCamino) - 3 / 8;

            if (Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz).ElementAt(posXMatriz).BackColor == Color.Orange &&
                Controladores.ControladorLaberinto.controlador.TrofeosRestantes == 0)
            {
                System.Windows.Forms.DialogResult resultado;
                //Has Ganado!!
                
                resultado = System.Windows.Forms.MessageBox.Show("Has ganado!\n¿Deseas ver la repeticion?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (!repitiendoMovimientos)
                {                    
                    if (Controladores.ControladorMainProgram.controlador.Jugador != null)
                    {
                        Servicios.Service1Client servicio = new Servicios.Service1Client();
                        Thread guardarPuntaje = new Thread(() => servicio.UpdatePuntaje(Controladores.ControladorMainProgram.controlador.Jugador.Id,
                                                            Controladores.ControladorLaberinto.controlador.Puntaje));
                        guardarPuntaje.Start();
                    }
                }

                if (resultado == DialogResult.Yes)
                {
                    hacerVisibleTrofeos(Controladores.ControladorNuevoJuego.controlador.RepresentacionLaberinto);
                    repetirMovimientos(Controladores.ControladorLaberinto.controlador.Jugador);
                }
                else if(resultado == DialogResult.No)
                {
                    this.btnRendirse_Click(null, null);
                }
            }
            else if (Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz).ElementAt(posXMatriz).BackColor == Control.DefaultBackColor)
            {
                // verificacion si salió del laberinto, por el color, es decir si el color es control pierde
                System.Windows.Forms.MessageBox.Show("Has perdido!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnRendirse_Click(null, null);
            }
            if (Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz).ElementAt(posXMatriz).BackColor == Color.Red)
            {
                //es trofeo y acabo de pasar por él
                Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(posYMatriz).ElementAt(posXMatriz).BackColor = Color.Brown;
                Controladores.ControladorLaberinto.controlador.TrofeosRestantes--;
            }

        }

        private void repetirMovimientos(Modelos.Jugador jugador)
        {
            //tiempo de espera en miliseguntos
            int tiempoEspera = 200;
            repitiendoMovimientos = true;
            if(jugador!=null){
                Controladores.ControladorLaberinto.controlador.Jugador.Representacion.Location =
                            Controladores.ControladorLaberinto.controlador.Jugador.Movimientos[0];
                foreach (KeyEventArgs eventoMovimiento in Controladores.ControladorLaberinto.controlador.Jugador.MovimientosEvents)
                {
                    // hacer que esto no este en esta fncion
                    LaberintoVista_KeyDown(null, eventoMovimiento);
                    System.Threading.Thread.Sleep(tiempoEspera);

                }
            }
            repitiendoMovimientos = false;
        }

        internal void cargar(ClassLibraryScheme.Laberinto laberinto)
        {
            int lastX = laberinto.Final.x, lastY = laberinto.Final.y, i, j, x, y;
            Point punto;
            Panel aux;
            Controladores.ControladorLaberinto.controlador.DimX = laberinto.DimX;
            Controladores.ControladorLaberinto.controlador.DimY = laberinto.DimY;
            Controladores.ControladorLaberinto.controlador.LargoCamino = panelFondo.Size.Width / (Controladores.ControladorLaberinto.controlador.DimX * 2 + 1);
            Controladores.ControladorLaberinto.controlador.AnchoCamino = panelFondo.Size.Height / (Controladores.ControladorLaberinto.controlador.DimY * 2 + 1);
            bool[][] aniadido = new bool[Controladores.ControladorLaberinto.controlador.DimY*2+1][];
            for (i = 0; i < Controladores.ControladorLaberinto.controlador.DimY*2+1; i++)
                aniadido[i] = new bool[Controladores.ControladorLaberinto.controlador.DimX*2+1];

            for (y = 0; y < Controladores.ControladorLaberinto.controlador.DimY*2+1; y++)
                for (x = 0; x < Controladores.ControladorLaberinto.controlador.DimX*2+1; x++)
                    aniadido[y][x] = false;

            /*=== Inicializacion de matriz del doble mas uno de dimension para simular muros ===*/
            Controladores.ControladorLaberinto.controlador.MatrizPaneles = new List<List<Panel>>(Controladores.ControladorLaberinto.controlador.DimY * 2 + 1);
            for (i = 0; i < (Controladores.ControladorLaberinto.controlador.DimY * 2 + 1); i++)
                Controladores.ControladorLaberinto.controlador.MatrizPaneles.Add(new List<Panel>(Controladores.ControladorLaberinto.controlador.DimX * 2 + 1));

            for (i = 0; i < (Controladores.ControladorLaberinto.controlador.DimY * 2 + 1); i++)
                for (j = 0; j < (Controladores.ControladorLaberinto.controlador.DimX * 2 + 1); j++)
                {
                    Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(i).Add(new Panel());
                    Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(i).ElementAt(j).Size = new Size(Controladores.ControladorLaberinto.controlador.LargoCamino, Controladores.ControladorLaberinto.controlador.AnchoCamino);
                    if (i == 0 || j == 0 || i == Controladores.ControladorLaberinto.controlador.DimY * 2 || j == Controladores.ControladorLaberinto.controlador.DimX * 2)
                    {
                        aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(i).ElementAt(j);
                        punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * j, Controladores.ControladorLaberinto.controlador.AnchoCamino * i);
                        asignarPropiedades(aux, punto);
                        aux.BackColor = Color.Gray;
                        panelFondo.Controls.Add(aux);
                    }
                }
            /*=== Fin inicizializacion ===*/


            this.lblPuntajeEdit.Text = Controladores.ControladorLaberinto.controlador.Puntaje.ToString();

            /* === CREANDO VISUALIZACION DEL LABERINTO === */
            Controladores.ControladorLaberinto.controlador.TrofeosRestantes = 0;
            foreach (ClassLibraryScheme.Vector3 vector in laberinto.laberinto)
            {
                x = vector.x * 2 + 1; //posicion en paneles
                y = vector.y * 2 + 1;
                aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(y).ElementAt(x);
                if (!aniadido[y][x])
                {
                    punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * x, Controladores.ControladorLaberinto.controlador.AnchoCamino * y);
                    asignarPropiedades(aux, punto);
                    panelFondo.Controls.Add(aux);
                    aniadido[y][x] = true;
                }
                if (vector.t != 0)
                {
                    //es trofeo
                    if (aux.BackColor != Color.Red)
                    {
                        aux.BackColor = Color.Red;
                        Controladores.ControladorLaberinto.controlador.TrofeosRestantes++;
                    }
                }
                
                if (lastX < vector.x || lastX > vector.x)
                {
                    //Existe Camino entre camino x-1 <-> x
                    if (lastX < vector.x)
                        i = x - 1;
                    else
                        i = x + 1;
                    if (!aniadido[y][i])
                    {
                        aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(y).ElementAt(i);
                        punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * i, Controladores.ControladorLaberinto.controlador.AnchoCamino * y);
                        asignarPropiedades(aux, punto);
                        panelFondo.Controls.Add(aux);
                        aniadido[y][i] = true;
                    }
                }
                lastX = vector.x;
                if (lastY < vector.y || lastY > vector.y)
                {
                    //Existe Camino entre camino y-1 <-> y
                    if (lastY < vector.y)
                        i = y - 1;
                    else
                        i = y + 1;
                    if (!aniadido[i][x])
                    {
                        aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(i).ElementAt(x);
                        punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * x, Controladores.ControladorLaberinto.controlador.AnchoCamino * i);
                        asignarPropiedades(aux, punto);
                        panelFondo.Controls.Add(aux);
                        aniadido[i][x] = true;
                    }
                }
                lastY = vector.y;

                if (vector.Equals(laberinto.Inicio))
                {
                    i = x;
                    j = y;
                    if (vector.x == 0)
                        i = x - 1;
                    else if (vector.y == 0)
                        j = y - 1;
                    else if (vector.x == Controladores.ControladorLaberinto.controlador.DimX - 1)
                        i = x + 1;
                    else if (vector.y == Controladores.ControladorLaberinto.controlador.DimY - 1)
                        j = y + 1;
                    if (!aniadido[j][i])
                    {
                        aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(j).ElementAt(i);
                        punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * i, Controladores.ControladorLaberinto.controlador.AnchoCamino * j);
                        asignarPropiedades(aux, punto);
                        panelFondo.Controls.Add(aux);
                        aniadido[j][i] = true;
                    }
                    aux.BackColor = Color.Green;
                    agregarJugador(i, j);
                }
                if (vector.Equals(laberinto.Final))
                {
                    i = x;
                    j = y;
                    if (vector.x == 0)
                        i = x - 1;
                    else if (vector.y == 0)
                        j = y - 1;
                    else if (vector.x == Controladores.ControladorLaberinto.controlador.DimX - 1)
                        i = x + 1;
                    else if (vector.y == Controladores.ControladorLaberinto.controlador.DimY - 1)
                        j = y + 1;
                    if (!aniadido[j][i])
                    {
                        aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(j).ElementAt(i);
                        punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * i, Controladores.ControladorLaberinto.controlador.AnchoCamino * j);
                        asignarPropiedades(aux, punto);
                        panelFondo.Controls.Add(aux);
                        aniadido[j][i] = true;
                    }
                    aux.BackColor = Color.Orange;
                }

            }
            /* === FIN CREACION LABERINTO === */

            Controladores.ControladorLaberinto.controlador.Puntaje = Controladores.ControladorLaberinto.controlador.calcularPuntaje();
            this.lblPuntajeEdit.Text = Controladores.ControladorLaberinto.controlador.Puntaje.ToString();

            /*=== AGREGANDO JUGADOR ===*/
            panelFondo.Controls.Add(Controladores.ControladorLaberinto.controlador.Jugador.Representacion);
            Controladores.ControladorLaberinto.controlador.Jugador.Representacion.BringToFront();
            Resources.dll.DLLImport.guardarMapa(true);
            /*=== FIN AGREGACION ===*/
        }

        private void hacerVisibleTrofeos(bool esScheme)
        {
            int x,y;
            Panel aux;
            if (esScheme)
            {
                foreach (ClassLibraryScheme.Vector3 vector in Controladores.ControladorLaberinto.controlador.IronSchemeClass.Laberinto.laberinto)
                {
                    x = vector.x * 2 + 1; //posicion en paneles
                    y = vector.y * 2 + 1;
                    if (vector.t != 0)
                    {
                        //es trofeo
                        aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(y).ElementAt(x);
                        if (aux.BackColor != Color.Red)
                        {
                            aux.BackColor = Color.Red;
                            Controladores.ControladorLaberinto.controlador.TrofeosRestantes++;
                        }
                    }
                }
            }
            else
            {
                foreach (int trofeo in Controladores.ControladorLaberinto.controlador.PrologClass.Laberinto.Trofeos)
                {
                    x = ((trofeo - 1) % Controladores.ControladorLaberinto.controlador.DimX) * 2 + 1; //posicion en paneles
                    y = ((trofeo - 1) / Controladores.ControladorLaberinto.controlador.DimX) * 2 + 1;//es trofeo
                    aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(y).ElementAt(x);
                    aux.BackColor = Color.Red;
                    Controladores.ControladorLaberinto.controlador.TrofeosRestantes++;
                }
            }
        }

        internal void cargar(ClassLibraryProlog.Laberinto laberinto)
        {
            int i, j, x, y,vectorX,vectorY, lastX, lastY;
            Point punto;
            Panel aux;

            this.lblPuntajeEdit.Text = Controladores.ControladorLaberinto.controlador.Puntaje.ToString();

            Controladores.ControladorLaberinto.controlador.DimX = laberinto.DimX;
            Controladores.ControladorLaberinto.controlador.DimY = laberinto.DimY;
            Controladores.ControladorLaberinto.controlador.LargoCamino = panelFondo.Size.Width / (Controladores.ControladorLaberinto.controlador.DimX * 2 + 1);
            Controladores.ControladorLaberinto.controlador.AnchoCamino = panelFondo.Size.Height / (Controladores.ControladorLaberinto.controlador.DimY * 2 + 1);
            bool[][] revisados = new bool[Controladores.ControladorLaberinto.controlador.DimY][];
            for (i = 0; i < Controladores.ControladorLaberinto.controlador.DimY; i++)
                revisados[i] = new bool[Controladores.ControladorLaberinto.controlador.DimX];

            for (y = 0; y < Controladores.ControladorLaberinto.controlador.DimY; y++)
                for (x = 0; x < Controladores.ControladorLaberinto.controlador.DimX; x++)
                    revisados[y][x] = false;

            /*=== Inicializacion de matriz del doble mas uno de dimension para simular muros ===*/
            Controladores.ControladorLaberinto.controlador.MatrizPaneles = new List<List<Panel>>(Controladores.ControladorLaberinto.controlador.DimY * 2 + 1);
            for (i = 0; i < (Controladores.ControladorLaberinto.controlador.DimY * 2 + 1); i++)
                Controladores.ControladorLaberinto.controlador.MatrizPaneles.Add(new List<Panel>(Controladores.ControladorLaberinto.controlador.DimX * 2 + 1));
            for (i = 0; i < (Controladores.ControladorLaberinto.controlador.DimY * 2 + 1); i++)
                for (j = 0; j < (Controladores.ControladorLaberinto.controlador.DimX * 2 + 1); j++)
                {
                    Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(i).Add(new Panel());
                    Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(i).ElementAt(j).Size = new Size(Controladores.ControladorLaberinto.controlador.LargoCamino, Controladores.ControladorLaberinto.controlador.AnchoCamino);
                    if (i == 0 || j == 0 || i == Controladores.ControladorLaberinto.controlador.DimY * 2 || j == Controladores.ControladorLaberinto.controlador.DimX * 2)
                    {
                        aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(i).ElementAt(j);
                        punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * j, Controladores.ControladorLaberinto.controlador.AnchoCamino * i);
                        asignarPropiedades(aux, punto);
                        aux.BackColor = Color.Gray;
                        panelFondo.Controls.Add(aux);
                    }
                }
            /*=== Fin inicizializacion ===*/

            /* === CREANDO VISUALIZACION DEL LABERINTO === */
            lastX = (int)((laberinto.Final - 1) % Controladores.ControladorLaberinto.controlador.DimX);
            lastY = (int)((laberinto.Final - 1) / Controladores.ControladorLaberinto.controlador.DimX);
            foreach (int posicion in laberinto.laberinto)
            {
                vectorX = (int)((posicion - 1) % Controladores.ControladorLaberinto.controlador.DimX);
                //Para obtener la coordenada y se debe eliminar la coordenada x diviendo por su dimension
                vectorY = (int)((posicion - 1) / Controladores.ControladorLaberinto.controlador.DimX);
                x = vectorX * 2 + 1; //posicion en paneles
                y = vectorY * 2 + 1;
                if (!revisados[vectorY][vectorX])
                {
                    revisados[vectorY][vectorX] = true;
                    if (lastX < vectorX || lastX > vectorX)
                    {
                        //Existe Camino entre camino x-1 <-> x
                        if (lastX < vectorX)
                            i = x - 1;
                        else if(lastX > vectorX)
                            i = x + 1;
                        if (lastX != vectorX)
                        {
                            aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(y).ElementAt(i);
                            punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * i, Controladores.ControladorLaberinto.controlador.AnchoCamino * y);
                            asignarPropiedades(aux, punto);
                            panelFondo.Controls.Add(aux);
                        }
                    }
                    if (lastY < vectorY || lastY > vectorY)
                    {
                        //Existe Camino entre camino y-1 <-> y
                        if (lastY < vectorY)
                            i = y - 1;
                        else if (lastY > vectorY)
                            i = y + 1;
                        if (lastY != vectorY)
                        {
                            aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(i).ElementAt(x);
                            punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * x, Controladores.ControladorLaberinto.controlador.AnchoCamino * i);
                            asignarPropiedades(aux, punto);
                            panelFondo.Controls.Add(aux);
                        }
                    }
                    if (lastX != vectorX && lastY != vectorY)
                    {
                        if (lastX > vectorX)
                            i = Controladores.ControladorLaberinto.controlador.DimX*2;
                        else if (lastX < vectorX)
                            i = 0;
                        //=== posicion anterior ===//
                        if (lastX != vectorX)
                        {
                            aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(lastY * 2 + 1).ElementAt(i);
                            punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * (i), Controladores.ControladorLaberinto.controlador.AnchoCamino * (lastY * 2 + 1));
                            asignarPropiedades(aux, punto);
                            panelFondo.Controls.Add(aux);
                        }
                        //=== posicion actual ===//
                        if (lastX > vectorX)
                            i = 0;
                        else if (lastX < vectorX)
                            i = Controladores.ControladorLaberinto.controlador.DimX*2;
                        if (lastX != vectorX)
                        {
                            aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(y).ElementAt(i);
                            punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * (i), Controladores.ControladorLaberinto.controlador.AnchoCamino * (y));
                            asignarPropiedades(aux, punto);
                            panelFondo.Controls.Add(aux);
                        }
                    }
                    aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(y).ElementAt(x);
                    punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * x, Controladores.ControladorLaberinto.controlador.AnchoCamino * y);
                    lastX = vectorX;
                    lastY = vectorY;
                    asignarPropiedades(aux, punto);
                    panelFondo.Controls.Add(aux);
            
                }
                if (posicion == laberinto.Inicio)
                {
                    i = x;
                    j = y;
                    if (vectorX == 0)
                        i = x - 1;
                    else if (vectorY == 0)
                        j = y - 1;
                    else if (vectorX == Controladores.ControladorLaberinto.controlador.DimX-1)
                        i = x + 1;
                    else if (vectorY == Controladores.ControladorLaberinto.controlador.DimY-1)
                        j = y + 1;
                    aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(j).ElementAt(i);
                    punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * i, Controladores.ControladorLaberinto.controlador.AnchoCamino * j);
                    asignarPropiedades(aux, punto);
                    aux.BackColor = Color.Green;
                    panelFondo.Controls.Add(aux);
                    agregarJugador(i, j);
                }
                if (posicion==laberinto.Final)
                {
                    i = x;
                    j = y;
                    if (vectorY == 0)
                        j = y - 1;
                    else if (vectorY == Controladores.ControladorLaberinto.controlador.DimY-1)
                        j = y + 1;
                    aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(j).ElementAt(i);
                    punto = new Point(Controladores.ControladorLaberinto.controlador.LargoCamino * i, Controladores.ControladorLaberinto.controlador.AnchoCamino * j);
                    asignarPropiedades(aux, punto);
                    aux.BackColor = Color.Orange;
                    panelFondo.Controls.Add(aux);
                }
            }
            /* === FIN CREACION LABERINTO === */
            Controladores.ControladorLaberinto.controlador.TrofeosRestantes = 0;
            foreach (int trofeo in laberinto.Trofeos)
            {
                vectorX = (trofeo - 1) % Controladores.ControladorLaberinto.controlador.DimX;
                vectorY = (trofeo - 1) / Controladores.ControladorLaberinto.controlador.DimX;
                x = vectorX * 2 + 1; //posicion en paneles
                y = vectorY * 2 + 1;//es trofeo
                if (trofeo != Controladores.ControladorLaberinto.controlador.PrologClass.Laberinto.Inicio &&
                    trofeo != Controladores.ControladorLaberinto.controlador.PrologClass.Laberinto.Final)
                {
                    aux = Controladores.ControladorLaberinto.controlador.MatrizPaneles.ElementAt(y).ElementAt(x);
                    aux.BackColor = Color.Red;
                    Controladores.ControladorLaberinto.controlador.TrofeosRestantes++;
                }
            }

            Controladores.ControladorLaberinto.controlador.Puntaje = Controladores.ControladorLaberinto.controlador.calcularPuntaje();
            this.lblPuntajeEdit.Text = Controladores.ControladorLaberinto.controlador.Puntaje.ToString();

            /*=== AGREGANDO JUGADOR ===*/
            panelFondo.Controls.Add(Controladores.ControladorLaberinto.controlador.Jugador.Representacion);
            Controladores.ControladorLaberinto.controlador.Jugador.Representacion.BringToFront();
            Resources.dll.DLLImport.guardarMapa(false);
            /*=== FIN AGREGACION ===*/
        }

        private void btnRendirse_Click(object sender, EventArgs e)
        {
            Controladores.ControladorLaberinto.setVisible(false);
            Controladores.ControladorNuevoJuego.setVisible(true);
            Controladores.ControladorLaberinto.controlador.Jugador = null;
            panelFondo.Controls.Clear();
        }

        private void VistaLaberinto_Activated(object sender, EventArgs e)
        {
            actualizarPuntaje();
        }
    
    }
}
