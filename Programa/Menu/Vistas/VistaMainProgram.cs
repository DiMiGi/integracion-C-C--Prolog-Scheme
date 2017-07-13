using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryScheme;
using System.Threading;





namespace Menu.Vistas
{
    public partial class VistaMainProgram : Form
    {
        private bool fuePresionado = false;

        public VistaMainProgram()
        {
            InitializeComponent();
            pnlConectado.Visible = true;
            pnlDesconectado.Visible = true;
            pnlDesconectado.BringToFront();
        }

        public String getNombreUsuario(){
            return this.lblUsuarioEditar.Text;
        }

        private void SalirClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoJuegoClick(object sender, EventArgs e)
        {
            Controladores.ControladorNuevoJuego.setVisible(true);
            this.Visible = false;
        }

        private void CargarHistorialClick(object sender, EventArgs e)
        {
            if (Controladores.ControladorNuevoJuego.controlador.RepresentacionLaberinto)
            {
                //cargar de scheme

            }
            else
            {
                // cargar de prolog


            }
        }

        private void btnCargarJuego_Click(object sender, EventArgs e)
        {
            Controladores.ControladorCargarJuego.Run();
            this.Visible = false;
        }

        private void ConfiguracionesClick(object sender, EventArgs e)
        {
            Controladores.ControladorConfiguraciones.Run();
            this.Visible = false;
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            int idUsuario,idJugador;
            Servicios.Service1Client servicio = new Servicios.Service1Client();
            idUsuario = servicio.GetIdUsuario(TxtUsuario.Text);
            if (idUsuario == -1)
            {
                //personaje no existe
                MessageBox.Show("El usuario ingresado no existe, vuelva a intentarlo.", "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtContrasenia.Text.Equals(servicio.GetPassUsuarioId(idUsuario)))
                {
                    //contraseña correcta(Instanciar Jugador)
                    idJugador = servicio.GetIdJugadorId(idUsuario);
                    Controladores.ControladorMainProgram.controlador.instanciarJugador(idJugador, TxtUsuario.Text, servicio.GetNombreJugador(idJugador), servicio.GetVidaJugadorId(idJugador), servicio.GetPuntajeJugadorId(idJugador));

                    //========//
                    lblUsuarioEditar.Text = Controladores.ControladorMainProgram.controlador.Jugador.NombreUsuario;
                    lblVidaEditar.Text = Controladores.ControladorMainProgram.controlador.Jugador.Vida.ToString();
                    lblMejorPuntajeEditar.Text = Controladores.ControladorMainProgram.controlador.Jugador.Puntaje.ToString();

                    pnlConectado.BringToFront();

                    MessageBox.Show("Bienvenido " + TxtUsuario.Text + ", se ha logrado conectar a su cuenta, ¡ahora podra guardar sus logros y trofeos!.", "Conexion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Contraseñas incorrectas
                    MessageBox.Show("Contraseña no coincide con el usuario ingresado, vuelva a intentarlo.", "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            Controladores.ControladorCrearUsuario.Run();
            Controladores.ControladorMainProgram.setVisible(false);
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !fuePresionado)
            {
                Conectar_Click(null, null);
                fuePresionado = true;
            }

        }

        private void TxtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !fuePresionado)
            {
                Conectar_Click(null, null);
                fuePresionado = true;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Controladores.ControladorMainProgram.controlador.Jugador = null;
            
            pnlDesconectado.BringToFront();
        }

        

        
    }
}
